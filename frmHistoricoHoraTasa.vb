Public Class frmHistoricoHoraTasa

#Region "Propiedades Públicas"

    Private MIDOperario As String
    Public WriteOnly Property IDOperario() As String
        Set(ByVal value As String)
            MIDOperario = value
        End Set
    End Property

    Private MDescOperario As String
    Public WriteOnly Property DescOperario() As String
        Set(ByVal value As String)
            MDescOperario = value
        End Set
    End Property

    Private MIDHora As String
    Public WriteOnly Property IDHora() As String
        Set(ByVal value As String)
            MIDHora = value
        End Set
    End Property

    Private MTasaHorariaA As Double
    Public WriteOnly Property TasaHorariaA() As Double
        Set(ByVal value As Double)
            MTasaHorariaA = value
        End Set
    End Property

#End Region

#Region "Funciones / Procesos Privados"

    Private Sub LoadData()
        Me.TxtOperario.Text = MIDOperario
        Me.ULblDescOperario.Text = MDescOperario
        Me.TxtHora.Text = MIDHora
        Me.ULblDescHora.Text = Nz(New Hora().SelOnPrimaryKey(MIDHora).Rows(0)("DescHora"), String.Empty)

        Dim FilData As New Filter
        FilData.Add("IDOperario", FilterOperator.Equal, MIDOperario)
        FilData.Add("IDHora", FilterOperator.Equal, MIDHora)
        Dim DtHist As DataTable = New HistoricoTasaOperarioHora().Filter(FilData)
        Me.GrdHistorico.DataSource = DtHist

        Me.GrdHistorico.Columns("IDOperario").DefaultValue = MIDOperario
        Me.GrdHistorico.Columns("IDHora").DefaultValue = MIDHora
        Me.GrdHistorico.Columns("TasaHorariaA").DefaultValue = MTasaHorariaA
        Me.GrdHistorico.Columns("FechaDesde").DefaultValue = Date.Now
        Me.GrdHistorico.Columns("FechaHasta").DefaultValue = Date.Now
    End Sub

    Private Sub SaveData()
        Dim DtData As DataTable = Me.GrdHistorico.DataSource
        'Análisis de estados de rows
        Dim DtDelete As DataTable = DtData.GetChanges(DataRowState.Deleted)
        Dim ClsHist As New HistoricoTasaOperarioHora
        If Not DtDelete Is Nothing AndAlso DtDelete.Rows.Count > 0 Then
            DtDelete.RejectChanges()
            ClsHist.Delete(DtDelete)
        End If
        Dim DtAdded As DataTable = DtData.GetChanges(DataRowState.Added Or DataRowState.Modified)
        If Not DtAdded Is Nothing AndAlso DtAdded.Rows.Count > 0 Then
            ClsHist.Validate(DtAdded)
            ClsHist.Update(DtAdded)
        End If
    End Sub

#End Region

#Region "Eventos Formulario"

    Private Sub frmHistoricoHoraTasa_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub GrdHistorico_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GrdHistorico.AddingRecord
        If Length(Me.GrdHistorico.GetValue("FechaDesde")) = 0 OrElse Length(Me.GrdHistorico.GetValue("FechaHasta")) = 0 Then
            ExpertisApp.GenerateMessage("Las Fechas son un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub GrdHistorico_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GrdHistorico.EditingCell
        Select Case e.Column.Key
            Case "FechaDesde", "FechaHasta"
                If GrdHistorico.Row <> GrdHistorico.newTopRowPosition Then
                    e.Cancel = True
                End If
        End Select
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        SaveData()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

#End Region

End Class