Public Class Form1
    Dim ganancia As Integer
    Public Shared cantidad As Integer = 0
    Public Shared costos As Integer = 0
    Public Shared precio As Integer = 0


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cantidad = InputBox("Introduzca cantidad vendidas")
        Label1.Text = "Cantidad = " & cantidad


    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        costos = InputBox("Introduzca costo por c/u")
        Label2.Text = "Costo = " & costos

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        precio = InputBox("Introduzca precio por c/u")
        Label3.Text = "Precio de venta = " & precio
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ganancia = (precio * cantidad) - (costos * cantidad)

        If ganancia Or precio Or costos = 0 Then
            MsgBox("Faltan datos")
        End If
        If ganancia < 0 Then
            MsgBox("Esta sufriendo de perdidas")
            Label4.Text = "Ganancia = " & ganancia
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
