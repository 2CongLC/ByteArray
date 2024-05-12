Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.IO
Imports System.Text

Public Class AMF0Helper
    Private _ms As MemoryStream = Nothing

    Public Sub New(ByVal ms As MemoryStream)

        _ms = ms

    End Sub

    Public Function ReadObject() As Object

    End Function


    Public Sub WriteObject(ByVal obj As Object)

    End Sub

End Class
