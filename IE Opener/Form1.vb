Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TheBrowser As Object = CreateObject("InternetExplorer.Application")
        TheBrowser.Visible = True
        TheBrowser.Navigate("https://dantdmjace.neocities.org/ie-opener")

    End Sub
End Class
