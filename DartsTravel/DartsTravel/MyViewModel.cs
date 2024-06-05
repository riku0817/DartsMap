using System.ComponentModel;

public class MyViewModel : INotifyPropertyChanged
{
    private string _myVariable;
    public string MyVariable
    {
        get { return _myVariable; }
        set
        {
            if (_myVariable != value)
            {
                _myVariable = value;
                OnPropertyChanged(nameof(MyVariable));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}