 
### Coding4Fun.Phone.Controls.BooleanToVisibilityConverter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.UI.Xaml.Controls/Frame.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|BooleanToVisibilityConverter            |Type           |Always       |             |
|Convert                                 |Call           |             |             |
|ConvertBack                             |Call           |             |             |
 
### Coding4Fun.Phone.Controls.Converter.BooleanToVisibilityConverter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Coding4Fun.Phone.Controls.Converters/VisibilityToBooleanConverter.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|BooleanToVisibilityConverter            |Type           |Always       |             |
|Convert                                 |Call           |             |             |
|ConvertBack                             |Call           |             |             |
 
### Coding4Fun.Phone.Controls.Converter.StringToVisibilityConverter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Coding4Fun.Phone.Controls.Converters/BooleanToVisibilityConverter.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|StringToVisibilityConverter             |Type           |Always       |             |
|Convert                                 |Call           |             |             |
|ConvertBack                             |Call           |             |             |
 
### Coding4Fun.Phone.Controls.ToastPrompt
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Coding4Fun.Phone.Controls.Converters/StringToVisibility.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ToastPrompt                             |Type           |Always       |             |
|Overlay                                 |MemberAccess   |             |Always       |
|Foreground                              |MemberAccess   |             |Always       |
|Background                              |MemberAccess   |             |Always       |
|TextOrientation                         |MemberAccess   |             |Always       |
|FontSize                                |MemberAccess   |             |Always       |
|IsTimerEnabled                          |MemberAccess   |             |Always       |
|Completed                               |Assign         |             |Always       |
|Loaded                                  |Assign         |             |Always       |
 
### Coding4Fun.Toolkit.Controls.AboutPrompt
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Coding4Fun.Toolkit.Controls/Toast.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AboutPrompt                             |Type           |Always       |             |
|IsPromptMode                            |MemberAccess   |             |Always       |
|Body                                    |MemberAccess   |             |             |
|Footer                                  |MemberAccess   |             |             |
|Title                                   |MemberAccess   |             |             |
|VersionNumber                           |MemberAccess   |             |             |
|WaterMark                               |MemberAccess   |             |             |
|Show                                    |Call           |             |             |
|Completed                               |MemberAccess   |             |             |
 
### Coding4Fun.Toolkit.Controls.AboutPromptItem
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Coding4Fun.Toolkit.Controls/AboutPrompt.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AboutPromptItem                         |Type           |Always       |             |
|AuthorName                              |MemberAccess   |             |             |
|EmailAddress                            |MemberAccess   |             |             |
|Role                                    |MemberAccess   |             |             |
|WebSiteDisplay                          |MemberAccess   |             |             |
|WebSiteUrl                              |MemberAccess   |             |             |
 
### Coding4Fun.Toolkit.Controls.Data.PhoneHelper
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Coding4Fun.Toolkit.Controls/AboutPromptItem.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PhoneHelper                             |Type           |             |             |
|GetAppAttribute                         |Call           |Conditionally|             |
 
### Coding4Fun.Toolkit.Controls.InputPrompt
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Coding4Fun.Toolkit.Controls.Data/Package.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|InputPrompt                             |Type           |Always       |             |
|Overlay                                 |MemberAccess   |             |Always       |
|IsOpen                                  |MemberAccess   |             |Always       |
|InputScore                              |MemberAccess   |             |             |
|Title                                   |MemberAccess   |             |             |
|Message                                 |MemberAccess   |             |             |
|Completed                               |Assign         |             |             |
|Completed                               |MemberAccess   |             |             |
 
### Coding4Fun.Toolkit.Controls.MessagePrompt
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Coding4Fun.Toolkit.Controls/InputPrompt.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MessagePrompt                           |Type           |Always       |             |
|IsPromptMode                            |MemberAccess   |             |Always       |
|Overlay                                 |MemberAccess   |             |Always       |
|IsAppBarVisible                         |MemberAccess   |             |Always       |
|IsCancelVisible                         |MemberAccess   |             |Always       |
|Body                                    |MemberAccess   |             |             |
|Title                                   |MemberAccess   |             |             |
|Show                                    |Call           |             |             |
|Completed                               |MemberAccess   |             |             |
 
### Coding4Fun.Toolkit.Controls.PopUpEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Coding4Fun.Toolkit.Controls/MessagePrompt.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PopUpEventArgs                          |Type           |             |Always       |
|Error                                   |MemberAccess   |             |Always       |
|PopUpResult                             |MemberAccess   |             |Always       |
|Result                                  |MemberAccess   |             |Always       |
 
### Coding4Fun.Toolkit.Controls.ProgressOverlay
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Coding4Fun.Toolkit.Controls/PopUpEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ProgressOverlay                         |Type           |             |             |
|Focus                                   |MemberAccess   |             |             |
|Visibility                              |MemberAccess   |             |             |
|IsEnabled                               |MemberAccess   |             |             |
|Content                                 |MemberAccess   |             |Always       |
|ContentTemplate                         |MemberAccess   |             |Always       |
|ProgressControl                         |MemberAccess   |             |Always       |
|Cursor                                  |MemberAccess   |             |Always       |
|OnApplyTemplate                         |Call           |             |Always       |
|ProgressOverlay                         |Call           |             |Always       |
|Show                                    |Call           |             |             |
|Hide                                    |Call           |             |             |
 
### Microsoft.Devices.DeviceType
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Coding4Fun.Toolkit.Controls/ProgressOverlay.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Emulator                                |MemberAccess   |             |             |
|Device                                  |MemberAccess   |             |             |
 
### Microsoft.Devices.Environment
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Devices/DeviceType.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DeviceType                              |MemberAccess   |             |             |
 
### Microsoft.Devices.VibrateController
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Devices/Environment.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|VibrateController                       |Type           |             |             |
|Default                                 |MemberAccess   |             |             |
|Start                                   |Call           |             |             |
 
### Microsoft.Phone.Controls.AutoCompleteBox
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Devices/VibrateController.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AutoCompleteBox                         |Type           |             |             |
|TextBoxStyle                            |MemberAccess   |             |             |
|ItemTemplate                            |MemberAccess   |             |             |
|ItemContainerStyle                      |MemberAccess   |             |             |
|TextBoxStyle                            |MemberAccess   |             |             |
|ItemsSource                             |MemberAccess   |             |             |
|FilterMode                              |MemberAccess   |             |Always       |
|ItemFilter                              |MemberAccess   |             |Always       |
|TextFilter                              |MemberAccess   |             |Always       |
|MinimumPopulateDelay                    |MemberAccess   |             |Always       |
|MinimumPrefixLength                     |MemberAccess   |             |Always       |
|IsTextCompletionEnabled                 |MemberAccess   |             |Always       |
|MinimumPrefixLengthProperty             |MemberAccess   |             |Always       |
|MinimumPopulateDelayProperty            |MemberAccess   |             |Always       |
|IsTextCompletionEnabledProperty         |MemberAccess   |             |Always       |
|ItemTemplateProperty                    |MemberAccess   |             |Always       |
|ItemContainerStyleProperty              |MemberAccess   |             |Always       |
|isDropDownOpenProperty                  |MemberAccess   |             |Always       |
|ItemSourceProperty                      |MemberAccess   |             |Always       |
|SelectedItem                            |MemberAccess   |             |Always       |
|SelectedItemProperty                    |MemberAccess   |             |Always       |
|TextProperty                            |MemberAccess   |             |Always       |
|SearchTextProperty                      |MemberAccess   |             |Always       |
|InputScope                              |MemberAccess   |             |Always       |
|DropDownPopup                           |MemberAccess   |             |Always       |
|Populated                               |MemberAccess   |             |Always       |
|Populating                              |MemberAccess   |             |Always       |
|DropDownOpening                         |MemberAccess   |             |Always       |
|DropDownOpened                          |MemberAccess   |             |Always       |
|DropDownClosing                         |MemberAccess   |             |Always       |
|PopulateComplete                        |Call           |             |Always       |
 
### Microsoft.Phone.Controls.ContextMenu
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/AutoCompleteBox.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ContextMenu                             |Type           |             |             |
|IsOpen                                  |MemberAccess   |             |Always       |
|IsZoomEnabled                           |MemberAccess   |             |Always       |
|ItemContainerStyle                      |MemberAccess   |             |Always       |
|VerticalOffset                          |MemberAccess   |             |Always       |
|ItemsSource                             |MemberAccess   |             |Always       |
|Closed                                  |Assign         |             |             |
|Opened                                  |Assign         |             |             |
 
### Microsoft.Phone.Controls.DatePicker
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/ContextMenu.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DatePicker                              |Type           |             |             |
|ValueProperty                           |MemberAccess   |             |             |
|Value                                   |MemberAccess   |             |             |
|Header                                  |MemberAccess   |             |             |
|HeaderTemplate                          |MemberAccess   |             |             |
|PickerPageUri                           |MemberAccess   |             |Always       |
|PickerPageUriProperty                   |MemberAccess   |             |Always       |
|ValueStringFormat                       |MemberAccess   |             |Always       |
|ValueStringFormatProperty               |MemberAccess   |             |Always       |
|ValueString                             |MemberAccess   |             |             |
|ValueChanged                            |MemberAccess   |             |             |
|ValueChanged                            |Assign         |             |             |
 
### Microsoft.Phone.Controls.DateTimeValueChangedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/DatePicker.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DateTimeValueChangedEventArgs           |Type           |             |             |
|NewDateTime                             |MemberAccess   |             |             |
|OldDateTime                             |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.FlickGestureEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/TimePickerValueChangedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FlickGestureEventArgs                   |Type           |             |Always       |
|Angle                                   |MemberAccess   |             |Always       |
|Direction                               |MemberAccess   |             |Always       |
|HorizontalVelocity                      |MemberAccess   |             |Always       |
|VerticalVelocity                        |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.GestureEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/FlickGestureEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GestureEventArgs                        |Type           |             |Always       |
|Handled                                 |MemberAccess   |             |Always       |
|OriginalSource                          |MemberAccess   |             |Always       |
|GestureOrigin                           |MemberAccess   |             |Always       |
|TouchPosition                           |MemberAccess   |             |Always       |
|GetPosition                             |Call           |             |Always       |
 
### Microsoft.Phone.Controls.ListPicker
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/GestureEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ListPicker                              |Type           |             |             |
|SelectedItem                            |MemberAccess   |             |             |
|SelectedIndex                           |MemberAccess   |             |             |
|Header                                  |MemberAccess   |             |             |
|HeaderTemplate                          |MemberAccess   |             |             |
|ItemSource                              |MemberAccess   |             |             |
|ListPickerMode                          |MemberAccess   |             |Always       |
|ItemsCountTheshold                      |MemberAccess   |             |Always       |
|FullModeItemTemplate                    |MemberAccess   |             |Always       |
|FullModeHeader                          |MemberAccess   |             |Always       |
|SelectedIndexProperty                   |MemberAccess   |             |Always       |
|SelectedItemProperty                    |MemberAccess   |             |Always       |
|FullModeItemTemplateProperty            |MemberAccess   |             |Always       |
|FullModeItemTemplate                    |MemberAccess   |             |Always       |
|PickerPageUri                           |MemberAccess   |             |Always       |
|SelectionMode                           |MemberAccess   |             |Always       |
|ExpansionMode                           |MemberAccess   |             |Always       |
|Open                                    |MemberAccess   |             |Always       |
|Open                                    |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.LongListMultiSelector
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/ListPicker.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|LongListMultiSelector                   |Type           |             |             |
|LayoutMode                              |MemberAccess   |             |Always       |
|IsSelectionEnabled                      |MemberAccess   |             |Always       |
|GridCellSize                            |MemberAccess   |             |Always       |
|ListFooterTemplate                      |MemberAccess   |             |             |
|ListFooter                              |MemberAccess   |             |             |
|ListHeaderTemplate                      |MemberAccess   |             |             |
|HideEmptyGroups                         |MemberAccess   |             |Always       |
|IsGroupingEnabled                       |MemberAccess   |             |Always       |
|HideEmptyGroups                         |MemberAccess   |             |Always       |
|SelectedItems                           |MemberAccess   |             |             |
|ItemContainerStyle                      |MemberAccess   |             |             |
|ItemInfoTemplate                        |MemberAccess   |             |Always       |
|ItemInfoTemplate                        |MemberAccess   |             |Always       |
|OnItemsSourcePropertyChanged            |MemberAccess   |             |Always       |
|DefaultListItemContainerStyle           |MemberAccess   |             |Always       |
|JumpListStyle                           |MemberAccess   |             |Always       |
|GroupFooterTemplate                     |MemberAccess   |             |Always       |
|ListFooter                              |MemberAccess   |             |             |
|ListHeader                              |MemberAccess   |             |             |
|Language                                |MemberAccess   |             |             |
|CacheMode                               |MemberAccess   |             |             |
|Style                                   |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.LongListSelector
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/LongListMultiSelector.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|LongListSelector                        |Type           |             |             |
|LayoutMode                              |MemberAccess   |             |Always       |
|IsSelectionEnabled                      |MemberAccess   |             |Always       |
|GridCellSize                            |MemberAccess   |             |Always       |
|ListFooterTemplate                      |MemberAccess   |             |             |
|ListFooter                              |MemberAccess   |             |             |
|ListHeaderTemplate                      |MemberAccess   |             |             |
|HideEmptyGroups                         |MemberAccess   |             |Always       |
|IsGroupingEnabled                       |MemberAccess   |             |Always       |
|HideEmptyGroups                         |MemberAccess   |             |Always       |
|SelectedItems                           |MemberAccess   |             |             |
|ItemContainerStyle                      |MemberAccess   |             |             |
|ItemInfoTemplate                        |MemberAccess   |             |Always       |
|ItemInfoTemplate                        |MemberAccess   |             |Always       |
|OnItemsSourcePropertyChanged            |MemberAccess   |             |Always       |
|DefaultListItemContainerStyle           |MemberAccess   |             |Always       |
|JumpListStyle                           |MemberAccess   |             |Always       |
|GroupFooterTemplate                     |MemberAccess   |             |Always       |
|ListFooter                              |MemberAccess   |             |             |
|ListHeader                              |MemberAccess   |             |             |
|Language                                |MemberAccess   |             |             |
|CacheMode                               |MemberAccess   |             |             |
|Style                                   |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.Maps.ApplicationIdCredentialsProvider
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/LongListSelector.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### Microsoft.Phone.Controls.Maps.Core.MapCore
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls.Maps/Map.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SetView                                 |Call           |             |             |
 
### Microsoft.Phone.Controls.Maps.Map
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls.Maps/MapCore.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Map                                     |Type           |             |             |
|CredentialsProvider                     |MemberAccess   |             |             |
|Mode                                    |MemberAccess   |             |             |
|Children                                |MemberAccess   |             |             |
|SetView                                 |Call           |             |             |
 
### Microsoft.Phone.Controls.Maps.MapItemsControl
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls.Maps/Map.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MapItemsControl                         |Type           |             |             |
 
