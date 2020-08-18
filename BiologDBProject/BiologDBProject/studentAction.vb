Public Class studentAction

  Dim var As Integer
  Private Sub studentAction_load(sender As Object, e As EventArgs) Handles MyBase.Load
    btnSubmit.Enabled = False

    'ensure that there are no radio buttons selected upon form load
    rbtn_newData.Checked = False
    rbtn_modData.Checked = False
    rbtn_viewData.Checked = False
    rbtn_query.Checked = False
    rbtn_return.Checked = False

  End Sub
  Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
    'check to see which radiobutton is checked
    Try
      Select Case var
        Case 10
          MessageBox.Show("new data selected")
        Case 20
          MessageBox.Show("mod data selected")
        Case 30
          MessageBox.Show("view data selected")
        Case 40
          MessageBox.Show("query data selected")
        Case 50
          MessageBox.Show("return to login selected")

        Case Else
          MessageBox.Show("Error with select case statement")
      End Select
    Catch ex As Exception
      MessageBox.Show(ex.Message)
    End Try

  End Sub

  Private Sub rbtn_newData_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_newData.CheckedChanged
    var = 10
    btnSubmit.Enabled = rbtn_newData.Checked
  End Sub

  Private Sub rbtn_modData_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_modData.CheckedChanged
    var = 20
    btnSubmit.Enabled = rbtn_modData.Checked
  End Sub

  Private Sub rbtn_viewData_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_viewData.CheckedChanged
    var = 30
    btnSubmit.Enabled = rbtn_viewData.Checked
  End Sub

  Private Sub rbtn_query_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_query.CheckedChanged
    var = 40
    btnSubmit.Enabled = rbtn_query.Checked
  End Sub

  Private Sub rbtn_return_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_return.CheckedChanged
    var = 50
    btnSubmit.Enabled = rbtn_return.Checked
  End Sub

  Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
    Me.Close()
  End Sub
End Class