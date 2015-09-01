Imports Excel_RW_VB.ExcelFile

Public Class FrmTesting
    Dim excel As ExcelFile
    Dim ruta As String = String.Empty
    Dim path As String = String.Empty

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        OpenFileDialog1.ShowDialog()
        ruta = OpenFileDialog1.FileName
        txtruta.Text = ruta
        excel = New ExcelFile(ruta)
        path = ruta.Substring(0, (ruta.Length - OpenFileDialog1.SafeFileName.Length))
    End Sub

    Private Sub btnleer_Click(sender As Object, e As EventArgs) Handles btnleer.Click
        If ruta = String.Empty Then
            MsgBox("Cargue un archivo primero")
            Return
        Else
            If String.IsNullOrEmpty(txtcelda.Text) Then
                Return
            Else
                Dim valor As String = excel.Leer(txtcelda.Text, 1)
                MsgBox(valor)
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ruta = String.Empty Then
            Return
        Else
            If String.IsNullOrEmpty(txtvalor.Text) Then
                Return
            Else
                excel.Guardar(1, "A2", txtvalor.Text)
            End If
        End If
        excel.GuardarUltimaCelda(lblCeldaPos.Text, path)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.Text = excel.BuscarCeldaVacia(10, 10, False, 1)
    End Sub
End Class