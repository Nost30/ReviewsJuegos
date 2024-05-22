Namespace ReviewsJuegos
    Partial Class ActualizarGenero
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
            comboBox1 = New Windows.Forms.ComboBox()
            button1 = New Windows.Forms.Button()
            button2 = New Windows.Forms.Button()
            label2 = New Windows.Forms.Label()
            textBox1 = New Windows.Forms.TextBox()
            label3 = New Windows.Forms.Label()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(99, 45)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(104, 15)
            label1.TabIndex = 0
            label1.Text = "Selecciona Genero"
            ' 
            ' comboBox1
            ' 
            comboBox1.FormattingEnabled = True
            comboBox1.Location = New Drawing.Point(99, 95)
            comboBox1.Name = "comboBox1"
            comboBox1.Size = New Drawing.Size(121, 23)
            comboBox1.TabIndex = 1
            ' 
            ' button1
            ' 
            button1.Location = New Drawing.Point(58, 244)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(75, 23)
            button1.TabIndex = 2
            button1.Text = "Actualizar"
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' button2
            ' 
            button2.Location = New Drawing.Point(189, 244)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(75, 23)
            button2.TabIndex = 3
            button2.Text = "Salir"
            button2.UseVisualStyleBackColor = True
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(133, 166)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(0, 15)
            label2.TabIndex = 4
            ' 
            ' textBox1
            ' 
            textBox1.Location = New Drawing.Point(103, 193)
            textBox1.Name = "textBox1"
            textBox1.Size = New Drawing.Size(100, 23)
            textBox1.TabIndex = 5
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New Drawing.Point(81, 151)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(168, 15)
            label3.TabIndex = 6
            label3.Text = "¿Que nombre quieres ponerle?"
            ' 
            ' ActualizarGenero
            ' 
            AutoScaleDimensions = New Drawing.SizeF(7F, 15F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(318, 332)
            Controls.Add(label3)
            Controls.Add(textBox1)
            Controls.Add(label2)
            Controls.Add(button2)
            Controls.Add(button1)
            Controls.Add(comboBox1)
            Controls.Add(label1)
            Name = "ActualizarGenero"
            Text = "ActualizarGenero"
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private comboBox1 As Windows.Forms.ComboBox
        Private button1 As Windows.Forms.Button
        Private button2 As Windows.Forms.Button
        Private label2 As Windows.Forms.Label
        Private textBox1 As Windows.Forms.TextBox
        Private label3 As Windows.Forms.Label
    End Class
End Namespace
