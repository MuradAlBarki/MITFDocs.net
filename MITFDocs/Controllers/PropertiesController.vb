Imports System.Web.Mvc

Namespace Controllers
    Public Class PropertiesController
        Inherits Controller

        ' GET: Properties
        Function Auth() As ActionResult
            Return View()
        End Function
    End Class
End Namespace