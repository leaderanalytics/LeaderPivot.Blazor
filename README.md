![Leader Analytics](./logo.png)

# LeaderPivot.Blazor

A pivot table control for Blazor.

## [Live Demo](https://leaderanalytics.com/blazor/leaderpivotdemo)

* Easy to implement and configure
* Drag and drop dimensions across axis
* User configurable measures
* Four color themes provided, customize or create your own.

![Leader Analytics pivot table control](./screencap.png) 

# Getting Started

* [Get the demo application](https://github.com/leaderanalytics/LeaderPivot.BlazorDemo)

* [Get the test data application](https://github.com/leaderanalytics/LeaderPivot.TestData)

* [Get the NuGet package](https://www.nuget.org/packages/LeaderAnalytics.LeaderPivot.Blazor/)

* Create a data structure to model your denormalized data.  See the [`SalesData`](https://github.com/leaderanalytics/LeaderPivot.TestData/blob/main/LeaderPivot.TestData/SalesData.cs) class for an example.

* Create [Dimensions](https://github.com/leaderanalytics/LeaderPivot/blob/main/LeaderPivot/Dimension.cs) and [Measures](https://github.com/leaderanalytics/LeaderPivot/blob/main/LeaderPivot/Measure.cs).    Dimensions are used to group data.  Measures are used to create the values shown in each cell of the pivot table.  Examples are provided in the [TestData](https://github.com/leaderanalytics/LeaderPivot.TestData/blob/main/LeaderPivot.TestData/SalesData.cs) project.

* Add a [LeaderPivot control](https://github.com/leaderanalytics/LeaderPivot.BlazorDemo/blob/main/LeaderPivot.BlazorDemo/Pages/LeaderPivotDemo.razor) to your page.  

* Add LeaderPivot to your [dependency injection container](https://github.com/leaderanalytics/LeaderPivot.BlazorDemo/blob/main/LeaderPivot.BlazorDemo/Program.cs):

    `builder.Services.AddLeaderPivot();`

* Add css to [`index.html`](https://github.com/leaderanalytics/LeaderPivot.BlazorDemo/blob/main/LeaderPivot.BlazorDemo/wwwroot/index.html):

    
       
        <link href="_content/LeaderAnalytics.LeaderPivot.Blazor/leader-pivot.css" rel="stylesheet" />
      

[LeaderPivot WPF implementation is available here](https://github.com/leaderanalytics/LeaderPivot.XAML.WPF)
