namespace TypicalMemoryLeaks.Pages;

public partial class SinglegonPage : ContentPage
{
	public SinglegonPage()
	{
		InitializeComponent();
        MemoryHelper.Objects.Add(new WeakReference(this));
    }
}