Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim bytes As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                bytes.Compress()
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, bytes.ToArray())
                MessageBox.Show("ok")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim bytes As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                bytes.Uncompress()
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, bytes.ToArray())
                MessageBox.Show("ok")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim bytes As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                bytes.Compress(CompressionAlgorithm.Deflate)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, bytes.ToArray())
                MessageBox.Show("ok")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim bytes As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                bytes.Uncompress(CompressionAlgorithm.Deflate)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, bytes.ToArray())
                MessageBox.Show("ok")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim bytes As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                bytes.Compress(CompressionAlgorithm.LZMA)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, bytes.ToArray())
                MessageBox.Show("ok")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim bytes As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                bytes.Uncompress(CompressionAlgorithm.LZMA)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, bytes.ToArray())
                MessageBox.Show("ok")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            OpenFileDialog1.Filter = "Flash File (*.swf)|*.swf|All Files (*.*)|*.*"
            SaveFileDialog1.Filter = "Flash File (*.swf)|*.swf|All Files (*.*)|*.*"

            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim bytes As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim header As ByteArray = New ByteArray()
                header.WriteBytes(bytes, 3, 5)
                Dim body As ByteArray = New ByteArray()
                body.WriteBytes(bytes, 8)
                body.Compress(CompressionAlgorithm.Zlib)
                Dim buffer As ByteArray = New ByteArray()
                buffer.WriteMultiByte("CWS", "us-ascii")
                buffer.WriteBytes(header)
                buffer.WriteBytes(body)
                Dim data As Byte() = buffer.ToArray()
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, data)

                MessageBox.Show("ok")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            OpenFileDialog1.Filter = "Flash File (*.swf)|*.swf|All Files (*.*)|*.*"
            SaveFileDialog1.Filter = "Flash File (*.swf)|*.swf|All Files (*.*)|*.*"

            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim bytes As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim header As ByteArray = New ByteArray()
                header.WriteBytes(bytes, 3, 5)
                Dim body As ByteArray = New ByteArray()
                body.WriteBytes(bytes, 8)
                body.Uncompress(CompressionAlgorithm.Zlib)
                Dim buffer As ByteArray = New ByteArray()
                buffer.WriteMultiByte("FWS", "us-ascii")
                buffer.WriteBytes(header)
                buffer.WriteBytes(body)
                Dim data As Byte() = buffer.ToArray()
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, data)

                MessageBox.Show("ok")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            OpenFileDialog1.Filter = "Flash File (*.swf)|*.swf|All Files (*.*)|*.*"
            SaveFileDialog1.Filter = "Flash File (*.swf)|*.swf|All Files (*.*)|*.*"

            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim bytes As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim header As ByteArray = New ByteArray()
                header.WriteBytes(bytes, 3, 5)
                Dim body As ByteArray = New ByteArray()
                body.WriteBytes(bytes, 8)
                body.Compress(CompressionAlgorithm.LZMA)
                Dim compressedLen As Long = body.BytesAvailable
                Dim lzmaprops As ByteArray = New ByteArray()
                lzmaprops.WriteBytes(body, 0, 3)
                Dim data As ByteArray = New ByteArray()
                data.WriteBytes(body, 12)

                Dim buffer As ByteArray = New ByteArray()
                buffer.WriteMultiByte("ZWS", "us-ascii")
                buffer.WriteBytes(header)
                buffer.WriteByte(compressedLen)
                buffer.WriteBytes(lzmaprops)
                buffer.WriteBytes(data)

                IO.File.WriteAllBytes(SaveFileDialog1.FileName, buffer.ToArray())

                MessageBox.Show("ok")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            OpenFileDialog1.Filter = "Flash File (*.swf)|*.swf|All Files (*.*)|*.*"
            SaveFileDialog1.Filter = "Flash File (*.swf)|*.swf|All Files (*.*)|*.*"

            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(File.ReadAllBytes(OpenFileDialog1.FileName))


                Dim header As ByteArray = New ByteArray()
                header.WriteBytes(source, 3, 5)

                Dim compressedLen As ByteArray = New ByteArray()
                compressedLen.WriteBytes(source, 8, 4)


                Dim lzmaprops As ByteArray = New ByteArray()
                lzmaprops.WriteBytes(source, 12, 5)
                Dim properties As Byte() = lzmaprops.ToArray()



                MessageBox.Show("ok")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class
