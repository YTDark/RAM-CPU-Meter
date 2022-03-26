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
        Me.components = New System.ComponentModel.Container
        Me.Label1 = New System.Windows.Forms.Label
        Me.pb_CPU = New System.Windows.Forms.ProgressBar
        Me.pc_CPU = New System.Diagnostics.PerformanceCounter
        Me.pc_RAM = New System.Diagnostics.PerformanceCounter
        Me.pb_RAM = New System.Windows.Forms.ProgressBar
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_ram = New System.Windows.Forms.Label
        Me.lbl_cpu = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.pc_CPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pc_RAM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPU"
        '
        'pb_CPU
        '
        Me.pb_CPU.Location = New System.Drawing.Point(78, 71)
        Me.pb_CPU.Name = "pb_CPU"
        Me.pb_CPU.Size = New System.Drawing.Size(276, 21)
        Me.pb_CPU.TabIndex = 1
        '
        'pc_CPU
        '
        Me.pc_CPU.CategoryName = "Processor"
        Me.pc_CPU.CounterName = "% Processor Time"
        Me.pc_CPU.InstanceName = "_Total"
        '
        'pc_RAM
        '
        Me.pc_RAM.CategoryName = "Memory"
        Me.pc_RAM.CounterName = "% Committed Bytes In Use"
        '
        'pb_RAM
        '
        Me.pb_RAM.Location = New System.Drawing.Point(78, 98)
        Me.pb_RAM.Name = "pb_RAM"
        Me.pb_RAM.Size = New System.Drawing.Size(276, 21)
        Me.pb_RAM.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RAM"
        '
        'lbl_ram
        '
        Me.lbl_ram.AutoSize = True
        Me.lbl_ram.Location = New System.Drawing.Point(362, 104)
        Me.lbl_ram.Name = "lbl_ram"
        Me.lbl_ram.Size = New System.Drawing.Size(21, 12)
        Me.lbl_ram.TabIndex = 5
        Me.lbl_ram.Text = "0%"
        '
        'lbl_cpu
        '
        Me.lbl_cpu.AutoSize = True
        Me.lbl_cpu.Location = New System.Drawing.Point(362, 73)
        Me.lbl_cpu.Name = "lbl_cpu"
        Me.lbl_cpu.Size = New System.Drawing.Size(21, 12)
        Me.lbl_cpu.TabIndex = 4
        Me.lbl_cpu.Text = "0%"
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(218, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "RAM and CPU  Meter"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 156)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_ram)
        Me.Controls.Add(Me.lbl_cpu)
        Me.Controls.Add(Me.pb_RAM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pb_CPU)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pc_CPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pc_RAM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pb_CPU As System.Windows.Forms.ProgressBar
    Friend WithEvents pc_CPU As System.Diagnostics.PerformanceCounter
    Friend WithEvents pc_RAM As System.Diagnostics.PerformanceCounter
    Friend WithEvents pb_RAM As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_ram As System.Windows.Forms.Label
    Friend WithEvents lbl_cpu As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
