<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDuplicar
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
        Dim cboBBDD1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDuplicar))
        Me.txtOperario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNuevoCodigo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cboBBDD1 = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.btnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.btnCancelar = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.cboBBDD1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtOperario
        '
        Me.txtOperario.DisabledBackColor = System.Drawing.Color.White
        Me.txtOperario.Location = New System.Drawing.Point(151, 21)
        Me.txtOperario.Name = "txtOperario"
        Me.txtOperario.Size = New System.Drawing.Size(131, 21)
        Me.txtOperario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Operario a Duplicar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(26, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nuevo Código"
        '
        'txtNuevoCodigo
        '
        Me.txtNuevoCodigo.DisabledBackColor = System.Drawing.Color.White
        Me.txtNuevoCodigo.Location = New System.Drawing.Point(151, 48)
        Me.txtNuevoCodigo.Name = "txtNuevoCodigo"
        Me.txtNuevoCodigo.Size = New System.Drawing.Size(131, 21)
        Me.txtNuevoCodigo.TabIndex = 2
        '
        'cboBBDD1
        '
        cboBBDD1_DesignTimeLayout.LayoutString = resources.GetString("cboBBDD1_DesignTimeLayout.LayoutString")
        Me.cboBBDD1.DesignTimeLayout = cboBBDD1_DesignTimeLayout
        Me.cboBBDD1.DisabledBackColor = System.Drawing.Color.White
        Me.cboBBDD1.Location = New System.Drawing.Point(151, 76)
        Me.cboBBDD1.Name = "cboBBDD1"
        Me.cboBBDD1.SelectedIndex = -1
        Me.cboBBDD1.SelectedItem = Nothing
        Me.cboBBDD1.Size = New System.Drawing.Size(131, 21)
        Me.cboBBDD1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(26, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Destino"
        '
        'btnAceptar
        '
        Me.btnAceptar.Icon = CType(resources.GetObject("btnAceptar.Icon"), System.Drawing.Icon)
        Me.btnAceptar.Location = New System.Drawing.Point(43, 121)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(92, 23)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Icon = CType(resources.GetObject("btnCancelar.Icon"), System.Drawing.Icon)
        Me.btnCancelar.Location = New System.Drawing.Point(168, 123)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(96, 21)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        '
        'FrmDuplicar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 172)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboBBDD1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNuevoCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtOperario)
        Me.Name = "FrmDuplicar"
        Me.Text = "FrmDuplicar"
        CType(Me.cboBBDD1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOperario As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNuevoCodigo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cboBBDD1 As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents btnCancelar As Solmicro.Expertis.Engine.UI.Button
End Class
