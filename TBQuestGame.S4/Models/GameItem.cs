using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBQuestGame.Models
{
    class GameItem
    {
        #region ENUMERABLES

        #endregion

        #region FIELDS
        private int _id;
        private string _name;
        private int _value;
        private string _description;
        private string _useMessage;
        #endregion

        #region PROPERTIES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

       

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

       
        public string UseMessage
        {
            get { return _useMessage; }
            set { _useMessage = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public GameItem (int id, string name, int value, string description, string useMessage = "")
        {
            Id = id;
            Name = name;
            Value = value;
            Description = description;
            UseMessage = useMessage;
        }


        #endregion

        #region METHODS

        public virtual string InformationString()
        {
            return $"{Name}: {Description}/nValue: {Value}";
        }

        public string Information
        {
            get
            {
                return InformationString();
            }
        }


        #endregion
    }
}
