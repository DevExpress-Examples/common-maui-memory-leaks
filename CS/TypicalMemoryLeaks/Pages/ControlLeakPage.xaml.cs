namespace TypicalMemoryLeaks.Pages;

public partial class ControlLeakPage : ContentPage {
    public ControlLeakPage() {
        InitializeComponent();
        MemoryHelper.Objects.Add(new WeakReference(this));
    }
}
public class LabelEx : Label {
    public LabelEx() {
        DeviceDisplay.Current.MainDisplayInfoChanged += Current_MainDisplayInfoChanged;
    }

    private void Current_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e) {
        if (e.DisplayInfo.Orientation == DisplayOrientation.Portrait) {
            //...
        }
        else {
            //...
        }
    }
}