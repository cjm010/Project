Public Class ControlClassForm

    'Programmer: sample
    'Date: 01/01/07
    'Description: Functions for all SQL query commands

    Public Shared Sub ValidateDataFields()

    End Sub

    Public Shared Sub LockFields()

        'Set Read Only flag to True for all editable fields.
        frmApplicationForm.txtLastName.ReadOnly = True
        'frmApplicationForm.txtAcceptedOffer.ReadOnly = True
        frmApplicationForm.txtBefore_when.ReadOnly = True
        frmApplicationForm.txtBirthday1.ReadOnly = True
        'frmApplicationForm.txtCFrom1.ReadOnly = True
        'frmApplicationForm.txtCFrom2.ReadOnly = True
        'frmApplicationForm.txtCGPA1.ReadOnly = True
        'frmApplicationForm.txtCGPA2.ReadOnly = True
        'frmApplicationForm.txtCName1.ReadOnly = True
        'frmApplicationForm.txtCName2.ReadOnly = True
        'frmApplicationForm.txtCTo1.ReadOnly = True
        'frmApplicationForm.txtCTo2.ReadOnly = True
        frmApplicationForm.txtCurrentPhone.ReadOnly = True
        'frmApplicationForm.txtDateAccepted.ReadOnly = True
        frmApplicationForm.txtDateApplied.ReadOnly = True
        frmApplicationForm.txtDDate.ReadOnly = True
        frmApplicationForm.txtDeclined.ReadOnly = True
        'frmApplicationForm.txtDegree1.ReadOnly = True
        'frmApplicationForm.txtDegree2.ReadOnly = True
        'frmApplicationForm.txtDegreeDate1.ReadOnly = True
        'frmApplicationForm.txtDegreeDate2.ReadOnly = True
        frmApplicationForm.txtDEnrolled.ReadOnly = True
        frmApplicationForm.txtEmail.ReadOnly = True
        frmApplicationForm.txtEnrolled_When.ReadOnly = True
        frmApplicationForm.txtFirstName.ReadOnly = True
        'frmApplicationForm.txtGMATDate.ReadOnly = True
        'frmApplicationForm.txtGMATQuant.ReadOnly = True
        'frmApplicationForm.txtGMATTotal.ReadOnly = True
        'frmApplicationForm.txtGMATVerbal.ReadOnly = True
        frmApplicationForm.txtLAddress.ReadOnly = True
        frmApplicationForm.txtLCity.ReadOnly = True
        frmApplicationForm.txtLZipCode.ReadOnly = True
        'frmApplicationForm.txtMajor1.ReadOnly = True
        'frmApplicationForm.txtMajor2.ReadOnly = True
        frmApplicationForm.txtMiddleName.ReadOnly = True
        'frmApplicationForm.txtNotes.ReadOnly = True
        frmApplicationForm.txtPAddress.ReadOnly = True
        frmApplicationForm.txtPCity.ReadOnly = True
        frmApplicationForm.txtPPhone.ReadOnly = True
        frmApplicationForm.txtPZipCode.ReadOnly = True
        frmApplicationForm.txtRequestYear.ReadOnly = True
        'frmApplicationForm.txtSEnrolled.ReadOnly = True
        frmApplicationForm.txtSSN.ReadOnly = True
        'frmApplicationForm.txtStatus.ReadOnly = True
        frmApplicationForm.txtStudentID.ReadOnly = True
        'frmApplicationForm.txtTOEFLDate.ReadOnly = True
        'frmApplicationForm.txtTOEFLTotal.ReadOnly = True
        'frmApplicationForm.txtTSEDate.ReadOnly = True
        'frmApplicationForm.txtTSETotal.ReadOnly = True
        'frmApplicationForm.txtUnderGPA.ReadOnly = True
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
        'frmApplicationForm.chkAppFeePaid.Enabled = False
        ' frmApplicationForm.chkAppForm.Enabled = False
        frmApplicationForm.chkBefore.Enabled = False
        frmApplicationForm.chkEducation.Enabled = False
        frmApplicationForm.chkEnrolled.Enabled = False
        frmApplicationForm.chkEssay.Enabled = False
        frmApplicationForm.chkFinancial.Enabled = False
        frmApplicationForm.chkGMATScore.Enabled = False
        'frmApplicationForm.chkGREScore.Enabled = False
        frmApplicationForm.chkLOR.Enabled = False
        'frmApplicationForm.chkRequested.Enabled = False
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
        ' frmApplicationForm.txtAcceptedOffer.ReadOnly = False
        frmApplicationForm.txtBefore_when.ReadOnly = False
        frmApplicationForm.txtBirthday1.ReadOnly = False
        'frmApplicationForm.txtCFrom1.ReadOnly = False
        'frmApplicationForm.txtCFrom2.ReadOnly = False
        'frmApplicationForm.txtCGPA1.ReadOnly = False
        'frmApplicationForm.txtCGPA2.ReadOnly = False
        'frmApplicationForm.txtCName1.ReadOnly = False
        'frmApplicationForm.txtCName2.ReadOnly = False
        'frmApplicationForm.txtCTo1.ReadOnly = False
        'frmApplicationForm.txtCTo2.ReadOnly = False
        frmApplicationForm.txtCurrentPhone.ReadOnly = False
        'frmApplicationForm.txtDateAccepted.ReadOnly = False
        frmApplicationForm.txtDateApplied.ReadOnly = False
        frmApplicationForm.txtDDate.ReadOnly = False
        frmApplicationForm.txtDeclined.ReadOnly = False
        'frmApplicationForm.txtDegree1.ReadOnly = False
        'frmApplicationForm.txtDegree2.ReadOnly = False
        'frmApplicationForm.txtDegreeDate1.ReadOnly = False
        'frmApplicationForm.txtDegreeDate2.ReadOnly = False
        frmApplicationForm.txtDEnrolled.ReadOnly = False
        frmApplicationForm.txtEmail.ReadOnly = False
        frmApplicationForm.txtEnrolled_When.ReadOnly = False
        frmApplicationForm.txtFirstName.ReadOnly = False
        'frmApplicationForm.txtGMATDate.ReadOnly = False
        'frmApplicationForm.txtGMATQuant.ReadOnly = False
        'frmApplicationForm.txtGMATTotal.ReadOnly = False
        'frmApplicationForm.txtGMATVerbal.ReadOnly = False
        frmApplicationForm.txtLAddress.ReadOnly = False
        frmApplicationForm.txtLCity.ReadOnly = False
        frmApplicationForm.txtLZipCode.ReadOnly = False
        'frmApplicationForm.txtMajor1.ReadOnly = False
        'frmApplicationForm.txtMajor2.ReadOnly = False
        frmApplicationForm.txtMiddleName.ReadOnly = False
        ' frmApplicationForm.txtNotes.ReadOnly = False
        frmApplicationForm.txtPAddress.ReadOnly = False
        frmApplicationForm.txtPCity.ReadOnly = False
        frmApplicationForm.txtPPhone.ReadOnly = False
        frmApplicationForm.txtPZipCode.ReadOnly = False
        frmApplicationForm.txtRequestYear.ReadOnly = False
        'frmApplicationForm.txtSEnrolled.ReadOnly = False
        frmApplicationForm.txtSSN.ReadOnly = False
        'frmApplicationForm.txtStatus.ReadOnly = False
        frmApplicationForm.txtStudentID.ReadOnly = False
        'frmApplicationForm.txtTOEFLDate.ReadOnly = False
        'frmApplicationForm.txtTOEFLTotal.ReadOnly = False
        'frmApplicationForm.txtTSEDate.ReadOnly = False
        'frmApplicationForm.txtTSETotal.ReadOnly = False
        'frmApplicationForm.txtUnderGPA.ReadOnly = False
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
        'frmApplicationForm.chkAppFeePaid.Enabled = True
        'frmApplicationForm.chkAppForm.Enabled = True
        frmApplicationForm.chkBefore.Enabled = True
        frmApplicationForm.chkEducation.Enabled = True
        frmApplicationForm.chkEnrolled.Enabled = True
        frmApplicationForm.chkEssay.Enabled = True
        frmApplicationForm.chkFinancial.Enabled = True
        frmApplicationForm.chkGMATScore.Enabled = True
        ' frmApplicationForm.chkGREScore.Enabled = True
        frmApplicationForm.chkLOR.Enabled = True
        'frmApplicationForm.chkRequested.Enabled = True
        frmApplicationForm.chkResident.Enabled = True
        frmApplicationForm.chkResume.Enabled = True
        frmApplicationForm.chkTOEFL.Enabled = True
        frmApplicationForm.chkTranscript.Enabled = True
        frmApplicationForm.chkTSE.Enabled = True

    End Sub

End Class
