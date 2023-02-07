Imports System.Net.Mime.MediaTypeNames

Public Class Form1
    Const PI As Decimal = 3.14159
    Private Sub btnTriangle_Click(sender As Object, e As EventArgs) Handles btnTriangle.Click
        Dim iHeight, iBase As Integer
        If Not IsNumeric(txtHeight.Text) OrElse Not IsNumeric(txtBase.Text) Then
            MsgBox("Please enter a valid integer", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iHeight = txtHeight.Text
        iBase = txtBase.Text
        areaOfTriangle.Text = (1 / 2) * iBase * iHeight
    End Sub
    Private Sub btnARectangle_Click(sender As Object, e As EventArgs) Handles btnARectangle.Click
        Dim iHeight, iWidth As Integer
        If Not IsNumeric(txtWidth.Text) OrElse Not IsNumeric(txtRecHeight.Text) Then
            MsgBox("Please enter a valid integer", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iHeight = txtRecHeight.Text
        iWidth = txtWidth.Text
        areaOfRectangle.Text = iHeight * iWidth
    End Sub

    Private Sub btnACircle_Click(sender As Object, e As EventArgs) Handles btnACircle.Click
        Dim iRad As Integer
        If Not IsNumeric(circRad.Text) Then
            MsgBox("Please enter a valid integer", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iRad = circRad.Text
        circArea.Text = PI * iRad * iRad
    End Sub

    Private Sub btnVCylinder_Click(sender As Object, e As EventArgs) Handles btnVCylinder.Click
        Dim iRad, iHeight As Integer
        If Not IsNumeric(cylRad.Text) OrElse Not IsNumeric(cylHeight.Text) Then
            MsgBox("Please enter a valid integer", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iRad = cylRad.Text
        iHeight = cylHeight.Text
        cylVol.Text = PI * iRad * iRad * iHeight
    End Sub

    Private Sub btnVCone_Click(sender As Object, e As EventArgs) Handles btnVCone.Click
        Dim iRad, iHeight As Integer
        If Not IsNumeric(coneRad.Text) OrElse Not IsNumeric(coneHeight.Text) Then
            MsgBox("Please enter a valid integer", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iRad = coneRad.Text
        iHeight = coneHeight.Text
        coneVol.Text = PI * iRad * iRad * (iHeight / 3)
    End Sub

    Private Sub btnConvertA_Click(sender As Object, e As EventArgs) Handles btnConvertA.Click
        Dim iPound, iKilo As Integer
        If Not IsNumeric(poundVal.Text) Then
            MsgBox("Please enter a valid integer for Pound", MessageBoxIcon.Error, "Invalid Number")
        Else
            iPound = poundVal.Text
            toKilo.Text = Convert.ToDouble(iPound / 2.205)
        End If

        If Not IsNumeric(kiloVal.Text) Then
            MsgBox("Please enter a valid integer for Kilo", MessageBoxIcon.Error, "Invalid Number")
        Else
            iKilo = kiloVal.Text
            toPound.Text = Convert.ToDouble(iKilo * 2.205)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iFaren As Double
        If Not IsNumeric(farenVal.Text) Then
            MsgBox("Please enter a valid integer for Pound", MessageBoxIcon.Error, "Invalid Number")
            Return
        End If
        iFaren = farenVal.Text
        celsiusVal.Text = (iFaren - 32) / 1.8
    End Sub
End Class
