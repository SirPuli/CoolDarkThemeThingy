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
# Errors and 'todo' stuff
I dont entirely like the look of the sliders. blue's okay, but it's normally used for light theme cases. i messed up the colour of the background with the slider too. Background does **absolutely** nothing (i think). Border is technically the background, and foreground is the slider-ery bit (the blue bit atm).

An error if you add a "Light/Dark" option thingy, and use Menus/MenuItems; in the test program thing, selecting the light theme just unloads DarkTheme.xaml, which makes WPF style everything to their default styles. But because i said that MenuItems need to have a special template, well WPF will try to look for that template and wont find it. As a result, the MenuItems will all turn into tiny squares because WPF has nothing to style them with. idk how to fix that unfortunately. rip.
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
Also, if you absolutely need my consent to do stuff like edit/use this theme stuff, then you can edit this and publish this all you want :) would be nice if you credited me at this github link, but eh.
