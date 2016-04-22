using System;
using System.Xml.Serialization;
using CB.Model.Common;


namespace TicketManagerModels
{
    public class Project: ObservableObject
    {
        #region Fields
        private DateTime _createdAt;
        private string _description;
        private int _id;
        private string _name;
        private DateTime _updatedAt;
        #endregion


        #region  Properties & Indexers
        [XmlElement("create-at")]
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { SetProperty(ref _createdAt, value); }
        }

        [XmlElement("id")]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        [XmlElement("description")]
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        [XmlElement("name")]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        [XmlElement("updated-at")]
        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { SetProperty(ref _updatedAt, value); }
        }
        #endregion
    }
}