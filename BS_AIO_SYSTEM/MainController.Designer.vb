<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainController
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainController))
        Me.TCHUKER = New System.Windows.Forms.Timer(Me.components)
        Me.notification = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GBM = New System.Windows.Forms.PictureBox()
        Me.COMMANAGER = New System.Windows.Forms.PictureBox()
        Me.OVER_SIGHT = New System.Windows.Forms.PictureBox()
        Me.SETTING = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.GBM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMMANAGER, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OVER_SIGHT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SETTING, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCHUKER
        '
        Me.TCHUKER.Enabled = True
        Me.TCHUKER.Interval = 1000
        '
        'notification
        '
        Me.notification.Icon = CType(resources.GetObject("notification.Icon"), System.Drawing.Icon)
        Me.notification.Text = "Beeshop All In One"
        Me.notification.Visible = True
        '
        'GBM
        '
        Me.GBM.Image = Global.BS_AIO_SYSTEM.My.Resources.Resources.SystemGestion1
        Me.GBM.Location = New System.Drawing.Point(623, 270)
        Me.GBM.Name = "GBM"
        Me.GBM.Size = New System.Drawing.Size(130, 130)
        Me.GBM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GBM.TabIndex = 1
        Me.GBM.TabStop = False
        '
        'COMMANAGER
        '
        Me.COMMANAGER.Image = Global.BS_AIO_SYSTEM.My.Resources.Resources.emploi_commercial1_5
        Me.COMMANAGER.Location = New System.Drawing.Point(230, 270)
        Me.COMMANAGER.Name = "COMMANAGER"
        Me.COMMANAGER.Size = New System.Drawing.Size(130, 130)
        Me.COMMANAGER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.COMMANAGER.TabIndex = 1
        Me.COMMANAGER.TabStop = False
        '
        'OVER_SIGHT
        '
        Me.OVER_SIGHT.Image = Global.BS_AIO_SYSTEM.My.Resources.Resources.SUper
        Me.OVER_SIGHT.Location = New System.Drawing.Point(425, 91)
        Me.OVER_SIGHT.Name = "OVER_SIGHT"
        Me.OVER_SIGHT.Size = New System.Drawing.Size(130, 130)
        Me.OVER_SIGHT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OVER_SIGHT.TabIndex = 1
        Me.OVER_SIGHT.TabStop = False
        '
        'SETTING
        '
        Me.SETTING.Image = Global.BS_AIO_SYSTEM.My.Resources.Resources.parametre
        Me.SETTING.Location = New System.Drawing.Point(425, 469)
        Me.SETTING.Name = "SETTING"
        Me.SETTING.Size = New System.Drawing.Size(130, 130)
        Me.SETTING.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SETTING.TabIndex = 1
        Me.SETTING.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BS_AIO_SYSTEM.My.Resources.Resources.logo_rond
        Me.PictureBox1.Location = New System.Drawing.Point(388, 245)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MainController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 678)
        Me.Controls.Add(Me.GBM)
        Me.Controls.Add(Me.COMMANAGER)
        Me.Controls.Add(Me.OVER_SIGHT)
        Me.Controls.Add(Me.SETTING)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainController"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BS_OIA_SYSTEM"
        Me.TopMost = True
        CType(Me.GBM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMMANAGER, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OVER_SIGHT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SETTING, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SETTING As PictureBox
    Friend WithEvents COMMANAGER As PictureBox
    Friend WithEvents OVER_SIGHT As PictureBox
    Friend WithEvents GBM As PictureBox
    Friend WithEvents TCHUKER As Timer
    Friend WithEvents notification As NotifyIcon
End Class
