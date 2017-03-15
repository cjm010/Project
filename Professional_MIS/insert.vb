Public Class Insert

    Public Shared Function Update_Student_Admission_State() As DataSet
        Dim _DBConnector As New DBConnector()
        Dim ds As New DataSet
        Dim query As String

        Try
            'query = "UPDATE STUDENT_ADMISSION_STATE SET REQUEST_YEAR = '" & Professional_MIS.frmApplicationForm.txtRequestYear.Text & "', YEAR_TERM = '" & Professional_MIS.frmApplicationForm.cbxSession.Text & "', APPLIED_BEFORE = '" & Professional_MIS.frmApplicationForm.chkBefore.Checked.ToString & "', DATE_BEFORE = '" & Professional_MIS.frmApplicationForm.txtBefore_when.Text & "', ENROLLED = '" & Professional_MIS.frmApplicationForm.chkEnrolled.Checked.ToString & "', ENROLLED_DATE = '" & Professional_MIS.frmApplicationForm.txtEnrolled_When.Text & "', STUDENT_STANDING = '" & Professional_MIS.frmApplicationForm.cbxStanding.Text & "', ASSISTANTSHIP_REQUESTED = '" & Professional_MIS.frmApplicationForm.chkRequested.Checked.ToString & "', APPLICATION_FEE = '" & Professional_MIS.frmApplicationForm.chkAppFeePaid.Checked.ToString & "', STUDENT_RESUME = '" & Professional_MIS.frmApplicationForm.chkResume.Checked.ToString & "', ESSAY = '" & Professional_MIS.frmApplicationForm.chkEssay.Checked.ToString & "', APPLICATION = '" & Professional_MIS.frmApplicationForm.chkAppForm.Checked.ToString & "', LOR = '" & Professional_MIS.frmApplicationForm.chkLOR.Checked.ToString & "', TRANSCRIPT = '" & Professional_MIS.frmApplicationForm.chkTranscript.Checked.ToString & "', EDUCATION = '" & Professional_MIS.frmApplicationForm.chkEducation.Checked.ToString & "', FINANCIAL = '" & Professional_MIS.frmApplicationForm.chkFinancial.Checked.ToString & "', TOEFL = '" & Professional_MIS.frmApplicationForm.chkTOEFL.Checked.ToString & "', TSE = '" & Professional_MIS.frmApplicationForm.chkTSE.Checked.ToString & "', GMAT_SCORE = '" & Professional_MIS.frmApplicationForm.chkGMATScore.Checked.ToString & "', GRE_SCORE = '" & Professional_MIS.frmApplicationForm.chkGREScore.Checked & "', STATUS = '" & Professional_MIS.frmApplicationForm.txtStatus.Text & "', DATE_APPLIED = '" & Professional_MIS.frmApplicationForm.txtDateApplied.Text & "', ASSISTANTSHIP_STATUS = '" & Professional_MIS.frmApplicationForm.txtAStatus.Text & "', FEE_PAID = '" & Professional_MIS.frmApplicationForm.txtFeePaid.Text & "', STUDENT_ENROLLED = '" & Professional_MIS.frmApplicationForm.txtSEnrolled.Text & "', DATE_ENROLLED = '" & Professional_MIS.frmApplicationForm.txtDEnrolled.Text & "', OFFER_DECLINED = '" & Professional_MIS.frmApplicationForm.txtDeclined.Text & "', DATE_DECLINED = '" & Professional_MIS.frmApplicationForm.txtDDate.Text & "', ACCEPTED_OFFER = '" & Professional_MIS.frmApplicationForm.txtAcceptedOffer.Text & "', DATE_ACCEPTED = '" & Professional_MIS.frmApplicationForm.txtDateAccepted.Text & "', NOTES = '" & Professional_MIS.frmApplicationForm.txtNotes.Text & "' WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
            ' ds = _DBConnector.GetDataSet(query)
        Catch err As Exception
            MessageBox.Show(err.Message)
        Finally
            MsgBox("Student information updated completed sucessfully.", MsgBoxStyle.Information, "")
        End Try
        Return ds
    End Function

    Public Shared Function Delete_Personal() As DataSet
        Dim _DBConnector As New DBConnector()
        Dim ds As New DataSet
        Dim query As String

        Try
            query = "DELETE FROM STUDENT WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
            ds = _DBConnector.GetDataSet(query)
        Catch err As Exception
            MessageBox.Show(err.Message)
        Finally
            MsgBox("Student information deleted completed sucessfully.", MsgBoxStyle.Information, "")
        End Try
        Return ds
    End Function
    Public Shared Function Delete_Address() As DataSet
        Dim _DBConnector As New DBConnector()
        Dim ds As New DataSet
        Dim query As String

        Try
            query = "DELETE FROM STUDENT_ADDRESS WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
            ds = _DBConnector.GetDataSet(query)
        Catch err As Exception
            MessageBox.Show(err.Message)
        Finally
            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
        End Try
        Return ds
    End Function
    Public Shared Function Delete_Phone() As DataSet
        Dim _DBConnector As New DBConnector()
        Dim ds As New DataSet
        Dim query As String

        Try
            query = "DELETE FROM STUDENT_PHONE WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
            ds = _DBConnector.GetDataSet(query)
        Catch err As Exception
            MessageBox.Show(err.Message)
        Finally
            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
        End Try
        Return ds
    End Function
    Public Shared Function Delete_Email() As DataSet
        Dim _DBConnector As New DBConnector()
        Dim ds As New DataSet
        Dim query As String

        Try
            query = "DELETE FROM STUDENT_EMAIL WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
            ds = _DBConnector.GetDataSet(query)
        Catch err As Exception
            MessageBox.Show(err.Message)
        Finally
            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
        End Try
        Return ds
    End Function
    Public Shared Function Delete_Student_Test_Score() As DataSet
        Dim _DBConnector As New DBConnector()
        Dim ds As New DataSet
        Dim query As String

        Try
            query = "DELETE FROM STUDENT_TEST_SCORE WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
            ds = _DBConnector.GetDataSet(query)
        Catch err As Exception
            MessageBox.Show(err.Message)
        Finally
            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
        End Try
        Return ds
    End Function
    Public Shared Function Delete_Student_Academic_Transcript() As DataSet
        Dim _DBConnector As New DBConnector()
        Dim ds As New DataSet
        Dim query As String

        Try
            query = "DELETE FROM STUDENT_ADADEMIC_TRANSCRIPT WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
            ds = _DBConnector.GetDataSet(query)
        Catch err As Exception
            MessageBox.Show(err.Message)
        Finally
            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
        End Try
        Return ds
    End Function
    Public Shared Function Delete_Student_Admission_State() As DataSet
        Dim _DBConnector As New DBConnector()
        Dim ds As New DataSet
        Dim query As String

        Try
            query = "DELETE FROM STUDENT_ADMISSION_STATE WHERE STUDENT_ID = " & Professional_MIS.frmApplicationForm.txtStudentID.Text & ""
            ds = _DBConnector.GetDataSet(query)
        Catch err As Exception
            MessageBox.Show(err.Message)
        Finally
            'MsgBox("Student Information deleted completed sucessfully.", MsgBoxStyle.Information, "")
        End Try
        Return ds
    End Function
End Class