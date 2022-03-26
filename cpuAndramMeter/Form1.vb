Public Class Form1

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'SET THE PERFORMANCE VALUE TO A PROGESSBAR
        pb_CPU.Value = pc_CPU.NextValue
        pb_RAM.Value = pc_RAM.NextValue
        'SET THE PROGRESS BAR VALUE TO THE LABEL TO KNOW WHAT IS THE PERCENTAGE OF THE PROCESS.
        lbl_cpu.Text = pb_CPU.Value & "%"
        lbl_ram.Text = pb_RAM.Value & "%"
    End Sub
 
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SET THE INTERVAL TO 500.
        Timer1.Interval = 500
        'START THE TIMER 
        Timer1.Start()

    End Sub
End Class
