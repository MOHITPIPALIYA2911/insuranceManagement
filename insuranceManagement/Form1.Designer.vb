<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnshowag = New System.Windows.Forms.Button()
        Me.btnags = New System.Windows.Forms.Button()
        Me.btnagd = New System.Windows.Forms.Button()
        Me.btnagu = New System.Windows.Forms.Button()
        Me.btnagi = New System.Windows.Forms.Button()
        Me.labl = New System.Windows.Forms.Label()
        Me.txtac = New System.Windows.Forms.TextBox()
        Me.lab = New System.Windows.Forms.Label()
        Me.txtaan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtaac = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnpos = New System.Windows.Forms.Button()
        Me.btnpou = New System.Windows.Forms.Button()
        Me.lll = New System.Windows.Forms.Label()
        Me.btnpod = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtpsd = New System.Windows.Forms.TextBox()
        Me.txtppa = New System.Windows.Forms.TextBox()
        Me.txtped = New System.Windows.Forms.TextBox()
        Me.ljl = New System.Windows.Forms.Label()
        Me.btnpoi = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.l = New System.Windows.Forms.Label()
        Me.txtppn = New System.Windows.Forms.TextBox()
        Me.txtpcn = New System.Windows.Forms.TextBox()
        Me.txtpac = New System.Windows.Forms.TextBox()
        Me.ll = New System.Windows.Forms.Label()
        Me.btnq2 = New System.Windows.Forms.Button()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.btnq1 = New System.Windows.Forms.Button()
        Me.btnshowpo = New System.Windows.Forms.Button()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView
        '
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridView.Location = New System.Drawing.Point(0, 249)
        Me.GridView.Name = "GridView"
        Me.GridView.RowTemplate.Height = 25
        Me.GridView.Size = New System.Drawing.Size(800, 201)
        Me.GridView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(259, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Insurance Management"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnshowag)
        Me.GroupBox1.Controls.Add(Me.btnags)
        Me.GroupBox1.Controls.Add(Me.btnagd)
        Me.GroupBox1.Controls.Add(Me.btnagu)
        Me.GroupBox1.Controls.Add(Me.btnagi)
        Me.GroupBox1.Controls.Add(Me.labl)
        Me.GroupBox1.Controls.Add(Me.txtac)
        Me.GroupBox1.Controls.Add(Me.lab)
        Me.GroupBox1.Controls.Add(Me.txtaan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtaac)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 193)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agent master"
        '
        'btnshowag
        '
        Me.btnshowag.Location = New System.Drawing.Point(78, 166)
        Me.btnshowag.Name = "btnshowag"
        Me.btnshowag.Size = New System.Drawing.Size(98, 23)
        Me.btnshowag.TabIndex = 17
        Me.btnshowag.Text = "Show"
        Me.btnshowag.UseVisualStyleBackColor = True
        '
        'btnags
        '
        Me.btnags.Location = New System.Drawing.Point(132, 138)
        Me.btnags.Name = "btnags"
        Me.btnags.Size = New System.Drawing.Size(98, 23)
        Me.btnags.TabIndex = 16
        Me.btnags.Text = "Search"
        Me.btnags.UseVisualStyleBackColor = True
        '
        'btnagd
        '
        Me.btnagd.Location = New System.Drawing.Point(28, 138)
        Me.btnagd.Name = "btnagd"
        Me.btnagd.Size = New System.Drawing.Size(98, 23)
        Me.btnagd.TabIndex = 15
        Me.btnagd.Text = "Delete"
        Me.btnagd.UseVisualStyleBackColor = True
        '
        'btnagu
        '
        Me.btnagu.Location = New System.Drawing.Point(132, 109)
        Me.btnagu.Name = "btnagu"
        Me.btnagu.Size = New System.Drawing.Size(98, 23)
        Me.btnagu.TabIndex = 14
        Me.btnagu.Text = "Update"
        Me.btnagu.UseVisualStyleBackColor = True
        '
        'btnagi
        '
        Me.btnagi.Location = New System.Drawing.Point(28, 109)
        Me.btnagi.Name = "btnagi"
        Me.btnagi.Size = New System.Drawing.Size(98, 23)
        Me.btnagi.TabIndex = 6
        Me.btnagi.Text = "Insert"
        Me.btnagi.UseVisualStyleBackColor = True
        '
        'labl
        '
        Me.labl.AutoSize = True
        Me.labl.Location = New System.Drawing.Point(20, 83)
        Me.labl.Name = "labl"
        Me.labl.Size = New System.Drawing.Size(28, 15)
        Me.labl.TabIndex = 5
        Me.labl.Text = "City"
        '
        'txtac
        '
        Me.txtac.Location = New System.Drawing.Point(102, 80)
        Me.txtac.Name = "txtac"
        Me.txtac.Size = New System.Drawing.Size(140, 23)
        Me.txtac.TabIndex = 4
        '
        'lab
        '
        Me.lab.AutoSize = True
        Me.lab.Location = New System.Drawing.Point(20, 54)
        Me.lab.Name = "lab"
        Me.lab.Size = New System.Drawing.Size(72, 15)
        Me.lab.TabIndex = 3
        Me.lab.Text = "Agent name"
        '
        'txtaan
        '
        Me.txtaan.Location = New System.Drawing.Point(102, 51)
        Me.txtaan.Name = "txtaan"
        Me.txtaan.Size = New System.Drawing.Size(140, 23)
        Me.txtaan.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Agent code"
        '
        'txtaac
        '
        Me.txtaac.Location = New System.Drawing.Point(102, 22)
        Me.txtaac.Name = "txtaac"
        Me.txtaac.Size = New System.Drawing.Size(140, 23)
        Me.txtaac.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnpos)
        Me.GroupBox2.Controls.Add(Me.btnpou)
        Me.GroupBox2.Controls.Add(Me.lll)
        Me.GroupBox2.Controls.Add(Me.btnpod)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtpsd)
        Me.GroupBox2.Controls.Add(Me.txtppa)
        Me.GroupBox2.Controls.Add(Me.txtped)
        Me.GroupBox2.Controls.Add(Me.ljl)
        Me.GroupBox2.Controls.Add(Me.btnpoi)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.l)
        Me.GroupBox2.Controls.Add(Me.txtppn)
        Me.GroupBox2.Controls.Add(Me.txtpcn)
        Me.GroupBox2.Controls.Add(Me.txtpac)
        Me.GroupBox2.Controls.Add(Me.ll)
        Me.GroupBox2.Location = New System.Drawing.Point(285, 57)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 157)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Policy master"
        '
        'btnpos
        '
        Me.btnpos.Location = New System.Drawing.Point(304, 118)
        Me.btnpos.Name = "btnpos"
        Me.btnpos.Size = New System.Drawing.Size(90, 23)
        Me.btnpos.TabIndex = 21
        Me.btnpos.Text = "Search"
        Me.btnpos.UseVisualStyleBackColor = True
        '
        'btnpou
        '
        Me.btnpou.Location = New System.Drawing.Point(106, 118)
        Me.btnpou.Name = "btnpou"
        Me.btnpou.Size = New System.Drawing.Size(90, 23)
        Me.btnpou.TabIndex = 20
        Me.btnpou.Text = "Update"
        Me.btnpou.UseVisualStyleBackColor = True
        '
        'lll
        '
        Me.lll.AutoSize = True
        Me.lll.Location = New System.Drawing.Point(272, 25)
        Me.lll.Name = "lll"
        Me.lll.Size = New System.Drawing.Size(57, 15)
        Me.lll.TabIndex = 15
        Me.lll.Text = "Start date"
        '
        'btnpod
        '
        Me.btnpod.Location = New System.Drawing.Point(205, 118)
        Me.btnpod.Name = "btnpod"
        Me.btnpod.Size = New System.Drawing.Size(90, 23)
        Me.btnpod.TabIndex = 20
        Me.btnpod.Text = "Delete"
        Me.btnpod.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(272, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Policy amt."
        '
        'txtpsd
        '
        Me.txtpsd.Location = New System.Drawing.Point(343, 22)
        Me.txtpsd.Name = "txtpsd"
        Me.txtpsd.Size = New System.Drawing.Size(140, 23)
        Me.txtpsd.TabIndex = 14
        '
        'txtppa
        '
        Me.txtppa.Location = New System.Drawing.Point(343, 80)
        Me.txtppa.Name = "txtppa"
        Me.txtppa.Size = New System.Drawing.Size(140, 23)
        Me.txtppa.TabIndex = 18
        '
        'txtped
        '
        Me.txtped.Location = New System.Drawing.Point(343, 51)
        Me.txtped.Name = "txtped"
        Me.txtped.Size = New System.Drawing.Size(140, 23)
        Me.txtped.TabIndex = 16
        '
        'ljl
        '
        Me.ljl.AutoSize = True
        Me.ljl.Location = New System.Drawing.Point(272, 54)
        Me.ljl.Name = "ljl"
        Me.ljl.Size = New System.Drawing.Size(53, 15)
        Me.ljl.TabIndex = 17
        Me.ljl.Text = "End date"
        '
        'btnpoi
        '
        Me.btnpoi.Location = New System.Drawing.Point(7, 118)
        Me.btnpoi.Name = "btnpoi"
        Me.btnpoi.Size = New System.Drawing.Size(90, 23)
        Me.btnpoi.TabIndex = 13
        Me.btnpoi.Text = "Insert"
        Me.btnpoi.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Policy no."
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Location = New System.Drawing.Point(16, 83)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(87, 15)
        Me.l.TabIndex = 12
        Me.l.Text = "Cutomer name"
        '
        'txtppn
        '
        Me.txtppn.Location = New System.Drawing.Point(110, 22)
        Me.txtppn.Name = "txtppn"
        Me.txtppn.Size = New System.Drawing.Size(140, 23)
        Me.txtppn.TabIndex = 7
        '
        'txtpcn
        '
        Me.txtpcn.Location = New System.Drawing.Point(110, 80)
        Me.txtpcn.Name = "txtpcn"
        Me.txtpcn.Size = New System.Drawing.Size(140, 23)
        Me.txtpcn.TabIndex = 11
        '
        'txtpac
        '
        Me.txtpac.Location = New System.Drawing.Point(110, 51)
        Me.txtpac.Name = "txtpac"
        Me.txtpac.Size = New System.Drawing.Size(140, 23)
        Me.txtpac.TabIndex = 9
        '
        'll
        '
        Me.ll.AutoSize = True
        Me.ll.Location = New System.Drawing.Point(16, 54)
        Me.ll.Name = "ll"
        Me.ll.Size = New System.Drawing.Size(68, 15)
        Me.ll.TabIndex = 10
        Me.ll.Text = "Agent code"
        '
        'btnq2
        '
        Me.btnq2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnq2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnq2.Location = New System.Drawing.Point(639, 220)
        Me.btnq2.Name = "btnq2"
        Me.btnq2.Size = New System.Drawing.Size(146, 23)
        Me.btnq2.TabIndex = 22
        Me.btnq2.Text = "Query 2"
        Me.btnq2.UseVisualStyleBackColor = False
        '
        'btnshow
        '
        Me.btnshow.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnshow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnshow.Location = New System.Drawing.Point(285, 219)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(146, 23)
        Me.btnshow.TabIndex = 23
        Me.btnshow.Text = "Show all"
        Me.btnshow.UseVisualStyleBackColor = False
        '
        'btnq1
        '
        Me.btnq1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnq1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnq1.Location = New System.Drawing.Point(462, 219)
        Me.btnq1.Name = "btnq1"
        Me.btnq1.Size = New System.Drawing.Size(146, 23)
        Me.btnq1.TabIndex = 24
        Me.btnq1.Text = "Query 1"
        Me.btnq1.UseVisualStyleBackColor = False
        '
        'btnshowpo
        '
        Me.btnshowpo.Location = New System.Drawing.Point(689, 175)
        Me.btnshowpo.Name = "btnshowpo"
        Me.btnshowpo.Size = New System.Drawing.Size(90, 23)
        Me.btnshowpo.TabIndex = 18
        Me.btnshowpo.Text = "Show"
        Me.btnshowpo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnshowpo)
        Me.Controls.Add(Me.btnq1)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.btnq2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridView)
        Me.Name = "Form1"
        Me.Text = "Insurance Info"
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnagi As Button
    Friend WithEvents labl As Label
    Friend WithEvents txtac As TextBox
    Friend WithEvents lab As Label
    Friend WithEvents txtaan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtaac As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnpoi As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents l As Label
    Friend WithEvents txtppn As TextBox
    Friend WithEvents txtpcn As TextBox
    Friend WithEvents txtpac As TextBox
    Friend WithEvents ll As Label
    Friend WithEvents lll As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtpsd As TextBox
    Friend WithEvents txtppa As TextBox
    Friend WithEvents txtped As TextBox
    Friend WithEvents ljl As Label
    Friend WithEvents btnpod As Button
    Friend WithEvents btnq2 As Button
    Friend WithEvents btnagd As Button
    Friend WithEvents btnagu As Button
    Friend WithEvents btnpou As Button
    Friend WithEvents btnags As Button
    Friend WithEvents btnpos As Button
    Friend WithEvents btnshow As Button
    Friend WithEvents btnq1 As Button
    Friend WithEvents btnshowag As Button
    Friend WithEvents btnshowpo As Button
End Class
