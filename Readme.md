<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128624972/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3334)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Disable specific detail tabs (master-detail)

This example create a custom grid control with the `DetailTabStyle` event. Handle this event to disable certain detail tabs based on a specific condition:

```csharp
private void myGridView1_DetailTabStyle(object sender, DetailTabStyleEventArgs e) {
    if (e.RowHandle % 2 == 0 && e.RelationIndex == 1)
        e.Enabled = false;
}
```


## Files to Review

* [DetailTabStyleEventArgs.cs](./CS/WindowsApplication3/DetailTabStyleEventArgs.cs) (VB: [DetailTabStyleEventArgs.vb](./VB/WindowsApplication3/DetailTabStyleEventArgs.vb))
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
* [MyGrid.cs](./CS/WindowsApplication3/MyGrid.cs) (VB: [MyGrid.vb](./VB/WindowsApplication3/MyGrid.vb))


## Documentation

* [Master-Detail Relationships](https://docs.devexpress.com/WindowsForms/3473/controls-and-libraries/data-grid/master-detail-relationships)
* [Working with Master-Detail Relationships in Code](https://docs.devexpress.com/WindowsForms/732/controls-and-libraries/data-grid/master-detail/working-with-master-detail-relationships-in-code)
