namespace TypicalMemoryLeaks.Pages;

public partial class DirectReferenceLeakPage : ContentPage {
    public DirectReferenceLeakPage() {
        InitializeComponent();
        MemoryHelper.Objects.Add(new WeakReference(this));

        //Issue
        ((AppShell)App.Current.MainPage).OpenedChildPages.Add(this);

        //FIX: Use Appearing and Disappearing event to add and remove static references
        //Appearing += OnAppearing;
        //Disappearing += OnDisappearing;
    }

    //private void OnAppearing(object sender, EventArgs e) {
    //    ((AppShell)App.Current.MainPage).OpenedChildPages.Add(this);
    //}

    //private void OnDisappearing(object sender, EventArgs e) {
    //    ((AppShell)App.Current.MainPage).OpenedChildPages.Remove(this);
    //}
}