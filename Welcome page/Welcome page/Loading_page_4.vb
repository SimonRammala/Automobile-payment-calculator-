﻿Public Class Loading_page_4

    Private Sub Loading_page_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value <= ProgressBar1.Maximum - 1) Then
            ProgressBar1.Value += 1
            lblpercentage_display.Text = ProgressBar1.Value
        Else
            Timer1.Enabled = False
            Me.Hide()
            Payment_details.Show()
        End If
    End Sub
End Class