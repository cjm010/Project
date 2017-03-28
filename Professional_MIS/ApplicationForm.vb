Imports System.Windows.Forms.ErrorProvider

Public Class frmApplicationForm
    Dim studentID As String
    Dim appID As String

    Private Sub frmApplicationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ControlClassSQL.UserRole = "Program Director" Then
            SaveAStatusButton.Enabled = True
            txtAStatus.Enabled = True
            txtStatus.Enabled = True
        End If
        Dim AllStudents As DataSet
        AllStudents = ControlClassSQL.GetAllStudents()
        AllStudentsDataGridView.DataBindings.Clear()
        AllStudentsDataGridView.DataSource = AllStudents.Tables(0).DefaultView()
        AllStudentsDataGridView.Columns.Item(0).Visible = False
    End Sub

    Private Sub frmApplicationForm_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        LoginForm.Close()
    End Sub


    Private Sub AllStudentsDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles AllStudentsDataGridView.SelectionChanged
        Dim studentRecord As DataSet
        Dim address As DataSet
        Dim education As DataSet
        Dim review As DataSet
        Dim Scores As DataSet

        If (AllStudentsDataGridView.SelectedRows.Count() > 0) Then


            studentID = ControlClassSQL.getSelected(AllStudentsDataGridView)
            appID = ControlClassSQL.getSelectedAppID(AllStudentsDataGridView)
            studentRecord = ControlClassSQL.GetStudentRecord(studentID)

            Scores = ControlClassSQL.GetStudentScores(studentID)

            DataGridViewScores.DataBindings.Clear()
            DataGridViewScores.DataSource = Scores.Tables(0).DefaultView()

            education = ControlClassSQL.GetEducation(studentID)

            DataGridViewEducation.DataBindings.Clear()
            DataGridViewEducation.DataSource = education.Tables(0).DefaultView()

            review = ControlClassSQL.GetAppReview(studentID)


            ' Populate the Form with the record matching the matching the selected Student ID
            txtStudentID.DataBindings.Clear()
            txtStudentID.DataBindings.Add("Text", studentRecord.Tables(0), "StudentID")
            txtLastName.DataBindings.Clear()
            txtLastName.DataBindings.Add("Text", studentRecord.Tables(0), "LastName")
            txtFirstName.DataBindings.Clear()
            txtFirstName.DataBindings.Add("Text", studentRecord.Tables(0), "FirstName")
            txtMiddleName.DataBindings.Clear()
            txtMiddleName.DataBindings.Add("Text", studentRecord.Tables(0), "MiddleName")
            txtSSN.DataBindings.Clear()
            txtSSN.DataBindings.Add("Text", studentRecord.Tables(0), "SSN")
            txtBirthday1.DataBindings.Clear()
            txtBirthday1.DataBindings.Add("Text", studentRecord.Tables(0), "DOB")
            cbxOrigin.DataBindings.Clear()
            cbxOrigin.DataBindings.Add("Text", studentRecord.Tables(0), "Origin")
            cbxEthnic.DataBindings.Clear()
            cbxEthnic.DataBindings.Add("Text", studentRecord.Tables(0), "Ethnicity")
            cbxGender.DataBindings.Clear()
            cbxGender.DataBindings.Add("Text", studentRecord.Tables(0), "Gender")
            cbxCitizenship.DataBindings.Clear()
            cbxCitizenship.DataBindings.Add("Text", studentRecord.Tables(0), "Citizenship")

            'Student Email DataBindings
            txtEmail.DataBindings.Clear()
            txtEmail.DataBindings.Add("Text", studentRecord.Tables(0), "Email")


            address = ControlClassSQL.GetStudentAddress(studentID)

            'Student Address DataBindings
            txtPAddress.DataBindings.Clear()
            txtPAddress.DataBindings.Add("Text", address.Tables(0), "Address1")
            txtPCity.DataBindings.Clear()
            txtPCity.DataBindings.Add("Text", address.Tables(0), "City")
            cbxPState.DataBindings.Clear()
            cbxPState.DataBindings.Add("Text", address.Tables(0), "StateProvince")
            txtPZipCode.DataBindings.Clear()
            txtPZipCode.DataBindings.Add("Text", address.Tables(0), "ZipCode")
            IsMailingCheckBox.DataBindings.Clear()
            IsMailingCheckBox.DataBindings.Add("Checked", address.Tables(0), "Mailing")


            'Student Phone DataBindings
            txtCurrentPhone.DataBindings.Clear()
            txtCurrentPhone.DataBindings.Add("Text", studentRecord.Tables(0), "CellPhone")
            txtWorkPhone.DataBindings.Clear()
            txtWorkPhone.DataBindings.Add("Text", studentRecord.Tables(0), "WorkPhone")
            txtPPhone.DataBindings.Clear()
            txtPPhone.DataBindings.Add("Text", studentRecord.Tables(0), "HomePhone")
            cbxPrimaryContactNumber.DataBindings.Clear()
            cbxPrimaryContactNumber.DataBindings.Add("Text", studentRecord.Tables(0), "PreferredType")


            'Student Admission State
            txtRequestYear.DataBindings.Clear()
            txtRequestYear.DataBindings.Add("Text", studentRecord.Tables(0), "ApplicationYear")
            cbxSession.DataBindings.Clear()
            cbxSession.DataBindings.Add("SelectedItem", studentRecord.Tables(0), "ApplicationSemester")
            chkBefore.DataBindings.Clear()
            chkBefore.DataBindings.Add("Checked", studentRecord.Tables(0), "PrevApp")
            If studentRecord.Tables(0).Select("PrevApp").ToString = "1" Then
                txtBefore_when.DataBindings.Clear()
                txtBefore_when.DataBindings.Add("Text", studentRecord.Tables(0), "PrevAppTerm")
                chkEnrolled.DataBindings.Clear()
                chkEnrolled.DataBindings.Add("Checked", studentRecord.Tables(0), "PrevEnrol")
                If studentRecord.Tables(0).Select("PrevEnrol").ToString = "1" Then
                    cbxStanding.DataBindings.Clear()
                    cbxStanding.DataBindings.Add("Text", studentRecord.Tables(0), "PrevStatus")
                    txtEnrolled_When.DataBindings.Clear()
                    txtEnrolled_When.DataBindings.Add("Text", studentRecord.Tables(0), "PrevEnrolTerm")
                End If
            End If



            chkResume.DataBindings.Clear()
            chkResume.DataBindings.Add("Checked", studentRecord.Tables(0), "HasResume")
            chkEssay.DataBindings.Clear()
            chkEssay.DataBindings.Add("Checked", studentRecord.Tables(0), "HasStatement")
            'chkLOR.DataBindings.Clear()
            'chkLOR.DataBindings.Add("Checked", studentRecord.Tables(0), "LOR")
            'chkTranscript.DataBindings.Clear()
            'chkTranscript.DataBindings.Add("Checked", studentRecord.Tables(0), "TRANSCRIPT")
            'chkGMATScore.DataBindings.Clear()
            'chkGMATScore.DataBindings.Add("Checked", studentRecord.Tables(0), "GMAT_SCORE")

            'ONLY FOR INTERNATIONAL STUDENTS
            'chkEducation.DataBindings.Clear()
            'chkEducation.DataBindings.Add("Checked", studentRecord.Tables(0), "EDUCATION")
            'chkFinancial.DataBindings.Clear()
            'chkFinancial.DataBindings.Add("Checked", studentRecord.Tables(0), "FINANCIAL")
            'chkTOEFL.DataBindings.Clear()
            'chkTOEFL.DataBindings.Add("Checked", studentRecord.Tables(0), "TOEFL")
            'chkTSE.DataBindings.Clear()
            'chkTSE.DataBindings.Add("Checked", studentRecord.Tables(0), "TSE")


            txtStatus.DataBindings.Clear()
            txtStatus.DataBindings.Add("SelectedItem", studentRecord.Tables(0), "AppStatus")
            txtDateApplied.DataBindings.Clear()
            txtDateApplied.DataBindings.Add("Text", studentRecord.Tables(0), "AppStatusDate")
            txtAStatus.DataBindings.Clear()
            txtAStatus.DataBindings.Add("SelectedItem", studentRecord.Tables(0), "AssistantshipStatus")

            EnrolledCheckBox.DataBindings.Clear()
            EnrolledCheckBox.DataBindings.Add("Checked", studentRecord.Tables(0), "Enrolled")


            txtDEnrolled.DataBindings.Clear()
            txtDEnrolled.DataBindings.Add("Text", studentRecord.Tables(0), "EnrolledDate")
            txtDeclined.DataBindings.Clear()
            txtDeclined.DataBindings.Add("Text", studentRecord.Tables(0), "StudentDecision")
            txtDDate.DataBindings.Clear()
            txtDDate.DataBindings.Add("Text", studentRecord.Tables(0), "StudentDecisionDate")


            RecAComboBox.DataBindings.Clear()
            RecAComboBox.SelectedItem = " "
            RecAComboBox.DataBindings.Add("SelectedItem", review.Tables(0), "RecAssistantship")
            ComScoreDomainUpDown.DataBindings.Clear()
            ComScoreDomainUpDown.SelectedIndex = 0
            ComScoreDomainUpDown.DataBindings.Add("SelectedIndex", review.Tables(0), "CommitteeScore")
            IntvScoreDomainUpDown.DataBindings.Clear()
            IntvScoreDomainUpDown.SelectedIndex = 0
            IntvScoreDomainUpDown.DataBindings.Add("SelectedIndex", review.Tables(0), "InterviewScore")
            IntvNotesRichTextBox.DataBindings.Clear()
            IntvNotesRichTextBox.Clear()
            IntvNotesRichTextBox.DataBindings.Add("Text", review.Tables(0), "InterviewNotes")
            GenNotesRichTextBox.DataBindings.Clear()
            GenNotesRichTextBox.Clear()
            GenNotesRichTextBox.DataBindings.Add("Text", review.Tables(0), "GeneralNotes")


            'Set all fields to read only.
            ControlClassForm.LockFields()
        End If


        'Bring Focus to the form
        BringToFront()
        ' tabApplication.Focus()
        tabCredentials.Focus()
        tabStudentStatus.Select()

    End Sub

    Private Sub IsMailingCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IsMailingCheckBox.CheckedChanged
        If IsMailingCheckBox.Checked Then
            Label20.Visible = False
            Label19.Visible = False
            Label18.Visible = False
            Label17.Visible = False
            Label16.Visible = False
            txtLAddress.Visible = False
            txtLCity.Visible = False
            txtLZipCode.Visible = False
            cbxLState.Visible = False
        ElseIf IsMailingCheckBox.Checked.Equals(False) Then
            Label20.Visible = True
            Label19.Visible = True
            Label18.Visible = True
            Label17.Visible = True
            Label16.Visible = True
            txtLAddress.Visible = True
            txtLCity.Visible = True
            txtLZipCode.Visible = True
            cbxLState.Visible = True
        End If
    End Sub

    Private Sub SaveAStatusButton_Click(sender As Object, e As EventArgs) Handles SaveAStatusButton.Click
        Insert.UpdateAssistantship(studentID, txtAStatus.SelectedItem.ToString, txtStatus.SelectedItem.ToString)
        Dim AllStudents As DataSet
        AllStudents = ControlClassSQL.GetAllStudents()
        AllStudentsDataGridView.DataBindings.Clear()
        AllStudentsDataGridView.DataSource = AllStudents.Tables(0).DefaultView()
    End Sub

    Private Sub SaveAppRevButton_Click(sender As Object, e As EventArgs) Handles SaveAppRevButton.Click
        Insert.UpdateAppRev(ComScoreDomainUpDown.SelectedItem.ToString, GenNotesRichTextBox.Text, RecAComboBox.SelectedItem.ToString, IntvNotesRichTextBox.Text, IntvScoreDomainUpDown.SelectedItem.ToString, appID, ControlClassSQL.UserID.ToString)

        Dim review As DataSet
        review = ControlClassSQL.GetAppReview(studentID)
        RecAComboBox.DataBindings.Clear()
        RecAComboBox.DataBindings.Add("Text", review.Tables(0), "RecAssistantship")
        ComScoreDomainUpDown.DataBindings.Clear()
        ComScoreDomainUpDown.DataBindings.Add("Text", review.Tables(0), "CommitteeScore")
        IntvScoreDomainUpDown.DataBindings.Clear()
        IntvScoreDomainUpDown.DataBindings.Add("Text", review.Tables(0), "InterviewScore")
        IntvNotesRichTextBox.DataBindings.Clear()
        IntvNotesRichTextBox.DataBindings.Add("Text", review.Tables(0), "InterviewNotes")
        GenNotesRichTextBox.DataBindings.Clear()
        GenNotesRichTextBox.DataBindings.Add("Text", review.Tables(0), "GeneralNotes")
    End Sub

    Private Sub SaveAppStatButton_Click(sender As Object, e As EventArgs)

    End Sub
End Class