Namespace ReviewsJuegos
    Partial Class ActualizarPlataforma
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            label1 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            comboBox1 = New Windows.Forms.ComboBox()
            textBox1 = New Windows.Forms.TextBox()
            button1 = New Windows.Forms.Button()
            button2 = New Windows.Forms.Button()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(123, 57)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(126, 15)
            label1.TabIndex = 0
            label1.Text = "Aelecciona Plataforma"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(117, 150)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(132, 15)
            label2.TabIndex = 1
            label2.Text = "Modifica el nombre por"
            ' 
            ' comboBox1
            ' 
            comboBox1.FormattingEnabled = True
            comboBox1.Location = New Drawing.Point(117, 99)
            comboBox1.Name = "comboBox1"
            comboBox1.Size = New Drawing.Size(121, 23)
            comboBox1.TabIndex = 2
            ' 
            ' textBox1
            ' 
            textBox1.Location = New Drawing.Point(128, 184)
            textBox1.Name = "textBox1"
            textBox1.Size = New Drawing.Size(100, 23)
            textBox1.TabIndex = 3
            ' 
            ' button1
            ' 
            button1.Location = New Drawing.Point(70, 257)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(75, 23)
            button1.TabIndex = 4
            button1.Text = "Actualizar"
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' button2
            ' 
            button2.Location = New Drawing.Point(230, 258)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(75, 23)
            button2.TabIndex = 5
            button2.Text = "Salir"
            button2.UseVisualStyleBackColor = True
            ' 
            ' ActualizarPlataforma
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(386, 327)
            Controls.Add(button2)
            Controls.Add(button1)
            Controls.Add(textBox1)
            Controls.Add(comboBox1)
            Controls.Add(label2)
            Controls.Add(label1)
            Name = "ActualizarPlataforma"
            Text = "ActualizarPlataforma"
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private comboBox1 As Windows.Forms.ComboBox
        Private textBox1 As Windows.Forms.TextBox
        Private button1 As Windows.Forms.Button
        Private button2 As Windows.Forms.Button
    End Class
End Namespace
