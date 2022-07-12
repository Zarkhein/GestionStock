using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock
{
    internal class Article
    {
        public int numReference;
        public string nomArticle;
        public double prixArticle;
        public int stockArticle;

        public Article()
        {
            numReference = 0;
            nomArticle = "null";
            prixArticle = 0;
            stockArticle = 0;            
        }

        public Article(int numReference, string nomArticle, double prixArticle, int stockArticle)
        {
            this.numReference = numReference;
            this.nomArticle = nomArticle;
            this.prixArticle = prixArticle;
            this.stockArticle = stockArticle;
        }

        public void SetNum(int numReference)
        {
            this.numReference = numReference;   
        }
        public int GetNum()
        {
            return numReference;
        }

        public void SetNom(string nomArticle)
        {
            this.nomArticle = nomArticle;
        }

        public string getNom()
        {
            return nomArticle;
        }

        public void SetPrix(double prixArticle)
        {
            this.prixArticle = prixArticle; 
        }

        public double GetPrix()
        {
            return prixArticle;
        }

        public void SetStock(int stockArticle)
        {
            this.stockArticle = stockArticle;
        }

        public int GetStock()
        {
            return stockArticle;    
        }

        public new string ToString()
        {
            return "Num Produit:" + numReference + "\n" + 
                   "Nom Article:" + nomArticle + "\n" + 
                   "Prix Article:" + prixArticle + "\n" + 
                   "Stock Article:" + stockArticle;
        }
    }
}
