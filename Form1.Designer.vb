<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNB = New System.Windows.Forms.Label()
        Me.txtNB = New System.Windows.Forms.TextBox()
        Me.lblHS = New System.Windows.Forms.Label()
        Me.txtHS = New System.Windows.Forms.TextBox()
        Me.lblJB = New System.Windows.Forms.Label()
        Me.txtJB = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnUlng = New System.Windows.Forms.Button()
        Me.lblTH = New System.Windows.Forms.Label()
        Me.lblDisk = New System.Windows.Forms.Label()
        Me.txtTB = New System.Windows.Forms.TextBox()
        Me.txtTH = New System.Windows.Forms.TextBox()
        Me.lblTB = New System.Windows.Forms.Label()
        Me.lblBNS = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.txtBNS = New System.Windows.Forms.TextBox()
        Me.txtDisk = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNB
        '
        Me.lblNB.AutoSize = True
        Me.lblNB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNB.Location = New System.Drawing.Point(76, 51)
        Me.lblNB.Name = "lblNB"
        Me.lblNB.Size = New System.Drawing.Size(95, 17)
        Me.lblNB.TabIndex = 0
        Me.lblNB.Text = "Nama Barang"
        '
        'txtNB
        '
        Me.txtNB.Location = New System.Drawing.Point(188, 51)
        Me.txtNB.Name = "txtNB"
        Me.txtNB.Size = New System.Drawing.Size(205, 20)
        Me.txtNB.TabIndex = 1
        '
        'lblHS
        '
        Me.lblHS.AutoSize = True
        Me.lblHS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHS.Location = New System.Drawing.Point(76, 82)
        Me.lblHS.Name = "lblHS"
        Me.lblHS.Size = New System.Drawing.Size(96, 17)
        Me.lblHS.TabIndex = 2
        Me.lblHS.Text = "Harga Satuan"
        '
        'txtHS
        '
        Me.txtHS.Location = New System.Drawing.Point(188, 82)
        Me.txtHS.Name = "txtHS"
        Me.txtHS.Size = New System.Drawing.Size(100, 20)
        Me.txtHS.TabIndex = 3
        '
        'lblJB
        '
        Me.lblJB.AutoSize = True
        Me.lblJB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJB.Location = New System.Drawing.Point(76, 114)
        Me.lblJB.Name = "lblJB"
        Me.lblJB.Size = New System.Drawing.Size(103, 17)
        Me.lblJB.TabIndex = 4
        Me.lblJB.Text = "Jumlah Barang"
        '
        'txtJB
        '
        Me.txtJB.Location = New System.Drawing.Point(188, 114)
        Me.txtJB.Name = "txtJB"
        Me.txtJB.Size = New System.Drawing.Size(100, 20)
        Me.txtJB.TabIndex = 5
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(129, 197)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(85, 31)
        Me.btnHitung.TabIndex = 6
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnUlng
        '
        Me.btnUlng.Location = New System.Drawing.Point(237, 197)
        Me.btnUlng.Name = "btnUlng"
        Me.btnUlng.Size = New System.Drawing.Size(80, 31)
        Me.btnUlng.TabIndex = 7
        Me.btnUlng.Text = "Ulang"
        Me.btnUlng.UseVisualStyleBackColor = True
        '
        'lblTH
        '
        Me.lblTH.AutoSize = True
        Me.lblTH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTH.Location = New System.Drawing.Point(76, 276)
        Me.lblTH.Name = "lblTH"
        Me.lblTH.Size = New System.Drawing.Size(83, 17)
        Me.lblTH.TabIndex = 8
        Me.lblTH.Text = "Total Harga"
        '
        'lblDisk
        '
        Me.lblDisk.AutoSize = True
        Me.lblDisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisk.Location = New System.Drawing.Point(76, 307)
        Me.lblDisk.Name = "lblDisk"
        Me.lblDisk.Size = New System.Drawing.Size(51, 17)
        Me.lblDisk.TabIndex = 9
        Me.lblDisk.Text = "Diskon"
        '
        'txtTB
        '
        Me.txtTB.Location = New System.Drawing.Point(188, 339)
        Me.txtTB.Name = "txtTB"
        Me.txtTB.Size = New System.Drawing.Size(142, 20)
        Me.txtTB.TabIndex = 10
        '
        'txtTH
        '
        Me.txtTH.Location = New System.Drawing.Point(188, 273)
        Me.txtTH.Name = "txtTH"
        Me.txtTH.Size = New System.Drawing.Size(142, 20)
        Me.txtTH.TabIndex = 11
        '
        'lblTB
        '
        Me.lblTB.AutoSize = True
        Me.lblTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTB.Location = New System.Drawing.Point(76, 339)
        Me.lblTB.Name = "lblTB"
        Me.lblTB.Size = New System.Drawing.Size(81, 17)
        Me.lblTB.TabIndex = 12
        Me.lblTB.Text = "Total Bayar"
        '
        'lblBNS
        '
        Me.lblBNS.AutoSize = True
        Me.lblBNS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBNS.Location = New System.Drawing.Point(76, 373)
        Me.lblBNS.Name = "lblBNS"
        Me.lblBNS.Size = New System.Drawing.Size(48, 17)
        Me.lblBNS.TabIndex = 13
        Me.lblBNS.Text = "Bonus"
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(188, 443)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(81, 31)
        Me.btnKeluar.TabIndex = 14
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'txtBNS
        '
        Me.txtBNS.Location = New System.Drawing.Point(188, 373)
        Me.txtBNS.Name = "txtBNS"
        Me.txtBNS.Size = New System.Drawing.Size(100, 20)
        Me.txtBNS.TabIndex = 15
        '
        'txtDisk
        '
        Me.txtDisk.Location = New System.Drawing.Point(188, 306)
        Me.txtDisk.Name = "txtDisk"
        Me.txtDisk.Size = New System.Drawing.Size(100, 20)
        Me.txtDisk.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 517)
        Me.Controls.Add(Me.txtDisk)
        Me.Controls.Add(Me.txtBNS)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.lblBNS)
        Me.Controls.Add(Me.lblTB)
        Me.Controls.Add(Me.txtTH)
        Me.Controls.Add(Me.txtTB)
        Me.Controls.Add(Me.lblDisk)
        Me.Controls.Add(Me.lblTH)
        Me.Controls.Add(Me.btnUlng)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtJB)
        Me.Controls.Add(Me.lblJB)
        Me.Controls.Add(Me.txtHS)
        Me.Controls.Add(Me.lblHS)
        Me.Controls.Add(Me.txtNB)
        Me.Controls.Add(Me.lblNB)
        Me.Name = "Form1"
        Me.Text = "PROGRAM BELANJA SEDERHANA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNB As Label
    Friend WithEvents txtNB As TextBox
    Friend WithEvents lblHS As Label
    Friend WithEvents txtHS As TextBox
    Friend WithEvents lblJB As Label
    Friend WithEvents txtJB As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnUlng As Button
    Friend WithEvents lblTH As Label
    Friend WithEvents lblDisk As Label
    Friend WithEvents txtTB As TextBox
    Friend WithEvents txtTH As TextBox
    Friend WithEvents lblTB As Label
    Friend WithEvents lblBNS As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtBNS As TextBox
    Friend WithEvents txtDisk As TextBox
End Class
