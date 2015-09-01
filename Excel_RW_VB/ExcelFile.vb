Imports Microsoft.Office.Interop.Excel
Imports System.IO

Public Class ExcelFile
    Private ruta As String = String.Empty
    Private indice As String = String.Empty
    Dim misValue As Object = System.Reflection.Missing.Value

    Public Property RutaDelArchivo() As String
        Get
            Return ruta
        End Get
        Set(ByVal value As String)
            'If value.Contains("xlsx") Then
            '    ruta = value
            'End If
        End Set
    End Property

    Public Sub New(ByVal ruta As String)
        MyBase.New()
        Me.ruta = ruta
    End Sub

    Public Function Guardar(ByVal hoja As Integer, ByVal celda As String, ByVal valor As String) As Boolean
        If ruta = String.Empty Then
            Console.WriteLine("Ruta vacía...")
            Return False
        Else
            Dim oExcel As Object = CreateObject("Excel.Application")
            Dim oBook As Object = oExcel.Workbooks.Open(ruta)
            Dim oSheet As Object = oBook.Worksheets(hoja)
            oSheet.Range(celda).Value = valor
            'oBook.SaveAs(ruta, True)
            oBook.Save()
            oExcel.Quit()
            Return True
        End If
    End Function

    Public Function Leer(ByVal celda As String, ByVal hoja As Integer) As String
        Dim valor As String = String.Empty
        If ruta = String.Empty Then
            Console.WriteLine("Ruta vacía...")
            Return String.Empty
        Else
            Try
                Dim oExcel As Object = CreateObject("Excel.Application")
                Dim oBook As Object = oExcel.Workbooks.Open(ruta)
                Dim oSheet As Object = oBook.Worksheets(hoja)
                valor = oSheet.Range(celda).Value
                If valor = String.Empty Then
                    System.Diagnostics.Debug.WriteLine(String.Empty)
                End If
                'oBook.SaveAs(ruta, True)
                'oBook.SaveAs(ruta, oExcel.XlFileFormat.xlWorkbookNormal,
                'misValue, misValue, misValue, misValue,
                'oExcel.XlSaveAsAccessMode.xlExclusive, misValue,
                'misValue, misValue, misValue, misValue)
                oBook.Save()
                oExcel.Quit()
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("Ha ocurrido el siguiente error: " + ex.Message)
            End Try
        End If
        Return valor
    End Function

    Public Function BuscarCeldaVacia(ByVal columnas As Integer, ByVal filas As Integer, ByVal recorrerVertical As Boolean, ByVal hoja As Integer) As String
        Dim celda As String = String.Empty
        celda = "NULL"
        Dim alphabet() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "0", "P",
                                    "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        If recorrerVertical Then
            For index = 0 To columnas
                For i = 1 To filas
                    'Preguntar si la celda esta vacía
                    Dim valor As String = Leer(alphabet(index) + i.ToString(), hoja)
                    If String.IsNullOrEmpty(valor) Then
                        Return alphabet(index) + i.ToString()
                    End If
                Next
            Next
        Else
            For index = 1 To filas
                For i = 0 To columnas
                    'Preguntar si la celda esta vacía
                    Dim valor As String = Leer(alphabet(i) + index.ToString(), hoja)
                    If String.IsNullOrEmpty(valor) Then
                        Return alphabet(i) + index.ToString()
                    End If
                Next
            Next
        End If
        Return celda
    End Function

    Public Function GuardarUltimaCelda(ByVal celda As String, ByVal path As String) As Boolean
        Dim _writer As StreamWriter
        Dim nombreArchivo As String = String.Empty
        nombreArchivo = "data.txt"
        Try
            _writer = File.CreateText(path + nombreArchivo)
            _writer.Write(celda)
            _writer.Close()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Se prdujo el siguiente error: " + ex.Message)
        End Try
        Return True
    End Function
End Class