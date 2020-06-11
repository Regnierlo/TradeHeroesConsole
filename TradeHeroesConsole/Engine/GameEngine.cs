using System;
using TradeHeroesConsole.Engine;

namespace TradeHeroesConsole.View
{
    public class GameEngine
    {
        private GestionPlaces _gestionPlaces;

        public GameEngine()
        {
            ReadParameters readParam = new ReadParameters();

            readParam.LoadLanguage();

            #region NewGame

            //Generate places
            _gestionPlaces = new GestionPlaces();

            //

            #endregion
        }
    }
}
