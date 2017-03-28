Public Class Insert

    Public Shared Function UpdateAssistantship(ByVal StuID As String, ByVal Status As String, ByVal appStat As String) As Integer
        Dim _DBConnector As New DBConnector()
        Dim ds As New Integer
        Dim query As String

        Try
            query = "UPDATE Application
                     SET AssistantshipStatus = '" & Status & "', AppStatus = '" & appStat & "'
                     WHERE StudentID = " & StuID & ";"
            ds = _DBConnector.ExecuteNonQuery(query)
        Catch err As Exception
            MessageBox.Show(err.Message)
        Finally
            MsgBox("Assistantship Status Successfully Updated.", MsgBoxStyle.Information, "")
        End Try
        Return ds
    End Function


    Public Shared Function UpdateAppRev(ByVal ComScore As String, ByVal GenNote As String, ByVal RecAs As String, ByVal IntNote As String, ByVal IntScore As String, ByVal AppID As String, ByVal UserID As String) As Integer
        Dim _DBConnector As New DBConnector()
        Dim ds As New Integer
        Dim query As String

        Try
            query = "UPDATE AppReview
                    SET CommitteeScore = " & ComScore & ",
	                    GeneralNotes = '" & GenNote & "',
	                    RecAssistantship = '" & RecAs & "',
	                    InterviewNotes = '" & IntNote & "',
	                    InterviewScore = " & IntScore & " 
                WHERE ApplicationID = " & AppID & "  AND UserID = " & UserID & ";"
            ds = _DBConnector.ExecuteNonQuery(query)
        Catch err As Exception
            MessageBox.Show(err.Message)
        Finally
            MsgBox("Successfully Updated.", MsgBoxStyle.Information, "")
        End Try
        Return ds
    End Function


End Class