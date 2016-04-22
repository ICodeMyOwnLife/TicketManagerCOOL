using System.Xml.Serialization;
using CB.Model.Common;


namespace TicketManagerModels
{
    [XmlRoot("tickets")]
    public class TicketList: ObservableObject
    {
        #region Fields
        private Ticket[] _tickets;
        #endregion


        #region  Properties & Indexers
        [XmlElement("ticket")]
        public Ticket[] Tickets
        {
            get { return _tickets; }
            set { SetProperty(ref _tickets, value); }
        }
        #endregion
    }
}