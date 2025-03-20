Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Module Module1
    Public db As New OleDbConnection
    Public tbluser As New OleDbDataAdapter
    Public book As New OleDbDataAdapter
    Public borrow As New OleDbDataAdapter
    Public penalty As New OleDbDataAdapter
    Private dbcon As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Windows11\Desktop\test2\test2\test2\bin\Debug\dbase.mdb"
    Private dbConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbcon


    Public dbcmd As New OleDbCommand
    Public dbds As New DataSet

    Public recpointer As Integer
    Public trec As Integer
    Public sw As Boolean
    Dim imagePathbook As String = Application.StartupPath & "\bookimage\" & ".jpg"""
    Dim imagePath As String = Application.StartupPath & "\images\" & ".jpg"""
    Dim userId As String
    Dim booktitle As String
    Public XName As String
    Public xpic As String
    Public Xid As String
    Public xpost As String
    Public xpriv As String
    Public xtry As Integer






    Sub opendb()
        Try
            db = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\dbase.mdb")
            tbluser = New OleDb.OleDbDataAdapter("SELECT * FROM tbluser", db)
            dbds = New DataSet()
            tbluser.Fill(dbds, "tbluser")

            If dbds.Tables("tbluser").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tbluser").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(Err.ToString)
        Finally

            db.Close()

        End Try
    End Sub
    Sub Opendbbooks()
        Try
            db = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\dbase.mdb")
            book = New OleDb.OleDbDataAdapter("SELECT * FROM book", db)
            dbds = New DataSet()
            book.Fill(dbds, "book")

            If dbds.Tables("book").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("book").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(Err.ToString)
        Finally

            db.Close()

        End Try
    End Sub

    Sub Opendbborrow()
        Try
            db = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\dbase.mdb")
            borrow = New OleDb.OleDbDataAdapter("SELECT * FROM borrow", db)
            dbds = New DataSet()
            borrow.Fill(dbds, "borrow")

            If dbds.Tables("borrow").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("borrow").Rows.Count) - 1
            End If
        Catch ex As Exception
            MsgBox(Err.ToString)
        Finally


            db.Close()

        End Try
    End Sub

    Sub sqlquery()
        Try
            tbluser = New OleDb.OleDbDataAdapter("SELECT [User ID],[User Name],[Position],[Privilege],[studentid] FROM tbluser", db)
            dbds = New DataSet()
            tbluser.Fill(dbds, "tbluser")

            If dbds.Tables("tbluser").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("tbluser").Rows.Count) - 1
            End If
        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub

    Sub sqlquerybooks()
        Try
            book = New OleDb.OleDbDataAdapter("SELECT [Call No],[ISBN],[Title of the book],[Author of the book],[Publication Year],[Genre],[Copyright],[Number of books],[Description],[Available books] FROM book", db)
            dbds = New DataSet()
            book.Fill(dbds, "book")

            If dbds.Tables("book").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("book").Rows.Count) - 1
            End If

        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub
    Sub sqlqueryborrow()
        Try
            borrow = New OleDb.OleDbDataAdapter("SELECT [call num],[tl],[dt],[tm],[au],[nm],[course],[isbn],[copyright],[studentid],[description] FROM borrow", db)
            dbds = New DataSet()
            borrow.Fill(dbds, "borrow")

            If dbds.Tables("borrow").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("borrow").Rows.Count) - 1
            End If
        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub

    'this below is connections to transactions

    Sub openpenalty()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\dbase.mdb")
            penalty = New OleDb.OleDbDataAdapter("SELECT * FROM penalty", db)
            dbds = New DataSet()
            penalty.Fill(dbds, "penalty")
            If dbds.Tables("penalty").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("penatly").Rows.Count) - 1

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            db.Close()

        End Try
    End Sub

    Sub sqlquerypenatly()
        Try
            penalty = New OleDb.OleDbDataAdapter("SELECT [penalty],[Due],[No] FROM penalty", db)
            dbds = New DataSet()
            penalty.Fill(dbds, "penalty")

            If dbds.Tables("penalty").Rows.Count > 0 Then
                recpointer = 0
                trec = CInt(dbds.Tables("penalty").Rows.Count) - 1
            End If
        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub

End Module
