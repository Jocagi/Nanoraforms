Imports System.IO.Ports

'Version Aplpha2: Se han cambiado las coordenadas iniciales de las piezas(Las esquinas)... 
'...y se ha reajustado el algoritmo a las coordenadas del nuevo tablero.  Y otros cambios menores...

Public Class Mapa_tablero

    Dim Fx As Integer
    Dim Fy As Integer
    Dim Fz As Integer
    Dim Px As Integer
    Dim Py As Integer
    Dim Pz As Integer
    Dim x1 As Integer
    Dim y1 As Integer
    Dim z1 As Integer
    Dim x2 As Integer
    Dim y2 As Integer
    Dim z2 As Integer
    Dim V As String
    Dim A As String = "A"
    Dim B As String = "B"
    Dim C As String = "C"
    Dim xA As Integer = 1
    Dim yA As Integer = 3
    Dim zA As Integer = 3
    Dim xB As Integer = 3
    Dim yB As Integer = 1
    Dim zB As Integer = 3
    Dim xC As Integer = 1
    Dim yC As Integer = 1
    Dim zC As Integer = 1


    Private Sub Conectar_Click(sender As Object, e As EventArgs) Handles Conectar.Click
        Try
            With Comunicacion

                .BaudRate = 9600
                .DataBits = 8
                .Parity = IO.Ports.Parity.None
                .StopBits = 1
                .PortName = ComboBox1.Text
                .Open()

                If .IsOpen Then
                    lblestado.Text = "CONECTADO"
                Else
                    lblestado.Text = "DESCONECTADO"
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub




    Private Sub Comunicacion_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles Comunicacion.DataReceived
        Dim buffer As String
        buffer = Comunicacion.ReadExisting
    End Sub


    Private Sub C313_CheckedChanged(sender As Object, e As EventArgs) Handles C313.CheckedChanged
        If C313.Checked Then
            x2 = 3
            y2 = 1
            z2 = 3
        End If

    End Sub

    Private Sub C133_CheckedChanged(sender As Object, e As EventArgs) Handles C133.CheckedChanged
        If C133.Checked Then
            x2 = 1
            y2 = 3
            z2 = 3
        End If

    End Sub

    Private Sub C111_CheckedChanged(sender As Object, e As EventArgs) Handles C111.CheckedChanged
        If C111.Checked Then
            x2 = 1
            y2 = 1
            z2 = 1
        End If
    End Sub

    Private Sub C213_CheckedChanged(sender As Object, e As EventArgs) Handles C213.CheckedChanged
        If C213.Checked Then
            x2 = 2
            y2 = 1
            z2 = 3
        End If
    End Sub

    Private Sub C123_CheckedChanged(sender As Object, e As EventArgs) Handles C123.CheckedChanged
        If C123.Checked Then
            x2 = 1
            y2 = 2
            z2 = 3
        End If
    End Sub

    Private Sub C212_CheckedChanged(sender As Object, e As EventArgs) Handles C212.CheckedChanged
        If C212.Checked Then
            x2 = 2
            y2 = 1
            z2 = 2
        End If
    End Sub

    Private Sub C132_CheckedChanged(sender As Object, e As EventArgs) Handles C122.CheckedChanged
        x2 = 1
        y2 = 3
        z2 = 2
    End Sub

    Private Sub C221_CheckedChanged(sender As Object, e As EventArgs) Handles C223.CheckedChanged
        If C223.Checked Then
            x2 = 2
            y2 = 2
            z2 = 1
        End If
    End Sub

    Private Sub C122_CheckedChanged(sender As Object, e As EventArgs) Handles C112.CheckedChanged
        If C112.Checked Then
            x2 = 1
            y2 = 2
            z2 = 2
        End If
    End Sub

    Private Sub PiezaA_CheckedChanged(sender As Object, e As EventArgs) Handles PiezaA.CheckedChanged

        If PiezaA.Checked Then
            V = A

            x1 = xA
            y1 = yA
            z1 = zA

        End If

    End Sub

    Private Sub PiezaB_CheckedChanged(sender As Object, e As EventArgs) Handles PiezaB.CheckedChanged

        If PiezaB.Checked Then
            V = B

            x1 = xB
            y1 = yB
            z1 = zB

        End If

    End Sub


    Private Sub PiezaC_CheckedChanged(sender As Object, e As EventArgs) Handles PiezaC.CheckedChanged

        If PiezaC.Checked Then
            V = C

            x1 = xC
            y1 = yC
            z1 = zC

        End If
    End Sub

    Private Sub Enviar_Click(sender As Object, e As EventArgs) Handles Enviar.Click

        If Comunicacion.IsOpen Then

            Do Until V & x1 & y1 & z1 = V & x2 & y2 & z2


                If x1 > x2 Then Px = x1 - 1
                If x1 = x2 Then Px = x1
                If x1 < x2 Then Px = x1 + 1


                If Px <> x1 Then
                    'Fila Superior
                    If Px & y1 & z1 = 133 Then
                        Fx = Px
                        Comunicacion.Write(V + "A")
                    ElseIf Px & y1 & z1 = 123 Then
                        Fx = Px
                        Comunicacion.Write(V + "B")
                    ElseIf Px & y1 & z1 = 223 Then
                        Fx = Px
                        Comunicacion.Write(V + "C")
                    ElseIf Px & y1 & z1 = 213 Then
                        Fx = Px
                        Comunicacion.Write(V + "D")
                    ElseIf Px & y1 & z1 = 313 Then
                        Fx = Px
                        Comunicacion.Write(V + "E")

                        'Fila Media
                    ElseIf Px & y1 & z1 = 122 Then
                        Fx = Px
                        Comunicacion.Write(V + "F")
                    ElseIf Px & y1 & z1 = 112 Then
                        Fx = Px
                        Comunicacion.Write(V + "G")
                    ElseIf Px & y1 & z1 = 212 Then
                        Fx = Px
                        Comunicacion.Write(V + "H")

                        'Fila Inferior
                    ElseIf Px & y1 & z1 = 111 Then
                        Fx = Px
                        Comunicacion.Write(V + "I")

                    Else Fx = x1
                    End If




                    x1 = Fx

                    'Instruccion
                    'x1 & y1 & z1 = No then send "A" por serial
                    System.Threading.Thread.Sleep(1500)

                End If


                If y1 > y2 Then Py = y1 - 1
                If y1 = y2 Then Py = y1
                If y1 < y2 Then Py = y1 + 1


                If Py <> y1 Then

                    'Fila Superior
                    If x1 & Py & z1 = 133 Then
                        Fy = Py
                        Comunicacion.Write(V + "A")
                    ElseIf x1 & Py & z1 = 123 Then
                        Fy = Py
                        Comunicacion.Write(V + "B")
                    ElseIf x1 & Py & z1 = 223 Then
                        Fy = Py
                        Comunicacion.Write(V + "C")
                    ElseIf x1 & Py & z1 = 213 Then
                        Fy = Py
                        Comunicacion.Write(V + "D")
                    ElseIf x1 & Py & z1 = 313 Then
                        Fy = Py
                        Comunicacion.Write(V + "E")

                        'Fila Media
                    ElseIf x1 & Py & z1 = 122 Then
                        Fy = Py
                        Comunicacion.Write(V + "F")
                    ElseIf x1 & Py & z1 = 112 Then
                        Fy = Py
                        Comunicacion.Write(V + "G")
                    ElseIf x1 & Py & z1 = 212 Then
                        Fy = Py
                        Comunicacion.Write(V + "H")

                        'Fila inferior
                    ElseIf x1 & Py & z1 = 131 Then
                        Fy = Py
                        Comunicacion.Write(V + "I")
                    Else Fy = y1
                    End If





                    y1 = Fy

                    'Instruccion
                    System.Threading.Thread.Sleep(1500)
                End If


                If z1 > z2 Then Pz = z1 - 1
                If z1 = z2 Then Pz = z1
                If z1 < z2 Then Pz = z1 + 1

                If Pz <> z1 Then


                    'Fila Superior
                    If x1 & y1 & Pz = 133 Then
                        Fz = Pz
                        Comunicacion.Write(V + "A")
                    ElseIf x1 & y1 & Pz = 123 Then
                        Fz = Pz
                        Comunicacion.Write(V + "B")
                    ElseIf x1 & y1 & Pz = 223 Then
                        Fz = Pz
                        Comunicacion.Write(V + "C")
                    ElseIf x1 & y1 & Pz = 213 Then
                        Fz = Pz
                        Comunicacion.Write(V + "D")
                    ElseIf x1 & y1 & Pz = 313 Then
                        Fz = Pz
                        Comunicacion.Write(V + "E")

                        'Fila Media
                    ElseIf x1 & y1 & Pz = 122 Then
                        Fz = Pz
                        Comunicacion.Write(V + "F")
                    ElseIf x1 & y1 & Pz = 112 Then
                        Fz = Pz
                        Comunicacion.Write(V + "G")
                    ElseIf x1 & y1 & Pz = 212 Then
                        Fz = Pz
                        Comunicacion.Write(V + "H")

                        'Fila Inferior
                    ElseIf x1 & y1 & Pz = 111 Then
                        Fz = Pz
                        Comunicacion.Write(V + "I")
                    Else Fz = z1
                    End If


                    z1 = Fz

                    'Instruccion

                    System.Threading.Thread.Sleep(1500)
                End If

            Loop

            If V = A Then
                xA = x1
                yA = y1
                zA = z1
            End If
            If V = B Then
                xB = x1
                yB = y1
                zB = z1
            End If
            If V = C Then
                xC = x1
                yC = y1
                zC = z1
            End If

            C133.Checked = False
            C123.Checked = False
            C223.Checked = False
            C213.Checked = False
            C313.Checked = False
            C122.Checked = False
            C112.Checked = False
            C212.Checked = False
            C111.Checked = False

            PiezaA.Checked = False
            PiezaB.Checked = False
            PiezaC.Checked = False

        Else
            MsgBox("NO ESTÁS CONECTADO, Prueba presionando el botón ´Conectar´ primero. :) ", MsgBoxStyle.Exclamation)
        End If


    End Sub

    Private Sub Mapa_tablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class