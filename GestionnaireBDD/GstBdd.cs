using MySql.Data.MySqlClient;
using System;
using MetierTrader;
using System.Collections.Generic;

namespace GestionnaireBDD
{
    public class GstBdd
    {
        private MySqlConnection cnx;
        private MySqlCommand cmd;
        private MySqlDataReader dr;

        // Constructeur
        public GstBdd()
        {
            string chaine = "Server=localhost;Database=bourse;Uid=root;Pwd=";
            cnx = new MySqlConnection(chaine);
            cnx.Open();
        }

        public List<Trader> getAllTraders()
        {
            List<Trader> mesTraders = new List<Trader>();
            cmd = new MySqlCommand("select idTrader, nomTrader from trader", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Trader unTrader = new Trader(Convert.ToInt16(dr[0]), dr[1].ToString());
                mesTraders.Add(unTrader);
            }
            dr.Close();
            return mesTraders;
        }
        public List<ActionPerso> getAllActionsByTrader(int numTrader)
        {
            List<ActionPerso> mesActionPerso = new List<ActionPerso>();
            cmd = new MySqlCommand("SELECT numAction, action.nomAction, prixAchat, quantite, SUM(prixAchat * quantite) AS total  FROM acheter inner join action on acheter.numAction = action.idAction WHERE acheter.numTrader =" + numTrader, cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ActionPerso uneAction = new ActionPerso(Convert.ToInt16(dr[0]), dr[1].ToString(), Convert.ToDouble(dr[2]), Convert.ToInt16(dr[3]), Convert.ToInt32(dr[4]));
                mesActionPerso.Add(uneAction);

            }
            dr.Close();
            return mesActionPerso;
        }
        //public List<MetierTrader.Action> GetAllAction()
        //{
        //    List<MetierTrader.Action> mesAction = new List<MetierTrader.Action>();
        //    cmd = new MySqlCommand("select idAction, nomAction, coursReel from action", cnx);
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        MetierTrader.Action uneAction = new MetierTrader.Action(Convert.ToInt16(dr[0]), dr[1].ToString(), Convert.ToDouble(dr[2]));
        //        mesAction.Add(uneAction);
        //    }
        //    dr.Close();
        //    return mesAction;
        //}

        public List<MetierTrader.Action> getAllActionsNonPossedees(int numTrader)
        {
            return null;
        }

        public void SupprimerActionAcheter(int numAction, int numTrader)
        {
   
            
        }

        public void UpdateQuantite(int numAction, int numTrader, int quantite)
        {
            
        }

        public double getCoursReel(int numAction)
        {
            return 0;
        }
        public void AcheterAction(int numAction, int numTrader, double prix, int quantite)
        {

        }
        public double getTotalPortefeuille(int numTrader)
        {
            return 0;
        }
    }
}
