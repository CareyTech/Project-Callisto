Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        WebBrowser1.Refresh()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        WebBrowser1.Navigate("www.carey.com.au")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class
