Imports System.Windows.Forms.ErrorProvider

Public Class frmApplicationForm

    'Programmer: Joel Golden
    'Date: 2/18/08
    'Description: Application DB UI for the Walton Business College Masters Programs.

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Private Sub btnAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRecord.Click
    '    If Me.txtLastName.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtLastName, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtLastName, "")
    '    End If
    '    If Me.txtFirstName.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtFirstName, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtFirstName, "")
    '    End If
    '    If Not (txtStudentID.Text Like "#########") Then
    '        Me.ErrorProvider1.SetError(txtStudentID, "Student ID must be 9 numbers.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtStudentID, "")
    '    End If
    '    If Not (txtSSN.Text Like "###-##-####") Then
    '        Me.ErrorProvider1.SetError(txtSSN, "SSN must be in ###-###-#### format.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtSSN, "")
    '    End If
    '    If Me.txtBirthday1.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtBirthday1, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtBirthday1, "")
    '    End If
    '    If Me.cbxOrigin.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(cbxOrigin, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(cbxOrigin, "")
    '    End If
    '    If Me.txtSSN.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtSSN, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtSSN, "")
    '    End If
    '    If Me.cbxEthnic.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(cbxEthnic, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(cbxEthnic, "")
    '    End If
    '    If Me.cbxGender.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(cbxGender, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(cbxGender, "")
    '    End If
    '    If Me.cbxCitizenship.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(cbxCitizenship, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(cbxCitizenship, "")
    '    End If
    '    If Me.txtPAddress.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtPAddress, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtPAddress, "")
    '    End If
    '    If Me.txtPCity.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtPCity, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtPCity, "")
    '    End If
    '    If Me.cbxPState.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(cbxPState, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(cbxPState, "")
    '    End If
    '    If Not (txtPZipCode.Text Like "#####-####") Then
    '        Me.ErrorProvider1.SetError(txtPZipCode, "Zip Code must be in #####-#### format.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtPZipCode, "")
    '    End If
    '    If Me.txtLAddress.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtLAddress, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtLAddress, "")
    '    End If
    '    If Me.txtLCity.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtLCity, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtLCity, "")
    '    End If
    '    If Me.cbxLState.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(cbxLState, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(cbxLState, "")
    '    End If
    '    If Not (txtLZipCode.Text Like "#####-####") Then
    '        Me.ErrorProvider1.SetError(txtLZipCode, "Zip Code must be in #####-#### format.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtLZipCode, "")
    '    End If
    '    'If Me.txtCurrentPhone.Text.Length = 0 Then
    '    'Me.ErrorProvider1.SetError(txtCurrentPhone, "Field required.")
    '    'Else
    '    'Me.ErrorProvider1.SetError(txtCurrentPhone, "")
    '    'End If
    '    If Me.txtPPhone.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtPPhone, "Please enter a permanent phone number.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtPPhone, "")
    '    End If
    '    If Me.cbxPrimaryContactNumber.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(cbxPrimaryContactNumber, "Please select a primary contact number.")
    '    Else
    '        Me.ErrorProvider1.SetError(cbxPrimaryContactNumber, "")
    '    End If
    '    If Me.txtRequestYear.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtRequestYear, "Field required.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtRequestYear, "")
    '    End If
    '    If Me.txtGMATDate.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtGMATDate, "Please enter students GMAT date.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtGMATDate, "")
    '    End If
    '    If Me.txtGMATVerbal.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtGMATVerbal, "Please enter students Verbal GMAT Score.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtGMATVerbal, "")
    '    End If
    '    If Me.txtGMATTotal.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtGMATTotal, "Please enter students Total GMAT Score.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtGMATTotal, "")
    '    End If
    '    If Me.txtUnderGPA.Text.Length = 0 Then
    '        Me.ErrorProvider1.SetError(txtUnderGPA, "Please enter students Undergrad GPA.")
    '    Else
    '        Me.ErrorProvider1.SetError(txtUnderGPA, "")
    '    End If

    '    Insert.Insert_Personal()
    '    Insert.Insert_Address()
    '    Insert.Insert_Email()
    '    Insert.Insert_Phone()
    '    Insert.Insert_Student_Academic_Transcript()
    '    Insert.Insert_Student_Test_Score()
    '    Insert.Insert_Student_Admission_State()
    'End Sub

    Private Sub btnSearchRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim variable As String

        ControlClassForm.ValidateSearchFields()
        '        ControlClassSQL.GetSearchResults()

        Dim searchResults As DataSet

        If Me.txtLastName.Text.Length <> 0 And
                        Me.txtLastName.Text.Length <> 0 And
                        Me.Text.Length <> 0 And
                        Me.Text.Length <> 0 And
                        Me.Text.Length <> 0 Then

            searchResults = ControlClassSQL.GetSearchResults()

            frmSearchResults.dgSearchResults.DataBindings.Clear()
            frmSearchResults.dgSearchResults.DataSource = searchResults.Tables(0).DefaultView()
            frmSearchResults.Show()

            'Use row autosizing to show all the text
            frmSearchResults.dgSearchResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells

            ' Initialize DataGridView Columns
            frmSearchResults.dgSearchResults.RowHeadersVisible = False
            For Each col As DataGridViewColumn In frmSearchResults.dgSearchResults.Columns
                If col.GetType Is GetType(DataGridViewTextBoxColumn) Then
                    For Each row As DataGridViewRow In frmSearchResults.dgSearchResults.Rows
                        If row.IsNewRow Then Continue For
                        row.Height = row.Cells("LastName").ContentBounds.Height + 6
                    Next
                End If
            Next

        End If

    End Sub

    Private Sub btnEditRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRecord.Click

        'Call EditText function
        ControlClassForm.UnlockFields()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Clear all text boxes used for search function
        ControlClassForm.ClearSearchFields()
        ControlClassForm.UnlockFields()

    End Sub


    'Private Sub btnSaveChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChanges.Click

    '    'Call function to save changes to record to DB.

    '    Insert.Update_Personal()
    '    Insert.Update_Address()
    '    Insert.Update_Email()
    '    Insert.Update_Phone()
    '    Insert.Update_Student_Academic_Transcript()
    '    Insert.Update_Student_Test_Score()
    '    Insert.Update_Student_Admission_State()

    'End Sub

    Private Sub btnDeleteRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Insert.Delete_Student_Admission_State()
        Insert.Delete_Student_Academic_Transcript()
        Insert.Delete_Student_Test_Score()
        Insert.Delete_Phone()
        Insert.Delete_Email()
        Insert.Delete_Address()
        Insert.Delete_Personal()
        ControlClassForm.ClearSearchFields()
    End Sub

    Private Sub EditToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem1.Click
        'Call EditText function
        ControlClassForm.UnlockFields()
    End Sub

    Private Sub frmApplicationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AllStudents As DataSet
        AllStudents = ControlClassSQL.GetAllStudents()

        AllStudentsDataGridView.DataBindings.Clear()
        AllStudentsDataGridView.DataSource = AllStudents.Tables(0).DefaultView()
    End Sub

    Private Sub AllStudentsDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles AllStudentsDataGridView.SelectionChanged
        Dim studentRecord As DataSet
        Dim address As DataSet
        Dim variable As String

        If (AllStudentsDataGridView.SelectedRows.Count() > 0) Then

            variable = ControlClassSQL.getSelected(AllStudentsDataGridView)
            studentRecord = ControlClassSQL.GetStudentRecord(variable)

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
            lblStudentName.Text = txtLastName.Text & ", " & txtFirstName.Text
            lblStudentID.Text = txtStudentID.Text

            'Student Email DataBindings
            txtEmail.DataBindings.Clear()
            txtEmail.DataBindings.Add("Text", studentRecord.Tables(0), "Email")

            address = ControlClassSQL.GetStudentAddress(variable)

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

            'txtFAddress.DataBindings.Clear()
            'txtFAddress.DataBindings.Add("Text", studentRecord.Tables(0), "PREVIOUS_ADDRESS")
            'txtFCity.DataBindings.Clear()
            'txtFCity.DataBindings.Add("Text", studentRecord.Tables(0), "PREVIOUS_CITY")
            'cbxFState.DataBindings.Clear()
            'cbxFState.DataBindings.Add("Text", studentRecord.Tables(0), "PREVIOUS_STATE")
            'txtFZipCode.DataBindings.Clear()
            'txtFZipCode.DataBindings.Add("Text", studentRecord.Tables(0), "PERVIOUS_ZIP_CODE")
            'txtPYears.DataBindings.Clear()
            'txtPYears.DataBindings.Add("Text", studentRecord.Tables(0), "YEARS_PERM")
            'chkResident.DataBindings.Clear()
            'chkResident.DataBindings.Add("Checked", studentRecord.Tables(0), "RESIDENT")
            'txtLAddress.DataBindings.Clear()
            'txtLAddress.DataBindings.Add("Text", studentRecord.Tables(0), "MAILING_ADDRESS")
            'txtLCity.DataBindings.Clear()
            'txtLCity.DataBindings.Add("Text", studentRecord.Tables(0), "MAILING_CITY")
            'cbxLState.DataBindings.Clear()
            'cbxLState.DataBindings.Add("Text", studentRecord.Tables(0), "MAILING_STATE")
            'txtLZipCode.DataBindings.Clear()
            'txtLZipCode.DataBindings.Add("Text", studentRecord.Tables(0), "MAILING_ZIP_CODE")
            'txtFYears.DataBindings.Clear()
            'txtFYears.DataBindings.Add("Text", studentRecord.Tables(0), "YEARS_PREVIOUS")

            'Student Phone DataBindings
            txtCurrentPhone.DataBindings.Clear()
            txtCurrentPhone.DataBindings.Add("Text", studentRecord.Tables(0), "CellPhone")
            txtWorkPhone.DataBindings.Clear()
            txtWorkPhone.DataBindings.Add("Text", studentRecord.Tables(0), "WorkPhone")
            txtPPhone.DataBindings.Clear()
            txtPPhone.DataBindings.Add("Text", studentRecord.Tables(0), "HomePhone")
            cbxPrimaryContactNumber.DataBindings.Clear()
            cbxPrimaryContactNumber.DataBindings.Add("Text", studentRecord.Tables(0), "PreferredType")

            'Student Test Score DataBindings
            ' CHANGE EVERYTHING HERE...

            'txtGMATDate.DataBindings.Clear()
            'txtGMATDate.DataBindings.Add("Text", studentRecord.Tables(0), "GMATDATE")
            'txtGMATVerbal.DataBindings.Clear()
            'txtGMATVerbal.DataBindings.Add("Text", studentRecord.Tables(0), "GMATVERBAL")
            'txtGMATQuant.DataBindings.Clear()
            'txtGMATQuant.DataBindings.Add("Text", studentRecord.Tables(0), "GMATQUANT")
            'txtGMATTotal.DataBindings.Clear()
            'txtGMATTotal.DataBindings.Add("Text", studentRecord.Tables(0), "GMATTOTAL")
            'txtTOEFLDate.DataBindings.Clear()
            'txtTOEFLDate.DataBindings.Add("Text", studentRecord.Tables(0), "TOEFLDATE")
            'txtTOEFLTotal.DataBindings.Clear()
            'txtTOEFLTotal.DataBindings.Add("Text", studentRecord.Tables(0), "TOEFLTOTAL")
            'txtTSEDate.DataBindings.Clear()
            'txtTSEDate.DataBindings.Add("Text", studentRecord.Tables(0), "TSEDATE")
            'txtTSETotal.DataBindings.Clear()
            'txtTSETotal.DataBindings.Add("Text", studentRecord.Tables(0), "TSETOTAL")

            'Student Academic Transcript DataBindings
            'txtUnderGPA.DataBindings.Clear()
            'txtUnderGPA.DataBindings.Add("Text", studentRecord.Tables(0), "GPA")
            'txtGPASenior.DataBindings.Clear()
            'txtGPASenior.DataBindings.Add("Text", studentRecord.Tables(0), "GPA_SENIOR")
            'txtCName1.DataBindings.Clear()
            'txtCName1.DataBindings.Add("Text", studentRecord.Tables(0), "SchoolName")
            'txtCTo1.DataBindings.Clear()
            'txtCTo1.DataBindings.Add("Text", studentRecord.Tables(0), "AttendedTo")
            'txtCFrom1.DataBindings.Clear()
            'txtCFrom1.DataBindings.Add("Text", studentRecord.Tables(0), "AttendedFrom")
            'txtHoursEarned1.DataBindings.Clear()
            'txtHoursEarned1.DataBindings.Add("Text", studentRecord.Tables(0), "HOURS_EARNED_1")
            'txtCGPA1.DataBindings.Clear()
            'txtCGPA1.DataBindings.Add("Text", studentRecord.Tables(0), "COLLEGE_GPA_1")
            'txtDegree1.DataBindings.Clear()
            'txtDegree1.DataBindings.Add("Text", studentRecord.Tables(0), "Degree")
            'txtMajor1.DataBindings.Clear()
            'txtMajor1.DataBindings.Add("Text", studentRecord.Tables(0), "Major")
            'txtDegreeDate1.DataBindings.Clear()
            'txtDegreeDate1.DataBindings.Add("Text", studentRecord.Tables(0), "DegreeDate")
            ' ADD THIS SHIT..
            ' Country
            ' City
            ' State
            ' Classification
            ' InProgress
            ' Transcript

            'txtCurrentHours1.DataBindings.Clear()
            'txtCurrentHours1.DataBindings.Add("Text", studentRecord.Tables(0), "CURRENT_HOURS_1")
            'txtCName2.DataBindings.Clear()
            'txtCName2.DataBindings.Add("Text", studentRecord.Tables(0), "COLLEGE_NAME_2")
            'txtCTo2.DataBindings.Clear()
            'txtCTo2.DataBindings.Add("Text", studentRecord.Tables(0), "DATE_TO_2")
            'txtCFrom2.DataBindings.Clear()
            'txtCFrom2.DataBindings.Add("Text", studentRecord.Tables(0), "DATE_FROM_2")
            'txtHoursEarned2.DataBindings.Clear()
            'txtHoursEarned2.DataBindings.Add("Text", studentRecord.Tables(0), "HOURS_EARNED_2")
            'txtCGPA2.DataBindings.Clear()
            'txtCGPA2.DataBindings.Add("Text", studentRecord.Tables(0), "COLLEGE_GPA_2")
            'txtDegree2.DataBindings.Clear()
            'txtDegree2.DataBindings.Add("Text", studentRecord.Tables(0), "DEGREE_NAME_2")
            'txtMajor2.DataBindings.Clear()
            'txtMajor2.DataBindings.Add("Text", studentRecord.Tables(0), "MAJOR_2")
            'txtDegreeDate2.DataBindings.Clear()
            'txtDegreeDate2.DataBindings.Add("Text", studentRecord.Tables(0), "DEGREE_DATE_2")
            'txtCurrentHours2.DataBindings.Clear()
            'txtCurrentHours2.DataBindings.Add("Text", studentRecord.Tables(0), "CURRENT_HOURS_2")

            'Student Admission State
            'txtRequestYear.DataBindings.Clear()
            'txtRequestYear.DataBindings.Add("Text", studentRecord.Tables(0), "ApplicationYear")
            'cbxSession.DataBindings.Clear()
            'cbxSession.DataBindings.Add("Text", studentRecord.Tables(0), "ApplicationSemester")
            'chkBefore.DataBindings.Clear()
            'chkBefore.DataBindings.Add("Checked", studentRecord.Tables(0), "PrevApp")
            'txtBefore_when.DataBindings.Clear()
            'txtBefore_when.DataBindings.Add("Text", studentRecord.Tables(0), "PrevAppTerm")
            'chkEnrolled.DataBindings.Clear()
            'chkEnrolled.DataBindings.Add("Checked", studentRecord.Tables(0), "PrevEnrol")
            'txtEnrolled_When.DataBindings.Clear()
            'txtEnrolled_When.DataBindings.Add("Text", studentRecord.Tables(0), "PrevEnrolTerm")
            'cbxStanding.DataBindings.Clear()
            'cbxStanding.DataBindings.Add("Text", studentRecord.Tables(0), "PrevStatus")
            ' ADD THIS SHIT
            ' ProgramType
            ' Major
            ' Concentration.
            ' UndergradDegree
            ' ReferralSource
            ' Current
            'chkRequested.DataBindings.Clear()
            'chkRequested.DataBindings.Add("Checked", studentRecord.Tables(0), "AssistantshipStatus")
            'chkAppFeePaid.DataBindings.Clear()
            'chkAppFeePaid.DataBindings.Add("Checked", studentRecord.Tables(0), "APPLICATION_FEE")
            'chkResume.DataBindings.Clear()
            'chkResume.DataBindings.Add("Checked", studentRecord.Tables(0), "Resume") 'Fix this
            'chkEssay.DataBindings.Clear()
            'chkEssay.DataBindings.Add("Checked", studentRecord.Tables(0), "PersonalStatement")
            ''chkAppForm.DataBindings.Clear()
            ''chkAppForm.DataBindings.Add("Checked", studentRecord.Tables(0), "APPLICATION")
            'chkLOR.DataBindings.Clear()
            'chkLOR.DataBindings.Add("Checked", studentRecord.Tables(0), "LOR")
            'chkTranscript.DataBindings.Clear()
            'chkTranscript.DataBindings.Add("Checked", studentRecord.Tables(0), "TRANSCRIPT")
            'chkEducation.DataBindings.Clear()
            'chkEducation.DataBindings.Add("Checked", studentRecord.Tables(0), "EDUCATION")
            'chkFinancial.DataBindings.Clear()
            'chkFinancial.DataBindings.Add("Checked", studentRecord.Tables(0), "FINANCIAL")
            'chkTOEFL.DataBindings.Clear()
            'chkTOEFL.DataBindings.Add("Checked", studentRecord.Tables(0), "TOEFL")
            'chkTSE.DataBindings.Clear()
            'chkTSE.DataBindings.Add("Checked", studentRecord.Tables(0), "TSE")
            'chkGMATScore.DataBindings.Clear()
            'chkGMATScore.DataBindings.Add("Checked", studentRecord.Tables(0), "GMAT_SCORE")
            'chkGREScore.DataBindings.Clear()
            'chkGREScore.DataBindings.Add("Checked", studentRecord.Tables(0), "GRE_SCORE")
            'txtStatus.DataBindings.Clear()
            'txtStatus.DataBindings.Add("Text", studentRecord.Tables(0), "AppStatus")
            'txtDateApplied.DataBindings.Clear()
            'txtDateApplied.DataBindings.Add("Text", studentRecord.Tables(0), "AppStatusDate")
            'txtAStatus.DataBindings.Clear()
            'txtAStatus.DataBindings.Add("Text", studentRecord.Tables(0), "AssistantshipStatus")
            'txtFeePaid.DataBindings.Clear()
            'txtFeePaid.DataBindings.Add("Text", studentRecord.Tables(0), "FEE_PAID")
            'txtSEnrolled.DataBindings.Clear()
            'txtSEnrolled.DataBindings.Add("Text", studentRecord.Tables(0), "Enrolled")
            'txtDEnrolled.DataBindings.Clear()
            'txtDEnrolled.DataBindings.Add("Text", studentRecord.Tables(0), "EnrolledDate")
            'txtDeclined.DataBindings.Clear()
            'txtDeclined.DataBindings.Add("Text", studentRecord.Tables(0), "OFFER_DECLINED")
            'txtDDate.DataBindings.Clear()
            'txtDDate.DataBindings.Add("Text", studentRecord.Tables(0), "DATE_DECLINED")
            'txtAcceptedOffer.DataBindings.Clear()
            'txtAcceptedOffer.DataBindings.Add("Text", studentRecord.Tables(0), "ACCEPTED_OFFER")
            'txtDateAccepted.DataBindings.Clear()
            'txtDateAccepted.DataBindings.Add("Text", studentRecord.Tables(0), "DATE_ACCEPTED")
            'txtNotes.DataBindings.Clear()
            'txtNotes.DataBindings.Add("Text", studentRecord.Tables(0), "NOTES")

            'Set all fields to read only.
            ControlClassForm.LockFields()
        End If

        'Clear search fields if a record without a student id is selected.
        If txtStudentID.Text.Length = 0 Then
            ControlClassForm.ClearSearchFields()
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
End Class




'dgGrades.DataBindings.Clear() 
'        dgGrades.Columns.Clear() 
'        dgGrades.AutoGenerateColumns = False 
'        dgGrades.DataSource = studentGrades.Tables(0) 

'Dim colClass As New DataGridViewColumn
'        dgGrades.Columns.Add("Class", "Class") 
'        dgGrades.Columns("Class").DataPropertyName = "Class"