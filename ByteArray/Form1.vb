﻿Imports System.Text.Json
Imports System.Web

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Compress(CompressionAlgorithm.Deflate)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Uncompress(CompressionAlgorithm.Deflate)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Compress(CompressionAlgorithm.Gzip)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Uncompress(CompressionAlgorithm.Gzip)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Compress(CompressionAlgorithm.Zlib)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Uncompress(CompressionAlgorithm.Zlib)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Compress(CompressionAlgorithm.Lzma)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Uncompress(CompressionAlgorithm.Lzma)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Compress(CompressionAlgorithm.Brotli)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Uncompress(CompressionAlgorithm.Brotli)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK Then 'AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                Dim out As XDocument = Nothing
                Dim isxml As Boolean = source.TryGetXml(out)

                MessageBox.Show(isxml)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK Then 'AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                Dim out As JsonDocument = Nothing
                Dim isxml As Boolean = source.TryGetJson(out)

                MessageBox.Show(isxml)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    <Obsolete>
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim result As Byte() = source.SerializeBinary(Of String)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, result)
                MessageBox.Show("Ok")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    <Obsolete>
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim result As String = source.DeserializeBinary(Of String)
                IO.File.WriteAllText(SaveFileDialog1.FileName, result)
                MessageBox.Show("Ok")


            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim result As String = source.SerializeJson(Of String)
                IO.File.WriteAllText(SaveFileDialog1.FileName, result)
                MessageBox.Show("Ok")


            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim result As String = source.DeSerializeJson(Of String)
                IO.File.WriteAllText(SaveFileDialog1.FileName, result)
                MessageBox.Show("Ok")


            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim result As String = source.SerializeXml(Of String)
                IO.File.WriteAllText(SaveFileDialog1.FileName, result)
                MessageBox.Show("Ok")


            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim result As String = source.DeserializeXml(Of String)
                IO.File.WriteAllText(SaveFileDialog1.FileName, result)
                MessageBox.Show("Ok")


            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                Dim md5 As String = source.MD5Hash()

                source.Compress(CompressionAlgorithm.Zlib)

                Dim build As ByteArray = New ByteArray()
                build.WriteMultiByte(md5, "us-ascii")
                build.WriteBytes(source)

                IO.File.WriteAllBytes(SaveFileDialog1.FileName, build.ToArray())
                MessageBox.Show("Ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                Dim md5 As String = source.MD5Hash()

                source.Compress(CompressionAlgorithm.Zlib)

                Dim build As ByteArray = New ByteArray()
                build.WriteMultiByte(TextBox1.Text, "us-ascii")
                build.WriteBytes(source)

                IO.File.WriteAllBytes(SaveFileDialog1.FileName, build.ToArray())
                MessageBox.Show("Ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim result As String = source.ConvertToBase64String()

                IO.File.WriteAllText(SaveFileDialog1.FileName, result)
                MessageBox.Show("Ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim result As Byte() = source.ConvertFromBase64String()

                IO.File.WriteAllBytes(SaveFileDialog1.FileName, result)
                MessageBox.Show("Ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim result As String = source.ConvertToHexString

                IO.File.WriteAllText(SaveFileDialog1.FileName, result)
                MessageBox.Show("Ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))
                Dim result As Byte() = source.ConvertFromHexString

                IO.File.WriteAllBytes(SaveFileDialog1.FileName, result)
                MessageBox.Show("Ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Compress(CompressionAlgorithm.Snappy)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Uncompress(CompressionAlgorithm.Snappy)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Compress(CompressionAlgorithm.Zstd)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Try
            OpenFileDialog1.Filter = "All Files(*.*)|*.*"
            SaveFileDialog1.Filter = "All Files(*.*)|*.*"


            If OpenFileDialog1.ShowDialog = DialogResult.OK AndAlso SaveFileDialog1.ShowDialog = DialogResult.OK Then

                Dim source As ByteArray = New ByteArray(IO.File.ReadAllBytes(OpenFileDialog1.FileName))

                source.Uncompress(CompressionAlgorithm.Zstd)
                IO.File.WriteAllBytes(SaveFileDialog1.FileName, source.ToArray())

                MessageBox.Show("ok")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class
