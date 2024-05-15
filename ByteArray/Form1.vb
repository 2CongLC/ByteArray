Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                source.Compress(CompressionAlgorithm.Deflate)

                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())


            End If


        Catch ex As Exception

        End Try
    End Sub
End Class
