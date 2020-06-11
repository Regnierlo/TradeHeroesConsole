using System;
namespace TradeHeroesConsole.View
{
    public class GestionActions
    {
        #region enum
        private enum ActionsPosition
        {
            CentreVille = "ActionsCentreVille",
            Domaine = "ActionsDomaine",
            Forgeron = "ActionsForgeron",
            Taverne = "ActionsTaverne",
            Marché = "ActionsMarche"
        };

        public enum ActionsCentreVille
        {

        };

        public enum ActionsDomaine
        {

        };

        public enum ActionsForgeron
        {

        };

        public enum ActionsMarche
        {
            MarcheHeros = "Marché des héros",
            MarcheObjet = "Marché des objets"
        };

        public enum ActionsMarcheHeros
        {
            AcheterHeros = "Acheter des héros",
            VendreHeros = "Vendre des héros",
            LouerHeros = "Loueur des héros"
        };

        public enum ActionsMarcheObjets
        {
            AcheterObjets = "Acheter des objets",
            VendreObjets = "Vendre des objets",
            LouerObjets = "Loueur des objets"
        };

        public enum ActionsTaverne
        {

        };
        #endregion


        public GestionActions()
        {
        }

        public void afficherActions(GestionPlaces.Places p)
        {

        }
    }
}
