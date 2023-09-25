using System.ComponentModel;

namespace ViewModels.BaseClass
{
    public class IBetegViewModel
    {
        bool IsBusy { get; set; }
        event PropertyChangedEventHandler PropertyChanged;
    }
}
