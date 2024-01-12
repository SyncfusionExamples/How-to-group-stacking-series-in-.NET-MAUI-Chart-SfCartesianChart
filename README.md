# How-to-group-stacking-series-in-.NET-MAUI-Chart-SfCartesianChart
This article explains how to group the stacking series in .NET MAUI Chart ([SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html)).


Stacking series are rendered in such a way that all the series are stacked. This is not desired when there are many stacking series in the chart. In such cases, the .NET MAUI Chart provides options to group the stacking series by using the [GroupingLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingSeriesBase.html#Syncfusion_Maui_Charts_StackingSeriesBase_GroupingLabel) property.

For example, consider four stacking column series grouped into two; **Microsoft** and **Google** by using the [GroupingLabel](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.StackingSeriesBase.html#Syncfusion_Maui_Charts_StackingSeriesBase_GroupingLabel)  property. Then, chart is rendered in two stacking columns at a point; one for **Microsoft** and the other for **Google** .


**XAML**
 
 ```XAML
        <chart:StackingColumnSeries ItemsSource="{Binding GoogleDrive}"
                                    XBindingPath="Month"
                                    YBindingPath="Value"
                                    GroupingLabel="Google">
        </chart:StackingColumnSeries>
        
        <chart:StackingColumnSeries ItemsSource="{Binding GoogleMeet}"
                                    XBindingPath="Month"
                                    YBindingPath="Value"
                                    GroupingLabel="Google">
        </chart:StackingColumnSeries>
        
        <chart:StackingColumnSeries ItemsSource="{Binding OneDrive}"
                                    XBindingPath="Month"
                                    YBindingPath="Value"
                                    GroupingLabel="Microsoft">
        </chart:StackingColumnSeries>

        <chart:StackingColumnSeries ItemsSource="{Binding Teams}"
                                    XBindingPath="Month"
                                    YBindingPath="Value"
                                    GroupingLabel="Microsoft">
        </chart:StackingColumnSeries>
 ```



**C#**
 ```C#
    var googleDriveSeries = new StackingColumnSeries
    {
        ItemsSource = "{Binding GoogleDrive}",
        XBindingPath = "Month",
        YBindingPath = "Value",
        GroupingLabel = "Google"
    };
    
    var googleMeetSeries = new StackingColumnSeries
    {
        ItemsSource = "{Binding GoogleMeet}",
        XBindingPath = "Month",
        YBindingPath = "Value",
        GroupingLabel = "Google"
    };
    
    var oneDriveSeries = new StackingColumnSeries
    {
        ItemsSource = "{Binding OneDrive}",
        XBindingPath = "Month",
        YBindingPath = "Value",
        GroupingLabel = "Microsoft"
    };
    
    var teamsSeries = new StackingColumnSeries
    {
        ItemsSource = "{Binding Teams}",
        XBindingPath = "Month",
        YBindingPath = "Value",
        GroupingLabel = "Microsoft"
    };
    
    chart.Series.Add(googleDriveSeries);
    chart.Series.Add(googleMeetSeries);
    chart.Series.Add(oneDriveSeries);
    chart.Series.Add(teamsSeries);
    
    this.Content=chart;

 ```


**Output**

**Before Grouping the series**

![Before.png](https://support.syncfusion.com/kb/agent/attachment/article/14906/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE2ODQ3Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.HkNoJEjizHEue3SwWvtBCMKvqxdYEEHfygCeHpKAEbM)


**After Grouping the series**

![After.png](https://support.syncfusion.com/kb/agent/attachment/article/14906/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE2ODQ4Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.D7L-K9Bt8oXeGXo-1LaOD9l3I6MHtfQ5zHKA-Y96vrY)
