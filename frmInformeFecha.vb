Public Class frmInformeFecha
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Public blEstado As Boolean
    Public fecha1 As Date
    Public fecha2 As Date
    Public idHora As String
    Public DescHora As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        blEstado = True
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fecha1 = Nz(FechaDesde.Value, 0)
        fecha2 = Nz(FechaHasta.Value, 0)
        idHora = UiCB_TipoHora.Value
        DescHora = UiCB_TipoHora.Text
        blEstado = False
        Me.Close()
    End Sub

    Private Sub CargarCombos()
        Try
            Dim Strsql As String
            Strsql = "SELECT IDHora,DescHora FROM tbMaestroHora"
            ''' Cargar Jefes
            'UiCB_TipoHora.DataSource = AdminData.Filter(Strsql, , , , False).DataTable
            Dim filtro As New Filter

            UiCB_TipoHora.DataSource = New BE.DataEngine().Filter("tbMaestroHora", filtro, "IDHora, DescHora")
            UiCB_TipoHora.DisplayMember = UiCB_TipoHora.DataSource.Columns("DescHora").Caption.ToString
            UiCB_TipoHora.ValueMember = UiCB_TipoHora.DataSource.Columns("IDHora").Caption.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmInformeFecha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombos()
    End Sub
End Class