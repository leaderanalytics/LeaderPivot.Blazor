namespace LeaderPivot.Blazor.Tests;

public class TestVintage
{
    private string _vintageDateString;
    private string _obsDateString;

    public string VintageDateString => _vintageDateString;


    public string ObsDateString => _obsDateString;


    private DateTime _VintageDate;
    public DateTime VintageDate
    {
        get => _VintageDate;
        set
        {
            _VintageDate = value;
            _vintageDateString = _VintageDate.ToString(Constants.DateFormat);
        }
    }

    private DateTime _ObsDate;
    public DateTime ObsDate
    {
        get => _ObsDate;
        set
        {
            _ObsDate = value;
            _obsDateString = _ObsDate.ToString(Constants.DateFormat);
        }
    }

    public decimal Value { get; set; }  // Changing Value from string to decimal had zero performance impact.
}
