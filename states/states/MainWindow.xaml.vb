Class MainWindow 
    Dim states As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Sub Output(ByVal Value As String)
        txtOutput.Text += Value + vbCrLf
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnAdd.Click
        states.Clear()
        states.Add("California", "CA")
        states.Add("Oregen", "OR")
        states.Add("Wasington", "WA")
        OutputStates()
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnShow.Click
        OutputStates()
    End Sub

    Sub OutputStates()
        For Each state In states
            Output(state.ToString)
        Next
    End Sub

    Private Sub btnGet_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnGet.Click
        Dim stateID As String = txtInput.Text
        If states.ContainsKey(stateID) Then
            Output("You requested: " + states.Item(stateID))
        Else
            Output("Not found")
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnRemove.Click
        Dim stateId As String = txtInput.Text
        If states.ContainsKey(stateId) Then
            states.Remove(stateId)
            txtOutput.Text = ""
            Output(stateId + "remove, here's what is left")
            OutputStates()
        Else
            Output("Not Found")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnClear.Click
        txtOutput.Text = ""

    End Sub
End Class