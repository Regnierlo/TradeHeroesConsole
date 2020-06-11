using System;
using System.Collections.Generic;

namespace TradeHeroesConsole.View
{
    public class GestionPlaces
    {
        public enum Places
        {
            CentreVille,
            Domaine,
            Forgeron,
            Taverne,
            Marché
        };

        public GestionPlaces()
        {

            affichePlaces(generationPlaces(Places.CentreVille));
        }

        /// <summary>
        /// Permet de générer les places accessibles depuis la position du joueur
        /// </summary>
        /// <returns>Retourne les places accessibles.</returns>
        /// <param name="e">Position du joueur</param>
        private List<Places> generationPlaces(Places e)
        {
            List<Places> lp = new List<Places>();

            foreach (Places p in (Places[]) Enum.GetValues(typeof(Places)))
            {
                if (p.ToString() != e.ToString())
                {
                    lp.Add(p);
                }
            }

            return lp;
        }

        /// <summary>
        /// Affiche les places accessibles par le joueur
        /// </summary>
        /// <param name="l">List des places accessibles par le joueur</param>
        private void affichePlaces(List<Places> l)
        {
            for (int i = 1; i < l.Count+1; i++)
            {
                Console.WriteLine(i+" - "+l[i-1]);
            }
        }


    }
}
