using System;
using System.Xml.Serialization;
using CB.Model.Common;
using Newtonsoft.Json;


namespace TicketManagerModels
{
    public class Ticket: ObservableObject
    {
        #region Fields
        private const string ASSIGNEDTO_PROP = "assigned-user-name";
        private const string CREATEDAT_PROP = "created-at";
        private const string CREATEDBY_PROP = "creator-name";
        private const string IMPORTANCE_PROP = "importance-name";
        private const string LATESTBODY_PROP = "latest-body";
        private const string MILESTONE_PROP = "milestone-title";
        private const string NUMBER_PROP = "number";
        private const string ORIGINALBODY_PROP = "original-body";
        private const string PRIORITY_PROP = "priority";
        private const string PROJECTID_PROP = "project-id";
        private const string STATE_PROP = "state";
        private const string TAG_PROP = "tag";
        private const string TITLE_PROP = "title";
        private const string UPDATEDAT_PROP = "updated-at";
        private const string URL_PROP = "url";
        private string _assignedTo;
        private DateTime _createdAt;

        private string _createdBy;

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

        private DateTime _updatedAt;

        private string _url;
        #endregion


        #region  Properties & Indexers
        [XmlElement(TITLE_PROP), JsonProperty(TITLE_PROP)]
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        [XmlElement(UPDATEDAT_PROP), JsonProperty(UPDATEDAT_PROP)]
        public DateTime UpdatedAt
        {
            get { return _updatedAt; }
            set { SetProperty(ref _updatedAt, value); }
        }

        [XmlElement(CREATEDBY_PROP), JsonProperty(CREATEDBY_PROP)]
        public string CreatedBy
        {
            get { return _createdBy; }
            set { SetProperty(ref _createdBy, value); }
        }

        [XmlElement(ASSIGNEDTO_PROP), JsonProperty(ASSIGNEDTO_PROP)]
        public string AssignedTo
        {
            get { return _assignedTo; }
            set { SetProperty(ref _assignedTo, value); }
        }

        [XmlElement(CREATEDAT_PROP), JsonProperty(CREATEDAT_PROP)]
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { SetProperty(ref _createdAt, value); }
        }

        [XmlElement(IMPORTANCE_PROP), JsonProperty(IMPORTANCE_PROP)]
        public string Importance
        {
            get { return _importance; }
            set { SetProperty(ref _importance, value); }
        }

        [XmlElement(URL_PROP), JsonProperty(URL_PROP)]
        public string Url
        {
            get { return _url; }
            set { SetProperty(ref _url, value); }
        }

        [XmlElement(PRIORITY_PROP), JsonProperty(PRIORITY_PROP)]
        public int Priority
        {
            get { return _priority; }
            set { SetProperty(ref _priority, value); }
        }

        [XmlElement(ORIGINALBODY_PROP), JsonProperty(ORIGINALBODY_PROP)]
        public string OriginalBody
        {
            get { return _originalBody; }
            set { SetProperty(ref _originalBody, value, ReplaceBreakWithNewLine); }
        }

        [XmlElement(LATESTBODY_PROP), JsonProperty(LATESTBODY_PROP)]
        public string LatestBody
        {
            get { return _latestBody; }
            set { SetProperty(ref _latestBody, value, ReplaceBreakWithNewLine); }
        }

        [XmlElement(NUMBER_PROP), JsonProperty(NUMBER_PROP)]
        public int Number
        {
            get { return _number; }
            set { SetProperty(ref _number, value); }
        }

        [XmlElement(PROJECTID_PROP), JsonProperty(PROJECTID_PROP)]
        public int ProjectId
        {
            get { return _projectId; }
            set { SetProperty(ref _projectId, value); }
        }

        [XmlElement(MILESTONE_PROP), JsonProperty(MILESTONE_PROP)]
        public string Milestone
        {
            get { return _milestone; }
            set { SetProperty(ref _milestone, value); }
        }

        [XmlElement(STATE_PROP), JsonProperty(STATE_PROP)]
        public string State
        {
            get { return _state; }
            set { SetProperty(ref _state, value); }
        }

        [XmlElement(TAG_PROP), JsonProperty(TAG_PROP)]
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


// TODO: parse tag, project name