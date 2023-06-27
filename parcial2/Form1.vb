﻿Imports System.Runtime.InteropServices

Public Class Form1

    'VARIABLES
    Private originalImage As Image

    'CARGA========================================================================================

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'incióSesion?
        If variablesGlobales.inicioSesion = False Then

            loginRegistro.Show()
            loginRegistro.Owner = Me
        Else
            loginRegistro.Close()
        End If

    End Sub


    'BOTON CERRAR---------------------
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub BtnCerrar_MouseEnter(sender As Object, e As EventArgs) Handles BtnCerrar.MouseEnter
        originalImage = BtnCerrar.Image
        BtnCerrar.BackColor = Color.FromArgb(255, 117, 117)
        BtnCerrar.Image = Image.FromFile("C:\Users\edkac\OneDrive\Documentos\MEGAsync\U 2023\HPP\5. PARCIALES\PARCIAL #2\parcial2\parcial2\IMG\cancel White.png")
    End Sub

    Private Sub BtnCerrar_MouseLeave(sender As Object, e As EventArgs) Handles BtnCerrar.MouseLeave
        BtnCerrar.Image = originalImage
        BtnCerrar.BackColor = Color.White
    End Sub

    'BOTON MINIMIZAR---------------------

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub BtnMin_MouseEnter(sender As Object, e As EventArgs) Handles BtnMin.MouseEnter
        BtnMin.BackColor = Color.FromArgb(229, 229, 229)

    End Sub

    Private Sub BtnMin_MouseLeave(sender As Object, e As EventArgs) Handles BtnMin.MouseLeave
        BtnMin.BackColor = Color.White
    End Sub


    'BARRA HERADER MOVIMIENTO relativo
    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged

        'loginRegistro
        If loginRegistro IsNot Nothing Then
            loginRegistro.Location = New Point(Me.Location.X, Me.Location.Y + 49)
        End If

    End Sub

    'MOVIMIENTO-=====================================================================================
    Private Sub Menu_MouseDown(sender As Object, e As MouseEventArgs) Handles Menu.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = 2
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

End Class