### Microsoft.Phone.Controls.Maps.Pushpin
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls.Maps/MapItemsControl.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Pushpin                                 |Type           |             |             |
|Content                                 |MemberAccess   |             |             |
|GeoCoordinate                           |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.Maps.RoadMode
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls.Maps/Map.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### Microsoft.Phone.Controls.MenuItem
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls.Maps/Map.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MenuItem                                |Type           |             |             |
|Command                                 |MemberAccess   |             |             |
|CommandParameter                        |MemberAccess   |             |             |
|Header                                  |MemberAccess   |             |             |
|HeaderTemplate                          |MemberAccess   |             |             |
|ItemContainerStyle                      |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.MultiselectList
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/MenuItem.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MultiselectList                         |Type           |             |             |
|IsSelectionEnabled                      |MemberAccess   |             |             |
|SelectedItems                           |MemberAccess   |             |             |
|ItemContainerStyle                      |MemberAccess   |             |             |
|ItemInfoTemplate                        |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.NavigatingEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/MultiselectList.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NavigatingEventArgs                     |Type           |             |             |
|Equals                                  |Call           |             |             |
|Finalize                                |Call           |             |             |
|GetHashCode                             |Call           |             |             |
|GetType                                 |Call           |             |             |
|MemberwiseClone                         |Call           |             |             |
|ToString                                |Call           |             |             |
|Uri                                     |MemberAccess   |             |             |
|Cancel                                  |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.NavigationInTransition
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/NavigatingEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NavigationInTransition                  |Type           |             |             |
|Backward                                |MemberAccess   |             |Always       |
|Forward                                 |Assign         |             |             |
 
### Microsoft.Phone.Controls.NavigationOutTransition
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/NavigationThemeTransition.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NavigationOutTransition                 |Type           |             |Always       |
|Backward                                |MemberAccess   |             |Always       |
|Forward                                 |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.NotifyEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/NavigationOutTransition.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NotifyEventArgs                         |Type           |             |             |
|Value                                   |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.OrientationChangedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/NotifyEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|OrientationChangedEventArgs             |Type           |             |             |
|Orientation                             |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.PageOrientation
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/OrientationChangedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PageOrientation                         |Type           |             |             |
|PortraitUp                              |MemberAccess   |             |             |
|PortraitDown                            |MemberAccess   |             |             |
|LandscapeLeft                           |MemberAccess   |             |             |
|LandscapeRight                          |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.PanoramaItem
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/PageOrientation.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PanoramaItem                            |Type           |             |             |
|Header                                  |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.PerformanceProgressBar
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/PanoramaItem.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PerformanceProgressBar                  |Type           |             |             |
|IsIndeterminate                         |MemberAccess   |             |             |
|ActualIsIndeterminate                   |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.PhoneApplicationFrame
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/ProgressBar.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PhoneApplicationFrame                   |Type           |             |             |
|Orientation                             |MemberAccess   |             |             |
|RemoveBackEntry                         |Call           |             |             |
|OrientationChanged                      |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.PhoneApplicationPage
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/PhoneApplicationFrame.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PhoneApplicationPage                    |Type           |             |             |
|State                                   |MemberAccess   |             |             |
|ApplicationBar                          |MemberAccess   |             |             |
|ApplicationBar                          |Assign         |             |             |
|Orientation                             |MemberAccess   |             |             |
|SupportedOrientations                   |MemberAccess   |             |             |
|BackKeyPress                            |MemberAccess   |             |             |
|FontFamily                              |MemberAccess   |             |             |
|FontSize                                |MemberAccess   |             |             |
|Foreground                              |MemberAccess   |             |             |
|OnOrientationChanged                    |MemberAccess   |             |Always       |
|OnBackKeyPress                          |MemberAccess   |             |Always       |
|OrientationChanged                      |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.Pivot
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/PhoneApplicationPage.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Pivot                                   |Type           |             |             |
|MouseMove                               |MemberAccess   |             |             |
|Tap                                     |MemberAccess   |             |             |
|Margin                                  |MemberAccess   |             |             |
|SelectionChanged                        |MemberAccess   |             |             |
|SelectedIndex                           |MemberAccess   |             |             |
|Title                                   |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.PivotItem
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/Pivot.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PivotItem                               |Type           |             |             |
|Header                                  |MemberAccess   |             |             |
|Margin                                  |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.RollTransition
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/PivotItem.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|RollTransition                          |Type           |             |             |
 
### Microsoft.Phone.Controls.RotateTransition
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/TurnstileTransition.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|RotateTransition                        |Type           |             |             |
|Mode                                    |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.RotateTransitionMode
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/TurnstileTransition.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|In90Clockwise                           |MemberAccess   |             |Always       |
|In90Counterclockwise                    |MemberAccess   |             |Always       |
|In180Clockwise                          |MemberAccess   |             |Always       |
|In180Counterclockwise                   |MemberAccess   |             |Always       |
|Out90Clockwise                          |MemberAccess   |             |Always       |
|Out90Counterclockwise                   |MemberAccess   |             |Always       |
|Out180Clockwise                         |MemberAccess   |             |Always       |
|Out180Counterclockwise                  |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.RoundButton
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/RotateTransitionMode.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|RoundButton                             |Type           |             |             |
|Orientation                             |MemberAccess   |             |Always       |
|PressedBrush                            |MemberAccess   |             |Always       |
|Stretch                                 |MemberAccess   |             |Always       |
|ButtonHeight                            |MemberAccess   |             |             |
|ButtonWidth                             |MemberAccess   |             |             |
|ImageResource                           |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.SlideTransition
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/RoundButton.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SlideTransition                         |Type           |             |             |
|Mode                                    |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.SlideTransitionMode
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/SlideTransition.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SlideTransitionMode                     |Type           |             |             |
|SlideUpFadeIn                           |MemberAccess   |             |             |
|SlideDownFadeOut                        |MemberAccess   |             |             |
|SlideDownFadeIn                         |MemberAccess   |             |             |
|SlideUpFadeOut                          |MemberAccess   |             |             |
|SlideRightFadeIn                        |MemberAccess   |             |             |
|SlideLeftFadeLeftOut                    |MemberAccess   |             |             |
|SlideRightFadeIn                        |MemberAccess   |             |             |
|SlideLeftFadeLeftOut                    |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.SupportedPageOrientation
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/SlideTransitionMode.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SupportedPageOrientation                |Type           |             |             |
|PortraitOrLandscape                     |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.SwivelTransition
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/SupportedPageOrientation.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SwivelTransition                        |Type           |             |             |
|Mode                                    |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.SwivelTransitionMode
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/TurnstileTransition.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FullScreenIn                            |MemberAccess   |             |Always       |
|FullScreenOut                           |MemberAccess   |             |Always       |
|ForwardIn                               |MemberAccess   |             |Always       |
|ForwardOut                              |MemberAccess   |             |Always       |
|BackwardIn                              |MemberAccess   |             |Always       |
|BackwardOut                             |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.TiltEffect
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/SwivelTransitionMode.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TiltEffect                              |Type           |             |Always       |
|TiltableItems                           |MemberAccess   |             |Always       |
|IsTiltEnabled                           |MemberAccess   |             |Always       |
|SuppressTilt                            |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.TimePicker
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/TiltEffect.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TimePicker                              |Type           |             |             |
|ValueProperty                           |MemberAccess   |             |             |
|Header                                  |MemberAccess   |             |             |
|HeaderTemplate                          |MemberAccess   |             |             |
|PickerPageUri                           |MemberAccess   |             |Always       |
|ValueStringFormat                       |MemberAccess   |             |Always       |
|PickerPageUriProperty                   |MemberAccess   |             |Always       |
|Value                                   |MemberAccess   |             |             |
|Value                                   |Assign         |             |             |
|ValueString                             |MemberAccess   |             |             |
|ValueChanged                            |MemberAccess   |             |             |
|ValueChanged                            |Assign         |             |             |
 
### Microsoft.Phone.Controls.ToggleSwitch
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/TimePicker.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ToggleSwitch                            |Type           |             |             |
|IsCheckedProperty                       |MemberAccess   |             |             |
|IsChecked                               |MemberAccess   |             |             |
|IsChecked                               |Assign         |             |             |
|Content                                 |Assign         |             |             |
|Content                                 |MemberAccess   |             |             |
|Header                                  |MemberAccess   |             |             |
|HeaderTemplate                          |MemberAccess   |             |             |
|HeaderProperty                          |MemberAccess   |             |             |
|HeaderTemplateProperty                  |MemberAccess   |             |             |
|IsCheckedProperty                       |MemberAccess   |             |             |
|SwitchForegroundProperty                |MemberAccess   |             |Always       |
|SwitchForeground                        |MemberAccess   |             |             |
|Checked                                 |MemberAccess   |             |Always       |
|Unchecked                               |MemberAccess   |             |Always       |
|Indeterminate                           |MemberAccess   |             |Always       |
|Click                                   |MemberAccess   |             |             |
|Click                                   |Assign         |             |             |
 
### Microsoft.Phone.Controls.TransitionFrame
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/ToggleSwitch.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TransitionFrame                         |Type           |             |             |
|OrientationChanged                      |MemberAccess   |             |             |
 
### Microsoft.Phone.Controls.TransitionService
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/TransitionFrame.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TransitionService                       |Type           |             |             |
|SetNavigationInTransition               |Call           |             |             |
|SetNavigationOutTransition              |Call           |             |Always       |
 
### Microsoft.Phone.Controls.TurnstileFeatherTransition
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/TransitionCollection.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TurnstileFeatherTransition              |Type           |             |             |
|Mode                                    |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.TurnstileTransition
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/TurnstileTransition.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TurnstileTransition                     |Type           |             |             |
|Mode                                    |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.TurnstileTransitionMode
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/TurnstileTransition.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ForwardIn                               |MemberAccess   |             |Always       |
|ForwardOut                              |MemberAccess   |             |Always       |
|BackwardIn                              |MemberAccess   |             |Always       |
|BackwardOut                             |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.WebBrowser
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/TurnstileTransitionMode.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|WebBrowser                              |Type           |             |             |
|SaveToString                            |Call           |             |             |
|InvokeScript                            |Call           |             |             |
|Navigating                              |MemberAccess   |             |             |
|Navigated                               |MemberAccess   |             |             |
|IsScriptEnabled                         |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Controls.WrapPanel
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/WebBrowser.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|WrapPanel                               |Type           |             |             |
|ItemHeight                              |MemberAccess   |             |             |
|ItemHeightProperty                      |MemberAccess   |             |             |
|ItemWidth                               |MemberAccess   |             |             |
|ItemWidthProperty                       |MemberAccess   |             |             |
|Orientation                             |MemberAccess   |             |             |
|OrientationProperty                     |MemberAccess   |             |             |
 
### Microsoft.Phone.Globalization.SortedLocaleGrouping
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Controls/WrapPanel.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SortedLocaleGrouping                    |Type           |Always       |             |
 
### Microsoft.Phone.Info.DeviceExtendedProperties
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Globalization/SortedLocaleGrouping.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Tick                                    |MemberAccess   |             |             |
|IsEnabled                               |MemberAccess   |             |             |
|Interval                                |MemberAccess   |             |             |
|GetValue                                |Call           |Conditionally|             |
|TryGetValue                             |Call           |Conditionally|             |
 
### Microsoft.Phone.Info.DeviceStatus
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Info/DeviceExtendedProperties.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ApplicationCurrentMemoryUsage           |MemberAccess   |             |             |
|DeviceFirmwareVersion                   |MemberAccess   |             |             |
|DeviceHardwareVersion                   |MemberAccess   |             |             |
|DeviceManufacturer                      |MemberAccess   |             |             |
|DeviceName                              |MemberAccess   |             |             |
|DeviceName                              |MemberAccess   |             |             |
|DeviceTotalMemory                       |MemberAccess   |             |Always       |
|ApplicationPeakMemoryUsage              |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Info.UserExtendedProperties
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Info/DeviceStatus.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TryGetValue                             |Call           |Conditionally|             |
 
### Microsoft.Phone.Maps.Controls.Map
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Info/UserExtendedProperties.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Map                                     |Type           |             |             |
|CartographicMode                        |MemberAccess   |             |             |
|Layers                                  |MemberAccess   |             |             |
|Tap                                     |MemberAccess   |             |             |
|ConvertViewportPointToGeoCoordinate     |Call           |             |             |
|ConvertGeoCoordinateToViewportPoint     |Call           |             |             |
|SetView                                 |Call           |             |             |
|ColorMode                               |MemberAccess   |             |             |
|LandmarksEnabled                        |MemberAccess   |             |             |
|PedestrianFeaturesEnabled               |MemberAccess   |             |             |
|Pitch                                   |MemberAccess   |             |             |
|ActualPitch                             |MemberAccess   |             |             |
|ResolveCompleted                        |MemberAccess   |             |Always       |
|TransformCenterChanged                  |MemberAccess   |             |Always       |
|ViewChanging                            |MemberAccess   |             |Always       |
|ViewChanged                             |MemberAccess   |             |Always       |
|LandmarksEnabledChanged                 |MemberAccess   |             |Always       |
|ColorModeChanged                        |MemberAccess   |             |Always       |
|CartographicModeChanged                 |MemberAccess   |             |Always       |
|GetMapElementAt                         |Call           |             |Always       |
|Hold                                    |MemberAccess   |             |             |
|ConvertGeoCoordinateToViewportPoint     |Call           |             |             |
 
### Microsoft.Phone.Maps.Controls.MapCartographicMode
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Maps.Controls/Map.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MapCartographicMode                     |Type           |             |             |
|Hybrid                                  |MemberAccess   |             |             |
|Aerial                                  |MemberAccess   |             |             |
|Terrain                                 |MemberAccess   |             |             |
|Road                                    |MemberAccess   |             |             |
 
### Microsoft.Phone.Maps.Controls.MapColorMode
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Maps.Controls/MapCartographicMode.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MapColorMode                            |Type           |             |             |
|Light                                   |MemberAccess   |             |             |
|Dark                                    |MemberAccess   |             |             |
 
### Microsoft.Phone.Maps.Controls.MapLayer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Maps.Controls/MapColorMode.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MapLayer                                |Type           |             |             |
|Add                                     |Call           |             |             |
|Count                                   |MemberAccess   |             |             |
|Count                                   |Call           |             |             |
|RemoveAt                                |Call           |             |             |
 
### Microsoft.Phone.Maps.Controls.MapOverlay
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Maps.Controls/MapLayer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MapOverlay                              |Type           |             |             |
|PositionOrigin                          |MemberAccess   |             |Always       |
|Content                                 |MemberAccess   |             |             |
|GeoCoordinate                           |Assign         |             |Conditionally|
|GeoCoordinate                           |MemberAccess   |             |Conditionally|
 
### Microsoft.Phone.Maps.MapsApplicationContext
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Maps.Controls/MapOverlay.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ApplicationId                           |MemberAccess   |             |Always       |
|AuthenticationToken                     |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Maps.Toolkit.MapExtensions
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Maps.Controls/MapsApplicationContext.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GetChildren                             |Call           |             |             |
 
### Microsoft.Phone.Maps.Toolkit.Pushpin
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Maps.Toolkit/MapExtensions.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Pushpin                                 |Type           |             |             |
|Content                                 |MemberAccess   |             |             |
|GeoCoordinate                           |MemberAccess   |             |             |
|OnPositionOriginChangedCallback         |MemberAccess   |             |Always       |
|OnDoubleTap                             |MemberAccess   |             |Always       |
|OnHold                                  |MemberAccess   |             |Always       |
|OnKeyUp                                 |MemberAccess   |             |Always       |
|OnTap                                   |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Maps.Toolkit.UserLocationMarker
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Maps.Toolkit/Pushpin.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|UserLocationMarker                      |Type           |             |             |
|Content                                 |MemberAccess   |             |             |
|GeoCoordinate                           |MemberAccess   |             |             |
 
