using Library;

public class Book: ILoanable, IPrintable
{
    private string _author;
    private string _title;
    private string _ISBN;
    private int _loanPeriod;
    private string _borrower;
    public string Author 
    {
        get {return _author;}
        set {_author = value;}
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
                Console.WriteLine("Invalid title");
            }
        }
    }

    public string ISBN 
    {
        get {return _ISBN;}
        set
        {
            if(value.Length >= 10 && value.Length <= 13)
            {
                _ISBN = value;
            }
            else
            {
                Console.WriteLine("Invalid ISBN");
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

    public string Borrow(int loanPeriod)
    {
        if(loanPeriod >= 21)
        {
            LoanPeriod = loanPeriod;
            Borrower = "Library";
            return $"This book is loaned for {this.LoanPeriod} days by {Borrower}";
        }
        else
        {
            return "Impossible to loaned this book, it should be loanable for a minimum of 21 days";

        }
    }

    public string Print()
    {
       return $"{this.Title} by {this.Author}";
    }

    public string Return()
    {
        return $"The loan period of {this.LoanPeriod} days is over, please return the book";
    }
}