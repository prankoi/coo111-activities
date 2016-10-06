Class MainWindow 
    Dim phones As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Dim ctr As Integer = 1

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnFind.Click

        OutputNull(phoneName)
        OutputNull(phoneDesc)

        Dim phoneID As String = modelBox.Text

        If phones.ContainsKey(phoneID) Then
            OutputName(phoneName, phoneID)
            OutputDesc(phoneDesc, phones.Item(phoneID))
        Else
            OutputDesc(phoneDesc, "Item not found.")
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnAdd.Click

        Dim phoneID As String
        Dim phoneSpecs As String

        phoneID = phoneName.Text
        phoneSpecs = phoneDesc.Text

        AddDict(phones, phoneID, phoneSpecs)

        phoneList.Items.Add(phoneID)

    End Sub

    Private Sub btnUpd_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnUpd.Click

        If phones.ContainsKey(phoneName.Text) Then
            phones(phoneName.Text) = phoneDesc.Text
        End If

    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles btnDel.Click

        Dim phoneID As String = phoneName.Text

        If phones.ContainsKey(phoneID) Then
            phones.Remove(phoneID)
            OutputNull(phoneName)
            OutputNull(phoneDesc)
            OutputDesc(phoneDesc, "Item removed.")
        Else
            OutputDesc(phoneDesc, "Item not found.")
        End If

        phoneList.Items.Remove(phoneID)

    End Sub





    Private Sub phoneList_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles phoneList.SelectionChanged

        If phoneList.SelectedIndex <> -1 Then
            If phoneList.SelectedItem.ToString <> "" Then
                If phones.ContainsKey(phoneList.SelectedItem.ToString) Then
                    OutputNull(phoneName)
                    OutputNull(phoneDesc)
                    OutputName(phoneName, phoneList.SelectedItem.ToString)
                    OutputDesc(phoneDesc, phones.Item(phoneList.SelectedItem.ToString))
                End If
            End If
        End If

    End Sub

    Private Sub phoneList_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles phoneList.Loaded

        If ctr = 1 Then

            Dim phoneID1, phoneID2, phoneID3, phoneID4, phoneID5 As String
            Dim phoneSpecs1, phoneSpecs2, phoneSpecs3, phoneSpecs4, phoneSpecs5 As String

            phoneID1 = "Samsung Galaxy S"
            phoneID2 = "Samsung Galaxy S2"
            phoneID3 = "Samsung Galaxy S3"
            phoneID4 = "Samsung Galaxy S4"
            phoneID5 = "Samsung Galaxy S5"

            phoneSpecs1 = "Display: 4.0-inch Super AMOLED (WVGA)" + vbCrLf + vbCrLf +
                          "Camera: 5MP (rear) - 0.3MP (front)" + vbCrLf + vbCrLf +
                          "Chipset: Exynos 3110/MSM8255T" + vbCrLf + vbCrLf +
                          "CPU: 1.0 GHz single-core ARM Cortex-A8/1.4 Ghz single-core Scorpion" + vbCrLf + vbCrLf +
                          "GPU: PowerVR SGX540/Adreno 205" + vbCrLf + vbCrLf +
                          "Memory: 8GB ROM - 512MB RAM" + vbCrLf + vbCrLf +
                          "OS: Android 2.3 (Gingerbread)"

            phoneSpecs2 = "Display: 4.3-inch Super AMOLED (HD)" + vbCrLf + vbCrLf +
                          "Camera: 8MP (rear) - 2MP (front)" + vbCrLf + vbCrLf +
                          "Chipset: Exynos 4210/MSM8260" + vbCrLf + vbCrLf +
                          "CPU: 1.2 GHz dual-core ARM Cortex-A9" + vbCrLf + vbCrLf +
                          "GPU: MALI400 MP4/Adreno 220" + vbCrLf + vbCrLf +
                          "Memory: 16GB ROM - 1GB RAM" + vbCrLf + vbCrLf +
                          "OS: Android 4.2.2 (Jelly Bean)"

            phoneSpecs3 = "Display: 4.8-inch Super AMOLED (HD)" + vbCrLf + vbCrLf +
                          "Camera: 8MP (rear) - 1.9MP (front)" + vbCrLf + vbCrLf +
                          "Chipset: Exynos 4412/MSM8228" + vbCrLf + vbCrLf +
                          "CPU: 1.4 GHz quad-core ARM Cortex-A9/1.4 Ghz quad-core Cortex-A7" + vbCrLf + vbCrLf +
                          "GPU: ARM MALI400 MP4/Adreno 305" + vbCrLf + vbCrLf +
                          "Memory: 16GB ROM - 2GB RAM" + vbCrLf + vbCrLf +
                          "OS: Android 4.4.2 (Kit-Kat)"

            phoneSpecs4 = "Display: 5.0-inch Super AMOLED (FHD)" + vbCrLf + vbCrLf +
                          "Camera: 13MP (rear) - 2MP (front)" + vbCrLf + vbCrLf +
                          "Chipset: Exynos 5410/APQ8064T" + vbCrLf + vbCrLf +
                          "CPU: 1.6 GHz - 1.2 GHz big.LITTLE/1.9 Ghz quad-core Krait 300" + vbCrLf + vbCrLf +
                          "GPU: PowerVR SGX544 MP3/Adreno 320" + vbCrLf + vbCrLf +
                          "Memory: 64GB ROM - 2GB RAM" + vbCrLf + vbCrLf +
                          "OS: Android 5.0.1 (Lollipop)"

            phoneSpecs5 = "Display: 5.1-inch Super AMOLED (QHD)" + vbCrLf + vbCrLf +
                          "Camera: 16MP (rear) - 2MP (front)" + vbCrLf + vbCrLf +
                          "Chipset: Exynos 5422/APQ8084" + vbCrLf + vbCrLf +
                          "CPU: 1.9 GHz - 1.3 GHz big.LITTLE/2.5 Ghz quad-core Krait 400" + vbCrLf + vbCrLf +
                          "GPU: MALI T628 MP6/Adreno 420" + vbCrLf + vbCrLf +
                          "Memory: 32GB ROM - 3GB RAM" + vbCrLf + vbCrLf +
                          "OS: Android 6.0.1 (Marshmallow)"


            AddDict(phones, phoneID1, phoneSpecs1)
            AddDict(phones, phoneID2, phoneSpecs2)
            AddDict(phones, phoneID3, phoneSpecs3)
            AddDict(phones, phoneID4, phoneSpecs4)
            AddDict(phones, phoneID5, phoneSpecs5)

            AddItem(phoneList, phoneID1)
            AddItem(phoneList, phoneID2)
            AddItem(phoneList, phoneID3)
            AddItem(phoneList, phoneID4)
            AddItem(phoneList, phoneID5)

            ctr = ctr + 1

        End If

    End Sub

End Class