### Microsoft.Phone.Marketplace.LicenseInformation
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Maps.Toolkit/UserLocationMarker.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|LicenseInformation                      |Type           |             |             |
|IsTrial                                 |Call           |             |             |
 
### Microsoft.Phone.Net.NetworkInformation.DeviceNetworkInformation
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Marketplace/LicenseInformation.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CellularMobileOperator                  |MemberAccess   |             |             |
|IsNetworkAvailable                      |MemberAccess   |             |             |
 
### Microsoft.Phone.Net.NetworkInformation.NetworkInterface
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Net.NetworkInformation/DeviceNetworkInformation.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NetworkInterfaceType                    |MemberAccess   |Always       |             |
 
### Microsoft.Phone.Net.NetworkInformation.NetworkInterfaceType
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Net.NetworkInformation/NetworkInterface.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NetworkInterfaceType                    |Type           |             |             |
|ToString                                |Call           |             |             |
 
### Microsoft.Phone.Scheduler.Alarm
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Net.NetworkInformation/NetworkInterfaceType.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Alarm                                   |Type           |Always       |             |
|Title                                   |MemberAccess   |             |             |
|Content                                 |MemberAccess   |             |             |
|Sound                                   |MemberAccess   |             |             |
|Name                                    |MemberAccess   |             |             |
|IsScheduled                             |MemberAccess   |             |Always       |
|RecurrenceType                          |MemberAccess   |             |Always       |
|ExpirationTime                          |MemberAccess   |             |Always       |
|Name                                    |MemberAccess   |             |             |
 
### Microsoft.Phone.Scheduler.ScheduledActionService
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Scheduler/Alarm.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ScheduledActionService                  |Type           |             |             |
|Add                                     |Call           |             |Conditionally|
|Remove                                  |Call           |             |Conditionally|
 
### Microsoft.Phone.Shell.ApplicationBar
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Scheduler/ToastNotificationManager.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ApplicationBar                          |Type           |             |             |
|Buttons                                 |MemberAccess   |             |             |
|IsVisible                               |Assign         |             |             |
|BackgroundColor                         |Assign         |             |             |
|BackgroundColor                         |MemberAccess   |             |             |
|IsVisible                               |MemberAccess   |             |             |
|IsMenuEnabled                           |MemberAccess   |             |             |
|MenuItems                               |MemberAccess   |             |             |
 
### Microsoft.Phone.Shell.ApplicationBarIconButton
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/ApplicationBar.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ApplicationBarIconButton                |Type           |             |             |
|Text                                    |MemberAccess   |             |             |
|IconUri                                 |MemberAccess   |             |             |
|IconUri                                 |Assign         |             |             |
 
### Microsoft.Phone.Shell.ApplicationBarMenuItem
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/ApplicationBarIconButton.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ApplicationBarMenuItem                  |Type           |             |             |
|Text                                    |MemberAccess   |             |             |
 
### Microsoft.Phone.Shell.FlipTileData
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/ApplicationBarMenuItem.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FlipTileData                            |Type           |             |             |
|BackTitle                               |MemberAccess   |             |             |
|BackContent                             |MemberAccess   |             |             |
|WideBackContent                         |MemberAccess   |             |             |
 
### Microsoft.Phone.Shell.IApplicationBar
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/FlipTileData.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|IApplicationBar                         |Type           |             |             |
|Buttons                                 |MemberAccess   |             |             |
|IsVisible                               |MemberAccess   |             |             |
|IsVisible                               |Assign         |             |             |
|BackgroundColor                         |Assign         |             |             |
|BackgroundColor                         |MemberAccess   |             |             |
|IsMenuEnabled                           |MemberAccess   |             |             |
|MenuItems                               |MemberAccess   |             |             |
 
### Microsoft.Phone.Shell.IApplicationBarIconButton
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/IApplicationBar.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|IApplicationBarIconButton               |Type           |             |             |
|IsEnabled                               |MemberAccess   |             |             |
|Text                                    |MemberAccess   |             |             |
|Icon                                    |MemberAccess   |             |Always       |
|IconUri                                 |MemberAccess   |             |             |
|IconUri                                 |Assign         |             |             |
 
### Microsoft.Phone.Shell.IApplicationBarMenuItem
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/IApplicationBarIconButton.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|IApplicationBarMenuItem                 |Type           |             |             |
|IsEnabled                               |MemberAccess   |             |             |
|Text                                    |MemberAccess   |             |             |
|Icon                                    |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Shell.IdleDetectionMode
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/IApplicationBarMenuItem.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|IdleDetectionMode                       |Type           |Always       |             |
 
### Microsoft.Phone.Shell.LaunchingEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/IdleDetectionMode.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|LaunchingEventArgs                      |Type           |             |Always       |
 
### Microsoft.Phone.Shell.PhoneApplicationService
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/LaunchingEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PhoneApplicationService                 |Type           |             |             |
|UserIdleDetectionMode                   |Assign         |Conditionally|             |
|UserIdleDetectionMode                   |MemberAccess   |Always       |             |
|ApplicationIdleDetectionMode            |MemberAccess   |Always       |             |
|ApplicationIdleDetectionMode            |Assign         |Conditionally|             |
|Activated                               |MemberAccess   |             |             |
|Current                                 |MemberAccess   |             |             |
|Closing                                 |MemberAccess   |             |             |
|Deactivated                             |MemberAccess   |             |             |
|State                                   |MemberAccess   |             |             |
|Launching                               |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Shell.ProgressIndicator
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/PhoneApplicationService.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ProgressIndicator                       |Type           |             |             |
|IsVisible                               |Assign         |Conditionally|             |
|IsVisible                               |MemberAccess   |             |Always       |
|IsIndeterminate                         |Assign         |             |             |
 
### Microsoft.Phone.Shell.ShellTile
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/StatusBarProgressIndicator.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ShellTile                               |Type           |             |             |
|ActiveTiles                             |MemberAccess   |             |             |
|Delete                                  |Call           |             |             |
|Create                                  |Call           |Conditionally|             |
|Update                                  |Call           |             |             |
|NavigationUri                           |MemberAccess   |Conditionally|             |
 
### Microsoft.Phone.Shell.ShellTileData
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/ShellTile.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ShellTileData                           |Type           |             |             |
|Title                                   |MemberAccess   |             |             |
|BackgroundImage                         |MemberAccess   |             |             |
 
### Microsoft.Phone.Shell.ShellToast
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/ShellTileData.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ShellToast                              |Type           |             |             |
|Title                                   |Assign         |             |             |
|Content                                 |Assign         |             |             |
|NavigationUri                           |Assign         |             |             |
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.Shell.StandardTileData
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/ShellToast.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|StandardTileData                        |Type           |             |             |
|Title                                   |MemberAccess   |             |             |
|BackgroundImage                         |MemberAccess   |             |             |
|BackgroundImage                         |Assign         |             |             |
|BackContent                             |MemberAccess   |             |Always       |
|BackTitle                               |MemberAccess   |             |Always       |
 
### Microsoft.Phone.Shell.SystemTray
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/StandardTileData.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SystemTray                              |Type           |             |             |
|IsVisible                               |Assign         |Conditionally|             |
|IsVisible                               |MemberAccess   |             |Always       |
|SetProgressIndicator                    |Call           |             |Always       |
|Opacity                                 |MemberAccess   |             |             |
|BackgroundColor                         |MemberAccess   |             |             |
|ForegroundColor                         |MemberAccess   |             |             |
 
### Microsoft.Phone.Tasks.CameraCaptureTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Shell/SystemTray.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CameraCaptureTask                       |Type           |             |             |
|Completed                               |MemberAccess   |             |             |
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.Tasks.EmailComposeTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/CameraCaptureTask.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|EmailComposeTask                        |Type           |             |             |
|Subject                                 |MemberAccess   |             |             |
|To                                      |MemberAccess   |             |             |
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.Tasks.MarketplaceContentType
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/EmailComposeTask.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Applications                            |MemberAccess   |             |             |
|Music                                   |MemberAccess   |             |             |
 
### Microsoft.Phone.Tasks.MarketplaceDetailTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/MarketplaceContentType.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.Tasks.MarketplaceReviewTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/MarketplaceDetailTask.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.Tasks.MarketplaceSearchTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/MarketplaceReviewTask.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.Tasks.PhoneCallTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/MarketplaceSearchTask.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PhoneCallTask                           |Type           |Conditionally|             |
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.Tasks.PhotoChooserTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/PhoneCallTask.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PhotoChooserTask                        |Type           |             |             |
|Completed                               |MemberAccess   |             |             |
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.Tasks.PhotoResult
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/PhotoChooser.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PhotoResult                             |Type           |             |             |
|OriginalFileName                        |MemberAccess   |             |             |
|ChosenPhoto                             |MemberAccess   |             |             |
|TaskResult                              |MemberAccess   |             |             |
 
### Microsoft.Phone.Tasks.SaveContactTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/PhotoResult.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Show                                    |Call           |Conditionally|             |
 
### Microsoft.Phone.Tasks.ShareLinkTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/SaveContactTask.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ShareLinkTask                           |Type           |Conditionally|             |
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.Tasks.ShareMediaTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/ShareLinkTask.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.Tasks.ShareTaskBase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/ShareMediaTask.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### Microsoft.Phone.Tasks.SmsComposeTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/ShareTaskBase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SmsComposeTask                          |Type           |             |             |
|To                                      |Assign         |             |             |
|Body                                    |MemberAccess   |             |             |
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.Tasks.TaskEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/SmsComposeTask.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TaskEventArgs                           |Type           |             |             |
|TaskResult                              |MemberAccess   |             |             |
 
### Microsoft.Phone.Tasks.TaskResult
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/TaskEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|OK                                      |MemberAccess   |             |             |
|Cancel                                  |MemberAccess   |             |             |
 
### Microsoft.Phone.Tasks.WebBrowserTask
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/TaskResult.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|WebBrowserTask                          |Type           |Conditionally|             |
|Show                                    |Call           |             |             |
 
### Microsoft.Phone.UserData.Appointment
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.Tasks/WebBrowserTask.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Appointment                             |Type           |             |             |
 
### Microsoft.Phone.UserData.Appointments
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.UserData/Appointment.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Appointments                            |Type           |             |             |
|SearchAsync                             |Call           |             |             |
|SearchCompleted                         |MemberAccess   |             |             |
 
### Microsoft.Phone.UserData.AppointmentsSearchEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.UserData/Appointments.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Results                                 |MemberAccess   |             |             |
 
### Microsoft.Phone.UserData.CompleteName
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.UserData/AppointmentsSearchEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CompleteName                            |Type           |             |             |
|FirstName                               |MemberAccess   |             |             |
|LastName                                |MemberAccess   |             |             |
|LastName2                               |MemberAccess   |             |             |
|MiddleName                              |MemberAccess   |             |             |
 
### Microsoft.Phone.UserData.Contact
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.UserData/CompleteName.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Contact                                 |Type           |             |             |
|PhoneNumbers                            |MemberAccess   |             |             |
 
### Microsoft.Phone.UserData.ContactPhoneNumber
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.UserData/Contact.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ContactPhoneNumber                      |Type           |             |             |
|PhoneNumber                             |MemberAccess   |             |             |
 
### Microsoft.Phone.UserData.Contacts
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.UserData/ContactPhoneNumber.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Contacts                                |Type           |             |             |
|SearchAsync                             |Call           |             |             |
|SearchCompleted                         |MemberAccess   |             |             |
 
### Microsoft.Phone.UserData.ContactsSearchEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.UserData/Contacts.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Results                                 |MemberAccess   |             |             |
 
### Microsoft.Phone.UserData.FilterKind
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.UserData/ContactsSearchEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FilterKind                              |Type           |             |             |
|DisplayName                             |MemberAccess   |             |             |
|EmailAddress                            |MemberAccess   |             |             |
|PhoneNumber                             |MemberAccess   |             |             |
 
### Microsoft.Xna.Framework.Audio.SoundEffect
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Phone.UserData/FilterKind.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SoundEffect                             |Type           |             |             |
|Duration                                |MemberAccess   |             |             |
|Name                                    |MemberAccess   |             |             |
|MasterVolume                            |MemberAccess   |             |             |
|SpeedOfSound                            |MemberAccess   |             |Always       |
|DopplerScale                            |MemberAccess   |             |Always       |
|IsDisposed                              |MemberAccess   |             |Always       |
|FromStream                              |MemberAccess   |             |Always       |
|GetSampleDuration                       |MemberAccess   |             |Always       |
|Play                                    |MemberAccess   |             |             |
|GetSampleSizeInBytes                    |MemberAccess   |             |             |
|Finalize                                |MemberAccess   |             |             |
|MemberwiseClone                         |MemberAccess   |             |Always       |
|CreateInstance                          |Call           |             |             |
 
### Microsoft.Xna.Framework.Audio.SoundEffectInstance
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Xna.Framework.Audio/SoundEffect.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SoundEffectInstance                     |Type           |             |             |
|IsLooped                                |MemberAccess   |             |             |
|Volume                                  |MemberAccess   |             |             |
|State                                   |MemberAccess   |             |             |
|IsDisposed                              |MemberAccess   |             |Always       |
|Pan                                     |MemberAccess   |             |Always       |
|Pitch                                   |MemberAccess   |             |Always       |
|Pause                                   |MemberAccess   |             |             |
|Play                                    |MemberAccess   |             |             |
|Stop                                    |MemberAccess   |             |             |
|Resume                                  |MemberAccess   |             |             |
|Apply3D                                 |MemberAccess   |             |Always       |
|Dispose                                 |MemberAccess   |             |             |
|Equals                                  |MemberAccess   |             |             |
|GetHashCode                             |MemberAccess   |             |             |
|GetType                                 |MemberAccess   |             |             |
 
### Microsoft.Xna.Framework.Audio.SoundState
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Xna.Framework.Audio/SoundEffectInstance.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SoundState                              |Type           |             |             |
|Playing                                 |MemberAccess   |             |             |
|Paused                                  |MemberAccess   |             |             |
|Stopped                                 |MemberAccess   |             |             |
 
### Microsoft.Xna.Framework.FrameworkDispatcher
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Xna.Framework.Audio/SoundState.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FrameworkDispatcher                     |Type           |             |Always       |
|Update                                  |Call           |             |Always       |
 
### Microsoft.Xna.Framework.GamerServices.Guide
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Xna.Framework/FrameworkDispatcher.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|EndShowMessageBox                       |Call           |             |Conditionally|
|BeginShowMessageBox                     |Call           |             |Conditionally|
 
### Microsoft.Xna.Framework.Media.MediaLibrary
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Xna.Framework.GamerServices/Guide.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MediaLibrary                            |Type           |             |             |
|SavePicture                             |Call           |             |             |
 
### Microsoft.Xna.Framework.TitleContainer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Xna.Framework.Media/MediaLibrary.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|OpenStream                              |Call           |             |             |
 
