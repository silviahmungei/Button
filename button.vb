Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = "Click
 Me" ' Set the name of button 
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("
 Visit
 here:
 https://www.javatpoint.com")     ' Display the message, when a user clicks on Click me button 
    End Sub
End Class
