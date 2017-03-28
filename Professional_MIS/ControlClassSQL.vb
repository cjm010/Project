Public Class ControlClassSQL
    Public Shared UserID As String
    Public Shared UserRole As String

    Public Shared Function getSelected(gridview As DataGridView) As String
        Dim str As String
        str = gridview.Rows(gridview.SelectedRows(0).Index()).Cells(1).Value.ToString()
        Return str
    End Function

    Public Shared Function getSelectedAppID(gridview As DataGridView) As String
        Dim str As String
        str = gridview.Rows(gridview.SelectedRows(0).Index()).Cells(0).Value.ToString()
        Return str
    End Function


    Public Shared Function GetAllStudents() As DataSet
        Dim _DBConnector As New DBConnector()
        Dim AllStudents As New DataSet
        Dim query As String

        Try
            query = "SELECT c.ApplicationID, a.StudentID as ID, a.FirstName, a.LastName, b.ProgramType, b.Concentration, c.ApplicationTerm, c.AppStatus
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


    Public Shared Function GetStudentScores(ByVal StuID As String) As DataSet
        Dim _DBConnector As New DBConnector()
        Dim Scores As New DataSet
        Dim query As String

        Try
            query = "SELECT TestScore.Type, TestScore.Date, TestScore.Total, TestScore.Quant, TestScore.QuantPercentile AS 'Quant %', TestScore.Verbal, TestScore.VerbalPercentile AS 'Verbal %', TestScore.Writing, (TestScore.QuantPercentile + TestScore.VerbalPercentile) AS 'V+Q'
                            FROM TestScore INNER JOIN Application ON TestScore.ApplicationID = Application.ApplicationID
                            WHERE Application.StudentID = " & StuID & ";"
            Scores = _DBConnector.GetDataSet(query)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
        'Return the result
        Return Scores
    End Function


    Public Shared Function GetStudentRecord(ByVal stuID As String) As DataSet
        Dim _DBConnector As New DBConnector()
        Dim studentRecord As New DataSet
        Dim query As String

        Try
            query = "Select Student.StudentID, 
		                    Student.LastName, 
		                    Student.MiddleName, 
		                    Student.FirstName, 
		                    Student.SSN,
		                    CONVERT( DATE, Student.DOB) as DOB,
		                    Student.Origin, 
		                    Student.Ethnicity, 
		                    Student.Gender, 
		                    Student.Citizenship, 
		                    Student.Email, 
		                    RIGHT(Application.ApplicationTerm, 4) AS ApplicationYear,
		                    LEFT(Application.ApplicationTerm, CHARINDEX(' ', Application.ApplicationTerm, 1)-1) AS ApplicationSemester,
		                    Application.PrevApp, 
		                    Application.PrevAppTerm,
		                    Application.PrevEnrol, 
		                    Application.PrevEnrolTerm,
		                    Application.AppStatus, 
                            CONVERT( DATE, Application.AppStatusDate) as AppStatusDate,
		                    Application.AssistantshipStatus,
		                    Application.Enrolled, 
                            CONVERT( DATE, Application.EnrolledDate) as EnrolledDate,
                            Application.StudentDecision,
                            CONVERT( DATE, Application.StudentDecisionDate) as StudentDecisionDate,
							Application.Resume,
							Application.PersonalStatement,
							CASE WHEN Application.Resume = null THEN 0 ELSE 1 END AS HasResume,
							CASE WHEN Application.PersonalStatement = null THEN 0 ELSE 1 END AS HasStatement,
                            CASE WHEN Phone.Type = 'Cell' THEN Phone.PhoneNumber else NULL end as CellPhone,
		                    CASE WHEN Phone.Type = 'Home' THEN Phone.PhoneNumber else NULL end as HomePhone,
		                    CASE WHEN Phone.Type = 'Work' THEN Phone.PhoneNumber else NULL end as WorkPhone,
		                    CASE WHEN Phone.Preferred = 1 THEN Phone.Type else NULL end as PreferredType
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


    Public Shared Function GetEducation(ByVal StuID As String) As DataSet
        Dim _DBConnector As New DBConnector()
        Dim Education As New DataSet
        Dim query As String

        Try
            query = "SELECT SchoolName, AttendedFrom, AttendedTo, GPA, Degree, Major, DegreeDate, Transcript, InProgress
                        FROM Education
                        WHERE StudentID = " & StuID & ";"
            Education = _DBConnector.GetDataSet(query)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
        'Return the result
        Return Education
    End Function


    Public Shared Function Login(ByVal UserID As String, ByVal Password As String) As DataSet
        Dim _DBConnector As New DBConnector()
        Dim Users As New DataSet
        Dim query As String

        Try
            query = "SELECT UserID, Role, Password
                            FROM Users
                            WHERE UserID = " & UserID & " AND Password ='" & Password & "';"
            Users = _DBConnector.GetDataSet(query)
        Catch ex As Exception
            Throw ex
        Finally

        End Try

        'Return the result
        Return Users
    End Function


    Public Shared Function GetAppReview(ByVal StuID As String) As DataSet
        Dim _DBConnector As New DBConnector()
        Dim Review As New DataSet
        Dim query As String

        Try
            query = "SELECT a.CommitteeScore, a.GeneralNotes, a.RecAssistantship, a.InterviewNotes, a.InterviewScore
                            FROM AppReview a INNER JOIN Application b ON a.ApplicationID = b.ApplicationID
                            WHERE b.StudentID = " & StuID & " AND a.UserID = " & UserID & ";"
            Review = _DBConnector.GetDataSet(query)
        Catch ex As Exception
            Throw ex
        Finally

        End Try
        'Return the result
        Return Review
    End Function


End Class