### NavigationListControl.NavigationEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Microsoft.Xna.Framework/TitleContainer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NavigationEventArgs                     |Type           |Always       |             |
 
### NavigationListControl.NavigationList
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//NavigationListControl/NavigationEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NavigationList                          |Type           |Always       |             |
 
### System.CodeDom.Compiler.GeneratedCodeAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//NavigationListControl/NavigationList.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.DictionaryEntry
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.CodeDom.Compiler/GeneratedCodeAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.Generic.IDictionary
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections/DictionaryEntry.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.Generic.IEnumerable
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections.Generic/IDictionary.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.Generic.KeyNotFoundException
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections.Generic/IEnumerable.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.Generic.List
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections.Generic/KeyNotFoundException.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ForEach                                 |Call           |             |             |
 
### System.Collections.ICollection
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections.Generic/List.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.IDictionary
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections/ICollection.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.IEnumerable
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections/IDictionary.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.IEnumerator
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections/IEnumerable.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.IList
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections/IEnumerator.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.Specialized.INotifyCollectionChanged
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections/IList.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.Specialized.NotifyCollectionChangedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections.Specialized/INotifyCollectionChanged.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Collections.Specialized.NotifyCollectionChangedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections.Specialized/NotifyCollectionChangedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.ComponentModel.AsyncCompletedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Collections.Specialized/NotifyCollectionChangedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Cancelled                               |MemberAccess   |             |             |
|Error                                   |MemberAccess   |             |             |
 
### System.ComponentModel.BackgroundWorker
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/AsyncCompletedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|BackgroundWorker                        |Type           |             |             |
 
### System.ComponentModel.CancelEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/BackgroundWorker.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Cancel                                  |MemberAccess   |             |             |
 
### System.ComponentModel.CategoryAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/CancelEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.ComponentModel.DefaultValueAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/CategoryAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Value                                   |MemberAccess   |             |             |
 
### System.ComponentModel.DesignerProperties
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/DefaultValueAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DesignerProperties                      |Type           |             |             |
|IsInDesignTool                          |MemberAccess   |             |             |
|GetIsInDesignMode                       |Call           |             |             |
 
### System.ComponentModel.DoWorkEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/DesignerProperties.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DoWorkEventArgs                         |Type           |             |             |
 
### System.ComponentModel.EditorBrowsableAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/DoWorkEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.ComponentModel.INotifyPropertyChanged
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/EditorBrowsableAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PropertyChanged                         |MemberAccess   |             |             |
 
### System.ComponentModel.PropertyChangedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/INotifyPropertyChanged.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PropertyName                            |MemberAccess   |             |             |
 
### System.ComponentModel.PropertyChangedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/PropertyChangedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Invoke                                  |Call           |             |             |
 
### System.ComponentModel.RunWorkerCompletedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/PropertyChangedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|RunWorkerCompletedEventArgs             |Type           |             |             |
 
### System.ComponentModel.TypeConverter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/RunWorkerCompletedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.DateTime
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ComponentModel/TypeConverter.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ToShortTimeString                       |Call           |             |             |
|ToLongTimeString                        |Call           |             |             |
|ToShortDateString                       |Call           |             |             |
|ToLongDateString                        |Call           |             |             |
 
### System.Device.Location.GeoCoordinate
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System/DateTime.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GeoCoordinate                           |Type           |             |             |
|GetDistanceTo                           |Call           |Conditionally|             |
|Latitude                                |MemberAccess   |             |             |
|Longitude                               |MemberAccess   |             |             |
|IsUnknown                               |MemberAccess   |             |             |
|VerticalAccuracy                        |MemberAccess   |             |Always       |
|HorizontalAccuracy                      |MemberAccess   |             |Always       |
 
### System.Device.Location.GeoCoordinateWatcher
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Device.Location/GeoCoordinate.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GeoCoordinateWatcher                    |Type           |             |             |
|Start                                   |Call           |             |             |
|Stop                                    |Call           |             |             |
|Position                                |MemberAccess   |             |             |
 
### System.Device.Location.GeoPosition
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Device.Location/GeoCoordinateWatcher.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GeoPosition                             |Type           |             |             |
|Location                                |MemberAccess   |             |             |
 
### System.Device.Location.GeoPositionAccuracy
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Device.Location/GeoPosition.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GeoPositionAccuracy                     |Type           |             |             |
|Default                                 |MemberAccess   |             |             |
|High                                    |MemberAccess   |             |             |
 
### System.Device.Location.GeoPositionChangedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Device.Location/GeoPositionAccuracy.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GeoPositionChangedEventArgs             |Type           |             |             |
 
### System.Device.Location.GeoPositionStatus
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Device.Location/GeoPositionChangedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GeoPositionStatus                       |Type           |             |             |
|Disabled                                |MemberAccess   |             |             |
|Ready                                   |MemberAccess   |             |             |
|Initializing                            |MemberAccess   |             |             |
|NoData                                  |MemberAccess   |             |             |
 
### System.Device.Location.GeoPositionStatusChangedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Device.Location/GeoPositionStatus.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GeoPositionStatusChangedEventArgs       |Type           |             |             |
 
### System.Diagnostics.CodeAnalysis.SuppressMessageAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Device.Location/GeoPositionStatusChangedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Diagnostics.ConditionalAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Diagnostics.CodeAnalysis/SuppressMessageAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Diagnostics.Debug
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Diagnostics/ConditionalAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Diagnostics.DebuggableAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Diagnostics/Debug.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Diagnostics.Debugger
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Diagnostics/DebuggableAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|IsAttached                              |MemberAccess   |             |             |
|Break                                   |Call           |             |             |
 
### System.Diagnostics.DebuggerBrowsableAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Diagnostics/Debugger.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Diagnostics.DebuggerDisplayAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Diagnostics/DebuggerBrowsableAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Diagnostics.DebuggerHiddenAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Diagnostics/DebuggerDisplayAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Diagnostics.DebuggerStepThroughAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Diagnostics/DebuggerHiddenAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Diagnostics.StackFrame
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Diagnostics/DebuggerStepThroughAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GetMethod                               |Call           |             |             |
 
### System.Diagnostics.StackTrace
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Diagnostics/StackFrame.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GetFrame                                |Call           |             |             |
|FrameCount                              |MemberAccess   |             |Always       |
 
### System.Environment
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Diagnostics/StackTrace.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|OSVersion                               |MemberAccess   |             |             |
 
### System.EventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System/Environment.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|EventHandler                            |Type           |             |             |
 
### System.Globalization.CultureInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System/EventHandler_GeoPositionStatusChangedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CultureInfo                             |Type           |             |             |
|Name                                    |MemberAccess   |             |             |
|DateTimeFormat                          |MemberAccess   |             |             |
|TwoLetterISOLanguageName                |MemberAccess   |             |             |
|CurrentCulture                          |MemberAccess   |             |             |
|CurrentUICulture                        |MemberAccess   |             |             |
|InvariantCulture                        |MemberAccess   |             |             |
 
### System.Globalization.DateTimeFormatInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Globalization/CultureInfoMapper.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|LongTimePattern                         |MemberAccess   |             |             |
 
### System.Globalization.NumberFormatInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Globalization/DateTimeFormatInfo.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|InvariantInfo                           |MemberAccess   |             |             |
 
### System.IO.BinaryReader
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Globalization/NumberFormatInfo.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Close                                   |Call           |             |             |
|Dispose                                 |Call           |             |             |
|BaseStream                              |MemberAccess   |             |             |
|Read                                    |Call           |             |             |
|ReadByte                                |Call           |             |             |
|ReadBytes                               |Call           |             |             |
|ReadDouble                              |Call           |             |             |
|ReadInt32                               |Call           |             |             |
|ReadInt64                               |Call           |             |             |
|ReadSByte                               |Call           |             |             |
 
### System.IO.BinaryWriter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/BinaryReader.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Close                                   |Call           |             |             |
|Dispose                                 |Call           |             |             |
|Write                                   |Call           |             |             |
|Flush                                   |Call           |             |             |
 
### System.IO.EndOfStreamException
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/BinaryWriter.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|EndOfStreamException                    |Type           |             |             |
 
### System.IO.File
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/EndOfStreamException.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Exists                                  |Call           |             |             |
 
### System.IO.IsolatedStorage.IsolatedStorageFile
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/File.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AvailableFreeSpace                      |MemberAccess   |Always       |             |
|CreateDirectory                         |Call           |             |             |
|CreateFile                              |Call           |             |             |
|DeleteFile                              |Call           |             |             |
|DirectoryExists                         |Call           |             |             |
|Dispose                                 |Call           |             |             |
|FileExists                              |Call           |             |             |
|GetFileNames                            |Call           |             |             |
|GetUserStoreForApplication              |Call           |             |             |
|OpenFile                                |Call           |             |             |
 
### System.IO.IsolatedStorage.IsolatedStorageFileStream
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO.IsolatedStorage/IsolatedStorageFile.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|IsolatedStorageFileStream               |Type           |             |             |
|Close                                   |Call           |             |             |
 
### System.IO.IsolatedStorage.IsolatedStorageSettings
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO.IsolatedStorage/IsolatedStorageFileStream.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|IsolatedStorageSettings                 |Type           |             |             |
|ApplicationSettings                     |MemberAccess   |             |             |
|TryGetValue                             |Call           |Conditionally|             |
|Remove                                  |Call           |             |             |
|Contains                                |Call           |             |             |
|Save                                    |Call           |             |Always       |
|Add                                     |Call           |             |             |
|Count                                   |MemberAccess   |             |             |
 
### System.IO.MemoryStream
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO.IsolatedStorage/IsolatedStorageSettingsMapper.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MemoryStream                            |Type           |             |             |
|ToArray                                 |Call           |             |             |
|GetBuffer                               |Call           |             |             |
 
### System.IO.Path
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/MemoryStream.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Path                                    |Type           |             |             |
|Combine                                 |Call           |             |             |
|GetDirectoryName                        |Call           |             |             |
|GetFileName                             |Call           |             |             |
|GetTempFileName                         |Call           |             |             |
 
### System.IO.Stream
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/Path.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Stream                                  |Type           |             |             |
|Close                                   |Call           |             |             |
|CopyTo                                  |Call           |             |             |
|CopyToAsync                             |Call           |             |             |
|Dispose                                 |Call           |             |             |
|Flush                                   |Call           |             |             |
|Read                                    |Call           |             |             |
|ReadByte                                |Call           |             |             |
|Seek                                    |Call           |             |             |
|SetLength                               |Call           |             |             |
|ReadByte                                |Call           |             |             |
|Write                                   |Call           |             |             |
|WriteByte                               |Call           |             |             |
|CanRead                                 |MemberAccess   |             |             |
|CanSeek                                 |MemberAccess   |             |             |
|CanWrite                                |MemberAccess   |             |             |
|Length                                  |MemberAccess   |             |             |
|Position                                |MemberAccess   |             |             |
 
### System.IO.StreamReader
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/Stream.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|StreamReader                            |Type           |             |             |
|Close                                   |Call           |             |             |
 
### System.IO.StreamWriter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/StreamReader.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|StreamWriter                            |Type           |             |             |
|Close                                   |Call           |             |             |
 
### System.IO.StringReader
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/StreamWriter.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|StringReader                            |Type           |             |             |
 
### System.IO.StringWriter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/StringReader.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|StringWriter                            |Type           |             |             |
 
### System.IO.TextReader
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/StringWriter.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TextReader                              |Type           |             |             |
|Close                                   |Call           |             |             |
|Dispose                                 |Call           |             |             |
|Peek                                    |Call           |             |             |
|Read                                    |Call           |             |             |
|ReadLine                                |Call           |             |             |
|ReadToEnd                               |Call           |             |             |
 
### System.IO.TextWriter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/TextReader.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TextWriter                              |Type           |             |             |
|Flush                                   |Call           |             |             |
|Dispose                                 |Call           |             |             |
|Write                                   |Call           |             |             |
|WriteLine                               |Call           |             |             |
|Close                                   |Call           |             |             |
 
### System.Linq.Enumerable
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.IO/TextWriter.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Linq.Expressions.Expression
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Linq/Enumerable.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Linq.Expressions.LambdaExpression
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Linq.Expressions/Expression.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Linq.Expressions.MemberExpression
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Linq.Expressions/LambdaExpression.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Linq.Expressions.UnaryExpression
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Linq.Expressions/MemberExpression.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Net.DownloadStringCompletedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Linq.Expressions/UnaryExpression.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Error                                   |MemberAccess   |             |             |
|Result                                  |MemberAccess   |             |             |
 
### System.Net.DownloadStringCompletedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Net/DownloadStringCompletedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DownloadStringCompletedEventHandler     |Type           |             |Always       |
 
### System.Net.HttpUtility
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Net/DownloadStringCompletedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|HttpUtility                             |Type           |             |             |
 
### System.Net.HttpWebRequest
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Net/HttpUtility.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|HttpWebRequest                          |Type           |             |             |
|UserAgent                               |MemberAccess   |             |             |
 
### System.Net.HttpWebResponse
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Net/HttpWebRequest.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|HttpWebResponse                         |Type           |             |             |
 
### System.Net.OpenReadCompletedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Net/HttpWebResponse.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Result                                  |MemberAccess   |             |             |
 
### System.Net.OpenReadCompletedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Net/OpenReadCompletedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|OpenReadCompletedEventHandler           |Type           |             |Always       |
 
### System.Net.WebClient
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Net/OpenReadCompletedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|WebClient                               |Type           |             |             |
|DownloadStringCompleted                 |MemberAccess   |             |             |
|OpenReadCompleted                       |MemberAccess   |             |             |
|Headers                                 |MemberAccess   |             |             |
|IsBusy                                  |MemberAccess   |             |             |
|DownloadStringAsync                     |Call           |             |             |
|OpenReadAsync                           |Call           |             |             |
 
### System.Net.WebRequest
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Net/WebClient.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|WebRequest                              |Type           |             |             |
|ContentLength                           |Assign         |             |             |
 
### System.Net.WebResponse
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Net/WebRequest.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|WebResponse                             |Type           |             |             |
|Close                                   |Call           |             |             |
 
### System.Reflection.Assembly
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Net/WebResponse.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FullName                                |MemberAccess   |             |             |
|GetExecutingAssembly                    |Call           |             |             |
|GetManifestResourceStream               |Call           |             |             |
|GetType                                 |Call           |             |             |
|Load                                    |Call           |             |             |
 
### System.Reflection.AssemblyCompanyAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/Assembly.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AssemblyCompanyAttribute                |Type           |             |             |
 
### System.Reflection.AssemblyConfigurationAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/AssemblyCompanyAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AssemblyConfigurationAttribute          |Type           |             |             |
 
### System.Reflection.AssemblyCopyrightAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/AssemblyConfigurationAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AssemblyCopyrightAttribute              |Type           |             |             |
 
### System.Reflection.AssemblyCultureAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/AssemblyCopyrightAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AssemblyCultureAttribute                |Type           |             |             |
|Value                                   |MemberAccess   |             |             |
 
### System.Reflection.AssemblyDescriptionAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/AssemblyCultureAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AssemblyDescriptionAttribute            |Type           |             |             |
 
### System.Reflection.AssemblyFileVersionAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/AssemblyDescriptionAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AssemblyFileVersionAttribute            |Type           |             |             |
|Version                                 |MemberAccess   |             |             |
 
