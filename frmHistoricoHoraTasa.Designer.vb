<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistoricoHoraTasa
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
        Me.components = New System.ComponentModel.Container
        Dim GrdHistorico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistoricoHoraTasa))
        Me.FrmInfo = New Solmicro.Expertis.Engine.UI.Frame
        Me.ULblDescHora = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.TxtHora = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblHora = New Solmicro.Expertis.Engine.UI.Label
        Me.ULblDescOperario = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.TxtOperario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.GrdHistorico = New Solmicro.Expertis.Engine.UI.Grid
        Me.PnlButtons = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmInfo.SuspendLayout()
        CType(Me.GrdHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlButtons.suspendlayout()
        Me.SuspendLayout()
        '
        'FrmInfo
        '
        Me.FrmInfo.Controls.Add(Me.ULblDescHora)
        Me.FrmInfo.Controls.Add(Me.TxtHora)
        Me.FrmInfo.Controls.Add(Me.LblHora)
        Me.FrmInfo.Controls.Add(Me.ULblDescOperario)
        Me.FrmInfo.Controls.Add(Me.TxtOperario)
        Me.FrmInfo.Controls.Add(Me.LblOperario)
        Me.FrmInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmInfo.Location = New System.Drawing.Point(0, 0)
        Me.FrmInfo.Name = "FrmInfo"
        Me.FrmInfo.Size = New System.Drawing.Size(458, 78)
        Me.FrmInfo.TabIndex = 0
        Me.FrmInfo.TabStop = False
        Me.FrmInfo.Text = "Info"
        '
        'ULblDescHora
        '
        Me.ULblDescHora.Location = New System.Drawing.Point(174, 43)
        Me.ULblDescHora.Name = "ULblDescHora"
        Me.ULblDescHora.Size = New System.Drawing.Size(278, 23)
        Me.ULblDescHora.TabIndex = 5
        '
        'TxtHora
        '
        Me.TxtHora.DisabledBackColor = System.Drawing.Color.White
        Me.TxtHora.Enabled = False
        Me.TxtHora.Location = New System.Drawing.Point(68, 44)
        Me.TxtHora.Name = "TxtHora"
        Me.TxtHora.Size = New System.Drawing.Size(100, 21)
        Me.TxtHora.TabIndex = 4
        '
        'LblHora
        '
        Me.LblHora.Location = New System.Drawing.Point(6, 48)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(34, 13)
        Me.LblHora.TabIndex = 3
        Me.LblHora.Text = "Hora"
        '
        'ULblDescOperario
        '
        Me.ULblDescOperario.Location = New System.Drawing.Point(174, 16)
        Me.ULblDescOperario.Name = "ULblDescOperario"
        Me.ULblDescOperario.Size = New System.Drawing.Size(278, 23)
        Me.ULblDescOperario.TabIndex = 2
        '
        'TxtOperario
        '
        Me.TxtOperario.DisabledBackColor = System.Drawing.Color.White
        Me.TxtOperario.Enabled = False
        Me.TxtOperario.Location = New System.Drawing.Point(68, 17)
        Me.TxtOperario.Name = "TxtOperario"
        Me.TxtOperario.Size = New System.Drawing.Size(100, 21)
        Me.TxtOperario.TabIndex = 1
        '
        'LblOperario
        '
        Me.LblOperario.Location = New System.Drawing.Point(6, 21)
        Me.LblOperario.Name = "LblOperario"
        Me.LblOperario.Size = New System.Drawing.Size(57, 13)
        Me.LblOperario.TabIndex = 0
        Me.LblOperario.Text = "Operario"
        '
        'GrdHistorico
        '
        GrdHistorico_DesignTimeLayout.LayoutString = resources.GetString("GrdHistorico_DesignTimeLayout.LayoutString")
        Me.GrdHistorico.DesignTimeLayout = GrdHistorico_DesignTimeLayout
        Me.GrdHistorico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdHistorico.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GrdHistorico.EntityName = Nothing
        Me.GrdHistorico.Location = New System.Drawing.Point(0, 78)
        Me.GrdHistorico.Name = "GrdHistorico"
        Me.GrdHistorico.PrimaryDataFields = Nothing
        Me.GrdHistorico.SecondaryDataFields = Nothing
        Me.GrdHistorico.Size = New System.Drawing.Size(458, 212)
        Me.GrdHistorico.TabIndex = 1
        Me.GrdHistorico.ViewName = Nothing
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 290)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(458, 45)
        Me.PnlButtons.TabIndex = 2
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(237, 6)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(82, 33)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(139, 6)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(82, 33)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "Aceptar"
        '
        'frmHistoricoHoraTasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 335)
        Me.Controls.Add(Me.GrdHistorico)
        Me.Controls.Add(Me.PnlButtons)
        Me.Controls.Add(Me.FrmInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHistoricoHoraTasa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histórico Tasas"
        Me.FrmInfo.ResumeLayout(False)
        Me.FrmInfo.PerformLayout()
        CType(Me.GrdHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FrmInfo As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents GrdHistorico As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents PnlButtons As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents ULblDescHora As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents TxtHora As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblHora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ULblDescOperario As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents TxtOperario As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
End Class
