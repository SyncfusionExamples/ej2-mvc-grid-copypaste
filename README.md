# Copying and Pasting Excel Sheet Data to EJ2 Grid ASP.NET MVC

Cross browser way to copy paste Excel sheet data to ASP.NET MVC Grid.

Register `paste` event for the grid element and handle the process the pasted data.

[Index.cshtml]

```javascript
document.getElementById('grid').addEventListener(ej.base.Browser.isIE ? 'keydown' : 'paste', function (e) {
        var tsv;
        if (e.ctrlKey && (e.keyCode == 86)) { //Handle copy paste in IE.
            tsv = window.clipboardData.getData('Text');
        } else {
            tsv = e.clipboardData.getData('Text')
        }
        if (tsv) {
            var ajax = new ej.base.Ajax("@Url.Action("OnPaste")");
            ajax.type = "POST";
            ajax.send(JSON.stringify({ pastedData: tsvJSON(tsv) }))
                .then(function (data) {
                    var grid = document.getElementById('grid').ej2_instances[0];
                    grid.dataSource = JSON.parse(data);
                });
        }
    });
```

Add a controller action to merge pasted data with the actual data and bound the result to the grid.

[HomeController.cs]

```c#
[HttpPost]
public ActionResult OnPaste(PostData data, string action)
{
    OrdersList.AddRange(data.pastedData);
    return Json(OrdersList);
}
```