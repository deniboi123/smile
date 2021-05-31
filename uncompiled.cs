using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace smileExploit
{
    public partial class Form1 : Form
    {
        // So we can start calling methods from the API. 
        ExploitAPI API = new ExploitAPI();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            API.SendLuaScript(richTextBox1.Text);    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            API.LaunchExploit();
            API.SendLuaScript("game.StarterGui:SetCore('SendNotification', {Title=':) Attached'; Text='Powered by WeAreDevs. Check em out!'; Duration=5;})");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = " + textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            API.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = " + textBox2.Text);
        }
    }
}
