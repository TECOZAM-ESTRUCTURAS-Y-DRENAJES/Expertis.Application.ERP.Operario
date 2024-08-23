Imports Expertis.Application.ERP.HorasTrab

Public Class AppHorasInternacional
    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        LoadToolbarActions()
    End Sub

    Private Sub frmHorasInternacionalApp_QueryExecuting(ByVal sender As System.Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("NObra", FilterOperator.Equal, advNObra.Text)
        e.Filter.Add("IDOperario", FilterOperator.Equal, advIDOperario.Text)
        e.Filter.Add("FechaParte", FilterOperator.GreaterThanOrEqual, clbFecha1.Value, FilterType.DateTime)
        e.Filter.Add("FechaParte", FilterOperator.LessThanOrEqual, clbFecha2.Value, FilterType.DateTime)
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Generar excel horas Noruega.", AddressOf exportacion)
    End Sub

    Private Sub exportacion()
        ' Crear una instancia de la clase ExportacionCuadranteNoruega
        Dim tablaOriginal As String = "frmMntoHorasInternacionalTecozam"
        Dim exportacion As New ExportacionNoruegaCuadrante()
        ' Llamar al método generaExcelNoruega
        exportacion.tablaDatos = tablaOriginal
        exportacion.tipoExportacion = "TECOZAM"
        exportacion.generaExcelNoruega()
    End Sub
End Class