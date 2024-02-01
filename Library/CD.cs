using Library;

public class CD : ILoanable, IPrintable
{
    private string _artist;
    private string _title;
    private int _numberOfTracks;
    private int _loanPeriod;
    private string _borrower;

    public string Artist
    {
        get { return _artist; }
        set { _artist = value; }
    }

    public string Title
    {
        get { return _title; }
        set
        {
            if (value.Length > 2)
            {
                _title = value;
            }
            else
            {
                Console.WriteLine("This title doesn't exist");
            }
        }
    }

    public int NumberOfTracks
    {
        get { return _numberOfTracks; }
        set
        {
            if (value != 0)
            {
                _numberOfTracks = value;
            }
            else
            {
                Console.WriteLine("Not enough tracks");
            }
        }
    }

    public int LoanPeriod
    {
        get { return _loanPeriod; }
        set
        {
            if (value > 2)
            {
                _loanPeriod = value;
            }
            else
            {
                Console.WriteLine("The loan period is too short");
            }
        }
    }

    public string Borrower
    {
        get { return _borrower; }
        set { _borrower = value; }
    }

    public string Borrow(int loanPeriod)
    {
        if (loanPeriod >= 14)
        {
            LoanPeriod = loanPeriod;
            Borrower = "Library";
            return $"This CD is loaned for {this.LoanPeriod} days by {Borrower}";
        }
        else
        {
            return "Impossible to loaned this book, it should be loanable for a minimum of 14 days";

        }
    }

    public string Print()
    {
        return $"{this.Title} by {this.Artist}";
    }

    public string Return()
    {
        return $"The loan period of {this.LoanPeriod} days is over, please return the CD";
    }
}