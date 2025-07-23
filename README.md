## How to group stacking series in .NET MAUI SfCartesianChart

This article explains how to group the stacking series in [.NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts)

A stacked chart is a type of graph that displays multiple data series on top of one another, allowing you to see the total and individual contributions of each series to the whole. The .NET MAUI Cartesian Chart provide support to cluster the stacking series using the [GroupingLabel](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.StackingSeriesBase.html#Syncfusion_Maui_Toolkit_Charts_StackingSeriesBase_GroupingLabel) property.

Consider a scenario with four stacking column series grouped into two entities, namely **GroupOne** and **GroupTwo**, distinguished by the  [GroupingLabel](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.StackingSeriesBase.html#Syncfusion_Maui_Toolkit_Charts_StackingSeriesBase_GroupingLabel) property. In the resulting chart, two stacking columns are rendered at a specific point— one representing **GroupOne** and the other representing **GroupTwo**. Specifically, **TeamA** and **TeamB** are associated with **GroupOne**, while **TeamC** and **TeamD** are affiliated with **GroupTwo**.


**XAML**
 
 ```XAML
 <chart:SfCartesianChart>
        ...
        <chart:StackingColumnSeries ItemsSource="{Binding Data1}"
                                    XBindingPath="Month"
                                    YBindingPath="Value"
                                    Label="Team A"
                                    GroupingLabel="GroupOne">
        </chart:StackingColumnSeries>
        
        <chart:StackingColumnSeries ItemsSource="{Binding Data2}"
                                    XBindingPath="Month"
                                    YBindingPath="Value"
                                    Label="Team B"
                                    GroupingLabel="GroupOne">
        </chart:StackingColumnSeries>
        
        <chart:StackingColumnSeries ItemsSource="{Binding Data3}"
                                    XBindingPath="Month"
                                    Label="Team C"
                                    GroupingLabel="GroupTwo">
        </chart:StackingColumnSeries>

        <chart:StackingColumnSeries ItemsSource="{Binding Data4}"
                                    XBindingPath="Month"
                                    YBindingPath="Value"
                                    Label="Team D"
                                    GroupingLabel="GroupTwo">
        </chart:StackingColumnSeries>
        ...      
 </chart:SfCartesianChart>
 ```



**C#**
 ```C#
 
    SfCartesianChart chart = new SfCartesianChart();
    ...
    
    var teamASeries = new StackingColumnSeries
    {
        ItemsSource = "{Binding Data1}",
        XBindingPath = "Month",
        YBindingPath = "Value",
        Label="Team A",
        GroupingLabel="GroupOne"
    };
    
    var teamBSeries  = new StackingColumnSeries
    {
        ItemsSource = "{Binding Data2}",
        XBindingPath = "Month",
        YBindingPath = "Value",
        Label="Team B",
        GroupingLabel="GroupOne"
    };
    
    var teamCSeries  = new StackingColumnSeries
    {
        ItemsSource = "{Binding Data3}",
        XBindingPath = "Month",
        YBindingPath = "Value",
        Label="Team C",
        GroupingLabel="GroupTwo"
    };
    
    var teamDSeries  = new StackingColumnSeries
    {
        ItemsSource = "{Binding Data4}",
        XBindingPath = "Month",
        YBindingPath = "Value",
        Label="Team D",
        GroupingLabel="GroupTwo"
    };
    
    chart.Series.Add(teamASeries);
    chart.Series.Add(teamBSeries);
    chart.Series.Add(teamCSeries);
    chart.Series.Add(teamDSeries);
    
    this.Content=chart;

 ```


**Output**

**Before Grouping the series**

![Before.png](https://support.syncfusion.com/kb/agent/attachment/article/14906/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE3MjkyIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.ELSzAa4NCiIdr_mS0Bg8T7XVE9y_g-2DbwnQJ0thedE)

**After Grouping the series**

![After.png](https://support.syncfusion.com/kb/agent/attachment/article/14906/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE3Mjg2Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9._IlGUeutt5mOugHIfa8Rke-BiIgwJ6yRrwR0r27ZNs4)

### Troubleshooting
**Path too long exception**
If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For more details, refer to the KB on [how to group stacking series in .NET MAUI SfCartesianChart](https://support.syncfusion.com/kb/article/14906/how-to-group-stacking-series-in-net-maui-chart-sfcartesianchart-).
