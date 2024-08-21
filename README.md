<!-- default badges list -->
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Common .NET MAUI Memory Leaks and Their Fixes

This repository contains common patterns that cause memory leaks in .NET MAUI applications. Each problematic pattern is implemented in a separate page so that you can test it separatelly. 

Pages in this project include code that resolves a memory leak. You can uncomment this code to compare the behavior of the application with and without memory leak.

To check if a page persists in the memory, click the "sdfsdf" button that invokes the garbage collector and calculates the number alive pages.
**gif**
You may need to click the "sdfsdf" button 2-3 times to force the garbage collector destroys unused objects in multiple cycles. 

Below are the usage scenarios causing an object to stay in the memory:

1. Reference from a long-living object or static property
2. Event handler referenced by a long-living object
3. Delegate funnction  referenced by a long-living object
4. Control with an internal memory leak on a page
5. Singleton view registered in a dependency injection container

You can use .NET Meteor and Heapview to profile your .NET MAUI application. Refer to the following blog post for additional information: [.NET MAUI Memory Profiling - Identify and Fix Memory Leaks](https://community.devexpress.com/blogs/mobile/archive/2024/08/21/net-maui-memory-profiling-identify-and-fix-memory-leaks.aspx)

## Files to Review

- [DirectReferenceLeakPage.cs](./CS/TypicalMemoryLeaks/Pages/DirectReferenceLeakPage.xaml.cs)
- [EventLeakPage.cs](./CS/TypicalMemoryLeaks/Pages/EventLeakPage.xaml.cs)
- [ControlLeakPage.cs](./CS/TypicalMemoryLeaks/Pages/ControlLeakPage.xaml.cs)
- [SinglegonPage.cs](./CS/TypicalMemoryLeaks/Pages/SinglegonPage.xaml.cs)


## Documentation

- [Create Your First App with DevExpress Mobile UI for .NET MAUI (Visual Studio Code)](https://docs.devexpress.com/MAUI/404815/get-started/build-your-first-app-vscode)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=common-maui-memory-leaks&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=common-maui-memory-leaks&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
