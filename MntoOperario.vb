Imports Solmicro.Expertis.Business.ClasesTecozam
Imports Solmicro.Expertis.Engine.DAL
Imports OfficeOpenXml
Imports Solmicro.Expertis.Engine

Public Class MntoOperario
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

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
    Public WithEvents PicFichaOperario As Solmicro.Expertis.Engine.UI.Panel

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Private WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents pnlFichaOperario As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents chkExterno As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents FraCondEco As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents CmbCurriculum As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblCategoria As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblSucursal As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtSucursal As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblDigitoControl As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtDigitoControl As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblNCuenta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNCuenta As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescFormaPago As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvIDFormaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblBanco As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescBanco As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advIDBanco As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblIDoperario As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtDescOperario As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblFechaAlta As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaAlta As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents lblDNI As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtDNI As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents ulDescCategoria As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvIDCategoria As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblTexto As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblOficio As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescOficio As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advIdOficio As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblDepartamento As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents ulDescDepartamento As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents AdvIDDepartamento As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblCurriculum As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCurriculum As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblUsuario As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxUsuario As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblApellidos As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtApellidos As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblNombre As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNombre As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblDescOperario As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents CmbTipoDocIdent As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents LblTipoDocIdent As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblCodigoIBAN As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtCodigoIBAN As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblSwift As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtSwift As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents CntIDOperario As Solmicro.Expertis.Engine.UI.CounterTextBox
    Public WithEvents chkNoContratar As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkAviso9m As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents FraDatosContacto As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblFax As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtFax As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents ulDescPais As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents advPoblacion As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents advCodPostal As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblCP As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents advIDPais As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents txtProvincia As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblDireccion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblPoblacion As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblProvincia As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblIDPais As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtEmail As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtTelefono3 As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtTelefono2 As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents txtTelefono As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents lblTelefono As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblEmail As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDireccion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtN_Social As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblN_Social As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTipoContrato As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTipoContrato As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents clbFecha_Reconocimiento As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFecha_Reconocimiento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Frame2 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblFLugar20 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFLugar8 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtLugar As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtFLugar20 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtFLugar8 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents clbFFormacion60 As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents clbFFormacion8 As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents clbFFormacion20 As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFLugar60 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtFLugar60 As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtTextoCondiciones As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTextoCondiciones As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbC_H_E As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblC_H_E As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbC_H_X As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblC_H_X As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbC_H_N As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblC_H_N As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulObra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents advObra_Predeterminada As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblObra_Predeterminada As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chbTodas_Obras As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblTodas_Obras As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblAmortizacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPlus As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbJornada_Laboral As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblJornada_Laboral As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbAmortizacion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ntbPlus As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ntbEmbargo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblEmbargo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbDieta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDieta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbSueldo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblSueldo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbAnticipo_Fijo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblAnticipo_Fijo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnHistorico As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents chbIncentivos As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblIncentivos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents GridHistorico As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents chbPermisoGD As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblPermisoGD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaNacimiento As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnGenIBAN As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents bHistoricoProyecto As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents GridHistoricoPersonal As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents txtDiccionario As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblDiccionario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIDGET As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblIDGET As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblsortcode As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtaccountNumber As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblaccountNumber As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtsortcode As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ntbJornadaParcial As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblJornadaParcial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chbFirmaApp As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblFirmaApp As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaBaja As Solmicro.Expertis.Engine.UI.CalendarBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridHistoricoPersonal_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoOperario))
        Dim GridHistorico_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbTipoDocIdent_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxUsuario_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.PicFichaOperario = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDiccionario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDiccionario = New Solmicro.Expertis.Engine.UI.Label
        Me.GridHistoricoPersonal = New Solmicro.Expertis.Engine.UI.Grid
        Me.bHistoricoProyecto = New Solmicro.Expertis.Engine.UI.Button
        Me.chbIncentivos = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblIncentivos = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbAnticipo_Fijo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblAnticipo_Fijo = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbEmbargo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblEmbargo = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbDieta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDieta = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbSueldo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblSueldo = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbAmortizacion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ntbPlus = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblAmortizacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPlus = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbJornada_Laboral = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblJornada_Laboral = New Solmicro.Expertis.Engine.UI.Label
        Me.chbTodas_Obras = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblTodas_Obras = New Solmicro.Expertis.Engine.UI.Label
        Me.ulObra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advObra_Predeterminada = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblObra_Predeterminada = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbC_H_E = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblC_H_E = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbC_H_X = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblC_H_X = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbC_H_N = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblC_H_N = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlFichaOperario = New Solmicro.Expertis.Engine.UI.Panel
        Me.ntbJornadaParcial = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblJornadaParcial = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDGET = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblIDGET = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaNacimiento = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.chbPermisoGD = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblPermisoGD = New Solmicro.Expertis.Engine.UI.Label
        Me.GridHistorico = New Solmicro.Expertis.Engine.UI.Grid
        Me.btnHistorico = New Solmicro.Expertis.Engine.UI.Button
        Me.txtTextoCondiciones = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTextoCondiciones = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Frame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtFLugar60 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtFLugar20 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtFLugar8 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.clbFFormacion60 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.clbFFormacion8 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.clbFFormacion20 = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFLugar60 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFLugar20 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFLugar8 = New Solmicro.Expertis.Engine.UI.Label
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtLugar = New Solmicro.Expertis.Engine.UI.TextBox
        Me.clbFecha_Reconocimiento = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFecha_Reconocimiento = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTipoContrato = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTipoContrato = New Solmicro.Expertis.Engine.UI.Label
        Me.txtN_Social = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblN_Social = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaBaja = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.chkAviso9m = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkNoContratar = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.CntIDOperario = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.CmbTipoDocIdent = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.LblTipoDocIdent = New Solmicro.Expertis.Engine.UI.Label
        Me.FraDatosContacto = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtDireccion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFax = New Solmicro.Expertis.Engine.UI.Label
        Me.txtFax = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ulDescPais = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advPoblacion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advCodPostal = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCP = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDPais = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtProvincia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDireccion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPoblacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblProvincia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDPais = New Solmicro.Expertis.Engine.UI.Label
        Me.txtEmail = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtTelefono3 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtTelefono2 = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtTelefono = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTelefono = New Solmicro.Expertis.Engine.UI.Label
        Me.lblEmail = New Solmicro.Expertis.Engine.UI.Label
        Me.chkExterno = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblDescOperario = New Solmicro.Expertis.Engine.UI.Label
        Me.lblApellidos = New Solmicro.Expertis.Engine.UI.Label
        Me.txtApellidos = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNombre = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNombre = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCategoria = New Solmicro.Expertis.Engine.UI.Label
        Me.FraCondEco = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtaccountNumber = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblaccountNumber = New Solmicro.Expertis.Engine.UI.Label
        Me.txtsortcode = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblsortcode = New Solmicro.Expertis.Engine.UI.Label
        Me.btnGenIBAN = New Solmicro.Expertis.Engine.UI.Button
        Me.lblSwift = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSwift = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodigoIBAN = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodigoIBAN = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSucursal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSucursal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDigitoControl = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDigitoControl = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNCuenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNCuenta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescFormaPago = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDFormaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblBanco = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescBanco = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIDBanco = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDoperario = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescOperario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaAlta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaAlta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblDNI = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDNI = New Solmicro.Expertis.Engine.UI.TextBox
        Me.ulDescCategoria = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDCategoria = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblTexto = New Solmicro.Expertis.Engine.UI.Label
        Me.lblOficio = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescOficio = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.advIdOficio = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblDepartamento = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescDepartamento = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDDepartamento = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.CmbCurriculum = New Solmicro.Expertis.Engine.UI.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lblCurriculum = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCurriculum = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblUsuario = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxUsuario = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.chbFirmaApp = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblFirmaApp = New Solmicro.Expertis.Engine.UI.Label
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.PicFichaOperario.suspendlayout()
        CType(Me.GridHistoricoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFichaOperario.suspendlayout()
        CType(Me.GridHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.CmbTipoDocIdent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraDatosContacto.SuspendLayout()
        Me.FraCondEco.SuspendLayout()
        CType(Me.cbxUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.PicFichaOperario)
        Me.MainPanel.Size = New System.Drawing.Size(991, 767)
        '
        'PicFichaOperario
        '
        Me.PicFichaOperario.Controls.Add(Me.txtDiccionario)
        Me.PicFichaOperario.Controls.Add(Me.lblDiccionario)
        Me.PicFichaOperario.Controls.Add(Me.GridHistoricoPersonal)
        Me.PicFichaOperario.Controls.Add(Me.bHistoricoProyecto)
        Me.PicFichaOperario.Controls.Add(Me.chbIncentivos)
        Me.PicFichaOperario.Controls.Add(Me.lblIncentivos)
        Me.PicFichaOperario.Controls.Add(Me.ntbAnticipo_Fijo)
        Me.PicFichaOperario.Controls.Add(Me.lblAnticipo_Fijo)
        Me.PicFichaOperario.Controls.Add(Me.ntbVarios)
        Me.PicFichaOperario.Controls.Add(Me.lblVarios)
        Me.PicFichaOperario.Controls.Add(Me.ntbEmbargo)
        Me.PicFichaOperario.Controls.Add(Me.lblEmbargo)
        Me.PicFichaOperario.Controls.Add(Me.ntbDieta)
        Me.PicFichaOperario.Controls.Add(Me.lblDieta)
        Me.PicFichaOperario.Controls.Add(Me.ntbSueldo)
        Me.PicFichaOperario.Controls.Add(Me.lblSueldo)
        Me.PicFichaOperario.Controls.Add(Me.ntbAmortizacion)
        Me.PicFichaOperario.Controls.Add(Me.ntbPlus)
        Me.PicFichaOperario.Controls.Add(Me.lblAmortizacion)
        Me.PicFichaOperario.Controls.Add(Me.lblPlus)
        Me.PicFichaOperario.Controls.Add(Me.ntbJornada_Laboral)
        Me.PicFichaOperario.Controls.Add(Me.lblJornada_Laboral)
        Me.PicFichaOperario.Controls.Add(Me.chbTodas_Obras)
        Me.PicFichaOperario.Controls.Add(Me.lblTodas_Obras)
        Me.PicFichaOperario.Controls.Add(Me.ulObra)
        Me.PicFichaOperario.Controls.Add(Me.advObra_Predeterminada)
        Me.PicFichaOperario.Controls.Add(Me.lblObra_Predeterminada)
        Me.PicFichaOperario.Controls.Add(Me.ntbC_H_E)
        Me.PicFichaOperario.Controls.Add(Me.lblC_H_E)
        Me.PicFichaOperario.Controls.Add(Me.ntbC_H_X)
        Me.PicFichaOperario.Controls.Add(Me.lblC_H_X)
        Me.PicFichaOperario.Controls.Add(Me.ntbC_H_N)
        Me.PicFichaOperario.Controls.Add(Me.lblC_H_N)
        Me.PicFichaOperario.Controls.Add(Me.pnlFichaOperario)
        Me.PicFichaOperario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicFichaOperario.Location = New System.Drawing.Point(0, 0)
        Me.PicFichaOperario.Name = "PicFichaOperario"
        Me.PicFichaOperario.Size = New System.Drawing.Size(991, 767)
        Me.PicFichaOperario.TabIndex = 1
        '
        'txtDiccionario
        '
        Me.TryDataBinding(txtDiccionario, New System.Windows.Forms.Binding("Text", Me, "Diccionario", True))
        Me.txtDiccionario.DisabledBackColor = System.Drawing.Color.White
        Me.txtDiccionario.Location = New System.Drawing.Point(802, 743)
        Me.txtDiccionario.Name = "txtDiccionario"
        Me.txtDiccionario.Size = New System.Drawing.Size(176, 21)
        Me.txtDiccionario.TabIndex = 34
        '
        'lblDiccionario
        '
        Me.lblDiccionario.Location = New System.Drawing.Point(693, 747)
        Me.lblDiccionario.Name = "lblDiccionario"
        Me.lblDiccionario.Size = New System.Drawing.Size(70, 13)
        Me.lblDiccionario.TabIndex = 35
        Me.lblDiccionario.Text = "Diccionario"
        '
        'GridHistoricoPersonal
        '
        Me.GridHistoricoPersonal.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridHistoricoPersonal.ColumnAutoResize = True
        GridHistoricoPersonal_DesignTimeLayout.LayoutString = resources.GetString("GridHistoricoPersonal_DesignTimeLayout.LayoutString")
        Me.GridHistoricoPersonal.DesignTimeLayout = GridHistoricoPersonal_DesignTimeLayout
        Me.GridHistoricoPersonal.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridHistoricoPersonal.EntityName = "HistoricoPersonal"
        Me.GridHistoricoPersonal.KeyField = "IDOperario"
        Me.GridHistoricoPersonal.Location = New System.Drawing.Point(369, 661)
        Me.GridHistoricoPersonal.Name = "GridHistoricoPersonal"
        Me.GridHistoricoPersonal.PrimaryDataFields = "IDOperario"
        Me.GridHistoricoPersonal.SecondaryDataFields = "IDOperario"
        Me.GridHistoricoPersonal.Size = New System.Drawing.Size(250, 76)
        Me.GridHistoricoPersonal.TabIndex = 33
        Me.GridHistoricoPersonal.ViewName = "tbHistoricoPersonal"
        Me.GridHistoricoPersonal.Visible = False
        '
        'bHistoricoProyecto
        '
        Me.bHistoricoProyecto.Location = New System.Drawing.Point(21, 737)
        Me.bHistoricoProyecto.Name = "bHistoricoProyecto"
        Me.bHistoricoProyecto.Size = New System.Drawing.Size(171, 23)
        Me.bHistoricoProyecto.TabIndex = 32
        Me.bHistoricoProyecto.Text = "Historico Proyecto"
        '
        'chbIncentivos
        '
        Me.TryDataBinding(chbIncentivos, New System.Windows.Forms.Binding("BindableValue", Me, "Incentivos", True))
        Me.chbIncentivos.Location = New System.Drawing.Point(230, 720)
        Me.chbIncentivos.Name = "chbIncentivos"
        Me.chbIncentivos.Size = New System.Drawing.Size(15, 15)
        Me.chbIncentivos.TabIndex = 30
        '
        'lblIncentivos
        '
        Me.lblIncentivos.Location = New System.Drawing.Point(18, 720)
        Me.lblIncentivos.Name = "lblIncentivos"
        Me.lblIncentivos.Size = New System.Drawing.Size(66, 13)
        Me.lblIncentivos.TabIndex = 31
        Me.lblIncentivos.Text = "Incentivos"
        '
        'ntbAnticipo_Fijo
        '
        Me.TryDataBinding(ntbAnticipo_Fijo, New System.Windows.Forms.Binding("Value", Me, "Anticipo_Fijo", True))
        Me.ntbAnticipo_Fijo.DisabledBackColor = System.Drawing.Color.White
        Me.ntbAnticipo_Fijo.Location = New System.Drawing.Point(802, 716)
        Me.ntbAnticipo_Fijo.Name = "ntbAnticipo_Fijo"
        Me.ntbAnticipo_Fijo.Size = New System.Drawing.Size(176, 21)
        Me.ntbAnticipo_Fijo.TabIndex = 28
        '
        'lblAnticipo_Fijo
        '
        Me.lblAnticipo_Fijo.Location = New System.Drawing.Point(693, 720)
        Me.lblAnticipo_Fijo.Name = "lblAnticipo_Fijo"
        Me.lblAnticipo_Fijo.Size = New System.Drawing.Size(79, 13)
        Me.lblAnticipo_Fijo.TabIndex = 29
        Me.lblAnticipo_Fijo.Text = "Anticipo_Fijo"
        '
        'ntbVarios
        '
        Me.TryDataBinding(ntbVarios, New System.Windows.Forms.Binding("Value", Me, "Varios", True))
        Me.ntbVarios.DisabledBackColor = System.Drawing.Color.White
        Me.ntbVarios.Location = New System.Drawing.Point(442, 716)
        Me.ntbVarios.Name = "ntbVarios"
        Me.ntbVarios.Size = New System.Drawing.Size(177, 21)
        Me.ntbVarios.TabIndex = 26
        '
        'lblVarios
        '
        Me.lblVarios.Location = New System.Drawing.Point(371, 720)
        Me.lblVarios.Name = "lblVarios"
        Me.lblVarios.Size = New System.Drawing.Size(42, 13)
        Me.lblVarios.TabIndex = 27
        Me.lblVarios.Text = "Varios"
        '
        'ntbEmbargo
        '
        Me.TryDataBinding(ntbEmbargo, New System.Windows.Forms.Binding("Value", Me, "Embargo", True))
        Me.ntbEmbargo.DisabledBackColor = System.Drawing.Color.White
        Me.ntbEmbargo.Location = New System.Drawing.Point(802, 689)
        Me.ntbEmbargo.Name = "ntbEmbargo"
        Me.ntbEmbargo.Size = New System.Drawing.Size(176, 21)
        Me.ntbEmbargo.TabIndex = 24
        '
        'lblEmbargo
        '
        Me.lblEmbargo.Location = New System.Drawing.Point(693, 693)
        Me.lblEmbargo.Name = "lblEmbargo"
        Me.lblEmbargo.Size = New System.Drawing.Size(33, 13)
        Me.lblEmbargo.TabIndex = 25
        Me.lblEmbargo.Text = "IRPF"
        '
        'ntbDieta
        '
        Me.TryDataBinding(ntbDieta, New System.Windows.Forms.Binding("Value", Me, "Dieta", True))
        Me.ntbDieta.DisabledBackColor = System.Drawing.Color.White
        Me.ntbDieta.Location = New System.Drawing.Point(442, 689)
        Me.ntbDieta.Name = "ntbDieta"
        Me.ntbDieta.Size = New System.Drawing.Size(177, 21)
        Me.ntbDieta.TabIndex = 22
        '
        'lblDieta
        '
        Me.lblDieta.Location = New System.Drawing.Point(371, 693)
        Me.lblDieta.Name = "lblDieta"
        Me.lblDieta.Size = New System.Drawing.Size(37, 13)
        Me.lblDieta.TabIndex = 23
        Me.lblDieta.Text = "Dieta"
        '
        'ntbSueldo
        '
        Me.TryDataBinding(ntbSueldo, New System.Windows.Forms.Binding("Value", Me, "Sueldo", True))
        Me.ntbSueldo.DisabledBackColor = System.Drawing.Color.White
        Me.ntbSueldo.Location = New System.Drawing.Point(157, 689)
        Me.ntbSueldo.Name = "ntbSueldo"
        Me.ntbSueldo.Size = New System.Drawing.Size(176, 21)
        Me.ntbSueldo.TabIndex = 20
        '
        'lblSueldo
        '
        Me.lblSueldo.Location = New System.Drawing.Point(18, 693)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(46, 13)
        Me.lblSueldo.TabIndex = 21
        Me.lblSueldo.Text = "Sueldo"
        '
        'ntbAmortizacion
        '
        Me.TryDataBinding(ntbAmortizacion, New System.Windows.Forms.Binding("Value", Me, "Amortizacion", True))
        Me.ntbAmortizacion.DisabledBackColor = System.Drawing.Color.White
        Me.ntbAmortizacion.Location = New System.Drawing.Point(802, 661)
        Me.ntbAmortizacion.Name = "ntbAmortizacion"
        Me.ntbAmortizacion.Size = New System.Drawing.Size(176, 21)
        Me.ntbAmortizacion.TabIndex = 19
        '
        'ntbPlus
        '
        Me.TryDataBinding(ntbPlus, New System.Windows.Forms.Binding("Value", Me, "Plus", True))
        Me.ntbPlus.DisabledBackColor = System.Drawing.Color.White
        Me.ntbPlus.Location = New System.Drawing.Point(442, 661)
        Me.ntbPlus.Name = "ntbPlus"
        Me.ntbPlus.Size = New System.Drawing.Size(177, 21)
        Me.ntbPlus.TabIndex = 18
        '
        'lblAmortizacion
        '
        Me.lblAmortizacion.Location = New System.Drawing.Point(693, 665)
        Me.lblAmortizacion.Name = "lblAmortizacion"
        Me.lblAmortizacion.Size = New System.Drawing.Size(81, 13)
        Me.lblAmortizacion.TabIndex = 17
        Me.lblAmortizacion.Text = "Amortizacion"
        '
        'lblPlus
        '
        Me.lblPlus.Location = New System.Drawing.Point(371, 665)
        Me.lblPlus.Name = "lblPlus"
        Me.lblPlus.Size = New System.Drawing.Size(30, 13)
        Me.lblPlus.TabIndex = 15
        Me.lblPlus.Text = "Plus"
        '
        'ntbJornada_Laboral
        '
        Me.TryDataBinding(ntbJornada_Laboral, New System.Windows.Forms.Binding("Value", Me, "Jornada_Laboral", True))
        Me.ntbJornada_Laboral.DisabledBackColor = System.Drawing.Color.White
        Me.ntbJornada_Laboral.Location = New System.Drawing.Point(157, 661)
        Me.ntbJornada_Laboral.Name = "ntbJornada_Laboral"
        Me.ntbJornada_Laboral.Size = New System.Drawing.Size(176, 21)
        Me.ntbJornada_Laboral.TabIndex = 12
        '
        'lblJornada_Laboral
        '
        Me.lblJornada_Laboral.Location = New System.Drawing.Point(18, 665)
        Me.lblJornada_Laboral.Name = "lblJornada_Laboral"
        Me.lblJornada_Laboral.Size = New System.Drawing.Size(101, 13)
        Me.lblJornada_Laboral.TabIndex = 13
        Me.lblJornada_Laboral.Text = "Jornada_Laboral"
        '
        'chbTodas_Obras
        '
        Me.TryDataBinding(chbTodas_Obras, New System.Windows.Forms.Binding("BindableValue", Me, "Todas_Obras", True))
        Me.chbTodas_Obras.Location = New System.Drawing.Point(876, 640)
        Me.chbTodas_Obras.Name = "chbTodas_Obras"
        Me.chbTodas_Obras.Size = New System.Drawing.Size(15, 15)
        Me.chbTodas_Obras.TabIndex = 10
        '
        'lblTodas_Obras
        '
        Me.lblTodas_Obras.Location = New System.Drawing.Point(756, 642)
        Me.lblTodas_Obras.Name = "lblTodas_Obras"
        Me.lblTodas_Obras.Size = New System.Drawing.Size(81, 13)
        Me.lblTodas_Obras.TabIndex = 11
        Me.lblTodas_Obras.Text = "Todas_Obras"
        '
        'ulObra
        '
        Me.TryDataBinding(ulObra, New System.Windows.Forms.Binding("Text", Me.advObra_Predeterminada, "DescObra", True))
        Me.ulObra.Location = New System.Drawing.Point(368, 642)
        Me.ulObra.Name = "ulObra"
        Me.ulObra.Size = New System.Drawing.Size(280, 13)
        Me.ulObra.TabIndex = 9
        '
        'advObra_Predeterminada
        '
        Me.TryDataBinding(advObra_Predeterminada, New System.Windows.Forms.Binding("Text", Me, "Obra_Predeterminada", True))
        Me.advObra_Predeterminada.DisabledBackColor = System.Drawing.Color.White
        Me.advObra_Predeterminada.DisplayField = "IDObra"
        Me.advObra_Predeterminada.EntityName = "ObraCabecera"
        Me.advObra_Predeterminada.Location = New System.Drawing.Point(157, 632)
        Me.advObra_Predeterminada.Name = "advObra_Predeterminada"
        Me.advObra_Predeterminada.Size = New System.Drawing.Size(176, 23)
        Me.advObra_Predeterminada.TabIndex = 7
        '
        'lblObra_Predeterminada
        '
        Me.lblObra_Predeterminada.Location = New System.Drawing.Point(18, 637)
        Me.lblObra_Predeterminada.Name = "lblObra_Predeterminada"
        Me.lblObra_Predeterminada.Size = New System.Drawing.Size(133, 13)
        Me.lblObra_Predeterminada.TabIndex = 8
        Me.lblObra_Predeterminada.Text = "Obra_Predeterminada"
        '
        'ntbC_H_E
        '
        Me.TryDataBinding(ntbC_H_E, New System.Windows.Forms.Binding("Value", Me, "C_H_E", True))
        Me.ntbC_H_E.DisabledBackColor = System.Drawing.Color.White
        Me.ntbC_H_E.Location = New System.Drawing.Point(802, 606)
        Me.ntbC_H_E.Name = "ntbC_H_E"
        Me.ntbC_H_E.Size = New System.Drawing.Size(177, 21)
        Me.ntbC_H_E.TabIndex = 5
        '
        'lblC_H_E
        '
        Me.lblC_H_E.Location = New System.Drawing.Point(693, 610)
        Me.lblC_H_E.Name = "lblC_H_E"
        Me.lblC_H_E.Size = New System.Drawing.Size(84, 13)
        Me.lblC_H_E.TabIndex = 6
        Me.lblC_H_E.Text = "Hora Especial"
        '
        'ntbC_H_X
        '
        Me.TryDataBinding(ntbC_H_X, New System.Windows.Forms.Binding("Value", Me, "C_H_X", True))
        Me.ntbC_H_X.DisabledBackColor = System.Drawing.Color.White
        Me.ntbC_H_X.Location = New System.Drawing.Point(442, 606)
        Me.ntbC_H_X.Name = "ntbC_H_X"
        Me.ntbC_H_X.Size = New System.Drawing.Size(177, 21)
        Me.ntbC_H_X.TabIndex = 3
        '
        'lblC_H_X
        '
        Me.lblC_H_X.Location = New System.Drawing.Point(368, 610)
        Me.lblC_H_X.Name = "lblC_H_X"
        Me.lblC_H_X.Size = New System.Drawing.Size(68, 13)
        Me.lblC_H_X.TabIndex = 4
        Me.lblC_H_X.Text = "Hora Extra"
        '
        'ntbC_H_N
        '
        Me.TryDataBinding(ntbC_H_N, New System.Windows.Forms.Binding("Value", Me, "C_H_N", True))
        Me.ntbC_H_N.DisabledBackColor = System.Drawing.Color.White
        Me.ntbC_H_N.Location = New System.Drawing.Point(157, 606)
        Me.ntbC_H_N.Name = "ntbC_H_N"
        Me.ntbC_H_N.Size = New System.Drawing.Size(176, 21)
        Me.ntbC_H_N.TabIndex = 1
        '
        'lblC_H_N
        '
        Me.lblC_H_N.Location = New System.Drawing.Point(17, 610)
        Me.lblC_H_N.Name = "lblC_H_N"
        Me.lblC_H_N.Size = New System.Drawing.Size(79, 13)
        Me.lblC_H_N.TabIndex = 2
        Me.lblC_H_N.Text = "Hora Normal"
        '
        'pnlFichaOperario
        '
        Me.pnlFichaOperario.Controls.Add(Me.chbFirmaApp)
        Me.pnlFichaOperario.Controls.Add(Me.lblFirmaApp)
        Me.pnlFichaOperario.Controls.Add(Me.ntbJornadaParcial)
        Me.pnlFichaOperario.Controls.Add(Me.lblJornadaParcial)
        Me.pnlFichaOperario.Controls.Add(Me.txtIDGET)
        Me.pnlFichaOperario.Controls.Add(Me.lblIDGET)
        Me.pnlFichaOperario.Controls.Add(Me.cbxFechaNacimiento)
        Me.pnlFichaOperario.Controls.Add(Me.Label2)
        Me.pnlFichaOperario.Controls.Add(Me.chbPermisoGD)
        Me.pnlFichaOperario.Controls.Add(Me.lblPermisoGD)
        Me.pnlFichaOperario.Controls.Add(Me.GridHistorico)
        Me.pnlFichaOperario.Controls.Add(Me.btnHistorico)
        Me.pnlFichaOperario.Controls.Add(Me.txtTextoCondiciones)
        Me.pnlFichaOperario.Controls.Add(Me.lblTextoCondiciones)
        Me.pnlFichaOperario.Controls.Add(Me.txtTexto)
        Me.pnlFichaOperario.Controls.Add(Me.Frame2)
        Me.pnlFichaOperario.Controls.Add(Me.Frame1)
        Me.pnlFichaOperario.Controls.Add(Me.txtTipoContrato)
        Me.pnlFichaOperario.Controls.Add(Me.lblTipoContrato)
        Me.pnlFichaOperario.Controls.Add(Me.txtN_Social)
        Me.pnlFichaOperario.Controls.Add(Me.lblN_Social)
        Me.pnlFichaOperario.Controls.Add(Me.Label1)
        Me.pnlFichaOperario.Controls.Add(Me.cbxFechaBaja)
        Me.pnlFichaOperario.Controls.Add(Me.chkAviso9m)
        Me.pnlFichaOperario.Controls.Add(Me.chkNoContratar)
        Me.pnlFichaOperario.Controls.Add(Me.CntIDOperario)
        Me.pnlFichaOperario.Controls.Add(Me.CmbTipoDocIdent)
        Me.pnlFichaOperario.Controls.Add(Me.LblTipoDocIdent)
        Me.pnlFichaOperario.Controls.Add(Me.FraDatosContacto)
        Me.pnlFichaOperario.Controls.Add(Me.lblDescOperario)
        Me.pnlFichaOperario.Controls.Add(Me.lblApellidos)
        Me.pnlFichaOperario.Controls.Add(Me.txtApellidos)
        Me.pnlFichaOperario.Controls.Add(Me.lblNombre)
        Me.pnlFichaOperario.Controls.Add(Me.txtNombre)
        Me.pnlFichaOperario.Controls.Add(Me.lblCategoria)
        Me.pnlFichaOperario.Controls.Add(Me.FraCondEco)
        Me.pnlFichaOperario.Controls.Add(Me.lblIDoperario)
        Me.pnlFichaOperario.Controls.Add(Me.txtDescOperario)
        Me.pnlFichaOperario.Controls.Add(Me.lblFechaAlta)
        Me.pnlFichaOperario.Controls.Add(Me.cbxFechaAlta)
        Me.pnlFichaOperario.Controls.Add(Me.lblDNI)
        Me.pnlFichaOperario.Controls.Add(Me.txtDNI)
        Me.pnlFichaOperario.Controls.Add(Me.ulDescCategoria)
        Me.pnlFichaOperario.Controls.Add(Me.AdvIDCategoria)
        Me.pnlFichaOperario.Controls.Add(Me.lblTexto)
        Me.pnlFichaOperario.Controls.Add(Me.lblOficio)
        Me.pnlFichaOperario.Controls.Add(Me.ulDescOficio)
        Me.pnlFichaOperario.Controls.Add(Me.advIdOficio)
        Me.pnlFichaOperario.Controls.Add(Me.lblDepartamento)
        Me.pnlFichaOperario.Controls.Add(Me.ulDescDepartamento)
        Me.pnlFichaOperario.Controls.Add(Me.AdvIDDepartamento)
        Me.pnlFichaOperario.Controls.Add(Me.CmbCurriculum)
        Me.pnlFichaOperario.Controls.Add(Me.lblCurriculum)
        Me.pnlFichaOperario.Controls.Add(Me.txtCurriculum)
        Me.pnlFichaOperario.Controls.Add(Me.lblUsuario)
        Me.pnlFichaOperario.Controls.Add(Me.cbxUsuario)
        Me.pnlFichaOperario.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFichaOperario.Location = New System.Drawing.Point(0, 0)
        Me.pnlFichaOperario.Name = "pnlFichaOperario"
        Me.pnlFichaOperario.Size = New System.Drawing.Size(991, 593)
        Me.pnlFichaOperario.TabIndex = 0
        '
        'ntbJornadaParcial
        '
        Me.TryDataBinding(ntbJornadaParcial, New System.Windows.Forms.Binding("Value", Me, "JornadaParcial", True))
        Me.ntbJornadaParcial.DisabledBackColor = System.Drawing.Color.White
        Me.ntbJornadaParcial.Location = New System.Drawing.Point(401, 404)
        Me.ntbJornadaParcial.Name = "ntbJornadaParcial"
        Me.ntbJornadaParcial.Size = New System.Drawing.Size(121, 21)
        Me.ntbJornadaParcial.TabIndex = 144
        '
        'lblJornadaParcial
        '
        Me.lblJornadaParcial.Location = New System.Drawing.Point(305, 405)
        Me.lblJornadaParcial.Name = "lblJornadaParcial"
        Me.lblJornadaParcial.Size = New System.Drawing.Size(90, 13)
        Me.lblJornadaParcial.TabIndex = 145
        Me.lblJornadaParcial.Text = "JornadaParcial"
        '
        'txtIDGET
        '
        Me.TryDataBinding(txtIDGET, New System.Windows.Forms.Binding("Text", Me, "IDGET", True))
        Me.txtIDGET.DisabledBackColor = System.Drawing.Color.White
        Me.txtIDGET.Location = New System.Drawing.Point(860, 28)
        Me.txtIDGET.Name = "txtIDGET"
        Me.txtIDGET.Size = New System.Drawing.Size(120, 21)
        Me.txtIDGET.TabIndex = 142
        '
        'lblIDGET
        '
        Me.lblIDGET.Location = New System.Drawing.Point(784, 32)
        Me.lblIDGET.Name = "lblIDGET"
        Me.lblIDGET.Size = New System.Drawing.Size(44, 13)
        Me.lblIDGET.TabIndex = 143
        Me.lblIDGET.Text = "IDGET"
        '
        'cbxFechaNacimiento
        '
        Me.TryDataBinding(cbxFechaNacimiento, New System.Windows.Forms.Binding("BindableValue", Me, "Fecha_Nacimiento", True))
        Me.cbxFechaNacimiento.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaNacimiento.Location = New System.Drawing.Point(671, 28)
        Me.cbxFechaNacimiento.Name = "cbxFechaNacimiento"
        Me.cbxFechaNacimiento.Size = New System.Drawing.Size(107, 21)
        Me.cbxFechaNacimiento.TabIndex = 141
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(562, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 140
        Me.Label2.Tag = "IdRec=4457;"
        Me.Label2.Text = "Fecha Nacimiento"
        '
        'chbPermisoGD
        '
        Me.TryDataBinding(chbPermisoGD, New System.Windows.Forms.Binding("BindableValue", Me, "PermisoGD", True))
        Me.chbPermisoGD.Location = New System.Drawing.Point(757, 404)
        Me.chbPermisoGD.Name = "chbPermisoGD"
        Me.chbPermisoGD.Size = New System.Drawing.Size(15, 15)
        Me.chbPermisoGD.TabIndex = 138
        '
        'lblPermisoGD
        '
        Me.lblPermisoGD.Location = New System.Drawing.Point(577, 404)
        Me.lblPermisoGD.Name = "lblPermisoGD"
        Me.lblPermisoGD.Size = New System.Drawing.Size(178, 13)
        Me.lblPermisoGD.TabIndex = 139
        Me.lblPermisoGD.Text = "Permisos Gestión Documental"
        '
        'GridHistorico
        '
        Me.GridHistorico.ColumnAutoResize = True
        GridHistorico_DesignTimeLayout.LayoutString = resources.GetString("GridHistorico_DesignTimeLayout.LayoutString")
        Me.GridHistorico.DesignTimeLayout = GridHistorico_DesignTimeLayout
        Me.GridHistorico.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridHistorico.EntityName = "OperarioHistorico"
        Me.GridHistorico.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridHistorico.KeyField = "IDOperario"
        Me.GridHistorico.Location = New System.Drawing.Point(529, 57)
        Me.GridHistorico.Name = "GridHistorico"
        Me.GridHistorico.PrimaryDataFields = "IDOperario"
        Me.GridHistorico.SecondaryDataFields = "IdOperario"
        Me.GridHistorico.Size = New System.Drawing.Size(398, 161)
        Me.GridHistorico.TabIndex = 137
        Me.GridHistorico.ViewName = "tbOperarioHistorico"
        Me.GridHistorico.Visible = False
        '
        'btnHistorico
        '
        Me.btnHistorico.Location = New System.Drawing.Point(478, 26)
        Me.btnHistorico.Name = "btnHistorico"
        Me.btnHistorico.Size = New System.Drawing.Size(75, 23)
        Me.btnHistorico.TabIndex = 136
        Me.btnHistorico.Text = "..."
        '
        'txtTextoCondiciones
        '
        Me.TryDataBinding(txtTextoCondiciones, New System.Windows.Forms.Binding("Text", Me, "TextoCondiciones", True))
        Me.txtTextoCondiciones.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoCondiciones.Location = New System.Drawing.Point(15, 524)
        Me.txtTextoCondiciones.Multiline = True
        Me.txtTextoCondiciones.Name = "txtTextoCondiciones"
        Me.txtTextoCondiciones.Size = New System.Drawing.Size(964, 62)
        Me.txtTextoCondiciones.TabIndex = 134
        '
        'lblTextoCondiciones
        '
        Me.lblTextoCondiciones.Location = New System.Drawing.Point(12, 508)
        Me.lblTextoCondiciones.Name = "lblTextoCondiciones"
        Me.lblTextoCondiciones.Size = New System.Drawing.Size(139, 13)
        Me.lblTextoCondiciones.TabIndex = 135
        Me.lblTextoCondiciones.Text = "Condiciones Especiales"
        '
        'txtTexto
        '
        Me.TryDataBinding(txtTexto, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.txtTexto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTexto.Location = New System.Drawing.Point(15, 444)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(965, 61)
        Me.txtTexto.TabIndex = 0
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.txtFLugar60)
        Me.Frame2.Controls.Add(Me.txtFLugar20)
        Me.Frame2.Controls.Add(Me.txtFLugar8)
        Me.Frame2.Controls.Add(Me.clbFFormacion60)
        Me.Frame2.Controls.Add(Me.clbFFormacion8)
        Me.Frame2.Controls.Add(Me.clbFFormacion20)
        Me.Frame2.Controls.Add(Me.lblFLugar60)
        Me.Frame2.Controls.Add(Me.lblFLugar20)
        Me.Frame2.Controls.Add(Me.lblFLugar8)
        Me.Frame2.Location = New System.Drawing.Point(539, 288)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(439, 107)
        Me.Frame2.TabIndex = 133
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Formación / Lugar"
        '
        'txtFLugar60
        '
        Me.txtFLugar60.DisabledBackColor = System.Drawing.Color.White
        Me.txtFLugar60.Location = New System.Drawing.Point(181, 69)
        Me.txtFLugar60.Name = "txtFLugar60"
        Me.txtFLugar60.Size = New System.Drawing.Size(252, 21)
        Me.txtFLugar60.TabIndex = 11
        '
        'txtFLugar20
        '
        Me.TryDataBinding(txtFLugar20, New System.Windows.Forms.Binding("Text", Me, "FLugar60", True))
        Me.txtFLugar20.DisabledBackColor = System.Drawing.Color.White
        Me.txtFLugar20.Location = New System.Drawing.Point(181, 42)
        Me.txtFLugar20.Name = "txtFLugar20"
        Me.txtFLugar20.Size = New System.Drawing.Size(253, 21)
        Me.txtFLugar20.TabIndex = 10
        '
        'txtFLugar8
        '
        Me.TryDataBinding(txtFLugar8, New System.Windows.Forms.Binding("Text", Me, "FLugar8", True))
        Me.txtFLugar8.DisabledBackColor = System.Drawing.Color.White
        Me.txtFLugar8.Location = New System.Drawing.Point(181, 16)
        Me.txtFLugar8.Name = "txtFLugar8"
        Me.txtFLugar8.Size = New System.Drawing.Size(253, 21)
        Me.txtFLugar8.TabIndex = 9
        '
        'clbFFormacion60
        '
        Me.TryDataBinding(clbFFormacion60, New System.Windows.Forms.Binding("BindableValue", Me, "FFormacion60", True))
        Me.clbFFormacion60.DisabledBackColor = System.Drawing.Color.White
        Me.clbFFormacion60.Location = New System.Drawing.Point(50, 69)
        Me.clbFFormacion60.Name = "clbFFormacion60"
        Me.clbFFormacion60.Size = New System.Drawing.Size(121, 21)
        Me.clbFFormacion60.TabIndex = 8
        '
        'clbFFormacion8
        '
        Me.TryDataBinding(clbFFormacion8, New System.Windows.Forms.Binding("BindableValue", Me, "FFormacion8", True))
        Me.clbFFormacion8.DisabledBackColor = System.Drawing.Color.White
        Me.clbFFormacion8.Location = New System.Drawing.Point(50, 16)
        Me.clbFFormacion8.Name = "clbFFormacion8"
        Me.clbFFormacion8.Size = New System.Drawing.Size(121, 21)
        Me.clbFFormacion8.TabIndex = 7
        '
        'clbFFormacion20
        '
        Me.TryDataBinding(clbFFormacion20, New System.Windows.Forms.Binding("BindableValue", Me, "FFormacion20", True))
        Me.clbFFormacion20.DisabledBackColor = System.Drawing.Color.White
        Me.clbFFormacion20.Location = New System.Drawing.Point(50, 42)
        Me.clbFFormacion20.Name = "clbFFormacion20"
        Me.clbFFormacion20.Size = New System.Drawing.Size(121, 21)
        Me.clbFFormacion20.TabIndex = 6
        '
        'lblFLugar60
        '
        Me.lblFLugar60.Location = New System.Drawing.Point(7, 73)
        Me.lblFLugar60.Name = "lblFLugar60"
        Me.lblFLugar60.Size = New System.Drawing.Size(39, 13)
        Me.lblFLugar60.TabIndex = 5
        Me.lblFLugar60.Text = "60 hr."
        '
        'lblFLugar20
        '
        Me.lblFLugar20.Location = New System.Drawing.Point(7, 46)
        Me.lblFLugar20.Name = "lblFLugar20"
        Me.lblFLugar20.Size = New System.Drawing.Size(39, 13)
        Me.lblFLugar20.TabIndex = 3
        Me.lblFLugar20.Text = "20 hr."
        '
        'lblFLugar8
        '
        Me.lblFLugar8.Location = New System.Drawing.Point(7, 20)
        Me.lblFLugar8.Name = "lblFLugar8"
        Me.lblFLugar8.Size = New System.Drawing.Size(32, 13)
        Me.lblFLugar8.TabIndex = 1
        Me.lblFLugar8.Text = "8 hr."
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.txtLugar)
        Me.Frame1.Controls.Add(Me.clbFecha_Reconocimiento)
        Me.Frame1.Controls.Add(Me.lblFecha_Reconocimiento)
        Me.Frame1.Location = New System.Drawing.Point(540, 246)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(439, 42)
        Me.Frame1.TabIndex = 132
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Reconocimiento / Lugar"
        '
        'txtLugar
        '
        Me.TryDataBinding(txtLugar, New System.Windows.Forms.Binding("Text", Me, "Lugar", True))
        Me.txtLugar.DisabledBackColor = System.Drawing.Color.White
        Me.txtLugar.Location = New System.Drawing.Point(180, 15)
        Me.txtLugar.Name = "txtLugar"
        Me.txtLugar.Size = New System.Drawing.Size(253, 21)
        Me.txtLugar.TabIndex = 2
        '
        'clbFecha_Reconocimiento
        '
        Me.TryDataBinding(clbFecha_Reconocimiento, New System.Windows.Forms.Binding("BindableValue", Me, "Fecha_Reconocimiento", True))
        Me.clbFecha_Reconocimiento.DisabledBackColor = System.Drawing.Color.White
        Me.clbFecha_Reconocimiento.Location = New System.Drawing.Point(49, 15)
        Me.clbFecha_Reconocimiento.Name = "clbFecha_Reconocimiento"
        Me.clbFecha_Reconocimiento.Size = New System.Drawing.Size(121, 21)
        Me.clbFecha_Reconocimiento.TabIndex = 0
        '
        'lblFecha_Reconocimiento
        '
        Me.lblFecha_Reconocimiento.Location = New System.Drawing.Point(6, 19)
        Me.lblFecha_Reconocimiento.Name = "lblFecha_Reconocimiento"
        Me.lblFecha_Reconocimiento.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha_Reconocimiento.TabIndex = 1
        Me.lblFecha_Reconocimiento.Text = "Fecha"
        '
        'txtTipoContrato
        '
        Me.TryDataBinding(txtTipoContrato, New System.Windows.Forms.Binding("Text", Me, "TipoContrato", True))
        Me.txtTipoContrato.DisabledBackColor = System.Drawing.Color.White
        Me.txtTipoContrato.Location = New System.Drawing.Point(860, 52)
        Me.txtTipoContrato.Name = "txtTipoContrato"
        Me.txtTipoContrato.Size = New System.Drawing.Size(120, 21)
        Me.txtTipoContrato.TabIndex = 130
        '
        'lblTipoContrato
        '
        Me.lblTipoContrato.Location = New System.Drawing.Point(756, 56)
        Me.lblTipoContrato.Name = "lblTipoContrato"
        Me.lblTipoContrato.Size = New System.Drawing.Size(85, 13)
        Me.lblTipoContrato.TabIndex = 131
        Me.lblTipoContrato.Text = "Tipo Contrato"
        '
        'txtN_Social
        '
        Me.TryDataBinding(txtN_Social, New System.Windows.Forms.Binding("Text", Me, "N_Social", True))
        Me.txtN_Social.DisabledBackColor = System.Drawing.Color.White
        Me.txtN_Social.Location = New System.Drawing.Point(477, 52)
        Me.txtN_Social.Name = "txtN_Social"
        Me.txtN_Social.Size = New System.Drawing.Size(253, 21)
        Me.txtN_Social.TabIndex = 128
        '
        'lblN_Social
        '
        Me.lblN_Social.Location = New System.Drawing.Point(404, 56)
        Me.lblN_Social.Name = "lblN_Social"
        Me.lblN_Social.Size = New System.Drawing.Size(67, 13)
        Me.lblN_Social.TabIndex = 129
        Me.lblN_Social.Text = "Seg Social"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(784, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 127
        Me.Label1.Tag = "IdRec=4457;"
        Me.Label1.Text = "Fecha Baja"
        '
        'cbxFechaBaja
        '
        Me.TryDataBinding(cbxFechaBaja, New System.Windows.Forms.Binding("BindableValue", Me, "Fecha_Baja", True))
        Me.cbxFechaBaja.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaBaja.Location = New System.Drawing.Point(860, 3)
        Me.cbxFechaBaja.Name = "cbxFechaBaja"
        Me.cbxFechaBaja.Size = New System.Drawing.Size(120, 21)
        Me.cbxFechaBaja.TabIndex = 126
        '
        'chkAviso9m
        '
        Me.TryDataBinding(chkAviso9m, New System.Windows.Forms.Binding("BindableValue", Me, "aviso9m", True))
        Me.chkAviso9m.Location = New System.Drawing.Point(15, 401)
        Me.chkAviso9m.Name = "chkAviso9m"
        Me.chkAviso9m.Size = New System.Drawing.Size(119, 17)
        Me.chkAviso9m.TabIndex = 125
        Me.chkAviso9m.Text = "Aviso 9 meses"
        '
        'chkNoContratar
        '
        Me.TryDataBinding(chkNoContratar, New System.Windows.Forms.Binding("BindableValue", Me, "Nocontratar", True))
        Me.chkNoContratar.Location = New System.Drawing.Point(140, 393)
        Me.chkNoContratar.Name = "chkNoContratar"
        Me.chkNoContratar.Size = New System.Drawing.Size(208, 33)
        Me.chkNoContratar.TabIndex = 124
        Me.chkNoContratar.Text = "No Volver a Contratar"
        '
        'CntIDOperario
        '
        Me.TryDataBinding(CntIDOperario, New System.Windows.Forms.Binding("Text", Me, "IDOperario", True))
        Me.CntIDOperario.DisabledBackColor = System.Drawing.Color.White
        Me.CntIDOperario.Location = New System.Drawing.Point(102, 2)
        Me.CntIDOperario.Name = "CntIDOperario"
        Me.CntIDOperario.Size = New System.Drawing.Size(84, 23)
        Me.CntIDOperario.TabIndex = 122
        '
        'CmbTipoDocIdent
        '
        Me.CmbTipoDocIdent.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(CmbTipoDocIdent, New System.Windows.Forms.Binding("Value", Me, "TipoDocIdentidad", True))
        CmbTipoDocIdent_DesignTimeLayout.LayoutString = resources.GetString("CmbTipoDocIdent_DesignTimeLayout.LayoutString")
        Me.CmbTipoDocIdent.DesignTimeLayout = CmbTipoDocIdent_DesignTimeLayout
        Me.CmbTipoDocIdent.DisabledBackColor = System.Drawing.Color.White
        Me.CmbTipoDocIdent.DisplayMember = "Text"
        Me.CmbTipoDocIdent.Location = New System.Drawing.Point(102, 52)
        Me.CmbTipoDocIdent.Name = "CmbTipoDocIdent"
        Me.CmbTipoDocIdent.SelectedIndex = -1
        Me.CmbTipoDocIdent.SelectedItem = Nothing
        Me.CmbTipoDocIdent.Size = New System.Drawing.Size(122, 21)
        Me.CmbTipoDocIdent.TabIndex = 6
        Me.CmbTipoDocIdent.ValueMember = "Value"
        '
        'LblTipoDocIdent
        '
        Me.LblTipoDocIdent.Location = New System.Drawing.Point(3, 56)
        Me.LblTipoDocIdent.Name = "LblTipoDocIdent"
        Me.LblTipoDocIdent.Size = New System.Drawing.Size(100, 13)
        Me.LblTipoDocIdent.TabIndex = 120
        Me.LblTipoDocIdent.Text = "Tipo Documento"
        '
        'FraDatosContacto
        '
        Me.FraDatosContacto.Controls.Add(Me.txtDireccion)
        Me.FraDatosContacto.Controls.Add(Me.lblFax)
        Me.FraDatosContacto.Controls.Add(Me.txtFax)
        Me.FraDatosContacto.Controls.Add(Me.ulDescPais)
        Me.FraDatosContacto.Controls.Add(Me.advPoblacion)
        Me.FraDatosContacto.Controls.Add(Me.advCodPostal)
        Me.FraDatosContacto.Controls.Add(Me.lblCP)
        Me.FraDatosContacto.Controls.Add(Me.advIDPais)
        Me.FraDatosContacto.Controls.Add(Me.txtProvincia)
        Me.FraDatosContacto.Controls.Add(Me.lblDireccion)
        Me.FraDatosContacto.Controls.Add(Me.lblPoblacion)
        Me.FraDatosContacto.Controls.Add(Me.lblProvincia)
        Me.FraDatosContacto.Controls.Add(Me.lblIDPais)
        Me.FraDatosContacto.Controls.Add(Me.txtEmail)
        Me.FraDatosContacto.Controls.Add(Me.txtTelefono3)
        Me.FraDatosContacto.Controls.Add(Me.txtTelefono2)
        Me.FraDatosContacto.Controls.Add(Me.txtTelefono)
        Me.FraDatosContacto.Controls.Add(Me.lblTelefono)
        Me.FraDatosContacto.Controls.Add(Me.lblEmail)
        Me.FraDatosContacto.Controls.Add(Me.chkExterno)
        Me.FraDatosContacto.Location = New System.Drawing.Point(5, 76)
        Me.FraDatosContacto.Name = "FraDatosContacto"
        Me.FraDatosContacto.Size = New System.Drawing.Size(975, 91)
        Me.FraDatosContacto.TabIndex = 10
        Me.FraDatosContacto.TabStop = False
        Me.FraDatosContacto.Text = "Datos Contacto"
        '
        'txtDireccion
        '
        Me.TryDataBinding(txtDireccion, New System.Windows.Forms.Binding("Text", Me, "Direccion", True))
        Me.txtDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccion.Location = New System.Drawing.Point(73, 18)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(391, 21)
        Me.txtDireccion.TabIndex = 45
        '
        'lblFax
        '
        Me.lblFax.Location = New System.Drawing.Point(338, 71)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(26, 13)
        Me.lblFax.TabIndex = 44
        Me.lblFax.Text = "Fax"
        '
        'txtFax
        '
        Me.TryDataBinding(txtFax, New System.Windows.Forms.Binding("Text", Me, "Fax", True))
        Me.txtFax.DisabledBackColor = System.Drawing.Color.White
        Me.txtFax.Location = New System.Drawing.Point(369, 67)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(95, 21)
        Me.txtFax.TabIndex = 8
        '
        'ulDescPais
        '
        Me.TryDataBinding(ulDescPais, New System.Windows.Forms.Binding("Text", Me.advIDPais, "DescPais", True))
        Me.ulDescPais.Location = New System.Drawing.Point(602, 18)
        Me.ulDescPais.Name = "ulDescPais"
        Me.ulDescPais.Size = New System.Drawing.Size(170, 24)
        Me.ulDescPais.TabIndex = 42
        '
        'advPoblacion
        '
        Me.TryDataBinding(advPoblacion, New System.Windows.Forms.Binding("Text", Me, "Poblacion", True))
        Me.advPoblacion.DisabledBackColor = System.Drawing.Color.White
        Me.advPoblacion.EntityName = "Poblacion"
        Me.advPoblacion.Location = New System.Drawing.Point(185, 42)
        Me.advPoblacion.Name = "advPoblacion"
        Me.advPoblacion.PrimaryDataFields = "Poblacion"
        Me.advPoblacion.SecondaryDataFields = "DescPoblacion"
        Me.advPoblacion.Size = New System.Drawing.Size(279, 23)
        Me.advPoblacion.TabIndex = 3
        '
        'advCodPostal
        '
        Me.TryDataBinding(advCodPostal, New System.Windows.Forms.Binding("Text", Me, "CodPostal", True))
        Me.advCodPostal.DisabledBackColor = System.Drawing.Color.White
        Me.advCodPostal.EntityName = "Poblacion"
        Me.advCodPostal.Location = New System.Drawing.Point(44, 42)
        Me.advCodPostal.Name = "advCodPostal"
        Me.advCodPostal.PrimaryDataFields = "CodPostal"
        Me.advCodPostal.SecondaryDataFields = "CodPostal"
        Me.advCodPostal.Size = New System.Drawing.Size(66, 23)
        Me.advCodPostal.TabIndex = 2
        '
        'lblCP
        '
        Me.lblCP.Location = New System.Drawing.Point(7, 47)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(29, 13)
        Me.lblCP.TabIndex = 41
        Me.lblCP.Text = "C.P."
        '
        'advIDPais
        '
        Me.TryDataBinding(advIDPais, New System.Windows.Forms.Binding("Text", Me, "IDPais", True))
        Me.advIDPais.DisabledBackColor = System.Drawing.Color.White
        Me.advIDPais.EntityName = "Pais"
        Me.advIDPais.Location = New System.Drawing.Point(534, 19)
        Me.advIDPais.Name = "advIDPais"
        Me.advIDPais.PrimaryDataFields = "IDPais"
        Me.advIDPais.SecondaryDataFields = "IDPais"
        Me.advIDPais.Size = New System.Drawing.Size(64, 23)
        Me.advIDPais.TabIndex = 1
        '
        'txtProvincia
        '
        Me.TryDataBinding(txtProvincia, New System.Windows.Forms.Binding("Text", Me, "Provincia", True))
        Me.txtProvincia.DisabledBackColor = System.Drawing.Color.White
        Me.txtProvincia.Location = New System.Drawing.Point(534, 44)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(238, 21)
        Me.txtProvincia.TabIndex = 4
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(7, 21)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(60, 13)
        Me.lblDireccion.TabIndex = 37
        Me.lblDireccion.Text = "Dirección"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.Location = New System.Drawing.Point(120, 47)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(61, 13)
        Me.lblPoblacion.TabIndex = 38
        Me.lblPoblacion.Text = "Población"
        '
        'lblProvincia
        '
        Me.lblProvincia.Location = New System.Drawing.Point(470, 48)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(59, 13)
        Me.lblProvincia.TabIndex = 39
        Me.lblProvincia.Text = "Provincia"
        '
        'lblIDPais
        '
        Me.lblIDPais.Location = New System.Drawing.Point(470, 22)
        Me.lblIDPais.Name = "lblIDPais"
        Me.lblIDPais.Size = New System.Drawing.Size(30, 13)
        Me.lblIDPais.TabIndex = 40
        Me.lblIDPais.Text = "País"
        '
        'txtEmail
        '
        Me.TryDataBinding(txtEmail, New System.Windows.Forms.Binding("Text", Me, "Email", True))
        Me.txtEmail.DisabledBackColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(534, 67)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(238, 21)
        Me.txtEmail.TabIndex = 9
        '
        'txtTelefono3
        '
        Me.TryDataBinding(txtTelefono3, New System.Windows.Forms.Binding("Text", Me, "Telefono", True))
        Me.txtTelefono3.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefono3.Location = New System.Drawing.Point(239, 67)
        Me.txtTelefono3.Name = "txtTelefono3"
        Me.txtTelefono3.Size = New System.Drawing.Size(95, 21)
        Me.txtTelefono3.TabIndex = 7
        '
        'txtTelefono2
        '
        Me.TryDataBinding(txtTelefono2, New System.Windows.Forms.Binding("Text", Me, "Telefono2", True))
        Me.txtTelefono2.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefono2.Location = New System.Drawing.Point(141, 67)
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.Size = New System.Drawing.Size(95, 21)
        Me.txtTelefono2.TabIndex = 6
        '
        'txtTelefono
        '
        Me.TryDataBinding(txtTelefono, New System.Windows.Forms.Binding("Text", Me, "Telefono", True))
        Me.txtTelefono.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefono.Location = New System.Drawing.Point(43, 67)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(95, 21)
        Me.txtTelefono.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.Location = New System.Drawing.Point(7, 71)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(24, 13)
        Me.lblTelefono.TabIndex = 26
        Me.lblTelefono.Text = "Tlf."
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(470, 71)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(38, 13)
        Me.lblEmail.TabIndex = 33
        Me.lblEmail.Text = "Email"
        '
        'chkExterno
        '
        Me.TryDataBinding(chkExterno, New System.Windows.Forms.Binding("BindableValue", Me, "Externo", True))
        Me.chkExterno.Location = New System.Drawing.Point(905, 18)
        Me.chkExterno.Name = "chkExterno"
        Me.chkExterno.Size = New System.Drawing.Size(64, 19)
        Me.chkExterno.TabIndex = 8
        Me.chkExterno.Text = "Externo"
        '
        'lblDescOperario
        '
        Me.lblDescOperario.Location = New System.Drawing.Point(3, 32)
        Me.lblDescOperario.Name = "lblDescOperario"
        Me.lblDescOperario.Size = New System.Drawing.Size(93, 13)
        Me.lblDescOperario.TabIndex = 113
        Me.lblDescOperario.Tag = ""
        Me.lblDescOperario.Text = "Desc. Operario"
        '
        'lblApellidos
        '
        Me.lblApellidos.Location = New System.Drawing.Point(393, 8)
        Me.lblApellidos.Name = "lblApellidos"
        Me.lblApellidos.Size = New System.Drawing.Size(58, 13)
        Me.lblApellidos.TabIndex = 111
        Me.lblApellidos.Text = "Apellidos"
        '
        'txtApellidos
        '
        Me.TryDataBinding(txtApellidos, New System.Windows.Forms.Binding("Text", Me, "Apellidos", True))
        Me.txtApellidos.DisabledBackColor = System.Drawing.Color.White
        Me.txtApellidos.Location = New System.Drawing.Point(455, 4)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(141, 21)
        Me.txtApellidos.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(193, 8)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(52, 13)
        Me.lblNombre.TabIndex = 112
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.TryDataBinding(txtNombre, New System.Windows.Forms.Binding("Text", Me, "Nombre", True))
        Me.txtNombre.DisabledBackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(249, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(141, 21)
        Me.txtNombre.TabIndex = 1
        '
        'lblCategoria
        '
        Me.lblCategoria.Location = New System.Drawing.Point(5, 174)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(63, 13)
        Me.lblCategoria.TabIndex = 108
        Me.lblCategoria.Tag = "IdRec=4619;"
        Me.lblCategoria.Text = "Categoría"
        '
        'FraCondEco
        '
        Me.FraCondEco.Controls.Add(Me.txtaccountNumber)
        Me.FraCondEco.Controls.Add(Me.lblaccountNumber)
        Me.FraCondEco.Controls.Add(Me.txtsortcode)
        Me.FraCondEco.Controls.Add(Me.lblsortcode)
        Me.FraCondEco.Controls.Add(Me.btnGenIBAN)
        Me.FraCondEco.Controls.Add(Me.lblSwift)
        Me.FraCondEco.Controls.Add(Me.txtSwift)
        Me.FraCondEco.Controls.Add(Me.lblCodigoIBAN)
        Me.FraCondEco.Controls.Add(Me.txtCodigoIBAN)
        Me.FraCondEco.Controls.Add(Me.lblSucursal)
        Me.FraCondEco.Controls.Add(Me.txtSucursal)
        Me.FraCondEco.Controls.Add(Me.lblDigitoControl)
        Me.FraCondEco.Controls.Add(Me.txtDigitoControl)
        Me.FraCondEco.Controls.Add(Me.lblNCuenta)
        Me.FraCondEco.Controls.Add(Me.txtNCuenta)
        Me.FraCondEco.Controls.Add(Me.lblFormaPago)
        Me.FraCondEco.Controls.Add(Me.ulDescFormaPago)
        Me.FraCondEco.Controls.Add(Me.AdvIDFormaPago)
        Me.FraCondEco.Controls.Add(Me.lblBanco)
        Me.FraCondEco.Controls.Add(Me.ulDescBanco)
        Me.FraCondEco.Controls.Add(Me.advIDBanco)
        Me.FraCondEco.Location = New System.Drawing.Point(5, 246)
        Me.FraCondEco.Name = "FraCondEco"
        Me.FraCondEco.Size = New System.Drawing.Size(529, 149)
        Me.FraCondEco.TabIndex = 17
        Me.FraCondEco.TabStop = False
        Me.FraCondEco.Text = "Condiciones Econonómicas"
        '
        'txtaccountNumber
        '
        Me.TryDataBinding(txtaccountNumber, New System.Windows.Forms.Binding("Text", Me, "accountNumber", True))
        Me.txtaccountNumber.DisabledBackColor = System.Drawing.Color.White
        Me.txtaccountNumber.Location = New System.Drawing.Point(287, 120)
        Me.txtaccountNumber.Name = "txtaccountNumber"
        Me.txtaccountNumber.Size = New System.Drawing.Size(121, 21)
        Me.txtaccountNumber.TabIndex = 47
        Me.txtaccountNumber.Visible = False
        '
        'lblaccountNumber
        '
        Me.lblaccountNumber.Location = New System.Drawing.Point(190, 123)
        Me.lblaccountNumber.Name = "lblaccountNumber"
        Me.lblaccountNumber.Size = New System.Drawing.Size(97, 13)
        Me.lblaccountNumber.TabIndex = 48
        Me.lblaccountNumber.Text = "AccountNumber"
        Me.lblaccountNumber.Visible = False
        '
        'txtsortcode
        '
        Me.TryDataBinding(txtsortcode, New System.Windows.Forms.Binding("Text", Me, "sortcode", True))
        Me.txtsortcode.DisabledBackColor = System.Drawing.Color.White
        Me.txtsortcode.Location = New System.Drawing.Point(88, 119)
        Me.txtsortcode.Name = "txtsortcode"
        Me.txtsortcode.Size = New System.Drawing.Size(96, 21)
        Me.txtsortcode.TabIndex = 46
        Me.txtsortcode.Visible = False
        '
        'lblsortcode
        '
        Me.lblsortcode.Location = New System.Drawing.Point(7, 119)
        Me.lblsortcode.Name = "lblsortcode"
        Me.lblsortcode.Size = New System.Drawing.Size(58, 13)
        Me.lblsortcode.TabIndex = 44
        Me.lblsortcode.Text = "Sortcode"
        Me.lblsortcode.Visible = False
        '
        'btnGenIBAN
        '
        Me.btnGenIBAN.Location = New System.Drawing.Point(428, 119)
        Me.btnGenIBAN.Name = "btnGenIBAN"
        Me.btnGenIBAN.Size = New System.Drawing.Size(89, 24)
        Me.btnGenIBAN.TabIndex = 43
        Me.btnGenIBAN.Text = "Calcular IBAN"
        '
        'lblSwift
        '
        Me.lblSwift.Location = New System.Drawing.Point(349, 19)
        Me.lblSwift.Name = "lblSwift"
        Me.lblSwift.Size = New System.Drawing.Size(44, 13)
        Me.lblSwift.TabIndex = 42
        Me.lblSwift.Text = "SWIFT"
        '
        'txtSwift
        '
        Me.TryDataBinding(txtSwift, New System.Windows.Forms.Binding("Text", Me, "SWIFT", True))
        Me.txtSwift.DisabledBackColor = System.Drawing.Color.White
        Me.txtSwift.Location = New System.Drawing.Point(396, 15)
        Me.txtSwift.MaxLength = 11
        Me.txtSwift.Name = "txtSwift"
        Me.txtSwift.Size = New System.Drawing.Size(121, 21)
        Me.txtSwift.TabIndex = 1
        '
        'lblCodigoIBAN
        '
        Me.lblCodigoIBAN.Location = New System.Drawing.Point(7, 19)
        Me.lblCodigoIBAN.Name = "lblCodigoIBAN"
        Me.lblCodigoIBAN.Size = New System.Drawing.Size(80, 13)
        Me.lblCodigoIBAN.TabIndex = 40
        Me.lblCodigoIBAN.Text = "Código IBAN"
        '
        'txtCodigoIBAN
        '
        Me.TryDataBinding(txtCodigoIBAN, New System.Windows.Forms.Binding("Text", Me, "CodigoIBAN", True))
        Me.txtCodigoIBAN.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodigoIBAN.Location = New System.Drawing.Point(88, 15)
        Me.txtCodigoIBAN.MaxLength = 34
        Me.txtCodigoIBAN.Name = "txtCodigoIBAN"
        Me.txtCodigoIBAN.Size = New System.Drawing.Size(255, 21)
        Me.txtCodigoIBAN.TabIndex = 0
        '
        'lblSucursal
        '
        Me.lblSucursal.Location = New System.Drawing.Point(7, 92)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(56, 13)
        Me.lblSucursal.TabIndex = 0
        Me.lblSucursal.Tag = "IdRec=4606;"
        Me.lblSucursal.Text = "Sucursal"
        '
        'txtSucursal
        '
        Me.TryDataBinding(txtSucursal, New System.Windows.Forms.Binding("Text", Me, "Sucursal", True))
        Me.txtSucursal.DisabledBackColor = System.Drawing.Color.White
        Me.txtSucursal.Location = New System.Drawing.Point(88, 92)
        Me.txtSucursal.MaxLength = 4
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(96, 21)
        Me.txtSucursal.TabIndex = 4
        '
        'lblDigitoControl
        '
        Me.lblDigitoControl.Location = New System.Drawing.Point(190, 96)
        Me.lblDigitoControl.Name = "lblDigitoControl"
        Me.lblDigitoControl.Size = New System.Drawing.Size(33, 13)
        Me.lblDigitoControl.TabIndex = 27
        Me.lblDigitoControl.Tag = ""
        Me.lblDigitoControl.Text = "D.C."
        '
        'txtDigitoControl
        '
        Me.TryDataBinding(txtDigitoControl, New System.Windows.Forms.Binding("Text", Me, "DigitoControl", True))
        Me.txtDigitoControl.DisabledBackColor = System.Drawing.Color.White
        Me.txtDigitoControl.Location = New System.Drawing.Point(229, 92)
        Me.txtDigitoControl.MaxLength = 2
        Me.txtDigitoControl.Name = "txtDigitoControl"
        Me.txtDigitoControl.Size = New System.Drawing.Size(58, 21)
        Me.txtDigitoControl.TabIndex = 5
        '
        'lblNCuenta
        '
        Me.lblNCuenta.Location = New System.Drawing.Point(300, 96)
        Me.lblNCuenta.Name = "lblNCuenta"
        Me.lblNCuenta.Size = New System.Drawing.Size(82, 13)
        Me.lblNCuenta.TabIndex = 28
        Me.lblNCuenta.Tag = "IdRec=6986;"
        Me.lblNCuenta.Text = "Num. Cuenta"
        '
        'txtNCuenta
        '
        Me.TryDataBinding(txtNCuenta, New System.Windows.Forms.Binding("Text", Me, "NCuenta", True))
        Me.txtNCuenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtNCuenta.Location = New System.Drawing.Point(387, 92)
        Me.txtNCuenta.MaxLength = 10
        Me.txtNCuenta.Name = "txtNCuenta"
        Me.txtNCuenta.Size = New System.Drawing.Size(130, 21)
        Me.txtNCuenta.TabIndex = 6
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(7, 42)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(75, 13)
        Me.lblFormaPago.TabIndex = 29
        Me.lblFormaPago.Tag = ""
        Me.lblFormaPago.Text = "Forma Pago"
        '
        'ulDescFormaPago
        '
        Me.TryDataBinding(ulDescFormaPago, New System.Windows.Forms.Binding("Text", Me.AdvIDFormaPago, "DescFormaPago", True))
        Me.ulDescFormaPago.Location = New System.Drawing.Point(189, 40)
        Me.ulDescFormaPago.Name = "ulDescFormaPago"
        Me.ulDescFormaPago.Size = New System.Drawing.Size(328, 23)
        Me.ulDescFormaPago.TabIndex = 30
        '
        'AdvIDFormaPago
        '
        Me.TryDataBinding(AdvIDFormaPago, New System.Windows.Forms.Binding("Text", Me, "IDFormaPago", True))
        Me.AdvIDFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDFormaPago.EntityName = "FormaPago"
        Me.AdvIDFormaPago.Location = New System.Drawing.Point(88, 40)
        Me.AdvIDFormaPago.MaxLength = 10
        Me.AdvIDFormaPago.Name = "AdvIDFormaPago"
        Me.AdvIDFormaPago.PrimaryDataFields = "IDFormaPago"
        Me.AdvIDFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.AdvIDFormaPago.Size = New System.Drawing.Size(96, 23)
        Me.AdvIDFormaPago.TabIndex = 2
        Me.AdvIDFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'lblBanco
        '
        Me.lblBanco.Location = New System.Drawing.Point(7, 66)
        Me.lblBanco.Name = "lblBanco"
        Me.lblBanco.Size = New System.Drawing.Size(42, 13)
        Me.lblBanco.TabIndex = 31
        Me.lblBanco.Tag = "IdRec=5834;"
        Me.lblBanco.Text = "Banco"
        '
        'ulDescBanco
        '
        Me.TryDataBinding(ulDescBanco, New System.Windows.Forms.Binding("Text", Me.advIDBanco, "DescBanco", True))
        Me.ulDescBanco.Location = New System.Drawing.Point(189, 66)
        Me.ulDescBanco.Name = "ulDescBanco"
        Me.ulDescBanco.Size = New System.Drawing.Size(328, 23)
        Me.ulDescBanco.TabIndex = 32
        '
        'advIDBanco
        '
        Me.TryDataBinding(advIDBanco, New System.Windows.Forms.Binding("Text", Me, "IDBanco", True))
        Me.advIDBanco.DisabledBackColor = System.Drawing.Color.White
        Me.advIDBanco.EntityName = "Banco"
        Me.advIDBanco.Location = New System.Drawing.Point(88, 66)
        Me.advIDBanco.MaxLength = 10
        Me.advIDBanco.Name = "advIDBanco"
        Me.advIDBanco.PrimaryDataFields = "IDBanco"
        Me.advIDBanco.SecondaryDataFields = "IDBanco"
        Me.advIDBanco.Size = New System.Drawing.Size(96, 23)
        Me.advIDBanco.TabIndex = 3
        Me.advIDBanco.ViewName = "tbMaestroBanco"
        '
        'lblIDoperario
        '
        Me.lblIDoperario.Location = New System.Drawing.Point(3, 8)
        Me.lblIDoperario.Name = "lblIDoperario"
        Me.lblIDoperario.Size = New System.Drawing.Size(57, 13)
        Me.lblIDoperario.TabIndex = 87
        Me.lblIDoperario.Tag = ""
        Me.lblIDoperario.Text = "Operario"
        '
        'txtDescOperario
        '
        Me.TryDataBinding(txtDescOperario, New System.Windows.Forms.Binding("Text", Me, "DescOperario", True))
        Me.txtDescOperario.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescOperario.Location = New System.Drawing.Point(102, 28)
        Me.txtDescOperario.MaxLength = 100
        Me.txtDescOperario.Name = "txtDescOperario"
        Me.txtDescOperario.Size = New System.Drawing.Size(357, 21)
        Me.txtDescOperario.TabIndex = 4
        '
        'lblFechaAlta
        '
        Me.lblFechaAlta.Location = New System.Drawing.Point(603, 5)
        Me.lblFechaAlta.Name = "lblFechaAlta"
        Me.lblFechaAlta.Size = New System.Drawing.Size(66, 13)
        Me.lblFechaAlta.TabIndex = 88
        Me.lblFechaAlta.Tag = "IdRec=4457;"
        Me.lblFechaAlta.Text = "Fecha Alta"
        '
        'cbxFechaAlta
        '
        Me.TryDataBinding(cbxFechaAlta, New System.Windows.Forms.Binding("BindableValue", Me, "FechaAlta", True))
        Me.cbxFechaAlta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaAlta.Location = New System.Drawing.Point(672, 4)
        Me.cbxFechaAlta.Name = "cbxFechaAlta"
        Me.cbxFechaAlta.Size = New System.Drawing.Size(106, 21)
        Me.cbxFechaAlta.TabIndex = 3
        '
        'lblDNI
        '
        Me.lblDNI.Location = New System.Drawing.Point(230, 56)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(72, 13)
        Me.lblDNI.TabIndex = 97
        Me.lblDNI.Tag = ""
        Me.lblDNI.Text = "Documento"
        '
        'txtDNI
        '
        Me.TryDataBinding(txtDNI, New System.Windows.Forms.Binding("Text", Me, "DNI", True))
        Me.txtDNI.DisabledBackColor = System.Drawing.Color.White
        Me.txtDNI.Location = New System.Drawing.Point(308, 52)
        Me.txtDNI.MaxLength = 25
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(80, 21)
        Me.txtDNI.TabIndex = 7
        '
        'ulDescCategoria
        '
        Me.TryDataBinding(ulDescCategoria, New System.Windows.Forms.Binding("Text", Me.AdvIDCategoria, "DescCategoria", True))
        Me.ulDescCategoria.Location = New System.Drawing.Point(170, 170)
        Me.ulDescCategoria.Name = "ulDescCategoria"
        Me.ulDescCategoria.Size = New System.Drawing.Size(244, 23)
        Me.ulDescCategoria.TabIndex = 98
        '
        'AdvIDCategoria
        '
        Me.TryDataBinding(AdvIDCategoria, New System.Windows.Forms.Binding("Text", Me, "IDCategoria", True))
        Me.AdvIDCategoria.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCategoria.EntityName = "Categoria"
        Me.AdvIDCategoria.Location = New System.Drawing.Point(98, 170)
        Me.AdvIDCategoria.MaxLength = 10
        Me.AdvIDCategoria.Name = "AdvIDCategoria"
        Me.AdvIDCategoria.PrimaryDataFields = "IDCategoria"
        Me.AdvIDCategoria.SecondaryDataFields = "IDCategoria"
        Me.AdvIDCategoria.Size = New System.Drawing.Size(67, 23)
        Me.AdvIDCategoria.TabIndex = 11
        Me.AdvIDCategoria.ViewName = "tbMaestroCategoria"
        '
        'lblTexto
        '
        Me.lblTexto.Location = New System.Drawing.Point(12, 428)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(91, 13)
        Me.lblTexto.TabIndex = 99
        Me.lblTexto.Tag = "IdRec=5286;"
        Me.lblTexto.Text = "Observaciones"
        '
        'lblOficio
        '
        Me.lblOficio.Location = New System.Drawing.Point(420, 176)
        Me.lblOficio.Name = "lblOficio"
        Me.lblOficio.Size = New System.Drawing.Size(39, 13)
        Me.lblOficio.TabIndex = 100
        Me.lblOficio.Tag = "IdRec=7672;"
        Me.lblOficio.Text = "Oficio"
        '
        'ulDescOficio
        '
        Me.TryDataBinding(ulDescOficio, New System.Windows.Forms.Binding("Text", Me.advIdOficio, "DescOficio", True))
        Me.ulDescOficio.Location = New System.Drawing.Point(544, 172)
        Me.ulDescOficio.Name = "ulDescOficio"
        Me.ulDescOficio.Size = New System.Drawing.Size(233, 21)
        Me.ulDescOficio.TabIndex = 101
        '
        'advIdOficio
        '
        Me.TryDataBinding(advIdOficio, New System.Windows.Forms.Binding("Text", Me, "IDOficio", True))
        Me.advIdOficio.DisabledBackColor = System.Drawing.Color.White
        Me.advIdOficio.EntityName = "Oficio"
        Me.advIdOficio.Location = New System.Drawing.Point(472, 170)
        Me.advIdOficio.MaxLength = 10
        Me.advIdOficio.Name = "advIdOficio"
        Me.advIdOficio.PrimaryDataFields = "IDOficio"
        Me.advIdOficio.SecondaryDataFields = "IDOficio"
        Me.advIdOficio.Size = New System.Drawing.Size(67, 23)
        Me.advIdOficio.TabIndex = 12
        Me.advIdOficio.ViewName = "tbMaestroOficio"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Location = New System.Drawing.Point(5, 200)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(89, 13)
        Me.lblDepartamento.TabIndex = 102
        Me.lblDepartamento.Tag = ""
        Me.lblDepartamento.Text = "Departamento"
        '
        'ulDescDepartamento
        '
        Me.TryDataBinding(ulDescDepartamento, New System.Windows.Forms.Binding("Text", Me.AdvIDDepartamento, "DescDepartamento", True))
        Me.ulDescDepartamento.Location = New System.Drawing.Point(170, 195)
        Me.ulDescDepartamento.Name = "ulDescDepartamento"
        Me.ulDescDepartamento.Size = New System.Drawing.Size(244, 23)
        Me.ulDescDepartamento.TabIndex = 103
        '
        'AdvIDDepartamento
        '
        Me.TryDataBinding(AdvIDDepartamento, New System.Windows.Forms.Binding("Text", Me, "IDDepartamento", True))
        Me.AdvIDDepartamento.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDDepartamento.EntityName = "Departamento"
        Me.AdvIDDepartamento.Location = New System.Drawing.Point(98, 195)
        Me.AdvIDDepartamento.MaxLength = 10
        Me.AdvIDDepartamento.Name = "AdvIDDepartamento"
        Me.AdvIDDepartamento.PrimaryDataFields = "IDDepartamento"
        Me.AdvIDDepartamento.SecondaryDataFields = "IDDepartamento"
        Me.AdvIDDepartamento.Size = New System.Drawing.Size(67, 23)
        Me.AdvIDDepartamento.TabIndex = 13
        Me.AdvIDDepartamento.ViewName = "tbMaestroDepartamento"
        '
        'CmbCurriculum
        '
        Me.CmbCurriculum.ImageIndex = 0
        Me.CmbCurriculum.ImageList = Me.ImageList1
        Me.CmbCurriculum.Location = New System.Drawing.Point(959, 221)
        Me.CmbCurriculum.Name = "CmbCurriculum"
        Me.CmbCurriculum.Size = New System.Drawing.Size(21, 21)
        Me.CmbCurriculum.TabIndex = 16
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "book_blue.ico")
        '
        'lblCurriculum
        '
        Me.lblCurriculum.Location = New System.Drawing.Point(5, 225)
        Me.lblCurriculum.Name = "lblCurriculum"
        Me.lblCurriculum.Size = New System.Drawing.Size(70, 13)
        Me.lblCurriculum.TabIndex = 104
        Me.lblCurriculum.Tag = "IdRec=7670;"
        Me.lblCurriculum.Text = "Curriculum"
        '
        'txtCurriculum
        '
        Me.TryDataBinding(txtCurriculum, New System.Windows.Forms.Binding("Text", Me, "Curriculum", True))
        Me.txtCurriculum.DisabledBackColor = System.Drawing.Color.White
        Me.txtCurriculum.Location = New System.Drawing.Point(98, 221)
        Me.txtCurriculum.MaxLength = 200
        Me.txtCurriculum.Name = "txtCurriculum"
        Me.txtCurriculum.Size = New System.Drawing.Size(855, 21)
        Me.txtCurriculum.TabIndex = 15
        '
        'lblUsuario
        '
        Me.lblUsuario.Location = New System.Drawing.Point(421, 199)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(50, 13)
        Me.lblUsuario.TabIndex = 105
        Me.lblUsuario.Tag = "IdRec=4362;"
        Me.lblUsuario.Text = "Usuario"
        '
        'cbxUsuario
        '
        Me.TryDataBinding(cbxUsuario, New System.Windows.Forms.Binding("Value", Me, "IDUsuario", True))
        cbxUsuario_DesignTimeLayout.LayoutString = resources.GetString("cbxUsuario_DesignTimeLayout.LayoutString")
        Me.cbxUsuario.DesignTimeLayout = cbxUsuario_DesignTimeLayout
        Me.cbxUsuario.DisabledBackColor = System.Drawing.Color.White
        Me.cbxUsuario.DisplayMember = "CUsuario"
        Me.cbxUsuario.Location = New System.Drawing.Point(472, 195)
        Me.cbxUsuario.Name = "cbxUsuario"
        Me.cbxUsuario.SelectedIndex = -1
        Me.cbxUsuario.SelectedItem = Nothing
        Me.cbxUsuario.Size = New System.Drawing.Size(305, 21)
        Me.cbxUsuario.TabIndex = 14
        Me.cbxUsuario.ValueMember = "IDUsuario"
        '
        'chbFirmaApp
        '
        Me.TryDataBinding(chbFirmaApp, New System.Windows.Forms.Binding("BindableValue", Me, "FirmaApp", True))
        Me.chbFirmaApp.Location = New System.Drawing.Point(865, 405)
        Me.chbFirmaApp.Name = "chbFirmaApp"
        Me.chbFirmaApp.Size = New System.Drawing.Size(15, 15)
        Me.chbFirmaApp.TabIndex = 146
        '
        'lblFirmaApp
        '
        Me.lblFirmaApp.Location = New System.Drawing.Point(799, 406)
        Me.lblFirmaApp.Name = "lblFirmaApp"
        Me.lblFirmaApp.Size = New System.Drawing.Size(61, 13)
        Me.lblFirmaApp.TabIndex = 147
        Me.lblFirmaApp.Text = "FirmaApp"
        '
        'MntoOperario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(999, 840)
        Me.EntityName = "Operario"
        Me.Name = "MntoOperario"
        Me.NavigationFields = "NOperarioOrden"
        Me.Text = "Mantenimiento de Trabajadores"
        Me.ViewName = "frmMntoOperario"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.PicFichaOperario.ResumeLayout(False)
        Me.PicFichaOperario.PerformLayout()
        CType(Me.GridHistoricoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFichaOperario.ResumeLayout(False)
        Me.pnlFichaOperario.PerformLayout()
        CType(Me.GridHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.CmbTipoDocIdent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraDatosContacto.ResumeLayout(False)
        Me.FraDatosContacto.PerformLayout()
        Me.FraCondEco.ResumeLayout(False)
        Me.FraCondEco.PerformLayout()
        CType(Me.cbxUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mstrProveedorContrata As String

    Dim blnOrdenar As Boolean = True
    Public NOPERARIO As String

#Region " Load "

    Protected Overridable Sub MntoOperario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadToolBarActions()
            LoadEnums()
            LoadGridActions()
            Dim o As New Business.General.Operario
            cbxUsuario.DataSource = o.DevuelveUsuariosBD()
            If ExpertisApp.DataBaseName.ToUpper = "XTECOZAMUNITEDKINGDOM50R2" Then
                txtsortcode.Visible = True
                txtaccountNumber.Visible = True
                lblsortcode.Visible = True
                lblaccountNumber.Visible = True
            End If
        End If
    End Sub

    Protected Overridable Sub LoadERPData()
        mstrProveedorContrata = New Parametro().TipoProvContrata
    End Sub

    Protected Overridable Sub LoadToolBarActions()
        Me.FormActions.Add("Ver Calendario de Operario", AddressOf VerCalendarioOperario, ExpertisApp.GetIcon("calendar.ico"))
        Me.FormActions.Add("Duplicar Operario", AddressOf DuplicarOperario)
        'David Velasco 15/2/24
        Me.AddSeparator()
        Me.FormActions.Add("Generar listado CAIXA alta personas", AddressOf GenerarListadoCaixaPersonas)
        'David Velasco 22/8/24
        Me.AddSeparator()

        'If ExpertisApp.DataBaseName = "xTecozamNorge50R2" Then
        '    Me.FormActions.Add("Listado de horas Tecozam", AddressOf GenerarCuadranteHorasNoruega)
        'End If
    End Sub
    Public Sub GenerarCuadranteHorasNoruega()
        ' Solicitar la contraseña al usuario
        Dim inputPassword As String = InputBox("Por favor, introduzca la contraseña:", "Contraseña requerida")

        ' Verificar si la contraseña es "zz"
        If inputPassword = "zz" Then
            ' Contraseña correcta, se ejecuta la exportación
            Dim frm As New AppHorasInternacional
            frm.ShowDialog()
            Exit Sub
        End If
    End Sub

    Public Sub GenerarListadoCaixaPersonas()
        Dim dtPersonasSinProcesar As DataTable = devuelvePersonas()
        Dim dtEstructuraTabla As DataTable = devuelveFormaTabla()

        Dim dtProcesada As DataTable = devuelveTablaProcesada(dtPersonasSinProcesar, dtEstructuraTabla)

        Dim ruta As String
        ruta = DevuelveRuta()
        ExportarExcelListadoCaixa(ruta, dtProcesada)
    End Sub

    Public Sub ExportarExcelListadoCaixa(ByVal ruta As String, ByVal dtFinal As DataTable)

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        Using package As New ExcelPackage(ruta)
            Dim worksheet = package.Workbook.Worksheets.Add("1")
            ' Copiar los datos de la DataTable a la hoja de cálculo.
            worksheet.Cells("A1").LoadFromDataTable(dtFinal, True)
            worksheet.Column(10).Width = 15
            ' Aplicar formato negrita a la fila 1
            Dim fila1 As ExcelRange = worksheet.Cells(1, 1, 1, worksheet.Dimension.End.Column)
            fila1.Style.Font.Bold = True
            ' Guardar el archivo de Excel.
            package.Save()
        End Using
    End Sub

    Public Function DevuelveRuta() As String
        Dim CD As New SaveFileDialog()

        CD.Title = "Seleccionar archivos"
        CD.Filter = "Archivos Excel (*.xlsx)|*.xlsx"

        'CD.ShowOpen()
        CD.ShowDialog()

        If CD.FileName <> "" Then
            'lblRuta.Caption = CD.FileName
            Return CD.FileName
        End If
    End Function
    Public Function devuelveTablaProcesada(ByVal dtPersonasSinProcesar As DataTable, ByVal dtEstructuraTabla As DataTable) As DataTable
        For Each dr As DataRow In dtPersonasSinProcesar.Rows
            Dim drFinal As DataRow
            drFinal = dtEstructuraTabla.NewRow
            drFinal("CIF/NIF PROMOTOR") = devuelveNIF()
            drFinal("NIF TITULAR") = dr("DNI").ToString
            drFinal("PRIMER APELLIDO") = devuelvePrimerApellido(dr("DescOperario").ToString)
            drFinal("SEGUNDO APELLIDO") = devuelveSegundoApellido(dr("DescOperario").ToString)
            drFinal("NOMBRE") = devuelveNombre(dr("DescOperario").ToString)
            drFinal("FECHA NACIMIENTO") = DevuelveFechaConFormato(devuelveFechaNacimiento(dr("IDOperario").ToString))
            drFinal("SEXO") = "V"
            drFinal("IDIOMA") = "CASTELLANO"
            drFinal("CÓDIGO VÍA PÚBLICA") = "CL"
            drFinal("DIRECCIÓN") = dr("Direccion").ToString
            drFinal("CÓDIGO POSTAL") = dr("CodPostal").ToString
            drFinal("POBLACIÓN") = dr("Poblacion").ToString
            drFinal("NACIONALIDAD") = "ESPAÑOLA"
            drFinal("FECHA ALTA PLAN") = DevuelveFechaConFormato("01/02/2024")
            drFinal("CÓDIGO EMPLEADO") = dr("IDOperario").ToString
            drFinal("INGRESOS SUPERIORES A 60.000 EUROS") = "N"
            drFinal("EMAIL") = dr("Email").ToString
            drFinal("MÓVIL") = dr("Telefono").ToString
            dtEstructuraTabla.Rows.Add(drFinal)
        Next
        Return dtEstructuraTabla
    End Function
    Public Function devuelvePrimerApellido(ByVal descOperario As String) As String
        Dim partes As String() = descOperario.Split(","c)

        ' Nombre es la parte de la derecha de la coma (eliminar espacios adicionales)
        Dim nombre As String = partes(1).Trim()

        ' Parte izquierda de la coma
        Dim parteIzquierda As String = partes(0)

        ' Dividir la parte izquierda en palabras
        Dim palabras As String() = parteIzquierda.Split(" "c)

        ' El primer elemento es el primer apellido
        Dim primerApellido As String = palabras(0)

        Return primerApellido
    End Function
    Public Function devuelveSegundoApellido(ByVal descOperario As String) As String
        Dim partes As String() = descOperario.Split(","c)

        ' Nombre es la parte de la derecha de la coma (eliminar espacios adicionales)
        Dim nombre As String = partes(1).Trim()

        ' Parte izquierda de la coma
        Dim parteIzquierda As String = partes(0)

        ' Dividir la parte izquierda en palabras
        Dim palabras As String() = parteIzquierda.Split(" "c)

        ' El primer elemento es el primer apellido
        Dim primerApellido As String = palabras(0)

        ' El segundo elemento, si existe, es el segundo apellido
        Dim segundoApellido As String = ""
        If palabras.Length > 1 Then
            For i As Integer = 1 To palabras.Length - 1
                segundoApellido &= palabras(i)
                If i < palabras.Length - 1 Then
                    segundoApellido &= " "
                End If
            Next
        End If

        Return segundoApellido
    End Function
    Public Function devuelveNombre(ByVal descOperario As String) As String
        Dim partes As String() = descOperario.Split(","c)

        ' Nombre es la parte de la derecha de la coma (eliminar espacios adicionales)
        Dim nombre As String = partes(1).Trim()
        Return nombre
    End Function
    Public Function DevuelveFechaConFormato(ByVal fechanumero As String) As String
        If fechanumero = "" Then
            Return ""
        End If
        Dim fechaActual As DateTime = fechanumero
        Dim formatoPersonalizado As String = "dd/MM/yyyy"
        Dim fechaComoStringConFormato As String = fechaActual.ToString(formatoPersonalizado)

        Return fechaComoStringConFormato

    End Function

    Public Function devuelveNIF() As String
        Dim dt As New DataTable
        Dim f As New Filter
        dt = New BE.DataEngine().Filter("tbDatosEmpresa", f)
        Return dt.Rows(0)("Cif").ToString
    End Function
    Public Function devuelveFechaNacimiento(ByVal idoperario As String) As String
        Dim dt As New DataTable
        Dim f As New Filter
        f.Add("IDOperario", FilterOperator.Equal, idoperario)
        dt = New BE.DataEngine().Filter("tbMaestroOperarioSAt", f)
        Return dt.Rows(0)("Fecha_Nacimiento").ToString
    End Function
    Public Function devuelvePersonas() As DataTable
        Dim dt As New DataTable
        Dim f As New Filter
        f.Add("Fecha_Baja", FilterOperator.Equal, System.DBNull.Value)
        Return New BE.DataEngine().Filter("frmMntoOperario", f)
    End Function
    Public Function devuelveFormaTabla() As DataTable
        Dim dt As New DataTable

        Dim dc As New DataColumn("CIF/NIF PROMOTOR")
        dt.Columns.Add(dc)
        dc = New DataColumn("NIF TITULAR")
        dt.Columns.Add(dc)
        dc = New DataColumn("PRIMER APELLIDO")
        dt.Columns.Add(dc)
        dc = New DataColumn("SEGUNDO APELLIDO")
        dt.Columns.Add(dc)
        dc = New DataColumn("NOMBRE")
        dt.Columns.Add(dc)
        dc = New DataColumn("FECHA NACIMIENTO")
        dt.Columns.Add(dc)
        dc = New DataColumn("SEXO")
        dt.Columns.Add(dc)
        dc = New DataColumn("IDIOMA")
        dt.Columns.Add(dc)
        dc = New DataColumn("CÓDIGO VÍA PÚBLICA")
        dt.Columns.Add(dc)
        dc = New DataColumn("DIRECCIÓN")
        dt.Columns.Add(dc)
        dc = New DataColumn("CÓDIGO POSTAL")
        dt.Columns.Add(dc)
        dc = New DataColumn("POBLACIÓN")
        dt.Columns.Add(dc)
        dc = New DataColumn("NACIONALIDAD")
        dt.Columns.Add(dc)
        dc = New DataColumn("FECHA ALTA PLAN")
        dt.Columns.Add(dc)
        dc = New DataColumn("CÓDIGO EMPLEADO")
        dt.Columns.Add(dc)
        dc = New DataColumn("INGRESOS SUPERIORES A 60.000 EUROS")
        dt.Columns.Add(dc)
        dc = New DataColumn("EMAIL")
        dt.Columns.Add(dc)
        dc = New DataColumn("MÓVIL")
        dt.Columns.Add(dc)
        Return dt

    End Function

    '-----FIN DAVID
    Protected Overridable Sub LoadEnums()
        CmbTipoDocIdent.DataSource = EnumData.EnumView("enumTipoDocIdent")
    End Sub

    Protected Overridable Sub LoadGridActions()
        'Me.GridOperarioHora.Actions.Add("Abrir Histórico", AddressOf AccionAbrirHistorico, ExpertisApp.GetIcon("book_blue.ico"))
    End Sub

#End Region

#Region " Toolbar Actions "

    Private Sub VerCalendarioOperario()
        Solmicro.Expertis.Engine.UI.ExpertisApp.OpenForm("CALOPERARIO", New FilterItem("IDOperario", Me.CurrentRow("IDOperario")))

    End Sub

    Private Sub DuplicarOperario()
        Dim frm As New FrmDuplicar
        Dim nuevoCodi As String

        frm.Show()
        'frm.txtOperario.Text = Me.CurrentRow("IDOperario")
        Dim dtNuevo As New DataTable
        Dim drNuevo As DataRow
        Me.CurrentRow("IDOperario") = frm.txtNuevoCodigo.Text
        drNuevo = Me.CurrentRow

        drNuevo("IDOperario") = frm.txtNuevoCodigo.Text
        MessageBox.Show("El nuevo Código es el siguiente" & frm.txtNuevoCodigo.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        dtNuevo.Rows.Add(drNuevo)
        Dim clsOperario As New Business.General.Operario
        clsOperario.Update(dtNuevo)
        MessageBox.Show("Usuario insertado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


    End Sub

#End Region

#Region "Grid Actions"
    'SERGIO BLANCO 07/06/2018
    'Private Sub AccionAbrirHistorico()
    '    Dim FrmHist As New frmHistoricoHoraTasa
    '    FrmHist.IDOperario = Me.CurrentRow("IDOperario")
    '    FrmHist.DescOperario = Me.CurrentRow("DescOperario")
    '    FrmHist.IDHora = Me.GridOperarioHora.GetValue("IDHora")
    '    FrmHist.TasaHorariaA = Me.GridOperarioHora.GetValue("TasaHorariaA")
    '    FrmHist.ShowDialog()
    'End Sub

#End Region

    Private Sub MntoOperario_BusinessCalled(ByVal sender As Object, ByVal e As Engine.UI.BusinessCalledEventArgs) Handles Me.BusinessCalled
        If Not IsNothing(e.Data) AndAlso e.Data.ContainsKey("DNICorrecto") Then
            txtDNI.Text = e.Data("DNICorrecto")
        End If
    End Sub

    Protected Overridable Sub MntoOperario_Navigated(ByVal sender As Object, ByVal e As Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        MostrarExternoProveedor()
        'Saca Desc Obra Predeterminada
        Try
            Dim idobra As String
            idobra = advObra_Predeterminada.Text

            Dim filtro As New Filter
            filtro.Add("IDObra", FilterOperator.Equal, idobra)

            Dim dt As New DataTable
            dt = New BE.DataEngine().Filter("tbObraCabecera", filtro)

            Dim descObra As String
            descObra = dt.Rows(0)("DescObra").ToString
            ulObra.Text = descObra
        Catch ex As Exception
            ulObra.Text = ""
        End Try

    End Sub

    Protected Overridable Sub chkExterno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkExterno.CheckedChanged
        MostrarExternoProveedor()
    End Sub

    Protected Overridable Sub MostrarExternoProveedor()
        'lblProveedor.Visible = chkExterno.Checked
        'AdvIdProveedor.Visible = chkExterno.Checked
        'ulDescProveedor.Visible = chkExterno.Checked
    End Sub

    Protected Overridable Sub AdvIdProveedor_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs)
        e.Filter.Add(New StringFilterItem("IDTipoProveedor", FilterOperator.Equal, mstrProveedorContrata))
    End Sub

    Private Sub txtDNI_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDNI.Validating
        ValidaDocumentoIdentificativo()
    End Sub

    Private Sub advIDPais_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles advIDPais.Validating
        ValidaDocumentoIdentificativo()
    End Sub

    Private Sub CmbTipoDocIdent_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CmbTipoDocIdent.Validating
        ValidaDocumentoIdentificativo()
    End Sub

    Private Function ValidaDocumentoIdentificativo() As Boolean
        Dim blnOK As Boolean = True
        If Length(txtDNI.Text) > 0 Then
            Dim datos As New DataDocIdentificacion(txtDNI.Text, advIDPais.Text, CmbTipoDocIdent.Value)
            datos = ExpertisApp.ExecuteTask(Of DataDocIdentificacion, DataDocIdentificacion)(AddressOf Comunes.ValidarDocumentoIdentificativo, datos)
            If Not datos.EsCorrecto Then
                If Length(datos.DocumentoCorrecto) > 0 Then
                    txtDNI.Text = datos.DocumentoCorrecto
                Else
                    blnOK = False
                    ExpertisApp.GenerateMessage("El Documento introducido no es un '|'. Intoduzca uno correcto o cambie de tipo de documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, datos.TipoDocumento)
                End If
            End If
        End If

        Return blnOK
    End Function

    Private Sub advCodPostal_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advCodPostal.SetPredefinedFilter
        If Length(advIDPais.Text) > 0 Then e.Filter.Add(New StringFilterItem("IDPais", advIDPais.Text))
    End Sub

    Private Sub advCodPostal_NotInList(ByVal sender As Object, ByVal e As Engine.UI.NotInListEventArgs) Handles advCodPostal.NotInList
        e.Handled = True
        e.Cancel = False
    End Sub

    Private Sub advPoblacion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advPoblacion.SetPredefinedFilter
        If Length(advIDPais.Text) > 0 Then e.Filter.Add(New StringFilterItem("IDPais", advIDPais.Text))
        If Length(advCodPostal.Text) > 0 Then e.Filter.Add(New StringFilterItem("CodPostal", advCodPostal.Text))
    End Sub

    Private Sub advPoblacion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advPoblacion.SelectionChanged
        If Not e.Selected Is Nothing Then
            If Length(e.Selected.Rows(0)("IDPais")) > 0 Then advIDPais.Text = e.Selected.Rows(0)("IDPais")
            If Length(e.Selected.Rows(0)("CodPostal")) > 0 Then advCodPostal.Text = e.Selected.Rows(0)("CodPostal")
            If Length(e.Selected.Rows(0)("DescProvincia")) > 0 Then txtProvincia.Text = e.Selected.Rows(0)("DescProvincia")
        End If
    End Sub

    Private Sub advPoblacion_NotInList(ByVal sender As Object, ByVal e As Engine.UI.NotInListEventArgs) Handles advPoblacion.NotInList
        e.Handled = True
        e.Cancel = False
    End Sub

    Private Sub CmbCurriculum_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbCurriculum.Click
        OpenFileDialog1.InitialDirectory = ExpertisApp.Path
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> String.Empty Then
            txtCurriculum.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Public Overrides Sub UpdateData(Optional ByVal EndCurrentEdit As Boolean = True)
        If Me.CurrentRow.RowState = DataRowState.Deleted Then
            MyBase.UpdateData(EndCurrentEdit)
            Me.GotoRecord(DataProviderActions.GoFirst)
        Else
            MyBase.UpdateData(EndCurrentEdit)
        End If
    End Sub
    'SERGIO BLANCO 07/06/2018
    'Private Sub GridOperarioHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim Hit As Janus.Windows.GridEX.GridArea = Me.GridOperarioHora.HitTest
    '    If Hit = Janus.Windows.GridEX.GridArea.Cell Then
    '        Dim c As Janus.Windows.GridEX.GridEXColumn = Me.GridOperarioHora.ColumnFromPoint()
    '        If Not IsNothing(c) Then
    '            Select Case c.Key
    '                Case "BtnHistorico"
    '                    Dim FrmHistorico As New frmHistoricoHoraTasa
    '                    FrmHistorico.IDOperario = Me.CurrentRow("IDOperario")
    '                    FrmHistorico.DescOperario = Me.CurrentRow("DescOperario")
    '                    FrmHistorico.TasaHorariaA = Me.GridOperarioHora.GetValue("TasaHorariaA")
    '                    FrmHistorico.IDHora = Me.GridOperarioHora.GetValue("IDHora")
    '                    FrmHistorico.ShowDialog()
    '            End Select
    '        End If
    '    End If
    'End Sub

    'Private Sub GridOperarioHora_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs)
    '    Select Case e.Column.Key
    '        Case "TasaHorariaA"
    '            If Me.GridOperarioHora.Row <> Me.GridOperarioHora.newTopRowPosition Then
    '                If ExpertisApp.GenerateMessage("Si desea mantener la Tasa que tenía registrada, deberá insertar la información del periodo de vigencia para dicha tasa, ¿desea dar de alta el nuevo registro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = Windows.Forms.DialogResult.Yes Then
    '                    Dim FrmHist As New frmHistoricoHoraTasa
    '                    FrmHist.IDOperario = Me.CurrentRow("IDOperario")
    '                    FrmHist.DescOperario = Me.CurrentRow("DescOperario")
    '                    FrmHist.IDHora = Me.GridOperarioHora.GetValue("IDHora")
    '                    FrmHist.TasaHorariaA = e.InitialValue
    '                    FrmHist.ShowDialog()
    '                End If
    '            End If
    '    End Select
    'End Sub

    Private Sub pnlFichaOperario_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlFichaOperario.Paint

    End Sub


    Private Sub btnHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistorico.Click
        If GridHistorico.Visible = True Then
            GridHistorico.Visible = False
        Else
            GridHistorico.Visible = True
        End If

    End Sub

    Private Sub MntoOperario_Navigating(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatingEventArgs) Handles MyBase.Navigating
        '    'David. Ponemos q nos ordene por NOperarioOrden, para q salga ordenado, la cosa
        '    'es que la casilla blanca de FindText no funciona. Entonces vamos a hacer una ñapa.

        'Cogemos el valor que tenemos en la caja blanca
        Dim CodigoCorto As String
        Dim CodigoLargo As String

        Dim rs As New DataTable
        Dim obj As New Business.General.Operario

        Dim f As New Filter
        Try

            If blnOrdenar = False Then
                blnOrdenar = True
                Exit Sub
            End If

            If Me.FindText.Control.Text = NOPERARIO Then
                Me.FindText.Control.Text = ""
            End If

            If Nz(Me.FindText.Control.Text, "") = "" Then
                Exit Sub
            Else
                CodigoCorto = Me.FindText.Control.Text

                f.Add("IDOperario", CodigoCorto)
                rs = obj.Filter(f)
                CodigoLargo = rs.Rows(0)("NOperarioOrden").ToString
                blnOrdenar = False
                Me.GotoRecord(CodigoLargo)
                'Me.FindText.Control.Text = CodigoLargo
                NOPERARIO = Me.FindText.Control.Text
                e.Cancel = True
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            rs = Nothing
            obj = Nothing
            f = Nothing
        End Try
    End Sub

    Private Sub MntoOperario_SetReportDesignObjects(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Dim Fecha1 As Date
        Dim Fecha2 As Date

        If e.Alias = "LISTHORAS" Then
            Dim frm As New frmInformeFecha
            frm.ShowDialog()
            'vMes = frm.VM
            Fecha1 = frm.FechaDesde.Value
            'vAnio = frm.VA
            Fecha2 = frm.FechaHasta.Value
            Dim idHora As String = frm.idHora
            Dim DescHora As String = frm.DescHora
            GenerarListadoHoras(Fecha1, Fecha2, idHora, DescHora)
            e.Cancel = True
        End If
    End Sub
    Private Sub GenerarListadoHoras(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idHora As String, ByVal DescHora As String)
        Dim rp As New Report("LISTHORAS")

        rp.Formulas("CodTrabajador").Text = CntIDOperario.Text
        rp.Formulas("DescTrabajador").Text = txtDescOperario.Text
        rp.Formulas("Fecha1").Text = Fecha1
        rp.Formulas("Fecha2").Text = Fecha2
        rp.Formulas("TipoHora").Text = idHora
        rp.Formulas("DescHora").Text = DescHora
        ExpertisApp.OpenReport(rp)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenIBAN.Click
        Dim idbanco As String = advIDBanco.Text
        Dim sucursal As String = txtSucursal.Text
        Dim dc As String = txtDigitoControl.Text
        Dim ncuenta As String = txtNCuenta.Text
        Dim frm As New frmIntroducirCodigoISO
        frm.ShowDialog()
        Dim codIso As String = frm.CodigoISO
        Dim codIBAN As String = GenerarCodigoIBAN(idbanco, sucursal, dc, ncuenta, codIso)
        txtCodigoIBAN.Text = codIBAN
        'Obtener el SWIFT
        Dim dt As New DataTable
        Dim filtro As New Filter
        filtro.Add("IDBanco", FilterOperator.Equal, idbanco)
        dt = New BE.DataEngine().Filter("tbMaestroBanco", filtro)
        txtSwift.Text = dt.Rows(0)("SWIFT").ToString
    End Sub

    Public Function GenerarCodigoIBAN(ByVal IDBanco As String, ByVal Sucursal As String, ByVal DigitoControl As String, ByVal NCuenta As String, ByVal CodigoISO As String) As String
        If IDBanco.ToString.Length = 0 OrElse Sucursal.ToString.Length = 0 OrElse DigitoControl.ToString.Length = 0 OrElse NCuenta.ToString.Length = 0 OrElse CodigoISO.ToString.Length = 0 Then Exit Function
        If IDBanco.ToString.Length <> 4 OrElse Sucursal.ToString.Length <> 4 OrElse DigitoControl.ToString.Length <> 2 OrElse NCuenta.ToString.Length <> 10 OrElse CodigoISO.ToString.Length <> 2 Then Exit Function

        Dim strCodigo As String = IDBanco + Sucursal + DigitoControl + NCuenta + GetCaracteresEnNumero(CodigoISO) + "00"
        Dim Resto As Integer = CDec(strCodigo) Mod 97
        Resto = 98 - Resto
        Dim DC As String = Format(Resto, "0#")

        Return CodigoISO + DC + IDBanco + Sucursal + DigitoControl + NCuenta
    End Function
    Public Function GetCaracteresEnNumero(ByVal data As String) As String
        Dim Num As String = String.Empty
        For Each c As Char In data
            Select Case UCase(c)
                Case "A"
                    Num &= "10"
                Case "B"
                    Num &= "11"
                Case "C"
                    Num &= "12"
                Case "D"
                    Num &= "13"
                Case "E"
                    Num &= "14"
                Case "F"
                    Num &= "15"
                Case "G"
                    Num &= "16"
                Case "H"
                    Num &= "17"
                Case "I"
                    Num &= "18"
                Case "J"
                    Num &= "19"
                Case "K"
                    Num &= "20"
                Case "L"
                    Num &= "21"
                Case "M"
                    Num &= "22"
                Case "N"
                    Num &= "23"
                Case "O"
                    Num &= "24"
                Case "P"
                    Num &= "25"
                Case "Q"
                    Num &= "26"
                Case "R"
                    Num &= "27"
                Case "S"
                    Num &= "28"
                Case "T"
                    Num &= "29"
                Case "U"
                    Num &= "30"
                Case "V"
                    Num &= "31"
                Case "W"
                    Num &= "32"
                Case "X"
                    Num &= "33"
                Case "Y"
                    Num &= "34"
                Case "Z"
                    Num &= "35"
                Case Else
                    Num &= c
            End Select
        Next
        Return Num
    End Function

    Private Sub bHistoricoProyecto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bHistoricoProyecto.Click
        Try
            If GridHistoricoPersonal.Visible = True Then
                GridHistoricoPersonal.Visible = False
            Else
                GridHistoricoPersonal.Visible = True
            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Function devuelveNObra(ByVal IDObra As String) As String
        Dim f As New Filter
        f.Add("IDObra", FilterOperator.Equal, IDObra)
        Dim dt As New DataTable

        dt = New BE.DataEngine().Filter("tbObraCabecera", f)
        Return dt.Rows(0)("NObra")
    End Function

    Public Function devuelveUltimaObra() As String
        Dim f As New Filter
        f.Add("IDOperario", FilterOperator.Equal, CurrentRow("IDOperario"))
        Dim dt As New DataTable
        dt = New BE.DataEngine().Filter("tbHistoricoPersonal", f, , "Fecha desc")

        Return dt.Rows(0)("Proyecto")
    End Function
    Public Sub AñadeLineaHistorico(ByVal NObra As String)
        Dim LineaH As New HistoricoPersonal
        Dim dtLineaH As DataTable = LineaH.AddNewForm
        'dtLineaH.Rows(0)("IDLinea") = 3
        dtLineaH.Rows(0)("Fecha") = Today
        dtLineaH.Rows(0)("IDOperario") = CurrentRow("IDOperario")
        dtLineaH.Rows(0)("Proyecto") = NObra

        LineaH.Update(dtLineaH)
    End Sub

    Private Sub cbxFechaAlta_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxFechaAlta.Leave

        If Len(txtIDGET.Text) = 0 Then
            Dim IDGET As String = GetIDGET()
            setIDGET()
            txtIDGET.Text = IDGET
        End If

    End Sub

    Public Function GetIDGET() As String
        Dim f As New Filter
        f.Add("IDContador", FilterOperator.Equal, "IDGET")
        Dim dt As New DataTable
        dt = New BE.DataEngine().Filter("xTecozam50R2..tbMaestroContador", f)

        Dim texto As String
        texto = dt.Rows(0)("Texto")

        Dim numerico As String
        numerico = dt.Rows(0)("Contador")

        If Len(numerico) = 1 Then
            texto = texto & "0000" & numerico
        ElseIf Len(numerico) = 2 Then
            texto = texto & "000" & numerico
        ElseIf Len(numerico) = 3 Then
            texto = texto & "00" & numerico
        ElseIf Len(numerico) = 4 Then
            texto = texto & "0" & numerico
        Else
            texto = texto
        End If

        Return texto

    End Function

    Public Sub setIDGET()
        Dim f As New Filter
        f.Add("IDContador", FilterOperator.Equal, "IDGET")
        Dim dt As New DataTable
        dt = New BE.DataEngine().Filter("xTecozam50R2..tbMaestroContador", f)

        Dim texto As String
        texto = dt.Rows(0)("Texto")

        Dim numerico As Integer
        numerico = dt.Rows(0)("Contador")

        numerico = numerico + 1

        Dim sql As String
        sql = "UPDATE xTecozam50R2..tbMaestroContador set Contador= " & numerico & " Where IDContador='IDGET'"

        Dim aux As New Business.ClasesTecozam.MetodosAuxiliares
        aux.EjecutarSql(sql)

    End Sub

    Private Sub advObra_Predeterminada_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles advObra_Predeterminada.Enter
        'Dim IDObra As String = ""
        'IDObra = advObra_Predeterminada.Text
        'If Len(IDObra) > 0 Then

        '    'Dim nObra As String
        '    'nObra = devuelveNObra(advObra_Predeterminada.Text)
        '    Try
        '        If IDObra = devuelveUltimaObra() Then
        '            'MsgBox("Es misma obra, no se añade nada.")
        '        Else
        '            'MsgBox("Se añade obra")
        '            Dim result As DialogResult = MessageBox.Show("¿Deseas actualizar a este operario de obra_predeterminada ? Se añadará la obra anterior al historial.", "Confirmación datos", MessageBoxButtons.YesNo)
        '            If result = DialogResult.Yes Then
        '                AñadeLineaHistorico(IDObra)
        '            End If
        '        End If
        '    Catch ex As Exception
        '        Dim result As DialogResult = MessageBox.Show("¿Deseas actualizar a este operario de obra_predeterminada ? Se añadará la obra anterior al historial.", "Confirmación datos", MessageBoxButtons.YesNo)
        '        If result = DialogResult.Yes Then
        '            AñadeLineaHistorico(IDObra)
        '        End If
        '    End Try
        '    Me.UpdateData()
        'End If

    End Sub

    Private Sub advIdOficio_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advIdOficio.SetPredefinedFilter
        If ExpertisApp.DataBaseName = "xTecozam50R2" Then
            Dim f As New Filter(FilterUnionOperator.Or)
            If Len(AdvIDCategoria.Text) <> 0 Then
                If AdvIDCategoria.Text = 1 Then
                    f.Add(New StringFilterItem("IDOficio", "J. Prod"))
                ElseIf AdvIDCategoria.Text = 2 Then
                    f.Add(New StringFilterItem("IDOficio", "Capataz"))
                    f.Add(New StringFilterItem("IDOficio", "Encargado"))
                ElseIf AdvIDCategoria.Text = 3 Then
                    f.Add(New StringFilterItem("IDOficio", "Encofrador"))
                    f.Add(New StringFilterItem("IDOficio", "Ferrallist"))
                    f.Add(New StringFilterItem("IDOficio", "Op.Almacen"))
                    f.Add(New StringFilterItem("IDOficio", "Sold. Of 2"))
                ElseIf AdvIDCategoria.Text = 4 Then
                    f.Add(New StringFilterItem("IDOficio", "TEC_OBRA"))
                ElseIf AdvIDCategoria.Text = 5 Then
                    f.Add(New StringFilterItem("IDOficio", "ADMINOBRA"))
                    f.Add(New StringFilterItem("IDOficio", "AUXILIARES"))
                    f.Add(New StringFilterItem("IDOficio", "Calidad"))
                    f.Add(New StringFilterItem("IDOficio", "COMPRAS"))
                    f.Add(New StringFilterItem("IDOficio", "CONTABILID"))
                    f.Add(New StringFilterItem("IDOficio", "CONTRATA"))
                    f.Add(New StringFilterItem("IDOficio", "COSTES"))
                    f.Add(New StringFilterItem("IDOficio", "DELEGADO"))
                    f.Add(New StringFilterItem("IDOficio", "DIRECCION"))
                    f.Add(New StringFilterItem("IDOficio", "Documentac"))
                    f.Add(New StringFilterItem("IDOficio", "ENCOFRADOS"))
                    f.Add(New StringFilterItem("IDOficio", "INFORMATIC"))
                    f.Add(New StringFilterItem("IDOficio", "TECDES"))
                    f.Add(New StringFilterItem("IDOficio", "MEDICIONES"))
                    f.Add(New StringFilterItem("IDOficio", "Prevencion"))
                    f.Add(New StringFilterItem("IDOficio", "RRHH"))
                End If
            End If         
            e.Filter.Add(f)
        ElseIf ExpertisApp.DataBaseName = "xFerrallas50R2" Then
            Dim f As New Engine.Filter(FilterUnionOperator.Or)
            If Len(AdvIDCategoria.Text) <> 0 Then
                If AdvIDCategoria.Text = 1 Then
                ElseIf AdvIDCategoria.Text = 2 Then
                    f.Add(New StringFilterItem("IDOficio", "ENCARGADO"))
                ElseIf AdvIDCategoria.Text = 3 Then
                    f.Add(New StringFilterItem("IDOficio", "ENC OF 1ª"))
                    f.Add(New StringFilterItem("IDOficio", "FER OF 1º"))
                    f.Add(New StringFilterItem("IDOficio", "FER OF 2º"))
                    f.Add(New StringFilterItem("IDOficio", "GRUISTA"))
                ElseIf AdvIDCategoria.Text = 4 Then
                ElseIf AdvIDCategoria.Text = 5 Then
                    f.Add(New StringFilterItem("IDOficio", "COND"))
                    f.Add(New StringFilterItem("IDOficio", "JEFETALLER"))
                    f.Add(New StringFilterItem("IDOficio", "INFORMATIC"))
                    f.Add(New StringFilterItem("IDOficio", "LIMP"))
                    f.Add(New StringFilterItem("IDOficio", "MEDICIONES"))
                    f.Add(New StringFilterItem("IDOficio", "RECEPCION"))
                    f.Add(New StringFilterItem("IDOficio", "TECDES"))
                    f.Add(New StringFilterItem("IDOficio", "TECPROY"))
                End If
            End If
            e.Filter.Add(f)
        ElseIf ExpertisApp.DataBaseName = "xSecozam50R2" Then
            Dim f As New Filter(FilterUnionOperator.Or)
            If Len(AdvIDCategoria.Text) <> 0 Then
                If AdvIDCategoria.Text = 1 Then
                ElseIf AdvIDCategoria.Text = 2 Then
                ElseIf AdvIDCategoria.Text = 3 Then
                ElseIf AdvIDCategoria.Text = 4 Then
                ElseIf AdvIDCategoria.Text = 5 Then
                    f.Add(New StringFilterItem("IDOficio", "ADMINISTRA"))
                    f.Add(New StringFilterItem("IDOficio", "DELINEANTE"))
                    f.Add(New StringFilterItem("IDOficio", "ENCOFRADOS"))
                    f.Add(New StringFilterItem("IDOficio", "JEFEOT"))
                    f.Add(New StringFilterItem("IDOficio", "MARCOTEC"))
                    f.Add(New StringFilterItem("IDOficio", "TECCOSTES"))
                    f.Add(New StringFilterItem("IDOficio", "TECPROY"))
                End If
            End If
            e.Filter.Add(f)
        ElseIf ExpertisApp.DataBaseName = "xTecozamUnitedKingdom50R2" Then
            Dim f As New Filter(FilterUnionOperator.Or)
            If Len(AdvIDCategoria.Text) <> 0 Then
                If AdvIDCategoria.Text = 1 Then
                ElseIf AdvIDCategoria.Text = 2 Then
                    f.Add(New StringFilterItem("IDOficio", "ENCARGADO"))
                ElseIf AdvIDCategoria.Text = 3 Then
                    f.Add(New StringFilterItem("IDOficio", "ENC"))
                    f.Add(New StringFilterItem("IDOficio", "FERR"))
                ElseIf AdvIDCategoria.Text = 4 Then
                    f.Add(New StringFilterItem("IDOficio", "TEC_OBRA"))
                ElseIf AdvIDCategoria.Text = 5 Then
                End If
            End If
            e.Filter.Add(f)
        ElseIf ExpertisApp.DataBaseName = "xTecozamNorge50R2" Then
            Dim f As New Filter(FilterUnionOperator.Or)
            If Len(AdvIDCategoria.Text) <> 0 Then
                If AdvIDCategoria.Text = 1 Then
                ElseIf AdvIDCategoria.Text = 2 Then
                    f.Add(New StringFilterItem("IDOficio", "ENCARGADO"))
                ElseIf AdvIDCategoria.Text = 3 Then
                    f.Add(New StringFilterItem("IDOficio", "ENC"))
                    f.Add(New StringFilterItem("IDOficio", "FERR"))
                ElseIf AdvIDCategoria.Text = 4 Then
                    f.Add(New StringFilterItem("IDOficio", "TEC_OBRA"))
                ElseIf AdvIDCategoria.Text = 5 Then
                End If
            End If
            e.Filter.Add(f)
        ElseIf ExpertisApp.DataBaseName = "xDrenajesPortugal50R2" Then
            Dim f As New Filter(FilterUnionOperator.Or)
            If Len(AdvIDCategoria.Text) <> 0 Then
                If AdvIDCategoria.Text = 1 Then
                ElseIf AdvIDCategoria.Text = 2 Then
                    f.Add(New StringFilterItem("IDOficio", "ENCARGADO"))
                ElseIf AdvIDCategoria.Text = 3 Then
                    f.Add(New StringFilterItem("IDOficio", "ENC"))
                ElseIf AdvIDCategoria.Text = 4 Then
                    f.Add(New StringFilterItem("IDOficio", "TEC_OBRA"))
                ElseIf AdvIDCategoria.Text = 5 Then
                    f.Add(New StringFilterItem("IDOficio", "ADMINISTRA"))
                    f.Add(New StringFilterItem("IDOficio", "TECPROY"))
                End If
            End If
            e.Filter.Add(f)
        End If
    End Sub

    Private Sub AdvIDCategoria_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDCategoria.SetPredefinedFilter
        Dim f As New Filter(FilterUnionOperator.Or)
        f.Add(New StringFilterItem("IDCategoria", 1))
        f.Add(New StringFilterItem("IDCategoria", 2))
        f.Add(New StringFilterItem("IDCategoria", 3))
        f.Add(New StringFilterItem("IDCategoria", 4))
        f.Add(New StringFilterItem("IDCategoria", 5))
        e.Filter.Add(f)
    End Sub

    Private Sub advObra_Predeterminada_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advObra_Predeterminada.SetPredefinedFilter
        If ExpertisApp.DataBaseName = "xTecozam50R2" Then
            Dim f As New Filter(FilterUnionOperator.Or)
            f.Add(New StringFilterItem("IDObra", 73))
            f.Add(New StringFilterItem("IDObra", 16895681))
            f.Add(New StringFilterItem("IDObra", 15331132))
            f.Add(New StringFilterItem("IDObra", 50010))
            f.Add(New StringFilterItem("IDObra", 16901645))
            f.Add(New StringFilterItem("IDObra", 17734421))
            e.Filter.Add(f)
        ElseIf ExpertisApp.DataBaseName = "xFerrallas50R2" Then
            Dim f As New Filter(FilterUnionOperator.Or)
            f.Add(New StringFilterItem("IDObra", 12677615))
            f.Add(New StringFilterItem("IDObra", 12677838))
            f.Add(New StringFilterItem("IDObra", 12678141))
            f.Add(New StringFilterItem("IDObra", 50001))
            e.Filter.Add(f)
        ElseIf ExpertisApp.DataBaseName = "xSecozam50R2" Then
            Dim f As New Filter(FilterUnionOperator.Or)
            f.Add(New StringFilterItem("IDObra", 11854231))
            f.Add(New StringFilterItem("IDObra", 11854299))
            e.Filter.Add(f)
        End If
    End Sub

    Private Sub AdvIDDepartamento_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDDepartamento.SetPredefinedFilter
        If ExpertisApp.DataBaseName = "xTecozam50R2" Then
            Dim f As New Filter(FilterUnionOperator.Or)
            f.Add(New StringFilterItem("IDDepartamento", "01"))
            f.Add(New StringFilterItem("IDDepartamento", "02"))
            f.Add(New StringFilterItem("IDDepartamento", "06"))
            f.Add(New StringFilterItem("IDDepartamento", "32"))
            f.Add(New StringFilterItem("IDDepartamento", "20"))
            f.Add(New StringFilterItem("IDDepartamento", "26"))
            f.Add(New StringFilterItem("IDDepartamento", "33"))
            e.Filter.Add(f)
        End If
    End Sub
End Class
