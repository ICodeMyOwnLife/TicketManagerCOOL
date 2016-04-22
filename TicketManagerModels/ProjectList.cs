using System.Xml.Serialization;
using CB.Model.Common;


namespace TicketManagerModels
{
    [XmlRoot("projects")]
    public class ProjectList: ObservableObject
    {
        #region Fields
        private Project[] _projects;
        #endregion


        #region  Properties & Indexers
        [XmlElement("project")]
        public Project[] Projects
        {
            get { return _projects; }
            set { SetProperty(ref _projects, value); }
        }
        #endregion
    }
}