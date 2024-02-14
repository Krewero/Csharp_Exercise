using Article;
using System.Linq;

class NewsArticleCollection
{
    private List<NewsArticle> _articles = new List<NewsArticle>();

    public event Action<NewsArticle> articleAddedHandler;
    public event Action<NewsArticle> articleRemovedHandler;
    public event Action<string> articleFilteredHandler;

    public List<NewsArticle> Articles 
    {
        get {return _articles;}
        set {_articles = value;}
    }

    public void AddArticle(NewsArticle art)
    {
        Articles.Add(art);
        articleAddedHandler.Invoke(art);
    }

    public void RemoveArticle(NewsArticle art)
    {
        Articles.Remove(art);
        articleRemovedHandler.Invoke(art);
    }

    public List<NewsArticle> FilterArticlesByCategory(string category)
    {
        List<NewsArticle> filteredArticles = new List<NewsArticle>();
        foreach(NewsArticle article in Articles)
        {
            if(article.Category == category)
            {
                filteredArticles.Add(article);
            }
        }
        articleFilteredHandler.Invoke(category);
        return filteredArticles;
    }

    public void RegisterArticleAddedHandler(Action<NewsArticle> handler)
    {
        articleAddedHandler += handler;
    }

    public void RegisterArticleRemovedHandler(Action<NewsArticle> handler)
    {
        articleRemovedHandler += handler;
    }

    public void RegisterArticleFilteredHandler(Action<string> handler)
    {
        articleFilteredHandler += handler;
    }
}