using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    internal class Program
    {
        public class Global
        {
            //public static List<Article> list = new List<Article>(); 
            public static int numArticle = 0;
            public static List<Article> listdeux = new List<Article>();
        }

        
        


        public static void Main(string[] args)
        {
            List<Article> list = new List<Article>();

            bool loopMenu = true;
            while (loopMenu)
            {
                Console.WriteLine("Choisir une page");
                Console.WriteLine("1:Ajout Article");
                Console.WriteLine("2:Rechercher un article par nom");
                Console.WriteLine("3:Afficher tous les articles");
                Console.WriteLine("4:Modifier un article via la réference");
                Console.WriteLine("5:Rechercher un article intervale prix");
                Console.WriteLine("6: Exit");
                int vChoix = Convert.ToInt32(Console.ReadLine());
                switch (vChoix)
                {
                    case 1:
                        Console.WriteLine("1:Ajout Article");                       
                        createArticle(list);
                        loopMenu = true;
                        break;
                    case 2:
                        Console.WriteLine("2:Rechercher un article par nom");
                        searchArticleByName(list);
                        loopMenu = true;
                        break;
                    case 3:
                        Console.WriteLine("3:Afficher tous les articles");
                        afficheList(list);
                        loopMenu = true;
                        break;
                    case 4:
                        Console.WriteLine("Vous avez choisis l'option 4");
                        SearchArticleByNum(list);
                        break;
                    case 5:
                        Console.WriteLine("Vous avez choisis l'option 5");
                        Console.WriteLine("Choisir une valeur");
                        int testmin = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Choisir une deuxieme valeur");
                        int testmax = Convert.ToInt32(Console.ReadLine());
                        List<Article> l2 = SearchArticleByIntervalPrice(list, testmin, testmax);
                        afficheList(l2);
                        loopMenu = true;
                        break;
                    case 6:
                        Console.WriteLine("Good bye");
                        loopMenu = false;
                        break;
                    default:
                        loopMenu = true;
                        break;
                }
            }           
   
        }

        public static void afficheList(List<Article> list)
        {
            foreach(var article in list)
            {
                Console.WriteLine(article.ToString());
                Console.WriteLine("--------------------");
            }
        }
        public static List<Article> SearchArticleByIntervalPrice(List<Article> list, int min, int max)
        {
            int tmp = 0;
            List<Article> listResult = new List<Article>();
            foreach (var article in list)
            {
                if(min < article.prixArticle && max > article.prixArticle)
                {
                    tmp = 1;
                    listResult.Add(article);
                }                
            }
            if(tmp == 0)
            {
                Console.WriteLine("Auncun article trouvé dans cette tranche");
            }
            return listResult;
        }

        public static void SearchArticleByNum(List<Article> list)
        {
            int numRef = 0;
            int tmp = 0;
            bool loopUpdate = true;
            while (numRef == 0)
            {
                Console.WriteLine("Entrer le numero de reference de votre article: ");
                numRef = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var article in list)
            {
                if (article.numReference == numRef)
                {
                    tmp = 1;
                    Console.WriteLine("--------" + article.numReference + "------");
                    Console.WriteLine(article.ToString());
                    Console.WriteLine("--------------------------------------");
                    while(loopUpdate)
                    {
                        Console.WriteLine("Modification");
                        Console.WriteLine("1:NomArticle");
                        Console.WriteLine("2:PrixArticle");
                        Console.WriteLine("3:StockArticle");
                        Console.WriteLine("4:Fin de la modification");
                        int vChoix = Convert.ToInt32(Console.ReadLine());
                        switch(vChoix)
                        {
                            case 1:
                                Console.WriteLine("Veuillez saisir un nom");
                                string articleNom = Console.ReadLine();
                                article.SetNom(articleNom);
                                loopUpdate = true;
                                Console.WriteLine(article.ToString());
                                break;
                            case 2:
                                Console.WriteLine("Veuillez saisir le prix");
                                double articlePrix = Convert.ToDouble(Console.ReadLine());
                                article.SetPrix(articlePrix);
                                loopUpdate = true;
                                Console.WriteLine(article.ToString());
                                break;
                            case 3:
                                Console.WriteLine("Veuillez saisir le nombre de stock");
                                int articleStock = Convert.ToInt32(Console.ReadLine());
                                article.SetStock(articleStock);
                                Console.WriteLine(article.ToString());

                                loopUpdate = true;
                                break;
                            case 4:
                                Console.WriteLine(article.ToString());
                                Console.WriteLine("Fin modification...");
                                Console.WriteLine();                                
                                loopUpdate = false;
                                break;
                            default:
                                loopUpdate = true;
                                break;

                        }
                    }
                }
            }
            if (tmp == 0)
            {
                Console.WriteLine("Votre article n'existe pas ");
            }
        }
        public static void searchArticleByName(List<Article> list)
        {
            int tmp = 0;
            Console.WriteLine("Vous avez choisi l'option rechercher l'article");
            Console.WriteLine("Entrer le nom de l'article: ");
            string nameArticleUser = Console.ReadLine();
            foreach(var article in list)
            {
                if(article.nomArticle == nameArticleUser)
                { 
                    tmp = 1;
                    Console.WriteLine("--------"+article.nomArticle+"------");
                    Console.WriteLine(article.ToString());
                    Console.WriteLine("--------------------------------------");
                }
                
            }
            if(tmp == 0)
            {
                Console.WriteLine("Votre article n'existe pas ");
            }
            
        }

        public static void createArticle(List<Article> list)
        {
            int endBoucle = 0;
            

            while (endBoucle < 1)
            {
                endBoucle++;
                

                Console.WriteLine(endBoucle);
                for (int i = 0; i < 1; i++)
                {
                    Global.numArticle++;
                    Console.WriteLine("NomArticle");
                    string nomArticle = Console.ReadLine();
                    Console.WriteLine("PrixArticle");
                    double prixArticle = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("StockArticle");
                    int stockArticle = Convert.ToInt32(Console.ReadLine());
                    Article endboucle = new Article(Global.numArticle, nomArticle, prixArticle, stockArticle);
                    list.Add(endboucle);
                    Console.WriteLine();                  

                }
                
                foreach (var article in list)
                {
                    
                    Console.WriteLine(article.ToString());
                    Console.WriteLine("----------");
                }


            }
        }
    }
}
