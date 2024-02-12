namespace Article
{
    class NewsArticle
    {
        private string _title;
        private string _category;

        public string Title 
        {
            get {return _title;}
            set {_title = value;}
        }

        public string Category 
        {
            get {return _category;}
            set
            {
                if(value == "Technology"||value == "Business"||value == "Health"||value =="Sport")
                {
                    _category = value;
                }
                else
                {
                    Console.WriteLine("This category doesn't exist");
                }
            }
        }

        public NewsArticle(string title, string category)
        {
            this.Title = title;
            this.Category = category;
        }
    }
}