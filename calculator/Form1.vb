﻿Imports System.Linq.Expressions

Public Class Form1
    Dim operand1 As Double
    Dim operand2 As Double
    Dim op As String
    Dim result As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text & sender.text
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        operand1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        op = "+"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        operand1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        op = "-"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        operand1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        op = "*"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        operand1 = Val(TextBox1.Text)
        TextBox1.Text = ""
        op = "/"
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        operand2 = Val(TextBox1.Text)
        Select Case op
            Case "+"
                result = operand1 + operand2
                TextBox1.Text = result

            Case "-"
                result = operand1 - operand2
                TextBox1.Text = result
            Case "*"
                result = operand1 * operand2
                TextBox1.Text = result
            Case "/"
                result = operand1 / operand2
                TextBox1.Text = result
        End Select

    End Sub

End Class
