using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPABuddy
{
    /// <summary>
    /// This class holds "Öğretim Programı Dersleri".
    /// </summary>
    public class Database
    {
        TableLayoutPanel programTable;
        ProgramTableLogic tableLogic;

        public List<Course> courses = new List<Course>();

        public Database(string program, TableLayoutPanel programTable,ProgramTableLogic tableLogic)
        {
            this.programTable = programTable;
            this.tableLogic = tableLogic;

            BasicTexts();

            if (program == "İktisat Programı (Türkçe)")
                AddTurkishEconomicsCourses();
        }

        void AddTurkishEconomicsCourses()
        {
            courses.Add(new Course(0, "TEMEL BİLGİ VE İLETİŞİM TEKN. KULLANIMI", 2, 1));
            courses.Add(new Course(1, "Hukuka Giriş", 3, 1));
            courses.Add(new Course(2, "İŞLETMEYE GİRİŞ", 3, 1));
            courses.Add(new Course(3, "İKTİSADA GİRİŞ I ", 5, 1));
            courses.Add(new Course(4, "FELSEFEYE GİRİŞ ", 4, 1));
            courses.Add(new Course(5, "UYGARLIK TARİHİ  ", 4, 1));
            courses.Add(new Course(6, "İKTİSATÇILAR İÇİN BİLGİSAYAR BECERİLERİ I", 4, 1));
            courses.Add(new Course(7, "İktisatçılar için Matematik I", 3, 1));
            courses.Add(new Course(8, "Genel Muhasebe I ", 3, 1));
            courses.Add(new Course(9, "TEMEL İNGİLİZCE I  ", 3, 1));
            courses.Add(new Course(10, "TÜRK DİLİ I", 2, 1));

            courses.Add(new Course(11, "ANAYASA HUKUKUNA GİRİŞ ", 5, 2));
            courses.Add(new Course(12, "SİYASİ TARİH ", 4, 2));
            courses.Add(new Course(13, "İKTİSADA GİRİŞ II  ", 5, 2));
            courses.Add(new Course(14, "Sosyal Düşüncenin Temelleri ", 4, 2));
            courses.Add(new Course(15, "İKTİSATÇILAR İÇİN BİLGİSAYAR BECERİLERİ II  ", 4, 2));
            courses.Add(new Course(16, "İktisatçılar için Matematik II  ", 3, 2));
            courses.Add(new Course(17, "Genel Muhasebe II  ", 4, 2));
            courses.Add(new Course(18, "TEMEL İNGİLİZCE II", 3, 2));
            courses.Add(new Course(19, "TÜRK DİLİ II", 2, 2));

            courses.Add(new Course(20, "ATATÜRK İLKELERİ VE İNKILAP TARİHİ I  ", 2, 3));
            courses.Add(new Course(21, "İKTİSAT TARİHİ I  ", 5, 3));
            courses.Add(new Course(22, "MAKRO İKTİSAT I  ", 5, 3));
            courses.Add(new Course(23, "MATEMATİKSEL İKTİSAT I ", 5, 3));
            courses.Add(new Course(24, "İKTİSATÇILAR İÇİN ÖZEL HUKUK I ", 5, 3));
            courses.Add(new Course(25, "İstatistik I  ", 4, 3));

            courses.Add(new Course(26, "ATATÜRK İLKELERİ VE İNKILAP TARİHİ II  ", 2, 4));
            courses.Add(new Course(27, "İKTİSAT TARİHİ II ", 5, 4));
            courses.Add(new Course(28, "MİKRO İKTİSAT II ", 5, 4));
            courses.Add(new Course(29, "MATEMATİKSEL İKTİSAT II ", 5, 4));
            courses.Add(new Course(30, "MAKRO İKTİSAT II ", 5, 4));
            courses.Add(new Course(31, "İKTİSATÇILAR İÇİN ÖZEL HUKUK II ", 5, 4));
            courses.Add(new Course(32, "İstatistik II ", 4, 4));

            courses.Add(new Course(33, "PARA TEORİSİ VE POLİTİKASI I ", 5, 5));
            courses.Add(new Course(34, "EKONOMETRİ I ", 5, 5));
            courses.Add(new Course(35, "ULUSLARARASI İKTİSAT I ", 5, 5));
            courses.Add(new Course(36, "ENDÜSTRİYEL ORGANİZASYON ", 5, 5));
            courses.Add(new Course(37, "İŞLETME HUKUKU I ", 5, 5));
            courses.Add(new Course(38, "Kamu Maliyesi ", 5, 5));
            courses.Add(new Course(39, "Oyun Teorisi ", 5, 5));
            courses.Add(new Course(40, "İktisat ve Edebiyat ", 5, 5));
            courses.Add(new Course(41, "Marksist İktisat Teorisi ", 5, 5));
            courses.Add(new Course(42, "Tarım İktisadı ", 5, 5));

            courses.Add(new Course(43, "PARA TEORİSİ VE POLİTİKASI II ", 5, 6));
            courses.Add(new Course(44, "EKONOMETRİ II ", 5, 6));
            courses.Add(new Course(45, "ULUSLARARASI İKTİSAT II ", 5, 6));
            courses.Add(new Course(46, "FELSEFEYE", 5, 6));
            courses.Add(new Course(47, "FELSEFEYE", 5, 6));
            courses.Add(new Course(48, "İŞLETME HUKUKU II ", 5, 6));
            courses.Add(new Course(49, "MALİYE POLİTİKASI ", 5, 6));
            courses.Add(new Course(50, "FİNANSAL MUHASEBE ", 5, 6));
            courses.Add(new Course(51, "ÇALIŞMA EKONOMİSİ ", 5, 6));
            courses.Add(new Course(52, "TOPLUMSAL CİNSİYET VE İKTİSAT ", 5, 6));
            courses.Add(new Course(53, "POLİTİK İKTİSAT ", 5, 6));

            courses.Add(new Course(54, "İKTİSADİ ANALİZ TARİHİ I ", 6, 7));
            courses.Add(new Course(55, "TÜRKİYE EKONOMİSİ I ", 4, 7));
            courses.Add(new Course(56, "TÜRK VERGİ HUKUKU VE SİSTEMİ ", 5, 7));
            courses.Add(new Course(57, "DÜNYA EKONOMİSİ ", 5, 7));
            courses.Add(new Course(58, "PARA VE SERMAYE PİYASALARI ", 5, 7));
            courses.Add(new Course(59, "SEMİNER  ", 5, 7));
            courses.Add(new Course(60, "TEKNOLOJİ İKTİSADI ", 5, 7));
            courses.Add(new Course(61, "ZAMAN SERİSİ ANALİZİ ", 5, 7));
            courses.Add(new Course(62, "HESAPLANABİLİR GENEL DENGE MODELLERİ ", 5, 7));
            courses.Add(new Course(63, "KALKINMA VE BÜYÜME I ", 5, 7));
            courses.Add(new Course(64, "FİNANSAL PİYASALAR ", 5, 7));
            courses.Add(new Course(65, "ULUSLARARASI FİNANS ", 4, 7));

            courses.Add(new Course(66, "İKTİSADİ ANALİZ TARİHİ II ", 6, 8));
            courses.Add(new Course(67, "TÜRKİYE EKONOMİSİ II ", 4, 8));
            courses.Add(new Course(68, "PROJE DEĞERLENDİRME ", 5, 8));
            courses.Add(new Course(69, "SAĞLIK EKONOMİSİ ", 5, 8));
            courses.Add(new Course(70, "KENTSEL EKONOMİ ", 5, 8));
            courses.Add(new Course(71, "KALKINMA VE BÜYÜME II ", 5, 8));
            courses.Add(new Course(72, "Bölgesel Kalkınma ", 5, 8));
            courses.Add(new Course(73, "ÖZEL EKONOMİK KONULAR ", 5, 8));
            courses.Add(new Course(74, "AVRUPA BİRLİĞİ ", 5, 8));
            courses.Add(new Course(75, "DOĞAL KAYNAKLAR ve ÇEVRE EKONOMİSİ ", 5, 8));
            courses.Add(new Course(76, "KARAR TEORİSİ ", 5, 8));
            courses.Add(new Course(77, "İş Hukuku ", 7, 8));
           //courses.Add(new Course(78, "FELSEFEYE", 4, 1));
           //courses.Add(new Course(79, "FELSEFEYE", 4, 1));


            //Populate List.


            foreach (var course in courses)
            {
                int row = course.ID + 1;

                Label idLabel = new Label();
                idLabel.Text = course.ID.ToString();
                idLabel.Dock = DockStyle.Fill;
                idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                programTable.Controls.Add(idLabel, 0, row);

                Label nameLabel = new Label();
                nameLabel.Text = course.name;
                nameLabel.Dock = DockStyle.Fill;
                nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                programTable.Controls.Add(nameLabel, 1, row);

                Label aktsLabel = new Label();
                aktsLabel.Text = course.akts.ToString();
                aktsLabel.Dock = DockStyle.Fill;
                aktsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                programTable.Controls.Add(aktsLabel, 2, row);

                ComboBox gradeCombo = new ComboBox();
                gradeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
                gradeCombo.Items.Add("A1 (4.0)"); gradeCombo.Items.Add("A2 (3.75)"); gradeCombo.Items.Add("A3 (3.50)"); gradeCombo.Items.Add("B1 (3.25)"); gradeCombo.Items.Add("B2 (3.0)");
                gradeCombo.Items.Add("B3 (2.75)"); gradeCombo.Items.Add("C1 (2.50)"); gradeCombo.Items.Add("C2 (2.25)"); gradeCombo.Items.Add("C3 (2.0)"); gradeCombo.Items.Add("D (1.75)"); gradeCombo.Items.Add("F (0.0)");
                gradeCombo.SelectedIndex = 0; //Dont make it F xD
                tableLogic.gradeCombos.Add(gradeCombo);
                programTable.Controls.Add(gradeCombo, 3, row);

                //TextBox gradeBox = new TextBox();
                //gradeBox.Text = course.grade.ToString();
                //gradeBox.TextAlign = HorizontalAlignment.Center;
                //gradeBox.BorderStyle = BorderStyle.None;
                //tableLogic.gradeBoxes.Add(gradeBox);
                //programTable.Controls.Add(gradeBox, 3, row);
                
                CheckBox takenCheck = new CheckBox();
                takenCheck.Checked = course.isTaken;
                takenCheck.BackColor = Color.Gray;
                takenCheck.Dock = DockStyle.Fill;
                takenCheck.Text = course.isTaken.ToString();
                tableLogic.takenChecks.Add(takenCheck);
                programTable.Controls.Add(takenCheck, 4, row);
            }
        }

        void BasicTexts()
        {
            Label idLabel = new Label();
            idLabel.Text = "#";
            idLabel.Dock = DockStyle.Fill;
            idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            programTable.Controls.Add(idLabel, 0, 0);

            Label nameLabel = new Label();
            nameLabel.Text = "Ders Adı";
            nameLabel.Dock = DockStyle.Fill;
            nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            programTable.Controls.Add(nameLabel, 1, 0);

            Label aktsLabel = new Label();
            aktsLabel.Text = "AKTS";
            aktsLabel.Dock = DockStyle.Fill;
            aktsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            programTable.Controls.Add(aktsLabel, 2, 0);

            Label gradeLabel = new Label();
            gradeLabel.Text = "Not";
            gradeLabel.Dock = DockStyle.Fill;
            gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            programTable.Controls.Add(gradeLabel, 3, 0);

            Label takenLabel = new Label();
            takenLabel.Text = "Ders Alındı?";
            takenLabel.Dock = DockStyle.Fill;
            takenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            programTable.Controls.Add(takenLabel, 4, 0);
        }


    }
}
