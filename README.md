# How-to-show-or-hide-zooming-toolbar-items-in-UWP-Chart
This sample demonstrate how to show or hide zooming toolbar items in UWP Chart.

The [UWP SfChart](https://www.syncfusion.com/uwp-ui-controls/charts) Zooming Toolbar encompassed some buttons for performing actions like Zoom In/Out, Resetting, and selection zooming by using the [ToolBarItems](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Charts.ChartZoomPanBehavior.html#Syncfusion_UI_Xaml_Charts_ChartZoomPanBehavior_ToolBarItems) property.
 
You can show or hide the zooming toolbar by using the [EnableZoomingToolBar](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Charts.ChartZoomPanBehavior.html#Syncfusion_UI_Xaml_Charts_ChartZoomPanBehavior_EnableZoomingToolBar) property in the [ChartZoomPanBehavior](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Charts.ChartZoomPanBehavior.html) as per the following code snippet.

**[XAML]**

  ```
<chart:SfChart>
    <chart:SfChart.PrimaryAxis>
        <chart:DateTimeAxis LabelFormat="MMM, yyyy"/>
    </chart:SfChart.PrimaryAxis>

        <chart:SfChart.SecondaryAxis>
            <chart:NumericalAxis />
        </chart:SfChart.SecondaryAxis>

        <chart:SfChart.Behaviors>
            <chart:ChartZoomPanBehavior ToolBarItems="ZoomIn,ZoomOut,SelectZooming"
                                        EnableZoomingToolBar="True" 
                                        EnableSelectionZooming="True" />
        </chart:SfChart.Behaviors>


        <chart:FastLineSeries ItemsSource="{Binding Data}"
                              XBindingPath="Date"
                              YBindingPath="Load"/>
        </chart:SfChart>
  ```

## Output:

![Show or hide zooming toolbar items in UWP Chart](https://user-images.githubusercontent.com/61832185/209295360-635e381b-ce81-4c40-bdd7-104b8d2a76ec.png)

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## Knowledge base

**KB article:**[How to show or hide zooming toolbar items in UWP Chart?](https://support.syncfusion.com/kb/article/12179/how-to-show-or-hide-zooming-toolbar-items-in-uwp-chart)