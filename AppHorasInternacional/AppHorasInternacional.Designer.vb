﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppHorasInternacional
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

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
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppHorasInternacional))
        Me.advIDOperario = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.advNObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblNObra = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFecha2 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFecha1 = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFecha1 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.advIDOperario)
        Me.FilterPanel.Controls.Add(Me.lblIDOperario)
        Me.FilterPanel.Controls.Add(Me.advNObra)
        Me.FilterPanel.Controls.Add(Me.lblNObra)
        Me.FilterPanel.Controls.Add(Me.clbFecha2)
        Me.FilterPanel.Controls.Add(Me.lblFecha1)
        Me.FilterPanel.Controls.Add(Me.clbFecha1)
        Me.FilterPanel.Controls.Add(Me.lblFecha)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 465)
        Me.FilterPanel.Size = New System.Drawing.Size(1113, 101)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(1113, 465)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Size = New System.Drawing.Size(1113, 465)
        Me.Grid.ViewName = "frmMntoHorasInternacionalTecozam"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(1113, 566)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(1113, 566)
        '
        'advIDOperario
        '
        Me.advIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.advIDOperario.DisplayField = "IDOperario"
        Me.advIDOperario.EntityName = "Operario"
        Me.advIDOperario.Location = New System.Drawing.Point(98, 60)
        Me.advIDOperario.Name = "advIDOperario"
        Me.advIDOperario.PrimaryDataFields = "IDOperario"
        Me.advIDOperario.Size = New System.Drawing.Size(121, 23)
        Me.advIDOperario.TabIndex = 44
        '
        'lblIDOperario
        '
        Me.lblIDOperario.Location = New System.Drawing.Point(21, 65)
        Me.lblIDOperario.Name = "lblIDOperario"
        Me.lblIDOperario.Size = New System.Drawing.Size(57, 13)
        Me.lblIDOperario.TabIndex = 45
        Me.lblIDOperario.Text = "Operario"
        '
        'advNObra
        '
        Me.advNObra.DisabledBackColor = System.Drawing.Color.White
        Me.advNObra.DisplayField = "NObra"
        Me.advNObra.EntityName = "ObraCabecera"
        Me.advNObra.Location = New System.Drawing.Point(98, 27)
        Me.advNObra.Name = "advNObra"
        Me.advNObra.PrimaryDataFields = "NObra"
        Me.advNObra.Size = New System.Drawing.Size(121, 23)
        Me.advNObra.TabIndex = 42
        '
        'lblNObra
        '
        Me.lblNObra.Location = New System.Drawing.Point(21, 32)
        Me.lblNObra.Name = "lblNObra"
        Me.lblNObra.Size = New System.Drawing.Size(35, 13)
        Me.lblNObra.TabIndex = 43
        Me.lblNObra.Text = "Obra"
        '
        'clbFecha2
        '
        Me.clbFecha2.DisabledBackColor = System.Drawing.Color.White
        Me.clbFecha2.Location = New System.Drawing.Point(369, 60)
        Me.clbFecha2.Name = "clbFecha2"
        Me.clbFecha2.Size = New System.Drawing.Size(121, 21)
        Me.clbFecha2.TabIndex = 40
        '
        'lblFecha1
        '
        Me.lblFecha1.Location = New System.Drawing.Point(271, 65)
        Me.lblFecha1.Name = "lblFecha1"
        Me.lblFecha1.Size = New System.Drawing.Size(92, 13)
        Me.lblFecha1.TabIndex = 41
        Me.lblFecha1.Text = "Fecha Parte<="
        '
        'clbFecha1
        '
        Me.clbFecha1.DisabledBackColor = System.Drawing.Color.White
        Me.clbFecha1.Location = New System.Drawing.Point(369, 29)
        Me.clbFecha1.Name = "clbFecha1"
        Me.clbFecha1.Size = New System.Drawing.Size(121, 21)
        Me.clbFecha1.TabIndex = 38
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(271, 32)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(96, 13)
        Me.lblFecha.TabIndex = 39
        Me.lblFecha.Text = "Fecha Parte >="
        '
        'AppHorasInternacional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 654)
        Me.Name = "AppHorasInternacional"
        Me.Text = "Horas Internacional Tecozam"
        Me.ViewName = "frmMntoHorasInternacionalTecozam"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents advIDOperario As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDOperario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advNObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblNObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFecha2 As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFecha1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFecha1 As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
End Class
