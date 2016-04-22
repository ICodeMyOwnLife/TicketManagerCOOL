using System.IO;
using System.Windows;
using System.Xml.Serialization;
using TicketManagerModels;


namespace TicketManagerWindow
{
    public partial class MainWindow
    {
        #region  Constructors & Destructor
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion


        #region Event Handlers
        private void MainWindow_OnDrop(object sender, DragEventArgs e)
        {
            var file = GetFileDropped(e.Data);
            if (file == null) return;

            var ticketCollection = ReadTickets(file);
            datMain.ItemsSource = ticketCollection?.Tickets;
        }
        #endregion


        #region Implementation
        private static string GetFileDropped(IDataObject data)
        {
            var files = data.GetData(DataFormats.FileDrop, true) as string[];
            return files == null || files.Length == 0 ? null : files[0];
        }

        private static TicketCollection ReadTickets(string file)
        {
            using (var reader = new StreamReader(file))
            {
                var xmlSer = new XmlSerializer(typeof(TicketCollection));
                return xmlSer.Deserialize(reader) as TicketCollection;
            }
        }
        #endregion
    }
}