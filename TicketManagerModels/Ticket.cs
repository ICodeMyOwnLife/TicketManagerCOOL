using System;
using System.Xml.Serialization;
using CB.Model.Common;


namespace TicketManagerModels
{
    public class Ticket: ObservableObject
    {
        #region Fields
        private string _assignedTo;

        private string _createdBy;
        private DateTime _createdOn;

        private string _importance;

        private string _latestBody;

        private string _milestone;

        private int _number;

        private string _originalBody;

        private int _priority;

        private int _projectId;

        private string _state;

        private string _tagString;

        private string _title;

        private DateTime _updatedOn;

        private string _url;
        #endregion


        #region  Properties & Indexers
        [XmlElement("title")]
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        [XmlElement("updated-at")]
        public DateTime UpdatedOn
        {
            get { return _updatedOn; }
            set { SetProperty(ref _updatedOn, value); }
        }

        [XmlElement("creator-name")]
        public string CreatedBy
        {
            get { return _createdBy; }
            set { SetProperty(ref _createdBy, value); }
        }

        [XmlElement("assigned-user-name")]
        public string AssignedTo
        {
            get { return _assignedTo; }
            set { SetProperty(ref _assignedTo, value); }
        }

        [XmlElement("created-at")]
        public DateTime CreatedOn
        {
            get { return _createdOn; }
            set { SetProperty(ref _createdOn, value); }
        }

        [XmlElement("importance-name")]
        public string Importance
        {
            get { return _importance; }
            set { SetProperty(ref _importance, value); }
        }

        [XmlElement("url")]
        public string Url
        {
            get { return _url; }
            set { SetProperty(ref _url, value); }
        }

        [XmlElement("priority")]
        public int Priority
        {
            get { return _priority; }
            set { SetProperty(ref _priority, value); }
        }

        [XmlElement("original-body")]
        public string OriginalBody
        {
            get { return _originalBody; }
            set { SetProperty(ref _originalBody, value, ReplaceBreakWithNewLine); }
        }

        [XmlElement("latest-body")]
        public string LatestBody
        {
            get { return _latestBody; }
            set { SetProperty(ref _latestBody, value, ReplaceBreakWithNewLine); }
        }

        [XmlElement("number")]
        public int Number
        {
            get { return _number; }
            set { SetProperty(ref _number, value); }
        }

        [XmlElement("project-id")]
        public int ProjectId
        {
            get { return _projectId; }
            set { SetProperty(ref _projectId, value); }
        }

        [XmlElement("milestone-title")]
        public string Milestone
        {
            get { return _milestone; }
            set { SetProperty(ref _milestone, value); }
        }

        [XmlElement("state")]
        public string State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); }
        }

        [XmlElement("tag")]
        public string TagString
        {
            get { return _tagString; }
            set { SetProperty(ref _tagString, value); }
        }
        #endregion


        #region Implementation
        private static string ReplaceBreakWithNewLine(string s)
            => s?.Replace("<br/>", Environment.NewLine);
        #endregion
    }
}


//TODO: parse tag, project name