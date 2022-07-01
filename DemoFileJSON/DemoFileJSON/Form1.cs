using Microsoft.Extensions.Configuration;
namespace DemoFileJSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = GetEmailAdmin();
            label2.Text = GetPasswordAdmin();
        }
        private static string GetEmailAdmin()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", true, true)
                .Build();


            return config["Email:email"];
        }
        private static string GetPasswordAdmin()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", true, true)
                .Build();


            return config["Password:password"];
        }
    }
}