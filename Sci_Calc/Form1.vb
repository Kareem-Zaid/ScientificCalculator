

Public Class Kaze_Calc

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTtl.Click

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim A As Decimal, B As Decimal
        If txtA.Text = "" Or txtB.Text = "" Then
            MsgBox("A & B should exist,isn't it ?!")
        Else
            A = txtA.Text
            B = txtB.Text
            txtAns.Text = A + B
            txtS.Text = "+"
        End If
    End Sub

    Private Sub cmdSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSub.Click
        Dim A As Decimal, B As Decimal
        If txtA.Text = "" Or txtB.Text = "" Then
            MsgBox("A & B should exist,isn't it ?!")
        Else
            A = txtA.Text
            B = txtB.Text
            txtAns.Text = A - B
            txtS.Text = "-"
        End If
    End Sub

    Private Sub cmdClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClr.Click
        txtAns.Text = ""
    End Sub

    Private Sub cmdClrAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClrAll.Click
        txtAns.Text = ""
        txtS.Text = ""
        txtA.Text = ""
        txtB.Text = ""
        txtX.Text = ""
    End Sub

    Private Sub cmdFact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFact.Click
        Dim X, I, Y As Decimal
        If txtX.Text = "" Then
            MsgBox("Cannot Calc NOTHING :3")
        Else
            X = txtX.Text
            Y = 1
            For I = 1 To X
                Y = Y * I
            Next
            txtAns.Text = Y
        End If
    End Sub

    Private Sub cmdExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExp.Click
        Dim X, Y As Decimal
        If txtX.Text = "" Then
            MsgBox("Cannot Calc NOTHING :3")
        Else
            X = txtX.Text
            If X <> 0 Then
                Y = 1 / X
                txtAns.Text = Y
            Else : MsgBox("How Dare You Divide by ZERO !!")
            End If
        End If
    End Sub

    Private Sub cmdAnsA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnsA.Click
        Dim Ans As Decimal
        If txtAns.Text = "" Then
            If txtX.Text <> "" Then
                Ans = txtX.Text
                txtA.Text = Ans
                txtX.Text = ""
            Else
                If txtB.Text <> "" Then
                    Ans = txtB.Text
                    txtA.Text = Ans
                    txtB.Text = ""
                End If
            End If
        Else
            txtS.Text = ""
            txtA.Text = ""
            txtX.Text = ""
            Ans = txtAns.Text
            txtA.Text = Ans
            txtAns.Text = ""
        End If
    End Sub

    Private Sub cmdAnsX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnsX.Click
        Dim Ans As Decimal
        If txtAns.Text = "" Then
            If txtA.Text <> "" Then
                Ans = txtA.Text
                txtX.Text = Ans
                txtA.Text = ""
            Else
                If txtB.Text <> "" Then
                    Ans = txtB.Text
                    txtX.Text = Ans
                    txtB.Text = ""
                End If
            End If
        Else
            txtS.Text = ""
            txtA.Text = ""
            txtB.Text = ""
            txtX.Text = ""
            Ans = txtAns.Text
            txtX.Text = Ans
            txtAns.Text = ""
        End If
    End Sub

    Private Sub cmdSqr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSq.Click
        Dim X, Y As Decimal
        If txtX.Text = "" Then
            MsgBox("Cannot Calc NOTHING :3")
        Else
            X = txtX.Text
            Y = X ^ 2
            txtAns.Text = Y
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCu.Click
        Dim X, Y As Decimal
        If txtX.Text = "" Then
            MsgBox("Cannot Calc NOTHING :3")
        Else
            X = txtX.Text
            Y = X ^ 3
            txtAns.Text = Y
        End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSqrt.Click
        Dim X, Y As Decimal
        If txtX.Text = "" Then
            MsgBox("Cannot Calc NOTHING :3")
        Else
            X = txtX.Text
            Y = Math.Sqrt(X)
            txtAns.Text = Y
        End If
    End Sub

    Private Sub cmdCurt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCurt.Click
        Dim X, Y As Decimal
        If txtX.Text = "" Then
            MsgBox("Cannot Calc NOTHING :3")
        Else
            X = txtX.Text
            Y = X ^ (1 / 3)
            txtAns.Text = Y
        End If
    End Sub
    Private Sub txtAns_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtA_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtA.TextChanged

    End Sub

    Private Sub cmdAnsB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnsB.Click
        Dim Ans As Decimal
        If txtAns.Text = "" Then
            If txtX.Text <> "" Then
                Ans = txtX.Text
                txtB.Text = Ans
                txtX.Text = ""
            Else
                If txtA.Text <> "" Then
                    Ans = txtA.Text
                    txtB.Text = Ans
                    txtA.Text = ""
                End If
            End If
        Else
            txtS.Text = ""
            txtB.Text = ""
            txtX.Text = ""
            Ans = txtAns.Text
            txtB.Text = Ans
            txtAns.Text = ""
        End If
    End Sub

    Private Sub cmdDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiv.Click
        Dim A As Decimal, B As Decimal
        If txtA.Text = "" Or txtB.Text = "" Then
            MsgBox("A & B should exist,isn't it ?!")
        Else
            A = txtA.Text
            B = txtB.Text
            txtAns.Text = A / B
            txtS.Text = "÷"
        End If
    End Sub

    Private Sub cmdMul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMul.Click
        Dim A As Decimal, B As Decimal
        If txtA.Text = "" Or txtB.Text = "" Then
            MsgBox("A & B should exist,isn't it ?!")
        Else
            A = txtA.Text
            B = txtB.Text
            txtAns.Text = A * B
            txtS.Text = "×"
        End If
    End Sub

    Private Sub txtX_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtX.TextChanged

    End Sub

    Private Sub txtB_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtB.TextChanged

    End Sub

    Private Sub cmdSin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSin.Click
        Dim X, Y As Decimal
        If txtX.Text = "" Then
            MsgBox("Cannot Calc NOTHING :3")
        Else
            X = txtX.Text
            Y = Math.Sin(X * 3.14 / 180)
            txtAns.Text = Y
        End If
    End Sub

    Private Sub cmdCos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCos.Click
        Dim X, Y As Decimal
        If txtX.Text = "" Then
            MsgBox("Cannot Calc NOTHING :3")
        Else
            X = txtX.Text
            Y = Math.Cos(X * 3.14 / 180)
            txtAns.Text = Y
        End If
    End Sub

    Private Sub cmdLn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLn.Click
        Dim X, Y As Decimal
        If txtX.Text = "" Then
            MsgBox("Cannot Calc NOTHING :3")
        Else
            X = txtX.Text
            Y = Math.Log(X)
            txtAns.Text = Y
        End If
    End Sub

    Private Sub cmdLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLog.Click
        Dim X, Y As Decimal
        If txtX.Text = "" Then
            MsgBox("Cannot Calc NOTHING :3")
        Else
            X = txtX.Text
            Y = Math.Log10(X)
            txtAns.Text = Y
        End If
    End Sub

    Private Sub cmdExp10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExp10.Click
        Dim X, Y As Decimal
        If txtX.Text = "" Then
            MsgBox("Cannot Calc NOTHING :3")
        Else
            X = txtX.Text
            If X <= 28 Then
                Y = 10 ^ X
                txtAns.Text = Y
            Else : MsgBox("Number is LARGER than a young ELEPHANT :v ")
            End If
        End If
    End Sub
End Class