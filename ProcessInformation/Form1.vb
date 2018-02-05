Imports System.Management
Imports System.Text

Public Class Form1
    Friend memval As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stringBuilder As New StringBuilder()
        Dim sysSearch As New ManagementObjectSearcher("Select * FROM Win32_ComputerSystem")
        Dim sysInfo As New ManagementObject
        For Each sysInfo1 In sysSearch.Get()
            memval = (sysInfo1("totalphysicalmemory").ToString)
        Next
        For Each process As Process In Process.GetProcesses()
            Try
                If (process.MainWindowTitle.Length > 0) Then
                    ListBox1.Items.Add((process.ProcessName.ToString))
                End If
            Catch ex As Exception
                MsgBox("Error: " + ex.Message)
            End Try
        Next
    End Sub

    Private Sub updateText(sender As Object, e As EventArgs) Handles ListBox1.Click
        refreshInfo()
    End Sub

    Private Sub refresh_Click(sender As Object, e As EventArgs) Handles refresh.Click
        ListBox1.Items.Clear()
        For Each process As Process In Process.GetProcesses()
            Try
                If (process.MainWindowTitle.Length > 0) Then
                    ListBox1.Items.Add((process.ProcessName.ToString))
                End If
            Catch ex As Exception
                MsgBox("Error: " + ex.Message)
            End Try
        Next
    End Sub

    Private Sub murderTask_Click(sender As Object, e As EventArgs) Handles murderTask.Click
        Try
            For Each process As Process In Process.GetProcessesByName(ListBox1.Items.Item(ListBox1.SelectedIndex))
                process.Kill()
            Next
        Catch ex As Exception
        End Try
        refreshList()
        refreshInfo()
    End Sub

    Friend Function refreshList()
        ListBox1.Items.Clear()
        For Each process As Process In Process.GetProcesses()
            Try
                If (process.MainWindowTitle.Length > 0) Then
                    ListBox1.Items.Add((process.ProcessName.ToString))
                End If
            Catch ex As Exception
                MsgBox("Error: " + ex.Message)
            End Try
        Next
    End Function

    Friend Function refreshInfo()
        windowTitle.Text = "Window Title: "
        processorName.Text = "Process Name: "
        totalProcessorTime.Text = "Total Processor Time: "
        memoryUsage.Text = "Memory Usage: "
        memoryUsageAsPercent.Text = "Memory Usage As A Percent: "
        vmSize.Text = "virtual Memory Size: "
        priorityBoostStat.Text = "Priority Boost Status: "
        priorityClass.Text = "Priority Class: "
        processorAffinity.Text = "Processor Affinity: "
        threads.Text = "Threads: "
        Try
            For Each process As Process In Process.GetProcessesByName(ListBox1.Items.Item(ListBox1.SelectedIndex))
                windowTitle.Text = "Window Title: " + process.MainWindowTitle
                processorName.Text = "Process Name: " + process.ProcessName
                totalProcessorTime.Text = "Total Processor Time: " + process.TotalProcessorTime.ToString
                memoryUsage.Text = "Memory Usage: " + (process.WorkingSet64 / 1000000).ToString + "MB"
                memoryUsageAsPercent.Text = "Memory Usage As A Percent: " + (Math.Round(((process.WorkingSet64) / memval * 100), 2)).ToString + "%"
                vmSize.Text = "virtual Memory Size: " + Math.Round(process.VirtualMemorySize64 / 1000000, 2).ToString + "MB"
                priorityBoostStat.Text = "Priority Boost Status: " + process.PriorityBoostEnabled.ToString
                priorityClass.Text = "Priority Class: " + process.PriorityClass.ToString
                processorAffinity.Text = "Processor Affinity: " + process.ProcessorAffinity.ToString
                threads.Text = "Threads: " + process.Threads.ToString
            Next
        Catch ex As Exception

        End Try
    End Function

    Private Sub priorityStatusTrue_Click(sender As Object, e As EventArgs) Handles priorityStatusTrue.Click

        refreshList()
        refreshInfo()
    End Sub

    Private Sub priorityStatusFalse_Click(sender As Object, e As EventArgs) Handles priorityStatusFalse.Click

        refreshList()
        refreshInfo()
    End Sub

    Private Sub lowPriority_Click(sender As Object, e As EventArgs) Handles lowPriority.Click

        refreshList()
        refreshInfo()
    End Sub

    Private Sub belNormPriority_Click(sender As Object, e As EventArgs) Handles belNormPriority.Click

        refreshList()
        refreshInfo()
    End Sub

    Private Sub normPriority_Click(sender As Object, e As EventArgs) Handles normPriority.Click

        refreshList()
        refreshInfo()
    End Sub

    Private Sub aboveNormPriority_Click(sender As Object, e As EventArgs) Handles aboveNormPriority.Click

        refreshList()
        refreshInfo()
    End Sub

    Private Sub highPriority_Click(sender As Object, e As EventArgs) Handles highPriority.Click

        refreshList()
        refreshInfo()
    End Sub
End Class
