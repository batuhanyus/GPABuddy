using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPABuddy
{
    public class ProgramTableLogic
    {
        Database db;
        RichTextBox textBox;

        public List<ComboBox> gradeCombos = new List<ComboBox>();
        public List<CheckBox> takenChecks = new List<CheckBox>();


        public void Tick(Database db, RichTextBox textBox)
        {
            this.db = db;
            this.textBox = textBox;

            //GradeRefresh();
            //TakenRefresh();
            SummaryRefresh();
        }

        void SummaryRefresh()
        {
            float totalAKTS = 0;
            float totalPoints = 0;

            foreach (var course in db.courses)
            {
                if(course.isTaken)
                {
                    totalAKTS += course.akts;
                    totalPoints += course.akts * course.grade;
                }
            }

            if (totalAKTS == 0) return; //Divide by zero.

            float grade = totalPoints / totalAKTS;
            double finalGrade = Math.Round(grade, 2);

            //Text
            string s = string.Empty;
            s += "Toplam AKTS\n" + totalAKTS.ToString();
            s += "\nToplam Puan\n" + totalPoints.ToString();
            s += "\nDiploma Notu\n" + finalGrade.ToString();

            textBox.Text = s;
        }

        public void GradeRefresh() //Takes grades from db and updates UI.
        {
            for (int i = 0; i < gradeCombos.Count; i++)
            {
                float result = -1f;

                if (gradeCombos[i].SelectedItem == "A1 (4.0)") result = 4.0f;
                if (gradeCombos[i].SelectedItem == "A2 (3.75)") result = 3.75f;
                if (gradeCombos[i].SelectedItem == "A3 (3.50)") result = 3.50f;
                if (gradeCombos[i].SelectedItem == "B1 (3.25)") result = 3.25f;
                if (gradeCombos[i].SelectedItem == "B2 (3.0)") result = 3.00f;
                if (gradeCombos[i].SelectedItem == "B3 (2.75)") result = 2.75f;
                if (gradeCombos[i].SelectedItem == "C1 (2.50)") result = 2.50f;
                if (gradeCombos[i].SelectedItem == "C2 (2.25)") result = 2.25f;
                if (gradeCombos[i].SelectedItem == "C3 (2.0)") result = 2.0f;
                if (gradeCombos[i].SelectedItem == "D (1.75)") result = 1.75f;
                if (gradeCombos[i].SelectedItem == "F (0.0)") result = 0.0f;

                if (db.courses[i].grade != result)
                {
                    result = db.courses[i].grade;

                    if (db.courses[i].grade == 4.0f) gradeCombos[i].SelectedIndex = 0;
                    if (db.courses[i].grade == 3.75f) gradeCombos[i].SelectedIndex = 1;
                    if (db.courses[i].grade == 3.50f) gradeCombos[i].SelectedIndex = 2;
                    if (db.courses[i].grade == 3.25f) gradeCombos[i].SelectedIndex = 3;
                    if (db.courses[i].grade == 3.0f) gradeCombos[i].SelectedIndex = 4;
                    if (db.courses[i].grade == 2.75f) gradeCombos[i].SelectedIndex = 5;
                    if (db.courses[i].grade == 2.50f) gradeCombos[i].SelectedIndex = 6;
                    if (db.courses[i].grade == 2.25f) gradeCombos[i].SelectedIndex = 7;
                    if (db.courses[i].grade == 2.0f) gradeCombos[i].SelectedIndex = 8;
                    if (db.courses[i].grade == 1.75f) gradeCombos[i].SelectedIndex = 9;
                    if (db.courses[i].grade == 0.0f) gradeCombos[i].SelectedIndex = 10;
                }
            }
        }

        public void PushGrades() //Takes UI grades and pushes to them to db.
        {
            for (int i = 0; i < gradeCombos.Count; i++)
            {  
                float result = -1f;

                if (gradeCombos[i].SelectedItem == "A1 (4.0)") result = 4.0f;
                if (gradeCombos[i].SelectedItem == "A2 (3.75)") result = 3.75f;
                if (gradeCombos[i].SelectedItem == "A3 (3.50)") result = 3.50f;
                if (gradeCombos[i].SelectedItem == "B1 (3.25)") result = 3.25f;
                if (gradeCombos[i].SelectedItem == "B2 (3.0)") result = 3.00f;
                if (gradeCombos[i].SelectedItem == "B3 (2.75)") result = 2.75f;
                if (gradeCombos[i].SelectedItem == "C1 (2.50)") result = 2.50f;
                if (gradeCombos[i].SelectedItem == "C2 (2.25)") result = 2.25f;
                if (gradeCombos[i].SelectedItem == "C3 (2.0)") result = 2.0f;
                if (gradeCombos[i].SelectedItem == "D (1.75)") result = 1.75f;
                if (gradeCombos[i].SelectedItem == "F (0.0)") result = 0.0f;

                if (result == -1f)
                    MessageBox.Show(gradeCombos[i].SelectedItem.ToString());

                db.courses[i].grade = result;
            }
        }

        public void TakenPush() //Takes if course is taken or not and puts them in db.
        {
            for (int i = 0; i < takenChecks.Count; i++)
            {
                db.courses[i].isTaken = takenChecks[i].Checked;               
            }
        }

        public void TakenRefresh()
        {
            for (int i = 0; i < takenChecks.Count; i++)
            {
                takenChecks[i].Checked = db.courses[i].isTaken;

                if (takenChecks[i].Checked)
                {
                    takenChecks[i].Text = "Alındı";
                    takenChecks[i].BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    takenChecks[i].Text = "Alınmadı";
                    takenChecks[i].BackColor = System.Drawing.Color.Red;
                }
            }
        }

    }
}

//TODO: