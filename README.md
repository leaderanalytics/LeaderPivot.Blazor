![Leader Analytics](./logo.png)

# LeaderPivot.Blazor

A pivot table control for Blazor.

## [Live Demo](https://leaderanalytics.com/blazor/leader-pivot-demo)

* Easy to implement and configure
* Drag and drop dimensions across axis
* User configurable measures
* Four color themes provided, customize or create your own.

![Dark](./screencap_dark.png) 

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

## Version History
3.0.0 - Optimize rendering, update to net 8.
2.0.0 - Improve themeing.
1.0.0 - Initial release, net 6.
