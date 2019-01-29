Public Class Form1

    Private Sub btnEnglish_Click(sender As Object, e As EventArgs) Handles btnEnglish.Click
        lblMessage.Text = "Welcome to Visual Basic"
    End Sub

    Private Sub btnSpanish_Click(sender As Object, e As EventArgs) Handles btnSpanish.Click
        txtMessage.Text = "Bienvenido a Visual Basic"
    End Sub

 
    Private Sub btnFrench_Click(sender As Object, e As EventArgs) Handles btnFrench.Click
        lblMessage.Text = "Bienvenue a Visual Basic"
        txtMessage.Text = "Je m'appelle Darius"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMessage.Text = ""
        lblMessage.Text = ""
    End Sub
End Class