### System.Reflection.AssemblyName
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/AssemblyFileVersionAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AssemblyName                            |Type           |             |             |
|Name                                    |MemberAccess   |             |             |
|Version                                 |MemberAccess   |             |             |
 
### System.Reflection.AssemblyProductAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/AssemblyName.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AssemblyProductAttribute                |Type           |             |             |
 
### System.Reflection.AssemblyTitleAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/AssemblyProductAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AssemblyTitleAttribute                  |Type           |             |             |
 
### System.Reflection.AssemblyTrademarkAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/AssemblyTitleAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AssemblyTrademarkAttribute              |Type           |             |             |
 
### System.Reflection.AssemblyVersionAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/AssemblyTrademarkAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AssemblyVersionAttribute                |Type           |             |             |
 
### System.Reflection.ConstructorInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/AssemblyVersionAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Invoke                                  |Call           |             |             |
 
### System.Reflection.DefaultMemberAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/ConstructorInfo.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DefaultMemberAttribute                  |Type           |             |             |
 
### System.Reflection.EventInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/DefaultMemberAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|EventHandlerType                        |MemberAccess   |             |             |
 
### System.Reflection.FieldInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/EventInfo.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|EventHandlerType                        |MemberAccess   |             |             |
|FieldType                               |MemberAccess   |             |             |
|IsLiteral                               |MemberAccess   |             |             |
|IsPrivate                               |MemberAccess   |             |             |
|IsPublic                                |MemberAccess   |             |             |
|IsStatic                                |MemberAccess   |             |             |
|IsInitOnly                              |MemberAccess   |             |             |
|GetFieldFromHandle                      |Call           |             |             |
|GetValue                                |Call           |             |             |
|SetValue                                |Call           |             |             |
 
### System.Reflection.IntrospectionExtensions
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/FieldInfo.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GetTypeInfo                             |Call           |             |             |
 
### System.Reflection.MemberInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/IntrospectionExtensions.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DeclaringType                           |MemberAccess   |             |             |
|MemberType                              |MemberAccess   |             |             |
|Name                                    |MemberAccess   |             |             |
|GetCustomAttributes                     |Call           |             |             |
|IsDefined                               |MemberAccess   |             |             |
 
### System.Reflection.MethodBase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/MemberInfo.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ContainsGenericParameters               |MemberAccess   |             |             |
|IsPublic                                |MemberAccess   |             |             |
|IsStatic                                |MemberAccess   |             |             |
|IsVirtual                               |MemberAccess   |             |             |
|GetMethodFromHandle                     |Call           |             |             |
|GetParameters                           |Call           |             |             |
|Invoke                                  |Call           |             |             |
 
### System.Reflection.MethodInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/MethodBase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ReturnType                              |MemberAccess   |             |             |
 
### System.Reflection.ParameterInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/MethodInfo.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Member                                  |MemberAccess   |             |             |
|Name                                    |MemberAccess   |             |             |
|ParameterType                           |MemberAccess   |             |             |
 
### System.Reflection.PropertyInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/ParameterInfo.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CanRead                                 |MemberAccess   |             |             |
|CanWrite                                |MemberAccess   |             |             |
|PropertyType                            |MemberAccess   |             |             |
|GetGetMethod                            |Call           |             |             |
|GetIndexParameters                      |Call           |             |             |
|GetSetMethod                            |Call           |             |             |
|GetValue                                |Call           |             |             |
|SetValue                                |Call           |             |             |
 
### System.Reflection.RuntimeReflectionExtensions
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/PropertyInfo.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GetRuntimeProperties                    |Call           |             |             |
 
### System.Reflection.TypeInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/RuntimeReflectionExtensions.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|IsAssignableFrom                        |Call           |             |             |
 
### System.Resources.NeutralResourcesLanguageAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Reflection/TypeInfo.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Resources.ResourceManager
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Resources/NeutralResourcesLanguageAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GetString                               |Call           |             |             |
 
### System.Runtime.CompilerServices.AsyncStateMachineAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Resources/ResourceManager.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.CompilerServices.AsyncTaskMethodBuilder
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.CompilerServices/AsyncStateMachineAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.CompilerServices.AsyncVoidMethodBuilder
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.CompilerServices/AsyncTaskMethodBuilder.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.CompilerServices.DynamicAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.CompilerServices/AsyncVoidMethodBuilder.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.CompilerServices.ExtensionAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.CompilerServices/DynamicAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.CompilerServices.IAsyncStateMachine
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.CompilerServices/ExtensionAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.CompilerServices.InternalsVisibleToAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.CompilerServices/IAsyncStateMachine.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.CompilerServices.RuntimeHelpers
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.CompilerServices/InternalsVisibleToAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.CompilerServices.TaskAwaiter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.CompilerServices/RuntimeHelpers.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.InteropServices.ComVisibleAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.CompilerServices/TaskAwaiter.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.InteropServices.GuidAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.InteropServices/ComVisibleAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.InteropServices.OutAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.InteropServices/GuidAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.InteropServices.StructLayoutAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.InteropServices/OutAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Runtime.Serialization.DataContractAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.InteropServices/StructLayoutAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DataContractAttribute                   |Type           |             |             |
|IsReference                             |MemberAccess   |             |             |
 
### System.Runtime.Serialization.DataContractSerializer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.Serialization/DataContractAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DataContractSerializer                  |Type           |             |             |
 
### System.Runtime.Serialization.DataMemberAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.Serialization/DataContractSerializer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DataMemberAttribute                     |Type           |             |             |
|EmitDefaultValue                        |MemberAccess   |             |             |
|IsRequired                              |MemberAccess   |             |             |
|Name                                    |MemberAccess   |             |             |
|Order                                   |MemberAccess   |             |             |
 
### System.Runtime.Serialization.EnumMemberAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.Serialization/DataMemberAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|EnumMemberAttribute                     |Type           |             |             |
|Value                                   |MemberAccess   |             |             |
 
### System.Runtime.Serialization.Json.DataContractJsonSerializer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.Serialization/EnumMemberAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DataContractJsonSerializer              |Type           |             |             |
|ReadObject                              |Call           |             |             |
|WriteObject                             |Call           |             |             |
 
### System.Runtime.Serialization.XmlObjectSerializer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.Serialization.Json/DataContractJsonSerializer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|XmlObjectSerializer                     |Type           |             |             |
|ReadObject                              |Call           |             |             |
|WriteObject                             |Call           |             |             |
 
### System.Runtime.Versioning.TargetFrameworkAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.Serialization/XmlObjectSerializer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Security.Cryptography.AesManaged
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Runtime.Versioning/TargetFrameworkAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AesManaged                              |Type           |             |Always       |
 
### System.Security.Cryptography.CryptoStream
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Security.Cryptography/AesManaged.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CryptoStream                            |Type           |             |Always       |
 
### System.Security.Cryptography.HashAlgorithm
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Security.Cryptography/CryptoStream.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ComputeHash                             |Call           |             |             |
 
### System.Security.Cryptography.SHA1Managed
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Security.Cryptography/HashAlgorithm.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SHA1Managed                             |Type           |             |             |
|ComputeHash                             |Call           |             |             |
 
### System.Security.Cryptography.SymmetricAlgorithm
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Security.Cryptography/SHA1Managed.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|IV                                      |MemberAccess   |             |Always       |
|Key                                     |Assign         |             |Always       |
|CreateDecryptor                         |Call           |             |Always       |
|CreateEncryptor                         |Call           |             |Always       |
 
### System.ServiceModel.Syndication.SyndicationFeed
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Security.Cryptography/SymmetricAlgorithm.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SyndicationFeed                         |Type           |             |             |
|Load                                    |Call           |Always       |             |
 
### System.String
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.ServiceModel.Syndication/SyndicationFeed.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.StringComparison
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System/String.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|StringComparison                        |Type           |             |             |
|InvariantCulture                        |MemberAccess   |             |             |
|InvariantCultureIgnoreCase              |MemberAccess   |             |             |
 
### System.Text.Encoding
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System/StringComparison.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Unicode                                 |MemberAccess   |             |             |
|UTF8                                    |MemberAccess   |             |             |
|WebName                                 |MemberAccess   |             |             |
|GetByteCount                            |Call           |             |             |
|GetBytes                                |Call           |             |             |
|GetChars                                |Call           |             |             |
|GetEncoding                             |Call           |             |             |
|GetMaxCharsCount                        |Call           |             |             |
|GetString                               |Call           |             |             |
 
### System.Text.RegularExpressions.Capture
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Text/Encoding.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Text.RegularExpressions.GroupCollection
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Text.RegularExpressions/Capture.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Text.RegularExpressions.Match
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Text.RegularExpressions/GroupCollection.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Text.RegularExpressions.MatchCollection
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Text.RegularExpressions/Match.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Text.RegularExpressions.Regex
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Text.RegularExpressions/MatchCollection.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Text.StringBuilder
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Text.RegularExpressions/Regex.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Text.UTF8Encoding
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Text/StringBuilder.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Threading.AutoResetEvent
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Text/UTF8Encoding.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Threading.EventWaitHandle
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/AutoResetEvent.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Threading.Interlocked
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/EventWaitHandle.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CompareExchange                         |Call           |             |             |
 
### System.Threading.ManualResetEvent
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/Interlocked.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Threading.Monitor
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/ManualResetEvent.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Enter                                   |Call           |             |             |
|Exit                                    |Call           |             |             |
 
### System.Threading.SendOrPostCallback
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/Monitor.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Threading.SynchronizationContext
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/SendOrPostCallback.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Send                                    |Call           |             |             |
|Post                                    |Call           |             |             |
 
### System.Threading.Tasks.Task
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/SynchronizationContext.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Factory                                 |MemberAccess   |             |             |
|FromResult                              |Call           |             |             |
|GetAwaiter                              |Call           |             |             |
|Wait                                    |Call           |             |             |
 
### System.Threading.Tasks.TaskFactory
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading.Tasks/Task.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FromAsync                               |Call           |             |             |
|StartNew                                |Call           |             |             |
 
### System.Threading.Thread
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading.Tasks/TaskFactory.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Thread                                  |Type           |             |             |
|Start                                   |Call           |             |             |
|Sleep                                   |Call           |             |             |
|CurrentCulture                          |MemberAccess   |             |             |
|CurrentCulture                          |Assign         |             |             |
|ManagedThreadId                         |MemberAccess   |             |             |
|CurrentThread                           |Call           |             |Always       |
 
### System.Threading.ThreadPool
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/Thread.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ThreadPool                              |Type           |             |             |
|QueueUserWorkItem                       |Call           |             |             |
 
### System.Threading.ThreadStart
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/ThreadPool.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ThreadStart                             |Type           |             |             |
 
### System.Threading.Timer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/ThreadStart.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Timer                                   |Type           |             |             |
|Change                                  |Call           |             |             |
|Dispose                                 |Call           |             |             |
 
### System.Threading.TimerCallback
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/Timer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Threading.WaitCallback
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/TimerCallback.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|WaitCallback                            |Type           |             |             |
 
### System.Threading.WaitHandle
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/WaitCallback.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|WaitOne                                 |Call           |             |             |
 
### System.Uri
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Threading/WaitHandle.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Windows.Application
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System/Uri.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Application                             |Type           |             |             |
|GetResourceStream                       |Call           |             |             |
|Terminate                               |Call           |             |             |
|LoadComponent                           |Call           |             |             |
|Resources                               |MemberAccess   |             |             |
|Current                                 |MemberAccess   |             |             |
|Host                                    |MemberAccess   |             |             |
|RootVisual                              |MemberAccess   |             |             |
 
### System.Windows.BaseButton
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/ApplicationMapper.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|BaseButton                              |Type           |             |             |
 
### System.Windows.Clipboard
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/ButtonBase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SetText                                 |Call           |Conditionally|             |
|GetText                                 |Call           |Always       |             |
 
### System.Windows.Controls.Border
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/Clipboard.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Border                                  |Type           |             |             |
|Background                              |MemberAccess   |             |             |
 
### System.Windows.Controls.Button
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/Border.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Button                                  |Type           |             |             |
 
### System.Windows.Controls.Canvas
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/Button.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Canvas                                  |Type           |             |             |
|GetTop                                  |MemberAccess   |             |             |
|LeftProperty                            |MemberAccess   |             |             |
|SetLeft                                 |MemberAccess   |             |             |
|SetTop                                  |MemberAccess   |             |             |
|SetZIndex                               |MemberAccess   |             |             |
|TopProperty                             |MemberAccess   |             |             |
 
### System.Windows.Controls.CheckBox
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/Canvas.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CheckBox                                |Type           |             |             |
 
### System.Windows.Controls.ColumnDefinition
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/CheckBox.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ColumnDefinition                        |Type           |             |             |
|Width                                   |MemberAccess   |             |             |
 
### System.Windows.Controls.ContentControl
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/ColumnDefinition.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ContentControl                          |Type           |             |             |
|Content                                 |MemberAccess   |             |             |
|ContentTemplate                         |MemberAccess   |             |             |
|OnContentChanged                        |Call           |             |             |
 
### System.Windows.Controls.ContentPresenter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/ContentControl.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ContentPresenter                        |Type           |             |             |
|Content                                 |MemberAccess   |             |             |
 
### System.Windows.Controls.Control
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/ContentPresenter.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Control                                 |Type           |             |             |
|IsEnabledChanged                        |MemberAccess   |             |             |
|ApplyTemplate                           |Call           |             |             |
|Focus                                   |Call           |             |             |
|Background                              |MemberAccess   |             |             |
|FontSize                                |MemberAccess   |             |             |
|IsEnabled                               |MemberAccess   |             |             |
|GetTemplateChild                        |Call           |             |             |
|BorderThickness                         |MemberAccess   |             |             |
|DefaultStyleKey                         |MemberAccess   |             |             |
|Padding                                 |MemberAccess   |             |             |
|Foreground                              |MemberAccess   |             |             |
|HorizontalContentAlignment              |MemberAccess   |             |             |
|VerticalContentAlignment                |MemberAccess   |             |             |
 
### System.Windows.Controls.Frame
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/Control.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Frame                                   |Type           |             |             |
|Navigated                               |MemberAccess   |             |             |
|Navigating                              |MemberAccess   |             |             |
|NavigationFailed                        |MemberAccess   |             |             |
|NavigationStopped                       |MemberAccess   |             |             |
|CurrentSource                           |MemberAccess   |             |             |
 
### System.Windows.Controls.Grid
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/Frame.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Grid                                    |Type           |             |             |
|SetColumn                               |Call           |             |             |
|SetColumnSpan                           |Call           |             |             |
|SetRow                                  |Call           |             |             |
|SetRowSpan                              |Call           |             |             |
|RowProperty                             |MemberAccess   |             |             |
|ColumnProperty                          |MemberAccess   |             |             |
|RowDefinitions                          |MemberAccess   |             |             |
|ColumnDefinitions                       |MemberAccess   |             |             |
 
### System.Windows.Controls.Image
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/Grid.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Image                                   |Type           |             |             |
|ImageFailed                             |MemberAccess   |             |             |
|ImageOpened                             |MemberAccess   |             |             |
|Source                                  |MemberAccess   |             |             |
|Stretch                                 |MemberAccess   |             |             |
 
