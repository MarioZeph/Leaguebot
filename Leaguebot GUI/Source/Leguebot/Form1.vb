Public Class Leaguebot
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Logo.Parent = HeaderBackground
        MainLabel.Parent = HeaderBackground
        SeparatorMain.Parent = HeaderBackground
        HotkeysLabel.Parent = HeaderBackground
        SeparatorHotkey.Parent = HeaderBackground
        ScriptsLabel.Parent = HeaderBackground
        SeparatorScripts.Parent = HeaderBackground
        SettingsLabel.Parent = HeaderBackground
        SeparatorSettings.Parent = HeaderBackground
        If SeparatorHotkey.Visible = False And SeparatorScripts.Visible = False And SeparatorSettings.Visible = False Then
            SeparatorMain.Visible = True
            MainLabel.ForeColor = Color.Red
            ConsoleBackground.Visible = True
            ConsoleLabel.Visible = True
            Console.Visible = True
            MainSettingsLabel.Visible = True
            SettingsDivider.Visible = True
            MainSettingsContainer.Visible = True
            AcceptQCheck.Visible = True
            StartLuaCheck.Visible = True
            ZoomHackCheck.Visible = True
            DisplayCheck.Visible = True
            SaveConsoleButton.Visible = True
            LBLogo.Visible = True
        End If
    End Sub
    Private Sub HotkeysLabel_Click(sender As Object, e As EventArgs) Handles HotkeysLabel.Click
        SeparatorMain.Visible = False
        SeparatorScripts.Visible = False
        SeparatorSettings.Visible = False
        MainLabel.ForeColor = Color.DarkRed
        ScriptsLabel.ForeColor = Color.DarkRed
        SettingsLabel.ForeColor = Color.DarkRed
        If SeparatorMain.Visible = False And SeparatorScripts.Visible = False And SeparatorSettings.Visible = False Then
            SeparatorHotkey.Visible = True
            HotkeysLabel.ForeColor = Color.Red
            ConsoleBackground.Visible = True
            ConsoleLabel.Visible = False
            Console.Visible = False
            MainSettingsLabel.Visible = False
            SettingsDivider.Visible = True
            MainSettingsContainer.Visible = True
            AcceptQCheck.Visible = False
            StartLuaCheck.Visible = False
            ZoomHackCheck.Visible = False
            DisplayCheck.Visible = False
            SaveConsoleButton.Visible = False
            LBLogo.Visible = True
            ChampHotkeyLabel.Visible = True
            HotkeyLabel.Visible = True
            TextLabel.Visible = True
            HK1Box.Visible = True
            TX1Box.Visible = True
            HK2Box.Visible = True
            TX2Box.Visible = True
            HK3Box.Visible = True
            TX3Box.Visible = True
            HK4Box.Visible = True
            TX4Box.Visible = True
            HK5Box.Visible = True
            TX5Box.Visible = True
            HK6Box.Visible = True
            TX6Box.Visible = True
            HK7Box.Visible = True
            TX7Box.Visible = True
            HotkeySettingsLabel.Visible = True
            LoadNameCheck.Visible = True
            SaveNameButton.Visible = True
            LoadNameButton.Visible = True
            LoadFileButton.Visible = True
            HelpButton.Visible = True
            MoreHKButton.Visible = True
            DisplaySettingsLabel.Visible = False
            EnemyDataLabel.Visible = False
            SummonerSpellsCheck.Visible = False
            QWECheck.Visible = False
            RCheck.Visible = False
            ArmorCheck.Visible = False
            APADCheck.Visible = False
            MRCheck.Visible = False
            HPCheck.Visible = False
            MinionHitsCheck.Visible = False
            SmoothAttacksCheck.Visible = False
            SideViewCheck.Visible = False
            HeroViewCheck.Visible = False
            ExtraInfoLabel.Visible = False
            ShowMiaCheck.Visible = False
            MyRangeCheck.Visible = False
            EnemyRangeCheck.Visible = False
            JungleTimers.Visible = False
            WardTimersCheck.Visible = False
            EnemyMarksCheck.Visible = False
            AlliesMarkCheck.Visible = False
            TowerRangesCheck.Visible = False
            MoreSettingsLabel.Visible = False
            ShowTargetCheck.Visible = False
            MaxDistCheck.Visible = False
            MaxDistBox.Visible = False
            FontSizeLabel.Visible = False
            FontSizeBox.Visible = False
            RangeListButton.Visible = False
            SaveSettingsButton.Visible = False
            GlobalScriptLabel.Visible = False
            GlobalTextBox.Visible = False
            ChampionScriptLabel.Visible = False
            ChampionSpecificTextBox.Visible = False
            ScriptSettingsLabel.Visible = False
            GlobalScriptCheck.Visible = False
            ChampionScriptCheck.Visible = False
            AddGlobalScriptButton.Visible = False
            ChampionProfileButton.Visible = False
        End If
    End Sub
    Private Sub MainLabel_Click(sender As Object, e As EventArgs) Handles MainLabel.Click
        SeparatorHotkey.Visible = False
        SeparatorScripts.Visible = False
        SeparatorSettings.Visible = False
        HotkeysLabel.ForeColor = Color.DarkRed
        ScriptsLabel.ForeColor = Color.DarkRed
        SettingsLabel.ForeColor = Color.DarkRed
        If SeparatorHotkey.Visible = False And SeparatorScripts.Visible = False And SeparatorSettings.Visible = False Then
            SeparatorMain.Visible = True
            MainLabel.ForeColor = Color.Red
            ConsoleBackground.Visible = True
            ConsoleLabel.Visible = True
            Console.Visible = True
            MainSettingsLabel.Visible = True
            SettingsDivider.Visible = True
            MainSettingsContainer.Visible = True
            AcceptQCheck.Visible = True
            StartLuaCheck.Visible = True
            ZoomHackCheck.Visible = True
            DisplayCheck.Visible = True
            SaveConsoleButton.Visible = True
            LBLogo.Visible = True
            ChampHotkeyLabel.Visible = False
            HotkeyLabel.Visible = False
            TextLabel.Visible = False
            HK1Box.Visible = False
            TX1Box.Visible = False
            HK2Box.Visible = False
            TX2Box.Visible = False
            HK3Box.Visible = False
            TX3Box.Visible = False
            HK4Box.Visible = False
            TX4Box.Visible = False
            HK5Box.Visible = False
            TX5Box.Visible = False
            HK6Box.Visible = False
            TX6Box.Visible = False
            HK7Box.Visible = False
            TX7Box.Visible = False
            HotkeySettingsLabel.Visible = False
            LoadNameCheck.Visible = False
            SaveNameButton.Visible = False
            LoadNameButton.Visible = False
            LoadFileButton.Visible = False
            HelpButton.Visible = False
            MoreHKButton.Visible = False
            DisplaySettingsLabel.Visible = False
            EnemyDataLabel.Visible = False
            SummonerSpellsCheck.Visible = False
            QWECheck.Visible = False
            RCheck.Visible = False
            ArmorCheck.Visible = False
            APADCheck.Visible = False
            MRCheck.Visible = False
            HPCheck.Visible = False
            MinionHitsCheck.Visible = False
            SmoothAttacksCheck.Visible = False
            SideViewCheck.Visible = False
            HeroViewCheck.Visible = False
            ExtraInfoLabel.Visible = False
            ShowMiaCheck.Visible = False
            MyRangeCheck.Visible = False
            EnemyRangeCheck.Visible = False
            JungleTimers.Visible = False
            WardTimersCheck.Visible = False
            EnemyMarksCheck.Visible = False
            AlliesMarkCheck.Visible = False
            TowerRangesCheck.Visible = False
            MoreSettingsLabel.Visible = False
            ShowTargetCheck.Visible = False
            MaxDistCheck.Visible = False
            MaxDistBox.Visible = False
            FontSizeLabel.Visible = False
            FontSizeBox.Visible = False
            RangeListButton.Visible = False
            SaveSettingsButton.Visible = False
            GlobalScriptLabel.Visible = False
            GlobalTextBox.Visible = False
            ChampionScriptLabel.Visible = False
            ChampionSpecificTextBox.Visible = False
            ScriptSettingsLabel.Visible = False
            GlobalScriptCheck.Visible = False
            ChampionScriptCheck.Visible = False
            AddGlobalScriptButton.Visible = False
            ChampionProfileButton.Visible = False
        End If
    End Sub
    Private Sub ScriptsLabel_Click(sender As Object, e As EventArgs) Handles ScriptsLabel.Click
        SeparatorMain.Visible = False
        SeparatorHotkey.Visible = False
        SeparatorSettings.Visible = False
        MainLabel.ForeColor = Color.DarkRed
        HotkeysLabel.ForeColor = Color.DarkRed
        SettingsLabel.ForeColor = Color.DarkRed
        If SeparatorMain.Visible = False And SeparatorHotkey.Visible = False And SeparatorSettings.Visible = False Then
            SeparatorScripts.Visible = True
            ScriptsLabel.ForeColor = Color.Red
            ConsoleBackground.Visible = True
            ConsoleLabel.Visible = False
            Console.Visible = False
            MainSettingsLabel.Visible = False
            SettingsDivider.Visible = True
            MainSettingsContainer.Visible = True
            AcceptQCheck.Visible = False
            StartLuaCheck.Visible = False
            ZoomHackCheck.Visible = False
            DisplayCheck.Visible = False
            SaveConsoleButton.Visible = False
            LBLogo.Visible = True
            ChampHotkeyLabel.Visible = False
            HotkeyLabel.Visible = False
            TextLabel.Visible = False
            HK1Box.Visible = False
            TX1Box.Visible = False
            HK2Box.Visible = False
            TX2Box.Visible = False
            HK3Box.Visible = False
            TX3Box.Visible = False
            HK4Box.Visible = False
            TX4Box.Visible = False
            HK5Box.Visible = False
            TX5Box.Visible = False
            HK6Box.Visible = False
            TX6Box.Visible = False
            HK7Box.Visible = False
            TX7Box.Visible = False
            HotkeySettingsLabel.Visible = False
            LoadNameCheck.Visible = False
            SaveNameButton.Visible = False
            LoadNameButton.Visible = False
            LoadFileButton.Visible = False
            HelpButton.Visible = False
            MoreHKButton.Visible = False
            DisplaySettingsLabel.Visible = False
            EnemyDataLabel.Visible = False
            SummonerSpellsCheck.Visible = False
            QWECheck.Visible = False
            RCheck.Visible = False
            ArmorCheck.Visible = False
            APADCheck.Visible = False
            MRCheck.Visible = False
            HPCheck.Visible = False
            MinionHitsCheck.Visible = False
            SmoothAttacksCheck.Visible = False
            SideViewCheck.Visible = False
            HeroViewCheck.Visible = False
            ExtraInfoLabel.Visible = False
            ShowMiaCheck.Visible = False
            MyRangeCheck.Visible = False
            EnemyRangeCheck.Visible = False
            JungleTimers.Visible = False
            WardTimersCheck.Visible = False
            EnemyMarksCheck.Visible = False
            AlliesMarkCheck.Visible = False
            TowerRangesCheck.Visible = False
            MoreSettingsLabel.Visible = False
            ShowTargetCheck.Visible = False
            MaxDistCheck.Visible = False
            MaxDistBox.Visible = False
            FontSizeLabel.Visible = False
            FontSizeBox.Visible = False
            RangeListButton.Visible = False
            SaveSettingsButton.Visible = False
            GlobalScriptLabel.Visible = True
            GlobalTextBox.Visible = True
            ChampionScriptLabel.Visible = True
            ChampionSpecificTextBox.Visible = True
            ScriptSettingsLabel.Visible = True
            GlobalScriptCheck.Visible = True
            ChampionScriptCheck.Visible = True
            AddGlobalScriptButton.Visible = True
            ChampionProfileButton.Visible = True
        End If
    End Sub
    Private Sub SettingsLabel_Click(sender As Object, e As EventArgs) Handles SettingsLabel.Click
        SeparatorMain.Visible = False
        SeparatorHotkey.Visible = False
        SeparatorScripts.Visible = False
        MainLabel.ForeColor = Color.DarkRed
        ScriptsLabel.ForeColor = Color.DarkRed
        HotkeysLabel.ForeColor = Color.DarkRed
        If SeparatorMain.Visible = False And SeparatorHotkey.Visible = False And SeparatorScripts.Visible = False Then
            SeparatorSettings.Visible = True
            SettingsLabel.ForeColor = Color.Red
            ConsoleBackground.Visible = True
            ConsoleLabel.Visible = False
            Console.Visible = False
            MainSettingsLabel.Visible = False
            SettingsDivider.Visible = True
            MainSettingsContainer.Visible = True
            AcceptQCheck.Visible = False
            StartLuaCheck.Visible = False
            ZoomHackCheck.Visible = False
            DisplayCheck.Visible = False
            SaveConsoleButton.Visible = False
            LBLogo.Visible = True
            ChampHotkeyLabel.Visible = False
            HotkeyLabel.Visible = False
            TextLabel.Visible = False
            HK1Box.Visible = False
            TX1Box.Visible = False
            HK2Box.Visible = False
            TX2Box.Visible = False
            HK3Box.Visible = False
            TX3Box.Visible = False
            HK4Box.Visible = False
            TX4Box.Visible = False
            HK5Box.Visible = False
            TX5Box.Visible = False
            HK6Box.Visible = False
            TX6Box.Visible = False
            HK7Box.Visible = False
            TX7Box.Visible = False
            HotkeySettingsLabel.Visible = False
            LoadNameCheck.Visible = False
            SaveNameButton.Visible = False
            LoadNameButton.Visible = False
            LoadFileButton.Visible = False
            HelpButton.Visible = False
            MoreHKButton.Visible = False
            DisplaySettingsLabel.Visible = True
            EnemyDataLabel.Visible = True
            SummonerSpellsCheck.Visible = True
            QWECheck.Visible = True
            RCheck.Visible = True
            ArmorCheck.Visible = True
            APADCheck.Visible = True
            MRCheck.Visible = True
            HPCheck.Visible = True
            MinionHitsCheck.Visible = True
            SmoothAttacksCheck.Visible = True
            SideViewCheck.Visible = True
            HeroViewCheck.Visible = True
            ExtraInfoLabel.Visible = True
            ShowMiaCheck.Visible = True
            MyRangeCheck.Visible = True
            EnemyRangeCheck.Visible = True
            JungleTimers.Visible = True
            WardTimersCheck.Visible = True
            EnemyMarksCheck.Visible = True
            AlliesMarkCheck.Visible = True
            TowerRangesCheck.Visible = True
            MoreSettingsLabel.Visible = True
            ShowTargetCheck.Visible = True
            MaxDistCheck.Visible = True
            MaxDistBox.Visible = True
            FontSizeLabel.Visible = True
            FontSizeBox.Visible = True
            RangeListButton.Visible = True
            SaveSettingsButton.Visible = True
            GlobalScriptLabel.Visible = False
            GlobalTextBox.Visible = False
            ChampionScriptLabel.Visible = False
            ChampionSpecificTextBox.Visible = False
            ScriptSettingsLabel.Visible = False
            GlobalScriptCheck.Visible = False
            ChampionScriptCheck.Visible = False
            AddGlobalScriptButton.Visible = False
            ChampionProfileButton.Visible = False
        End If
    End Sub
    Private Sub MainLabel_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainLabel.MouseHover
        If SeparatorMain.Visible = False Then
            MainLabel.ForeColor = Color.Red
        End If
    End Sub
    Private Sub MainLabel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MainLabel.MouseLeave
        If SeparatorMain.Visible = False Then
            MainLabel.ForeColor = Color.DarkRed
        End If
    End Sub
    Private Sub HotkeysLabel_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles HotkeysLabel.MouseHover
        If SeparatorHotkey.Visible = False Then
            HotkeysLabel.ForeColor = Color.Red
        End If
    End Sub
    Private Sub HotkeysLabel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles HotkeysLabel.MouseLeave
        If SeparatorHotkey.Visible = False Then
            HotkeysLabel.ForeColor = Color.DarkRed
        End If
    End Sub
    Private Sub ScriptsLabel_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles ScriptsLabel.MouseHover
        If SeparatorScripts.Visible = False Then
            ScriptsLabel.ForeColor = Color.Red
        End If
    End Sub
    Private Sub ScriptsLabel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ScriptsLabel.MouseLeave
        If SeparatorScripts.Visible = False Then
            ScriptsLabel.ForeColor = Color.DarkRed
        End If
    End Sub
    Private Sub SettingsLabel_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles SettingsLabel.MouseHover
        If SeparatorSettings.Visible = False Then
            SettingsLabel.ForeColor = Color.Red
        End If
    End Sub
    Private Sub SettingsLabel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SettingsLabel.MouseLeave
        If SeparatorSettings.Visible = False Then
            SettingsLabel.ForeColor = Color.DarkRed
        End If
    End Sub
End Class