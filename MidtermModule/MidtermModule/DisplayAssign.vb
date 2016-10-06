Module DisplayAssign

    Sub OutputName(ByVal phoneName As Object, ByVal input As String)
        phoneName.Text += input
    End Sub

    Sub OutputDesc(ByVal phoneDesc As Object, ByVal input As String)
        phoneDesc.Text += input
    End Sub

    Sub OutputNull(ByVal var As Object)
        var.Text = ""
    End Sub

    Sub AddDict(ByVal dict As Dictionary(Of String, String), ByVal key As String, ByVal value As String)
        dict.Add(key, value)
    End Sub

    Sub AddItem(ByVal list As ListBox, ByVal item As String)
        list.Items.Add(item)
    End Sub

End Module
