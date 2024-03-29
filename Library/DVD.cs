using Library;

public class DVD: ILoanable, IPrintable
{
    private string _director;
    private string _title;
    private int _lenghtInMinutes;
    private int _loanPeriod;
    private string _borrower;

    public string Director 
    {
        get {return _director;}
        set { _director = value;}
    }

    public string Title
    {
        get {return _title;}
        set
        {
            if(value.Length > 2)
            {
                _title = value;
            }
            else
            {
                Console.WriteLine("This title doesn't exist");
            }
        }
    }

    public int LenghtInMinutes
    {
        get {return _lenghtInMinutes;}
        set
        {
            if(value > 0)
            {
                _lenghtInMinutes = value;
            }
            else
            {
                Console.WriteLine("This lenght is too short");
            }
        }
    }

    public int LoanPeriod
    {
        get {return _loanPeriod;}
        set
        {
            if(value > 2)
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
        get {return _borrower;}
        set {_borrower = value;}
    }

    public DVD(string director, string title, int lenghtInMinutes)
    {
        this.Director = director;
        this.Title = title;
        this.LenghtInMinutes = lenghtInMinutes;
    }

    public string Borrow(int loanPeriod)
    {
        if(loanPeriod >= 7)
        {
            LoanPeriod = loanPeriod;
            Borrower = "Library";
            return $"This DVD is loaned for {this.LoanPeriod} days by {Borrower}";
        }
        else
        {
            return "Impossible to loaned this book, it should be loanable for a minimum of 7 days";

        }
    }

    public string Print()
    {
        return $"{this.Title} by {this.Director}";
    }

    public string Return()
    {
          return $"The loan period of {this.LoanPeriod} days is over, please return the DVD";
    }
}