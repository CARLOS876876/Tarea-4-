Public Class Form1




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ObjSoap As New AppSoap_Crud.Service
        Dim Respuesta As String
        Respuesta = ObjSoap.FnRegistrarAlumno(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text,
                            Me.TextBox4.Text, Me.TextBox5.Text, Me.TextBox6.Text, Me.TextBox7.Text, Me.TextBox8.Text)
        MessageBox.Show(Respuesta)
        CargarDatos()

        Me.TextBox1.Clear()
        Me.TextBox2.Clear()
        Me.TextBox3.Clear()
        Me.TextBox4.Clear()
        Me.TextBox5.Clear()
        Me.TextBox6.Clear()
        Me.TextBox7.Clear()
        Me.TextBox8.Clear()
    End Sub

    Private Sub CargarDatos()
        Dim ObjSoap As New AppSoap_Crud.Service
        Dim Dsx As New DataSet

        Dsx = ObjSoap.FnVerAlumno
        Me.DGVAlumnoS.DataSource = Dsx.Tables("Estudiantes")
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ObjSoap As New AppSoap_Crud.Service
        Dim Respuesta As String
        Respuesta = ObjSoap.FnEliminarAlumno(Me.TextBox1.Text)
        MessageBox.Show(Respuesta)
        CargarDatos()

        Me.TextBox1.Clear()

    End Sub

    
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub
End Class
