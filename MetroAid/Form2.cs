using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace MetroAid
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "9eoOqsLnNlmDGT7ZLCPi23AKNmn3t1Zd1UesRu54",
            BasePath = "https://theusers-87676.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Form2_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    client = new FireSharp.FirebaseClient(ifc);
            //}

            //catch
            //{
            //    MessageBox.Show("No Internet or Connection Problem");
            //}
        }

        //   private void RegBtn_Click(object sender, EventArgs e)
        //  {
        //  RegistrationForm reg = new RegistrationForm();
        //   reg.ShowDialog();
        // }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            //#region Condition
            //if (string.IsNullOrWhiteSpace(user_txt.Text) &&
            //   string.IsNullOrWhiteSpace(pass_text.Text))
            //{
            //    MessageBox.Show("Please Fill All The Fields");
            //    return;
            //}
            //#endregion

            //FirebaseResponse res = client.Get(user_txt.Text);
            //MyUser ResUser = res.ResultAs<MyUser>();// database result

            //MyUser CurUser = new MyUser() // USER GIVEN INFO
            //{
            //    Username = user_txt.Text,
            //    Password = pass_text.Text
            //};

            //if (MyUser.IsEqual(ResUser, CurUser))
            //{
                Form1 real = new Form1();
                real.ShowDialog();
            
            //}

            //else
            //{
            //  //  MyUser.ShowError();
            //}
        }

    
    }
}