### System.Windows.Controls.ItemContainerGenerator
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/Image.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ItemContainerGenerator                  |Type           |             |             |
|ContainerFromIndex                      |Call           |             |             |
|ContainerFromItem                       |Call           |             |             |
 
### System.Windows.Controls.ItemsControl
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/ItemContainerGenerator.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ItemsControl                            |Type           |             |             |
|Items                                   |MemberAccess   |             |             |
|ItemContainerGenerator                  |MemberAccess   |             |             |
|ItemsSource                             |MemberAccess   |             |             |
 
### System.Windows.Controls.ListBox
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/ItemsControl.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ListBox                                 |Type           |             |             |
 
### System.Windows.Controls.ListBoxItem
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/ListBox.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ListBoxItem                             |Type           |             |             |
 
### System.Windows.Controls.MediaElement
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/ListBoxItem.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MediaElement                            |Type           |             |             |
|Source                                  |MemberAccess   |             |             |
|Play                                    |Call           |             |             |
 
### System.Windows.Controls.Orientation
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/MediaElement.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Orientation                             |Type           |             |             |
 
### System.Windows.Controls.Page
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/Orientation.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Page                                    |Type           |             |             |
|OnNavigatedFrom                         |MemberAccess   |             |             |
|OnNavigatedTo                           |MemberAccess   |             |             |
|OnNavigatingFrom                        |MemberAccess   |             |             |
|NavigationContext                       |MemberAccess   |             |             |
|NavigationService                       |Call           |             |             |
 
### System.Windows.Controls.Panel
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/Page.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Panel                                   |Type           |             |             |
|Background                              |MemberAccess   |             |             |
|Children                                |MemberAccess   |             |             |
 
### System.Windows.Controls.PasswordBox
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/Panel.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PasswordBox                             |Type           |             |             |
|PasswordChanged                         |MemberAccess   |             |             |
|Password                                |MemberAccess   |             |             |
|PasswordProperty                        |MemberAccess   |             |             |
 
### System.Windows.Controls.Primitives.ButtonBase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/PasswordBox.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ButtonBase                              |Type           |             |             |
|Click                                   |MemberAccess   |             |             |
 
### System.Windows.Controls.Primitives.Popup
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls.Primitives/ButtonBase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Popup                                   |Type           |             |             |
|IsOpen                                  |MemberAccess   |             |             |
|Child                                   |MemberAccess   |             |             |
|HorizontalOffset                        |MemberAccess   |             |             |
|VerticalOffset                          |MemberAccess   |             |             |
 
### System.Windows.Controls.Primitives.RangeBase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls.Primitives/Popup.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|RangeBase                               |Type           |             |             |
|Minimum                                 |MemberAccess   |             |             |
|Maximum                                 |MemberAccess   |             |             |
|Value                                   |MemberAccess   |             |             |
 
### System.Windows.Controls.Primitives.Selector
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls.Primitives/RangeBase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Selector                                |Type           |             |             |
|SelectionChanged                        |MemberAccess   |             |             |
|SelectedIndex                           |MemberAccess   |             |             |
|SelectedItem                            |MemberAccess   |             |             |
 
### System.Windows.Controls.Primitives.ToggleButton
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls.Primitives/Selector.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ToggleButton                            |Type           |             |             |
|IsChecked                               |MemberAccess   |             |             |
|Tap                                     |MemberAccess   |             |             |
 
### System.Windows.Controls.ProgressBar
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls.Primitives/ToggleButton.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ProgressBar                             |Type           |             |             |
|IsIndeterminate                         |MemberAccess   |             |             |
 
### System.Windows.Controls.RowDefinition
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/ProgressBar.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|RowDefinition                           |Type           |             |             |
|Height                                  |MemberAccess   |             |             |
 
### System.Windows.Controls.ScrollViewer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/RowDefinition.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ScrollViewer                            |Type           |             |             |
|VerticalOffset                          |MemberAccess   |             |             |
|HorizontalOffset                        |MemberAccess   |             |             |
|ScrollToVerticalOffset                  |Call           |             |             |
|ScrollToHorizontalOffset                |Call           |             |             |
 
### System.Windows.Controls.SelectionChangedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/ScrollViewer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SelectionChangedEventArgs               |Type           |             |             |
|AddedItems                              |MemberAccess   |             |             |
|RemovedItems                            |MemberAccess   |             |             |
 
### System.Windows.Controls.SelectionChangedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/SelectionChangedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SelectionChangedEventHandler            |Type           |             |             |
 
### System.Windows.Controls.Slider
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/SelectionChangedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Slider                                  |Type           |             |             |
 
### System.Windows.Controls.StackPanel
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/Slider.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|StackPanel                              |Type           |             |             |
|Orientation                             |MemberAccess   |             |             |
 
### System.Windows.Controls.TextBlock
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/StackPanel.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TextBlock                               |Type           |             |             |
|Text                                    |MemberAccess   |             |             |
|TextWrapping                            |MemberAccess   |             |             |
|Foreground                              |MemberAccess   |             |             |
|FontSize                                |MemberAccess   |             |             |
|FontFamily                              |MemberAccess   |             |             |
 
### System.Windows.Controls.TextBox
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/TextBlock.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TextBox                                 |Type           |             |             |
|TextChanged                             |MemberAccess   |             |             |
|SelectionStart                          |MemberAccess   |             |             |
|SelectionLength                         |MemberAccess   |             |             |
|Text                                    |MemberAccess   |             |             |
|OnGotFocus                              |MemberAccess   |             |             |
|OnLostFocus                             |MemberAccess   |             |             |
|SelectAll                               |Call           |             |             |
|TextProperty                            |MemberAccess   |             |             |
 
### System.Windows.Controls.TextChangedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/TextBox.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TextChangedEventHandler                 |Type           |             |             |
 
### System.Windows.Controls.UserControl
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/TextChangedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|UserControl                             |Type           |             |             |
|Content                                 |MemberAccess   |             |             |
 
### System.Windows.Data.Binding
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Controls/UserControl.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Binding                                 |Type           |             |             |
|Converter                               |MemberAccess   |             |             |
|ConverterParameter                      |MemberAccess   |             |             |
|Mode                                    |MemberAccess   |             |             |
|Path                                    |MemberAccess   |             |             |
|Source                                  |MemberAccess   |             |             |
 
### System.Windows.Data.BindingMode
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Data/Binding.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|BindingMode                             |Type           |             |             |
 
### System.Windows.Data.IValueConverter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Data/BindingMode.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|IValueConverter                         |Type           |             |             |
 
### System.Windows.DependencyObject
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Data/IValueConverter.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DependencyObject                        |Type           |             |             |
|Dispatcher                              |MemberAccess   |             |             |
|ClearValue                              |Call           |             |             |
|GetValue                                |Call           |             |             |
|ReadLocalValue                          |Call           |             |             |
|SetValue                                |Call           |             |             |
 
### System.Windows.DependencyProperty
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/DependencyObject.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DependencyProperty                      |Type           |             |             |
|UnsetValue                              |MemberAccess   |             |             |
|RegisterAttached                        |Call           |             |             |
|GetValue                                |Call           |             |             |
|Register                                |Call           |             |             |
 
### System.Windows.DependencyPropertyChangedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/DependencyProperty.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DependencyPropertyChangedEventArgs      |Type           |             |             |
|NewValue                                |MemberAccess   |             |             |
|OldValue                                |MemberAccess   |             |             |
 
### System.Windows.DependencyPropertyChangedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/DependencyPropertyChangedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DependencyPropertyChangedEventHandler   |Type           |             |             |
 
### System.Windows.Deployment
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/DependencyPropertyChangedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Current                                 |MemberAccess   |             |             |
 
### System.Windows.Documents.Inline
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/Deployment.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Inline                                  |Type           |             |             |
|TextDecorations                         |MemberAccess   |             |Always       |
 
### System.Windows.Documents.InlineCollection
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Documents/Inline.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|InlineCollection                        |Type           |             |             |
|Add                                     |Call           |             |             |
 
### System.Windows.Documents.Run
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Documents/InlineCollection.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Run                                     |Type           |             |             |
|Text                                    |MemberAccess   |             |             |
 
### System.Windows.Duration
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Documents/Run.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Duration                                |Type           |             |             |
|TimeSpan                                |MemberAccess   |             |             |
 
### System.Windows.FontStyles
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/Duration.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FontStyles                              |Type           |             |             |
 
### System.Windows.FontWeights
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/FontStyles.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FontWeights                             |Type           |             |             |
|Bold                                    |MemberAccess   |             |             |
 
### System.Windows.FrameworkElement
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/FontWeights.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FrameworkElement                        |Type           |             |             |
|ArrangeOverride                         |Call           |             |             |
|FindName                                |Call           |             |             |
|GetBindingExpression                    |Call           |             |             |
|MeasureOverride                         |Call           |             |             |
|OnApplyTemplate                         |Call           |             |             |
|ActualHeight                            |MemberAccess   |             |             |
|ActualWidth                             |MemberAccess   |             |             |
|DataContext                             |MemberAccess   |             |             |
|FlowDirection                           |MemberAccess   |             |             |
|HorizontalAlignment                     |MemberAccess   |             |             |
|Margin                                  |MemberAccess   |             |             |
|Name                                    |MemberAccess   |             |             |
|Parent                                  |MemberAccess   |             |             |
|Resources                               |MemberAccess   |             |             |
|Tag                                     |MemberAccess   |             |             |
|VerticalAlignment                       |MemberAccess   |             |             |
|Width                                   |MemberAccess   |             |             |
|Height                                  |MemberAccess   |             |             |
|Style                                   |MemberAccess   |             |             |
|MaxHeight                               |MemberAccess   |             |             |
|HeightProperty                          |MemberAccess   |             |             |
|Language                                |MemberAccess   |             |             |
|SetBinding                              |Call           |             |Conditionally|
|LayoutUpdated                           |MemberAccess   |             |             |
|Loaded                                  |MemberAccess   |             |             |
|SizeChanged                             |MemberAccess   |             |             |
|Unloaded                                |MemberAccess   |             |             |
 
### System.Windows.GridLength
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/FrameworkElement.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GridLength                              |Type           |             |             |
 
### System.Windows.GridUnitType
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/GridLength.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GridUnitType                            |Type           |             |             |
 
### System.Windows.HorizontalAlignment
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/GridUnitType.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|HorizontalAlignment                     |Type           |             |             |
 
### System.Windows.Input.GestureEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/HorizontalAlignment.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Windows.Input.ICommand
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/GestureEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Windows.Input.InputScope
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/ICommand.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|InputScope                              |Type           |             |             |
 
### System.Windows.Input.InputScopeName
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/InputScope.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|InputScopeName                          |Type           |             |             |
 
### System.Windows.Input.InputScopeNameValue
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/InputScopeName.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|InputScopeNameValue                     |Type           |             |             |
|EnumString                              |MemberAccess   |             |Always       |
|Xml                                     |MemberAccess   |             |Always       |
|Srgs                                    |MemberAccess   |             |Always       |
|RegularExpression                       |MemberAccess   |             |Always       |
|PhraseList                              |MemberAccess   |             |Always       |
|FullFilePath                            |MemberAccess   |             |Always       |
|FileName                                |MemberAccess   |             |Always       |
|EmailUserName                           |MemberAccess   |             |Always       |
|LogOnName                               |MemberAccess   |             |Always       |
|PersonalNamePrefix                      |MemberAccess   |             |Always       |
|PersonalGivenName                       |MemberAccess   |             |Always       |
|PersonalMiddleName                      |MemberAccess   |             |Always       |
|PersonalSurname                         |MemberAccess   |             |Always       |
|PersonalNameSuffix                      |MemberAccess   |             |Always       |
|PostalAddress                           |MemberAccess   |             |Always       |
|PostalCode                              |MemberAccess   |             |Always       |
|AddressStreet                           |MemberAccess   |             |Always       |
|AddressStateOrProvince                  |MemberAccess   |             |Always       |
|AddressCity                             |MemberAccess   |             |Always       |
|AddressCountryName                      |MemberAccess   |             |Always       |
|AddressCountryShortName                 |MemberAccess   |             |Always       |
|Date                                    |MemberAccess   |             |Always       |
|DateMonthName                           |MemberAccess   |             |Always       |
|DateDayName                             |MemberAccess   |             |Always       |
|OneChar                                 |MemberAccess   |             |Always       |
|Time                                    |MemberAccess   |             |Always       |
|CurrencyChinese                         |MemberAccess   |             |Always       |
|Bopomofo                                |MemberAccess   |             |Always       |
|Hanja                                   |MemberAccess   |             |Always       |
|Yomi                                    |MemberAccess   |             |Always       |
|Private                                 |MemberAccess   |             |Always       |
|ApplicationEnd                          |MemberAccess   |             |Always       |
|DateMonth                               |MemberAccess   |             |             |
|DateDay                                 |MemberAccess   |             |             |
|TimeMinorSec                            |MemberAccess   |             |             |
 
### System.Windows.Input.Key
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/InputScopeNameValue.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Key                                     |Type           |             |             |
|Shift                                   |MemberAccess   |             |             |
|Ctrl                                    |MemberAccess   |             |             |
|CapsLock                                |MemberAccess   |             |             |
 
### System.Windows.Input.KeyEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/Key.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|KeyEventArgs                            |Type           |             |             |
 
### System.Windows.Input.KeyEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/KeyEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|KeyEventHandler                         |Type           |             |             |
 
### System.Windows.Input.ManipulationCompletedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/KeyEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ManipulationCompletedEventArgs          |Type           |             |             |
|ManipulationContainer                   |MemberAccess   |             |             |
|FinalVelocities                         |MemberAccess   |             |             |
|TotalManipulation                       |MemberAccess   |             |             |
|FinalVelocities                         |MemberAccess   |             |             |
|IsInertial                              |MemberAccess   |             |             |
 
### System.Windows.Input.ManipulationDelta
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/ManipulationCompletedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ManipulationDelta                       |Type           |             |             |
|Translation                             |MemberAccess   |             |             |
|Scale                                   |MemberAccess   |             |             |
 
### System.Windows.Input.ManipulationDeltaEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/ManipulationDelta.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ManipulationDeltaEventArgs              |Type           |             |             |
|ManipulationContainer                   |MemberAccess   |             |             |
|DeltaManipulation                       |MemberAccess   |             |             |
|CumulativeManipulation                  |MemberAccess   |             |             |
|ManipulationOrigin                      |MemberAccess   |             |             |
|Handled                                 |MemberAccess   |             |             |
|PinchManipulation                       |MemberAccess   |             |Always       |
 
### System.Windows.Input.ManipulationStartedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/ManipulationDeltaEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ManipulationStartedEventArgs            |Type           |             |             |
|ManipulationContainer                   |MemberAccess   |             |             |
|Handled                                 |MemberAccess   |             |             |
|ManipulationOrigin                      |MemberAccess   |             |             |
 
### System.Windows.Input.ManipulationVelocities
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/ManipulationStartedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ManipulationVelocities                  |Type           |             |             |
|LinearVelocity                          |MemberAccess   |             |             |
|ExpansionVelocity                       |MemberAccess   |             |Always       |
 
