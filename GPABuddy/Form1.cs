using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPABuddy
{
    public partial class Form1 : Form
    {
        public Database db;
        public ProgramTableLogic tableLogic;
        public ProfileWorks profileWorks;

        public Form1()
        {
            InitializeComponent();

            Start();
        }

        void Start()
        {
            tableLogic = new ProgramTableLogic();
            profileWorks = new ProfileWorks();
        }

        private void programSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (programSelector.SelectedIndex == -1)
                return;

            db = null;
            db = new Database(programSelector.Items[programSelector.SelectedIndex].ToString(), programTable, tableLogic);

            programSelector.Enabled = false;
            profileWorks.FindProfiles(programSelector.Items[programSelector.SelectedIndex].ToString(),profilesBox);
            timer1.Enabled = true;
            newProfileButton.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tableLogic.Tick(db, programTextBox);
        }

        private void loadProfileButton_Click(object sender, EventArgs e)
        {
            profileWorks.LoadProfile(profilesBox,db,tableLogic);

            saveTimer.Enabled = true;
        }

        private void renameProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void newProfileButton_Click(object sender, EventArgs e)
        {
            profileWorks.NewProfile(programSelector.Items[programSelector.SelectedIndex].ToString(),profilesBox);
        }

        private void deleteProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadProfileButton.Enabled = true;
            deleteProfileButton.Enabled = true;
            renameProfileButton.Enabled = true;
            renameProfileBox.Text = profileWorks.programProfiles[profilesBox.SelectedIndex].name;
        }

        private void saveTimer_Tick(object sender, EventArgs e)
        {
            //profileWorks.SaveProfile(db);
        }

        private void programSaveButton_Click(object sender, EventArgs e)
        {
            tableLogic.PushGrades();
            tableLogic.TakenPush();
            profileWorks.SaveProfile(db);
            tableLogic.GradeRefresh();
            tableLogic.TakenRefresh();
        }
    }

   
}
