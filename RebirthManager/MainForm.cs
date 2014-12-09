using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RebirthManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ReadLastRun_Click(object sender, EventArgs e)
        {
        
            if(Properties.Settings.Default.LogFileLocation == "" || !File.Exists(Properties.Settings.Default.LogFileLocation)) //check if there is a a log file, if not go and find it
            {
                if(File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + Properties.Resources.LogFileDefault))
                {
                    Properties.Settings.Default.LogFileLocation = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + Properties.Resources.LogFileDefault;
                    MessageBox.Show("Log file automatically found!");
                    ProcessLogFile();
                }
                else
                {
                    
                }
            }
            else
            {
                ProcessLogFile();
            }
        }

        private void ProcessLogFile()
        {
            string lines;
            using (StreamReader sr = new StreamReader(Properties.Settings.Default.LogFileLocation))
            {
                lines = sr.ReadToEnd();
            }
            string seed = lines.Substring(lines.IndexOf("RNG Start Seed: ")+16, 9);
            
            testlabel.Text = "Seed: "+ seed ;
        }
       
        private void UpdateItemTables_Click(object sender, EventArgs e)
        {
            //Update Items

            var ItemImageList = Directory.GetFiles("Items");
            string[] Items = Properties.Resources.ItemList.Split('\n');
            int counter = 0;
            foreach (string item in Items)
            {
                string[] prop = item.Split(':');
                string ID = prop[0], Name = prop[1].Split('-')[0], Desc = prop[1].Split('-')[1];
                //Formating the item name
                if (Name[0] == '*')
                {
                    Name = Name.Substring(1);
                }
                if (Name.Contains('['))
                {
                    Name = Name.Substring(0, Name.IndexOf('['));
                }
                if(Name.Contains(", The"))
                {
                    Name = "The " + Name.Substring(0, Name.IndexOf(','));
                }
                if(Name.Contains(", A"))
                {
                    Name = "A " + Name.Substring(0, Name.IndexOf(','));
                }
                
                using (var ta = new IsaacDataSetTableAdapters.ItemsTableAdapter())
                {

                    try
                    {
                        ta.Insert(int.Parse(ID), Name, Desc, imageToByteArray(Image.FromFile(ItemImageList[counter])));
                    }
                    catch (Exception ex)
                    {
                        //No need to update the item, already exists
                    }
                }
                counter++;
            }

            //Update Characters
            var CharacterImageList = Directory.GetFiles("Characters");
            foreach (var character in CharacterImageList)
            {
                string filename = Path.GetFileName(character);
                string ID = filename.Split('-')[0], Name = filename.Split('-')[1].Split('.')[0];
                using (var ta = new IsaacDataSetTableAdapters.CharactersTableAdapter())
                {

                    try
                    {
                        ta.Insert(int.Parse(ID), Name, imageToByteArray(Image.FromFile(character)));
                    }
                    catch (Exception ex)
                    {
                        //No need to update the item, already exists
                    }
                }
            }

        }
    }
}
