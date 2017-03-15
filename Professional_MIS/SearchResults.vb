
Public Class frmSearchResults

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub dgSearchResults_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSearchResults.CellClick
        Dim studentRecord As DataSet
        Dim variable As String

        If dgSearchResults.CurrentCell.ColumnIndex = 0 Then
            variable = dgSearchResults.CurrentCell.Value.ToString()
            frmApplicationForm.txtStudentID.Text = variable
            studentRecord = ControlClassSQL.GetStudentRecord(variable)

            ' ControlClassForm.ClearSearchFields()

            ' Populate the Form with the record matching the matching the selected Student ID
            frmApplicationForm.txtStudentID.DataBindings.Clear()
            frmApplicationForm.txtStudentID.DataBindings.Add("Text", studentRecord.Tables(0), "StudentID")
            frmApplicationForm.txtLastName.DataBindings.Clear()
            frmApplicationForm.txtLastName.DataBindings.Add("Text", studentRecord.Tables(0), "LastName")
            frmApplicationForm.txtFirstName.DataBindings.Clear()
            frmApplicationForm.txtFirstName.DataBindings.Add("Text", studentRecord.Tables(0), "FirstName")
            frmApplicationForm.txtMiddleName.DataBindings.Clear()
            frmApplicationForm.txtMiddleName.DataBindings.Add("Text", studentRecord.Tables(0), "MiddleName")
            frmApplicationForm.txtSSN.DataBindings.Clear()
            frmApplicationForm.txtSSN.DataBindings.Add("Text", studentRecord.Tables(0), "SSN")
            frmApplicationForm.txtBirthday1.DataBindings.Clear()
            frmApplicationForm.txtBirthday1.DataBindings.Add("Text", studentRecord.Tables(0), "DOB")
            frmApplicationForm.cbxOrigin.DataBindings.Clear()
            frmApplicationForm.cbxOrigin.DataBindings.Add("Text", studentRecord.Tables(0), "Origin")
            frmApplicationForm.cbxEthnic.DataBindings.Clear()
            frmApplicationForm.cbxEthnic.DataBindings.Add("Text", studentRecord.Tables(0), "Ethnicity")
            frmApplicationForm.cbxGender.DataBindings.Clear()
            frmApplicationForm.cbxGender.DataBindings.Add("Text", studentRecord.Tables(0), "Gender")
            frmApplicationForm.cbxCitizenship.DataBindings.Clear()
            frmApplicationForm.cbxCitizenship.DataBindings.Add("Text", studentRecord.Tables(0), "Citizenship")
            frmApplicationForm.lblStudentName.Text = frmApplicationForm.txtLastName.Text & ", " & frmApplicationForm.txtFirstName.Text
            frmApplicationForm.lblStudentID.Text = frmApplicationForm.txtStudentID.Text

            'Student Address DataBindings
            frmApplicationForm.txtPAddress.DataBindings.Clear()
            frmApplicationForm.txtPAddress.DataBindings.Add("Text", studentRecord.Tables(0), "Address1")
            frmApplicationForm.txtPCity.DataBindings.Clear()
            frmApplicationForm.txtPCity.DataBindings.Add("Text", studentRecord.Tables(0), "City")
            frmApplicationForm.cbxPState.DataBindings.Clear()
            frmApplicationForm.cbxPState.DataBindings.Add("Text", studentRecord.Tables(0), "StateProvience")
            frmApplicationForm.txtPZipCode.DataBindings.Clear()
            frmApplicationForm.txtPZipCode.DataBindings.Add("Text", studentRecord.Tables(0), "ZipCode")
            ' NEED TO ADD THESE:
            ' COUNTRY
            ' Address2
            ' and other shit...

            'frmApplicationForm.txtFAddress.DataBindings.Clear()
            'frmApplicationForm.txtFAddress.DataBindings.Add("Text", studentRecord.Tables(0), "PREVIOUS_ADDRESS")
            'frmApplicationForm.txtFCity.DataBindings.Clear()
            'frmApplicationForm.txtFCity.DataBindings.Add("Text", studentRecord.Tables(0), "PREVIOUS_CITY")
            'frmApplicationForm.cbxFState.DataBindings.Clear()
            'frmApplicationForm.cbxFState.DataBindings.Add("Text", studentRecord.Tables(0), "PREVIOUS_STATE")
            'frmApplicationForm.txtFZipCode.DataBindings.Clear()
            'frmApplicationForm.txtFZipCode.DataBindings.Add("Text", studentRecord.Tables(0), "PERVIOUS_ZIP_CODE")
            'frmApplicationForm.txtPYears.DataBindings.Clear()
            'frmApplicationForm.txtPYears.DataBindings.Add("Text", studentRecord.Tables(0), "YEARS_PERM")
            'frmApplicationForm.chkResident.DataBindings.Clear()
            'frmApplicationForm.chkResident.DataBindings.Add("Checked", studentRecord.Tables(0), "RESIDENT")
            'frmApplicationForm.txtLAddress.DataBindings.Clear()
            'frmApplicationForm.txtLAddress.DataBindings.Add("Text", studentRecord.Tables(0), "MAILING_ADDRESS")
            'frmApplicationForm.txtLCity.DataBindings.Clear()
            'frmApplicationForm.txtLCity.DataBindings.Add("Text", studentRecord.Tables(0), "MAILING_CITY")
            'frmApplicationForm.cbxLState.DataBindings.Clear()
            'frmApplicationForm.cbxLState.DataBindings.Add("Text", studentRecord.Tables(0), "MAILING_STATE")
            'frmApplicationForm.txtLZipCode.DataBindings.Clear()
            'frmApplicationForm.txtLZipCode.DataBindings.Add("Text", studentRecord.Tables(0), "MAILING_ZIP_CODE")
            'frmApplicationForm.txtFYears.DataBindings.Clear()
            'frmApplicationForm.txtFYears.DataBindings.Add("Text", studentRecord.Tables(0), "YEARS_PREVIOUS")

            'Student Phone DataBindings
            frmApplicationForm.txtCurrentPhone.DataBindings.Clear()
            frmApplicationForm.txtCurrentPhone.DataBindings.Add("Text", studentRecord.Tables(0), "PhoneNumber")
            ' CHANGE A BUNCH OF SHIT HERE.

            'frmApplicationForm.txtWorkPhone.DataBindings.Clear()
            'frmApplicationForm.txtWorkPhone.DataBindings.Add("Text", studentRecord.Tables(0), "WORK_PHONE")
            'frmApplicationForm.txtPPhone.DataBindings.Clear()
            'frmApplicationForm.txtPPhone.DataBindings.Add("Text", studentRecord.Tables(0), "PERM_PHONE")
            'frmApplicationForm.cbxPrimaryContactNumber.DataBindings.Clear()
            'frmApplicationForm.cbxPrimaryContactNumber.DataBindings.Add("Text", studentRecord.Tables(0), "CONTACT")

            'Student Email DataBindings
            frmApplicationForm.txtEmail.DataBindings.Clear()
            frmApplicationForm.txtEmail.DataBindings.Add("Text", studentRecord.Tables(0), "Email")

            'Student Test Score DataBindings
            ' CHANGE EVERYTHING HERE...

            'frmApplicationForm.txtGMATDate.DataBindings.Clear()
            'frmApplicationForm.txtGMATDate.DataBindings.Add("Text", studentRecord.Tables(0), "GMATDATE")
            'frmApplicationForm.txtGMATVerbal.DataBindings.Clear()
            'frmApplicationForm.txtGMATVerbal.DataBindings.Add("Text", studentRecord.Tables(0), "GMATVERBAL")
            'frmApplicationForm.txtGMATQuant.DataBindings.Clear()
            'frmApplicationForm.txtGMATQuant.DataBindings.Add("Text", studentRecord.Tables(0), "GMATQUANT")
            'frmApplicationForm.txtGMATTotal.DataBindings.Clear()
            'frmApplicationForm.txtGMATTotal.DataBindings.Add("Text", studentRecord.Tables(0), "GMATTOTAL")
            'frmApplicationForm.txtTOEFLDate.DataBindings.Clear()
            'frmApplicationForm.txtTOEFLDate.DataBindings.Add("Text", studentRecord.Tables(0), "TOEFLDATE")
            'frmApplicationForm.txtTOEFLTotal.DataBindings.Clear()
            'frmApplicationForm.txtTOEFLTotal.DataBindings.Add("Text", studentRecord.Tables(0), "TOEFLTOTAL")
            'frmApplicationForm.txtTSEDate.DataBindings.Clear()
            'frmApplicationForm.txtTSEDate.DataBindings.Add("Text", studentRecord.Tables(0), "TSEDATE")
            'frmApplicationForm.txtTSETotal.DataBindings.Clear()
            'frmApplicationForm.txtTSETotal.DataBindings.Add("Text", studentRecord.Tables(0), "TSETOTAL")

            'Student Academic Transcript DataBindings
            frmApplicationForm.txtUnderGPA.DataBindings.Clear()
            frmApplicationForm.txtUnderGPA.DataBindings.Add("Text", studentRecord.Tables(0), "GPA")
            'frmApplicationForm.txtGPASenior.DataBindings.Clear()
            'frmApplicationForm.txtGPASenior.DataBindings.Add("Text", studentRecord.Tables(0), "GPA_SENIOR")
            frmApplicationForm.txtCName1.DataBindings.Clear()
            frmApplicationForm.txtCName1.DataBindings.Add("Text", studentRecord.Tables(0), "SchoolName")
            frmApplicationForm.txtCTo1.DataBindings.Clear()
            frmApplicationForm.txtCTo1.DataBindings.Add("Text", studentRecord.Tables(0), "AttendedTo")
            frmApplicationForm.txtCFrom1.DataBindings.Clear()
            frmApplicationForm.txtCFrom1.DataBindings.Add("Text", studentRecord.Tables(0), "AttendedFrom")
            'frmApplicationForm.txtHoursEarned1.DataBindings.Clear()
            'frmApplicationForm.txtHoursEarned1.DataBindings.Add("Text", studentRecord.Tables(0), "HOURS_EARNED_1")
            'frmApplicationForm.txtCGPA1.DataBindings.Clear()
            'frmApplicationForm.txtCGPA1.DataBindings.Add("Text", studentRecord.Tables(0), "COLLEGE_GPA_1")
            frmApplicationForm.txtDegree1.DataBindings.Clear()
            frmApplicationForm.txtDegree1.DataBindings.Add("Text", studentRecord.Tables(0), "Degree")
            frmApplicationForm.txtMajor1.DataBindings.Clear()
            frmApplicationForm.txtMajor1.DataBindings.Add("Text", studentRecord.Tables(0), "Major")
            frmApplicationForm.txtDegreeDate1.DataBindings.Clear()
            frmApplicationForm.txtDegreeDate1.DataBindings.Add("Text", studentRecord.Tables(0), "DegreeDate")
            ' ADD THIS SHIT..
            ' Country
            ' City
            ' State
            ' Classification
            ' InProgress
            ' Transcript

            'frmApplicationForm.txtCurrentHours1.DataBindings.Clear()
            'frmApplicationForm.txtCurrentHours1.DataBindings.Add("Text", studentRecord.Tables(0), "CURRENT_HOURS_1")
            'frmApplicationForm.txtCName2.DataBindings.Clear()
            'frmApplicationForm.txtCName2.DataBindings.Add("Text", studentRecord.Tables(0), "COLLEGE_NAME_2")
            'frmApplicationForm.txtCTo2.DataBindings.Clear()
            'frmApplicationForm.txtCTo2.DataBindings.Add("Text", studentRecord.Tables(0), "DATE_TO_2")
            'frmApplicationForm.txtCFrom2.DataBindings.Clear()
            'frmApplicationForm.txtCFrom2.DataBindings.Add("Text", studentRecord.Tables(0), "DATE_FROM_2")
            'frmApplicationForm.txtHoursEarned2.DataBindings.Clear()
            'frmApplicationForm.txtHoursEarned2.DataBindings.Add("Text", studentRecord.Tables(0), "HOURS_EARNED_2")
            'frmApplicationForm.txtCGPA2.DataBindings.Clear()
            'frmApplicationForm.txtCGPA2.DataBindings.Add("Text", studentRecord.Tables(0), "COLLEGE_GPA_2")
            'frmApplicationForm.txtDegree2.DataBindings.Clear()
            'frmApplicationForm.txtDegree2.DataBindings.Add("Text", studentRecord.Tables(0), "DEGREE_NAME_2")
            'frmApplicationForm.txtMajor2.DataBindings.Clear()
            'frmApplicationForm.txtMajor2.DataBindings.Add("Text", studentRecord.Tables(0), "MAJOR_2")
            'frmApplicationForm.txtDegreeDate2.DataBindings.Clear()
            'frmApplicationForm.txtDegreeDate2.DataBindings.Add("Text", studentRecord.Tables(0), "DEGREE_DATE_2")
            'frmApplicationForm.txtCurrentHours2.DataBindings.Clear()
            'frmApplicationForm.txtCurrentHours2.DataBindings.Add("Text", studentRecord.Tables(0), "CURRENT_HOURS_2")

            'Student Admission State
            frmApplicationForm.txtRequestYear.DataBindings.Clear()
            frmApplicationForm.txtRequestYear.DataBindings.Add("Text", studentRecord.Tables(0), "ApplicationTerm")
            frmApplicationForm.cbxSession.DataBindings.Clear()
            frmApplicationForm.cbxSession.DataBindings.Add("Text", studentRecord.Tables(0), "ApplicationTerm")
            frmApplicationForm.chkBefore.DataBindings.Clear()
            frmApplicationForm.chkBefore.DataBindings.Add("Checked", studentRecord.Tables(0), "PrevApp")
            frmApplicationForm.txtBefore_when.DataBindings.Clear()
            frmApplicationForm.txtBefore_when.DataBindings.Add("Text", studentRecord.Tables(0), "PrevAppTerm")
            frmApplicationForm.chkEnrolled.DataBindings.Clear()
            frmApplicationForm.chkEnrolled.DataBindings.Add("Checked", studentRecord.Tables(0), "PrevEnrol")
            frmApplicationForm.txtEnrolled_When.DataBindings.Clear()
            frmApplicationForm.txtEnrolled_When.DataBindings.Add("Text", studentRecord.Tables(0), "PrevEnrolTerm")
            frmApplicationForm.cbxStanding.DataBindings.Clear()
            frmApplicationForm.cbxStanding.DataBindings.Add("Text", studentRecord.Tables(0), "PrevStatus")
            ' ADD THIS SHIT
            ' ProgramType
            ' Major
            ' Concentration.
            ' UndergradDegree
            ' ReferralSource
            ' Current
            'frmApplicationForm.chkRequested.DataBindings.Clear()
            'frmApplicationForm.chkRequested.DataBindings.Add("Checked", studentRecord.Tables(0), "AssistantshipStatus")
            'frmApplicationForm.chkAppFeePaid.DataBindings.Clear()
            'frmApplicationForm.chkAppFeePaid.DataBindings.Add("Checked", studentRecord.Tables(0), "APPLICATION_FEE")
            'frmApplicationForm.chkResume.DataBindings.Clear()
            'frmApplicationForm.chkResume.DataBindings.Add("Checked", studentRecord.Tables(0), "Resume") 'Fix this
            'frmApplicationForm.chkEssay.DataBindings.Clear()
            'frmApplicationForm.chkEssay.DataBindings.Add("Checked", studentRecord.Tables(0), "PersonalStatement")
            ''frmApplicationForm.chkAppForm.DataBindings.Clear()
            ''frmApplicationForm.chkAppForm.DataBindings.Add("Checked", studentRecord.Tables(0), "APPLICATION")
            'frmApplicationForm.chkLOR.DataBindings.Clear()
            'frmApplicationForm.chkLOR.DataBindings.Add("Checked", studentRecord.Tables(0), "LOR")
            'frmApplicationForm.chkTranscript.DataBindings.Clear()
            'frmApplicationForm.chkTranscript.DataBindings.Add("Checked", studentRecord.Tables(0), "TRANSCRIPT")
            'frmApplicationForm.chkEducation.DataBindings.Clear()
            'frmApplicationForm.chkEducation.DataBindings.Add("Checked", studentRecord.Tables(0), "EDUCATION")
            'frmApplicationForm.chkFinancial.DataBindings.Clear()
            'frmApplicationForm.chkFinancial.DataBindings.Add("Checked", studentRecord.Tables(0), "FINANCIAL")
            'frmApplicationForm.chkTOEFL.DataBindings.Clear()
            'frmApplicationForm.chkTOEFL.DataBindings.Add("Checked", studentRecord.Tables(0), "TOEFL")
            'frmApplicationForm.chkTSE.DataBindings.Clear()
            'frmApplicationForm.chkTSE.DataBindings.Add("Checked", studentRecord.Tables(0), "TSE")
            'frmApplicationForm.chkGMATScore.DataBindings.Clear()
            'frmApplicationForm.chkGMATScore.DataBindings.Add("Checked", studentRecord.Tables(0), "GMAT_SCORE")
            'frmApplicationForm.chkGREScore.DataBindings.Clear()
            'frmApplicationForm.chkGREScore.DataBindings.Add("Checked", studentRecord.Tables(0), "GRE_SCORE")
            frmApplicationForm.txtStatus.DataBindings.Clear()
            frmApplicationForm.txtStatus.DataBindings.Add("Text", studentRecord.Tables(0), "AppStatus")
            frmApplicationForm.txtDateApplied.DataBindings.Clear()
            frmApplicationForm.txtDateApplied.DataBindings.Add("Text", studentRecord.Tables(0), "AppStatusDate")
            frmApplicationForm.txtAStatus.DataBindings.Clear()
            frmApplicationForm.txtAStatus.DataBindings.Add("Text", studentRecord.Tables(0), "AssistantshipStatus")
            'frmApplicationForm.txtFeePaid.DataBindings.Clear()
            'frmApplicationForm.txtFeePaid.DataBindings.Add("Text", studentRecord.Tables(0), "FEE_PAID")
            frmApplicationForm.txtSEnrolled.DataBindings.Clear()
            frmApplicationForm.txtSEnrolled.DataBindings.Add("Text", studentRecord.Tables(0), "Enrolled")
            frmApplicationForm.txtDEnrolled.DataBindings.Clear()
            frmApplicationForm.txtDEnrolled.DataBindings.Add("Text", studentRecord.Tables(0), "EnrolledDate")
            'frmApplicationForm.txtDeclined.DataBindings.Clear()
            'frmApplicationForm.txtDeclined.DataBindings.Add("Text", studentRecord.Tables(0), "OFFER_DECLINED")
            'frmApplicationForm.txtDDate.DataBindings.Clear()
            'frmApplicationForm.txtDDate.DataBindings.Add("Text", studentRecord.Tables(0), "DATE_DECLINED")
            'frmApplicationForm.txtAcceptedOffer.DataBindings.Clear()
            'frmApplicationForm.txtAcceptedOffer.DataBindings.Add("Text", studentRecord.Tables(0), "ACCEPTED_OFFER")
            'frmApplicationForm.txtDateAccepted.DataBindings.Clear()
            'frmApplicationForm.txtDateAccepted.DataBindings.Add("Text", studentRecord.Tables(0), "DATE_ACCEPTED")
            'frmApplicationForm.txtNotes.DataBindings.Clear()
            'frmApplicationForm.txtNotes.DataBindings.Add("Text", studentRecord.Tables(0), "NOTES")

            'Set all fields to read only.
            ControlClassForm.LockFields()

        End If

        'Clear search fields if a record without a student id is selected.
        If frmApplicationForm.txtStudentID.Text.Length = 0 Then
            ControlClassForm.ClearSearchFields()
        End If

        'Bring Focus to the form
        frmApplicationForm.BringToFront()
        ' frmApplicationForm.tabApplication.Focus()
        frmApplicationForm.tabCredentials.Focus()
        frmApplicationForm.tabStudentStatus.Select()

    End Sub

    Private Sub PrintToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        ' Calling DataGridView Printing
        ' PrintDGV.Print_DataGridView(dgSearchResults)
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, _
       ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _
       PrintDocument1.PrintPage
        Dim myPaintArgs As New PaintEventArgs(e.Graphics, New Rectangle(New _
           Point(0, 0), Me.Size))
        Me.InvokePaint(dgSearchResults, myPaintArgs)
    End Sub

    Private Sub dgSearchResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSearchResults.CellContentClick

    End Sub
End Class