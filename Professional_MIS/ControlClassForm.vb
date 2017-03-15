Public Class ControlClassForm

    'Programmer: sample
    'Date: 01/01/07
    'Description: Functions for all SQL query commands

    Public Shared Sub ClearSearchFields()

        'Student Personal

        frmApplicationForm.txtStudentID.Clear()
        frmApplicationForm.txtLastName.Clear()
        frmApplicationForm.txtFirstName.Clear()
        frmApplicationForm.txtMiddleName.Clear()
        'frmApplicationForm.txtPreferred.Clear()
        frmApplicationForm.txtSSN.Clear()
        frmApplicationForm.txtBirthday1.Clear()
        frmApplicationForm.cbxOrigin.ResetText()
        frmApplicationForm.cbxEthnic.ResetText()
        frmApplicationForm.cbxGender.ResetText()
        frmApplicationForm.cbxCitizenship.ResetText()

        'Student Address 
        frmApplicationForm.txtPAddress.Clear()
        frmApplicationForm.txtPCity.Clear()
        frmApplicationForm.cbxPState.ResetText()
        frmApplicationForm.txtPZipCode.Clear()
        frmApplicationForm.chkResident.Checked = False
        frmApplicationForm.txtLAddress.Clear()
        frmApplicationForm.txtLCity.Clear()
        frmApplicationForm.cbxLState.ResetText()
        frmApplicationForm.txtLZipCode.Clear()

        'Student Phone 
        frmApplicationForm.txtCurrentPhone.Clear()
        frmApplicationForm.txtWorkPhone.Clear()
        frmApplicationForm.txtPPhone.Clear()
        frmApplicationForm.cbxPrimaryContactNumber.ResetText()

        'Student Email 
        frmApplicationForm.txtEmail.Clear()

        'Student Test Score 
        frmApplicationForm.txtGMATDate.Clear()
        frmApplicationForm.txtGMATVerbal.Clear()
        frmApplicationForm.txtGMATQuant.Clear()
        frmApplicationForm.txtGMATTotal.Clear()
        frmApplicationForm.txtTOEFLDate.Clear()
        frmApplicationForm.txtTOEFLTotal.Clear()
        frmApplicationForm.txtTSEDate.Clear()
        frmApplicationForm.txtTSETotal.Clear()

        'Student Academic Transcript
        frmApplicationForm.txtUnderGPA.Clear()
        frmApplicationForm.txtCName1.Clear()
        frmApplicationForm.txtCTo1.Clear()
        frmApplicationForm.txtCFrom1.Clear()
        frmApplicationForm.txtDegree1.Clear()
        frmApplicationForm.txtMajor1.Clear()
        frmApplicationForm.txtDegreeDate1.Clear()
        frmApplicationForm.txtCName2.Clear()
        frmApplicationForm.txtCTo2.Clear()
        frmApplicationForm.txtCFrom2.Clear()
        frmApplicationForm.txtDegree2.Clear()
        frmApplicationForm.txtMajor2.Clear()
        frmApplicationForm.txtDegreeDate2.Clear()

        'Student Admission State
        frmApplicationForm.txtRequestYear.Clear()
        frmApplicationForm.cbxSession.ResetText()
        frmApplicationForm.chkBefore.Checked = False
        frmApplicationForm.txtBefore_when.Clear()
        frmApplicationForm.chkEnrolled.Checked = False
        frmApplicationForm.txtEnrolled_When.Clear()
        frmApplicationForm.cbxStanding.ResetText()
        frmApplicationForm.chkRequested.Checked = False
        frmApplicationForm.chkAppFeePaid.Checked = False
        frmApplicationForm.chkResume.Checked = False
        frmApplicationForm.chkEssay.Checked = False
        frmApplicationForm.chkAppForm.Checked = False
        frmApplicationForm.chkLOR.Checked = False
        frmApplicationForm.chkTranscript.Checked = False
        frmApplicationForm.chkEducation.Checked = False
        frmApplicationForm.chkFinancial.Checked = False
        frmApplicationForm.chkTOEFL.Checked = False
        frmApplicationForm.chkTSE.Checked = False
        frmApplicationForm.chkGMATScore.Checked = False
        frmApplicationForm.chkGREScore.Checked = False
        frmApplicationForm.txtStatus.Clear()
        frmApplicationForm.txtDateApplied.Clear()
        frmApplicationForm.txtAStatus.Clear()
        frmApplicationForm.txtSEnrolled.Clear()
        frmApplicationForm.txtDEnrolled.Clear()
        frmApplicationForm.txtDeclined.Clear()
        frmApplicationForm.txtDDate.Clear()
        frmApplicationForm.txtAcceptedOffer.Clear()
        frmApplicationForm.txtDateAccepted.Clear()
        frmApplicationForm.txtNotes.Clear()


    End Sub

    Public Shared Sub ValidateSearchFields()

        Try
            If frmApplicationForm.txtLastName.Text.Length = 0 And _
                frmApplicationForm.txtLastName.Text.Length = 0 And _
                frmApplicationForm.txtSSN.Text.Length = 0 And _
                frmApplicationForm.txtStudentID.Text.Length = 0 And _
                frmApplicationForm.txtEmail.Text.Length = 0 Then

                Throw New Exception()

            Else
                Try
                    If frmApplicationForm.txtLastName.Text.Length = 0 Then
                        frmApplicationForm.txtLastName.Text = "a"
                    Else
                    End If
                Catch ex As Exception

                End Try

                Try
                    If frmApplicationForm.txtFirstName.Text.Length = 0 Then
                        frmApplicationForm.txtFirstName.Text = "a"
                    Else
                    End If
                Catch ex As Exception

                End Try

                Try
                    If frmApplicationForm.txtSSN.Text.Length = 0 Then
                        frmApplicationForm.txtSSN.Text = "1"
                    Else
                    End If
                Catch ex As Exception

                End Try

                Try
                    If frmApplicationForm.txtStudentID.Text.Length = 0 Then
                        frmApplicationForm.txtStudentID.Text = "1"
                    Else
                    End If
                Catch ex As Exception

                End Try

                Try
                    If frmApplicationForm.txtEmail.Text.Length = 0 Then
                        frmApplicationForm.txtEmail.Text = "a"
                    Else
                    End If
                Catch ex As Exception

                End Try
                ControlClassSQL.GetSearchResults()
            End If
        Catch ex As Exception

            MessageBox.Show("Please populate a search field.")
        End Try

    End Sub

    Public Shared Sub ValidateDataFields()

    End Sub

    Public Shared Sub LockFields()

        'Set Read Only flag to True for all editable fields.
        frmApplicationForm.txtLastName.ReadOnly = True
        frmApplicationForm.txtAcceptedOffer.ReadOnly = True
        frmApplicationForm.txtAStatus.ReadOnly = True
        frmApplicationForm.txtBefore_when.ReadOnly = True
        frmApplicationForm.txtBirthday1.ReadOnly = True
        frmApplicationForm.txtCFrom1.ReadOnly = True
        frmApplicationForm.txtCFrom2.ReadOnly = True
        frmApplicationForm.txtCGPA1.ReadOnly = True
        frmApplicationForm.txtCGPA2.ReadOnly = True
        frmApplicationForm.txtCName1.ReadOnly = True
        frmApplicationForm.txtCName2.ReadOnly = True
        frmApplicationForm.txtCTo1.ReadOnly = True
        frmApplicationForm.txtCTo2.ReadOnly = True
        frmApplicationForm.txtCurrentPhone.ReadOnly = True
        frmApplicationForm.txtDateAccepted.ReadOnly = True
        frmApplicationForm.txtDateApplied.ReadOnly = True
        frmApplicationForm.txtDDate.ReadOnly = True
        frmApplicationForm.txtDeclined.ReadOnly = True
        frmApplicationForm.txtDegree1.ReadOnly = True
        frmApplicationForm.txtDegree2.ReadOnly = True
        frmApplicationForm.txtDegreeDate1.ReadOnly = True
        frmApplicationForm.txtDegreeDate2.ReadOnly = True
        frmApplicationForm.txtDEnrolled.ReadOnly = True
        frmApplicationForm.txtEmail.ReadOnly = True
        frmApplicationForm.txtEnrolled_When.ReadOnly = True
        frmApplicationForm.txtFirstName.ReadOnly = True
        frmApplicationForm.txtGMATDate.ReadOnly = True
        frmApplicationForm.txtGMATQuant.ReadOnly = True
        frmApplicationForm.txtGMATTotal.ReadOnly = True
        frmApplicationForm.txtGMATVerbal.ReadOnly = True
        frmApplicationForm.txtLAddress.ReadOnly = True
        frmApplicationForm.txtLCity.ReadOnly = True
        frmApplicationForm.txtLZipCode.ReadOnly = True
        frmApplicationForm.txtMajor1.ReadOnly = True
        frmApplicationForm.txtMajor2.ReadOnly = True
        frmApplicationForm.txtMiddleName.ReadOnly = True
        frmApplicationForm.txtNotes.ReadOnly = True
        frmApplicationForm.txtPAddress.ReadOnly = True
        frmApplicationForm.txtPCity.ReadOnly = True
        frmApplicationForm.txtPPhone.ReadOnly = True
        frmApplicationForm.txtPZipCode.ReadOnly = True
        frmApplicationForm.txtRequestYear.ReadOnly = True
        frmApplicationForm.txtSEnrolled.ReadOnly = True
        frmApplicationForm.txtSSN.ReadOnly = True
        frmApplicationForm.txtStatus.ReadOnly = True
        frmApplicationForm.txtStudentID.ReadOnly = True
        frmApplicationForm.txtTOEFLDate.ReadOnly = True
        frmApplicationForm.txtTOEFLTotal.ReadOnly = True
        frmApplicationForm.txtTSEDate.ReadOnly = True
        frmApplicationForm.txtTSETotal.ReadOnly = True
        frmApplicationForm.txtUnderGPA.ReadOnly = True
        frmApplicationForm.txtWorkPhone.ReadOnly = True
        frmApplicationForm.cbxCitizenship.Enabled = False
        frmApplicationForm.cbxEthnic.Enabled = False
        frmApplicationForm.cbxGender.Enabled = False
        frmApplicationForm.cbxLState.Enabled = False
        frmApplicationForm.cbxOrigin.Enabled = False
        frmApplicationForm.cbxPrimaryContactNumber.Enabled = False
        frmApplicationForm.cbxStanding.Enabled = False
        frmApplicationForm.cbxPState.Enabled = False
        frmApplicationForm.cbxSession.Enabled = False
        frmApplicationForm.chkAppFeePaid.Enabled = False
        frmApplicationForm.chkAppForm.Enabled = False
        frmApplicationForm.chkBefore.Enabled = False
        frmApplicationForm.chkEducation.Enabled = False
        frmApplicationForm.chkEnrolled.Enabled = False
        frmApplicationForm.chkEssay.Enabled = False
        frmApplicationForm.chkFinancial.Enabled = False
        frmApplicationForm.chkGMATScore.Enabled = False
        frmApplicationForm.chkGREScore.Enabled = False
        frmApplicationForm.chkLOR.Enabled = False
        frmApplicationForm.chkRequested.Enabled = False
        frmApplicationForm.chkResident.Enabled = False
        frmApplicationForm.chkResume.Enabled = False
        frmApplicationForm.chkTOEFL.Enabled = False
        frmApplicationForm.chkTranscript.Enabled = False
        frmApplicationForm.chkTSE.Enabled = False

    End Sub

    Public Shared Sub UnlockFields()

        'Set ReadOnly flag to False for all editable fields.
        frmApplicationForm.txtLastName.ReadOnly = False
        frmApplicationForm.txtLastName.ReadOnly = False
        frmApplicationForm.txtAcceptedOffer.ReadOnly = False
        frmApplicationForm.txtAStatus.ReadOnly = False
        frmApplicationForm.txtBefore_when.ReadOnly = False
        frmApplicationForm.txtBirthday1.ReadOnly = False
        frmApplicationForm.txtCFrom1.ReadOnly = False
        frmApplicationForm.txtCFrom2.ReadOnly = False
        frmApplicationForm.txtCGPA1.ReadOnly = False
        frmApplicationForm.txtCGPA2.ReadOnly = False
        frmApplicationForm.txtCName1.ReadOnly = False
        frmApplicationForm.txtCName2.ReadOnly = False
        frmApplicationForm.txtCTo1.ReadOnly = False
        frmApplicationForm.txtCTo2.ReadOnly = False
        frmApplicationForm.txtCurrentPhone.ReadOnly = False
        frmApplicationForm.txtDateAccepted.ReadOnly = False
        frmApplicationForm.txtDateApplied.ReadOnly = False
        frmApplicationForm.txtDDate.ReadOnly = False
        frmApplicationForm.txtDeclined.ReadOnly = False
        frmApplicationForm.txtDegree1.ReadOnly = False
        frmApplicationForm.txtDegree2.ReadOnly = False
        frmApplicationForm.txtDegreeDate1.ReadOnly = False
        frmApplicationForm.txtDegreeDate2.ReadOnly = False
        frmApplicationForm.txtDEnrolled.ReadOnly = False
        frmApplicationForm.txtEmail.ReadOnly = False
        frmApplicationForm.txtEnrolled_When.ReadOnly = False
        frmApplicationForm.txtFirstName.ReadOnly = False
        frmApplicationForm.txtGMATDate.ReadOnly = False
        frmApplicationForm.txtGMATQuant.ReadOnly = False
        frmApplicationForm.txtGMATTotal.ReadOnly = False
        frmApplicationForm.txtGMATVerbal.ReadOnly = False
        frmApplicationForm.txtLAddress.ReadOnly = False
        frmApplicationForm.txtLCity.ReadOnly = False
        frmApplicationForm.txtLZipCode.ReadOnly = False
        frmApplicationForm.txtMajor1.ReadOnly = False
        frmApplicationForm.txtMajor2.ReadOnly = False
        frmApplicationForm.txtMiddleName.ReadOnly = False
        frmApplicationForm.txtNotes.ReadOnly = False
        frmApplicationForm.txtPAddress.ReadOnly = False
        frmApplicationForm.txtPCity.ReadOnly = False
        frmApplicationForm.txtPPhone.ReadOnly = False
        frmApplicationForm.txtPZipCode.ReadOnly = False
        frmApplicationForm.txtRequestYear.ReadOnly = False
        frmApplicationForm.txtSEnrolled.ReadOnly = False
        frmApplicationForm.txtSSN.ReadOnly = False
        frmApplicationForm.txtStatus.ReadOnly = False
        frmApplicationForm.txtStudentID.ReadOnly = False
        frmApplicationForm.txtTOEFLDate.ReadOnly = False
        frmApplicationForm.txtTOEFLTotal.ReadOnly = False
        frmApplicationForm.txtTSEDate.ReadOnly = False
        frmApplicationForm.txtTSETotal.ReadOnly = False
        frmApplicationForm.txtUnderGPA.ReadOnly = False
        frmApplicationForm.txtWorkPhone.ReadOnly = False
        frmApplicationForm.cbxCitizenship.Enabled = True
        frmApplicationForm.cbxEthnic.Enabled = True
        frmApplicationForm.cbxGender.Enabled = True
        frmApplicationForm.cbxLState.Enabled = True
        frmApplicationForm.cbxOrigin.Enabled = True
        frmApplicationForm.cbxPrimaryContactNumber.Enabled = True
        frmApplicationForm.cbxStanding.Enabled = True
        frmApplicationForm.cbxPState.Enabled = True
        frmApplicationForm.cbxSession.Enabled = True
        frmApplicationForm.chkAppFeePaid.Enabled = True
        frmApplicationForm.chkAppForm.Enabled = True
        frmApplicationForm.chkBefore.Enabled = True
        frmApplicationForm.chkEducation.Enabled = True
        frmApplicationForm.chkEnrolled.Enabled = True
        frmApplicationForm.chkEssay.Enabled = True
        frmApplicationForm.chkFinancial.Enabled = True
        frmApplicationForm.chkGMATScore.Enabled = True
        frmApplicationForm.chkGREScore.Enabled = True
        frmApplicationForm.chkLOR.Enabled = True
        frmApplicationForm.chkRequested.Enabled = True
        frmApplicationForm.chkResident.Enabled = True
        frmApplicationForm.chkResume.Enabled = True
        frmApplicationForm.chkTOEFL.Enabled = True
        frmApplicationForm.chkTranscript.Enabled = True
        frmApplicationForm.chkTSE.Enabled = True

    End Sub

End Class
