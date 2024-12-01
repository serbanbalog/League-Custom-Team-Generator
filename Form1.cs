using System.Data;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;
using System.Linq;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Random _rnd = new Random();
        List<string> _blueTeam, _redTeam, _redTeamChampionPool, _blueTeamChampionPool;
        List<string> _topChampions = new() { "Aatrox", "Ambessa", "Camille", "Cho'Gath", "Darius", "Dr. Mundo", "Fiora", "Gangplank", "Garen", "Gnar", "Gragas", "Gwen", "Illaoi", "Irelia", "Jax", "Jayce", "K'Sante", "Kayle", "Kennen", "Kled", "Malphite", "Mordekaiser", "Nasus", "Olaf", "Ornn", "Pantheon", "Poppy", "Quinn", "Renekton", "Riven", "Rumble", "Sett", "Shen", "Singed", "Sion", "Skarner", "Sylas", "Tahm Kench", "Teemo", "Trundle", "Tryndamere", "Udyr", "Urgot", "Vayne", "Vladimir", "Volibear", "Warwick", "Wukong", "Yasuo", "Yone", "Yorick" };
        List<string> _jungleChampions = new() { "Amumu", "Bel'Veth", "Brand", "Briar", "Diana", "Ekko", "Elise", "Evelynn", "Fiddlesticks", "Gragas", "Graves", "Hecarim", "Ivern", "Jarvan IV", "Jax", "Karthus", "Kayn", "Kha'Zix", "Kindred", "Lee Sin", "Lillia", "Maokai", "Master Yi", "Nidalee", "Nocturne", "Nunu", "Pantheon", "Poppy", "Rammus", "Rek'Sai", "Rengar", "Sejuani", "Shaco", "Shyvana", "Skarner", "Taliyah", "Talon", "Teemo", "Trundle", "Udyr", "Vi", "Viego", "Volibear", "Warwick", "Wukong", "Xin Zhao", "Zac" };
        List<string> _midChampions = new() { "Ahri", "Akali", "Akshan", "Anivia", "Annie", "Aurelion Sol", "Aurora", "Azir", "Brand", "Cassiopeia", "Corki", "Diana", "Ekko", "Fizz", "Galio", "Gragas", "Heimerdinger", "Hwei", "Irelia", "Jayce", "Karma", "Kassadin", "Katarina", "LeBlanc", "Lissandra", "Lux", "Malphite", "Malzahar", "Naafiri", "Neeko", "Orianna", "Pantheon", "Qiyana", "Rumble", "Ryze", "Swain", "Sylas", "Syndra", "Taliyah", "Talon", "Taric", "Tristana", "Twisted Fate", "Veigar", "Vel'Koz", "Vex", "Viktor", "Vladimir", "Xerath", "Yasuo", "Yone", "Zed", "Ziggs", "Zoe" };
        List<string> _adcChampions = new() { "Aphelios", "Ashe", "Caitlyn", "Draven", "Ezreal", "Jhin", "Jinx", "Kai'Sa", "Kalista", "Karthus", "Kog'Maw", "Lucian", "Miss Fortune", "Nilah", "Samira", "Senna", "Sivir", "Smolder", "Tristana", "Twitch", "Varus", "Vayne", "Xayah", "Zeri" };
        List<string> _supportChampions = new() { "Alistar", "Annie", "Bard", "Blitzcrank", "Brand", "Braum", "Janna", "Karma", "Leona", "Lulu", "Lux", "Malphite", "Maokai", "Milio", "Morgana", "Nami", "Nautilus", "Neeko", "Pantheon", "Pyke", "Rakan", "Rell", "Renata Glasc", "Senna", "Seraphine", "Sona", "Soraka", "Swain", "Tahm Kench", "Taric", "Thresh", "Vel'Koz", "Xerath", "Yuumi", "Zilean", "Zyra" };
        Dictionary<int, List<string>> _indexedChampionsByRole;
        string[] roleNames = { "Top", "Jungle", "Mid", "ADC", "Supp" };
        bool _isMirrorMatchupEnabled = false;
        string _selectedRoleForChampionReroll;

        public Form1()
        {
            InitializeComponent();
            _indexedChampionsByRole = new Dictionary<int, List<string>> { { 0, _topChampions }, { 1, _jungleChampions }, { 2, _midChampions }, { 3, _adcChampions }, { 4, _supportChampions } };
            roleSelectionBox.Items.AddRange(roleNames);
            _blueTeam = new();
            _redTeam = new();
            _redTeamChampionPool = new();
            _blueTeamChampionPool = new();
            _selectedRoleForChampionReroll = "";
        }

        private void teamBtn_Click(object sender, EventArgs e)
        {
            ClearTeams();
            SplitParticipantsIntoTeams();
            WriteTeamsIntoTextboxes();
        }

        private void teamAndRoleBtn_Click(object sender, EventArgs e)
        {
            ClearTeams();
            SplitParticipantsIntoTeams();
            AddRoleToEachParticipant();
            WriteTeamsIntoTextboxes();

        }
        private void teamRoleAndChampBtn_Click(object sender, EventArgs e)
        {
            ClearTeams();
            SplitParticipantsIntoTeams();
            AddRoleAndChampionToEachParticipant();
            WriteTeamsIntoTextboxes();
        }


        private void teamAndChampionBtn_Click(object sender, EventArgs e)
        {
            ClearTeams();
            ClearChampionPools();
            SplitParticipantsIntoTeams();
            CreateChampionPoolForEachTeam();
            WriteTeamsIntoTextboxes();
            WriteChampionPoolForTeam();
        }


        private void generateRoleBtn_Click(object sender, EventArgs e)
        {
            rndRoleTextbox.Text = roleNames[_rnd.Next(roleNames.Length - 1)];
        }

        private void ClearTeams()
        {
            blueTeamTextbox.Text = "";
            redTeamTextbox.Text = "";
        }

        private void ClearChampionPools()
        {
            _blueTeamChampionPool.Clear();
            _redTeamChampionPool.Clear();
        }

        private void championBtn_Click(object sender, EventArgs e)
        {
            if (_selectedRoleForChampionReroll != null && _selectedRoleForChampionReroll != "")
                GenerateChampionBasedOnRole();
        }

        private void SplitParticipantsIntoTeams()
        {
            var participants = textBox1.Text.Split("\r").OrderBy(_ => _rnd.Next()).ToList<string>();
            _blueTeam = participants.Slice(0, participants.Count / 2);
            _redTeam = participants.Slice(participants.Count / 2, participants.Count / 2);
        }

        private void WriteTeamsIntoTextboxes()
        {
            foreach (var participant in _blueTeam)
            {
                blueTeamTextbox.Text += participant.ToString() + "\r\n";
            }
            foreach (var participant in _redTeam)
            {
                redTeamTextbox.Text += participant.ToString() + "\r\n";
            }
        }

        private void WriteChampionPoolForTeam()
        {
            blueTeamTextbox.Text += "\r\nChampions: \r\n";
            foreach (var champion in _blueTeamChampionPool)
            {
                blueTeamTextbox.Text += champion.ToString() + "\r\n";
            }
            redTeamTextbox.Text += "\r\nChampions: \r\n";
            foreach (var champion in _redTeamChampionPool)
            {
                redTeamTextbox.Text += champion.ToString() + "\r\n";
            }
        }

        private void AddRoleToEachParticipant()
        {
            for (int i = 0; i < roleNames.Length; i++)
            {
                _blueTeam[i] += "-" + roleNames[i];
                _redTeam[i] += "-" + roleNames[i];
            }
        }

        private void AddRoleAndChampionToEachParticipant()
        {
            for (int i = 0; i < roleNames.Length; i++)
            {

                _indexedChampionsByRole.TryGetValue(i, out var champions);
                if (champions != null)
                {
                    var blueTeamChampion = GetRandomChampionFromList(_blueTeam, champions);
                    _blueTeam[i] += "-" + roleNames[i] + "-" + blueTeamChampion;

                    var redTeamChampion = GetRandomChampionFromList(_redTeam, champions);
                    if (!_isMirrorMatchupEnabled)
                        while (redTeamChampion == blueTeamChampion)
                            redTeamChampion = GetRandomChampionFromList(_redTeam, champions);
                    _redTeam[i] += "-" + roleNames[i] + "-" + redTeamChampion;
                }
            }
        }

        private void CreateChampionPoolForEachTeam()
        {
            for (int i = 0; i < roleNames.Length; i++)
            {
                _indexedChampionsByRole.TryGetValue(i, out var champions);
                if (champions != null)
                {
                    var blueTeamChampion = GetRandomChampionFromList(_blueTeamChampionPool, champions);
                    _blueTeamChampionPool.Add(blueTeamChampion);

                    var redTeamChampion = GetRandomChampionFromList(_redTeamChampionPool, champions);
                    if (!_isMirrorMatchupEnabled)
                        while (redTeamChampion == blueTeamChampion)
                            redTeamChampion = GetRandomChampionFromList(_redTeamChampionPool, champions);
                    _redTeamChampionPool.Add(redTeamChampion);

                }
            }
        }

        private string GetRandomChampionFromList(List<string> listToCheck, List<string> champions)
        {
            var champion = champions[_rnd.Next(champions.Count - 1)];

            if (listToCheck.Contains(champion))
                champion = champions[_rnd.Next(champions.Count - 1)];

            return champion;
        }

        private void GenerateChampionBasedOnRole()
        {
            switch (roleSelectionBox.Text)
            {
                case ("Top"):
                    randomChampionResultTextbox.Text = _topChampions[_rnd.Next(_topChampions.Count - 1)];
                    break;
                case ("Jungle"):
                    randomChampionResultTextbox.Text = _jungleChampions[_rnd.Next(_jungleChampions.Count - 1)];
                    break;
                case ("Mid"):
                    randomChampionResultTextbox.Text = _midChampions[_rnd.Next(_midChampions.Count - 1)];
                    break;
                case ("ADC"):
                    randomChampionResultTextbox.Text = _adcChampions[_rnd.Next(_adcChampions.Count - 1)];
                    break;
                case ("Supp"):
                    randomChampionResultTextbox.Text = _supportChampions[_rnd.Next(_supportChampions.Count - 1)];
                    break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _isMirrorMatchupEnabled = !_isMirrorMatchupEnabled;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var words = textBox1.Text.Split("\r");
            var wordCount = words.Length;
            if (words[words.Length - 1] == "\n" || words[words.Length - 1] == "")
                wordCount--;
            noOfParticipantsTextbox.Text = "Participants:" + wordCount;
        }

    }
}
