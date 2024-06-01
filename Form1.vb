Imports GOLD

Public Class Form1
    Dim parser As New Parser()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            parser.LoadTables("drone_control_grammar.egt")
            MessageBox.Show("Gramática cargada exitosamente.")
        Catch ex As Exception
            MessageBox.Show("Error al cargar la gramática: " & ex.Message)
        End Try
    End Sub

    Private Sub ExecuteCommand(command As String)
        parser.Open(command)

        Dim response As ParseMessage = parser.Parse()
        While response = ParseMessage.TokenRead Or response = ParseMessage.Reduction
            response = parser.Parse()
        End While

        ' Procesar resultado final
        Select Case response
            Case ParseMessage.Accept
                Select Case command
                    Case "START_ENGINE"
                        MessageBox.Show("Motor iniciado")
                    Case "STOP_ENGINE"
                        MessageBox.Show("Motor detenido")
                    Case "TURN_LEFT"
                        MessageBox.Show("Girando a la izquierda")
                    Case "TURN_RIGHT"
                        MessageBox.Show("Girando a la derecha")
                    Case "MOVE_UP"
                        MessageBox.Show("Moviéndose hacia arriba")
                    Case "MOVE_DOWN"
                        MessageBox.Show("Moviéndose hacia abajo")
                    Case "ROTATE_FORWARD"
                        MessageBox.Show("Rotando hacia adelante")
                    Case "ROTATE_BACKWARD"
                        MessageBox.Show("Rotando hacia atrás")
                    Case "RETURN_HOME"
                        MessageBox.Show("Regresando a casa")
                End Select
            Case Else
                MessageBox.Show("Comando no aceptado: " & command)
        End Select
    End Sub

    ' Métodos para manejar eventos de los botones
    Private Sub btnStartEngine_Click(sender As Object, e As EventArgs) Handles btnStartEngine.Click
        ExecuteCommand("START_ENGINE")
    End Sub

    Private Sub btnStopEngine_Click(sender As Object, e As EventArgs) Handles btnStopEngine.Click
        ExecuteCommand("STOP_ENGINE")
    End Sub

    Private Sub btnTurnLeft_Click(sender As Object, e As EventArgs) Handles btnTurnLeft.Click
        ExecuteCommand("TURN_LEFT")
    End Sub

    Private Sub btnTurnRight_Click(sender As Object, e As EventArgs) Handles btnTurnRight.Click
        ExecuteCommand("TURN_RIGHT")
    End Sub

    Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click
        ExecuteCommand("MOVE_UP")
    End Sub

    Private Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click
        ExecuteCommand("MOVE_DOWN")
    End Sub

    Private Sub btnRotateForward_Click(sender As Object, e As EventArgs) Handles btnRotateForward.Click
        ExecuteCommand("ROTATE_FORWARD")
    End Sub

    Private Sub btnRotateBackward_Click(sender As Object, e As EventArgs) Handles btnRotateBackward.Click
        ExecuteCommand("ROTATE_BACKWARD")
    End Sub

    Private Sub btnReturnHome_Click(sender As Object, e As EventArgs) Handles btnReturnHome.Click
        ExecuteCommand("RETURN_HOME")
    End Sub

    Private Sub btnUndefined_Click(sender As Object, e As EventArgs) Handles btnUndefined.Click
        ExecuteCommand("UNDEFINED_ACTION")
    End Sub
End Class
