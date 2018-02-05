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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.windowTitle = New System.Windows.Forms.Label()
        Me.processorName = New System.Windows.Forms.Label()
        Me.totalProcessorTime = New System.Windows.Forms.Label()
        Me.memoryUsage = New System.Windows.Forms.Label()
        Me.memoryUsageAsPercent = New System.Windows.Forms.Label()
        Me.vmSize = New System.Windows.Forms.Label()
        Me.priorityBoostStat = New System.Windows.Forms.Label()
        Me.priorityClass = New System.Windows.Forms.Label()
        Me.processorAffinity = New System.Windows.Forms.Label()
        Me.threads = New System.Windows.Forms.Label()
        Me.priorityStatusTrue = New System.Windows.Forms.Button()
        Me.priorityStatusFalse = New System.Windows.Forms.Button()
        Me.setLabel1 = New System.Windows.Forms.Label()
        Me.refresh = New System.Windows.Forms.Button()
        Me.setLabel2 = New System.Windows.Forms.Label()
        Me.lowPriority = New System.Windows.Forms.Button()
        Me.belNormPriority = New System.Windows.Forms.Button()
        Me.normPriority = New System.Windows.Forms.Button()
        Me.aboveNormPriority = New System.Windows.Forms.Button()
        Me.highPriority = New System.Windows.Forms.Button()
        Me.murderTask = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 41)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(268, 160)
        Me.ListBox1.TabIndex = 0
        '
        'windowTitle
        '
        Me.windowTitle.AutoSize = True
        Me.windowTitle.Location = New System.Drawing.Point(286, 41)
        Me.windowTitle.Name = "windowTitle"
        Me.windowTitle.Size = New System.Drawing.Size(75, 13)
        Me.windowTitle.TabIndex = 2
        Me.windowTitle.Text = "Window Title: "
        '
        'processorName
        '
        Me.processorName.AutoSize = True
        Me.processorName.Location = New System.Drawing.Point(286, 56)
        Me.processorName.Name = "processorName"
        Me.processorName.Size = New System.Drawing.Size(79, 13)
        Me.processorName.TabIndex = 3
        Me.processorName.Text = "Process Name:"
        '
        'totalProcessorTime
        '
        Me.totalProcessorTime.AutoSize = True
        Me.totalProcessorTime.Location = New System.Drawing.Point(286, 71)
        Me.totalProcessorTime.Name = "totalProcessorTime"
        Me.totalProcessorTime.Size = New System.Drawing.Size(110, 13)
        Me.totalProcessorTime.TabIndex = 4
        Me.totalProcessorTime.Text = "Total Processor Time:"
        '
        'memoryUsage
        '
        Me.memoryUsage.AutoSize = True
        Me.memoryUsage.Location = New System.Drawing.Point(286, 86)
        Me.memoryUsage.Name = "memoryUsage"
        Me.memoryUsage.Size = New System.Drawing.Size(81, 13)
        Me.memoryUsage.TabIndex = 5
        Me.memoryUsage.Text = "Memory Usage:"
        '
        'memoryUsageAsPercent
        '
        Me.memoryUsageAsPercent.AutoSize = True
        Me.memoryUsageAsPercent.Location = New System.Drawing.Point(286, 101)
        Me.memoryUsageAsPercent.Name = "memoryUsageAsPercent"
        Me.memoryUsageAsPercent.Size = New System.Drawing.Size(167, 13)
        Me.memoryUsageAsPercent.TabIndex = 6
        Me.memoryUsageAsPercent.Text = "Memory Usage As A Percentage: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'vmSize
        '
        Me.vmSize.AutoSize = True
        Me.vmSize.Location = New System.Drawing.Point(286, 116)
        Me.vmSize.Name = "vmSize"
        Me.vmSize.Size = New System.Drawing.Size(105, 13)
        Me.vmSize.TabIndex = 7
        Me.vmSize.Text = "Virtual Memory Size: "
        '
        'priorityBoostStat
        '
        Me.priorityBoostStat.AutoSize = True
        Me.priorityBoostStat.Location = New System.Drawing.Point(286, 131)
        Me.priorityBoostStat.Name = "priorityBoostStat"
        Me.priorityBoostStat.Size = New System.Drawing.Size(104, 13)
        Me.priorityBoostStat.TabIndex = 8
        Me.priorityBoostStat.Text = "Priority Boost Status:"
        '
        'priorityClass
        '
        Me.priorityClass.AutoSize = True
        Me.priorityClass.Location = New System.Drawing.Point(286, 146)
        Me.priorityClass.Name = "priorityClass"
        Me.priorityClass.Size = New System.Drawing.Size(69, 13)
        Me.priorityClass.TabIndex = 9
        Me.priorityClass.Text = "Priority Class:"
        '
        'processorAffinity
        '
        Me.processorAffinity.AutoSize = True
        Me.processorAffinity.Location = New System.Drawing.Point(286, 161)
        Me.processorAffinity.Name = "processorAffinity"
        Me.processorAffinity.Size = New System.Drawing.Size(94, 13)
        Me.processorAffinity.TabIndex = 10
        Me.processorAffinity.Text = "Processor Affinity: "
        '
        'threads
        '
        Me.threads.AutoSize = True
        Me.threads.Location = New System.Drawing.Point(286, 176)
        Me.threads.Name = "threads"
        Me.threads.Size = New System.Drawing.Size(52, 13)
        Me.threads.TabIndex = 11
        Me.threads.Text = "Threads: "
        '
        'priorityStatusTrue
        '
        Me.priorityStatusTrue.Location = New System.Drawing.Point(600, 25)
        Me.priorityStatusTrue.Name = "priorityStatusTrue"
        Me.priorityStatusTrue.Size = New System.Drawing.Size(86, 23)
        Me.priorityStatusTrue.TabIndex = 13
        Me.priorityStatusTrue.Text = "True"
        Me.priorityStatusTrue.UseVisualStyleBackColor = True
        '
        'priorityStatusFalse
        '
        Me.priorityStatusFalse.Location = New System.Drawing.Point(686, 25)
        Me.priorityStatusFalse.Name = "priorityStatusFalse"
        Me.priorityStatusFalse.Size = New System.Drawing.Size(86, 23)
        Me.priorityStatusFalse.TabIndex = 14
        Me.priorityStatusFalse.Text = "False"
        Me.priorityStatusFalse.UseVisualStyleBackColor = True
        '
        'setLabel1
        '
        Me.setLabel1.AutoSize = True
        Me.setLabel1.Location = New System.Drawing.Point(600, 9)
        Me.setLabel1.Name = "setLabel1"
        Me.setLabel1.Size = New System.Drawing.Size(123, 13)
        Me.setLabel1.TabIndex = 15
        Me.setLabel1.Text = "Set Priority Boost Status:"
        '
        'refresh
        '
        Me.refresh.Location = New System.Drawing.Point(12, 12)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(268, 23)
        Me.refresh.TabIndex = 16
        Me.refresh.Text = "Refresh"
        Me.refresh.UseVisualStyleBackColor = True
        '
        'setLabel2
        '
        Me.setLabel2.AutoSize = True
        Me.setLabel2.Location = New System.Drawing.Point(600, 61)
        Me.setLabel2.Name = "setLabel2"
        Me.setLabel2.Size = New System.Drawing.Size(91, 13)
        Me.setLabel2.TabIndex = 17
        Me.setLabel2.Text = "Set Priority Class: "
        '
        'lowPriority
        '
        Me.lowPriority.Location = New System.Drawing.Point(600, 77)
        Me.lowPriority.Name = "lowPriority"
        Me.lowPriority.Size = New System.Drawing.Size(86, 23)
        Me.lowPriority.TabIndex = 18
        Me.lowPriority.Text = "Low"
        Me.lowPriority.UseVisualStyleBackColor = True
        '
        'belNormPriority
        '
        Me.belNormPriority.Location = New System.Drawing.Point(686, 77)
        Me.belNormPriority.Name = "belNormPriority"
        Me.belNormPriority.Size = New System.Drawing.Size(86, 23)
        Me.belNormPriority.TabIndex = 19
        Me.belNormPriority.Text = "Below Normal"
        Me.belNormPriority.UseVisualStyleBackColor = True
        '
        'normPriority
        '
        Me.normPriority.Location = New System.Drawing.Point(600, 106)
        Me.normPriority.Name = "normPriority"
        Me.normPriority.Size = New System.Drawing.Size(86, 23)
        Me.normPriority.TabIndex = 20
        Me.normPriority.Text = "Normal"
        Me.normPriority.UseVisualStyleBackColor = True
        '
        'aboveNormPriority
        '
        Me.aboveNormPriority.Location = New System.Drawing.Point(686, 106)
        Me.aboveNormPriority.Name = "aboveNormPriority"
        Me.aboveNormPriority.Size = New System.Drawing.Size(86, 23)
        Me.aboveNormPriority.TabIndex = 21
        Me.aboveNormPriority.Text = "Above Normal"
        Me.aboveNormPriority.UseVisualStyleBackColor = True
        '
        'highPriority
        '
        Me.highPriority.Location = New System.Drawing.Point(600, 135)
        Me.highPriority.Name = "highPriority"
        Me.highPriority.Size = New System.Drawing.Size(172, 23)
        Me.highPriority.TabIndex = 22
        Me.highPriority.Text = "High"
        Me.highPriority.UseVisualStyleBackColor = True
        '
        'murderTask
        '
        Me.murderTask.Location = New System.Drawing.Point(600, 178)
        Me.murderTask.Name = "murderTask"
        Me.murderTask.Size = New System.Drawing.Size(172, 23)
        Me.murderTask.TabIndex = 23
        Me.murderTask.Text = "Kill Task"
        Me.murderTask.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(784, 211)
        Me.Controls.Add(Me.murderTask)
        Me.Controls.Add(Me.highPriority)
        Me.Controls.Add(Me.aboveNormPriority)
        Me.Controls.Add(Me.normPriority)
        Me.Controls.Add(Me.belNormPriority)
        Me.Controls.Add(Me.lowPriority)
        Me.Controls.Add(Me.setLabel2)
        Me.Controls.Add(Me.refresh)
        Me.Controls.Add(Me.setLabel1)
        Me.Controls.Add(Me.priorityStatusFalse)
        Me.Controls.Add(Me.priorityStatusTrue)
        Me.Controls.Add(Me.threads)
        Me.Controls.Add(Me.processorAffinity)
        Me.Controls.Add(Me.priorityClass)
        Me.Controls.Add(Me.priorityBoostStat)
        Me.Controls.Add(Me.vmSize)
        Me.Controls.Add(Me.memoryUsageAsPercent)
        Me.Controls.Add(Me.memoryUsage)
        Me.Controls.Add(Me.totalProcessorTime)
        Me.Controls.Add(Me.processorName)
        Me.Controls.Add(Me.windowTitle)
        Me.Controls.Add(Me.ListBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 250)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 250)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Application Boost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents windowTitle As Label
    Friend WithEvents processorName As Label
    Friend WithEvents totalProcessorTime As Label
    Friend WithEvents memoryUsage As Label
    Friend WithEvents memoryUsageAsPercent As Label
    Friend WithEvents vmSize As Label
    Friend WithEvents priorityBoostStat As Label
    Friend WithEvents priorityClass As Label
    Friend WithEvents processorAffinity As Label
    Friend WithEvents threads As Label
    Friend WithEvents priorityStatusTrue As Button
    Friend WithEvents priorityStatusFalse As Button
    Friend WithEvents setLabel1 As Label
    Friend WithEvents refresh As Button
    Friend WithEvents setLabel2 As Label
    Friend WithEvents lowPriority As Button
    Friend WithEvents belNormPriority As Button
    Friend WithEvents normPriority As Button
    Friend WithEvents aboveNormPriority As Button
    Friend WithEvents highPriority As Button
    Friend WithEvents murderTask As Button
End Class
