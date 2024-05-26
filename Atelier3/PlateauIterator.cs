using BanqueApp3;

public class PlateauIterator : IIterator
{
    private Plateau _plateau;
    private int _currentIndex;

    public PlateauIterator(Plateau plateau)
    {
        _plateau = plateau;
        _currentIndex = -1;
    }

    public bool MoveNext()
    {
        if (_currentIndex + 1 < _plateau.NbCases())
        {
            _currentIndex++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        _currentIndex = -1;
    }

    public Case Current
    {
        get
        {
            if (_currentIndex < 0 || _currentIndex >= _plateau.NbCases())
            {
                throw new InvalidOperationException();
            }
            return _plateau.GetCase(_currentIndex);
        }
    }
}
