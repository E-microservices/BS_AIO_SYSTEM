Imports System.IO

Public Class MainController
    Dim CHECK_GBM As Boolean = True
    Dim CHECK_COM_MANAGER As Boolean = True
    Dim CHECK_OVER_SIGHT As Boolean = True
    Dim userInfos As New List(Of String)
    Dim userInfoContainer As String()
    Dim processCurrant As Process
    Dim luncher As Boolean = True
    Const OVER_SIGHT_APP As String = "OVERSIGHT"
    Const GLOBAL_BUSINESS_MANAGER As String = "GlobalBusnessManager"
    Const SUPER_USER As Integer = 0
    Const AGENT_COM_USER As Integer = 1
    Const MANAGER_AGENT As Integer = 2
    Const TOW_IN_ONE As Integer = 3
    Const INVOLID_USER As Integer = 4
    Const COM_MANAGER As String = "ComManager"
    Const USER_FILE As String = "file.bs"
    Const YOULE As String = "ouattara"
    Const HILAIRE As String = "malan"
    Const CEDRIC As String = "cedrick"
    Const EDITH As String = "edith"
    Const FRANCK As String = "franck"
    Const EDITH_2 As String = "edith"
    Const MICHAEL As String = "michael"
    Const SUPER_ADMIN As String = "super_h"
    Const BOSS As String = "headmaster"
    Const ADMIN As String = "haskey"
    Private Sub MainController_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TCHUKER.Interval = 1000
        TCHUKER.Enabled = True
        TCHUKER.Start()
        notificationInite()
        Connexion.BT_CANCEL.Visible = True

        checkUserInfos()
    End Sub
    Private Sub OVER_SIGHT_Click(sender As Object, e As EventArgs) Handles OVER_SIGHT.Click
        If userPermition() = SUPER_USER Then
            processSeting(OVER_SIGHT_APP)
        Else
            MsgBox("Vous ne pouvez pas acceder à cette fonctionnalite", MsgBoxStyle.Exclamation, "Erreur de permition")
        End If
    End Sub
    Private Sub GBM_Click(sender As Object, e As EventArgs) Handles GBM.Click
        If userPermition() = TOW_IN_ONE Or userPermition() = SUPER_USER Then
            processSeting(GLOBAL_BUSINESS_MANAGER)
        Else
            MsgBox("Vous ne pouvez pas acceder à cette fonctionnalite", MsgBoxStyle.Exclamation, "Erreur de permition")
        End If
    End Sub

    Private Sub COMMANAGER_Click(sender As Object, e As EventArgs) Handles COMMANAGER.Click
        If userPermition() = AGENT_COM_USER Or userPermition() = TOW_IN_ONE Or userPermition() = SUPER_USER Then
            processSeting(COM_MANAGER)
        Else
            MsgBox("Vous ne pouvez pas acceder à cette fonctionnalite", MsgBoxStyle.Exclamation, "Erreur de permition")
        End If
    End Sub
    Private Sub notification_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles notification.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

    Private Sub SETTING_Click(sender As Object, e As EventArgs) Handles SETTING.Click
        If userPermition() = SUPER_USER Then
            'Commande pour ouvrir les parametre
        Else
            MsgBox("Vous ne pouvez pas acceder à cette fonctionnalite", MsgBoxStyle.Exclamation, "Erreur de permition")
        End If

    End Sub
    Private Sub TMI(sender As Object, e As EventArgs) Handles TCHUKER.Disposed

        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub

