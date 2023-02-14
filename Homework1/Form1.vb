Public Class frmNumbers
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        MsgBox("quatre")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        MsgBox("trois")
    End Sub

    Private Sub FrmNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        MsgBox("cinq")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        MsgBox("deux")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        MsgBox("un")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

End Class
