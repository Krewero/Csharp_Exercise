using Article;
using System;

class Program
{
    static void Main(string[] args)
    {
        NewsArticleCollection articles = new NewsArticleCollection();

        articles.RegisterArticleFilteredHandler(category =>
        {
            Console.WriteLine($"Articles filtered by category: {category}");
        });
        articles.RegisterArticleAddedHandler(article =>
        {
            Console.WriteLine($"Article added: {article.Title} ({article.Category})");
        });
        articles.RegisterArticleRemovedHandler(article =>
        {
            Console.WriteLine($"Article removed: {article.Title} ({article.Category})");
        });

        NewsArticle article1 = new NewsArticle("Ronaldo score", "Sport");
        NewsArticle article2 = new NewsArticle("Kyle Jenner new brand", "Business");
        NewsArticle article3 = new NewsArticle("Messi is the GOAT", "Sport");

        articles.AddArticle(article1);
        articles.AddArticle(article3);

    }
}
