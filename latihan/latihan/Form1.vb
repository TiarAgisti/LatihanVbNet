Public Class Form1
    Private Sub PrepareDisplay()
        Me.txtServer.Text = My.Settings.Server
        Me.txtdb.Text = My.Settings.Database
        Me.txtUserName.Text = My.Settings.UserName
        Me.txtPass.Text = My.Settings.Password
        Me.ckWin.Checked = My.Settings.WinAuth
    End Sub
    Private Sub SaveConfig()
        My.Settings.Server = Me.txtServer.Text
        My.Settings.Database = Me.txtdb.Text
        My.Settings.UserName = Me.txtUserName.Text
        My.Settings.Password = Me.txtPass.Text
        My.Settings.WinAuth = Me.ckWin.Checked
        My.Settings.Save()
    End Sub
    Private Sub ckWin_CheckedChanged(sender As Object, e As EventArgs) Handles ckWin.CheckedChanged
        If Me.ckWin.Checked = True Then
            Me.txtUserName.Enabled = False
            Me.txtPass.Enabled = False
            Me.txtUserName.Clear()
            Me.txtPass.Clear()
            Me.btnConnect.Focus()
        Else
            Me.txtUserName.Enabled = True
            Me.txtPass.Enabled = True
            Me.btnConnect.Focus()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrepareDisplay()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        SaveConfig()
        If OpenConnection() = True Then
            MsgBox("Connection Successfully")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveConfig()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
