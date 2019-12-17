Imports Ionic.Utils.Zip
Public Class frmmain
    Dim zip As ZipFile
    Dim fileinzip As ZipEntry
    Dim tmpdir As String = System.IO.Path.GetTempPath

    Private Sub OpenGameFromMenu(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Dim res As Windows.Forms.DialogResult
        zip = Nothing
        fileinzip = Nothing

        res = openfiledlg.ShowDialog()
        If res = Windows.Forms.DialogResult.Cancel Then Exit Sub
        RetrieveManifestInfo(openfiledlg.FileName)
        GetFileList(openfiledlg.FileName)
    End Sub

    Private Sub GetFileList(ByVal jarfile As String)
        zip = Nothing
        zip = ZipFile.Read(jarfile)
        Dim ismediafile As Boolean = False
        Dim nonextensionfile As Boolean = False
        Dim embedmediafile As Boolean = False
        For Each x As ZipEntry In zip
            With x.FileName
                If .EndsWith("mid") Or .EndsWith("midi") Or .EndsWith("png") Or .EndsWith("amr") Or .EndsWith("jpg") Or .EndsWith("mp3") Or .EndsWith("wav") Then ismediafile = True
                If .Contains(".") = False And .EndsWith("/") = False Then nonextensionfile = True
                If ismediafile = False And (.EndsWith("class") = False And .EndsWith("MF") = False And .EndsWith("/") = False) Then embedmediafile = True


                If ismediafile = True Then lstsimple.Items.Add(x.FileName)
                If nonextensionfile = True Or embedmediafile = True Then lsthardcore.Items.Add(x.FileName)
            End With
            ismediafile = False
            nonextensionfile = False
            embedmediafile = False
        Next
    End Sub

    Private Sub ClearDetails()
        lblappname.Text = Nothing
        lbldatasize.Text = Nothing
        lblappver.Text = Nothing
        lblprofile.Text = Nothing
        lbldesc.Text = Nothing
        lblconfig.Text = Nothing
        lblvendor.Text = Nothing
        lblperm.Text = Nothing
        lblcreatedby.Text = Nothing
        picappicon.Image = picappicon.InitialImage
        lstsimple.Items.Clear()
        'lbldumpdir.Text = Nothing
        lsthardcore.Items.Clear()
    End Sub

    Private Sub IconExtract(ByVal iconame As String)
        Dim iconpath As String
        Dim tick As Integer
        'Dim iconfile As New ZipEntry
        ' Change for each loop to zip.Item(iconame) later        
        If iconame.Length >= 1 Then
            If Not ((Asc(iconame.Chars(iconame.Length - 1)) >= 65 And Asc(iconame.Chars(iconame.Length - 1)) <= 90) Or (Asc(iconame.Chars(iconame.Length - 1)) >= 97 And Asc(iconame.Chars(iconame.Length - 1)) <= 122)) Then iconame = iconame.Remove(iconame.Length - 1, 1)

            'iconpath = tmpdir & "\" & Trim(iconame)
            iconpath = System.IO.Path.Combine(tmpdir, Trim(iconame))
            For Each iconfile As ZipEntry In zip
                If iconfile.FileName = Trim(iconame) Then
                    If System.IO.File.Exists(iconpath) = True Then
                        tick = System.Environment.TickCount ' Set tick
                        iconfile.ExtractAs(tmpdir, tick.ToString & iconame, Nothing)
                        iconpath = System.IO.Path.Combine(tmpdir, tick.ToString & iconame)
                    Else
                        iconfile.Extract(tmpdir)
                    End If
                    Exit For
                End If
            Next
            Try
                picappicon.Image = System.Drawing.Image.FromFile(iconpath)
            Catch x As OutOfMemoryException
                MessageBox.Show("Cannot Allocate Space for Icon File. Invalid Format", x.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch y As Exception
                MessageBox.Show(y.Message & " File not Found in Archive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        ClearDetails()
        lbldumpdir.Text = Nothing
    End Sub

    Private Sub RetrieveManifestInfo(ByVal jarfilepath As String)
        Dim contents, elements() As String
        Dim tmp1 As String = ""
        Dim tmp() As String = {"", "", ""}
        Dim icontag As Boolean = False
        zip = ZipFile.Read(jarfilepath)
        'DeleteFile(tmpdir & "\" & "META-INF\MANIFEST.MF")
        DeleteFile(System.IO.Path.Combine(tmpdir, "META-INF\MANIFEST.MF"))
        fileinzip = zip.Item("META-INF/MANIFEST.MF")
        fileinzip.Extract(tmpdir)



        'contents = FileIO.FileSystem.ReadAllText(tmpdir & "\" & "META-INF\MANIFEST.MF")
        contents = FileIO.FileSystem.ReadAllText(System.IO.Path.Combine(tmpdir, "META-INF\MANIFEST.MF"))

        elements = Split(contents, vbLf)

        ClearDetails()
        For Each x As String In elements
            If String.IsNullOrEmpty(x) = False Then tmp = Split(x, ":") Else Exit For
            If x.StartsWith("MIDlet-Name") Then lblappname.Text = tmp(1)
            If x.StartsWith("MIDlet-Version") Then lblappver.Text = tmp(1)
            If x.StartsWith("MIDlet-Vendor") Then lblvendor.Text = tmp(1)
            If x.StartsWith("MIDlet-Data-Size") Then lbldatasize.Text = tmp(1)
            If x.StartsWith("MicroEdition-Profile") Then lblprofile.Text = tmp(1)
            If x.StartsWith("MicroEdition-Configuration") Then lblconfig.Text = tmp(1)
            If x.StartsWith("Created-By") Then lblcreatedby.Text = tmp(1)
            If x.StartsWith("MIDlet-Description") Then lbldesc.Text = tmp(1)
            If x.StartsWith("MIDlet-Permissions") Then lblperm.Text = tmp(1)

            If x.StartsWith("MIDlet-Icon") Then
                If Trim(tmp(1)).StartsWith("/") Then IconExtract(Trim(tmp(1)).Remove(0, 1)) Else IconExtract(Trim(tmp(1)))
                icontag = True
            End If
            If x.StartsWith("MIDlet-1") Then
                tmp = Split(tmp(1), ",")
                If Trim(tmp(1)).StartsWith("/") Then tmp1 = Trim(tmp(1)).Remove(0, 1) Else tmp1 = Trim(tmp(1))
            End If
        Next
        If icontag = False Then IconExtract(Trim(tmp1))

    End Sub


    Private Sub frmmain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        zip = Nothing
        fileinzip = Nothing 'hey
        'Dim abc As Byte() = {65, 66, 67}
        'MsgBox(BytesToHexString(abc))
        'End
        'folderbrowser.ShowDialog()
        'End
    End Sub

    Private Sub DeleteFile(ByVal filename As String)
        If IO.File.Exists(filename) = True Then IO.File.Delete(filename)
    End Sub

    
    Private Sub btnseldir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnseldir.Click
        Dim res As Windows.Forms.DialogResult
        res = folderbrowser.ShowDialog()
        If res = Windows.Forms.DialogResult.Cancel Then lbldumpdir.Text = Nothing : Exit Sub
        lbldumpdir.Text = folderbrowser.SelectedPath
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim res As Windows.Forms.DialogResult
        res = MessageBox.Show("Do you really want to Quit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = Windows.Forms.DialogResult.Yes Then End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("CHANGES FROM VERSION 2.0" & vbNewLine & "1) Support for WAV Format" & vbNewLine & _
            "2) Choose Extension Combinations for Extraction" & vbNewLine & _
            "3) Slightly Faster Hardcore Extract" & vbNewLine & vbNewLine & vbNewLine & _
            "Written By Sanchit Karve (born2c0de)" & vbNewLine & "Contact Me : born2c0de@dreamincode.net", "About J2MEdia Xtractor 2.5", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnsimple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimple.Click
        Dim simple As ZipEntry
        Dim c As Integer = 0
        prgsimple.Value = 0
        If String.IsNullOrEmpty(lbldumpdir.Text) = True Then
            MessageBox.Show("Select a Dump Directory", "Cannot Extract Files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        For Each x As String In lstsimple.Items
            System.Windows.Forms.Application.DoEvents()
            simple = zip.Item(Trim(x))
            simple.Extract(lbldumpdir.Text)
            c = c + 1
            prgsimple.Value = Int(((c * 100) / lstsimple.Items.Count))
        Next
        MessageBox.Show(lstsimple.Items.Count.ToString & " Items Extracted.", "Simple Extract Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
        prgsimple.Value = 0
    End Sub

    Private Sub btnhardcore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhardcore.Click
        Dim hardcore As ZipEntry
        Dim count As Integer = 0
        Dim strtotalfiles As String = ""

        If String.IsNullOrEmpty(lbldumpdir.Text) = True Then
            MessageBox.Show("Select a Dump Directory", "Cannot Extract Files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        For Each x As String In lsthardcore.Items
            hardcore = zip.Item(Trim(x))
            'Prevents File Already Present Exception + Increases Speed as file is not copied again.
            If IO.File.Exists(IO.Path.Combine(lbldumpdir.Text, hardcore.FileName)) = False Then hardcore.Extract(lbldumpdir.Text)

            count = count + 1
            strtotalfiles &= x & " = " & ExtractEmbeddedMedia(System.IO.Path.Combine(lbldumpdir.Text, Trim(x)), lbldumpdir.Text).ToString() & " Embedded Files" + vbNewLine
            prghardcore.Value = (count * 100) / lsthardcore.Items.Count
        Next
        MessageBox.Show(strtotalfiles, "Hardcore Extract Performed on " & lsthardcore.Items.Count.ToString & " Files.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        prghardcore.Value = 0
    End Sub

    Private Function ExtractEmbeddedMedia(ByVal filepath As String, ByVal dumpdir As String) As Integer
        ' Ensure count is shown only for non-zero media-embedded files
        Dim count As Integer = 0
        Dim final As String = ""
        ' Count is not shown properly
        If chkpng.Checked = True Then count = ExtractEmbedPNG(filepath, dumpdir)
        If chkmidi.Checked = True Then count += ExtractEmbedMID(filepath, dumpdir)
        If chkwav.Checked = True Then count += ExtractEmbedWAV(filepath, dumpdir)
        Return count
    End Function

    Private Function BytesToHexString(ByVal arr As System.Array) As String
        Dim finalstr As String = ""
        Dim i As Integer
        If System.Type.GetTypeCode(arr(0).GetType()) <> TypeCode.Byte Then MsgBox("Value is not of Byte Type", MsgBoxStyle.Critical, "BUG FOUND")
        For i = 0 To (arr.Length - 1)
            If Hex(arr(i)).Length <> 2 Then finalstr = finalstr & "0"
            finalstr = finalstr & Hex(arr(i))
        Next
        Return finalstr
    End Function

    Private Function ExtractEmbedPNG(ByVal filepath As String, ByVal dumpdir As String) As Integer
        Dim filefs As System.IO.FileStream
        Dim mediafs As System.IO.FileStream
        Dim br As System.IO.BinaryReader
        Dim bw As System.IO.BinaryWriter
        Dim fpos As Long
        Dim tmpbytes() As Byte = Nothing
        Dim tmpstr As String
        Dim mediafilename As String
        Dim count As Integer = 0
        Dim sigPNG() As String = {"89504E470D0A1A0A0000000D49484452", "0000000049454E44AE426082"}

        filefs = New System.IO.FileStream(filepath, IO.FileMode.Open)
        br = New System.IO.BinaryReader(filefs)
        If br.BaseStream.Length <= (sigPNG(0).Length / 2) Then
            br.Close()
            Return count 'File too small to contain even one PNG File. Return 0
        End If

        For fpos = 0 To (br.BaseStream.Length - 1)
            System.Windows.Forms.Application.DoEvents()
            br.BaseStream.Seek(fpos, IO.SeekOrigin.Begin)

            Try
                tmpbytes = br.ReadBytes(sigPNG(0).Length / 2)
            Catch e As Exception
            End Try
            br.BaseStream.Seek(-(sigPNG(0).Length / 2), IO.SeekOrigin.Current)
            tmpstr = BytesToHexString(tmpbytes)
            If tmpstr = sigPNG(0) Then
                'PNG SIG FOUND
                mediafilename = System.IO.Path.GetFileNameWithoutExtension(filepath) & "_" & Hex(fpos) & ".png"
                'If IO.File.Exists(System.IO.Path.Combine(dumpdir, mediafilename)) = True Then Continue For
                mediafs = New System.IO.FileStream(System.IO.Path.Combine(dumpdir, mediafilename), IO.FileMode.CreateNew)
                bw = New System.IO.BinaryWriter(mediafs)
                tmpbytes = Nothing
                tmpstr = Nothing
                While True
                    tmpbytes = br.ReadBytes(sigPNG(1).Length / 2)
                    br.BaseStream.Seek(-(sigPNG(1).Length / 2), IO.SeekOrigin.Current)
                    tmpstr = BytesToHexString(tmpbytes)

                    If tmpstr <> sigPNG(1) Then
                        ' Try to Find a Faster Algorithm
                        ' which would be
                        ' Put all File Data into An Array and Perform Search Operation on Array
                        bw.Write(br.ReadByte())
                    Else
                        ' if EOF Sig is present, then add eof sig bytes and close file
                        bw.Write(br.ReadBytes(sigPNG(1).Length / 2))
                        Exit While
                    End If
                End While
                'EXTRACT PNG FILE  until sigmid(1) is encountered
                bw.Close()
                fpos = br.BaseStream.Position - 1
                count = count + 1
                'Set fpos to position after EOF of PNG FILE
            End If
        Next
        br.Close()
        Return count
    End Function

    Private Function ExtractEmbedMID(ByVal filepath As String, ByVal dumpdir As String) As Integer
        Dim filefs As System.IO.FileStream
        Dim mediafs As System.IO.FileStream
        Dim br As System.IO.BinaryReader
        Dim bw As System.IO.BinaryWriter
        Dim fpos As Long
        'Dim shiftpos As Long
        Dim tmpbytes() As Byte = Nothing
        Dim tmpstr As String
        Dim mediafilename As String
        Dim count As Integer = 0
        Dim sigmidi() As String = {"4D546864", "00FF2F00"}

        filefs = New System.IO.FileStream(filepath, IO.FileMode.Open)
        br = New System.IO.BinaryReader(filefs)
        If br.BaseStream.Length <= (sigmidi(0).Length / 2) Then
            br.Close()
            Return count 'File too small to contain even one PNG File. Return 0
        End If

        For fpos = 0 To (br.BaseStream.Length - 1)
            System.Windows.Forms.Application.DoEvents()
            br.BaseStream.Seek(fpos, IO.SeekOrigin.Begin)

            Try
                tmpbytes = br.ReadBytes(sigmidi(0).Length / 2)
            Catch e As Exception
            End Try
            br.BaseStream.Seek(-(sigmidi(0).Length / 2), IO.SeekOrigin.Current)
            tmpstr = BytesToHexString(tmpbytes)

            If tmpstr = sigmidi(0) Then
                'MID SIG FOUND
                mediafilename = System.IO.Path.GetFileNameWithoutExtension(filepath) & "_" & Hex(fpos) & ".mid"
                'If IO.File.Exists(System.IO.Path.Combine(dumpdir, mediafilename)) = True Then Continue For
                mediafs = New System.IO.FileStream(System.IO.Path.Combine(dumpdir, mediafilename), IO.FileMode.CreateNew)
                bw = New System.IO.BinaryWriter(mediafs)
                tmpbytes = Nothing
                tmpstr = Nothing
                While True
                    tmpbytes = br.ReadBytes(sigmidi(1).Length / 2)
                    br.BaseStream.Seek(-(sigmidi(1).Length / 2), IO.SeekOrigin.Current)
                    tmpstr = BytesToHexString(tmpbytes)
                    If tmpstr <> sigmidi(1) Then
                        ' Put all File Data into An Array and Perform Search Operation on Array
                        bw.Write(br.ReadByte())
                    Else
                        ' if EOF Sig is present, then add eof sig bytes and close file
                        bw.Write(br.ReadBytes(sigmidi(1).Length / 2))
                        Exit While
                    End If
                End While
                'EXTRACT PNG FILE  until sigmid(1) is encountered
                bw.Close()
                fpos = br.BaseStream.Position - 1
                count = count + 1
                'Set fpos to position after EOF of PNG FILE
            End If
        Next
        br.Close()
        Return count
    End Function

    Private Function ExtractEmbedWAV(ByVal filepath As String, ByVal dumpdir As String) As Integer
        Dim filefs As System.IO.FileStream
        Dim mediafs As System.IO.FileStream
        Dim br As System.IO.BinaryReader
        Dim bw As System.IO.BinaryWriter
        Dim chunklength As Int32
        Dim fpos As Long
        'Dim shiftpos As Long
        Dim tmpbytes() As Byte = Nothing
        Dim tmpstr As String
        Dim mediafilename As String
        Dim count As Integer = 0
        Dim i As Int32
        Dim sigmidi As String = "52494646"

        filefs = New System.IO.FileStream(filepath, IO.FileMode.Open)
        br = New System.IO.BinaryReader(filefs)
        If br.BaseStream.Length <= (sigmidi.Length / 2) Then
            br.Close()
            Return count 'File too small to contain even one PNG File. Return 0
        End If

        For fpos = 0 To (br.BaseStream.Length - 1)
            System.Windows.Forms.Application.DoEvents()
            br.BaseStream.Seek(fpos, IO.SeekOrigin.Begin)

            Try
                tmpbytes = br.ReadBytes(sigmidi.Length / 2)
            Catch e As Exception
            End Try
            br.BaseStream.Seek(-(sigmidi.Length / 2), IO.SeekOrigin.Current)
            tmpstr = BytesToHexString(tmpbytes)

            If tmpstr = sigmidi Then
                'WAV SIG FOUND
                mediafilename = System.IO.Path.GetFileNameWithoutExtension(filepath) & "_" & Hex(fpos) & ".wav"
                'If IO.File.Exists(System.IO.Path.Combine(dumpdir, mediafilename)) = True Then Continue For
                mediafs = New System.IO.FileStream(System.IO.Path.Combine(dumpdir, mediafilename), IO.FileMode.CreateNew)
                bw = New System.IO.BinaryWriter(mediafs)
                tmpbytes = Nothing
                tmpstr = Nothing
                chunklength = 0


                bw.Write(br.ReadInt32()) ' Writes WAV Signature i.e. RIFF
                chunklength = br.ReadInt32()
                bw.Write(chunklength)
                'Optimized for Speed
                For i = 0 To chunklength - 1
                    bw.Write(br.ReadByte())
                Next i



                'EXTRACT PNG FILE  until sigmid(1) is encountered
                bw.Close()
                fpos = br.BaseStream.Position - 1
                count = count + 1
                'Set fpos to position after EOF of PNG FILE
            End If
        Next
        br.Close()
        Return count
        MsgBox("Hey")
    End Function

    Public Function BEInt32(f As System.IO.BinaryReader) As UInt32
        Dim data = f.ReadBytes(4)
        Array.Reverse(data)
        Return BitConverter.ToUInt32(data, 0)
    End Function

    Public Function BEInt64(f As System.IO.BinaryReader) As UInt64
        Dim data = f.ReadBytes(8)
        Array.Reverse(data)
        Return BitConverter.ToUInt64(data, 0)
    End Function

    Public Function BEInt16(f As System.IO.BinaryReader) As UInt16
        Dim data = f.ReadBytes(2)
        Array.Reverse(data)
        Return BitConverter.ToUInt16(data, 0)
    End Function



    Private Function ExtractPAKFile(ByVal filepath As String, ByVal dumpdir As String) As Integer
        Dim filefs As System.IO.FileStream
        Dim mediafs As System.IO.FileStream
        Dim br As System.IO.BinaryReader
        Dim bw As System.IO.BinaryWriter
        Dim fpos As Long
        'Dim shiftpos As Long
        Dim tmpbytes() As Byte = Nothing
        Dim tmpstr As String
        Dim mediafilename As String
        Dim count As Integer = 0
        Dim sigmidi() As String = {"4D546864", "00FF2F00"}
        ' PAK file format appears to be:
        ' 08 bytes: {8 byte checksum}
        ' 02 bytes: Size of embedded file
        ' 
        Dim embedFiles As Dictionary(Of UInt32, UInt16) = New Dictionary(Of UInteger, UShort)
        Dim fPak As System.IO.BinaryReader
        fPak = New System.IO.BinaryReader(System.IO.File.Open(filepath, IO.FileMode.Open))
        Dim fSize = fPak.BaseStream.Length
        Dim pos = 0

        ' First 6 bytes appear to be a checksum
        Dim totalElements = BEInt16(fPak)
        pos += 2
        Dim checksum = BEInt32(fPak)
        pos += 4
        Dim embed_location = BEInt32(fPak)
        pos += 4
        Dim embed_size = BEInt32(fPak)
        pos += 4

        fSize = embed_location
        embedFiles.Add(embed_location, embed_size)
        While pos < fSize
            checksum = BEInt32(fPak)
            pos += 4
            embed_location = BEInt32(fPak)
            pos += 4
            embed_size = BEInt32(fPak)
            pos += 4
            Try
                Debug.WriteLine(Hex(fPak.BaseStream.Position) + ": " + Hex(embed_location) + "-->" + Hex(embed_size))
                embedFiles.Add(embed_location, embed_size)
            Catch e As Exception
                Exit While
            End Try

        End While
        Dim counter As Integer
        For Each kvp As KeyValuePair(Of UInt32, UInt16) In embedFiles
            fPak.BaseStream.Seek(kvp.Key, IO.SeekOrigin.Begin)
            Dim embedData = fPak.ReadBytes(kvp.Value)
            System.IO.File.WriteAllBytes(System.IO.Path.Combine(dumpdir, kvp.Key.ToString()), embedData)
            counter += 1
        Next
        Return counter

    End Function

    Private Sub btnExtractAll_Click(sender As Object, e As EventArgs) Handles btnExtractAll.Click
        Dim currentFileInZip As ZipEntry
        Dim count As Integer = 0
        Dim strtotalfiles As String = ""

        If String.IsNullOrEmpty(lbldumpdir.Text) = True Then
            MessageBox.Show("Select a Dump Directory", "Cannot Extract Files", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        For Each x As String In lsthardcore.Items
            currentFileInZip = zip.Item(Trim(x))
            If currentFileInZip.FileName.EndsWith(".pak") Then
                If Not IO.File.Exists(IO.Path.Combine(lbldumpdir.Text, currentFileInZip.FileName)) Then currentFileInZip.Extract(lbldumpdir.Text)
                strtotalfiles &= x & " = " & ExtractPAKFile(System.IO.Path.Combine(lbldumpdir.Text, Trim(x)), lbldumpdir.Text).ToString() & " Embedded Files" + vbNewLine



            End If
            'Prevents File Already Present Exception + Increases Speed as file is not copied again.



            count = count + 1

            prghardcore.Value = (count * 100) / lsthardcore.Items.Count
        Next
        MessageBox.Show(strtotalfiles, "Hardcore Extract Performed on " & lsthardcore.Items.Count.ToString & " Files.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        prghardcore.Value = 0
    End Sub
End Class
