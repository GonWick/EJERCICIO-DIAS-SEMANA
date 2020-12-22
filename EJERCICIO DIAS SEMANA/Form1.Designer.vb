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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ButtonLunes = New System.Windows.Forms.Button()
        Me.ButtonMartes = New System.Windows.Forms.Button()
        Me.ButtonMiercoles = New System.Windows.Forms.Button()
        Me.ButtonJueves = New System.Windows.Forms.Button()
        Me.ButtonViernes = New System.Windows.Forms.Button()
        Me.ButtonSabado = New System.Windows.Forms.Button()
        Me.ButtonDomingo = New System.Windows.Forms.Button()
        Me.LabelDiaSemana = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonLunes
        '
        Me.ButtonLunes.Location = New System.Drawing.Point(12, 24)
        Me.ButtonLunes.Name = "ButtonLunes"
        Me.ButtonLunes.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLunes.TabIndex = 0
        Me.ButtonLunes.Text = "Lunes"
        Me.ButtonLunes.UseVisualStyleBackColor = True
        '
        'ButtonMartes
        '
        Me.ButtonMartes.Location = New System.Drawing.Point(93, 24)
        Me.ButtonMartes.Name = "ButtonMartes"
        Me.ButtonMartes.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMartes.TabIndex = 1
        Me.ButtonMartes.Text = "Martes"
        Me.ButtonMartes.UseVisualStyleBackColor = True
        '
        'ButtonMiercoles
        '
        Me.ButtonMiercoles.Location = New System.Drawing.Point(174, 24)
        Me.ButtonMiercoles.Name = "ButtonMiercoles"
        Me.ButtonMiercoles.Size = New System.Drawing.Size(75, 23)
        Me.ButtonMiercoles.TabIndex = 2
        Me.ButtonMiercoles.Text = "Miercoles"
        Me.ButtonMiercoles.UseVisualStyleBackColor = True
        '
        'ButtonJueves
        '
        Me.ButtonJueves.Location = New System.Drawing.Point(255, 24)
        Me.ButtonJueves.Name = "ButtonJueves"
        Me.ButtonJueves.Size = New System.Drawing.Size(75, 23)
        Me.ButtonJueves.TabIndex = 3
        Me.ButtonJueves.Text = "Jueves"
        Me.ButtonJueves.UseVisualStyleBackColor = True
        '
        'ButtonViernes
        '
        Me.ButtonViernes.Location = New System.Drawing.Point(336, 24)
        Me.ButtonViernes.Name = "ButtonViernes"
        Me.ButtonViernes.Size = New System.Drawing.Size(75, 23)
        Me.ButtonViernes.TabIndex = 4
        Me.ButtonViernes.Text = "Viernes"
        Me.ButtonViernes.UseVisualStyleBackColor = True
        '
        'ButtonSabado
        '
        Me.ButtonSabado.Location = New System.Drawing.Point(417, 24)
        Me.ButtonSabado.Name = "ButtonSabado"
        Me.ButtonSabado.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSabado.TabIndex = 5
        Me.ButtonSabado.Text = "Sabado"
        Me.ButtonSabado.UseVisualStyleBackColor = True
        '
        'ButtonDomingo
        '
        Me.ButtonDomingo.Location = New System.Drawing.Point(498, 24)
        Me.ButtonDomingo.Name = "ButtonDomingo"
        Me.ButtonDomingo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDomingo.TabIndex = 6
        Me.ButtonDomingo.Text = "Domingo"
        Me.ButtonDomingo.UseVisualStyleBackColor = True
        '
        'LabelDiaSemana
        '
        Me.LabelDiaSemana.AutoSize = True
        Me.LabelDiaSemana.Location = New System.Drawing.Point(12, 61)
        Me.LabelDiaSemana.Name = "LabelDiaSemana"
        Me.LabelDiaSemana.Size = New System.Drawing.Size(0, 15)
        Me.LabelDiaSemana.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 128)
        Me.Controls.Add(Me.LabelDiaSemana)
        Me.Controls.Add(Me.ButtonDomingo)
        Me.Controls.Add(Me.ButtonSabado)
        Me.Controls.Add(Me.ButtonViernes)
        Me.Controls.Add(Me.ButtonJueves)
        Me.Controls.Add(Me.ButtonMiercoles)
        Me.Controls.Add(Me.ButtonMartes)
        Me.Controls.Add(Me.ButtonLunes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Dia de la Semana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonLunes As Button
    Friend WithEvents ButtonMartes As Button
    Friend WithEvents ButtonMiercoles As Button
    Friend WithEvents ButtonJueves As Button
    Friend WithEvents ButtonViernes As Button
    Friend WithEvents ButtonSabado As Button
    Friend WithEvents ButtonDomingo As Button
    Friend WithEvents LabelDiaSemana As Label
End Class
