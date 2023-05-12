using System.Collections.ObjectModel;

namespace CollectionViewTest;

public partial class MainPage : ContentPage
{
     List <LapTimeClass> lapTimeList;
    public class LapTimeClass
    {
        public TimeSpan start { get; set; }
        public string EndTime { get; set; }
        public string LapTime { get; set; }
        public long LapCount { get; set; }
    }

    public MainPage()
	{
		InitializeComponent();
        lapTimeList = new List<LapTimeClass>();
        lapTimeList.Add(new LapTimeClass
        {
            LapTime = "asdf",
            EndTime = "adsf",
            LapCount = lapTimeList.Count,
        });
        lapTimeList.Add(new LapTimeClass
        {
            LapTime = "asdf",
            EndTime = "adsf",
            LapCount = lapTimeList.Count,
        }); LapTimeView.ItemsSource = lapTimeList;

    }


}

