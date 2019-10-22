<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Tb1 = New System.Windows.Forms.TextBox()
        Me.Bstart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Tb1
        '
        Me.Tb1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb1.Location = New System.Drawing.Point(13, 13)
        Me.Tb1.Multiline = True
        Me.Tb1.Name = "Tb1"
        Me.Tb1.Size = New System.Drawing.Size(548, 331)
        Me.Tb1.TabIndex = 0
        '
        'Bstart
        '
        Me.Bstart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bstart.Location = New System.Drawing.Point(13, 351)
        Me.Bstart.Name = "Bstart"
        Me.Bstart.Size = New System.Drawing.Size(548, 55)
        Me.Bstart.TabIndex = 1
        Me.Bstart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 418)
        Me.Controls.Add(Me.Bstart)
        Me.Controls.Add(Me.Tb1)
        Me.MinimumSize = New System.Drawing.Size(589, 457)
        Me.Name = "Form1"
        Me.Text = "Fibonacci 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tb1 As TextBox
    Friend WithEvents Bstart As Button
End Class
