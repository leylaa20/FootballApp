using FootballApp.Forms;
using FootballApp.Models;
using FootballApp.UserControls;

namespace FootballApp;

public partial class MainForm : Form
{
    public List<Player> Players { get; set; } = FakeDataService.GetPlayers();
    public StadiumForm StadiumForm { get; set; } = new StadiumForm();

    public string[] Position = new string[] { "F", "DD", "MD", "GK" };

    public MainForm()
    {
        InitializeComponent();
        cBox_CountryNames.DataSource = FakeDataService.GetCountryNames();
        cBox_CountryNames.SelectedIndex = 14;
        cBox_TacticsFormats.DataSource = FakeDataService.GetTacticFormats();
    }

    private void cBox_TacticsFormats_SelectedIndexChanged(object sender, EventArgs e)
    {
        Players.Clear();
        Players = FakeDataService.GetPlayers();

        int[] tacticFormat = Array.ConvertAll(cBox_TacticsFormats.Text.Split('-'), int.Parse);
        int index = 0, arrayindex = 0, num = 0;

        foreach (var userControl in panel_Players.Controls)
        {
            if (userControl is UC_Player uc)
            {
                uc.txt_Position.Text = Position[arrayindex];
                Players[index].Position = Position[arrayindex];
                uc.txt_Number.Text = Players[index].Number.ToString();
                uc.txt_Name.Text = Players[index].Name;
                index++;

                if (index == 11) return;

                if ((tacticFormat[arrayindex] + num) == index)
                {
                    num += tacticFormat[arrayindex];
                    arrayindex++;
                }
            }
        }
    }

    private void btn_Generate_Click(object sender, EventArgs e)
    {
        StadiumForm.CountryName = cBox_CountryNames.Text;
        StadiumForm.Players = Players;
        StadiumForm.Row();
        StadiumForm.ShowDialog();

    }
}