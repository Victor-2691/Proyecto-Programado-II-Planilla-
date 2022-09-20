Imports System.Xml
Public Class ArchivosXML

    Public Sub GuardarXml(ByVal ArchivoXML As XmlDocument, ByVal RutaArchivo As String)
        'Solo guarda el archivo XML 
        Try
            ArchivoXML.Save(RutaArchivo)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function LeerXML(ByVal RutaArchivo As String)
        Dim ArchivoXML = New XmlDocument
        'Solo hace la carga en memoria del XML
        Try
            ArchivoXML.Load(RutaArchivo)
        Catch ex As Exception
            Throw ex
        End Try
        Return ArchivoXML
    End Function


End Class
