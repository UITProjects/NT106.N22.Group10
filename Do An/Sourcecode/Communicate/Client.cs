﻿using communicate_client_server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communicate
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        Com_Client client;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            client.Send_login(username_textbox.Text, pass_textbox.Text);
        }

        private void Client_Load(object sender, EventArgs e)
        {
            client = new Com_Client();
        }
    }
}