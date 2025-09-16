# ComboBoxBugRepro1
This repository is used to reproduce several visual bugs still present in WPF with .NET 9 (.NET 9.0.9 was used at the time when this was created).

To fully experience all the bugs, make sure you first select "North America" in the Region ComboBox. This will load only 3 countries. After that, switch to any other region and notice how you can still see only 3 items, even though other regions have more.

Bugs being showcased:
1. On 1st Region selection, Country ComboBox will properly load all the belonging countries. On every subsequent Region change, you will notice how Country ComboBox dropdown height still matches height from first selection
2. On every subsequent selection after 1st, Country ComboBox will always show same number of items loaded on 1st selection
3. There is no vertical scroll bar even when there's more items being loaded than can fit in available dropdown space

Scrollbar isue can be resolved by implicitly enabling it on each ComboBox, just add `ScrollViewer.VerticalScrollBarVisibility="Auto"`.

4. After enabling (fixing) the scroll bar visibility, switching from "Europe" to "North America", even though there are fewer countries, vertical scroll bar will remain visible and dropdown will still be scrollable

If you open the Country ComboBox right after starting the app, it will show an empty dropdown (which is expected). However, if you click on (select) the "empty item" (sometimes you don't have to select anything, just open the Country ComboBox, close it and go to selecting the Region) and then change the Region, the Country ComboBox will continue to show an "empty item" or rather no items at all.

All these issues persist with `ThemeMode` in `App.xaml` being set to `Dark`, `Light` or `System`. If you change the value to `Noone`, this will effectively disable the Fluent theme and revert to the old Aero2, in which case all of the above issues are gone, as in, everything starts to work as expected.