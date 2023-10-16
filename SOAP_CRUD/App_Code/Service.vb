Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports Soap_estudiantesTableAdapters
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function FnVerAlumno() As Soap_estudiantes

        Dim DsAlumno As New Soap_estudiantes
        Dim ObjAlumno As New EstudiantesTableAdapter
        ObjAlumno.Mostrar(DsAlumno.Estudiantes)
        Return DsAlumno
    End Function

    <WebMethod()> _
    Public Function FnRegistrarAlumno(ByVal Matricula As String, ByVal Nombre As String, ByVal Apellido1 As String, ByVal Apellido2 As String, ByVal Correo As String, ByVal Telefono As String, ByVal Edad As Integer, ByVal Genero As String) As String
        Dim ObjAlumno As New EstudiantesTableAdapter
        ObjAlumno.Insertar(Matricula, Nombre, Apellido1, Apellido2, Correo, Telefono, Genero, Edad)
        Return "Se ha Resgistrado un Alumno"

    End Function

    <WebMethod()> _
    Public Function FnEliminarAlumno(ByVal Matricula As String) As String
        Dim ObjAlumno As New EstudiantesTableAdapter
        ObjAlumno.Eliminar(Matricula)
        Return "Se ha eliminado un Alumno"
    End Function

End Class