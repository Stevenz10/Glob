Public Class Form1
    Dim r1, r2, r3, r4 As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        r1 = Val(TextBox1.Text)

        r2 = Val(TextBox1.Text) * 0.65
        N.Text = r2

        r3 = Val(TextBox1.Text) * 0.35
        RG.Text= r3




    End Sub
End Class
