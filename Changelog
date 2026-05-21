# Changelog

All notable changes to this project will be documented in this file.

This project uses version numbers as educational milestones: each version introduces one clear practical WPF/C# concept.

## [0.3.0] - Add WPF commands and async command support

### Added

- Added WPF command support for UI actions.
- Added `RelayCommand` for synchronous commands.
- Added `AsyncRelayCommand` for asynchronous `Task`-based commands.
- Added `SaveOrderCommand` for the save workflow.
- Added `ResetOrderCommand` for the reset workflow.
- Added `CanExecute` logic for resetting form data.
- Added command state updates through `RaiseCanExecuteChanged`.

### Changed

- Replaced button `Click` event handlers with WPF command bindings.
- Moved button action logic from the window layer to the ViewModel layer.
- Disabled repeated save execution while the async save operation is running.
- Reduced `MainWindow.xaml.cs` responsibility to window initialization and ViewModel binding.
- Preserved existing form behavior from the previous MVVM version.

### Learning Focus

- `ICommand`
- Command binding in XAML
- `RelayCommand`
- `AsyncRelayCommand`
- `CanExecute`
- `RaiseCanExecuteChanged`
- Async command execution in WPF

## [0.2.0] - Basic MVVM refactor

### Added

- Added `MainWindowViewModel`.
- Added ViewModel-based form state management.
- Added ViewModel-based validation logic.
- Added ViewModel-based price calculation logic.
- Added ViewModel-based save and reset workflows.

### Changed

- Moved form state from `MainWindow.xaml.cs` to `MainWindowViewModel`.
- Moved validation logic from code-behind to the ViewModel.
- Moved total price calculation from code-behind to the ViewModel.
- Reduced `MainWindow.xaml.cs` to a thin code-behind layer.
- Preserved the existing UI and user-facing behavior.

### Learning Focus

- Basic MVVM structure
- `DataContext`
- ViewModel as screen state holder
- `INotifyPropertyChanged`
- Moving logic out of code-behind

## [0.1.0] - Initial working version

### Added

- Added initial working WPF order form.
- Added customer selection.
- Added session type selection.
- Added session duration selection.
- Added price-per-hour handling.
- Added manual discount input.
- Added urgent surcharge option.
- Added total cost calculation.
- Added validation warning borders.
- Added basic save feedback behavior.

### Learning Focus

- Basic WPF window layout
- XAML bindings
- ComboBox selection
- TextBox input
- CheckBox state
- Basic validation flags
- Simple UI feedback
