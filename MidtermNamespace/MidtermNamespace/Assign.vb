Namespace Assign

    Public Class Store

        Shared Sub AddDict(ByVal dict As Dictionary(Of String, String), ByVal key As String, ByVal value As String)
            dict.Add(key, value)
        End Sub

        Shared Sub AddItem(ByVal list As ListBox, ByVal item As String)
            list.Items.Add(item)
        End Sub

    End Class

End Namespace