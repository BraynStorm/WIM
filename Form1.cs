using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WoW_Instance_Manager
{
    public partial class Form1 : Form
    {

        public Dictionary<String, Instance> instances = new Dictionary<String, Instance>();
        public List<Realmlist> realmlists = new List<Realmlist>();
        CFG cfg = new CFG(Application.StartupPath + "\\wim.cfg");

        public Form1()
        {
            InitializeComponent();
            loadInstancesFromCFG();
            loadRealmlistsFromCFG();
           // Console.WriteLine(Application.StartupPath);
            
        }

        public void h_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }


        private void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
        }



        private void instanceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (instanceList.SelectedItem == null)
            {
                curInstanceName.Text = "";
                wowExePath.Text = "";
                realmFilePath.Text = "";
                return;
            }

            Instance inst = instances[instanceList.SelectedItem.ToString()];

            if (inst == null) return;
            
            curInstanceName.Text = instanceList.SelectedItem.ToString();
            wowExePath.Text = inst.wowExePath;
            realmFilePath.Text = inst.realmlistPath;

        }

        private void realmsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (realmsList.SelectedItem == null)
            {
                curRealmName.Text = "";
                curRealmAddress.Text = "";
                return;
            }

            Realmlist rel = realmlists[realmsList.SelectedIndex];

            if (rel == null) return;

            curRealmName.Text = rel.name;
            curRealmAddress.Text = rel.address;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wowExeDialog.ShowDialog();
        }

        private void wowExeDialog_FileOk(object sender, CancelEventArgs e)
        {
            Console.WriteLine(sender.ToString());
            wowExePath.Text = ((OpenFileDialog)sender).FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            realmFileDialog.ShowDialog();
        }

        private void realmFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Console.WriteLine(sender.ToString());
            realmFilePath.Text = ((OpenFileDialog)sender).FileName;
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            if (instanceList.SelectedIndex >= 0)
            {
                if (realmsList.SelectedIndex >= 0)
                {
                    setRealmlistOfInstnace(instances[instanceList.SelectedItem.ToString()]);
                    System.Diagnostics.Process.Start(instances[instanceList.SelectedItem.ToString()].wowExePath);
                }
                else
                {
                    showMessage("You don't have a REALMLIST selected.", "Error");
                }
            }
            else
            {
                showMessage("You don't have an INSTANCE selected.", "Error");
            }

        }

        private void btnNewInstance_Click(object sender, EventArgs e)
        {

            instances.Add("New Instance" + instances.Count, new Instance("","") );
            updateInstanceList();

            //instanceList.ClearSelected();
            //instanceList.SetSelected(insLen,true);
        }

        private void btnRemoveInstance_Click(object sender, EventArgs e)
        {
            if (instanceList.SelectedItem == null)
                return;

            instances.Remove(instanceList.SelectedItem.ToString());
            updateInstanceList();
        }

        public void setRealmlistOfInstnace(Instance instance)
        {
            // Set the realmlist addresss in the realmlist file for the instance.
            //showMessage("Yay", "WIM");
            Console.WriteLine(instance.realmlistPath);
            String output = "";
            if(instance.realmlistPath.EndsWith("Config.wtf"))
            {
                String[] input = System.IO.File.ReadAllLines(instance.realmlistPath);
                //bool edited = false;
                for (int i = 0; i < input.Length; i++)
                {
                    if(!input[i].StartsWith("SET realmlist ")){
                        output += input[i] + System.Environment.NewLine;
                    }
                }
                output += "SET realmlist \"" + realmlists[realmsList.SelectedIndex].address + "\"";
                

            }
            else if (instance.realmlistPath.EndsWith("realmlist.wtf"))
            {
                output = "set realmlist " + realmlists[realmsList.SelectedIndex].address;
                
            }
            else
            {
                showMessage("Your realmlist file is incorrect!", "WIM Error");
                return;
            }
            System.IO.File.WriteAllText(instance.realmlistPath, output);
        }

        public void updateInstanceList()
        {
            instanceList.ClearSelected();
            instanceList.Items.Clear();

            var sortedInstances = from item in instances orderby item.Key descending select item;

            foreach (KeyValuePair<String, Instance> entry in sortedInstances)
            {
                instanceList.Items.Add(entry.Key);
            }

        }
        public void updateRealmslistList()
        {
            realmsList.ClearSelected();
            realmsList.Items.Clear();
            realmlists.Sort((x, y) => string.Compare(x.name, y.name));
            foreach (Realmlist entry in realmlists)
            {
                realmsList.Items.Add(entry.name);
            }
            
        }

        private void btnSaveInstance_Click(object sender, EventArgs e)
        {
            if (instanceList.SelectedItem == null) return;
            String name = instanceList.SelectedItem.ToString();
            instances.Remove(name);
            Instance inst = new Instance(wowExePath.Text,realmFilePath.Text); //findInstance(instanceList.SelectedItem.ToString());
            instances.Add(curInstanceName.Text, inst);
            updateInstanceList();
        }

        public void showMessage(String m, String title)
        {
            MessageBox.Show(m, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void saveTheConfigs(object sender, FormClosedEventArgs e)
        {
            foreach(KeyValuePair<String,Instance> entry in instances){
                cfg.bufferData(entry.Key,entry.Value.wowExePath,entry.Value.realmlistPath);
            }
            if (instances.Count == 0)
                cfg.dumpBuffer();

            cfg.save("Instances");

            foreach (Realmlist entry in realmlists)
            {
                cfg.bufferData(entry.name,entry.address,"v");
            }
            cfg.save("Realmlists");


            cfg.save_do();


            StreamWriter sw = new StreamWriter(@"C:\Prova.txt", true);
            Console.WriteLine();
            
            sw.Close();

        }

        public void loadInstancesFromCFG()
        {
            List<CFGUtil> dataa = cfg.loadCFG("Instances");
            if (dataa == null) return;

            foreach (CFGUtil entry in dataa)
            {
                instances.Add(entry.a, new Instance(entry.b, entry.c));
            }
            updateInstanceList();
        }

        public void loadRealmlistsFromCFG()
        {
            List<CFGUtil> dataa = cfg.loadCFG("Realmlists");
            if (dataa == null) return;
            foreach (CFGUtil entry in dataa)
            {
                realmlists.Add(new Realmlist(entry.a, entry.b));
            }
            updateRealmslistList();
        }

        private void btnNewRealmlist_Click(object sender, EventArgs e)
        {
            realmlists.Add(new Realmlist("New Realmlist", ""));
            updateRealmslistList();
        }

        private void btnRemoveRealmlist_Click(object sender, EventArgs e)
        {
            if (realmsList.SelectedItem == null)
                return;

            realmlists.RemoveAt(realmsList.SelectedIndex);
            updateRealmslistList();
        }

        private void btnSaveRealmlist_Click(object sender, EventArgs e)
        {
            if (realmsList.SelectedItem == null)
                return;

            realmlists.RemoveAt(realmsList.SelectedIndex);
            realmlists.Add(new Realmlist(curRealmName.Text, curRealmAddress.Text));

            updateRealmslistList();
        }

       

        
    }
}
