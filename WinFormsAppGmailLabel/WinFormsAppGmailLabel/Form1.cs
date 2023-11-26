using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using System.ComponentModel;

namespace WinFormsAppGmailLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLabel_Click(object sender, EventArgs e)
        {
            GetLabelId(txtId.Text, txtSecret.Text);
        }

        public void ExtractAttachment(string strId, string strSecret, string strLabel, string strFolder)
        {
            //GetLabelId();
            // Install the Google.Apis.Gmail.v1 NuGet package
            // Create a GmailService object and authenticate with your credentials
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = strId,
                    ClientSecret = strSecret
                },
                new[] { GmailService.Scope.GmailReadonly },
                "user",
                CancellationToken.None).Result;

            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GmailExtractor",
            });

            // Get the list of threads in the folder using the Users.Threads.List method
            var request = service.Users.Threads.List("me");
            request.LabelIds = strLabel;

            var threads = request.Execute().Threads;

            // Loop through the threads and get the messages using the Users.Threads.Get method
            foreach (var thread in threads)
            {
                var threadRequest = service.Users.Threads.Get("me", thread.Id);
                var threadData = threadRequest.Execute();

                // Loop through the messages and get the attachments using the Users.Messages.Attachments.Get method
                foreach (var message in threadData.Messages)
                {
                    //Console.WriteLine("Subject: {0}", message.Payload.Headers.Find(h => h.Name == "Subject").Value);
                    foreach (var part in message.Payload.Parts)
                    {
                        if (!string.IsNullOrEmpty(part.Filename))
                        {
                            var attachId = part.Body.AttachmentId;
                            var attachRequest = service.Users.Messages.Attachments.Get("me", message.Id, attachId);
                            var attachData = attachRequest.Execute();

                            // Download the attachments using the Data property and save them to a local folder using File.WriteAllBytes
                            byte[] data = Convert.FromBase64String(attachData.Data.Replace('-', '+').Replace('_', '/'));
                            var fileName = part.Filename;
                            //var folderPath = Path.Combine(Environment.CurrentDirectory, "Attachments");
                            var folderPath = strFolder;
                            Directory.CreateDirectory(folderPath);
                            var filePath = Path.Combine(folderPath, fileName);
                            File.WriteAllBytes(filePath, data);
                            Console.WriteLine("Saved attachment: {0}", filePath);
                        }
                    }
                    //Console.WriteLine();
                }
            }
        }

        public void GetLabelId(string strId, string strSecret)
        {
            // Install the Google.Apis.Gmail.v1 NuGet package
            // Create a GmailService object and authenticate with your credentials
            GmailFolderList gmailFolderList = new GmailFolderList();
            var credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = strId,
                    ClientSecret = strSecret
                },
                new[] { GmailService.Scope.GmailReadonly },
                "user",
                CancellationToken.None).Result;

            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GmailLabeler",
            });

            // Get the list of labels using the Users.Labels.List method
            var request = service.Users.Labels.List("me");
            var labels = request.Execute().Labels;

            // Loop through the labels and get the id and name using the Id and Name properties
            gmailFolderList.lstFolder = new List<GmailFolder>();
            foreach (var label in labels)
            {
                //Console.WriteLine("Label id: {0}, name: {1}", label.Id, label.Name);
                GmailFolder gmailFolder = new GmailFolder();
                gmailFolder.labelId = label.Id;
                gmailFolder.labelName = label.Name;
                gmailFolderList.lstFolder.Add(gmailFolder);
            }

            GmailFolderList gmailFolderList1 = new GmailFolderList();
            gmailFolderList1.lstFolder =  gmailFolderList.lstFolder.OrderBy(r => r.labelName).ToList();
            //dataGridView1.DataSource = gmailFolderList;
            //dataGridView1.DataMember = "lstFolder";
            dataGridView1.DataSource = gmailFolderList1;
            dataGridView1.DataMember = "lstFolder";
            //dataGridView1.DataMember = "lstFolder";
            //dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.Programmatic;
            //dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);

            dataGridView1.Refresh();
            
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            ExtractAttachment(txtId.Text, txtSecret.Text, txtLabelId.Text, txtDir.Text);
        }
    }
}
