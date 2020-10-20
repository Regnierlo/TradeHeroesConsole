using System;
using TradeHeroesConsole.Engine;

namespace TradeHeroesConsole.View
{
    public class GameEngine
    {
        private GestionPlaces _gestionPlaces;
        private bool _leave;
        private int _previousChoice;

        public GameEngine()
        {
            ReadParameters readParam = new ReadParameters();

            //readParam.LoadLanguage();

            #region NewGame

            //Generate places
            _gestionPlaces = new GestionPlaces();
            _leave = false;
            _previousChoice = 0;
            start();

            //

            #endregion
        }

        private void start()
        {
            do
            {
                

            } while (!_leave);
        }
    }
}
