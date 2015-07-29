Imports System
Imports System.Xml

Public Class form_TimeTable
    Dim strGrid(5, 5) As String

    Private Sub form_TimeTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim document As XmlReader = New XmlTextReader("TimeTable.xml")
        'Reads TimeTable.xml
        While (document.Read())
            Dim type = document.NodeType
            If (type = XmlNodeType.Element) Then
                If (document.Name = "Lesson00") Then
                    strGrid(0, 0) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson10") Then
                    strGrid(0, 1) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson20") Then
                    strGrid(0, 2) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson30") Then
                    strGrid(0, 3) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson40") Then
                    strGrid(0, 4) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson50") Then
                    strGrid(0, 5) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson01") Then
                    strGrid(1, 0) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson11") Then
                    strGrid(1, 1) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson21") Then
                    strGrid(1, 2) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson31") Then
                    strGrid(1, 3) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson41") Then
                    strGrid(1, 4) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson51") Then
                    strGrid(1, 5) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson02") Then
                    strGrid(2, 0) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson12") Then
                    strGrid(2, 1) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson22") Then
                    strGrid(2, 2) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson32") Then
                    strGrid(2, 3) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson42") Then
                    strGrid(2, 4) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson52") Then
                    strGrid(2, 5) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson03") Then
                    strGrid(3, 0) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson13") Then
                    strGrid(3, 1) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson23") Then
                    strGrid(3, 2) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson33") Then
                    strGrid(3, 3) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson43") Then
                    strGrid(3, 4) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson53") Then
                    strGrid(3, 5) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson04") Then
                    strGrid(4, 0) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson14") Then
                    strGrid(4, 1) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson24") Then
                    strGrid(4, 2) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson34") Then
                    strGrid(4, 3) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson44") Then
                    strGrid(4, 4) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson54") Then
                    strGrid(4, 5) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson05") Then
                    strGrid(5, 0) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson15") Then
                    strGrid(5, 1) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson25") Then
                    strGrid(5, 2) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson35") Then
                    strGrid(5, 3) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson45") Then
                    strGrid(5, 4) = document.ReadInnerXml.ToString()
                End If
                If (document.Name = "Lesson55") Then
                    strGrid(5, 5) = document.ReadInnerXml.ToString()
                End If
            End If
        End While
        'Closes Settings.xml once it has read all the settings so that it can be edited when you save new settings
        document.Close()

        Dim row As String()
        Dim row_Height As DataGridViewRow
        row = New String() {strGrid(0, 0), strGrid(0, 1), strGrid(0, 2), strGrid(0, 3), strGrid(0, 4), strGrid(0, 5)}
        DataGridView1.Rows.Add(row)
        row_Height = DataGridView1.Rows(0)
        row_Height.Height = 60
        row = New String() {strGrid(1, 0), strGrid(1, 1), strGrid(1, 2), strGrid(1, 3), strGrid(1, 4), strGrid(1, 5)}
        DataGridView1.Rows.Add(row)
        row_Height = DataGridView1.Rows(1)
        row_Height.Height = 60
        row = New String() {strGrid(2, 0), strGrid(2, 1), strGrid(2, 2), strGrid(2, 3), strGrid(2, 4), strGrid(2, 5)}
        DataGridView1.Rows.Add(row)
        row_Height = DataGridView1.Rows(2)
        row_Height.Height = 60
        row = New String() {strGrid(3, 0), strGrid(3, 1), strGrid(3, 2), strGrid(3, 3), strGrid(3, 4), strGrid(3, 5)}
        DataGridView1.Rows.Add(row)
        row_Height = DataGridView1.Rows(3)
        row_Height.Height = 60
        row = New String() {strGrid(4, 0), strGrid(4, 1), strGrid(4, 2), strGrid(4, 3), strGrid(4, 4), strGrid(4, 5)}
        DataGridView1.Rows.Add(row)
        row_Height = DataGridView1.Rows(4)
        row_Height.Height = 60
        row = New String() {strGrid(5, 0), strGrid(5, 1), strGrid(5, 2), strGrid(5, 3), strGrid(5, 4), strGrid(5, 5)}
        DataGridView1.Rows.Add(row)
        row_Height = DataGridView1.Rows(5)
        row_Height.Height = 60
    End Sub



    Private Sub checkbox_Math_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkbox_Math.CheckedChanged
        Dim intA, intB As Integer
        intA = 0
        intB = 0
        If checkbox_Math.Checked = True Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "Math" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.SkyBlue
                    End If
                Next intA
            Next intB
        ElseIf checkbox_Math.Checked = False Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "Math" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.White
                    End If
                Next intA
            Next intB
        End If
    End Sub

    Private Sub checkbox_Physics_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkbox_Physics.CheckedChanged
        Dim intA, intB As Integer
        intA = 0
        intB = 0
        If checkbox_Physics.Checked = True Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "Physics" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.Orchid
                    End If
                Next intA
            Next intB
        ElseIf checkbox_Physics.Checked = False Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "Physics" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.White
                    End If
                Next intA
            Next intB
        End If
    End Sub

    Private Sub checkbox_Software_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkbox_Software.CheckedChanged
        Dim intA, intB As Integer
        intA = 0
        intB = 0
        If checkbox_Software.Checked = True Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "Software" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.Khaki
                    End If
                Next intA
            Next intB
        ElseIf checkbox_Software.Checked = False Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "Software" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.White
                    End If
                Next intA
            Next intB
        End If
    End Sub

    Private Sub checkbox_English_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkbox_English.CheckedChanged
        Dim intA, intB As Integer
        intA = 0
        intB = 0
        If checkbox_English.Checked = True Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "English" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.Thistle
                    End If
                Next intA
            Next intB
        ElseIf checkbox_English.Checked = False Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "English" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.White
                    End If
                Next intA
            Next intB
        End If
    End Sub

    Private Sub checkbox_ITM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkbox_ITM.CheckedChanged
        Dim intA, intB As Integer
        intA = 0
        intB = 0
        If checkbox_ITM.Checked = True Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "ITM" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.IndianRed
                    End If
                Next intA
            Next intB
        ElseIf checkbox_ITM.Checked = False Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "ITM" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.White
                    End If
                Next intA
            Next intB
        End If
    End Sub

    Private Sub checkbox_ReligionTutorial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkbox_ReligionTutorial.CheckedChanged
        Dim intA, intB As Integer
        intA = 0
        intB = 0
        If checkbox_ReligionTutorial.Checked = True Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "Religion" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.Peru
                    ElseIf strGrid(intB, intA) = "Tutorial" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.Peru
                    End If
                Next intA
            Next intB
        ElseIf checkbox_ReligionTutorial.Checked = False Then
            For intB = 0 To 5
                For intA = 0 To 5
                    If strGrid(intB, intA) = "Religion" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.White
                    ElseIf strGrid(intB, intA) = "Tutorial" Then
                        DataGridView1.Item(intA, intB).Style.BackColor = Color.White
                    End If
                Next intA
            Next intB
        End If
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        If IO.File.Exists("TimeTable.xml") = True Then
            Dim settings As New XmlWriterSettings()
            settings.Indent = True

            Dim XmlWrt As XmlWriter = XmlWriter.Create("TimeTable.xml", settings)
            Dim intA, intB As Integer
            Dim Lesson As String
            With XmlWrt
                .WriteStartDocument()
                .WriteComment("XML")
                .WriteStartElement("Data")
                .WriteStartElement("Lesson00")
                .WriteString("Period 1")
                .WriteEndElement()
                .WriteStartElement("Lesson01")
                .WriteString("Period 2")
                .WriteEndElement()
                .WriteStartElement("Lesson02")
                .WriteString("Period 3")
                .WriteEndElement()
                .WriteStartElement("Lesson03")
                .WriteString("Period 4")
                .WriteEndElement()
                .WriteStartElement("Lesson04")
                .WriteString("Period 5")
                .WriteEndElement()
                .WriteStartElement("Lesson05")
                .WriteString("Period 6")
                .WriteEndElement()
                intA = 1
                intB = 0
                Dim strInput As String
                For intA = 1 To 5
                    For intB = 0 To 5
                        strInput = InputBox("Day:" & intA & "Period" & intB + 1)
                        Lesson = "Lesson" & intA & intB
                        .WriteStartElement(Lesson)
                        .WriteString(strInput)
                        .WriteEndElement()
                        intB = intB + 1 - 1
                    Next intB
                Next intA
            End With
            XmlWrt.Close()
        End If
    End Sub
End Class
