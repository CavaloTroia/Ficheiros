<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbN_Botoes = New System.Windows.Forms.TextBox()
        Me.tbLogo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bLerConfig = New System.Windows.Forms.Button()
        Me.bGravarConfig = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N_Botoes"
        '
        'tbN_Botoes
        '
        Me.tbN_Botoes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbN_Botoes.Location = New System.Drawing.Point(262, 91)
        Me.tbN_Botoes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbN_Botoes.Name = "tbN_Botoes"
        Me.tbN_Botoes.Size = New System.Drawing.Size(148, 26)
        Me.tbN_Botoes.TabIndex = 1
        '
        'tbLogo
        '
        Me.tbLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLogo.Location = New System.Drawing.Point(262, 149)
        Me.tbLogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbLogo.Name = "tbLogo"
        Me.tbLogo.Size = New System.Drawing.Size(148, 26)
        Me.tbLogo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 154)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Logo"
        '
        'bLerConfig
        '
        Me.bLerConfig.Location = New System.Drawing.Point(76, 244)
        Me.bLerConfig.Name = "bLerConfig"
        Me.bLerConfig.Size = New System.Drawing.Size(142, 28)
        Me.bLerConfig.TabIndex = 4
        Me.bLerConfig.Text = "Ler Config"
        Me.bLerConfig.UseVisualStyleBackColor = True
        '
        'bGravarConfig
        '
        Me.bGravarConfig.Location = New System.Drawing.Point(303, 244)
        Me.bGravarConfig.Name = "bGravarConfig"
        Me.bGravarConfig.Size = New System.Drawing.Size(142, 28)
        Me.bGravarConfig.TabIndex = 5
        Me.bGravarConfig.Text = "Gravar Config"
        Me.bGravarConfig.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 439)
        Me.Controls.Add(Me.bGravarConfig)
        Me.Controls.Add(Me.bLerConfig)
        Me.Controls.Add(Me.tbLogo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbN_Botoes)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbN_Botoes As TextBox
    Friend WithEvents tbLogo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bLerConfig As Button
    Friend WithEvents bGravarConfig As Button
End Class
