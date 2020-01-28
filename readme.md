# The dark theme app
i started making this maybe a few weeks ago. just drag and drop the DarkTheme.xaml (located in the ThemesFolder folder) into your project (anywhere) and inside App.xaml place this:
```xml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <ResourceDictionary Source="/ThemesFolder/DarkTheme.xaml"/>
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>

```

 and thats about it. Enjoy :)
# Some things about the MenuItems
MenuItems are relatively challenging to auto-style, so they require just a tiny bit of effort to give them the dark theme. MenuItems use a POPUP thingy which is quite difficult to get to work sometimes. But i think i did okay tbh. but i haven't managed to put the little arrow which shows when the MenuItem has children MenuItems.
this is the code for making a fully themed menu:
```xml
<Menu VerticalAlignment="Top">
    <MenuItem Header="File">
        <MenuItem Header="Save"                Template="{DynamicResource DropDownMenuItemTemplate}"/>
        <MenuItem Header="Save as..."          Template="{DynamicResource DropDownMenuItemTemplate}">
            <MenuItem Header="Text File (txt)" Template="{DynamicResource DropDownMenuItemTemplate}"/>
            <MenuItem Header="XML (xml)"       Template="{DynamicResource DropDownMenuItemTemplate}"/>
            <MenuItem Header="C# File (cs)"    Template="{DynamicResource DropDownMenuItemTemplate}"/>
        </MenuItem>
    </MenuItem>
</Menu>
```
