using System;
using System.Collections.Generic;
using System.Text;

namespace MetierTrader
{
    public class ActionPerso
    {
        private int numAction;
        private string nomAction;
        private double prixAchat;
        private int quantite;
        private int total;


        public ActionPerso (int unNumAction, string unNomAction, double unPrixAchat, int uneQuantite, int unTotal)
        {
            NumAction = unNumAction;
            NomAction = unNomAction;
            PrixAchat = unPrixAchat;
            Quantite = uneQuantite;
            Total = unTotal;

        }

        public int NumAction { get => numAction; set => numAction = value; }
        public string NomAction { get => nomAction; set => nomAction = value; }
        public double PrixAchat { get => prixAchat; set => prixAchat = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public int Total { get => total; set => total = value; }
    }
}