### System.Windows.Input.MouseButtonEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/ManipulationVelocities.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MouseButtonEventArgs                    |Type           |             |             |
|Handled                                 |MemberAccess   |             |             |
 
### System.Windows.Input.MouseButtonEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/MouseButtonEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MouseButtonEventHandler                 |Type           |             |             |
 
### System.Windows.Input.MouseEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/MouseButtonEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MouseEventHandler                       |Type           |             |             |
 
### System.Windows.Input.Touch
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/MouseEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FrameReported                           |MemberAccess   |             |             |
 
### System.Windows.Input.TouchFrameEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/Touch.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TouchFrameEventArgs                     |Type           |             |             |
|GetPrimaryTouchPoint                    |Call           |             |             |
|GetTouchPoints                          |Call           |             |             |
 
### System.Windows.Input.TouchFrameEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/TouchFrameEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TouchFrameEventHandler                  |Type           |             |             |
 
### System.Windows.Input.TouchPoint
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/TouchFrameEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TouchPoint                              |Type           |             |             |
|Action                                  |MemberAccess   |             |Always       |
 
### System.Windows.Interop.Content
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Input/TouchPoint.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ScaleFactor                             |MemberAccess   |             |             |
|ActualHeight                            |MemberAccess   |             |             |
|ActualWidth                             |MemberAccess   |             |             |
 
### System.Windows.Interop.Settings
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Interop/Content.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Settings                                |Type           |             |             |
|EnableFrameRateCounter                  |MemberAccess   |             |             |
 
### System.Windows.Interop.SilverlightHost
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Interop/Settings.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Content                                 |MemberAccess   |             |             |
|Settings                                |MemberAccess   |             |             |
 
### System.Windows.Markup.ContentPropertyAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Interop/SilverlightHost.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ContentPropertyAttribute                |Type           |             |             |
 
### System.Windows.Markup.XamlReader
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Markup/ContentPropertyAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|XamlReader                              |Type           |             |             |
 
### System.Windows.Markup.XmlLanguage
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Markup/XamlReader.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|XmlLanguage                             |Type           |             |             |
|GetLanguage                             |Call           |             |             |
 
### System.Windows.Media.Animation.BackEase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Markup/XmlLanguage.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|BackEase                                |Type           |             |             |
 
### System.Windows.Media.Animation.BounceEase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/BackEase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|BounceEase                              |Type           |             |             |
 
### System.Windows.Media.Animation.CircleEase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/BounceEase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CircleEase                              |Type           |             |             |
 
### System.Windows.Media.Animation.CubicEase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/CircleEase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CubicEase                               |Type           |             |             |
 
### System.Windows.Media.Animation.DoubleAnimation
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/CubicEase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DoubleAnimation                         |Type           |             |             |
|From                                    |MemberAccess   |             |             |
|To                                      |MemberAccess   |             |             |
|EasingFunction                          |MemberAccess   |             |             |
 
### System.Windows.Media.Animation.DoubleAnimationUsingKeyFrames
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/DoubleAnimation.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DoubleAnimationUsingKeyFrames           |Type           |             |             |
|KeyFrames                               |MemberAccess   |             |             |
 
### System.Windows.Media.Animation.DoubleKeyFrame
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/DoubleAnimationUsingKeyFrames.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DoubleKeyFrame                          |Type           |             |             |
|KeyTime                                 |MemberAccess   |             |             |
|Value                                   |MemberAccess   |             |             |
 
### System.Windows.Media.Animation.EasingDoubleKeyFrame
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/DoubleKeyFrame.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|EasingDoubleKeyFrame                    |Type           |             |             |
 
### System.Windows.Media.Animation.EasingFunctionBase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/EasingDoubleKeyFrame.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|EasingFunctionBase                      |Type           |             |             |
|EasingMode                              |MemberAccess   |             |             |
 
### System.Windows.Media.Animation.ElasticEase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/EasingFunctionBase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ElasticEase                             |Type           |             |             |
 
### System.Windows.Media.Animation.ExponentialEase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/ElasticEase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ExponentialEase                         |Type           |             |             |
|Exponent                                |MemberAccess   |             |             |
 
### System.Windows.Media.Animation.KeyTime
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/ExponentialEase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|KeyTime                                 |Type           |             |             |
|FromTimeSpan                            |Call           |             |             |
|TimeSpan                                |MemberAccess   |             |             |
|Uniform                                 |MemberAccess   |             |Always       |
 
### System.Windows.Media.Animation.PowerEase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/KeyTime.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PowerEase                               |Type           |             |             |
 
### System.Windows.Media.Animation.QuadraticEase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/PowerEase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|QuadraticEase                           |Type           |             |             |
 
### System.Windows.Media.Animation.QuarticEase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/QuadraticEase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|QuarticEase                             |Type           |             |             |
 
### System.Windows.Media.Animation.QuinticEase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/QuarticEase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|QuinticEase                             |Type           |             |             |
 
### System.Windows.Media.Animation.SineEase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/QuinticEase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SineEase                                |Type           |             |             |
 
### System.Windows.Media.Animation.Storyboard
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/SineEase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Storyboard                              |Type           |             |             |
|SetTargetProperty                       |Call           |             |             |
|Children                                |MemberAccess   |             |             |
|Begin                                   |Call           |             |             |
|GetCurrentState                         |Call           |             |             |
|Pause                                   |Call           |             |             |
|SeekAlignedToLastTick                   |Call           |             |             |
|SetTarget                               |Call           |             |             |
|SkipToFill                              |Call           |             |             |
|Stop                                    |Call           |             |             |
 
### System.Windows.Media.Animation.Timeline
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/Storyboard.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Timeline                                |Type           |             |             |
|Duration                                |MemberAccess   |             |             |
|AutoReverse                             |MemberAccess   |             |             |
|BeginTime                               |MemberAccess   |             |             |
|RepeatBehavior                          |MemberAccess   |             |             |
 
### System.Windows.Media.BitmapCache
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Animation/Timeline.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|BitmapCache                             |Type           |             |             |
|RenderAtScale                           |MemberAccess   |             |Always       |
 
### System.Windows.Media.Brush
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/BitmapCache.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Brush                                   |Type           |             |             |
|Opacity                                 |MemberAccess   |             |             |
 
### System.Windows.Media.Color
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/Brush.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Color                                   |Type           |             |             |
|FromArgb                                |MemberAccess   |             |             |
|A                                       |MemberAccess   |             |             |
|R                                       |MemberAccess   |             |             |
|G                                       |MemberAccess   |             |             |
|B                                       |MemberAccess   |             |             |
 
### System.Windows.Media.Colors
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/Color.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Colors                                  |Type           |             |             |
|Black                                   |MemberAccess   |             |             |
|Green                                   |MemberAccess   |             |             |
|Red                                     |MemberAccess   |             |             |
|Transparent                             |MemberAccess   |             |             |
|White                                   |MemberAccess   |             |             |
 
### System.Windows.Media.CompositeTransform
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/Colors.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CompositeTransform                      |Type           |             |             |
|ScaleX                                  |MemberAccess   |             |             |
|ScaleY                                  |MemberAccess   |             |             |
|TranslateX                              |MemberAccess   |             |             |
|TranslateY                              |MemberAccess   |             |             |
|CenterY                                 |MemberAccess   |             |             |
|CenterX                                 |MemberAccess   |             |             |
|Rotation                                |MemberAccess   |             |             |
|SkewX                                   |MemberAccess   |             |             |
|SkewY                                   |MemberAccess   |             |             |
 
### System.Windows.Media.CompositionTarget
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/CompositeTransform.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|CompositionTarget                       |Type           |             |             |
 
### System.Windows.Media.EllipseGeometry
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/CompositionTarget.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|EllipseGeometry                         |Type           |             |             |
|Rect                                    |MemberAccess   |             |             |
 
### System.Windows.Media.FontFamily
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/EllipseGeometry.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|FontFamily                              |Type           |             |             |
 
### System.Windows.Media.GeneralTransform
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/FontFamily.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GeneralTransform                        |Type           |             |             |
|Transform                               |Call           |             |             |
|TransformsBounds                        |Call           |             |             |
 
### System.Windows.Media.GeometryGroup
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/GeneralTransform.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GeometryGroup                           |Type           |             |             |
 
### System.Windows.Media.GradientBrush
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/GeometryGroup.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GradientBrush                           |Type           |             |             |
|GradientStops                           |MemberAccess   |             |             |
 
### System.Windows.Media.GradientStop
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/GradientBrush.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GradientStop                            |Type           |             |             |
|Offset                                  |MemberAccess   |             |             |
|Color                                   |MemberAccess   |             |             |
 
### System.Windows.Media.GradientStopCollection
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/GradientStop.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|GradientStopCollection                  |Type           |             |             |
 
### System.Windows.Media.ImageBrush
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/GradientStopCollection.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ImageBrush                              |Type           |             |             |
|ImageSource                             |MemberAccess   |             |             |
 
### System.Windows.Media.Imaging.BitmapImage
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/ImageBrush.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|BitmapImage                             |Type           |             |             |
|ImageOpened                             |MemberAccess   |             |             |
|UriSource                               |MemberAccess   |             |             |
|CreateOptions                           |MemberAccess   |             |             |
 
### System.Windows.Media.Imaging.BitmapSource
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Imaging/BitmapImage.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|BitmapSource                            |Type           |             |             |
|SetSource                               |Call           |             |             |
|PixelHeight                             |MemberAccess   |             |             |
|PixelWidth                              |MemberAccess   |             |             |
 
### System.Windows.Media.Imaging.Extensions
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Imaging/BitmapSource.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SaveJpeg                                |Call           |             |Conditionally|
|LoadJpeg                                |Call           |             |Always       |
 
### System.Windows.Media.Imaging.WriteableBitmap
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Imaging/Extensions.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|WriteableBitmap                         |Type           |             |             |
|Invalidate                              |Call           |             |             |
|Render                                  |Call           |Conditionally|Conditionally|
|Pixels                                  |MemberAccess   |             |             |
 
### System.Windows.Media.LinearGradientBrush
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media.Imaging/WriteableBitmap.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|LinearGradientBrush                     |Type           |             |             |
|StartPoint                              |MemberAccess   |             |             |
|EndPoint                                |MemberAccess   |             |             |
 
### System.Windows.Media.PlaneProjection
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/LinearGradientBrush.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PlaneProjection                         |Type           |             |             |
|GlobalOffsetZProperty                   |MemberAccess   |             |             |
|RotationXProperty                       |MemberAccess   |             |             |
|RotationYProperty                       |MemberAccess   |             |             |
|CenterOfRotationX                       |MemberAccess   |             |             |
|CenterOfRotationY                       |MemberAccess   |             |             |
|GlobalOffsetX                           |MemberAccess   |             |             |
|GlobalOffsetY                           |MemberAccess   |             |             |
|GlobalOffsetZ                           |MemberAccess   |             |             |
|RotationX                               |MemberAccess   |             |             |
|RotationY                               |MemberAccess   |             |             |
 
### System.Windows.Media.RectangleGeometry
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/PlaneProjection.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|RectangleGeometry                       |Type           |             |             |
|Rect                                    |MemberAccess   |             |             |
 
### System.Windows.Media.RotateTransform
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/RectangleGeometry.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|RotateTransform                         |Type           |             |             |
|Angle                                   |MemberAccess   |             |             |
|CenterX                                 |MemberAccess   |             |             |
|CenterY                                 |MemberAccess   |             |             |
 
### System.Windows.Media.ScaleTransform
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/RotateTransform.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ScaleTransform                          |Type           |             |             |
|ScaleX                                  |MemberAccess   |             |             |
|ScaleY                                  |MemberAccess   |             |             |
 
### System.Windows.Media.SkewTransform
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/ScaleTransform.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SkewTransform                           |Type           |             |             |
 
### System.Windows.Media.SolidColorBrush
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/SkewTransform.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SolidColorBrush                         |Type           |             |             |
|Color                                   |MemberAccess   |             |             |
 
### System.Windows.Media.Stretch
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/SolidColorBrush.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Stretch                                 |Type           |             |             |
 
### System.Windows.Media.TileBrush
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/Stretch.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TileBrush                               |Type           |             |             |
|Stretch                                 |MemberAccess   |             |             |
 
### System.Windows.Media.TransformGroup
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/TileBrush.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TransformGroup                          |Type           |             |             |
|Children                                |MemberAccess   |             |             |
 
### System.Windows.Media.TranslateTransform
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/TransformGroup.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TranslateTransform                      |Type           |             |             |
|X                                       |MemberAccess   |             |             |
|Y                                       |MemberAccess   |             |             |
 
### System.Windows.Media.VisualTreeHelper
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/TranslateTransform.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|VisualTreeHelper                        |Type           |             |             |
|FindElementsInHostCoordinates           |Call           |             |             |
|GetChild                                |Call           |             |             |
|GetChildrenCount                        |Call           |             |             |
|GetParent                               |Call           |             |             |
 
### System.Windows.MessageBox
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Media/VisualTreeHelper.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Show                                    |Call           |             |             |
 
### System.Windows.MessageBoxResult
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/MessageBox.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|MessageBoxResult                        |Type           |             |             |
|OK                                      |MemberAccess   |             |             |
|Cancel                                  |MemberAccess   |             |             |
 
### System.Windows.Navigation.LoadCompletedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/MessageBoxResult.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|LoadCompletedEventHandler               |Type           |             |             |
 
### System.Windows.Navigation.NavigatedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Navigation/LoadCompletedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NavigatedEventHandler                   |Type           |             |             |
 
### System.Windows.Navigation.NavigatingCancelEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Navigation/NavigatedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NavigatingCancelEventArgs               |Type           |             |             |
|Uri                                     |MemberAccess   |Conditionally|             |
|NavigationMode                          |MemberAccess   |             |             |
 
### System.Windows.Navigation.NavigatingCancelEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Navigation/NavigatingCancelEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NavigatingCancelEventHandler            |Type           |             |             |
 
### System.Windows.Navigation.NavigationContext
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Navigation/NavigatingCancelEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|QueryString                             |MemberAccess   |             |Always       |
 
### System.Windows.Navigation.NavigationEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Navigation/NavigationContext.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NavigationEventArgs                     |Type           |             |             |
|NavigationMode                          |MemberAccess   |             |             |
|Content                                 |MemberAccess   |             |             |
|Uri                                     |MemberAccess   |             |             |
 
### System.Windows.Navigation.NavigationFailedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Navigation/NavigationEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NavigationFailedEventHandler            |Type           |             |             |
 
### System.Windows.Navigation.NavigationService
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Navigation/NavigationFailedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|NavigationService                       |Type           |             |             |
|GoBack                                  |Call           |             |             |
|BackStack                               |MemberAccess   |             |             |
|CanGoBack                               |MemberAccess   |             |             |
|Navigated                               |MemberAccess   |             |             |
|BackStack                               |MemberAccess   |             |Always       |
|RemoveBackEntry                         |Call           |             |             |
 
### System.Windows.Navigation.UriMapperBase
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Navigation/NavigationService.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|UriMapperBase                           |Type           |Always       |             |
 
### System.Windows.Point
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Navigation/UriMapperBase.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Point                                   |Type           |             |             |
|X                                       |MemberAccess   |             |             |
|Y                                       |MemberAccess   |             |             |
 
### System.Windows.PropertyChangedCallback
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/Point.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PropertyChangedCallback                 |Type           |             |             |
 
