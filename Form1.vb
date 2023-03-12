Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtBoxEnterValue.Focus()
        radBtnInches2Meters.Checked = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxEnterValue.Focus()
        txtBoxEnterValue.Text = ""
        lblReturnResult.Text = ""
        radBtnInches2Meters.Checked = True
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Declare Variables
        Dim strInput As String = txtBoxEnterValue.Text
        Dim decInput As Decimal
        Dim decResult As Decimal
        ' Check if Numeric
        If IsNumeric(strInput) Then
            decInput = Convert.ToDecimal(strInput)
            ' Check for positive number
            If decInput > 0 Then
                If decInput = 1 Then
                    If radBtnInches2Meters.Checked = True Then
                        decResult = decInput * 0.0254
                        ' Display Result
                        lblReturnResult.Text = strInput & " inch is " & decResult.ToString("N3") & " meters."
                    Else
                        decResult = decInput * 39.3700787402
                        ' Display Result
                        lblReturnResult.Text = strInput & " meter is " & decResult.ToString("N3") & " inches."
                    End If
                Else
                    ' Decide Conversion Type
                    If radBtnInches2Meters.Checked = True Then
                        decResult = decInput * 0.0254
                        ' Display Result
                        lblReturnResult.Text = strInput & " inches is " & decResult.ToString("N3") & " meters."
                    Else
                        decResult = decInput * 39.3700787402
                        ' Display Result
                        lblReturnResult.Text = strInput & " meters is " & decResult.ToString("N3") & " inches."
                    End If
                End If
            Else
                MsgBox("Please Enter a positive number", , "Invalid Number Error")
            End If
        Else
            MsgBox("Please Enter a positive number value", , "Invalid Number Error")
        End If
    End Sub
End Class
