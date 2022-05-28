Public Class Inicio


    Private Sub BotonDeIngreso_Click(sender As Object, e As EventArgs) Handles BotonDeIngreso.Click

        Dim f2 As New Mapa_tablero
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
