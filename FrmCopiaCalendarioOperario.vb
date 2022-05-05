Public Class FrmCopiaCalendarioOperario
    Inherits Solmicro.Expertis.Engine.UI.FormBase

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents FrmAñoCalendario As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents TxtAñoCalendario As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents LblCalendarioEmpresa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FrmHastaOperario As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblOperarioHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblOperarioDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvOperarioHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvOperarioDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FrmDesdeOperario As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblOperarioOrigen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvOperarioOrigen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FrmOficio As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents CmbOficio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FrmCategoria As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents CmbCategoria As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblCategoria As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridEXLayout2 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmHastaOperario = New Solmicro.Expertis.Engine.UI.Frame
        Me.FrmOficio = New Solmicro.Expertis.Engine.UI.Frame
        Me.CmbOficio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmCategoria = New Solmicro.Expertis.Engine.UI.Frame
        Me.CmbCategoria = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblCategoria = New Solmicro.Expertis.Engine.UI.Label
        Me.LblOperarioHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.LblOperarioDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvOperarioHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvOperarioDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FrmAñoCalendario = New Solmicro.Expertis.Engine.UI.Frame
        Me.TxtAñoCalendario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblCalendarioEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmDesdeOperario = New Solmicro.Expertis.Engine.UI.Frame
        Me.LblOperarioOrigen = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvOperarioOrigen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FrmHastaOperario.SuspendLayout()
        Me.FrmOficio.SuspendLayout()
        Me.FrmCategoria.SuspendLayout()
        Me.FrmAñoCalendario.SuspendLayout()
        Me.FrmDesdeOperario.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(224, 328)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(80, 32)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(128, 328)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(80, 32)
        Me.BtnAceptar.TabIndex = 9
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'FrmHastaOperario
        '
        Me.FrmHastaOperario.Controls.Add(Me.FrmOficio)
        Me.FrmHastaOperario.Controls.Add(Me.FrmCategoria)
        Me.FrmHastaOperario.Controls.Add(Me.LblOperarioHasta)
        Me.FrmHastaOperario.Controls.Add(Me.LblOperarioDesde)
        Me.FrmHastaOperario.Controls.Add(Me.AdvOperarioHasta)
        Me.FrmHastaOperario.Controls.Add(Me.AdvOperarioDesde)
        Me.FrmHastaOperario.Location = New System.Drawing.Point(8, 120)
        Me.FrmHastaOperario.Name = "FrmHastaOperario"
        Me.FrmHastaOperario.Size = New System.Drawing.Size(304, 200)
        Me.FrmHastaOperario.TabIndex = 2
        Me.FrmHastaOperario.TabStop = False
        Me.FrmHastaOperario.Text = "Operarios de Destino"
        '
        'FrmOficio
        '
        Me.FrmOficio.Controls.Add(Me.CmbOficio)
        Me.FrmOficio.Controls.Add(Me.Label4)
        Me.FrmOficio.Location = New System.Drawing.Point(8, 136)
        Me.FrmOficio.Name = "FrmOficio"
        Me.FrmOficio.Size = New System.Drawing.Size(288, 56)
        Me.FrmOficio.TabIndex = 9
        Me.FrmOficio.TabStop = False
        Me.FrmOficio.Text = "Oficio"
        '
        'CmbOficio
        '
        Me.CmbOficio.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDOficio""><C" & _
        "aption>Oficio</Caption><DataMember>IDOficio</DataMember><Key>IDOficio</Key><Posi" & _
        "tion>0</Position><Width>80</Width></Column0><Column1 ID=""DescOficio""><Caption>De" & _
        "sc. Oficio</Caption><DataMember>DescOficio</DataMember><Key>DescOficio</Key><Pos" & _
        "ition>1</Position><Width>150</Width></Column1></Columns><GroupCondition ID="""" />" & _
        "<SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>0</ColIndex></Sort" & _
        "Key0></SortKeys></RootTable><RowWithErrorsFormatStyle><PredefinedStyle>RowWithEr" & _
        "rorsFormatStyle</PredefinedStyle></RowWithErrorsFormatStyle><LinkFormatStyle><Pr" & _
        "edefinedStyle>LinkFormatStyle</PredefinedStyle></LinkFormatStyle><CardCaptionFor" & _
        "matStyle><PredefinedStyle>CardCaptionFormatStyle</PredefinedStyle></CardCaptionF" & _
        "ormatStyle><GroupByBoxInfoFormatStyle><PredefinedStyle>GroupByBoxInfoFormatStyle" & _
        "</PredefinedStyle></GroupByBoxInfoFormatStyle><GroupRowFormatStyle><PredefinedSt" & _
        "yle>GroupRowFormatStyle</PredefinedStyle></GroupRowFormatStyle><HeaderFormatStyl" & _
        "e><PredefinedStyle>HeaderFormatStyle</PredefinedStyle></HeaderFormatStyle><Previ" & _
        "ewRowFormatStyle><PredefinedStyle>PreviewRowFormatStyle</PredefinedStyle></Previ" & _
        "ewRowFormatStyle><RowFormatStyle><PredefinedStyle>RowFormatStyle</PredefinedStyl" & _
        "e></RowFormatStyle><SelectedFormatStyle><PredefinedStyle>SelectedFormatStyle</Pr" & _
        "edefinedStyle></SelectedFormatStyle><SelectedInactiveFormatStyle><PredefinedStyl" & _
        "e>SelectedInactiveFormatStyle</PredefinedStyle></SelectedInactiveFormatStyle><Wa" & _
        "termarkImage /><BorderStyle>Flat</BorderStyle><FlatBorderColor>125, 159, 190</Fl" & _
        "atBorderColor><ControlStyle><ButtonAppearance>Flat</ButtonAppearance></ControlSt" & _
        "yle><VisualStyle>Standard</VisualStyle><AllowEdit>False</AllowEdit><ExpandableGr" & _
        "oups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><HideSe" & _
        "lection>Highlight</HideSelection><DisplayMember>DescOficio</DisplayMember><Value" & _
        "Member>IDOficio</ValueMember></GridEXLayoutData>"
        Me.CmbOficio.DesignTimeLayout = GridEXLayout1
        Me.CmbOficio.DisplayMember = "DescOficio"
        Me.CmbOficio.Location = New System.Drawing.Point(128, 24)
        Me.CmbOficio.Name = "CmbOficio"
        Me.CmbOficio.SelectedIndex = -1
        Me.CmbOficio.SelectedItem = Nothing
        Me.CmbOficio.Size = New System.Drawing.Size(128, 21)
        Me.CmbOficio.TabIndex = 8
        Me.CmbOficio.Value = Nothing
        Me.CmbOficio.ValueMember = "IDOficio"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Oficio"
        '
        'FrmCategoria
        '
        Me.FrmCategoria.Controls.Add(Me.CmbCategoria)
        Me.FrmCategoria.Controls.Add(Me.LblCategoria)
        Me.FrmCategoria.Location = New System.Drawing.Point(8, 80)
        Me.FrmCategoria.Name = "FrmCategoria"
        Me.FrmCategoria.Size = New System.Drawing.Size(288, 56)
        Me.FrmCategoria.TabIndex = 8
        Me.FrmCategoria.TabStop = False
        Me.FrmCategoria.Text = "Categoría"
        '
        'CmbCategoria
        '
        Me.CmbCategoria.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        GridEXLayout2.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDCategoria""" & _
        "><Caption>Categoría</Caption><DataMember>IDCategoria</DataMember><Key>IDCategori" & _
        "a</Key><Position>0</Position></Column0><Column1 ID=""DescCategoria""><Caption>Desc" & _
        "ripción</Caption><DataMember>DescCategoria</DataMember><Key>DescCategoria</Key><" & _
        "Position>1</Position><Width>150</Width></Column1></Columns><GroupCondition ID=""""" & _
        " /><SortKeys Collection=""true""><SortKey0 ID=""SortKey0""><ColIndex>0</ColIndex></S" & _
        "ortKey0></SortKeys></RootTable><RowWithErrorsFormatStyle><PredefinedStyle>RowWit" & _
        "hErrorsFormatStyle</PredefinedStyle></RowWithErrorsFormatStyle><LinkFormatStyle>" & _
        "<PredefinedStyle>LinkFormatStyle</PredefinedStyle></LinkFormatStyle><CardCaption" & _
        "FormatStyle><PredefinedStyle>CardCaptionFormatStyle</PredefinedStyle></CardCapti" & _
        "onFormatStyle><GroupByBoxInfoFormatStyle><PredefinedStyle>GroupByBoxInfoFormatSt" & _
        "yle</PredefinedStyle></GroupByBoxInfoFormatStyle><GroupRowFormatStyle><Predefine" & _
        "dStyle>GroupRowFormatStyle</PredefinedStyle></GroupRowFormatStyle><HeaderFormatS" & _
        "tyle><PredefinedStyle>HeaderFormatStyle</PredefinedStyle></HeaderFormatStyle><Pr" & _
        "eviewRowFormatStyle><PredefinedStyle>PreviewRowFormatStyle</PredefinedStyle></Pr" & _
        "eviewRowFormatStyle><RowFormatStyle><PredefinedStyle>RowFormatStyle</PredefinedS" & _
        "tyle></RowFormatStyle><SelectedFormatStyle><PredefinedStyle>SelectedFormatStyle<" & _
        "/PredefinedStyle></SelectedFormatStyle><SelectedInactiveFormatStyle><PredefinedS" & _
        "tyle>SelectedInactiveFormatStyle</PredefinedStyle></SelectedInactiveFormatStyle>" & _
        "<WatermarkImage /><BorderStyle>Flat</BorderStyle><FlatBorderColor>125, 159, 190<" & _
        "/FlatBorderColor><ControlStyle><ButtonAppearance>Flat</ButtonAppearance></Contro" & _
        "lStyle><VisualStyle>Standard</VisualStyle><AllowEdit>False</AllowEdit><Expandabl" & _
        "eGroups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><Hid" & _
        "eSelection>Highlight</HideSelection><DisplayMember>IDCategoria</DisplayMember><V" & _
        "alueMember>IDCategoria</ValueMember></GridEXLayoutData>"
        Me.CmbCategoria.DesignTimeLayout = GridEXLayout2
        Me.CmbCategoria.DisplayMember = "IDCategoria"
        Me.CmbCategoria.Location = New System.Drawing.Point(128, 24)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.SelectedIndex = -1
        Me.CmbCategoria.SelectedItem = Nothing
        Me.CmbCategoria.Size = New System.Drawing.Size(128, 21)
        Me.CmbCategoria.TabIndex = 6
        Me.CmbCategoria.Value = Nothing
        Me.CmbCategoria.ValueMember = "IDCategoria"
        '
        'LblCategoria
        '
        Me.LblCategoria.Location = New System.Drawing.Point(8, 24)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(59, 17)
        Me.LblCategoria.TabIndex = 2
        Me.LblCategoria.Text = "Categoría"
        '
        'LblOperarioHasta
        '
        Me.LblOperarioHasta.Location = New System.Drawing.Point(8, 56)
        Me.LblOperarioHasta.Name = "LblOperarioHasta"
        Me.LblOperarioHasta.Size = New System.Drawing.Size(90, 17)
        Me.LblOperarioHasta.TabIndex = 3
        Me.LblOperarioHasta.Text = "Operario Hasta"
        '
        'LblOperarioDesde
        '
        Me.LblOperarioDesde.Location = New System.Drawing.Point(8, 24)
        Me.LblOperarioDesde.Name = "LblOperarioDesde"
        Me.LblOperarioDesde.Size = New System.Drawing.Size(93, 17)
        Me.LblOperarioDesde.TabIndex = 2
        Me.LblOperarioDesde.Text = "Operario Desde"
        '
        'AdvOperarioHasta
        '
        Me.AdvOperarioHasta.DisplayField = "IDOperario"
        Me.AdvOperarioHasta.EntityName = "Operario"
        Me.AdvOperarioHasta.Location = New System.Drawing.Point(144, 56)
        Me.AdvOperarioHasta.Name = "AdvOperarioHasta"
        Me.AdvOperarioHasta.SecondaryDataFields = "IDOperario"
        Me.AdvOperarioHasta.Size = New System.Drawing.Size(120, 21)
        Me.AdvOperarioHasta.TabIndex = 4
        Me.AdvOperarioHasta.ViewName = "tbMaestroOperario"
        '
        'AdvOperarioDesde
        '
        Me.AdvOperarioDesde.DisplayField = "IDOperario"
        Me.AdvOperarioDesde.EntityName = "Operario"
        Me.AdvOperarioDesde.Location = New System.Drawing.Point(144, 24)
        Me.AdvOperarioDesde.Name = "AdvOperarioDesde"
        Me.AdvOperarioDesde.SecondaryDataFields = "IDOperario"
        Me.AdvOperarioDesde.Size = New System.Drawing.Size(120, 21)
        Me.AdvOperarioDesde.TabIndex = 3
        Me.AdvOperarioDesde.ViewName = "tbMaestroOperario"
        '
        'FrmAñoCalendario
        '
        Me.FrmAñoCalendario.Controls.Add(Me.TxtAñoCalendario)
        Me.FrmAñoCalendario.Controls.Add(Me.LblCalendarioEmpresa)
        Me.FrmAñoCalendario.Location = New System.Drawing.Point(8, 8)
        Me.FrmAñoCalendario.Name = "FrmAñoCalendario"
        Me.FrmAñoCalendario.Size = New System.Drawing.Size(304, 56)
        Me.FrmAñoCalendario.TabIndex = 10
        Me.FrmAñoCalendario.TabStop = False
        Me.FrmAñoCalendario.Text = "Año Calendario"
        '
        'TxtAñoCalendario
        '
        Me.TxtAñoCalendario.Enabled = False
        Me.TxtAñoCalendario.Location = New System.Drawing.Point(191, 24)
        Me.TxtAñoCalendario.Name = "TxtAñoCalendario"
        Me.TxtAñoCalendario.Size = New System.Drawing.Size(75, 21)
        Me.TxtAñoCalendario.TabIndex = 1
        '
        'LblCalendarioEmpresa
        '
        Me.LblCalendarioEmpresa.Location = New System.Drawing.Point(39, 24)
        Me.LblCalendarioEmpresa.Name = "LblCalendarioEmpresa"
        Me.LblCalendarioEmpresa.Size = New System.Drawing.Size(136, 17)
        Me.LblCalendarioEmpresa.TabIndex = 0
        Me.LblCalendarioEmpresa.Text = "Calendario de Empresa"
        '
        'FrmDesdeOperario
        '
        Me.FrmDesdeOperario.Controls.Add(Me.LblOperarioOrigen)
        Me.FrmDesdeOperario.Controls.Add(Me.AdvOperarioOrigen)
        Me.FrmDesdeOperario.Location = New System.Drawing.Point(8, 64)
        Me.FrmDesdeOperario.Name = "FrmDesdeOperario"
        Me.FrmDesdeOperario.Size = New System.Drawing.Size(304, 56)
        Me.FrmDesdeOperario.TabIndex = 0
        Me.FrmDesdeOperario.TabStop = False
        Me.FrmDesdeOperario.Text = "Operario de Origen"
        '
        'LblOperarioOrigen
        '
        Me.LblOperarioOrigen.Location = New System.Drawing.Point(8, 24)
        Me.LblOperarioOrigen.Name = "LblOperarioOrigen"
        Me.LblOperarioOrigen.Size = New System.Drawing.Size(95, 17)
        Me.LblOperarioOrigen.TabIndex = 4
        Me.LblOperarioOrigen.Text = "Operario Origen"
        '
        'AdvOperarioOrigen
        '
        Me.AdvOperarioOrigen.DisplayField = "IDOperario"
        Me.AdvOperarioOrigen.EntityName = "Operario"
        Me.AdvOperarioOrigen.Location = New System.Drawing.Point(144, 24)
        Me.AdvOperarioOrigen.Name = "AdvOperarioOrigen"
        Me.AdvOperarioOrigen.SecondaryDataFields = "IDOperario"
        Me.AdvOperarioOrigen.Size = New System.Drawing.Size(120, 21)
        Me.AdvOperarioOrigen.TabIndex = 1
        Me.AdvOperarioOrigen.ViewName = "tbMaestroOperario"
        '
        'FrmCopiaCalendarioOperario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(322, 367)
        Me.Controls.Add(Me.FrmHastaOperario)
        Me.Controls.Add(Me.FrmDesdeOperario)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.FrmAñoCalendario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCopiaCalendarioOperario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Copiar Calendarios Operarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.FrmHastaOperario.ResumeLayout(False)
        Me.FrmOficio.ResumeLayout(False)
        Me.FrmCategoria.ResumeLayout(False)
        Me.FrmAñoCalendario.ResumeLayout(False)
        Me.FrmDesdeOperario.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Privadas / Propiedades Públicas"

    Private MStrIDOperarioOrigen As String
    Private MStrIDOperarioDesde As String
    Private MStrIDOperarioHasta As String
    Private MStrIDCategoria As String
    Private MStrIDOficio As String
    Private MIntAño As Short

    Public ReadOnly Property OperarioOrigen() As String
        Get
            Return MStrIDOperarioOrigen
        End Get
    End Property

    Public ReadOnly Property OperarioDesde() As String
        Get
            Return MStrIDOperarioDesde
        End Get
    End Property

    Public ReadOnly Property OperarioHasta() As String
        Get
            Return MStrIDOperarioHasta
        End Get
    End Property

    Public ReadOnly Property Oficio() As String
        Get
            Return MStrIDOficio
        End Get
    End Property

    Public ReadOnly Property Categoria() As String
        Get
            Return MStrIDCategoria
        End Get
    End Property

    Public WriteOnly Property AñoCalendario() As Short
        Set(ByVal Value As Short)
            MIntAño = Value
        End Set
    End Property

#End Region

#Region "Funciones Privadas"

    Private Sub CargarCategorias()
        CmbCategoria.DataSource = New Categoria().Filter
    End Sub

    Private Sub CargarOficios()
        CmbOficio.DataSource = New Oficio().Filter
    End Sub

#End Region

#Region "Eventos FrmCopiaCalendarioCentro"

    Private Sub FrmCopiaCalendarioOperario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtAñoCalendario.Text = MIntAño
        CargarCategorias()
        CargarOficios()
    End Sub

#Region "Eventos Buttons"

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        If Length(AdvOperarioOrigen.Value) > 0 Then
            If Length(AdvOperarioDesde.Text) > 0 OrElse _
            Length(AdvOperarioHasta.Text) > 0 OrElse _
            Length(CmbOficio.Value & String.Empty) > 0 OrElse _
            Length(CmbCategoria.Value & String.Empty) > 0 Then
                MStrIDOperarioOrigen = Nz(AdvOperarioOrigen.Value, String.Empty)
                MStrIDOperarioDesde = Nz(AdvOperarioDesde.Text, String.Empty)
                MStrIDOperarioHasta = Nz(AdvOperarioHasta.Text, String.Empty)
                MStrIDOficio = Nz(CmbOficio.Value, String.Empty)
                MStrIDCategoria = Nz(CmbCategoria.Value, String.Empty)
                Me.DialogResult = DialogResult.OK
            Else
                ExpertisApp.GenerateMessage("Debe establecer algún parámetro para copiar el calendario.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            ExpertisApp.GenerateMessage("Debe establecer un operario de origen para la copia del calendario.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

#End Region

End Class