# WPF ComboBox bugs repro
This repository is created to reproduce several functional and visual bugs present in WPF ComboBox after introducing Fluent themes and FluentMode, starting with .NET 9.

## [UPDATE]
After upgrading to .NET 10, this issue is still present.

**Bugs being showcased:**
1. ComboBox dropdown height issue
   - Select a Region from first ComboBox to trigger loading countries for that region in the second ComboBox (suggestion: select North America as it best illustrates the issue)
   - Open second ComboBox and notice the number of visible items (i.e. 3 for North America)
   - Switch to a different Region (suggestion: switch to Europe as it has more countries than North America)
   - Open the second ComboBox and notice that it still shows the same number of items
   - Every subsequent Region change will not update second ComboBox item count and visibility
   - If second region has less countries than the first one, Countries ComboBox dropdown height will remain the same (larger)
2. ComboBox dropdown scrollbar visibility and size
   - Repeate same steps as in first case
   - If second region has more countries than first, there will be no scrollbar visible
   - If second region has less countries than first one and scrollbar was visible then, it will remain visible with lower number of items

Scrollbar issue can be resolved by implicitly enabling it on each ComboBox, just add `ScrollViewer.VerticalScrollBarVisibility="Auto"`. However, after force-enabling the scrollbar, switching from region with more countries to one with less, vertical scrollbar will remain visible and dropdown will still be scrollable.

Opening and closing Countries ComboBox on app startup (before selecting a Region) or selecting an empty item which is present there (which is unexpected), and then selecting a Region will not populate the Countries ComboBox, it will remain completely empty.

All these issues are present while `ThemeMode` in `App.xaml` is set to `Light`/`Dark`/`System`. If `ThemeMode` is set to `None` or property is completely removed (effectivelly reverting to Aero2 builtin Windows theme), all the above mentioned issues are gone and both ComboBox start behaving perfectly normal

My guess is that this is related to incorrect dropdown, items and scrollbar size and visibility updates when Items collection changes and this is exclusive to Fluent theme.