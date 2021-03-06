Imports System
Imports EnvDTE
Imports EnvDTE80
Imports EnvDTE90
Imports EnvDTE90a
Imports EnvDTE100
Imports System.Diagnostics

Public Module Git
    Public Sub Commit()
        Dim message As String
        Dim solutionFolder As String
        Dim gitFolder As String
        Dim pos As Integer
        Dim cmd As String

        DTE.ExecuteCommand("File.SaveAll")

        message = InputBox("Git Commit Message", "Git Commit")
        If (message <> "") Then
            solutionFolder = DTE.Solution.FullName
            pos = solutionFolder.LastIndexOf("\")
            gitFolder = solutionFolder.Substring(0, pos)
            cmd = "powershell.exe -noprofile -command ""cd """ + gitFolder + """;"
            cmd = cmd + "cd (git rev-parse --show-cdup);"
            cmd = cmd + "git add -A;"
            cmd = cmd + "git commit -m """ + message + """"
            Shell(cmd)
        End If
    End Sub
End Module
