namespace FootballApp.UserControls;

public partial class ControlPlayer : UserControl
{
    public string Player_Number { get => Number_txt.Text; set => Number_txt.Text = value; }

    public ControlPlayer()
    {
        InitializeComponent();
    }

    public string Names
    {
        get => lbl_name.Text; set
        {
            lbl_name.Text = value;
        }
    }
    
    public int LoactionX
    {
        
        get => Location.X;
        set
        {
            Point name = new Point();
            name.X = value;
            name.Y = Location.Y;
            Location = name; 
        }
    }

    public int Marginsize
    {
        get => Margin.All;
        set
        {
            Padding name = new Padding();
            name.All = value;
            Margin = name;
        }
    }
}
