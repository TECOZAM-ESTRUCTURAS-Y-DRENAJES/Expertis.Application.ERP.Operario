Imports Solmicro.Expertis.Engine.DAL
Imports Solmicro.Expertis.Business.BusinessEnum
Imports Solmicro.Expertis.Engine.BE
Public Class FrmDuplicar
    Dim nuevoCod As String

    Private Sub FrmDuplicar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Dim datos As Object = ""


            Dim DE As New Expertis.Engine.BE.DataEngine
            Dim dt As New DataTable
            dt = DE.Filter("sxexpertis50r2.dbo.xdatabase", "BaseDatos,DescBaseDatos", "")
            'ExpertisApp.GenerateMessage("El dt tiene " & dt.Rows.Count() & " Filas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            cboBBDD1.DataSource = dt
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub

    Function Insertar()
        Dim sSQL As String
        'Dim sSQLSelect As String
        'Dim sSQLWhere As String
        Dim sCampos As String
        Dim strCategoria As String
        Dim dt As New DataTable
        Dim i As Integer
        'Dim deOperario As DataEngine
        Dim clsOperario As New Business.General.Operario

        Try
            Dim Filtro As New Filter
            Filtro.Add("IdOperario", FilterOperator.Equal, txtOperario.Text)
            dt = clsOperario.Filter(Filtro)

            'Recogemos la estructura
            'sSQL = "Select * from tbMaestroOperario where idoperario = '" & txtOperario.Text & "'"
            'sSQLSelect = "*"
            'sSQLWhere = " idoperario='" & txtOperario.Text & "'"



            'rs.Open(sSQL, fwnAplicacion.GetConnectionString, , )
            'dt = AdminData.GetData(sSQL)
            'dt = deOperario.Filter("tbMaestroOperario", "*", sSQLWhere)
            'ExpertisApp.GenerateMessage("El dt tiene " & dt.Rows.Count() & " Filas", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            'rs.Open(sSQL)
            For Each dr As DataRow In dt.Rows
                dr("IDOperario") = txtNuevoCodigo
                Dim dtnew As DataTable
                dtnew.Rows.Add(dr)


            Next

            '    strCategoria = Nz(dr("IDCategoria").value, "")
            '    'strCategoria = Nz(dt("IDCategoria"), "")
            '    'ExpertisApp.GenerateMessage(strCategoria)

            '    'Rellenamos todos los campos menos el primero que es el propio operario (el nuevo)

            '    sCampos = "'" & txtNuevoCodigo.Text & "'"

            '    For i = 1 To dt.Columns.Count - 1

            '        If dt.Columns(i).Caption = "IDCategoria" Or dt.Columns(i).Caption = "IDOficio" Or dt.Columns(i).Caption = "IDDepartamento" Or dt.Columns(i).Caption = "IDBancoPropio" Then
            '            sCampos = sCampos & ", null as " & Nz(dt.Columns(i).Caption)
            '        Else
            '            sCampos = sCampos & ", " & Nz(dt.Columns(i).Caption)
            '        End If
            '    Next
            'Next

            ''Inserto el nuevo operario
            'sSQL = "insert into " & cboBBDD1.Text & ".dbo.tbMaestroOperario " & _
            '       "select " & sCampos & " from tbMaestroOperario where idoperario = '" & txtOperario.Text & "'"

            'AdminData.Execute(sSQL)
            ''Modifico algunos valores del nuevo operario
            'sSQL = "Update " & cboBBDD1.Text & ".dbo.tbMaestroOperario " & _
            '       "set FechaCreacionAudi ='" & Now() & "', " & _
            '       "FechaModificacionAudi ='" & Now() & "', " & _
            '       "Obra_Predeterminada=null, Todas_Obras=0 " & _
            '       "where IdOperario = '" & txtNuevoCodigo.Text & "'"
            ''fwnAplicacion.Ejecutar(sSQL)
            'AdminData.Execute(sSQL)

            ''Modifico de forma independiente la categoría
            'sSQL = "Update " & cboBBDD1.Text & ".dbo.tbMaestroOperario " & _
            '       "set IDCategoria ='" & strCategoria & "' , NOperarioOrden = '" & ("000000000000000" & txtNuevoCodigo.Text) & "'" & _
            '       "where IdOperario = '" & txtNuevoCodigo.Text & "'"

            ''fwnAplicacion.Ejecutar(sSQL)

            'AdminData.Execute(sSQL)
            'MessageBox.Show("Usuario insertado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            'MsgBox("Usuario insertado correctamente", vbInformation + vbOKOnly)

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        Finally
            dt = Nothing
        End Try

    End Function

    Function ComprobarDatos() As Boolean
        ComprobarDatos = True

        If txtOperario.Text = "" Then
            MessageBox.Show("No hay ningun operario seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtOperario.Focus()
            ComprobarDatos = False
            Exit Function
        End If

        If txtNuevoCodigo.Text = "" Then
            MessageBox.Show("Debes introducir un Codigo", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNuevoCodigo.Focus()
            ComprobarDatos = False
            Exit Function
        End If

        If cboBBDD1.Text = "" Then
            MessageBox.Show("DDebes seleccionar un destino", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'MsgBox("Debes seleccionar un destino", vbInformation + vbOKOnly)
            cboBBDD1.Focus()
            ComprobarDatos = False
            Exit Function
        End If
    End Function

    Private Sub cmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'If ComprobarDatos() = False Then
        '    Exit Sub
        'End If

        'Insertar()
        nuevoCod = txtNuevoCodigo.Text

        Me.Close()
    End Sub
    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


End Class