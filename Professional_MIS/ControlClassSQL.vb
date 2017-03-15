Public Class ControlClassSQL

    'Programmer: sample
    'Date: 01/01/07
    'Description: Functions for all SQL query commands

    Public Shared Function getSelected(gridview As DataGridView) As String
        Dim str As String
        str = gridview.Rows(gridview.SelectedRows(0).Index()).Cells(0).Value.ToString()
        Return str
    End Function

    Public Shared Function GetSearchResults() As DataSet
        Dim _DBConnector As New DBConnector()
        Dim searchResults As New DataSet
        Dim query As String

        Try
            query = "SELECT StudentID, FirstName, LastName, SSN, Email, DOB, Gender FROM Student WHERE (LastName = '" & frmApplicationForm.txtLastName.Text & "' OR SSN = '" & frmApplicationForm.txtSSN.Text & "' OR StudentID = " & frmApplicationForm.txtStudentID.Text & " OR Email = '" & frmApplicationForm.txtEmail.Text & "');"
            searchResults = _DBConnector.GetDataSet(query)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
        'Return the result
        Return searchResults

    End Function

    Public Shared Function GetAllStudents() As DataSet
        Dim _DBConnector As New DBConnector()
        Dim AllStudents As New DataSet
        Dim query As String

        Try
            query = "SELECT a.StudentID, a.FirstName, a.LastName, b.ProgramType, b.Concentration, c.ApplicationTerm, c.AppStatus
                        FROM Student a INNER JOIN ProCon b ON a.ProConID = b.ProConID
                        INNER JOIN Application c ON a.StudentID = c.StudentID;"
            AllStudents = _DBConnector.GetDataSet(query)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
        'Return the result
        Return AllStudents

    End Function

    Public Shared Function GetStudentAddress(ByVal stuID As String) As DataSet
        Dim _DBConnector As New DBConnector()
        Dim Address As New DataSet
        Dim query As String

        Try
            query = "SELECT City, StateProvince, Country, ZipCode, Address1, Address2, AddressType, Mailing
                     FROM Address
                     WHERE StudentID = " & stuID & ";"
            Address = _DBConnector.GetDataSet(query)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
        'Return the result
        Return Address

    End Function

    Public Shared Function GetStudentPhone(ByVal stuID As String) As DataSet
        Dim _DBConnector As New DBConnector()
        Dim Phones As New DataSet
        Dim query As String

        Try
            query = "SELECT PhoneNumber, Type, Preferred
                     FROM Phone
                     WHERE StudentID = " & stuID & ";"
            Phones = _DBConnector.GetDataSet(query)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
        'Return the result
        Return Phones

    End Function


    Public Shared Function GetStudentRecord(ByVal stuID As String) As DataSet
        Dim _DBConnector As New DBConnector

        Dim studentRecord As New DataSet
        Dim query As String

        Try
            query = "Select Student.StudentID, 
		                    Student.LastName, 
		                    Student.MiddleName, 
		                    Student.FirstName, 
		                    Student.SSN, 
		                    Student.DOB,
		                    Student.Origin, 
		                    Student.Ethnicity, 
		                    Student.Gender, 
		                    Student.Citizenship, 
		                    Student.Email, 
		                    RIGHT(Application.ApplicationTerm, 4) AS ApplicationYear,
		                    LEFT(Application.ApplicationTerm, CHARINDEX(' ', Application.ApplicationTerm, 1)) AS ApplicationSemester,
		                    Application.PrevApp, 
		                    Application.PrevAppTerm,
		                    Application.PrevEnrol, 
		                    Application.PrevEnrolTerm,
		                    Application.AppStatus, 
		                    Application.AppStatusDate,
		                    Application.AssistantshipStatus,
		                    Application.Enrolled, 
		                    Application.EnrolledDate,
                            CASE WHEN Phone.Type = 'Cell' THEN Phone.PhoneNumber
		                    else NULL end as CellPhone,
		                    CASE WHEN Phone.Type = 'Home' THEN Phone.PhoneNumber
		                    else NULL end as HomePhone,
		                    CASE WHEN Phone.Type = 'Work' THEN Phone.PhoneNumber
		                    else NULL end as WorkPhone,
		                    CASE WHEN Phone.Preferred = 1 THEN Type
		                    else NULL end as PreferredType
                    FROM Student INNER JOIN Application ON Student.StudentID = Application.StudentID
                    INNER JOIN Phone ON Student.StudentID = Phone.StudentID
                    WHERE Student.StudentID = " & stuID & ";"
            studentRecord = _DBConnector.GetDataSet(query)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
        'Return the result
        Return studentRecord

    End Function

End Class
