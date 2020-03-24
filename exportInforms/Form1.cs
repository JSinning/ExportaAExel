using exportInforms.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exportInforms
{
    public partial class Form1 : Form
    {
        public string url = "https://jsonplaceholder.typicode.com";
        List<PetitionGET> Lista;
        List<PetitionUsersGet> Userlist;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string respuesta = await postGet();
            string usersrespueta = await usersGet();

            // All https information is listed

            Lista = JsonConvert.DeserializeObject<List<PetitionGET>>(respuesta);
            Userlist = JsonConvert.DeserializeObject<List<PetitionUsersGet>>(usersrespueta);
            foreach (PetitionGET dta in Lista)
            {
                ListViewItem item = new ListViewItem(dta.ID.ToString());
                foreach (PetitionUsersGet dtusers in Userlist)
                {
                    if (dtusers.ID == dta.Userid)
                    {
                        item.SubItems.Add(dtusers.Name);
                    }
                }

                item.SubItems.Add(dta.Title);
                item.SubItems.Add(dta.Body);
                listView1.Items.Add(item);

            }


        }

        public async Task<string> postGet()
        {
            WebRequest request = WebRequest.Create(url + "/posts/");
            WebResponse response = request.GetResponse();
            StreamReader stream = new StreamReader(response.GetResponseStream());
            return await stream.ReadToEndAsync();
        }

        public async Task<string> usersGet()
        {
            WebRequest request = WebRequest.Create(url + "/users");
            WebResponse response = request.GetResponse();
            StreamReader stream = new StreamReader(response.GetResponseStream());
            return await stream.ReadToEndAsync();
        }

        public async Task<string> postGetid(int id)
        {
            WebRequest request = WebRequest.Create(url + "/posts?userId=" + id);
            WebResponse response = request.GetResponse();
            StreamReader stream = new StreamReader(response.GetResponseStream());
            return await stream.ReadToEndAsync();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            int Numeber = 0;
            if (!int.TryParse(TxtSearch.Text, out Numeber) || string.IsNullOrEmpty(TxtSearch.Text))
            {
                MessageBox.Show("el campo esta vacio o dijito una cadena");
                return;

            }
            try
            {
                listView1.Items.Clear();
                int iduser = Int32.Parse(TxtSearch.Text);
                string listusersid = await postGetid(iduser);
                string usersrespueta = await usersGet();
                Lista = JsonConvert.DeserializeObject<List<PetitionGET>>(listusersid);
                Userlist = JsonConvert.DeserializeObject<List<PetitionUsersGet>>(usersrespueta);
                if (Lista.Count == 0)
                {
                    MessageBox.Show("El usurrio no due encontrado");
                    return;
                }
                foreach (PetitionGET dta in Lista )
                {
                    ListViewItem item = new ListViewItem(dta.ID.ToString());
                    foreach (PetitionUsersGet dtusers in Userlist)
                    {
                        if (dtusers.ID == dta.Userid)
                        {
                            item.SubItems.Add(dtusers.Name);
                        }
                    }
                    item.SubItems.Add(dta.Title);
                    item.SubItems.Add(dta.Body);
                    listView1.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }


            TxtSearch.Text = "";
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            GenerateReport Rep = new GenerateReport();
            ReportsData ReportsD = new ReportsData();
            try
            {
                for (int i = 0; i <= listView1.Items.Count; i++)
                {
                    ReportsD.ID = Int32.Parse(listView1.Items[i].SubItems[0].Text);
                    ReportsD.Name = listView1.Items[i].SubItems[1].Text;
                    ReportsD.Title = listView1.Items[i].SubItems[2].Text;
                    ReportsD.Description = listView1.Items[i].SubItems[3].Text;
                    
                   Console.WriteLine(ReportsD.ID);
                }
                

            }
            catch (ArgumentException ex)
            {
                ex.Message.ToString();
            }

            Rep.ShowDialog();
        }
    }
}
