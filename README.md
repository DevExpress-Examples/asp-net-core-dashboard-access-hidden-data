<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/353983354/20.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T987287)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
*Files to look at*:

* [Index.cshtml](./CS/Views/Home/Index.cshtml)

# Dashboard for ASP.NET Core - How to access hidden field values

This example shows how to access values of invisible field at the API level when the end user clicks the corresponding item.

## Example Structure

Let us consider that you have a `Department` field in your datasource and you do not wish to display it directly in the dashboard item. At the same time, the value of this field is required at the API level. For example, you need to redirect the end-user to the specific webpage based on the `Department` field value when the corresponding item is clicked. In this scenario you can use our [Underlying and Displayed Data](https://docs.devexpress.com/Dashboard/18078/web-dashboard/aspnet-web-forms-dashboard-control/obtain-underlying-and-displayed-data) API in the [ViewerApiExtension.itemClick](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.ViewerApiExtensionOptions?p=netframework#js_devexpress_dashboard_viewerapiextensionoptions_onitemclick) event handler. According to the NOTE in the [Measure Values](https://docs.devexpress.com/Dashboard/18078/web-dashboard/aspnet-web-forms-dashboard-control/obtain-underlying-and-displayed-data#measure-values) help section, you can put the `Department` field to the "HIDDEN MEASURES" section and set its summary type to Min or Max:

![](images/screenshot.png)

Then, field values will be accessible in code.

## Documentation

- [Underlying and Displayed Data](https://docs.devexpress.com/Dashboard/18078/web-dashboard/aspnet-web-forms-dashboard-control/obtain-underlying-and-displayed-data)

## More Examples

- [Web Dashboard - How to get data from a clicked dashboard item](https://github.com/DevExpress-Examples/Web-Dashboard---How-to-get-data-from-a-clicked-dashboard-item)
- [ASP.NET Web Forms Dashboard Control - How to obtain a dashboard item's underlying data for a clicked visual element](https://github.com/DevExpress-Examples/aspxdashboard-how-to-obtain-a-dashboard-items-underlying-data-for-a-clicked-visual-element-t492257)
