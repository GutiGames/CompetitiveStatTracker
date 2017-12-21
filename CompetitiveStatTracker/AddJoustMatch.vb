Public Class AddJoustMatch
    Private Sub AddJoustMatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.JoustMatches' Puede moverla o quitarla según sea necesario.
        Me.JoustMatchesTableAdapter.Fill(Me.SmiteDataSet.JoustMatches)
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.JoustPicks' Puede moverla o quitarla según sea necesario.
        Me.JoustPicksTableAdapter.Fill(Me.SmiteDataSet.JoustPicks)
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.JoustBans' Puede moverla o quitarla según sea necesario.
        Me.JoustBansTableAdapter.Fill(Me.SmiteDataSet.JoustBans)
        'TODO: esta línea de código carga datos en la tabla 'SmiteDataSet.Gods' Puede moverla o quitarla según sea necesario.
        Me.GodsTableAdapter.Fill(Me.SmiteDataSet.Gods)

        Dim LastInsert As Integer
        LastInsert = Me.JoustMatchesTableAdapter.LastInsert()



    End Sub

    Private Sub God1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles God1.SelectedIndexChanged


        Dim Sel1 As Integer

        Sel1 = God1.SelectedValue

        If Sel1 = 1 Then

            PictureBox1.Image = My.Resources.GodCards.Agni
        ElseIf Sel1 = 2 Then

            PictureBox1.Image = My.Resources.GodCards.Anubis
        ElseIf Sel1 = 3 Then

            PictureBox1.Image = My.Resources.GodCards.Arachne
        ElseIf Sel1 = 4 Then

            PictureBox1.Image = My.Resources.GodCards.Artemis
        ElseIf Sel1 = 5 Then

            PictureBox1.Image = My.Resources.GodCards.Bastet
        ElseIf Sel1 = 6 Then

            PictureBox1.Image = My.Resources.GodCards.Hades
        ElseIf Sel1 = 7 Then

            PictureBox1.Image = My.Resources.GodCards.HeBo
        ElseIf Sel1 = 8 Then

            PictureBox1.Image = My.Resources.GodCards.Hel
        ElseIf Sel1 = 9 Then

            PictureBox1.Image = My.Resources.GodCards.HunBatz
        ElseIf Sel1 = 10 Then

            PictureBox1.Image = My.Resources.GodCards.Kali
        ElseIf Sel1 = 11 Then

            PictureBox1.Image = My.Resources.GodCards.Kukulkan
        ElseIf Sel1 = 12 Then

            PictureBox1.Image = My.Resources.GodCards.Odin
        ElseIf Sel1 = 13 Then

            PictureBox1.Image = My.Resources.GodCards.Ra
        ElseIf Sel1 = 14 Then

            PictureBox1.Image = My.Resources.GodCards.Sobek
        ElseIf Sel1 = 15 Then

            PictureBox1.Image = My.Resources.GodCards.Vamana
        ElseIf Sel1 = 16 Then

            PictureBox1.Image = My.Resources.GodCards.Ymir
        ElseIf Sel1 = 17 Then

            PictureBox1.Image = My.Resources.GodCards.Zeus
        ElseIf Sel1 = 18 Then

            PictureBox1.Image = My.Resources.GodCards.GuanYu
        ElseIf Sel1 = 19 Then

            PictureBox1.Image = My.Resources.GodCards.Bakasura
        ElseIf Sel1 = 20 Then

            PictureBox1.Image = My.Resources.GodCards.Anhur
        ElseIf Sel1 = 21 Then

            PictureBox1.Image = My.Resources.GodCards.Cupid
        ElseIf Sel1 = 22 Then

            PictureBox1.Image = My.Resources.GodCards.Thor
        ElseIf Sel1 = 23 Then

            PictureBox1.Image = My.Resources.GodCards.Ares
        ElseIf Sel1 = 24 Then

            PictureBox1.Image = My.Resources.GodCards.Freya
        ElseIf Sel1 = 25 Then

            PictureBox1.Image = My.Resources.GodCards.Loki
        ElseIf Sel1 = 26 Then

            PictureBox1.Image = My.Resources.GodCards.Bacchus
        ElseIf Sel1 = 27 Then

            PictureBox1.Image = My.Resources.GodCards.Xbalanque
        ElseIf Sel1 = 28 Then

            PictureBox1.Image = My.Resources.GodCards.Hercules
        ElseIf Sel1 = 29 Then

            PictureBox1.Image = My.Resources.GodCards.Vulcan
        ElseIf Sel1 = 30 Then

            PictureBox1.Image = My.Resources.GodCards.Neith
        ElseIf Sel1 = 31 Then

            PictureBox1.Image = My.Resources.GodCards.Poseidon
        ElseIf Sel1 = 32 Then

            PictureBox1.Image = My.Resources.GodCards.Aphrodite
        ElseIf Sel1 = 33 Then

            PictureBox1.Image = My.Resources.GodCards.Apollo
        ElseIf Sel1 = 34 Then

            PictureBox1.Image = My.Resources.GodCards.NeZha
        ElseIf Sel1 = 35 Then

            PictureBox1.Image = My.Resources.GodCards.Fenrir
        ElseIf Sel1 = 36 Then

            PictureBox1.Image = My.Resources.GodCards.Isis
        ElseIf Sel1 = 37 Then

            PictureBox1.Image = My.Resources.GodCards.Athena
        ElseIf Sel1 = 38 Then

            PictureBox1.Image = My.Resources.GodCards.Chronos
        ElseIf Sel1 = 39 Then

            PictureBox1.Image = My.Resources.GodCards.Chang_e
        ElseIf Sel1 = 40 Then

            PictureBox1.Image = My.Resources.GodCards.Tyr
        ElseIf Sel1 = 41 Then

            PictureBox1.Image = My.Resources.GodCards.ZhongKui
        ElseIf Sel1 = 42 Then

            PictureBox1.Image = My.Resources.GodCards.Thanatos
        ElseIf Sel1 = 43 Then

            PictureBox1.Image = My.Resources.GodCards.Mercury
        ElseIf Sel1 = 44 Then

            PictureBox1.Image = My.Resources.GodCards.SunWukong
        ElseIf Sel1 = 45 Then

            PictureBox1.Image = My.Resources.GodCards.AhMuzenCab
        ElseIf Sel1 = 46 Then

            PictureBox1.Image = My.Resources.GodCards.NuWa
        ElseIf Sel1 = 47 Then

            PictureBox1.Image = My.Resources.GodCards.Chaac
        ElseIf Sel1 = 48 Then

            PictureBox1.Image = My.Resources.GodCards.Geb
        ElseIf Sel1 = 49 Then

            PictureBox1.Image = My.Resources.GodCards.Nemesis
        ElseIf Sel1 = 50 Then

            PictureBox1.Image = My.Resources.GodCards.Scylla
        ElseIf Sel1 = 51 Then

            PictureBox1.Image = My.Resources.GodCards.Ullr
        ElseIf Sel1 = 52 Then

            PictureBox1.Image = My.Resources.GodCards.Kumbhakarna
        ElseIf Sel1 = 53 Then

            PictureBox1.Image = My.Resources.GodCards.Osiris
        ElseIf Sel1 = 54 Then

            PictureBox1.Image = My.Resources.GodCards.Janus
        ElseIf Sel1 = 55 Then

            PictureBox1.Image = My.Resources.GodCards.Rama
        ElseIf Sel1 = 56 Then

            PictureBox1.Image = My.Resources.GodCards.Serqet
        ElseIf Sel1 = 57 Then

            PictureBox1.Image = My.Resources.GodCards.Cabrakan
        ElseIf Sel1 = 58 Then

            PictureBox1.Image = My.Resources.GodCards.Sylvanus
        ElseIf Sel1 = 59 Then

            PictureBox1.Image = My.Resources.GodCards.Nox
        ElseIf Sel1 = 60 Then

            PictureBox1.Image = My.Resources.GodCards.AoKuang
        ElseIf Sel1 = 61 Then

            PictureBox1.Image = My.Resources.GodCards.Awilix
        ElseIf Sel1 = 62 Then

            PictureBox1.Image = My.Resources.GodCards.HouYi
        ElseIf Sel1 = 63 Then

            PictureBox1.Image = My.Resources.GodCards.Bellona
        ElseIf Sel1 = 64 Then

            PictureBox1.Image = My.Resources.GodCards.Medusa
        ElseIf Sel1 = 65 Then

            PictureBox1.Image = My.Resources.GodCards.AhPuch
        ElseIf Sel1 = 66 Then

            PictureBox1.Image = My.Resources.GodCards.Ratatoskr
        ElseIf Sel1 = 67 Then

            PictureBox1.Image = My.Resources.GodCards.Ravana
        ElseIf Sel1 = 68 Then

            PictureBox1.Image = My.Resources.GodCards.Khepri
        ElseIf Sel1 = 69 Then

            PictureBox1.Image = My.Resources.GodCards.XingTian
        ElseIf Sel1 = 70 Then

            PictureBox1.Image = My.Resources.GodCards.Sol
        ElseIf Sel1 = 71 Then

            PictureBox1.Image = My.Resources.GodCards.Chiron
        ElseIf Sel1 = 72 Then

            PictureBox1.Image = My.Resources.GodCards.Amaterasu
        ElseIf Sel1 = 73 Then

            PictureBox1.Image = My.Resources.GodCards.Raijin
        ElseIf Sel1 = 74 Then

            PictureBox1.Image = My.Resources.GodCards.Skadi
        ElseIf Sel1 = 75 Then

            PictureBox1.Image = My.Resources.GodCards.JingWei
        ElseIf Sel1 = 76 Then

            PictureBox1.Image = My.Resources.GodCards.Susano
        ElseIf Sel1 = 77 Then

            PictureBox1.Image = My.Resources.GodCards.Fafnir
        ElseIf Sel1 = 78 Then

            PictureBox1.Image = My.Resources.GodCards.ErlangShen
        ElseIf Sel1 = 79 Then

            PictureBox1.Image = My.Resources.GodCards.Terra
        ElseIf Sel1 = 80 Then

            PictureBox1.Image = My.Resources.GodCards.Izanami
        ElseIf Sel1 = 81 Then

            PictureBox1.Image = My.Resources.GodCards.Camazotz
        ElseIf Sel1 = 82 Then

            PictureBox1.Image = My.Resources.GodCards.Thoth
        ElseIf Sel1 = 83 Then

            PictureBox1.Image = My.Resources.GodCards.Nike
        ElseIf Sel1 = 84 Then

            PictureBox1.Image = My.Resources.GodCards.TheMorrigan
        ElseIf Sel1 = 85 Then

            PictureBox1.Image = My.Resources.GodCards.Kuzenbo
        ElseIf Sel1 = 86 Then

            PictureBox1.Image = My.Resources.GodCards.Cernunnos
        ElseIf Sel1 = 87 Then

            PictureBox1.Image = My.Resources.GodCards.Ganesha
        ElseIf Sel1 = 88 Then

            PictureBox1.Image = My.Resources.GodCards.DaJi
        ElseIf Sel1 = 89 Then

            PictureBox1.Image = My.Resources.GodCards.CuChulainn
        ElseIf Sel1 = 90 Then

            PictureBox1.Image = My.Resources.GodCards.Artio
        ElseIf Sel1 = 91 Then

            PictureBox1.Image = My.Resources.GodCards.Hachiman
        ElseIf Sel1 = 92 Then

            PictureBox1.Image = My.Resources.GodCards.Discordia
        End If

    End Sub

    Private Sub God2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles God2.SelectedIndexChanged

        Dim Sel2 As Integer

        Sel2 = God2.SelectedValue

        If Sel2 = 1 Then

            PictureBox2.Image = My.Resources.GodCards.Agni
        ElseIf Sel2 = 2 Then

            PictureBox2.Image = My.Resources.GodCards.Anubis
        ElseIf Sel2 = 3 Then

            PictureBox2.Image = My.Resources.GodCards.Arachne
        ElseIf Sel2 = 4 Then

            PictureBox2.Image = My.Resources.GodCards.Artemis
        ElseIf Sel2 = 5 Then

            PictureBox2.Image = My.Resources.GodCards.Bastet
        ElseIf Sel2 = 6 Then

            PictureBox2.Image = My.Resources.GodCards.Hades
        ElseIf Sel2 = 7 Then

            PictureBox2.Image = My.Resources.GodCards.HeBo
        ElseIf Sel2 = 8 Then

            PictureBox2.Image = My.Resources.GodCards.Hel
        ElseIf Sel2 = 9 Then

            PictureBox2.Image = My.Resources.GodCards.HunBatz
        ElseIf Sel2 = 10 Then

            PictureBox2.Image = My.Resources.GodCards.Kali
        ElseIf Sel2 = 11 Then

            PictureBox2.Image = My.Resources.GodCards.Kukulkan
        ElseIf Sel2 = 12 Then

            PictureBox2.Image = My.Resources.GodCards.Odin
        ElseIf Sel2 = 13 Then

            PictureBox2.Image = My.Resources.GodCards.Ra
        ElseIf Sel2 = 14 Then

            PictureBox2.Image = My.Resources.GodCards.Sobek
        ElseIf Sel2 = 15 Then

            PictureBox2.Image = My.Resources.GodCards.Vamana
        ElseIf Sel2 = 16 Then

            PictureBox2.Image = My.Resources.GodCards.Ymir
        ElseIf Sel2 = 17 Then

            PictureBox2.Image = My.Resources.GodCards.Zeus
        ElseIf Sel2 = 18 Then

            PictureBox2.Image = My.Resources.GodCards.GuanYu
        ElseIf Sel2 = 19 Then

            PictureBox2.Image = My.Resources.GodCards.Bakasura
        ElseIf Sel2 = 20 Then

            PictureBox2.Image = My.Resources.GodCards.Anhur
        ElseIf Sel2 = 21 Then

            PictureBox2.Image = My.Resources.GodCards.Cupid
        ElseIf Sel2 = 22 Then

            PictureBox2.Image = My.Resources.GodCards.Thor
        ElseIf Sel2 = 23 Then

            PictureBox2.Image = My.Resources.GodCards.Ares
        ElseIf Sel2 = 24 Then

            PictureBox2.Image = My.Resources.GodCards.Freya
        ElseIf Sel2 = 25 Then

            PictureBox2.Image = My.Resources.GodCards.Loki
        ElseIf Sel2 = 26 Then

            PictureBox2.Image = My.Resources.GodCards.Bacchus
        ElseIf Sel2 = 27 Then

            PictureBox2.Image = My.Resources.GodCards.Xbalanque
        ElseIf Sel2 = 28 Then

            PictureBox2.Image = My.Resources.GodCards.Hercules
        ElseIf Sel2 = 29 Then

            PictureBox2.Image = My.Resources.GodCards.Vulcan
        ElseIf Sel2 = 30 Then

            PictureBox2.Image = My.Resources.GodCards.Neith
        ElseIf Sel2 = 31 Then

            PictureBox2.Image = My.Resources.GodCards.Poseidon
        ElseIf Sel2 = 32 Then

            PictureBox2.Image = My.Resources.GodCards.Aphrodite
        ElseIf Sel2 = 33 Then

            PictureBox2.Image = My.Resources.GodCards.Apollo
        ElseIf Sel2 = 34 Then

            PictureBox2.Image = My.Resources.GodCards.NeZha
        ElseIf Sel2 = 35 Then

            PictureBox2.Image = My.Resources.GodCards.Fenrir
        ElseIf Sel2 = 36 Then

            PictureBox2.Image = My.Resources.GodCards.Isis
        ElseIf Sel2 = 37 Then

            PictureBox2.Image = My.Resources.GodCards.Athena
        ElseIf Sel2 = 38 Then

            PictureBox2.Image = My.Resources.GodCards.Chronos
        ElseIf Sel2 = 39 Then

            PictureBox2.Image = My.Resources.GodCards.Chang_e
        ElseIf Sel2 = 40 Then

            PictureBox2.Image = My.Resources.GodCards.Tyr
        ElseIf Sel2 = 41 Then

            PictureBox2.Image = My.Resources.GodCards.ZhongKui
        ElseIf Sel2 = 42 Then

            PictureBox2.Image = My.Resources.GodCards.Thanatos
        ElseIf Sel2 = 43 Then

            PictureBox2.Image = My.Resources.GodCards.Mercury
        ElseIf Sel2 = 44 Then

            PictureBox2.Image = My.Resources.GodCards.SunWukong
        ElseIf Sel2 = 45 Then

            PictureBox2.Image = My.Resources.GodCards.AhMuzenCab
        ElseIf Sel2 = 46 Then

            PictureBox2.Image = My.Resources.GodCards.NuWa
        ElseIf Sel2 = 47 Then

            PictureBox2.Image = My.Resources.GodCards.Chaac
        ElseIf Sel2 = 48 Then

            PictureBox2.Image = My.Resources.GodCards.Geb
        ElseIf Sel2 = 49 Then

            PictureBox2.Image = My.Resources.GodCards.Nemesis
        ElseIf Sel2 = 50 Then

            PictureBox2.Image = My.Resources.GodCards.Scylla
        ElseIf Sel2 = 51 Then

            PictureBox2.Image = My.Resources.GodCards.Ullr
        ElseIf Sel2 = 52 Then

            PictureBox2.Image = My.Resources.GodCards.Kumbhakarna
        ElseIf Sel2 = 53 Then

            PictureBox2.Image = My.Resources.GodCards.Osiris
        ElseIf Sel2 = 54 Then

            PictureBox2.Image = My.Resources.GodCards.Janus
        ElseIf Sel2 = 55 Then

            PictureBox2.Image = My.Resources.GodCards.Rama
        ElseIf Sel2 = 56 Then

            PictureBox2.Image = My.Resources.GodCards.Serqet
        ElseIf Sel2 = 57 Then

            PictureBox2.Image = My.Resources.GodCards.Cabrakan
        ElseIf Sel2 = 58 Then

            PictureBox2.Image = My.Resources.GodCards.Sylvanus
        ElseIf Sel2 = 59 Then

            PictureBox2.Image = My.Resources.GodCards.Nox
        ElseIf Sel2 = 60 Then

            PictureBox2.Image = My.Resources.GodCards.AoKuang
        ElseIf Sel2 = 61 Then

            PictureBox2.Image = My.Resources.GodCards.Awilix
        ElseIf Sel2 = 62 Then

            PictureBox2.Image = My.Resources.GodCards.HouYi
        ElseIf Sel2 = 63 Then

            PictureBox2.Image = My.Resources.GodCards.Bellona
        ElseIf Sel2 = 64 Then

            PictureBox2.Image = My.Resources.GodCards.Medusa
        ElseIf Sel2 = 65 Then

            PictureBox2.Image = My.Resources.GodCards.AhPuch
        ElseIf Sel2 = 66 Then

            PictureBox2.Image = My.Resources.GodCards.Ratatoskr
        ElseIf Sel2 = 67 Then

            PictureBox2.Image = My.Resources.GodCards.Ravana
        ElseIf Sel2 = 68 Then

            PictureBox2.Image = My.Resources.GodCards.Khepri
        ElseIf Sel2 = 69 Then

            PictureBox2.Image = My.Resources.GodCards.XingTian
        ElseIf Sel2 = 70 Then

            PictureBox2.Image = My.Resources.GodCards.Sol
        ElseIf Sel2 = 71 Then

            PictureBox2.Image = My.Resources.GodCards.Chiron
        ElseIf Sel2 = 72 Then

            PictureBox2.Image = My.Resources.GodCards.Amaterasu
        ElseIf Sel2 = 73 Then

            PictureBox2.Image = My.Resources.GodCards.Raijin
        ElseIf Sel2 = 74 Then

            PictureBox2.Image = My.Resources.GodCards.Skadi
        ElseIf Sel2 = 75 Then

            PictureBox2.Image = My.Resources.GodCards.JingWei
        ElseIf Sel2 = 76 Then

            PictureBox2.Image = My.Resources.GodCards.Susano
        ElseIf Sel2 = 77 Then

            PictureBox2.Image = My.Resources.GodCards.Fafnir
        ElseIf Sel2 = 78 Then

            PictureBox2.Image = My.Resources.GodCards.ErlangShen
        ElseIf Sel2 = 79 Then

            PictureBox2.Image = My.Resources.GodCards.Terra
        ElseIf Sel2 = 80 Then

            PictureBox2.Image = My.Resources.GodCards.Izanami
        ElseIf Sel2 = 81 Then

            PictureBox2.Image = My.Resources.GodCards.Camazotz
        ElseIf Sel2 = 82 Then

            PictureBox2.Image = My.Resources.GodCards.Thoth
        ElseIf Sel2 = 83 Then

            PictureBox2.Image = My.Resources.GodCards.Nike
        ElseIf Sel2 = 84 Then

            PictureBox2.Image = My.Resources.GodCards.TheMorrigan
        ElseIf Sel2 = 85 Then

            PictureBox2.Image = My.Resources.GodCards.Kuzenbo
        ElseIf Sel2 = 86 Then

            PictureBox2.Image = My.Resources.GodCards.Cernunnos
        ElseIf Sel2 = 87 Then

            PictureBox2.Image = My.Resources.GodCards.Ganesha
        ElseIf Sel2 = 88 Then

            PictureBox2.Image = My.Resources.GodCards.DaJi
        ElseIf Sel2 = 89 Then

            PictureBox2.Image = My.Resources.GodCards.CuChulainn
        ElseIf Sel2 = 90 Then

            PictureBox2.Image = My.Resources.GodCards.Artio
        ElseIf Sel2 = 91 Then

            PictureBox2.Image = My.Resources.GodCards.Hachiman
        ElseIf Sel2 = 92 Then

            PictureBox2.Image = My.Resources.GodCards.Discordia
        End If

    End Sub

    Private Sub God3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles God3.SelectedIndexChanged

        Dim Sel3 As Integer

        Sel3 = God3.SelectedValue

        If Sel3 = 1 Then

            PictureBox3.Image = My.Resources.GodCards.Agni
        ElseIf Sel3 = 2 Then

            PictureBox3.Image = My.Resources.GodCards.Anubis
        ElseIf Sel3 = 3 Then

            PictureBox3.Image = My.Resources.GodCards.Arachne
        ElseIf Sel3 = 4 Then

            PictureBox3.Image = My.Resources.GodCards.Artemis
        ElseIf Sel3 = 5 Then

            PictureBox3.Image = My.Resources.GodCards.Bastet
        ElseIf Sel3 = 6 Then

            PictureBox3.Image = My.Resources.GodCards.Hades
        ElseIf Sel3 = 7 Then

            PictureBox3.Image = My.Resources.GodCards.HeBo
        ElseIf Sel3 = 8 Then

            PictureBox3.Image = My.Resources.GodCards.Hel
        ElseIf Sel3 = 9 Then

            PictureBox3.Image = My.Resources.GodCards.HunBatz
        ElseIf Sel3 = 10 Then

            PictureBox3.Image = My.Resources.GodCards.Kali
        ElseIf Sel3 = 11 Then

            PictureBox3.Image = My.Resources.GodCards.Kukulkan
        ElseIf Sel3 = 12 Then

            PictureBox3.Image = My.Resources.GodCards.Odin
        ElseIf Sel3 = 13 Then

            PictureBox3.Image = My.Resources.GodCards.Ra
        ElseIf Sel3 = 14 Then

            PictureBox3.Image = My.Resources.GodCards.Sobek
        ElseIf Sel3 = 15 Then

            PictureBox3.Image = My.Resources.GodCards.Vamana
        ElseIf Sel3 = 16 Then

            PictureBox3.Image = My.Resources.GodCards.Ymir
        ElseIf Sel3 = 17 Then

            PictureBox3.Image = My.Resources.GodCards.Zeus
        ElseIf Sel3 = 18 Then

            PictureBox3.Image = My.Resources.GodCards.GuanYu
        ElseIf Sel3 = 19 Then

            PictureBox3.Image = My.Resources.GodCards.Bakasura
        ElseIf Sel3 = 20 Then

            PictureBox3.Image = My.Resources.GodCards.Anhur
        ElseIf Sel3 = 21 Then

            PictureBox3.Image = My.Resources.GodCards.Cupid
        ElseIf Sel3 = 22 Then

            PictureBox3.Image = My.Resources.GodCards.Thor
        ElseIf Sel3 = 23 Then

            PictureBox3.Image = My.Resources.GodCards.Ares
        ElseIf Sel3 = 24 Then

            PictureBox3.Image = My.Resources.GodCards.Freya
        ElseIf Sel3 = 25 Then

            PictureBox3.Image = My.Resources.GodCards.Loki
        ElseIf Sel3 = 26 Then

            PictureBox3.Image = My.Resources.GodCards.Bacchus
        ElseIf Sel3 = 27 Then

            PictureBox3.Image = My.Resources.GodCards.Xbalanque
        ElseIf Sel3 = 28 Then

            PictureBox3.Image = My.Resources.GodCards.Hercules
        ElseIf Sel3 = 29 Then

            PictureBox3.Image = My.Resources.GodCards.Vulcan
        ElseIf Sel3 = 30 Then

            PictureBox3.Image = My.Resources.GodCards.Neith
        ElseIf Sel3 = 31 Then

            PictureBox3.Image = My.Resources.GodCards.Poseidon
        ElseIf Sel3 = 32 Then

            PictureBox3.Image = My.Resources.GodCards.Aphrodite
        ElseIf Sel3 = 33 Then

            PictureBox3.Image = My.Resources.GodCards.Apollo
        ElseIf Sel3 = 34 Then

            PictureBox3.Image = My.Resources.GodCards.NeZha
        ElseIf Sel3 = 35 Then

            PictureBox3.Image = My.Resources.GodCards.Fenrir
        ElseIf Sel3 = 36 Then

            PictureBox3.Image = My.Resources.GodCards.Isis
        ElseIf Sel3 = 37 Then

            PictureBox3.Image = My.Resources.GodCards.Athena
        ElseIf Sel3 = 38 Then

            PictureBox3.Image = My.Resources.GodCards.Chronos
        ElseIf Sel3 = 39 Then

            PictureBox3.Image = My.Resources.GodCards.Chang_e
        ElseIf Sel3 = 40 Then

            PictureBox3.Image = My.Resources.GodCards.Tyr
        ElseIf Sel3 = 41 Then

            PictureBox3.Image = My.Resources.GodCards.ZhongKui
        ElseIf Sel3 = 42 Then

            PictureBox3.Image = My.Resources.GodCards.Thanatos
        ElseIf Sel3 = 43 Then

            PictureBox3.Image = My.Resources.GodCards.Mercury
        ElseIf Sel3 = 44 Then

            PictureBox3.Image = My.Resources.GodCards.SunWukong
        ElseIf Sel3 = 45 Then

            PictureBox3.Image = My.Resources.GodCards.AhMuzenCab
        ElseIf Sel3 = 46 Then

            PictureBox3.Image = My.Resources.GodCards.NuWa
        ElseIf Sel3 = 47 Then

            PictureBox3.Image = My.Resources.GodCards.Chaac
        ElseIf Sel3 = 48 Then

            PictureBox3.Image = My.Resources.GodCards.Geb
        ElseIf Sel3 = 49 Then

            PictureBox3.Image = My.Resources.GodCards.Nemesis
        ElseIf Sel3 = 50 Then

            PictureBox3.Image = My.Resources.GodCards.Scylla
        ElseIf Sel3 = 51 Then

            PictureBox3.Image = My.Resources.GodCards.Ullr
        ElseIf Sel3 = 52 Then

            PictureBox3.Image = My.Resources.GodCards.Kumbhakarna
        ElseIf Sel3 = 53 Then

            PictureBox3.Image = My.Resources.GodCards.Osiris
        ElseIf Sel3 = 54 Then

            PictureBox3.Image = My.Resources.GodCards.Janus
        ElseIf Sel3 = 55 Then

            PictureBox3.Image = My.Resources.GodCards.Rama
        ElseIf Sel3 = 56 Then

            PictureBox3.Image = My.Resources.GodCards.Serqet
        ElseIf Sel3 = 57 Then

            PictureBox3.Image = My.Resources.GodCards.Cabrakan
        ElseIf Sel3 = 58 Then

            PictureBox3.Image = My.Resources.GodCards.Sylvanus
        ElseIf Sel3 = 59 Then

            PictureBox3.Image = My.Resources.GodCards.Nox
        ElseIf Sel3 = 60 Then

            PictureBox3.Image = My.Resources.GodCards.AoKuang
        ElseIf Sel3 = 61 Then

            PictureBox3.Image = My.Resources.GodCards.Awilix
        ElseIf Sel3 = 62 Then

            PictureBox3.Image = My.Resources.GodCards.HouYi
        ElseIf Sel3 = 63 Then

            PictureBox3.Image = My.Resources.GodCards.Bellona
        ElseIf Sel3 = 64 Then

            PictureBox3.Image = My.Resources.GodCards.Medusa
        ElseIf Sel3 = 65 Then

            PictureBox3.Image = My.Resources.GodCards.AhPuch
        ElseIf Sel3 = 66 Then

            PictureBox3.Image = My.Resources.GodCards.Ratatoskr
        ElseIf Sel3 = 67 Then

            PictureBox3.Image = My.Resources.GodCards.Ravana
        ElseIf Sel3 = 68 Then

            PictureBox3.Image = My.Resources.GodCards.Khepri
        ElseIf Sel3 = 69 Then

            PictureBox3.Image = My.Resources.GodCards.XingTian
        ElseIf Sel3 = 70 Then

            PictureBox3.Image = My.Resources.GodCards.Sol
        ElseIf Sel3 = 71 Then

            PictureBox3.Image = My.Resources.GodCards.Chiron
        ElseIf Sel3 = 72 Then

            PictureBox3.Image = My.Resources.GodCards.Amaterasu
        ElseIf Sel3 = 73 Then

            PictureBox3.Image = My.Resources.GodCards.Raijin
        ElseIf Sel3 = 74 Then

            PictureBox3.Image = My.Resources.GodCards.Skadi
        ElseIf Sel3 = 75 Then

            PictureBox3.Image = My.Resources.GodCards.JingWei
        ElseIf Sel3 = 76 Then

            PictureBox3.Image = My.Resources.GodCards.Susano
        ElseIf Sel3 = 77 Then

            PictureBox3.Image = My.Resources.GodCards.Fafnir
        ElseIf Sel3 = 78 Then

            PictureBox3.Image = My.Resources.GodCards.ErlangShen
        ElseIf Sel3 = 79 Then

            PictureBox3.Image = My.Resources.GodCards.Terra
        ElseIf Sel3 = 80 Then

            PictureBox3.Image = My.Resources.GodCards.Izanami
        ElseIf Sel3 = 81 Then

            PictureBox3.Image = My.Resources.GodCards.Camazotz
        ElseIf Sel3 = 82 Then

            PictureBox3.Image = My.Resources.GodCards.Thoth
        ElseIf Sel3 = 83 Then

            PictureBox3.Image = My.Resources.GodCards.Nike
        ElseIf Sel3 = 84 Then

            PictureBox3.Image = My.Resources.GodCards.TheMorrigan
        ElseIf Sel3 = 85 Then

            PictureBox3.Image = My.Resources.GodCards.Kuzenbo
        ElseIf Sel3 = 86 Then

            PictureBox3.Image = My.Resources.GodCards.Cernunnos
        ElseIf Sel3 = 87 Then

            PictureBox3.Image = My.Resources.GodCards.Ganesha
        ElseIf Sel3 = 88 Then

            PictureBox3.Image = My.Resources.GodCards.DaJi
        ElseIf Sel3 = 89 Then

            PictureBox3.Image = My.Resources.GodCards.CuChulainn
        ElseIf Sel3 = 90 Then

            PictureBox3.Image = My.Resources.GodCards.Artio
        ElseIf Sel3 = 91 Then

            PictureBox3.Image = My.Resources.GodCards.Hachiman
        ElseIf Sel3 = 92 Then

            PictureBox3.Image = My.Resources.GodCards.Discordia
        End If

    End Sub

    Private Sub God4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles God4.SelectedIndexChanged

        Dim Sel4 As Integer

        Sel4 = God4.SelectedValue

        If Sel4 = 1 Then

            PictureBox4.Image = My.Resources.GodCards.Agni
        ElseIf Sel4 = 2 Then

            PictureBox4.Image = My.Resources.GodCards.Anubis
        ElseIf Sel4 = 3 Then

            PictureBox4.Image = My.Resources.GodCards.Arachne
        ElseIf Sel4 = 4 Then

            PictureBox4.Image = My.Resources.GodCards.Artemis
        ElseIf Sel4 = 5 Then

            PictureBox4.Image = My.Resources.GodCards.Bastet
        ElseIf Sel4 = 6 Then

            PictureBox4.Image = My.Resources.GodCards.Hades
        ElseIf Sel4 = 7 Then

            PictureBox4.Image = My.Resources.GodCards.HeBo
        ElseIf Sel4 = 8 Then

            PictureBox4.Image = My.Resources.GodCards.Hel
        ElseIf Sel4 = 9 Then

            PictureBox4.Image = My.Resources.GodCards.HunBatz
        ElseIf Sel4 = 10 Then

            PictureBox4.Image = My.Resources.GodCards.Kali
        ElseIf Sel4 = 11 Then

            PictureBox4.Image = My.Resources.GodCards.Kukulkan
        ElseIf Sel4 = 12 Then

            PictureBox4.Image = My.Resources.GodCards.Odin
        ElseIf Sel4 = 13 Then

            PictureBox4.Image = My.Resources.GodCards.Ra
        ElseIf Sel4 = 14 Then

            PictureBox4.Image = My.Resources.GodCards.Sobek
        ElseIf Sel4 = 15 Then

            PictureBox4.Image = My.Resources.GodCards.Vamana
        ElseIf Sel4 = 16 Then

            PictureBox4.Image = My.Resources.GodCards.Ymir
        ElseIf Sel4 = 17 Then

            PictureBox4.Image = My.Resources.GodCards.Zeus
        ElseIf Sel4 = 18 Then

            PictureBox4.Image = My.Resources.GodCards.GuanYu
        ElseIf Sel4 = 19 Then

            PictureBox4.Image = My.Resources.GodCards.Bakasura
        ElseIf Sel4 = 20 Then

            PictureBox4.Image = My.Resources.GodCards.Anhur
        ElseIf Sel4 = 21 Then

            PictureBox4.Image = My.Resources.GodCards.Cupid
        ElseIf Sel4 = 22 Then

            PictureBox4.Image = My.Resources.GodCards.Thor
        ElseIf Sel4 = 23 Then

            PictureBox4.Image = My.Resources.GodCards.Ares
        ElseIf Sel4 = 24 Then

            PictureBox4.Image = My.Resources.GodCards.Freya
        ElseIf Sel4 = 25 Then

            PictureBox4.Image = My.Resources.GodCards.Loki
        ElseIf Sel4 = 26 Then

            PictureBox4.Image = My.Resources.GodCards.Bacchus
        ElseIf Sel4 = 27 Then

            PictureBox4.Image = My.Resources.GodCards.Xbalanque
        ElseIf Sel4 = 28 Then

            PictureBox4.Image = My.Resources.GodCards.Hercules
        ElseIf Sel4 = 29 Then

            PictureBox4.Image = My.Resources.GodCards.Vulcan
        ElseIf Sel4 = 30 Then

            PictureBox4.Image = My.Resources.GodCards.Neith
        ElseIf Sel4 = 31 Then

            PictureBox4.Image = My.Resources.GodCards.Poseidon
        ElseIf Sel4 = 32 Then

            PictureBox4.Image = My.Resources.GodCards.Aphrodite
        ElseIf Sel4 = 33 Then

            PictureBox4.Image = My.Resources.GodCards.Apollo
        ElseIf Sel4 = 34 Then

            PictureBox4.Image = My.Resources.GodCards.NeZha
        ElseIf Sel4 = 35 Then

            PictureBox4.Image = My.Resources.GodCards.Fenrir
        ElseIf Sel4 = 36 Then

            PictureBox4.Image = My.Resources.GodCards.Isis
        ElseIf Sel4 = 37 Then

            PictureBox4.Image = My.Resources.GodCards.Athena
        ElseIf Sel4 = 38 Then

            PictureBox4.Image = My.Resources.GodCards.Chronos
        ElseIf Sel4 = 39 Then

            PictureBox4.Image = My.Resources.GodCards.Chang_e
        ElseIf Sel4 = 40 Then

            PictureBox4.Image = My.Resources.GodCards.Tyr
        ElseIf Sel4 = 41 Then

            PictureBox4.Image = My.Resources.GodCards.ZhongKui
        ElseIf Sel4 = 42 Then

            PictureBox4.Image = My.Resources.GodCards.Thanatos
        ElseIf Sel4 = 43 Then

            PictureBox4.Image = My.Resources.GodCards.Mercury
        ElseIf Sel4 = 44 Then

            PictureBox4.Image = My.Resources.GodCards.SunWukong
        ElseIf Sel4 = 45 Then

            PictureBox4.Image = My.Resources.GodCards.AhMuzenCab
        ElseIf Sel4 = 46 Then

            PictureBox4.Image = My.Resources.GodCards.NuWa
        ElseIf Sel4 = 47 Then

            PictureBox4.Image = My.Resources.GodCards.Chaac
        ElseIf Sel4 = 48 Then

            PictureBox4.Image = My.Resources.GodCards.Geb
        ElseIf Sel4 = 49 Then

            PictureBox4.Image = My.Resources.GodCards.Nemesis
        ElseIf Sel4 = 50 Then

            PictureBox4.Image = My.Resources.GodCards.Scylla
        ElseIf Sel4 = 51 Then

            PictureBox4.Image = My.Resources.GodCards.Ullr
        ElseIf Sel4 = 52 Then

            PictureBox4.Image = My.Resources.GodCards.Kumbhakarna
        ElseIf Sel4 = 53 Then

            PictureBox4.Image = My.Resources.GodCards.Osiris
        ElseIf Sel4 = 54 Then

            PictureBox4.Image = My.Resources.GodCards.Janus
        ElseIf Sel4 = 55 Then

            PictureBox4.Image = My.Resources.GodCards.Rama
        ElseIf Sel4 = 56 Then

            PictureBox4.Image = My.Resources.GodCards.Serqet
        ElseIf Sel4 = 57 Then

            PictureBox4.Image = My.Resources.GodCards.Cabrakan
        ElseIf Sel4 = 58 Then

            PictureBox4.Image = My.Resources.GodCards.Sylvanus
        ElseIf Sel4 = 59 Then

            PictureBox4.Image = My.Resources.GodCards.Nox
        ElseIf Sel4 = 60 Then

            PictureBox4.Image = My.Resources.GodCards.AoKuang
        ElseIf Sel4 = 61 Then

            PictureBox4.Image = My.Resources.GodCards.Awilix
        ElseIf Sel4 = 62 Then

            PictureBox4.Image = My.Resources.GodCards.HouYi
        ElseIf Sel4 = 63 Then

            PictureBox4.Image = My.Resources.GodCards.Bellona
        ElseIf Sel4 = 64 Then

            PictureBox4.Image = My.Resources.GodCards.Medusa
        ElseIf Sel4 = 65 Then

            PictureBox4.Image = My.Resources.GodCards.AhPuch
        ElseIf Sel4 = 66 Then

            PictureBox4.Image = My.Resources.GodCards.Ratatoskr
        ElseIf Sel4 = 67 Then

            PictureBox4.Image = My.Resources.GodCards.Ravana
        ElseIf Sel4 = 68 Then

            PictureBox4.Image = My.Resources.GodCards.Khepri
        ElseIf Sel4 = 69 Then

            PictureBox4.Image = My.Resources.GodCards.XingTian
        ElseIf Sel4 = 70 Then

            PictureBox4.Image = My.Resources.GodCards.Sol
        ElseIf Sel4 = 71 Then

            PictureBox4.Image = My.Resources.GodCards.Chiron
        ElseIf Sel4 = 72 Then

            PictureBox4.Image = My.Resources.GodCards.Amaterasu
        ElseIf Sel4 = 73 Then

            PictureBox4.Image = My.Resources.GodCards.Raijin
        ElseIf Sel4 = 74 Then

            PictureBox4.Image = My.Resources.GodCards.Skadi
        ElseIf Sel4 = 75 Then

            PictureBox4.Image = My.Resources.GodCards.JingWei
        ElseIf Sel4 = 76 Then

            PictureBox4.Image = My.Resources.GodCards.Susano
        ElseIf Sel4 = 77 Then

            PictureBox4.Image = My.Resources.GodCards.Fafnir
        ElseIf Sel4 = 78 Then

            PictureBox4.Image = My.Resources.GodCards.ErlangShen
        ElseIf Sel4 = 79 Then

            PictureBox4.Image = My.Resources.GodCards.Terra
        ElseIf Sel4 = 80 Then

            PictureBox4.Image = My.Resources.GodCards.Izanami
        ElseIf Sel4 = 81 Then

            PictureBox4.Image = My.Resources.GodCards.Camazotz
        ElseIf Sel4 = 82 Then

            PictureBox4.Image = My.Resources.GodCards.Thoth
        ElseIf Sel4 = 83 Then

            PictureBox4.Image = My.Resources.GodCards.Nike
        ElseIf Sel4 = 84 Then

            PictureBox4.Image = My.Resources.GodCards.TheMorrigan
        ElseIf Sel4 = 85 Then

            PictureBox4.Image = My.Resources.GodCards.Kuzenbo
        ElseIf Sel4 = 86 Then

            PictureBox4.Image = My.Resources.GodCards.Cernunnos
        ElseIf Sel4 = 87 Then

            PictureBox4.Image = My.Resources.GodCards.Ganesha
        ElseIf Sel4 = 88 Then

            PictureBox4.Image = My.Resources.GodCards.DaJi
        ElseIf Sel4 = 89 Then

            PictureBox4.Image = My.Resources.GodCards.CuChulainn
        ElseIf Sel4 = 90 Then

            PictureBox4.Image = My.Resources.GodCards.Artio
        ElseIf Sel4 = 91 Then

            PictureBox4.Image = My.Resources.GodCards.Hachiman
        ElseIf Sel4 = 92 Then

            PictureBox4.Image = My.Resources.GodCards.Discordia
        End If

    End Sub

    Private Sub God5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles God5.SelectedIndexChanged

        Dim Sel5 As Integer

        Sel5 = God5.SelectedValue

        If Sel5 = 1 Then

            PictureBox5.Image = My.Resources.GodCards.Agni
        ElseIf Sel5 = 2 Then

            PictureBox5.Image = My.Resources.GodCards.Anubis
        ElseIf Sel5 = 3 Then

            PictureBox5.Image = My.Resources.GodCards.Arachne
        ElseIf Sel5 = 4 Then

            PictureBox5.Image = My.Resources.GodCards.Artemis
        ElseIf Sel5 = 5 Then

            PictureBox5.Image = My.Resources.GodCards.Bastet
        ElseIf Sel5 = 6 Then

            PictureBox5.Image = My.Resources.GodCards.Hades
        ElseIf Sel5 = 7 Then

            PictureBox5.Image = My.Resources.GodCards.HeBo
        ElseIf Sel5 = 8 Then

            PictureBox5.Image = My.Resources.GodCards.Hel
        ElseIf Sel5 = 9 Then

            PictureBox5.Image = My.Resources.GodCards.HunBatz
        ElseIf Sel5 = 10 Then

            PictureBox5.Image = My.Resources.GodCards.Kali
        ElseIf Sel5 = 11 Then

            PictureBox5.Image = My.Resources.GodCards.Kukulkan
        ElseIf Sel5 = 12 Then

            PictureBox5.Image = My.Resources.GodCards.Odin
        ElseIf Sel5 = 13 Then

            PictureBox5.Image = My.Resources.GodCards.Ra
        ElseIf Sel5 = 14 Then

            PictureBox5.Image = My.Resources.GodCards.Sobek
        ElseIf Sel5 = 15 Then

            PictureBox5.Image = My.Resources.GodCards.Vamana
        ElseIf Sel5 = 16 Then

            PictureBox5.Image = My.Resources.GodCards.Ymir
        ElseIf Sel5 = 17 Then

            PictureBox5.Image = My.Resources.GodCards.Zeus
        ElseIf Sel5 = 18 Then

            PictureBox5.Image = My.Resources.GodCards.GuanYu
        ElseIf Sel5 = 19 Then

            PictureBox5.Image = My.Resources.GodCards.Bakasura
        ElseIf Sel5 = 20 Then

            PictureBox5.Image = My.Resources.GodCards.Anhur
        ElseIf Sel5 = 21 Then

            PictureBox5.Image = My.Resources.GodCards.Cupid
        ElseIf Sel5 = 22 Then

            PictureBox5.Image = My.Resources.GodCards.Thor
        ElseIf Sel5 = 23 Then

            PictureBox5.Image = My.Resources.GodCards.Ares
        ElseIf Sel5 = 24 Then

            PictureBox5.Image = My.Resources.GodCards.Freya
        ElseIf Sel5 = 25 Then

            PictureBox5.Image = My.Resources.GodCards.Loki
        ElseIf Sel5 = 26 Then

            PictureBox5.Image = My.Resources.GodCards.Bacchus
        ElseIf Sel5 = 27 Then

            PictureBox5.Image = My.Resources.GodCards.Xbalanque
        ElseIf Sel5 = 28 Then

            PictureBox5.Image = My.Resources.GodCards.Hercules
        ElseIf Sel5 = 29 Then

            PictureBox5.Image = My.Resources.GodCards.Vulcan
        ElseIf Sel5 = 30 Then

            PictureBox5.Image = My.Resources.GodCards.Neith
        ElseIf Sel5 = 31 Then

            PictureBox5.Image = My.Resources.GodCards.Poseidon
        ElseIf Sel5 = 32 Then

            PictureBox5.Image = My.Resources.GodCards.Aphrodite
        ElseIf Sel5 = 33 Then

            PictureBox5.Image = My.Resources.GodCards.Apollo
        ElseIf Sel5 = 34 Then

            PictureBox5.Image = My.Resources.GodCards.NeZha
        ElseIf Sel5 = 35 Then

            PictureBox5.Image = My.Resources.GodCards.Fenrir
        ElseIf Sel5 = 36 Then

            PictureBox5.Image = My.Resources.GodCards.Isis
        ElseIf Sel5 = 37 Then

            PictureBox5.Image = My.Resources.GodCards.Athena
        ElseIf Sel5 = 38 Then

            PictureBox5.Image = My.Resources.GodCards.Chronos
        ElseIf Sel5 = 39 Then

            PictureBox5.Image = My.Resources.GodCards.Chang_e
        ElseIf Sel5 = 40 Then

            PictureBox5.Image = My.Resources.GodCards.Tyr
        ElseIf Sel5 = 41 Then

            PictureBox5.Image = My.Resources.GodCards.ZhongKui
        ElseIf Sel5 = 42 Then

            PictureBox5.Image = My.Resources.GodCards.Thanatos
        ElseIf Sel5 = 43 Then

            PictureBox5.Image = My.Resources.GodCards.Mercury
        ElseIf Sel5 = 44 Then

            PictureBox5.Image = My.Resources.GodCards.SunWukong
        ElseIf Sel5 = 45 Then

            PictureBox5.Image = My.Resources.GodCards.AhMuzenCab
        ElseIf Sel5 = 46 Then

            PictureBox5.Image = My.Resources.GodCards.NuWa
        ElseIf Sel5 = 47 Then

            PictureBox5.Image = My.Resources.GodCards.Chaac
        ElseIf Sel5 = 48 Then

            PictureBox5.Image = My.Resources.GodCards.Geb
        ElseIf Sel5 = 49 Then

            PictureBox5.Image = My.Resources.GodCards.Nemesis
        ElseIf Sel5 = 50 Then

            PictureBox5.Image = My.Resources.GodCards.Scylla
        ElseIf Sel5 = 51 Then

            PictureBox5.Image = My.Resources.GodCards.Ullr
        ElseIf Sel5 = 52 Then

            PictureBox5.Image = My.Resources.GodCards.Kumbhakarna
        ElseIf Sel5 = 53 Then

            PictureBox5.Image = My.Resources.GodCards.Osiris
        ElseIf Sel5 = 54 Then

            PictureBox5.Image = My.Resources.GodCards.Janus
        ElseIf Sel5 = 55 Then

            PictureBox5.Image = My.Resources.GodCards.Rama
        ElseIf Sel5 = 56 Then

            PictureBox5.Image = My.Resources.GodCards.Serqet
        ElseIf Sel5 = 57 Then

            PictureBox5.Image = My.Resources.GodCards.Cabrakan
        ElseIf Sel5 = 58 Then

            PictureBox5.Image = My.Resources.GodCards.Sylvanus
        ElseIf Sel5 = 59 Then

            PictureBox5.Image = My.Resources.GodCards.Nox
        ElseIf Sel5 = 60 Then

            PictureBox5.Image = My.Resources.GodCards.AoKuang
        ElseIf Sel5 = 61 Then

            PictureBox5.Image = My.Resources.GodCards.Awilix
        ElseIf Sel5 = 62 Then

            PictureBox5.Image = My.Resources.GodCards.HouYi
        ElseIf Sel5 = 63 Then

            PictureBox5.Image = My.Resources.GodCards.Bellona
        ElseIf Sel5 = 64 Then

            PictureBox5.Image = My.Resources.GodCards.Medusa
        ElseIf Sel5 = 65 Then

            PictureBox5.Image = My.Resources.GodCards.AhPuch
        ElseIf Sel5 = 66 Then

            PictureBox5.Image = My.Resources.GodCards.Ratatoskr
        ElseIf Sel5 = 67 Then

            PictureBox5.Image = My.Resources.GodCards.Ravana
        ElseIf Sel5 = 68 Then

            PictureBox5.Image = My.Resources.GodCards.Khepri
        ElseIf Sel5 = 69 Then

            PictureBox5.Image = My.Resources.GodCards.XingTian
        ElseIf Sel5 = 70 Then

            PictureBox5.Image = My.Resources.GodCards.Sol
        ElseIf Sel5 = 71 Then

            PictureBox5.Image = My.Resources.GodCards.Chiron
        ElseIf Sel5 = 72 Then

            PictureBox5.Image = My.Resources.GodCards.Amaterasu
        ElseIf Sel5 = 73 Then

            PictureBox5.Image = My.Resources.GodCards.Raijin
        ElseIf Sel5 = 74 Then

            PictureBox5.Image = My.Resources.GodCards.Skadi
        ElseIf Sel5 = 75 Then

            PictureBox5.Image = My.Resources.GodCards.JingWei
        ElseIf Sel5 = 76 Then

            PictureBox5.Image = My.Resources.GodCards.Susano
        ElseIf Sel5 = 77 Then

            PictureBox5.Image = My.Resources.GodCards.Fafnir
        ElseIf Sel5 = 78 Then

            PictureBox5.Image = My.Resources.GodCards.ErlangShen
        ElseIf Sel5 = 79 Then

            PictureBox5.Image = My.Resources.GodCards.Terra
        ElseIf Sel5 = 80 Then

            PictureBox5.Image = My.Resources.GodCards.Izanami
        ElseIf Sel5 = 81 Then

            PictureBox5.Image = My.Resources.GodCards.Camazotz
        ElseIf Sel5 = 82 Then

            PictureBox5.Image = My.Resources.GodCards.Thoth
        ElseIf Sel5 = 83 Then

            PictureBox5.Image = My.Resources.GodCards.Nike
        ElseIf Sel5 = 84 Then

            PictureBox5.Image = My.Resources.GodCards.TheMorrigan
        ElseIf Sel5 = 85 Then

            PictureBox5.Image = My.Resources.GodCards.Kuzenbo
        ElseIf Sel5 = 86 Then

            PictureBox5.Image = My.Resources.GodCards.Cernunnos
        ElseIf Sel5 = 87 Then

            PictureBox5.Image = My.Resources.GodCards.Ganesha
        ElseIf Sel5 = 88 Then

            PictureBox5.Image = My.Resources.GodCards.DaJi
        ElseIf Sel5 = 89 Then

            PictureBox5.Image = My.Resources.GodCards.CuChulainn
        ElseIf Sel5 = 90 Then

            PictureBox5.Image = My.Resources.GodCards.Artio
        ElseIf Sel5 = 91 Then

            PictureBox5.Image = My.Resources.GodCards.Hachiman
        ElseIf Sel5 = 92 Then

            PictureBox5.Image = My.Resources.GodCards.Discordia
        End If

    End Sub

    Private Sub God6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles God6.SelectedIndexChanged

        Dim Sel6 As Integer

        Sel6 = God6.SelectedValue

        If Sel6 = 1 Then

            PictureBox6.Image = My.Resources.GodCards.Agni
        ElseIf Sel6 = 2 Then

            PictureBox6.Image = My.Resources.GodCards.Anubis
        ElseIf Sel6 = 3 Then

            PictureBox6.Image = My.Resources.GodCards.Arachne
        ElseIf Sel6 = 4 Then

            PictureBox6.Image = My.Resources.GodCards.Artemis
        ElseIf Sel6 = 5 Then

            PictureBox6.Image = My.Resources.GodCards.Bastet
        ElseIf Sel6 = 6 Then

            PictureBox6.Image = My.Resources.GodCards.Hades
        ElseIf Sel6 = 7 Then

            PictureBox6.Image = My.Resources.GodCards.HeBo
        ElseIf Sel6 = 8 Then

            PictureBox6.Image = My.Resources.GodCards.Hel
        ElseIf Sel6 = 9 Then

            PictureBox6.Image = My.Resources.GodCards.HunBatz
        ElseIf Sel6 = 10 Then

            PictureBox6.Image = My.Resources.GodCards.Kali
        ElseIf Sel6 = 11 Then

            PictureBox6.Image = My.Resources.GodCards.Kukulkan
        ElseIf Sel6 = 12 Then

            PictureBox6.Image = My.Resources.GodCards.Odin
        ElseIf Sel6 = 13 Then

            PictureBox6.Image = My.Resources.GodCards.Ra
        ElseIf Sel6 = 14 Then

            PictureBox6.Image = My.Resources.GodCards.Sobek
        ElseIf Sel6 = 15 Then

            PictureBox6.Image = My.Resources.GodCards.Vamana
        ElseIf Sel6 = 16 Then

            PictureBox6.Image = My.Resources.GodCards.Ymir
        ElseIf Sel6 = 17 Then

            PictureBox6.Image = My.Resources.GodCards.Zeus
        ElseIf Sel6 = 18 Then

            PictureBox6.Image = My.Resources.GodCards.GuanYu
        ElseIf Sel6 = 19 Then

            PictureBox6.Image = My.Resources.GodCards.Bakasura
        ElseIf Sel6 = 20 Then

            PictureBox6.Image = My.Resources.GodCards.Anhur
        ElseIf Sel6 = 21 Then

            PictureBox6.Image = My.Resources.GodCards.Cupid
        ElseIf Sel6 = 22 Then

            PictureBox6.Image = My.Resources.GodCards.Thor
        ElseIf Sel6 = 23 Then

            PictureBox6.Image = My.Resources.GodCards.Ares
        ElseIf Sel6 = 24 Then

            PictureBox6.Image = My.Resources.GodCards.Freya
        ElseIf Sel6 = 25 Then

            PictureBox6.Image = My.Resources.GodCards.Loki
        ElseIf Sel6 = 26 Then

            PictureBox6.Image = My.Resources.GodCards.Bacchus
        ElseIf Sel6 = 27 Then

            PictureBox6.Image = My.Resources.GodCards.Xbalanque
        ElseIf Sel6 = 28 Then

            PictureBox6.Image = My.Resources.GodCards.Hercules
        ElseIf Sel6 = 29 Then

            PictureBox6.Image = My.Resources.GodCards.Vulcan
        ElseIf Sel6 = 30 Then

            PictureBox6.Image = My.Resources.GodCards.Neith
        ElseIf Sel6 = 31 Then

            PictureBox6.Image = My.Resources.GodCards.Poseidon
        ElseIf Sel6 = 32 Then

            PictureBox6.Image = My.Resources.GodCards.Aphrodite
        ElseIf Sel6 = 33 Then

            PictureBox6.Image = My.Resources.GodCards.Apollo
        ElseIf Sel6 = 34 Then

            PictureBox6.Image = My.Resources.GodCards.NeZha
        ElseIf Sel6 = 35 Then

            PictureBox6.Image = My.Resources.GodCards.Fenrir
        ElseIf Sel6 = 36 Then

            PictureBox6.Image = My.Resources.GodCards.Isis
        ElseIf Sel6 = 37 Then

            PictureBox6.Image = My.Resources.GodCards.Athena
        ElseIf Sel6 = 38 Then

            PictureBox6.Image = My.Resources.GodCards.Chronos
        ElseIf Sel6 = 39 Then

            PictureBox6.Image = My.Resources.GodCards.Chang_e
        ElseIf Sel6 = 40 Then

            PictureBox6.Image = My.Resources.GodCards.Tyr
        ElseIf Sel6 = 41 Then

            PictureBox6.Image = My.Resources.GodCards.ZhongKui
        ElseIf Sel6 = 42 Then

            PictureBox6.Image = My.Resources.GodCards.Thanatos
        ElseIf Sel6 = 43 Then

            PictureBox6.Image = My.Resources.GodCards.Mercury
        ElseIf Sel6 = 44 Then

            PictureBox6.Image = My.Resources.GodCards.SunWukong
        ElseIf Sel6 = 45 Then

            PictureBox6.Image = My.Resources.GodCards.AhMuzenCab
        ElseIf Sel6 = 46 Then

            PictureBox6.Image = My.Resources.GodCards.NuWa
        ElseIf Sel6 = 47 Then

            PictureBox6.Image = My.Resources.GodCards.Chaac
        ElseIf Sel6 = 48 Then

            PictureBox6.Image = My.Resources.GodCards.Geb
        ElseIf Sel6 = 49 Then

            PictureBox6.Image = My.Resources.GodCards.Nemesis
        ElseIf Sel6 = 50 Then

            PictureBox6.Image = My.Resources.GodCards.Scylla
        ElseIf Sel6 = 51 Then

            PictureBox6.Image = My.Resources.GodCards.Ullr
        ElseIf Sel6 = 52 Then

            PictureBox6.Image = My.Resources.GodCards.Kumbhakarna
        ElseIf Sel6 = 53 Then

            PictureBox6.Image = My.Resources.GodCards.Osiris
        ElseIf Sel6 = 54 Then

            PictureBox6.Image = My.Resources.GodCards.Janus
        ElseIf Sel6 = 55 Then

            PictureBox6.Image = My.Resources.GodCards.Rama
        ElseIf Sel6 = 56 Then

            PictureBox6.Image = My.Resources.GodCards.Serqet
        ElseIf Sel6 = 57 Then

            PictureBox6.Image = My.Resources.GodCards.Cabrakan
        ElseIf Sel6 = 58 Then

            PictureBox6.Image = My.Resources.GodCards.Sylvanus
        ElseIf Sel6 = 59 Then

            PictureBox6.Image = My.Resources.GodCards.Nox
        ElseIf Sel6 = 60 Then

            PictureBox6.Image = My.Resources.GodCards.AoKuang
        ElseIf Sel6 = 61 Then

            PictureBox6.Image = My.Resources.GodCards.Awilix
        ElseIf Sel6 = 62 Then

            PictureBox6.Image = My.Resources.GodCards.HouYi
        ElseIf Sel6 = 63 Then

            PictureBox6.Image = My.Resources.GodCards.Bellona
        ElseIf Sel6 = 64 Then

            PictureBox6.Image = My.Resources.GodCards.Medusa
        ElseIf Sel6 = 65 Then

            PictureBox6.Image = My.Resources.GodCards.AhPuch
        ElseIf Sel6 = 66 Then

            PictureBox6.Image = My.Resources.GodCards.Ratatoskr
        ElseIf Sel6 = 67 Then

            PictureBox6.Image = My.Resources.GodCards.Ravana
        ElseIf Sel6 = 68 Then

            PictureBox6.Image = My.Resources.GodCards.Khepri
        ElseIf Sel6 = 69 Then

            PictureBox6.Image = My.Resources.GodCards.XingTian
        ElseIf Sel6 = 70 Then

            PictureBox6.Image = My.Resources.GodCards.Sol
        ElseIf Sel6 = 71 Then

            PictureBox6.Image = My.Resources.GodCards.Chiron
        ElseIf Sel6 = 72 Then

            PictureBox6.Image = My.Resources.GodCards.Amaterasu
        ElseIf Sel6 = 73 Then

            PictureBox6.Image = My.Resources.GodCards.Raijin
        ElseIf Sel6 = 74 Then

            PictureBox6.Image = My.Resources.GodCards.Skadi
        ElseIf Sel6 = 75 Then

            PictureBox6.Image = My.Resources.GodCards.JingWei
        ElseIf Sel6 = 76 Then

            PictureBox6.Image = My.Resources.GodCards.Susano
        ElseIf Sel6 = 77 Then

            PictureBox6.Image = My.Resources.GodCards.Fafnir
        ElseIf Sel6 = 78 Then

            PictureBox6.Image = My.Resources.GodCards.ErlangShen
        ElseIf Sel6 = 79 Then

            PictureBox6.Image = My.Resources.GodCards.Terra
        ElseIf Sel6 = 80 Then

            PictureBox6.Image = My.Resources.GodCards.Izanami
        ElseIf Sel6 = 81 Then

            PictureBox6.Image = My.Resources.GodCards.Camazotz
        ElseIf Sel6 = 82 Then

            PictureBox6.Image = My.Resources.GodCards.Thoth
        ElseIf Sel6 = 83 Then

            PictureBox6.Image = My.Resources.GodCards.Nike
        ElseIf Sel6 = 84 Then

            PictureBox6.Image = My.Resources.GodCards.TheMorrigan
        ElseIf Sel6 = 85 Then

            PictureBox6.Image = My.Resources.GodCards.Kuzenbo
        ElseIf Sel6 = 86 Then

            PictureBox6.Image = My.Resources.GodCards.Cernunnos
        ElseIf Sel6 = 87 Then

            PictureBox6.Image = My.Resources.GodCards.Ganesha
        ElseIf Sel6 = 88 Then

            PictureBox6.Image = My.Resources.GodCards.DaJi
        ElseIf Sel6 = 89 Then

            PictureBox6.Image = My.Resources.GodCards.CuChulainn
        ElseIf Sel6 = 90 Then

            PictureBox6.Image = My.Resources.GodCards.Artio
        ElseIf Sel6 = 91 Then

            PictureBox6.Image = My.Resources.GodCards.Hachiman
        ElseIf Sel6 = 92 Then

            PictureBox6.Image = My.Resources.GodCards.Discordia
        End If

    End Sub

    Private Sub Ban1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ban1.SelectedIndexChanged

        Dim Sel7 As Integer

        Sel7 = Ban1.SelectedValue

        If Sel7 = 1 Then

            PictureBox7.Image = My.Resources.GodIcons.Agni
        ElseIf Sel7 = 2 Then

            PictureBox7.Image = My.Resources.GodIcons.Anubis
        ElseIf Sel7 = 3 Then

            PictureBox7.Image = My.Resources.GodIcons.Arachne
        ElseIf Sel7 = 4 Then

            PictureBox7.Image = My.Resources.GodIcons.Artemis
        ElseIf Sel7 = 5 Then

            PictureBox7.Image = My.Resources.GodIcons.Bastet
        ElseIf Sel7 = 6 Then

            PictureBox7.Image = My.Resources.GodIcons.Hades
        ElseIf Sel7 = 7 Then

            PictureBox7.Image = My.Resources.GodIcons.HeBo
        ElseIf Sel7 = 8 Then

            PictureBox7.Image = My.Resources.GodIcons.Hel
        ElseIf Sel7 = 9 Then

            PictureBox7.Image = My.Resources.GodIcons.HunBatz
        ElseIf Sel7 = 10 Then

            PictureBox7.Image = My.Resources.GodIcons.Kali
        ElseIf Sel7 = 11 Then

            PictureBox7.Image = My.Resources.GodIcons.Kukulkan
        ElseIf Sel7 = 12 Then

            PictureBox7.Image = My.Resources.GodIcons.Odin
        ElseIf Sel7 = 13 Then

            PictureBox7.Image = My.Resources.GodIcons.Ra
        ElseIf Sel7 = 14 Then

            PictureBox7.Image = My.Resources.GodIcons.Sobek
        ElseIf Sel7 = 15 Then

            PictureBox7.Image = My.Resources.GodIcons.Vamana
        ElseIf Sel7 = 16 Then

            PictureBox7.Image = My.Resources.GodIcons.Ymir
        ElseIf Sel7 = 17 Then

            PictureBox7.Image = My.Resources.GodIcons.Zeus
        ElseIf Sel7 = 18 Then

            PictureBox7.Image = My.Resources.GodIcons.GuanYu
        ElseIf Sel7 = 19 Then

            PictureBox7.Image = My.Resources.GodIcons.Bakasura
        ElseIf Sel7 = 20 Then

            PictureBox7.Image = My.Resources.GodIcons.Anhur
        ElseIf Sel7 = 21 Then

            PictureBox7.Image = My.Resources.GodIcons.Cupid
        ElseIf Sel7 = 22 Then

            PictureBox7.Image = My.Resources.GodIcons.Thor
        ElseIf Sel7 = 23 Then

            PictureBox7.Image = My.Resources.GodIcons.Ares
        ElseIf Sel7 = 24 Then

            PictureBox7.Image = My.Resources.GodIcons.Freya
        ElseIf Sel7 = 25 Then

            PictureBox7.Image = My.Resources.GodIcons.Loki
        ElseIf Sel7 = 26 Then

            PictureBox7.Image = My.Resources.GodIcons.Bacchus
        ElseIf Sel7 = 27 Then

            PictureBox7.Image = My.Resources.GodIcons.Xbalanque
        ElseIf Sel7 = 28 Then

            PictureBox7.Image = My.Resources.GodIcons.Hercules
        ElseIf Sel7 = 29 Then

            PictureBox7.Image = My.Resources.GodIcons.Vulcan
        ElseIf Sel7 = 30 Then

            PictureBox7.Image = My.Resources.GodIcons.Neith
        ElseIf Sel7 = 31 Then

            PictureBox7.Image = My.Resources.GodIcons.Poseidon
        ElseIf Sel7 = 32 Then

            PictureBox7.Image = My.Resources.GodIcons.Aphrodite
        ElseIf Sel7 = 33 Then

            PictureBox7.Image = My.Resources.GodIcons.Apollo
        ElseIf Sel7 = 34 Then

            PictureBox7.Image = My.Resources.GodIcons.NeZha
        ElseIf Sel7 = 35 Then

            PictureBox7.Image = My.Resources.GodIcons.Fenrir
        ElseIf Sel7 = 36 Then

            PictureBox7.Image = My.Resources.GodIcons.Isis
        ElseIf Sel7 = 37 Then

            PictureBox7.Image = My.Resources.GodIcons.Athena
        ElseIf Sel7 = 38 Then

            PictureBox7.Image = My.Resources.GodIcons.Chronos
        ElseIf Sel7 = 39 Then

            PictureBox7.Image = My.Resources.GodIcons.Chang_e
        ElseIf Sel7 = 40 Then

            PictureBox7.Image = My.Resources.GodIcons.Tyr
        ElseIf Sel7 = 41 Then

            PictureBox7.Image = My.Resources.GodIcons.ZhongKui
        ElseIf Sel7 = 42 Then

            PictureBox7.Image = My.Resources.GodIcons.Thanatos
        ElseIf Sel7 = 43 Then

            PictureBox7.Image = My.Resources.GodIcons.Mercury
        ElseIf Sel7 = 44 Then

            PictureBox7.Image = My.Resources.GodIcons.SunWukong
        ElseIf Sel7 = 45 Then

            PictureBox7.Image = My.Resources.GodIcons.AhMuzenCab
        ElseIf Sel7 = 46 Then

            PictureBox7.Image = My.Resources.GodIcons.NuWa
        ElseIf Sel7 = 47 Then

            PictureBox7.Image = My.Resources.GodIcons.Chaac
        ElseIf Sel7 = 48 Then

            PictureBox7.Image = My.Resources.GodIcons.Geb
        ElseIf Sel7 = 49 Then

            PictureBox7.Image = My.Resources.GodIcons.Nemesis
        ElseIf Sel7 = 50 Then

            PictureBox7.Image = My.Resources.GodIcons.Scylla
        ElseIf Sel7 = 51 Then

            PictureBox7.Image = My.Resources.GodIcons.Ullr
        ElseIf Sel7 = 52 Then

            PictureBox7.Image = My.Resources.GodIcons.Kumbhakarna
        ElseIf Sel7 = 53 Then

            PictureBox7.Image = My.Resources.GodIcons.Osiris
        ElseIf Sel7 = 54 Then

            PictureBox7.Image = My.Resources.GodIcons.Janus
        ElseIf Sel7 = 55 Then

            PictureBox7.Image = My.Resources.GodIcons.Rama
        ElseIf Sel7 = 56 Then

            PictureBox7.Image = My.Resources.GodIcons.Serqet
        ElseIf Sel7 = 57 Then

            PictureBox7.Image = My.Resources.GodIcons.Cabrakan
        ElseIf Sel7 = 58 Then

            PictureBox7.Image = My.Resources.GodIcons.Sylvanus
        ElseIf Sel7 = 59 Then

            PictureBox7.Image = My.Resources.GodIcons.Nox
        ElseIf Sel7 = 60 Then

            PictureBox7.Image = My.Resources.GodIcons.AoKuang
        ElseIf Sel7 = 61 Then

            PictureBox7.Image = My.Resources.GodIcons.Awilix
        ElseIf Sel7 = 62 Then

            PictureBox7.Image = My.Resources.GodIcons.HouYi
        ElseIf Sel7 = 63 Then

            PictureBox7.Image = My.Resources.GodIcons.Bellona
        ElseIf Sel7 = 64 Then

            PictureBox7.Image = My.Resources.GodIcons.Medusa
        ElseIf Sel7 = 65 Then

            PictureBox7.Image = My.Resources.GodIcons.AhPuch
        ElseIf Sel7 = 66 Then

            PictureBox7.Image = My.Resources.GodIcons.Ratatoskr
        ElseIf Sel7 = 67 Then

            PictureBox7.Image = My.Resources.GodIcons.Ravana
        ElseIf Sel7 = 68 Then

            PictureBox7.Image = My.Resources.GodIcons.Khepri
        ElseIf Sel7 = 69 Then

            PictureBox7.Image = My.Resources.GodIcons.XingTian
        ElseIf Sel7 = 70 Then

            PictureBox7.Image = My.Resources.GodIcons.Sol
        ElseIf Sel7 = 71 Then

            PictureBox7.Image = My.Resources.GodIcons.Chiron
        ElseIf Sel7 = 72 Then

            PictureBox7.Image = My.Resources.GodIcons.Amaterasu
        ElseIf Sel7 = 73 Then

            PictureBox7.Image = My.Resources.GodIcons.Raijin
        ElseIf Sel7 = 74 Then

            PictureBox7.Image = My.Resources.GodIcons.Skadi
        ElseIf Sel7 = 75 Then

            PictureBox7.Image = My.Resources.GodIcons.JingWei
        ElseIf Sel7 = 76 Then

            PictureBox7.Image = My.Resources.GodIcons.Susano
        ElseIf Sel7 = 77 Then

            PictureBox7.Image = My.Resources.GodIcons.Fafnir
        ElseIf Sel7 = 78 Then

            PictureBox7.Image = My.Resources.GodIcons.ErlangShen
        ElseIf Sel7 = 79 Then

            PictureBox7.Image = My.Resources.GodIcons.Terra
        ElseIf Sel7 = 80 Then

            PictureBox7.Image = My.Resources.GodIcons.Izanami
        ElseIf Sel7 = 81 Then

            PictureBox7.Image = My.Resources.GodIcons.Camazotz
        ElseIf Sel7 = 82 Then

            PictureBox7.Image = My.Resources.GodIcons.Thoth
        ElseIf Sel7 = 83 Then

            PictureBox7.Image = My.Resources.GodIcons.Nike
        ElseIf Sel7 = 84 Then

            PictureBox7.Image = My.Resources.GodIcons.TheMorrigan
        ElseIf Sel7 = 85 Then

            PictureBox7.Image = My.Resources.GodIcons.Kuzenbo
        ElseIf Sel7 = 86 Then

            PictureBox7.Image = My.Resources.GodIcons.Cernunnos
        ElseIf Sel7 = 87 Then

            PictureBox7.Image = My.Resources.GodIcons.Ganesha
        ElseIf Sel7 = 88 Then

            PictureBox7.Image = My.Resources.GodIcons.DaJi
        ElseIf Sel7 = 89 Then

            PictureBox7.Image = My.Resources.GodIcons.CuChulainn
        ElseIf Sel7 = 90 Then

            PictureBox7.Image = My.Resources.GodIcons.Artio
        ElseIf Sel7 = 91 Then

            PictureBox7.Image = My.Resources.GodIcons.Hachiman
        ElseIf Sel7 = 92 Then

            PictureBox7.Image = My.Resources.GodIcons.Discordia
        End If

    End Sub

    Private Sub Ban2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ban2.SelectedIndexChanged

        Dim Sel8 As Integer

        Sel8 = Ban2.SelectedValue

        If Sel8 = 1 Then

            PictureBox8.Image = My.Resources.GodIcons.Agni
        ElseIf Sel8 = 2 Then

            PictureBox8.Image = My.Resources.GodIcons.Anubis
        ElseIf Sel8 = 3 Then

            PictureBox8.Image = My.Resources.GodIcons.Arachne
        ElseIf Sel8 = 4 Then

            PictureBox8.Image = My.Resources.GodIcons.Artemis
        ElseIf Sel8 = 5 Then

            PictureBox8.Image = My.Resources.GodIcons.Bastet
        ElseIf Sel8 = 6 Then

            PictureBox8.Image = My.Resources.GodIcons.Hades
        ElseIf Sel8 = 7 Then

            PictureBox8.Image = My.Resources.GodIcons.HeBo
        ElseIf Sel8 = 8 Then

            PictureBox8.Image = My.Resources.GodIcons.Hel
        ElseIf Sel8 = 9 Then

            PictureBox8.Image = My.Resources.GodIcons.HunBatz
        ElseIf Sel8 = 10 Then

            PictureBox8.Image = My.Resources.GodIcons.Kali
        ElseIf Sel8 = 11 Then

            PictureBox8.Image = My.Resources.GodIcons.Kukulkan
        ElseIf Sel8 = 12 Then

            PictureBox8.Image = My.Resources.GodIcons.Odin
        ElseIf Sel8 = 13 Then

            PictureBox8.Image = My.Resources.GodIcons.Ra
        ElseIf Sel8 = 14 Then

            PictureBox8.Image = My.Resources.GodIcons.Sobek
        ElseIf Sel8 = 15 Then

            PictureBox8.Image = My.Resources.GodIcons.Vamana
        ElseIf Sel8 = 16 Then

            PictureBox8.Image = My.Resources.GodIcons.Ymir
        ElseIf Sel8 = 17 Then

            PictureBox8.Image = My.Resources.GodIcons.Zeus
        ElseIf Sel8 = 18 Then

            PictureBox8.Image = My.Resources.GodIcons.GuanYu
        ElseIf Sel8 = 19 Then

            PictureBox8.Image = My.Resources.GodIcons.Bakasura
        ElseIf Sel8 = 20 Then

            PictureBox8.Image = My.Resources.GodIcons.Anhur
        ElseIf Sel8 = 21 Then

            PictureBox8.Image = My.Resources.GodIcons.Cupid
        ElseIf Sel8 = 22 Then

            PictureBox8.Image = My.Resources.GodIcons.Thor
        ElseIf Sel8 = 23 Then

            PictureBox8.Image = My.Resources.GodIcons.Ares
        ElseIf Sel8 = 24 Then

            PictureBox8.Image = My.Resources.GodIcons.Freya
        ElseIf Sel8 = 25 Then

            PictureBox8.Image = My.Resources.GodIcons.Loki
        ElseIf Sel8 = 26 Then

            PictureBox8.Image = My.Resources.GodIcons.Bacchus
        ElseIf Sel8 = 27 Then

            PictureBox8.Image = My.Resources.GodIcons.Xbalanque
        ElseIf Sel8 = 28 Then

            PictureBox8.Image = My.Resources.GodIcons.Hercules
        ElseIf Sel8 = 29 Then

            PictureBox8.Image = My.Resources.GodIcons.Vulcan
        ElseIf Sel8 = 30 Then

            PictureBox8.Image = My.Resources.GodIcons.Neith
        ElseIf Sel8 = 31 Then

            PictureBox8.Image = My.Resources.GodIcons.Poseidon
        ElseIf Sel8 = 32 Then

            PictureBox8.Image = My.Resources.GodIcons.Aphrodite
        ElseIf Sel8 = 33 Then

            PictureBox8.Image = My.Resources.GodIcons.Apollo
        ElseIf Sel8 = 34 Then

            PictureBox8.Image = My.Resources.GodIcons.NeZha
        ElseIf Sel8 = 35 Then

            PictureBox8.Image = My.Resources.GodIcons.Fenrir
        ElseIf Sel8 = 36 Then

            PictureBox8.Image = My.Resources.GodIcons.Isis
        ElseIf Sel8 = 37 Then

            PictureBox8.Image = My.Resources.GodIcons.Athena
        ElseIf Sel8 = 38 Then

            PictureBox8.Image = My.Resources.GodIcons.Chronos
        ElseIf Sel8 = 39 Then

            PictureBox8.Image = My.Resources.GodIcons.Chang_e
        ElseIf Sel8 = 40 Then

            PictureBox8.Image = My.Resources.GodIcons.Tyr
        ElseIf Sel8 = 41 Then

            PictureBox8.Image = My.Resources.GodIcons.ZhongKui
        ElseIf Sel8 = 42 Then

            PictureBox8.Image = My.Resources.GodIcons.Thanatos
        ElseIf Sel8 = 43 Then

            PictureBox8.Image = My.Resources.GodIcons.Mercury
        ElseIf Sel8 = 44 Then

            PictureBox8.Image = My.Resources.GodIcons.SunWukong
        ElseIf Sel8 = 45 Then

            PictureBox8.Image = My.Resources.GodIcons.AhMuzenCab
        ElseIf Sel8 = 46 Then

            PictureBox8.Image = My.Resources.GodIcons.NuWa
        ElseIf Sel8 = 47 Then

            PictureBox8.Image = My.Resources.GodIcons.Chaac
        ElseIf Sel8 = 48 Then

            PictureBox8.Image = My.Resources.GodIcons.Geb
        ElseIf Sel8 = 49 Then

            PictureBox8.Image = My.Resources.GodIcons.Nemesis
        ElseIf Sel8 = 50 Then

            PictureBox8.Image = My.Resources.GodIcons.Scylla
        ElseIf Sel8 = 51 Then

            PictureBox8.Image = My.Resources.GodIcons.Ullr
        ElseIf Sel8 = 52 Then

            PictureBox8.Image = My.Resources.GodIcons.Kumbhakarna
        ElseIf Sel8 = 53 Then

            PictureBox8.Image = My.Resources.GodIcons.Osiris
        ElseIf Sel8 = 54 Then

            PictureBox8.Image = My.Resources.GodIcons.Janus
        ElseIf Sel8 = 55 Then

            PictureBox8.Image = My.Resources.GodIcons.Rama
        ElseIf Sel8 = 56 Then

            PictureBox8.Image = My.Resources.GodIcons.Serqet
        ElseIf Sel8 = 57 Then

            PictureBox8.Image = My.Resources.GodIcons.Cabrakan
        ElseIf Sel8 = 58 Then

            PictureBox8.Image = My.Resources.GodIcons.Sylvanus
        ElseIf Sel8 = 59 Then

            PictureBox8.Image = My.Resources.GodIcons.Nox
        ElseIf Sel8 = 60 Then

            PictureBox8.Image = My.Resources.GodIcons.AoKuang
        ElseIf Sel8 = 61 Then

            PictureBox8.Image = My.Resources.GodIcons.Awilix
        ElseIf Sel8 = 62 Then

            PictureBox8.Image = My.Resources.GodIcons.HouYi
        ElseIf Sel8 = 63 Then

            PictureBox8.Image = My.Resources.GodIcons.Bellona
        ElseIf Sel8 = 64 Then

            PictureBox8.Image = My.Resources.GodIcons.Medusa
        ElseIf Sel8 = 65 Then

            PictureBox8.Image = My.Resources.GodIcons.AhPuch
        ElseIf Sel8 = 66 Then

            PictureBox8.Image = My.Resources.GodIcons.Ratatoskr
        ElseIf Sel8 = 67 Then

            PictureBox8.Image = My.Resources.GodIcons.Ravana
        ElseIf Sel8 = 68 Then

            PictureBox8.Image = My.Resources.GodIcons.Khepri
        ElseIf Sel8 = 69 Then

            PictureBox8.Image = My.Resources.GodIcons.XingTian
        ElseIf Sel8 = 70 Then

            PictureBox8.Image = My.Resources.GodIcons.Sol
        ElseIf Sel8 = 71 Then

            PictureBox8.Image = My.Resources.GodIcons.Chiron
        ElseIf Sel8 = 72 Then

            PictureBox8.Image = My.Resources.GodIcons.Amaterasu
        ElseIf Sel8 = 73 Then

            PictureBox8.Image = My.Resources.GodIcons.Raijin
        ElseIf Sel8 = 74 Then

            PictureBox8.Image = My.Resources.GodIcons.Skadi
        ElseIf Sel8 = 75 Then

            PictureBox8.Image = My.Resources.GodIcons.JingWei
        ElseIf Sel8 = 76 Then

            PictureBox8.Image = My.Resources.GodIcons.Susano
        ElseIf Sel8 = 77 Then

            PictureBox8.Image = My.Resources.GodIcons.Fafnir
        ElseIf Sel8 = 78 Then

            PictureBox8.Image = My.Resources.GodIcons.ErlangShen
        ElseIf Sel8 = 79 Then

            PictureBox8.Image = My.Resources.GodIcons.Terra
        ElseIf Sel8 = 80 Then

            PictureBox8.Image = My.Resources.GodIcons.Izanami
        ElseIf Sel8 = 81 Then

            PictureBox8.Image = My.Resources.GodIcons.Camazotz
        ElseIf Sel8 = 82 Then

            PictureBox8.Image = My.Resources.GodIcons.Thoth
        ElseIf Sel8 = 83 Then

            PictureBox8.Image = My.Resources.GodIcons.Nike
        ElseIf Sel8 = 84 Then

            PictureBox8.Image = My.Resources.GodIcons.TheMorrigan
        ElseIf Sel8 = 85 Then

            PictureBox8.Image = My.Resources.GodIcons.Kuzenbo
        ElseIf Sel8 = 86 Then

            PictureBox8.Image = My.Resources.GodIcons.Cernunnos
        ElseIf Sel8 = 87 Then

            PictureBox8.Image = My.Resources.GodIcons.Ganesha
        ElseIf Sel8 = 88 Then

            PictureBox8.Image = My.Resources.GodIcons.DaJi
        ElseIf Sel8 = 89 Then

            PictureBox8.Image = My.Resources.GodIcons.CuChulainn
        ElseIf Sel8 = 90 Then

            PictureBox8.Image = My.Resources.GodIcons.Artio
        ElseIf Sel8 = 91 Then

            PictureBox8.Image = My.Resources.GodIcons.Hachiman
        ElseIf Sel8 = 92 Then

            PictureBox8.Image = My.Resources.GodIcons.Discordia
        End If

    End Sub

    Private Sub Ban3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ban3.SelectedIndexChanged

        Dim Sel9 As Integer

        Sel9 = Ban3.SelectedValue

        If Sel9 = 1 Then

            PictureBox9.Image = My.Resources.GodIcons.Agni
        ElseIf Sel9 = 2 Then

            PictureBox9.Image = My.Resources.GodIcons.Anubis
        ElseIf Sel9 = 3 Then

            PictureBox9.Image = My.Resources.GodIcons.Arachne
        ElseIf Sel9 = 4 Then

            PictureBox9.Image = My.Resources.GodIcons.Artemis
        ElseIf Sel9 = 5 Then

            PictureBox9.Image = My.Resources.GodIcons.Bastet
        ElseIf Sel9 = 6 Then

            PictureBox9.Image = My.Resources.GodIcons.Hades
        ElseIf Sel9 = 7 Then

            PictureBox9.Image = My.Resources.GodIcons.HeBo
        ElseIf Sel9 = 8 Then

            PictureBox9.Image = My.Resources.GodIcons.Hel
        ElseIf Sel9 = 9 Then

            PictureBox9.Image = My.Resources.GodIcons.HunBatz
        ElseIf Sel9 = 10 Then

            PictureBox9.Image = My.Resources.GodIcons.Kali
        ElseIf Sel9 = 11 Then

            PictureBox9.Image = My.Resources.GodIcons.Kukulkan
        ElseIf Sel9 = 12 Then

            PictureBox9.Image = My.Resources.GodIcons.Odin
        ElseIf Sel9 = 13 Then

            PictureBox9.Image = My.Resources.GodIcons.Ra
        ElseIf Sel9 = 14 Then

            PictureBox9.Image = My.Resources.GodIcons.Sobek
        ElseIf Sel9 = 15 Then

            PictureBox9.Image = My.Resources.GodIcons.Vamana
        ElseIf Sel9 = 16 Then

            PictureBox9.Image = My.Resources.GodIcons.Ymir
        ElseIf Sel9 = 17 Then

            PictureBox9.Image = My.Resources.GodIcons.Zeus
        ElseIf Sel9 = 18 Then

            PictureBox9.Image = My.Resources.GodIcons.GuanYu
        ElseIf Sel9 = 19 Then

            PictureBox9.Image = My.Resources.GodIcons.Bakasura
        ElseIf Sel9 = 20 Then

            PictureBox9.Image = My.Resources.GodIcons.Anhur
        ElseIf Sel9 = 21 Then

            PictureBox9.Image = My.Resources.GodIcons.Cupid
        ElseIf Sel9 = 22 Then

            PictureBox9.Image = My.Resources.GodIcons.Thor
        ElseIf Sel9 = 23 Then

            PictureBox9.Image = My.Resources.GodIcons.Ares
        ElseIf Sel9 = 24 Then

            PictureBox9.Image = My.Resources.GodIcons.Freya
        ElseIf Sel9 = 25 Then

            PictureBox9.Image = My.Resources.GodIcons.Loki
        ElseIf Sel9 = 26 Then

            PictureBox9.Image = My.Resources.GodIcons.Bacchus
        ElseIf Sel9 = 27 Then

            PictureBox9.Image = My.Resources.GodIcons.Xbalanque
        ElseIf Sel9 = 28 Then

            PictureBox9.Image = My.Resources.GodIcons.Hercules
        ElseIf Sel9 = 29 Then

            PictureBox9.Image = My.Resources.GodIcons.Vulcan
        ElseIf Sel9 = 30 Then

            PictureBox9.Image = My.Resources.GodIcons.Neith
        ElseIf Sel9 = 31 Then

            PictureBox9.Image = My.Resources.GodIcons.Poseidon
        ElseIf Sel9 = 32 Then

            PictureBox9.Image = My.Resources.GodIcons.Aphrodite
        ElseIf Sel9 = 33 Then

            PictureBox9.Image = My.Resources.GodIcons.Apollo
        ElseIf Sel9 = 34 Then

            PictureBox9.Image = My.Resources.GodIcons.NeZha
        ElseIf Sel9 = 35 Then

            PictureBox9.Image = My.Resources.GodIcons.Fenrir
        ElseIf Sel9 = 36 Then

            PictureBox9.Image = My.Resources.GodIcons.Isis
        ElseIf Sel9 = 37 Then

            PictureBox9.Image = My.Resources.GodIcons.Athena
        ElseIf Sel9 = 38 Then

            PictureBox9.Image = My.Resources.GodIcons.Chronos
        ElseIf Sel9 = 39 Then

            PictureBox9.Image = My.Resources.GodIcons.Chang_e
        ElseIf Sel9 = 40 Then

            PictureBox9.Image = My.Resources.GodIcons.Tyr
        ElseIf Sel9 = 41 Then

            PictureBox9.Image = My.Resources.GodIcons.ZhongKui
        ElseIf Sel9 = 42 Then

            PictureBox9.Image = My.Resources.GodIcons.Thanatos
        ElseIf Sel9 = 43 Then

            PictureBox9.Image = My.Resources.GodIcons.Mercury
        ElseIf Sel9 = 44 Then

            PictureBox9.Image = My.Resources.GodIcons.SunWukong
        ElseIf Sel9 = 45 Then

            PictureBox9.Image = My.Resources.GodIcons.AhMuzenCab
        ElseIf Sel9 = 46 Then

            PictureBox9.Image = My.Resources.GodIcons.NuWa
        ElseIf Sel9 = 47 Then

            PictureBox9.Image = My.Resources.GodIcons.Chaac
        ElseIf Sel9 = 48 Then

            PictureBox9.Image = My.Resources.GodIcons.Geb
        ElseIf Sel9 = 49 Then

            PictureBox9.Image = My.Resources.GodIcons.Nemesis
        ElseIf Sel9 = 50 Then

            PictureBox9.Image = My.Resources.GodIcons.Scylla
        ElseIf Sel9 = 51 Then

            PictureBox9.Image = My.Resources.GodIcons.Ullr
        ElseIf Sel9 = 52 Then

            PictureBox9.Image = My.Resources.GodIcons.Kumbhakarna
        ElseIf Sel9 = 53 Then

            PictureBox9.Image = My.Resources.GodIcons.Osiris
        ElseIf Sel9 = 54 Then

            PictureBox9.Image = My.Resources.GodIcons.Janus
        ElseIf Sel9 = 55 Then

            PictureBox9.Image = My.Resources.GodIcons.Rama
        ElseIf Sel9 = 56 Then

            PictureBox9.Image = My.Resources.GodIcons.Serqet
        ElseIf Sel9 = 57 Then

            PictureBox9.Image = My.Resources.GodIcons.Cabrakan
        ElseIf Sel9 = 58 Then

            PictureBox9.Image = My.Resources.GodIcons.Sylvanus
        ElseIf Sel9 = 59 Then

            PictureBox9.Image = My.Resources.GodIcons.Nox
        ElseIf Sel9 = 60 Then

            PictureBox9.Image = My.Resources.GodIcons.AoKuang
        ElseIf Sel9 = 61 Then

            PictureBox9.Image = My.Resources.GodIcons.Awilix
        ElseIf Sel9 = 62 Then

            PictureBox9.Image = My.Resources.GodIcons.HouYi
        ElseIf Sel9 = 63 Then

            PictureBox9.Image = My.Resources.GodIcons.Bellona
        ElseIf Sel9 = 64 Then

            PictureBox9.Image = My.Resources.GodIcons.Medusa
        ElseIf Sel9 = 65 Then

            PictureBox9.Image = My.Resources.GodIcons.AhPuch
        ElseIf Sel9 = 66 Then

            PictureBox9.Image = My.Resources.GodIcons.Ratatoskr
        ElseIf Sel9 = 67 Then

            PictureBox9.Image = My.Resources.GodIcons.Ravana
        ElseIf Sel9 = 68 Then

            PictureBox9.Image = My.Resources.GodIcons.Khepri
        ElseIf Sel9 = 69 Then

            PictureBox9.Image = My.Resources.GodIcons.XingTian
        ElseIf Sel9 = 70 Then

            PictureBox9.Image = My.Resources.GodIcons.Sol
        ElseIf Sel9 = 71 Then

            PictureBox9.Image = My.Resources.GodIcons.Chiron
        ElseIf Sel9 = 72 Then

            PictureBox9.Image = My.Resources.GodIcons.Amaterasu
        ElseIf Sel9 = 73 Then

            PictureBox9.Image = My.Resources.GodIcons.Raijin
        ElseIf Sel9 = 74 Then

            PictureBox9.Image = My.Resources.GodIcons.Skadi
        ElseIf Sel9 = 75 Then

            PictureBox9.Image = My.Resources.GodIcons.JingWei
        ElseIf Sel9 = 76 Then

            PictureBox9.Image = My.Resources.GodIcons.Susano
        ElseIf Sel9 = 77 Then

            PictureBox9.Image = My.Resources.GodIcons.Fafnir
        ElseIf Sel9 = 78 Then

            PictureBox9.Image = My.Resources.GodIcons.ErlangShen
        ElseIf Sel9 = 79 Then

            PictureBox9.Image = My.Resources.GodIcons.Terra
        ElseIf Sel9 = 80 Then

            PictureBox9.Image = My.Resources.GodIcons.Izanami
        ElseIf Sel9 = 81 Then

            PictureBox9.Image = My.Resources.GodIcons.Camazotz
        ElseIf Sel9 = 82 Then

            PictureBox9.Image = My.Resources.GodIcons.Thoth
        ElseIf Sel9 = 83 Then

            PictureBox9.Image = My.Resources.GodIcons.Nike
        ElseIf Sel9 = 84 Then

            PictureBox9.Image = My.Resources.GodIcons.TheMorrigan
        ElseIf Sel9 = 85 Then

            PictureBox9.Image = My.Resources.GodIcons.Kuzenbo
        ElseIf Sel9 = 86 Then

            PictureBox9.Image = My.Resources.GodIcons.Cernunnos
        ElseIf Sel9 = 87 Then

            PictureBox9.Image = My.Resources.GodIcons.Ganesha
        ElseIf Sel9 = 88 Then

            PictureBox9.Image = My.Resources.GodIcons.DaJi
        ElseIf Sel9 = 89 Then

            PictureBox9.Image = My.Resources.GodIcons.CuChulainn
        ElseIf Sel9 = 90 Then

            PictureBox9.Image = My.Resources.GodIcons.Artio
        ElseIf Sel9 = 91 Then

            PictureBox9.Image = My.Resources.GodIcons.Hachiman
        ElseIf Sel9 = 92 Then

            PictureBox9.Image = My.Resources.GodIcons.Discordia
        End If

    End Sub

    Private Sub Ban4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ban4.SelectedIndexChanged
        Dim Sel10 As Integer

        Sel10 = Ban4.SelectedValue

        If Sel10 = 1 Then

            PictureBox10.Image = My.Resources.GodIcons.Agni
        ElseIf Sel10 = 2 Then

            PictureBox10.Image = My.Resources.GodIcons.Anubis
        ElseIf Sel10 = 3 Then

            PictureBox10.Image = My.Resources.GodIcons.Arachne
        ElseIf Sel10 = 4 Then

            PictureBox10.Image = My.Resources.GodIcons.Artemis
        ElseIf Sel10 = 5 Then

            PictureBox10.Image = My.Resources.GodIcons.Bastet
        ElseIf Sel10 = 6 Then

            PictureBox10.Image = My.Resources.GodIcons.Hades
        ElseIf Sel10 = 7 Then

            PictureBox10.Image = My.Resources.GodIcons.HeBo
        ElseIf Sel10 = 8 Then

            PictureBox10.Image = My.Resources.GodIcons.Hel
        ElseIf Sel10 = 9 Then

            PictureBox10.Image = My.Resources.GodIcons.HunBatz
        ElseIf Sel10 = 10 Then

            PictureBox10.Image = My.Resources.GodIcons.Kali
        ElseIf Sel10 = 11 Then

            PictureBox10.Image = My.Resources.GodIcons.Kukulkan
        ElseIf Sel10 = 12 Then

            PictureBox10.Image = My.Resources.GodIcons.Odin
        ElseIf Sel10 = 13 Then

            PictureBox10.Image = My.Resources.GodIcons.Ra
        ElseIf Sel10 = 14 Then

            PictureBox10.Image = My.Resources.GodIcons.Sobek
        ElseIf Sel10 = 15 Then

            PictureBox10.Image = My.Resources.GodIcons.Vamana
        ElseIf Sel10 = 16 Then

            PictureBox10.Image = My.Resources.GodIcons.Ymir
        ElseIf Sel10 = 17 Then

            PictureBox10.Image = My.Resources.GodIcons.Zeus
        ElseIf Sel10 = 18 Then

            PictureBox10.Image = My.Resources.GodIcons.GuanYu
        ElseIf Sel10 = 19 Then

            PictureBox10.Image = My.Resources.GodIcons.Bakasura
        ElseIf Sel10 = 20 Then

            PictureBox10.Image = My.Resources.GodIcons.Anhur
        ElseIf Sel10 = 21 Then

            PictureBox10.Image = My.Resources.GodIcons.Cupid
        ElseIf Sel10 = 22 Then

            PictureBox10.Image = My.Resources.GodIcons.Thor
        ElseIf Sel10 = 23 Then

            PictureBox10.Image = My.Resources.GodIcons.Ares
        ElseIf Sel10 = 24 Then

            PictureBox10.Image = My.Resources.GodIcons.Freya
        ElseIf Sel10 = 25 Then

            PictureBox10.Image = My.Resources.GodIcons.Loki
        ElseIf Sel10 = 26 Then

            PictureBox10.Image = My.Resources.GodIcons.Bacchus
        ElseIf Sel10 = 27 Then

            PictureBox10.Image = My.Resources.GodIcons.Xbalanque
        ElseIf Sel10 = 28 Then

            PictureBox10.Image = My.Resources.GodIcons.Hercules
        ElseIf Sel10 = 29 Then

            PictureBox10.Image = My.Resources.GodIcons.Vulcan
        ElseIf Sel10 = 30 Then

            PictureBox10.Image = My.Resources.GodIcons.Neith
        ElseIf Sel10 = 31 Then

            PictureBox10.Image = My.Resources.GodIcons.Poseidon
        ElseIf Sel10 = 32 Then

            PictureBox10.Image = My.Resources.GodIcons.Aphrodite
        ElseIf Sel10 = 33 Then

            PictureBox10.Image = My.Resources.GodIcons.Apollo
        ElseIf Sel10 = 34 Then

            PictureBox10.Image = My.Resources.GodIcons.NeZha
        ElseIf Sel10 = 35 Then

            PictureBox10.Image = My.Resources.GodIcons.Fenrir
        ElseIf Sel10 = 36 Then

            PictureBox10.Image = My.Resources.GodIcons.Isis
        ElseIf Sel10 = 37 Then

            PictureBox10.Image = My.Resources.GodIcons.Athena
        ElseIf Sel10 = 38 Then

            PictureBox10.Image = My.Resources.GodIcons.Chronos
        ElseIf Sel10 = 39 Then

            PictureBox10.Image = My.Resources.GodIcons.Chang_e
        ElseIf Sel10 = 40 Then

            PictureBox10.Image = My.Resources.GodIcons.Tyr
        ElseIf Sel10 = 41 Then

            PictureBox10.Image = My.Resources.GodIcons.ZhongKui
        ElseIf Sel10 = 42 Then

            PictureBox10.Image = My.Resources.GodIcons.Thanatos
        ElseIf Sel10 = 43 Then

            PictureBox10.Image = My.Resources.GodIcons.Mercury
        ElseIf Sel10 = 44 Then

            PictureBox10.Image = My.Resources.GodIcons.SunWukong
        ElseIf Sel10 = 45 Then

            PictureBox10.Image = My.Resources.GodIcons.AhMuzenCab
        ElseIf Sel10 = 46 Then

            PictureBox10.Image = My.Resources.GodIcons.NuWa
        ElseIf Sel10 = 47 Then

            PictureBox10.Image = My.Resources.GodIcons.Chaac
        ElseIf Sel10 = 48 Then

            PictureBox10.Image = My.Resources.GodIcons.Geb
        ElseIf Sel10 = 49 Then

            PictureBox10.Image = My.Resources.GodIcons.Nemesis
        ElseIf Sel10 = 50 Then

            PictureBox10.Image = My.Resources.GodIcons.Scylla
        ElseIf Sel10 = 51 Then

            PictureBox10.Image = My.Resources.GodIcons.Ullr
        ElseIf Sel10 = 52 Then

            PictureBox10.Image = My.Resources.GodIcons.Kumbhakarna
        ElseIf Sel10 = 53 Then

            PictureBox10.Image = My.Resources.GodIcons.Osiris
        ElseIf Sel10 = 54 Then

            PictureBox10.Image = My.Resources.GodIcons.Janus
        ElseIf Sel10 = 55 Then

            PictureBox10.Image = My.Resources.GodIcons.Rama
        ElseIf Sel10 = 56 Then

            PictureBox10.Image = My.Resources.GodIcons.Serqet
        ElseIf Sel10 = 57 Then

            PictureBox10.Image = My.Resources.GodIcons.Cabrakan
        ElseIf Sel10 = 58 Then

            PictureBox10.Image = My.Resources.GodIcons.Sylvanus
        ElseIf Sel10 = 59 Then

            PictureBox10.Image = My.Resources.GodIcons.Nox
        ElseIf Sel10 = 60 Then

            PictureBox10.Image = My.Resources.GodIcons.AoKuang
        ElseIf Sel10 = 61 Then

            PictureBox10.Image = My.Resources.GodIcons.Awilix
        ElseIf Sel10 = 62 Then

            PictureBox10.Image = My.Resources.GodIcons.HouYi
        ElseIf Sel10 = 63 Then

            PictureBox10.Image = My.Resources.GodIcons.Bellona
        ElseIf Sel10 = 64 Then

            PictureBox10.Image = My.Resources.GodIcons.Medusa
        ElseIf Sel10 = 65 Then

            PictureBox10.Image = My.Resources.GodIcons.AhPuch
        ElseIf Sel10 = 66 Then

            PictureBox10.Image = My.Resources.GodIcons.Ratatoskr
        ElseIf Sel10 = 67 Then

            PictureBox10.Image = My.Resources.GodIcons.Ravana
        ElseIf Sel10 = 68 Then

            PictureBox10.Image = My.Resources.GodIcons.Khepri
        ElseIf Sel10 = 69 Then

            PictureBox10.Image = My.Resources.GodIcons.XingTian
        ElseIf Sel10 = 70 Then

            PictureBox10.Image = My.Resources.GodIcons.Sol
        ElseIf Sel10 = 71 Then

            PictureBox10.Image = My.Resources.GodIcons.Chiron
        ElseIf Sel10 = 72 Then

            PictureBox10.Image = My.Resources.GodIcons.Amaterasu
        ElseIf Sel10 = 73 Then

            PictureBox10.Image = My.Resources.GodIcons.Raijin
        ElseIf Sel10 = 74 Then

            PictureBox10.Image = My.Resources.GodIcons.Skadi
        ElseIf Sel10 = 75 Then

            PictureBox10.Image = My.Resources.GodIcons.JingWei
        ElseIf Sel10 = 76 Then

            PictureBox10.Image = My.Resources.GodIcons.Susano
        ElseIf Sel10 = 77 Then

            PictureBox10.Image = My.Resources.GodIcons.Fafnir
        ElseIf Sel10 = 78 Then

            PictureBox10.Image = My.Resources.GodIcons.ErlangShen
        ElseIf Sel10 = 79 Then

            PictureBox10.Image = My.Resources.GodIcons.Terra
        ElseIf Sel10 = 80 Then

            PictureBox10.Image = My.Resources.GodIcons.Izanami
        ElseIf Sel10 = 81 Then

            PictureBox10.Image = My.Resources.GodIcons.Camazotz
        ElseIf Sel10 = 82 Then

            PictureBox10.Image = My.Resources.GodIcons.Thoth
        ElseIf Sel10 = 83 Then

            PictureBox10.Image = My.Resources.GodIcons.Nike
        ElseIf Sel10 = 84 Then

            PictureBox10.Image = My.Resources.GodIcons.TheMorrigan
        ElseIf Sel10 = 85 Then

            PictureBox10.Image = My.Resources.GodIcons.Kuzenbo
        ElseIf Sel10 = 86 Then

            PictureBox10.Image = My.Resources.GodIcons.Cernunnos
        ElseIf Sel10 = 87 Then

            PictureBox10.Image = My.Resources.GodIcons.Ganesha
        ElseIf Sel10 = 88 Then

            PictureBox10.Image = My.Resources.GodIcons.DaJi
        ElseIf Sel10 = 89 Then

            PictureBox10.Image = My.Resources.GodIcons.CuChulainn
        ElseIf Sel10 = 90 Then

            PictureBox10.Image = My.Resources.GodIcons.Artio
        ElseIf Sel10 = 91 Then

            PictureBox10.Image = My.Resources.GodIcons.Hachiman
        ElseIf Sel10 = 92 Then

            PictureBox10.Image = My.Resources.GodIcons.Discordia
        End If

    End Sub

    Private Sub Ban5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ban5.SelectedIndexChanged
        Dim Sel11 As Integer

        Sel11 = Ban5.SelectedValue

        If Sel11 = 1 Then

            PictureBox11.Image = My.Resources.GodIcons.Agni
        ElseIf Sel11 = 2 Then

            PictureBox11.Image = My.Resources.GodIcons.Anubis
        ElseIf Sel11 = 3 Then

            PictureBox11.Image = My.Resources.GodIcons.Arachne
        ElseIf Sel11 = 4 Then

            PictureBox11.Image = My.Resources.GodIcons.Artemis
        ElseIf Sel11 = 5 Then

            PictureBox11.Image = My.Resources.GodIcons.Bastet
        ElseIf Sel11 = 6 Then

            PictureBox11.Image = My.Resources.GodIcons.Hades
        ElseIf Sel11 = 7 Then

            PictureBox11.Image = My.Resources.GodIcons.HeBo
        ElseIf Sel11 = 8 Then

            PictureBox11.Image = My.Resources.GodIcons.Hel
        ElseIf Sel11 = 9 Then

            PictureBox11.Image = My.Resources.GodIcons.HunBatz
        ElseIf Sel11 = 10 Then

            PictureBox11.Image = My.Resources.GodIcons.Kali
        ElseIf Sel11 = 11 Then

            PictureBox11.Image = My.Resources.GodIcons.Kukulkan
        ElseIf Sel11 = 12 Then

            PictureBox11.Image = My.Resources.GodIcons.Odin
        ElseIf Sel11 = 13 Then

            PictureBox11.Image = My.Resources.GodIcons.Ra
        ElseIf Sel11 = 14 Then

            PictureBox11.Image = My.Resources.GodIcons.Sobek
        ElseIf Sel11 = 15 Then

            PictureBox11.Image = My.Resources.GodIcons.Vamana
        ElseIf Sel11 = 16 Then

            PictureBox11.Image = My.Resources.GodIcons.Ymir
        ElseIf Sel11 = 17 Then

            PictureBox11.Image = My.Resources.GodIcons.Zeus
        ElseIf Sel11 = 18 Then

            PictureBox11.Image = My.Resources.GodIcons.GuanYu
        ElseIf Sel11 = 19 Then

            PictureBox11.Image = My.Resources.GodIcons.Bakasura
        ElseIf Sel11 = 20 Then

            PictureBox11.Image = My.Resources.GodIcons.Anhur
        ElseIf Sel11 = 21 Then

            PictureBox11.Image = My.Resources.GodIcons.Cupid
        ElseIf Sel11 = 22 Then

            PictureBox11.Image = My.Resources.GodIcons.Thor
        ElseIf Sel11 = 23 Then

            PictureBox11.Image = My.Resources.GodIcons.Ares
        ElseIf Sel11 = 24 Then

            PictureBox11.Image = My.Resources.GodIcons.Freya
        ElseIf Sel11 = 25 Then

            PictureBox11.Image = My.Resources.GodIcons.Loki
        ElseIf Sel11 = 26 Then

            PictureBox11.Image = My.Resources.GodIcons.Bacchus
        ElseIf Sel11 = 27 Then

            PictureBox11.Image = My.Resources.GodIcons.Xbalanque
        ElseIf Sel11 = 28 Then

            PictureBox11.Image = My.Resources.GodIcons.Hercules
        ElseIf Sel11 = 29 Then

            PictureBox11.Image = My.Resources.GodIcons.Vulcan
        ElseIf Sel11 = 30 Then

            PictureBox11.Image = My.Resources.GodIcons.Neith
        ElseIf Sel11 = 31 Then

            PictureBox11.Image = My.Resources.GodIcons.Poseidon
        ElseIf Sel11 = 32 Then

            PictureBox11.Image = My.Resources.GodIcons.Aphrodite
        ElseIf Sel11 = 33 Then

            PictureBox11.Image = My.Resources.GodIcons.Apollo
        ElseIf Sel11 = 34 Then

            PictureBox11.Image = My.Resources.GodIcons.NeZha
        ElseIf Sel11 = 35 Then

            PictureBox11.Image = My.Resources.GodIcons.Fenrir
        ElseIf Sel11 = 36 Then

            PictureBox11.Image = My.Resources.GodIcons.Isis
        ElseIf Sel11 = 37 Then

            PictureBox11.Image = My.Resources.GodIcons.Athena
        ElseIf Sel11 = 38 Then

            PictureBox11.Image = My.Resources.GodIcons.Chronos
        ElseIf Sel11 = 39 Then

            PictureBox11.Image = My.Resources.GodIcons.Chang_e
        ElseIf Sel11 = 40 Then

            PictureBox11.Image = My.Resources.GodIcons.Tyr
        ElseIf Sel11 = 41 Then

            PictureBox11.Image = My.Resources.GodIcons.ZhongKui
        ElseIf Sel11 = 42 Then

            PictureBox11.Image = My.Resources.GodIcons.Thanatos
        ElseIf Sel11 = 43 Then

            PictureBox11.Image = My.Resources.GodIcons.Mercury
        ElseIf Sel11 = 44 Then

            PictureBox11.Image = My.Resources.GodIcons.SunWukong
        ElseIf Sel11 = 45 Then

            PictureBox11.Image = My.Resources.GodIcons.AhMuzenCab
        ElseIf Sel11 = 46 Then

            PictureBox11.Image = My.Resources.GodIcons.NuWa
        ElseIf Sel11 = 47 Then

            PictureBox11.Image = My.Resources.GodIcons.Chaac
        ElseIf Sel11 = 48 Then

            PictureBox11.Image = My.Resources.GodIcons.Geb
        ElseIf Sel11 = 49 Then

            PictureBox11.Image = My.Resources.GodIcons.Nemesis
        ElseIf Sel11 = 50 Then

            PictureBox11.Image = My.Resources.GodIcons.Scylla
        ElseIf Sel11 = 51 Then

            PictureBox11.Image = My.Resources.GodIcons.Ullr
        ElseIf Sel11 = 52 Then

            PictureBox11.Image = My.Resources.GodIcons.Kumbhakarna
        ElseIf Sel11 = 53 Then

            PictureBox11.Image = My.Resources.GodIcons.Osiris
        ElseIf Sel11 = 54 Then

            PictureBox11.Image = My.Resources.GodIcons.Janus
        ElseIf Sel11 = 55 Then

            PictureBox11.Image = My.Resources.GodIcons.Rama
        ElseIf Sel11 = 56 Then

            PictureBox11.Image = My.Resources.GodIcons.Serqet
        ElseIf Sel11 = 57 Then

            PictureBox11.Image = My.Resources.GodIcons.Cabrakan
        ElseIf Sel11 = 58 Then

            PictureBox11.Image = My.Resources.GodIcons.Sylvanus
        ElseIf Sel11 = 59 Then

            PictureBox11.Image = My.Resources.GodIcons.Nox
        ElseIf Sel11 = 60 Then

            PictureBox11.Image = My.Resources.GodIcons.AoKuang
        ElseIf Sel11 = 61 Then

            PictureBox11.Image = My.Resources.GodIcons.Awilix
        ElseIf Sel11 = 62 Then

            PictureBox11.Image = My.Resources.GodIcons.HouYi
        ElseIf Sel11 = 63 Then

            PictureBox11.Image = My.Resources.GodIcons.Bellona
        ElseIf Sel11 = 64 Then

            PictureBox11.Image = My.Resources.GodIcons.Medusa
        ElseIf Sel11 = 65 Then

            PictureBox11.Image = My.Resources.GodIcons.AhPuch
        ElseIf Sel11 = 66 Then

            PictureBox11.Image = My.Resources.GodIcons.Ratatoskr
        ElseIf Sel11 = 67 Then

            PictureBox11.Image = My.Resources.GodIcons.Ravana
        ElseIf Sel11 = 68 Then

            PictureBox11.Image = My.Resources.GodIcons.Khepri
        ElseIf Sel11 = 69 Then

            PictureBox11.Image = My.Resources.GodIcons.XingTian
        ElseIf Sel11 = 70 Then

            PictureBox11.Image = My.Resources.GodIcons.Sol
        ElseIf Sel11 = 71 Then

            PictureBox11.Image = My.Resources.GodIcons.Chiron
        ElseIf Sel11 = 72 Then

            PictureBox11.Image = My.Resources.GodIcons.Amaterasu
        ElseIf Sel11 = 73 Then

            PictureBox11.Image = My.Resources.GodIcons.Raijin
        ElseIf Sel11 = 74 Then

            PictureBox11.Image = My.Resources.GodIcons.Skadi
        ElseIf Sel11 = 75 Then

            PictureBox11.Image = My.Resources.GodIcons.JingWei
        ElseIf Sel11 = 76 Then

            PictureBox11.Image = My.Resources.GodIcons.Susano
        ElseIf Sel11 = 77 Then

            PictureBox11.Image = My.Resources.GodIcons.Fafnir
        ElseIf Sel11 = 78 Then

            PictureBox11.Image = My.Resources.GodIcons.ErlangShen
        ElseIf Sel11 = 79 Then

            PictureBox11.Image = My.Resources.GodIcons.Terra
        ElseIf Sel11 = 80 Then

            PictureBox11.Image = My.Resources.GodIcons.Izanami
        ElseIf Sel11 = 81 Then

            PictureBox11.Image = My.Resources.GodIcons.Camazotz
        ElseIf Sel11 = 82 Then

            PictureBox11.Image = My.Resources.GodIcons.Thoth
        ElseIf Sel11 = 83 Then

            PictureBox11.Image = My.Resources.GodIcons.Nike
        ElseIf Sel11 = 84 Then

            PictureBox11.Image = My.Resources.GodIcons.TheMorrigan
        ElseIf Sel11 = 85 Then

            PictureBox11.Image = My.Resources.GodIcons.Kuzenbo
        ElseIf Sel11 = 86 Then

            PictureBox11.Image = My.Resources.GodIcons.Cernunnos
        ElseIf Sel11 = 87 Then

            PictureBox11.Image = My.Resources.GodIcons.Ganesha
        ElseIf Sel11 = 88 Then

            PictureBox11.Image = My.Resources.GodIcons.DaJi
        ElseIf Sel11 = 89 Then

            PictureBox11.Image = My.Resources.GodIcons.CuChulainn
        ElseIf Sel11 = 90 Then

            PictureBox11.Image = My.Resources.GodIcons.Artio
        ElseIf Sel11 = 91 Then

            PictureBox11.Image = My.Resources.GodIcons.Hachiman
        ElseIf Sel11 = 92 Then

            PictureBox11.Image = My.Resources.GodIcons.Discordia
        End If

    End Sub

    Private Sub Ban6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ban6.SelectedIndexChanged
        Dim Sel12 As Integer

        Sel12 = Ban6.SelectedValue

        If Sel12 = 1 Then

            PictureBox12.Image = My.Resources.GodIcons.Agni
        ElseIf Sel12 = 2 Then

            PictureBox12.Image = My.Resources.GodIcons.Anubis
        ElseIf Sel12 = 3 Then

            PictureBox12.Image = My.Resources.GodIcons.Arachne
        ElseIf Sel12 = 4 Then

            PictureBox12.Image = My.Resources.GodIcons.Artemis
        ElseIf Sel12 = 5 Then

            PictureBox12.Image = My.Resources.GodIcons.Bastet
        ElseIf Sel12 = 6 Then

            PictureBox12.Image = My.Resources.GodIcons.Hades
        ElseIf Sel12 = 7 Then

            PictureBox12.Image = My.Resources.GodIcons.HeBo
        ElseIf Sel12 = 8 Then

            PictureBox12.Image = My.Resources.GodIcons.Hel
        ElseIf Sel12 = 9 Then

            PictureBox12.Image = My.Resources.GodIcons.HunBatz
        ElseIf Sel12 = 10 Then

            PictureBox12.Image = My.Resources.GodIcons.Kali
        ElseIf Sel12 = 11 Then

            PictureBox12.Image = My.Resources.GodIcons.Kukulkan
        ElseIf Sel12 = 12 Then

            PictureBox12.Image = My.Resources.GodIcons.Odin
        ElseIf Sel12 = 13 Then

            PictureBox12.Image = My.Resources.GodIcons.Ra
        ElseIf Sel12 = 14 Then

            PictureBox12.Image = My.Resources.GodIcons.Sobek
        ElseIf Sel12 = 15 Then

            PictureBox12.Image = My.Resources.GodIcons.Vamana
        ElseIf Sel12 = 16 Then

            PictureBox12.Image = My.Resources.GodIcons.Ymir
        ElseIf Sel12 = 17 Then

            PictureBox12.Image = My.Resources.GodIcons.Zeus
        ElseIf Sel12 = 18 Then

            PictureBox12.Image = My.Resources.GodIcons.GuanYu
        ElseIf Sel12 = 19 Then

            PictureBox12.Image = My.Resources.GodIcons.Bakasura
        ElseIf Sel12 = 20 Then

            PictureBox12.Image = My.Resources.GodIcons.Anhur
        ElseIf Sel12 = 21 Then

            PictureBox12.Image = My.Resources.GodIcons.Cupid
        ElseIf Sel12 = 22 Then

            PictureBox12.Image = My.Resources.GodIcons.Thor
        ElseIf Sel12 = 23 Then

            PictureBox12.Image = My.Resources.GodIcons.Ares
        ElseIf Sel12 = 24 Then

            PictureBox12.Image = My.Resources.GodIcons.Freya
        ElseIf Sel12 = 25 Then

            PictureBox12.Image = My.Resources.GodIcons.Loki
        ElseIf Sel12 = 26 Then

            PictureBox12.Image = My.Resources.GodIcons.Bacchus
        ElseIf Sel12 = 27 Then

            PictureBox12.Image = My.Resources.GodIcons.Xbalanque
        ElseIf Sel12 = 28 Then

            PictureBox12.Image = My.Resources.GodIcons.Hercules
        ElseIf Sel12 = 29 Then

            PictureBox12.Image = My.Resources.GodIcons.Vulcan
        ElseIf Sel12 = 30 Then

            PictureBox12.Image = My.Resources.GodIcons.Neith
        ElseIf Sel12 = 31 Then

            PictureBox12.Image = My.Resources.GodIcons.Poseidon
        ElseIf Sel12 = 32 Then

            PictureBox12.Image = My.Resources.GodIcons.Aphrodite
        ElseIf Sel12 = 33 Then

            PictureBox12.Image = My.Resources.GodIcons.Apollo
        ElseIf Sel12 = 34 Then

            PictureBox12.Image = My.Resources.GodIcons.NeZha
        ElseIf Sel12 = 35 Then

            PictureBox12.Image = My.Resources.GodIcons.Fenrir
        ElseIf Sel12 = 36 Then

            PictureBox12.Image = My.Resources.GodIcons.Isis
        ElseIf Sel12 = 37 Then

            PictureBox12.Image = My.Resources.GodIcons.Athena
        ElseIf Sel12 = 38 Then

            PictureBox12.Image = My.Resources.GodIcons.Chronos
        ElseIf Sel12 = 39 Then

            PictureBox12.Image = My.Resources.GodIcons.Chang_e
        ElseIf Sel12 = 40 Then

            PictureBox12.Image = My.Resources.GodIcons.Tyr
        ElseIf Sel12 = 41 Then

            PictureBox12.Image = My.Resources.GodIcons.ZhongKui
        ElseIf Sel12 = 42 Then

            PictureBox12.Image = My.Resources.GodIcons.Thanatos
        ElseIf Sel12 = 43 Then

            PictureBox12.Image = My.Resources.GodIcons.Mercury
        ElseIf Sel12 = 44 Then

            PictureBox12.Image = My.Resources.GodIcons.SunWukong
        ElseIf Sel12 = 45 Then

            PictureBox12.Image = My.Resources.GodIcons.AhMuzenCab
        ElseIf Sel12 = 46 Then

            PictureBox12.Image = My.Resources.GodIcons.NuWa
        ElseIf Sel12 = 47 Then

            PictureBox12.Image = My.Resources.GodIcons.Chaac
        ElseIf Sel12 = 48 Then

            PictureBox12.Image = My.Resources.GodIcons.Geb
        ElseIf Sel12 = 49 Then

            PictureBox12.Image = My.Resources.GodIcons.Nemesis
        ElseIf Sel12 = 50 Then

            PictureBox12.Image = My.Resources.GodIcons.Scylla
        ElseIf Sel12 = 51 Then

            PictureBox12.Image = My.Resources.GodIcons.Ullr
        ElseIf Sel12 = 52 Then

            PictureBox12.Image = My.Resources.GodIcons.Kumbhakarna
        ElseIf Sel12 = 53 Then

            PictureBox12.Image = My.Resources.GodIcons.Osiris
        ElseIf Sel12 = 54 Then

            PictureBox12.Image = My.Resources.GodIcons.Janus
        ElseIf Sel12 = 55 Then

            PictureBox12.Image = My.Resources.GodIcons.Rama
        ElseIf Sel12 = 56 Then

            PictureBox12.Image = My.Resources.GodIcons.Serqet
        ElseIf Sel12 = 57 Then

            PictureBox12.Image = My.Resources.GodIcons.Cabrakan
        ElseIf Sel12 = 58 Then

            PictureBox12.Image = My.Resources.GodIcons.Sylvanus
        ElseIf Sel12 = 59 Then

            PictureBox12.Image = My.Resources.GodIcons.Nox
        ElseIf Sel12 = 60 Then

            PictureBox12.Image = My.Resources.GodIcons.AoKuang
        ElseIf Sel12 = 61 Then

            PictureBox12.Image = My.Resources.GodIcons.Awilix
        ElseIf Sel12 = 62 Then

            PictureBox12.Image = My.Resources.GodIcons.HouYi
        ElseIf Sel12 = 63 Then

            PictureBox12.Image = My.Resources.GodIcons.Bellona
        ElseIf Sel12 = 64 Then

            PictureBox12.Image = My.Resources.GodIcons.Medusa
        ElseIf Sel12 = 65 Then

            PictureBox12.Image = My.Resources.GodIcons.AhPuch
        ElseIf Sel12 = 66 Then

            PictureBox12.Image = My.Resources.GodIcons.Ratatoskr
        ElseIf Sel12 = 67 Then

            PictureBox12.Image = My.Resources.GodIcons.Ravana
        ElseIf Sel12 = 68 Then

            PictureBox12.Image = My.Resources.GodIcons.Khepri
        ElseIf Sel12 = 69 Then

            PictureBox12.Image = My.Resources.GodIcons.XingTian
        ElseIf Sel12 = 70 Then

            PictureBox12.Image = My.Resources.GodIcons.Sol
        ElseIf Sel12 = 71 Then

            PictureBox12.Image = My.Resources.GodIcons.Chiron
        ElseIf Sel12 = 72 Then

            PictureBox12.Image = My.Resources.GodIcons.Amaterasu
        ElseIf Sel12 = 73 Then

            PictureBox12.Image = My.Resources.GodIcons.Raijin
        ElseIf Sel12 = 74 Then

            PictureBox12.Image = My.Resources.GodIcons.Skadi
        ElseIf Sel12 = 75 Then

            PictureBox12.Image = My.Resources.GodIcons.JingWei
        ElseIf Sel12 = 76 Then

            PictureBox12.Image = My.Resources.GodIcons.Susano
        ElseIf Sel12 = 77 Then

            PictureBox12.Image = My.Resources.GodIcons.Fafnir
        ElseIf Sel12 = 78 Then

            PictureBox12.Image = My.Resources.GodIcons.ErlangShen
        ElseIf Sel12 = 79 Then

            PictureBox12.Image = My.Resources.GodIcons.Terra
        ElseIf Sel12 = 80 Then

            PictureBox12.Image = My.Resources.GodIcons.Izanami
        ElseIf Sel12 = 81 Then

            PictureBox12.Image = My.Resources.GodIcons.Camazotz
        ElseIf Sel12 = 82 Then

            PictureBox12.Image = My.Resources.GodIcons.Thoth
        ElseIf Sel12 = 83 Then

            PictureBox12.Image = My.Resources.GodIcons.Nike
        ElseIf Sel12 = 84 Then

            PictureBox12.Image = My.Resources.GodIcons.TheMorrigan
        ElseIf Sel12 = 85 Then

            PictureBox12.Image = My.Resources.GodIcons.Kuzenbo
        ElseIf Sel12 = 86 Then

            PictureBox12.Image = My.Resources.GodIcons.Cernunnos
        ElseIf Sel12 = 87 Then

            PictureBox12.Image = My.Resources.GodIcons.Ganesha
        ElseIf Sel12 = 88 Then

            PictureBox12.Image = My.Resources.GodIcons.DaJi
        ElseIf Sel12 = 89 Then

            PictureBox12.Image = My.Resources.GodIcons.CuChulainn
        ElseIf Sel12 = 90 Then

            PictureBox12.Image = My.Resources.GodIcons.Artio
        ElseIf Sel12 = 91 Then

            PictureBox12.Image = My.Resources.GodIcons.Hachiman
        ElseIf Sel12 = 92 Then

            PictureBox12.Image = My.Resources.GodIcons.Discordia
        End If

    End Sub

    Private Sub AddPaB_Click(sender As Object, e As EventArgs) Handles AddPaB.Click

        Dim LastInsert As Integer
        LastInsert = Me.JoustMatchesTableAdapter.LastInsert()

        'Order Side Picks
        Me.JoustPicksTableAdapter.AddPicks(Val(LastInsert), 1, God1.SelectedValue)
        Me.JoustPicksTableAdapter.AddPicks(Val(LastInsert), 1, God2.SelectedValue)
        Me.JoustPicksTableAdapter.AddPicks(Val(LastInsert), 1, God3.SelectedValue)

        'Chaos Side Picks
        Me.JoustPicksTableAdapter.AddPicks(Val(LastInsert), 2, God4.SelectedValue)
        Me.JoustPicksTableAdapter.AddPicks(Val(LastInsert), 2, God5.SelectedValue)
        Me.JoustPicksTableAdapter.AddPicks(Val(LastInsert), 2, God6.SelectedValue)

        'Order Side Bans
        Me.JoustBansTableAdapter.AddBans(Val(LastInsert), 1, Ban1.SelectedValue)
        Me.JoustBansTableAdapter.AddBans(Val(LastInsert), 1, Ban2.SelectedValue)
        Me.JoustBansTableAdapter.AddBans(Val(LastInsert), 1, Ban3.SelectedValue)

        'Chaos Side Bans 
        Me.JoustBansTableAdapter.AddBans(Val(LastInsert), 2, Ban4.SelectedValue)
        Me.JoustBansTableAdapter.AddBans(Val(LastInsert), 2, Ban5.SelectedValue)
        Me.JoustBansTableAdapter.AddBans(Val(LastInsert), 2, Ban6.SelectedValue)

        MsgBox("Match Added.")

        Me.Close()


    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        RankedJoust.Show()
        Me.Close()

    End Sub
End Class