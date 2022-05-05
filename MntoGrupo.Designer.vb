<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MntoGrupo
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

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
        Dim cbxFactor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim gridOperarios_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoGrupo))
        Me.txtIDGrupo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblIDGrupo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescGrupo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.advIDHora = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDHora = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescHora = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cbxFactor = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFactor = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblOperarios = New Solmicro.Expertis.Engine.UI.Label
        Me.gridOperarios = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        CType(Me.cbxFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCabecera.suspendlayout()
        CType(Me.gridOperarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(716, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.gridOperarios)
        Me.MainPanel.Controls.Add(Me.pnlCabecera)
        Me.MainPanel.Size = New System.Drawing.Size(708, 297)
        '
        'txtIDGrupo
        '
        Me.TryDataBinding(txtIDGrupo, New System.Windows.Forms.Binding("Text", Me, "IDGrupo", True))
        Me.txtIDGrupo.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDGrupo.Location = New System.Drawing.Point(68, 7)
        Me.txtIDGrupo.MaxLength = 10
        Me.txtIDGrupo.Name = "txtIDGrupo"
        Me.txtIDGrupo.Size = New System.Drawing.Size(98, 21)
        Me.txtIDGrupo.TabIndex = 0
        '
        'lblIDGrupo
        '
        Me.lblIDGrupo.Location = New System.Drawing.Point(7, 11)
        Me.lblIDGrupo.Name = "lblIDGrupo"
        Me.lblIDGrupo.Size = New System.Drawing.Size(42, 13)
        Me.lblIDGrupo.TabIndex = 1
        Me.lblIDGrupo.Text = "Grupo"
        '
        'txtDescGrupo
        '
        Me.TryDataBinding(txtDescGrupo, New System.Windows.Forms.Binding("Text", Me, "DescGrupo", True))
        Me.txtDescGrupo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescGrupo.Location = New System.Drawing.Point(169, 7)
        Me.txtDescGrupo.Name = "txtDescGrupo"
        Me.txtDescGrupo.Size = New System.Drawing.Size(531, 21)
        Me.txtDescGrupo.TabIndex = 2
        '
        'advIDHora
        '
        Me.TryDataBinding(advIDHora, New System.Windows.Forms.Binding("Text", Me, "IDHora", True))
        Me.advIDHora.DisabledBackColor = System.Drawing.Color.White
        Me.advIDHora.EntityName = "Hora"
        Me.advIDHora.Location = New System.Drawing.Point(68, 31)
        Me.advIDHora.Name = "advIDHora"
        Me.advIDHora.PrimaryDataFields = "IDHora"
        Me.advIDHora.SecondaryDataFields = "IDHora"
        Me.advIDHora.Size = New System.Drawing.Size(98, 23)
        Me.advIDHora.TabIndex = 4
        '
        'lblIDHora
        '
        Me.lblIDHora.Location = New System.Drawing.Point(7, 37)
        Me.lblIDHora.Name = "lblIDHora"
        Me.lblIDHora.Size = New System.Drawing.Size(62, 13)
        Me.lblIDHora.TabIndex = 5
        Me.lblIDHora.Text = "Tipo Hora"
        '
        'ulDescHora
        '
        Me.TryDataBinding(ulDescHora, New System.Windows.Forms.Binding("Text", Me.advIDHora, "DescHora", True))
        Me.ulDescHora.Location = New System.Drawing.Point(170, 31)
        Me.ulDescHora.Name = "ulDescHora"
        Me.ulDescHora.Size = New System.Drawing.Size(323, 23)
        Me.ulDescHora.TabIndex = 6
        '
        'cbxFactor
        '
        Me.TryDataBinding(cbxFactor, New System.Windows.Forms.Binding("Value", Me, "Factor", True))
        cbxFactor_DesignTimeLayout.LayoutString = resources.GetString("cbxFactor_DesignTimeLayout.LayoutString")
        Me.cbxFactor.DesignTimeLayout = cbxFactor_DesignTimeLayout
        Me.cbxFactor.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFactor.Location = New System.Drawing.Point(584, 31)
        Me.cbxFactor.Name = "cbxFactor"
        Me.cbxFactor.SelectedIndex = -1
        Me.cbxFactor.SelectedItem = Nothing
        Me.cbxFactor.Size = New System.Drawing.Size(116, 21)
        Me.cbxFactor.TabIndex = 7
        '
        'lblFactor
        '
        Me.lblFactor.Location = New System.Drawing.Point(538, 35)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(41, 13)
        Me.lblFactor.TabIndex = 8
        Me.lblFactor.Text = "Factor"
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Controls.Add(Me.lblOperarios)
        Me.pnlCabecera.Controls.Add(Me.txtIDGrupo)
        Me.pnlCabecera.Controls.Add(Me.cbxFactor)
        Me.pnlCabecera.Controls.Add(Me.lblIDGrupo)
        Me.pnlCabecera.Controls.Add(Me.lblFactor)
        Me.pnlCabecera.Controls.Add(Me.ulDescHora)
        Me.pnlCabecera.Controls.Add(Me.txtDescGrupo)
        Me.pnlCabecera.Controls.Add(Me.advIDHora)
        Me.pnlCabecera.Controls.Add(Me.lblIDHora)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(708, 76)
        Me.pnlCabecera.TabIndex = 9
        '
        'lblOperarios
        '
        Me.lblOperarios.Location = New System.Drawing.Point(7, 59)
        Me.lblOperarios.Name = "lblOperarios"
        Me.lblOperarios.Size = New System.Drawing.Size(63, 13)
        Me.lblOperarios.TabIndex = 9
        Me.lblOperarios.Text = "Operarios"
        '
        'gridOperarios
        '
        Me.gridOperarios.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDOperario", "Operario", "IDOperario", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescOperario", "DescOperario")}))})
        gridOperarios_DesignTimeLayout.LayoutString = resources.GetString("gridOperarios_DesignTimeLayout.LayoutString")
        Me.gridOperarios.DesignTimeLayout = gridOperarios_DesignTimeLayout
        Me.gridOperarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridOperarios.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.gridOperarios.EntityName = "GrupoOperario"
        Me.gridOperarios.Location = New System.Drawing.Point(0, 76)
        Me.gridOperarios.Name = "gridOperarios"
        Me.gridOperarios.PrimaryDataFields = "IDGrupo"
        Me.gridOperarios.SecondaryDataFields = "IDGrupo"
        Me.gridOperarios.Size = New System.Drawing.Size(708, 221)
        Me.gridOperarios.TabIndex = 10
        Me.gridOperarios.ViewName = "vMntoGrupoOperario"
        '
        'MntoGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 370)
        Me.EntityName = "Grupo"
        Me.Name = "MntoGrupo"
        Me.NavigationFields = "IDGrupo"
        Me.NoEditableControls = New Solmicro.Expertis.Engine.UI.NoEditableControls(New System.Windows.Forms.Control() {Me.txtIDGrupo})
        Me.Text = "MntoGrupo"
        Me.ViewName = "tbMaestroGrupo"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.cbxFactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        CType(Me.gridOperarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCabecera As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtIDGrupo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cbxFactor As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblIDGrupo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFactor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescHora As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advIDHora As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtDescGrupo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblIDHora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents gridOperarios As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblOperarios As Solmicro.Expertis.Engine.UI.Label
End Class
