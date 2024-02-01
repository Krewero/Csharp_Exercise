namespace Library
{
    interface ILoanable
    {
        int LoanPeriod{get;set;}
        string Borrower{get;set;}

        string Borrow(int loanperiod);
        string Return();
    }
}