### System.Windows.PropertyMetadata
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/PropertyChangedCallback.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PropertyMetadata                        |Type           |             |             |
 
### System.Windows.PropertyPath
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/PropertyMetadata.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|PropertyPath                            |Type           |             |             |
 
### System.Windows.Rect
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/PropertyPath.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Rect                                    |Type           |             |             |
|Bottom                                  |MemberAccess   |             |             |
|Top                                     |MemberAccess   |             |             |
|Height                                  |MemberAccess   |             |             |
|Width                                   |MemberAccess   |             |             |
|X                                       |MemberAccess   |             |             |
|Y                                       |MemberAccess   |             |             |
|Contains                                |Call           |             |             |
 
### System.Windows.ResourceDictionary
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/Rect.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ResourceDictionary                      |Type           |             |             |
|Contains                                |Call           |             |             |
 
### System.Windows.Resources.StreamResourceInfo
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/ResourceDictionary.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|StreamResourceInfo                      |Type           |             |             |
|Stream                                  |MemberAccess   |             |             |
 
### System.Windows.RoutedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Resources/StreamResourceInfo.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|RoutedEventArgs                         |Type           |             |             |
|OriginalSource                          |MemberAccess   |             |             |
 
### System.Windows.RoutedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/RoutedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|RoutedEventHandler                      |Type           |             |             |
|Invoke                                  |Call           |             |             |
 
### System.Windows.Shapes.Ellipse
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/RoutedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Ellipse                                 |Type           |             |             |
 
### System.Windows.Shapes.Path
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Shapes/Ellipse.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Path                                    |Type           |             |             |
 
### System.Windows.Shapes.Polygon
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Shapes/Path.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Polygon                                 |Type           |             |             |
 
### System.Windows.Shapes.Rectangle
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Shapes/Polygon.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Rectangle                               |Type           |             |             |
 
### System.Windows.Shapes.Shape
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Shapes/Rectangle.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Shape                                   |Type           |             |             |
|Fill                                    |MemberAccess   |             |             |
|Stroke                                  |MemberAccess   |             |             |
|StrokeThickness                         |MemberAccess   |             |             |
|FillProperty                            |MemberAccess   |             |             |
 
### System.Windows.Size
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Shapes/Shape.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Size                                    |Type           |             |             |
|Height                                  |MemberAccess   |             |             |
|Width                                   |MemberAccess   |             |             |
 
### System.Windows.SizeChangedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/Size.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SizeChangedEventArgs                    |Type           |             |             |
|NewSize                                 |MemberAccess   |             |             |
 
### System.Windows.SizeChangedEventHandler
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/SizeChangedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SizeChangedEventHandler                 |Type           |             |             |
|NewSize                                 |MemberAccess   |             |             |
 
### System.Windows.TemplatePartAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/SizeChangedEventHandler.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TemplatePartAttribute                   |Type           |             |             |
 
### System.Windows.TemplateVisualStateAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/TemplatePartAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TemplateVisualStateAttribute            |Type           |             |             |
 
### System.Windows.TextWrapping
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/TemplateVisualStateAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|TextWrapping                            |Type           |             |             |
 
### System.Windows.Thickness
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/TextWrapping.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Thickness                               |Type           |             |             |
|Bottom                                  |MemberAccess   |             |             |
|Top                                     |MemberAccess   |             |             |
|Right                                   |MemberAccess   |             |             |
|Left                                    |MemberAccess   |             |             |
 
### System.Windows.Threading.Dispatcher
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/Thickness.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Dispatcher                              |Type           |             |             |
|BeginInvoke                             |Call           |             |             |
|CheckAccess                             |Call           |             |             |
 
### System.Windows.Threading.DispatcherTimer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Threading/Dispatcher.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|DispatcherTimer                         |Type           |             |             |
|Tick                                    |MemberAccess   |             |             |
|IsEnabled                               |MemberAccess   |             |             |
|Interval                                |MemberAccess   |             |             |
|Start                                   |Call           |             |             |
|Stop                                    |Call           |             |             |
 
### System.Windows.UIElement
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows.Threading/DispatcherTimer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|UIElement                               |Type           |             |             |
|MouseMove                               |MemberAccess   |             |             |
|MouseLeftButtonDown                     |MemberAccess   |             |             |
|MouseLeftButtonUp                       |MemberAccess   |             |             |
|MouseEnter                              |MemberAccess   |             |             |
|MouseLeave                              |MemberAccess   |             |             |
|LostMouseCapture                        |MemberAccess   |             |             |
|Tap                                     |MemberAccess   |             |             |
|KeyDown                                 |MemberAccess   |             |             |
|KeyUp                                   |MemberAccess   |             |             |
|ManipulationCompleted                   |MemberAccess   |             |             |
|ManipulationStarted                     |MemberAccess   |             |             |
|ManipulationDelta                       |MemberAccess   |             |             |
|IsHitTestVisible                        |MemberAccess   |             |             |
|DesiredSize                             |MemberAccess   |             |             |
|Clip                                    |MemberAccess   |             |Always       |
|Opacity                                 |MemberAccess   |             |             |
|Projection                              |MemberAccess   |             |             |
|RenderTransform                         |MemberAccess   |             |             |
|CacheMode                               |MemberAccess   |             |             |
|AddHandler                              |MemberAccess   |             |             |
|UseLayoutRounding                       |MemberAccess   |             |             |
|RenderTransformOrigin                   |MemberAccess   |             |             |
|Visibility                              |MemberAccess   |             |             |
|RenderSize                              |MemberAccess   |             |             |
|OpacityProperty                         |MemberAccess   |             |             |
|GotFocus                                |MemberAccess   |             |             |
|LostFocus                               |MemberAccess   |             |             |
|Measure                                 |Call           |             |             |
|Arrange                                 |Call           |             |             |
|TransformToVisual                       |Call           |             |             |
|InvalidateMeasure                       |Call           |             |             |
|InvalidateArrange                       |Call           |             |             |
|UpdateLayout                            |Call           |             |             |
|CaptureMouse                            |Call           |             |Always       |
|ReleaseMouseCapture                     |Call           |             |Always       |
|KeyDownEvent                            |MemberAccess   |             |             |
|ManipulationCompletedEvent              |MemberAccess   |             |             |
|ManipulationStartedEvent                |MemberAccess   |             |             |
|ManipulationDeltaEvent                  |MemberAccess   |             |             |
|Hold                                    |MemberAccess   |             |             |
|DoubleTap                               |MemberAccess   |             |             |
|MouseWheel                              |MemberAccess   |             |             |
 
### System.Windows.VerticalAlignment
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/UIElement.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|VerticalAlignment                       |Type           |             |             |
 
### System.Windows.Visibility
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/VerticalAlignment.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Visibility                              |Type           |             |             |
 
### System.Windows.VisualState
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/VisibilityMapper.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|VisualState                             |Type           |             |             |
|Name                                    |MemberAccess   |             |             |
|Storyboard                              |MemberAccess   |             |             |
 
### System.Windows.VisualStateChangedEventArgs
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/VisualState.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|VisualStateChangedEventArgs             |Type           |             |             |
|NewState                                |MemberAccess   |             |             |
 
### System.Windows.VisualStateGroup
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/VisualStateChangedEventArgs.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|VisualStateGroup                        |Type           |             |             |
|Name                                    |MemberAccess   |             |             |
|States                                  |MemberAccess   |             |             |
 
### System.Windows.VisualStateManager
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/VisualStateGroup.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|VisualStateManager                      |Type           |             |             |
|GetVisualStateGroups                    |Call           |             |             |
|GoToState                               |Call           |             |             |
 
### System.Xml.Linq.XAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Windows/VisualStateManager.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XCData
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XComment
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XCData.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XContainer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XComment.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XDeclaration
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XContainer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XDocument
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XDeclaration.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XElement
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XDocument.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XName
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XElement.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XNamespace
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XName.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XNode
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XNamespace.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XObject
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XNode.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XProcessingInstruction
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XObject.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Linq.XText
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XProcessingInstruction.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.NameTable
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Linq/XText.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.Serialization.XmlSerializer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml/NameTable.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.XmlConvert
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml.Serialization/XmlSerializer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.XmlNamespaceManager
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml/XmlConvert.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.XmlReader
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml/XmlNamespaceManager.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.XmlReaderSettings
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml/XmlReader.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|XmlResolver                             |MemberAccess   |             |Always       |
 
### System.Xml.XmlWriter
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml/XmlReaderSettings.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### System.Xml.XmlXapResolver
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml/XmlWriter.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### Windows.ApplicationModel.Package
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//System.Xml/XmlXapResolver.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Current                                 |MemberAccess   |             |             |
 
### Windows.ApplicationModel.Store.CurrentApp
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.ApplicationModel/Package.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AppId                                   |MemberAccess   |             |             |
|GetAppReceiptAsync                      |Call           |             |             |
 
### Windows.Devices.Geolocation.Geocoordinate
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.ApplicationModel.Store/CurrentApp.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|Longitude                               |MemberAccess   |             |             |
|Latitude                                |MemberAccess   |             |             |
 
### Windows.Devices.Geolocation.GeocoordinateExtensions
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Devices.Geolocation/Geocoordinate.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|ToGeoCoordinate                         |Call           |             |             |
 
### Windows.Foundation.Metadata.DefaultAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Devices.Geolocation/GeocoordinateExtensions.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### Windows.Foundation.Metadata.DefaultOverloadAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Foundation.Metadata/DefaultAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### Windows.Foundation.Metadata.ExclusiveToAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Foundation.Metadata/DefaultOverloadAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### Windows.Foundation.Metadata.GuidAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Foundation.Metadata/ExclusiveToAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### Windows.Foundation.Metadata.MarshalingBehaviorAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Foundation.Metadata/GuidAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### Windows.Foundation.Metadata.ThreadingAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Foundation.Metadata/MarshalingBehaviorAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### Windows.Foundation.Metadata.VersionAttribute
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Foundation.Metadata/ThreadingAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
 
### Windows.Phone.Controls.TransitionFrame
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Foundation.Metadata/VersionAttribute.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|OrientationChanged                      |MemberAccess   |             |             |
 
### Windows.Phone.Speech.Recognition.SpeechGrammarSet
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.UI.Xaml.Controls/Frame.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|AddGrammarFromList                      |Call           |             |             |
|AddGrammarFromPredefinedType            |Call           |             |             |
 
### Windows.Phone.Speech.Recognition.SpeechRecognitionConfidence
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Recognition/SpeechGrammarSet.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SpeechRecognitionConfidence             |Type           |             |             |
 
### Windows.Phone.Speech.Recognition.SpeechRecognitionResult
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Recognition/SpeechRecognitionConfidence.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SpeechRecognitionResult                 |Type           |             |             |
|TextConfidence                          |MemberAccess   |             |             |
 
### Windows.Phone.Speech.Recognition.SpeechRecognitionUIResult
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Recognition/SpeechRecognitionResult.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SpeechRecognitionUIResult               |Type           |             |             |
|ResultStatus                            |MemberAccess   |             |             |
|RecognitionResult                       |MemberAccess   |             |             |
 
### Windows.Phone.Speech.Recognition.SpeechRecognitionUIStatus
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Recognition/SpeechRecognitionUIResult.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SpeechRecognitionUIStatus               |Type           |             |             |
|Succeeded                               |MemberAccess   |             |             |
|Preempted                               |MemberAccess   |             |             |
|Busy                                    |MemberAccess   |             |             |
|PrivacyPolicyDeclined                   |MemberAccess   |             |             |
 
### Windows.Phone.Speech.Recognition.SpeechRecognizer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Recognition/SpeechRecognitionResultStatus.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SpeechRecognizer                        |Type           |             |             |
|Settings                                |MemberAccess   |             |             |
|RecognizeAsync                          |Call           |             |             |
 
### Windows.Phone.Speech.Recognition.SpeechRecognizerSettings
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Recognition/SpeechRecognizer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SpeechRecognizerSettings                |Type           |             |             |
|EndSilenceTimeout                       |MemberAccess   |             |Conditionally|
 
### Windows.Phone.Speech.Recognition.SpeechRecognizerUI
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Recognition/SpeechRecognizerSettings.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SpeechRecognizerUI                      |Type           |             |             |
|Recognizer                              |MemberAccess   |             |Conditionally|
|Settings                                |MemberAccess   |             |             |
 
### Windows.Phone.Speech.Recognition.SpeechRecognizerUISettings
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Recognition/SpeechRecognizerUI.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SpeechRecognizerUISettings              |Type           |             |             |
|ListenText                              |MemberAccess   |             |             |
|ReadoutEnabled                          |MemberAccess   |             |             |
 
### Windows.Phone.Speech.Synthesis.InstalledVoices
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Recognition/SpeechRecognizerUISettings.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|All                                     |MemberAccess   |             |             |
|Default                                 |MemberAccess   |             |             |
 
### Windows.Phone.Speech.Synthesis.SpeechSynthesizer
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Synthesis/InstalledVoices.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SpeechSynthesizer                       |Type           |             |             |
|BookmarkReached                         |MemberAccess   |             |Always       |
|SpeechStarted                           |MemberAccess   |             |Always       |
|CancelAll                               |MemberAccess   |             |Always       |
|SpeakSsmlAsync                          |MemberAccess   |             |Always       |
|SpeakSsmlFromUriAsync                   |MemberAccess   |             |Always       |
|Close                                   |MemberAccess   |             |             |
|SpeakTextAsync                          |Call           |             |             |
|SetVoice                                |Call           |             |Conditionally|
|GetVoice                                |Call           |             |Conditionally|
 
### Windows.Phone.Speech.Synthesis.VoiceGender
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Synthesis/SpeechSynthesizer.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|VoiceGender                             |Type           |             |             |
|Male                                    |MemberAccess   |             |             |
|Female                                  |MemberAccess   |             |             |
 
### Windows.Phone.Speech.Synthesis.VoiceInformation
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Synthesis/VoiceGender.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|VoiceInformation                        |Type           |             |             |
 
### Windows.Phone.Speech.VoiceCommands.VoiceCommandService
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.Synthesis/VoiceInformation.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|VoiceCommandService                     |Type           |             |             |
|InstalledCommandSets                    |MemberAccess   |             |             |
|InstallCommandSetsFromFileAsync         |Call           |             |             |
 
### Windows.Phone.Speech.VoiceCommands.VoiceCommandSet
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.VoiceCommands/VoiceCommandService.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|VoiceCommandSet                         |Type           |             |             |
|UpdatePhraseListAsync                   |Call           |             |             |
 
### Windows.Phone.Storage.SharedAccess.SharedStorageAccessManager
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Speech.VoiceCommands/VoiceCommandSet.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|SharedStorageAccessManager              |Type           |             |             |
|GetSharedFileName                       |Call           |             |             |
|CopySharedFileAsync                     |Call           |             |             |
 
### Windows.System.Launcher
 
[Mapping file](https://github.com/MobilizeNet/UWPConversionMappings/blob/master/Mappings/CodeMappings//Windows.Phone.Storage.SharedAccess/SharedStorageAccessManager.map)
 
|Member Name                             |Kind           |Helper       |Not mapped   |
|----------------------------------------|---------------|-------------|-------------|
|LaunchUriAsync                          |Call           |             |             |
