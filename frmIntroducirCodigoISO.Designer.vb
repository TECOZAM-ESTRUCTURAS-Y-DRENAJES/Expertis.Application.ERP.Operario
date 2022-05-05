<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntroducirCodigoISO
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCodigo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblAdvertencia = New Solmicro.Expertis.Engine.UI.Label
        Me.cmdAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtCodigoISO = New Solmicro.Expertis.Engine.UI.TextBox
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.Location = New System.Drawing.Point(59, 85)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(413, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Introduzca el Código ISO del País al que pertenece la Cuenta Bancaria"
        '
        'lblAdvertencia
        '
        Me.lblAdvertencia.Location = New System.Drawing.Point(12, 45)
        Me.lblAdvertencia.Name = "lblAdvertencia"
        Me.lblAdvertencia.Size = New System.Drawing.Size(633, 13)
        Me.lblAdvertencia.TabIndex = 1
        Me.lblAdvertencia.Text = "NOTA: Solmicro no se hace responsable del Código IBAN generado. Recuerde que debe" & _
            " revisar dicho código."
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(194, 136)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(75, 23)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aeptar"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(413, 136)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 3
        Me.cmdCancelar.Text = "Cancelar"
        '
        'txtCodigoISO
        '
        Me.txtCodigoISO.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodigoISO.Location = New System.Drawing.Point(504, 81)
        Me.txtCodigoISO.Name = "txtCodigoISO"
        Me.txtCodigoISO.Size = New System.Drawing.Size(100, 21)
        Me.txtCodigoISO.TabIndex = 4
        '
        'frmIntroducirCodigoISO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 182)
        Me.Controls.Add(Me.txtCodigoISO)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.lblAdvertencia)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "frmIntroducirCodigoISO"
        Me.Text = "frmIntroducirCodigoISO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCodigo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAdvertencia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cmdAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmdCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtCodigoISO As Solmicro.Expertis.Engine.UI.TextBox
End Class
