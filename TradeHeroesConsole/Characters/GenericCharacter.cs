using System;
namespace TradeHeroesConsole.View
{
    public class GenericCharacter
    {
        private String _firstName="";
        private String _lastName = "";
        private String _surname = "";

        #region Accesseurs
        /// <summary>
        /// Get the first character's name
        /// </summary>
        public String FirstName { get => _firstName; }

        /// <summary>
        /// Get or set the character's last name
        /// </summary>
        public String LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        /// <summary>
        /// Get or set the character' surname
        /// </summary>
        public String Surname
        {
            get => _surname;
            set => _surname = value;
        }
        #endregion

        #region Builders
        public GenericCharacter()
        {

        }

        public GenericCharacter(String FirstName)
        {
            this._firstName = FirstName;
        }

        public GenericCharacter(String FirstName, String LastName)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
        }

        public GenericCharacter(String FirstName, String LastName, String Surname)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
            this._surname = Surname;
        }
        #endregion
    }
}
