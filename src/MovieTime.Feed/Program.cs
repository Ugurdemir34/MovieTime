using HtmlAgilityPack;
using Microsoft.Extensions.DependencyInjection;
using MovieTime.Business.Abstract;
using MovieTime.Business.Concrete;
using MovieTime.DataAccess.Abstract;
using MovieTime.DataAccess.Concrete.EntityFramework;
using MovieTime.Entities.Concrete;
using System;
using System.Net;
using System.Threading.Tasks;

namespace MovieTime.Feed
{
    class Program
    {
        static string URL = "https://www.fullhdfilmizlesene.com/film";
        static Uri address = new Uri(URL);
        static void Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                                           .AddTransient<IMovieService, MovieManager>()
                                           .AddTransient<IMovieDal,EfMovieDal>().BuildServiceProvider();
            IMovieService _movieService = serviceProvider.GetService<IMovieService>();
            WebClient wc = new WebClient();
            WebClient tempwc = new WebClient();
            HtmlDocument doc = new HtmlDocument();
            HtmlDocument tempdoc = new HtmlDocument();
            var specialword = "<span class=\"Apple-converted-space\"> </span>";
            var specialword2 = "<span class=\"Apple-converted-space\">  </span>";
            wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
            tempwc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
            var data =  wc.DownloadString(URL);
            var Movie = new Movie();
            doc.LoadHtml(data);
            var searching = doc.DocumentNode.SelectNodes("//a[@class='title']") ;
            var searching2 = doc.DocumentNode.SelectNodes("//a[@class='title hd']");
            foreach (var item in searching)
            {
                var film_adi = item.Attributes["title"].Value.Split("-")[0];
                var newUrlData = tempwc.DownloadString(item.Attributes["href"].Value);
                tempdoc.LoadHtml(newUrlData);
                var moviedetaysection = tempdoc.DocumentNode.SelectSingleNode("//section[@class='detay-sag']");
                var movieSummary = moviedetaysection.SelectSingleNode("//div[1]/article/p");
                var director = moviedetaysection.SelectSingleNode("//div[2]/dl/dd[1]/span/span");
                var actors = moviedetaysection.SelectSingleNode("//div[2]/dl/dd[2]");
                var date = moviedetaysection.SelectSingleNode("div[2]/dl/dd[3]/a");
                var imdb = moviedetaysection.SelectSingleNode("/html/body/div[4]/div/header/div[2]/div[1]/span");

                var film_ozet = movieSummary.InnerHtml.Replace("<br>"," ").Replace("<strong>"," ").Replace("</strong>"," ").Replace(specialword," ").Replace(specialword2," ");
                var yonetmen = director.InnerHtml;
                var oyuncular = actors.InnerHtml;
                var yil = date.InnerHtml.Split(" ")[0];
                var yapimyili = new DateTime(Convert.ToInt16(yil),1,1);
                var imdbpuani = imdb.InnerHtml.Replace(".",",");
                var Film = new Movie
                {
                    Title = film_adi,
                    Description = film_ozet,
                    CreationDate = DateTime.Now,
                    Director = yonetmen,
                    Actors = oyuncular,
                    Date = yapimyili,
                    Imdb = Convert.ToDouble(imdbpuani),
                    Id = Guid.NewGuid(),
                    Thumbnail = "assets/img/theme/" + film_adi+".jpg"
                };
                _movieService.Add(Film);


            }
            Console.WriteLine("Başarıyla Eklendi !");
            Console.ReadKey();

          
        }
       
    }
}
