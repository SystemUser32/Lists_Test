using System;
using CsharpGenerics_List;
using Gtk;

public partial class MainWindow : Gtk.Window
{

    ListContainer lc = new ListContainer();
    string[] assets;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        FillArray();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void Display(object sender, EventArgs e)
    {
        Random rand = new Random();
        int num = rand.Next(assets.Length);

        foreach(string i in assets)
        {
            lc._Add_(i);
        }

        label1.Text = lc.Value(num).ToString();

    }

    protected void FillArray()
    {
        assets = new string[]
        {
            "Mikoyan i Gurevich",
            "Ilyushin",
            "Antonov",
            "Sukhoi",
            "Yakovlev",
            "Myasishchev"
        };
    }
}