#Region "Function"
    Private Sub checkUserInfos()
        Dim looOk As Boolean
        If Not File.Exists(USER_FILE) Then
            Do
                looOk = connexionEstablishied()
            Loop Until looOk
        Else
            userInfoContainer = getUserInfos()
            userInfos.Add(userInfoContainer(0))
            userInfos.Add(userInfoContainer(1))
            notificationInfos("Bonjour " & userInfos(0).ToUpper, "Content de vous revoir !" & Chr(13) &
                              "Double-Cliquez ici pour ouvrir l'interface principale si elle n'apparait pas.")
        End If
    End Sub
    Private Sub processSeting(processName As String)
        Process.Start(processName + ".exe")
    End Sub
    Private Sub notificationInfos(titre As String, message As String)
        With Me.notification
            .BalloonTipTitle = titre
            .BalloonTipText = message
            .BalloonTipIcon = ToolTipIcon.Info
            .ShowBalloonTip(3000)
        End With
    End Sub
    Private Sub notificationWarning(message As String)
        With Me.notification
            .BalloonTipTitle = "Attention !"
            .BalloonTipText = message
            .BalloonTipIcon = ToolTipIcon.Warning
            .ShowBalloonTip(3000)
        End With
    End Sub
    Private Sub notificationError(message As String)
        With Me.notification
            .BalloonTipTitle = "Action inatendus"
            .BalloonTipText = message
            .BalloonTipIcon = ToolTipIcon.Error
            .ShowBalloonTip(3000)
        End With
    End Sub
    Private Sub notificationInite()
        Me.notification.Visible = True
        With Me.notification
            .BalloonTipTitle = "Infos"
            .BalloonTipText = "Faites un double click pour faire apparaitre la fenetre"
            .BalloonTipIcon = ToolTipIcon.Info
        End With
    End Sub
    Private Sub enabledOrDesable()
        For Each pro As Process In Process.GetProcesses
            If pro.ProcessName() = "GlobalBusnessManager" Then
                Me.WindowState = FormWindowState.Minimized
                Me.ShowInTaskbar = False
            Else
                Me.WindowState = FormWindowState.Normal
                Me.ShowInTaskbar = True
                luncher = True
            End If
        Next
    End Sub
    Private Function isProcessing(PROCESS_NAME As String) As Boolean
        Dim response As Boolean = False
        For Each pro As Process In Process.GetProcesses
            If pro.ProcessName() = PROCESS_NAME Then
                response = True
                If pro.ProcessName() = GLOBAL_BUSINESS_MANAGER Then
                    CHECK_OVER_SIGHT = False
                    CHECK_COM_MANAGER = False
                End If
                If pro.ProcessName() = OVER_SIGHT_APP Then
                    CHECK_GBM = False
                    CHECK_COM_MANAGER = False
                End If
                If pro.ProcessName() = COM_MANAGER Then
                    CHECK_OVER_SIGHT = False
                    CHECK_GBM = False
                End If
                Exit For
            End If
        Next
        Return response
    End Function
    Private Function userPermition() As Integer
        Dim response As Integer = INVOLID_USER
        If userInfos(0) <> BOSS And userInfos(0) <> ADMIN And userInfos(0) <> SUPER_ADMIN Then
            response = userPermitionTwo()
        Else
            Select Case userInfos(0)
                Case BOSS
                    response = SUPER_USER
                Case SUPER_ADMIN
                    response = SUPER_USER
                Case ADMIN
                    response = SUPER_USER
                Case Else
                    response = INVOLID_USER
            End Select
        End If
        Return response
    End Function
    Private Function userPermitionTwo() As Integer
        Dim response As Integer = INVOLID_USER
        If userInfos(0) <> HILAIRE And userInfos(0) <> YOULE And userInfos(0) <> CEDRIC And userInfos(0) <> EDITH And userInfos(0) <> MICHAEL Then
            response = INVOLID_USER
        Else
            Select Case userInfos(0)
                Case HILAIRE
                    response = AGENT_COM_USER
                Case YOULE
                    response = AGENT_COM_USER
                Case CEDRIC
                    response = AGENT_COM_USER
                Case EDITH
                    response = TOW_IN_ONE
                Case EDITH_2
                    response = TOW_IN_ONE
                Case MICHAEL
                    response = AGENT_COM_USER
                Case Else
                    response = INVOLID_USER
            End Select
        End If
        Return response
    End Function

    Private Sub TCHUKER_Tick(sender As Object, e As EventArgs) Handles TCHUKER.Tick
        If CHECK_COM_MANAGER Then
            displayOrNone(isProcessing(COM_MANAGER))
        End If
        If CHECK_GBM Then
            displayOrNone(isProcessing(GLOBAL_BUSINESS_MANAGER))
        End If
        If CHECK_OVER_SIGHT Then
            displayOrNone(isProcessing(OVER_SIGHT_APP))
        End If
    End Sub

    Private Sub displayOrNone(b As Boolean)
        If b Then
            Me.Visible = False
        Else
            Me.Visible = True
            CHECK_OVER_SIGHT = True
            CHECK_GBM = True
            CHECK_COM_MANAGER = True
        End If
    End Sub
    'Private Function userStatus(user As String) As Integer
    '    Dim response As Integer
    '    Select Case user
    '        Case "malan"
    '
    '        Case "ouattara"
    '
    '        Case "cedrick"
    '
    '        Case "edith"
    '
    '        Case Else
    '    End Select
    '    Return response
    'End Function
#End Region

    Function connexionEstablishied() As Boolean
        Dim succes As Boolean = False
        Dim mProcessuce As Process() = Process.GetProcessesByName("BS_AIO_SYSTEM")
        Connexion.ShowDialog()
        If Connexion.DialogResult = DialogResult.Cancel Then
            For Each pr In mProcessuce
                pr.Kill()
            Next
        End If
        If connected(Connexion.USER_BOX.Text, Connexion.PASSWORD_BOX.Text) Then
            userInfos.Add(Connexion.USER_BOX.Text)
            userInfos.Add(Connexion.PASSWORD_BOX.Text)
            setUserInfos(userInfos)
            notificationInfos("Bienvenu " & userInfos(0).ToUpper, "Connexion établie avec succès.")
            succes = True
        Else
            notificationError("Impossible de se connecter à BEESHOP")
            MsgBox("Problème de connexion. Veuillez contacter votre administrateur si le problème persiste !")
        End If
        Return succes
    End Function
End Class
