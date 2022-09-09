Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim URL As String = InputBox("Enter URL", "URL")
        WebBrowser1.Navigate(URL)
    End Sub
End Class
