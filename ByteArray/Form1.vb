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




            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            OpenFileDialog1.Filter = "Flash File (*.swf)|*.swf|All Files (*.*)|*.*"
            SaveFileDialog1.Filter = "Flash File (*.swf)|*.swf|All Files (*.*)|*.*"

            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
