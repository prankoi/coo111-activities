Namespace Display

    Public Class Output

        Shared Sub OutputName(ByVal phoneName As Object, ByVal input As String)
            phoneName.Text += input
        End Sub

        Shared Sub OutputDesc(ByVal phoneDesc As Object, ByVal input As String)
            phoneDesc.Text += input
        End Sub

        Shared Sub OutputNull(ByVal var As Object)
            var.Text = ""
        End Sub

    End Class

End Namespace
