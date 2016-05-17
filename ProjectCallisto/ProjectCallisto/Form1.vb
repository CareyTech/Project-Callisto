Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.BorderStyle = BorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        WebBrowser1.Navigate("http://google.com.au")
        WebBrowser1.ScriptErrorsSuppressed = True

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Contains(" ") Then
            PictureBox6.Visible = True
        ElseIf TextBox1.Text.Contains(".") Then
            PictureBox6.Visible = False
        Else
            PictureBox6.Visible = True
        End If

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
        Form2.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        WebBrowser1.Navigate("www.carey.com.au")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text.Contains(" ") Then
                WebBrowser1.Navigate("https://www.google.com/search?q=" + TextBox1.Text)
            ElseIf TextBox1.Text.Contains(".") Then
                WebBrowser1.Navigate(TextBox1.Text)
            Else
                WebBrowser1.Navigate("https://www.google.com/search?q=" + TextBox1.Text)
            End If

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        If WebBrowser1.CanGoBack Then
            WebBrowser1.GoBack()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If WebBrowser1.CanGoForward Then
            WebBrowser1.GoForward()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox1.Text = WebBrowser1.Url.ToString
        Label2.Text = WebBrowser1.Url.ToString
        If TextBox1.Text.Contains("https://") Then
            TextBox1.Text = Replace(TextBox1.Text, "https://", "")
            PictureBox7.Visible = True
        ElseIf TextBox1.Text.Contains("http://") Then
            TextBox1.Text = Replace(TextBox1.Text, "http://", "")
            PictureBox7.Visible = False
        Else
            PictureBox7.Visible = False
        End If
    End Sub
    Private Sub WebBrowser1_ProgressChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        Try
            ProgressBar1.Maximum = e.MaximumProgress
            ProgressBar1.Value = e.CurrentProgress
            Label4.Text = "Loading"


            If ProgressBar1.Value = ProgressBar1.Maximum Then

                Label4.Text = "Done"
                ProgressBar1.Value = ProgressBar1.Maximum

            End If
        Catch ex As Exception
            Label4.Text = "Error Loading"
        End Try
    End Sub
End Class
