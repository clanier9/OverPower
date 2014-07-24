Namespace My
    Partial Friend NotInheritable Class MySettings

        Private Sub MySettings_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded
            ' Call our method to change the connection string.
            SetConnectionString()
        End Sub

        Private Sub SetConnectionString()
            ' This uses the settings class to find it's own private storage for the setting. The other variables are marked read-only and thus cannot be changed.
            Me("OPCardsDataSetConnectionString") = ConnectionStringBuilder.BuildMyConnectionString()
        End Sub
    End Class

End Namespace
