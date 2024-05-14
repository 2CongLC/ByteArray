Imports System.Text
Imports System.Text.Json
Imports System.Xml

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim bytes As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                Dim x As XElement = Nothing
                Dim a As Boolean = bytes.TryGetXml(bytes.ToArray(), x)


                If a Then


                    Dim settings As New XmlWriterSettings()
                    settings.Indent = True
                    settings.OmitXmlDeclaration = False
                    settings.Encoding = Encoding.UTF8

                    Using xw As XmlWriter = XmlWriter.Create(SaveFileDialog1.FileName, settings)
                        x.Save(xw)
                    End Using


                End If

            End If

            MessageBox.Show("ok")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim bytes As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                Dim x As JsonDocument = Nothing
                Dim a As Boolean = bytes.TryGetJson(bytes.ToArray(), x)



                MessageBox.Show(a)



            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class