Public Class AdbHelper

    Private Shared AdbExec As String = _
        IIf(My.Computer.Info.OSFullName.ToLower() _
            .Contains("unix"), "prebuilts/linux/adb/adb", "prebuilts\adb\adb.exe").ToString()

    Public Shared Function ExecuteAdbCommand(command As String) As String
        Console.WriteLine("Executing command 'adb " & command & "'...")
        Dim p As New ProcessStartInfo

        p.FileName  = AdbExec
        p.Arguments = command

        ' Don't show a window!
        p.WindowStyle = ProcessWindowStyle.Hidden
        p.CreateNoWindow = True

        ' Prepare to catch up the output
        p.RedirectStandardOutput = True
        p.UseShellExecute = False

        ' Start the process
        Dim proc As New Process()
        proc.StartInfo = p
        proc.Start()

        Dim result As String = proc.StandardOutput.ReadToEnd()
        Console.WriteLine(result)
        Debug.WriteLine(result)
        proc.WaitForExit()
        Return result
    End Function

End Class
