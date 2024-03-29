﻿Imports MusicBookingSystem.DataStructures
Imports MusicBookingSystem.UserFileHandler
Imports MusicBookingSystem.SearchAlgorithms
Public Class LoginMenu
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Fetch the user from the array
        Dim user = SearchUserUsername(txtUsername.Text)
        ' Check if the user exists
        If (user.Password = txtPassword.Text) Then
            ' Set the currently logged in user
            currentlyLoggedInUser = user
            ' Send the user to the correct menu
            If currentlyLoggedInUser.UserType = "Admin" Then
                Me.Hide()
                AdminMenu.Show()
            Else
                Me.Hide()
                UserMenu.Show()
            End If
        Else
            ' Display an error message
            MsgBox("Incorrect username or password")
        End If
    End Sub
    Private Sub LoginMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the users from the file
        ReadUsers()
    End Sub

    Private Sub lnkForgottenPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgottenPassword.LinkClicked
        ' Send the user to the forgotten password menu
        Me.Hide()
        ForgottenPassword.Show()
    End Sub

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        ' Send the user to the create user menu
        Me.Hide()
        CreateUser.Show()
    End Sub
End Class