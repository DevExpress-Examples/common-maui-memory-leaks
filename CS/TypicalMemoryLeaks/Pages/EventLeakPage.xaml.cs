using TypicalMemoryLeaks;

namespace TypicalMemoryLeaks.Pages;

public partial class EventLeakPage : ContentPage
{
	public EventLeakPage()
	{
		InitializeComponent();
        MemoryHelper.Objects.Add(new WeakReference(this));
        
        //Issue
        Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;


        //FIX: Use Appearing/Disappearing event to subscribe/unsubscribe to/from events
        //Appearing += OnAppearing;
        //Disappearing += OnDisappearing;
    }

    //private void OnAppearing(object sender, EventArgs e) {
    //    Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
    //}

    //private void OnDisappearing(object sender, EventArgs e) {
    //    Accelerometer.ReadingChanged -= Accelerometer_ReadingChanged;
    //}

    private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e) {
        //...
    }
}