Public Class Calculator
    Dim process As String
    Dim firstNum As Int64
    Dim secondNum As Int64
    Dim result As Int64
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        If Not Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal

        End If

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If Me.WindowState = FormWindowState.Maximized Or Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
        End If



    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RichTextBox1.Text = RichTextBox1.Text & 2
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RichTextBox1.Text = RichTextBox1.Text & 1

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        RichTextBox1.Text = RichTextBox1.Text & 3
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        RichTextBox1.Text = RichTextBox1.Text & 4
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        RichTextBox1.Text = RichTextBox1.Text & 5
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        RichTextBox1.Text = RichTextBox1.Text & 6
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        RichTextBox1.Text = RichTextBox1.Text & 7
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        RichTextBox1.Text = RichTextBox1.Text & 8
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        RichTextBox1.Text = RichTextBox1.Text & 9
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("http://github.com/GreatArkStudios")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        RichTextBox1.Text = RichTextBox1.Text & 0
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        RichTextBox1.Text = RichTextBox1.Text & "."
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        firstNum = Val(RichTextBox1.Text)
        Math.Sqrt(firstNum)
        Console.Write(firstNum)
        RichTextBox1.Text() = firstNum

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        process = "+"
        firstNum = Val(RichTextBox1.Text)
        RichTextBox1.Clear()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If process = "+" Then
            secondNum = Val(RichTextBox1.Text)
            result = firstNum + secondNum
            RichTextBox1.Text = result
        End If
        If process = "-" Then
            secondNum = Val(RichTextBox1.Text)
            result = firstNum - secondNum
            RichTextBox1.Text = result
        End If
        If process = "*" Then
            secondNum = Val(RichTextBox1.Text)
            result = firstNum * secondNum
            RichTextBox1.Text = result
        End If
        If process = "/" Then
            secondNum = Val(RichTextBox1.Text)
            result = firstNum / secondNum
            RichTextBox1.Text = result
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        process = "-"
        firstNum = Val(RichTextBox1.Text)
        RichTextBox1.Clear()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        process = "*"
        firstNum = Val(RichTextBox1.Text)
        RichTextBox1.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        process = "/"
        firstNum = Val(RichTextBox1.Text)
        RichTextBox1.Clear()
    End Sub
End Class
