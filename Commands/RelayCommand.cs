using System.Windows.Input;

namespace StudioSessionOrderForm.Commands;

public class RelayCommand : ICommand
{
    // Event and its rising method

    public event EventHandler? CanExecuteChanged;

    public void RaiseCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    // Class fields

    private readonly Action _execute;
    private readonly Func<bool>? _canExecute;

    // Class constructor
    public RelayCommand(Action execute, Func<bool>? canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    // Class methods

    public void Execute(object? parameter)
    {
        _execute();
    }

    public bool CanExecute(object? parameter)
    {
        return _canExecute?.Invoke() ?? true;
    }
}