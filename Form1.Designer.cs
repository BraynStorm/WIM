namespace WoW_Instance_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNewInstance = new System.Windows.Forms.Button();
            this.btnRemoveInstance = new System.Windows.Forms.Button();
            this.instanceList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveRealmlist = new System.Windows.Forms.Button();
            this.realmsList = new System.Windows.Forms.ListBox();
            this.btnNewRealmlist = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnSaveInstance = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.realmFilePath = new System.Windows.Forms.TextBox();
            this.wowExePath = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.curInstanceName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wowExeDialog = new System.Windows.Forms.OpenFileDialog();
            this.realmFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSaveRealmlist = new System.Windows.Forms.Button();
            this.curRealmAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.curRealmName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.instanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewInstance
            // 
            this.btnNewInstance.Location = new System.Drawing.Point(6, 19);
            this.btnNewInstance.Name = "btnNewInstance";
            this.btnNewInstance.Size = new System.Drawing.Size(96, 25);
            this.btnNewInstance.TabIndex = 0;
            this.btnNewInstance.Text = "New Instance";
            this.btnNewInstance.UseVisualStyleBackColor = true;
            this.btnNewInstance.Click += new System.EventHandler(this.btnNewInstance_Click);
            // 
            // btnRemoveInstance
            // 
            this.btnRemoveInstance.Location = new System.Drawing.Point(108, 19);
            this.btnRemoveInstance.Name = "btnRemoveInstance";
            this.btnRemoveInstance.Size = new System.Drawing.Size(129, 25);
            this.btnRemoveInstance.TabIndex = 1;
            this.btnRemoveInstance.Text = "Remove Instnace";
            this.btnRemoveInstance.UseVisualStyleBackColor = true;
            this.btnRemoveInstance.Click += new System.EventHandler(this.btnRemoveInstance_Click);
            // 
            // instanceList
            // 
            this.instanceList.FormattingEnabled = true;
            this.instanceList.Location = new System.Drawing.Point(6, 50);
            this.instanceList.Name = "instanceList";
            this.instanceList.Size = new System.Drawing.Size(231, 199);
            this.instanceList.TabIndex = 2;
            this.instanceList.SelectedIndexChanged += new System.EventHandler(this.instanceList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveInstance);
            this.groupBox1.Controls.Add(this.instanceList);
            this.groupBox1.Controls.Add(this.btnNewInstance);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instances";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveRealmlist);
            this.groupBox2.Controls.Add(this.realmsList);
            this.groupBox2.Controls.Add(this.btnNewRealmlist);
            this.groupBox2.Location = new System.Drawing.Point(267, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 262);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Realmlists";
            // 
            // btnRemoveRealmlist
            // 
            this.btnRemoveRealmlist.Location = new System.Drawing.Point(108, 19);
            this.btnRemoveRealmlist.Name = "btnRemoveRealmlist";
            this.btnRemoveRealmlist.Size = new System.Drawing.Size(129, 25);
            this.btnRemoveRealmlist.TabIndex = 1;
            this.btnRemoveRealmlist.Text = "Remove Realmlist";
            this.btnRemoveRealmlist.UseVisualStyleBackColor = true;
            this.btnRemoveRealmlist.Click += new System.EventHandler(this.btnRemoveRealmlist_Click);
            // 
            // realmsList
            // 
            this.realmsList.FormattingEnabled = true;
            this.realmsList.Location = new System.Drawing.Point(6, 50);
            this.realmsList.Name = "realmsList";
            this.realmsList.Size = new System.Drawing.Size(231, 199);
            this.realmsList.TabIndex = 2;
            this.realmsList.SelectedIndexChanged += new System.EventHandler(this.realmsList_SelectedIndexChanged);
            // 
            // btnNewRealmlist
            // 
            this.btnNewRealmlist.Location = new System.Drawing.Point(6, 19);
            this.btnNewRealmlist.Name = "btnNewRealmlist";
            this.btnNewRealmlist.Size = new System.Drawing.Size(96, 25);
            this.btnNewRealmlist.TabIndex = 0;
            this.btnNewRealmlist.Text = "New Realmlist";
            this.btnNewRealmlist.UseVisualStyleBackColor = true;
            this.btnNewRealmlist.Click += new System.EventHandler(this.btnNewRealmlist_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Font = new System.Drawing.Font("Consolas", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLaunch.Location = new System.Drawing.Point(522, 286);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(284, 168);
            this.btnLaunch.TabIndex = 3;
            this.btnLaunch.Text = "Launch Instance";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnSaveInstance
            // 
            this.btnSaveInstance.Location = new System.Drawing.Point(6, 140);
            this.btnSaveInstance.Name = "btnSaveInstance";
            this.btnSaveInstance.Size = new System.Drawing.Size(486, 27);
            this.btnSaveInstance.TabIndex = 4;
            this.btnSaveInstance.Text = "Save Changes";
            this.btnSaveInstance.UseVisualStyleBackColor = true;
            this.btnSaveInstance.Click += new System.EventHandler(this.btnSaveInstance_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.realmFilePath);
            this.groupBox3.Controls.Add(this.wowExePath);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.btnSaveInstance);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.curInstanceName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 174);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Current Instance";
            // 
            // realmFilePath
            // 
            this.realmFilePath.Enabled = false;
            this.realmFilePath.Location = new System.Drawing.Point(9, 114);
            this.realmFilePath.Name = "realmFilePath";
            this.realmFilePath.Size = new System.Drawing.Size(483, 20);
            this.realmFilePath.TabIndex = 8;
            // 
            // wowExePath
            // 
            this.wowExePath.Enabled = false;
            this.wowExePath.Location = new System.Drawing.Point(9, 73);
            this.wowExePath.Name = "wowExePath";
            this.wowExePath.Size = new System.Drawing.Size(483, 20);
            this.wowExePath.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(363, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 20);
            this.button6.TabIndex = 7;
            this.button6.Text = "Choose...";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 20);
            this.button5.TabIndex = 7;
            this.button5.Text = "Choose...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Realm file Path";
            // 
            // curInstanceName
            // 
            this.curInstanceName.Location = new System.Drawing.Point(261, 22);
            this.curInstanceName.Name = "curInstanceName";
            this.curInstanceName.Size = new System.Drawing.Size(231, 20);
            this.curInstanceName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "WoW.EXE Path";
            // 
            // wowExeDialog
            // 
            this.wowExeDialog.FileName = "wow.exe";
            this.wowExeDialog.Filter = "WoW.exe|*.exe";
            this.wowExeDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.wowExeDialog_FileOk);
            // 
            // realmFileDialog
            // 
            this.realmFileDialog.FileName = "realmlist.wtf";
            this.realmFileDialog.Filter = "Config Files|*.wtf";
            this.realmFileDialog.Title = "Select the location of the Realm file (realmlist.wtf/Config.WTF)";
            this.realmFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.realmFileDialog_FileOk);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSaveRealmlist);
            this.groupBox4.Controls.Add(this.curRealmAddress);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.curRealmName);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(522, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 108);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Current Realmlist";
            // 
            // btnSaveRealmlist
            // 
            this.btnSaveRealmlist.Location = new System.Drawing.Point(9, 73);
            this.btnSaveRealmlist.Name = "btnSaveRealmlist";
            this.btnSaveRealmlist.Size = new System.Drawing.Size(269, 27);
            this.btnSaveRealmlist.TabIndex = 9;
            this.btnSaveRealmlist.Text = "Save Changes";
            this.btnSaveRealmlist.UseVisualStyleBackColor = true;
            this.btnSaveRealmlist.Click += new System.EventHandler(this.btnSaveRealmlist_Click);
            // 
            // curRealmAddress
            // 
            this.curRealmAddress.Location = new System.Drawing.Point(106, 47);
            this.curRealmAddress.Name = "curRealmAddress";
            this.curRealmAddress.Size = new System.Drawing.Size(172, 20);
            this.curRealmAddress.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // curRealmName
            // 
            this.curRealmName.Location = new System.Drawing.Point(106, 22);
            this.curRealmName.Name = "curRealmName";
            this.curRealmName.Size = new System.Drawing.Size(172, 20);
            this.curRealmName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.ImageLocation = "logo.png";
            this.logoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("logoBox.InitialImage")));
            this.logoBox.Location = new System.Drawing.Point(522, 126);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(284, 148);
            this.logoBox.TabIndex = 8;
            this.logoBox.TabStop = false;
            // 
            // instanceBindingSource
            // 
            this.instanceBindingSource.DataSource = typeof(WoW_Instance_Manager.Instance);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 461);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLaunch);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "WoW Instance Manger";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.saveTheConfigs);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instanceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewInstance;
        private System.Windows.Forms.Button btnRemoveInstance;
        private System.Windows.Forms.ListBox instanceList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveRealmlist;
        private System.Windows.Forms.ListBox realmsList;
        private System.Windows.Forms.Button btnNewRealmlist;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Button btnSaveInstance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox wowExePath;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox curInstanceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog wowExeDialog;
        private System.Windows.Forms.TextBox realmFilePath;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog realmFileDialog;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox curRealmAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox curRealmName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveRealmlist;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.BindingSource instanceBindingSource;
    }
}

