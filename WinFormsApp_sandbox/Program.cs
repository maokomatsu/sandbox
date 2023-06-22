using System.Diagnostics;

namespace WinFormsApp_sandbox
{
    internal class Sample : Form
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
       // [STAThread]

        private Label lb;
        private Button bt;

        private Boolean pushed_botton = false;


        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();



            Application.Run(new Sample());
        }

        public Sample()
        {
            this.Text = "�T���v��";
            this.Width = 300;
            this.Height = 200;


            lb = new Label();
            lb.Text = "�{�^���������Ă�������";
            lb.Width = 180;
            bt = new Button();
            bt.Text = "�{�^��";
            bt.Top = this.Top + lb.Height;
            bt.Width = lb.Width;

            bt.Parent = this;
            lb.Parent = this;

            bt.Click += new EventHandler(bt_Click);


        }

        public void bt_Click(Object sender, EventArgs e)
        {
            if (!pushed_botton)
            {
                pushed_botton = true;
                lb.BackColor = Color.Red;
                lb.Text = "���x���̐F���ς��܂���";
            }
            else
            {
                pushed_botton = false;
                lb.BackColor = Color.Transparent;
                lb.Text = "�{�^���������Ă�������";
            }
        }
    }
}
