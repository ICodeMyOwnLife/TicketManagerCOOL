using System;
using System.Xml.Serialization;
using CB.Model.Common;
using Newtonsoft.Json;


namespace TicketManagerModels
{
    public class Project: ObservableObject
    {
        private const string CREATEDAT_PROP = "create-at";
        private const string ID_PROP = "id";
        private const string DESCRIPTION_PROP = "description";
        private const string NAME_PROP = "name";
        private const string UPDATEDAT_PROP = "updated-at";
        #region Fields
        private DateTime _createdAt;
        private string _description;
        private int _id;
        private string _name;
        private DateTime _updatedAt;
        #endregion


        #region  Properties & Indexers
        [XmlElement(CREATEDAT_PROP), JsonProperty(CREATEDAT_PROP)]
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { SetProperty(ref _createdAt, value); }
        }

        [XmlElement(ID_PROP), JsonProperty(ID_PROP)]
        public int Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        [XmlElement(DESCRIPTION_PROP), JsonProperty(DESCRIPTION_PROP)]
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        [XmlElement(NAME_PROP), JsonProperty(NAME_PROP)]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        [XmlElement(UPDATEDAT_PROP), JsonProperty(UPDATEDAT_PROP)]
        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { SetProperty(ref _updatedAt, value); }
        }
        #endregion
    }
}


// TODO: https://qasolutions.lighthouseapp.com/