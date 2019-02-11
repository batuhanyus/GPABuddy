using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace GPABuddy
{
    public class ProfileWorks
    {
        public List<Profile> profileVault = new List<Profile>(); //All profiles for all programs.
        public List<Profile> programProfiles = new List<Profile>();

        Profile selectedProfile;

        string path;

        public ProfileWorks()
        {
            path = AppDomain.CurrentDomain.BaseDirectory;
        }

        public void FindProfiles(string program, ListBox profilesBox)
        {
            profilesBox.Items.Clear();
            profileVault.Clear();
            programProfiles.Clear();

            var profileFiles = Directory.GetFiles(path,"*.gbp");
            
            foreach (var file in profileFiles)
            {
                var stream = File.OpenRead(Path.Combine(path, file));
                var formatter = new BinaryFormatter();
                Profile profile = formatter.Deserialize(stream) as Profile;
                profileVault.Add(profile);

                if(profile.program == program)
                {
                    programProfiles.Add(profile);
                    profilesBox.Items.Add(profile.name);
                }

                stream.Close();
            }
        }

        public void LoadProfile(ListBox profilesBox,Database db,ProgramTableLogic tableLogic)
        {
            selectedProfile = programProfiles[profilesBox.SelectedIndex];
            db.courses = selectedProfile.courses;
            tableLogic.TakenRefresh();
            tableLogic.GradeRefresh();
        }

        public void NewProfile(string program, ListBox profilesBox)
        {
            var profileFiles = Directory.GetFiles(path, "*.gbp");

            Profile newProfile = new Profile("Profil " + profileFiles.Length.ToString(), program);

            var stream = File.Create(path + "Profil " + profileFiles.Length.ToString() + ".gbp");

            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, newProfile);

            stream.Close();

            FindProfiles(program, profilesBox);
        }

        public void RenameProfile(ListBox profilesBox)
        {

        }

        public void DeleteProfile(ListBox profilesBox)
        {

        }

        public void SaveProfile(Database db)
        {
            selectedProfile.courses = db.courses;

            var stream = File.Create(Path.Combine(path, selectedProfile.name + ".gbp"));
            var formatter = new BinaryFormatter();
            formatter.Serialize(stream, selectedProfile);
            stream.Close();
        }
    }
}
