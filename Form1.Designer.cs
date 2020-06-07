namespace DataBase
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Clients = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Employes = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_register = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clients);
            this.tabControl1.Controls.Add(this.Employes);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 403);
            this.tabControl1.TabIndex = 1;
            // 
            // Clients
            // 
            this.Clients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Clients.Controls.Add(this.dataGridView1);
            this.Clients.Location = new System.Drawing.Point(4, 28);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(635, 371);
            this.Clients.TabIndex = 0;
            this.Clients.Text = "Clients";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(624, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Employes
            // 
            this.Employes.BackColor = System.Drawing.Color.White;
            this.Employes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Employes.Location = new System.Drawing.Point(4, 28);
            this.Employes.Name = "Employes";
            this.Employes.Padding = new System.Windows.Forms.Padding(3);
            this.Employes.Size = new System.Drawing.Size(635, 371);
            this.Employes.TabIndex = 1;
            this.Employes.Text = "Employes";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(680, 360);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(108, 39);
            this.button_register.TabIndex = 2;
            this.button_register.Text = "Добавить";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main_Form";
            this.Text = "Главная форма";
            this.tabControl1.ResumeLayout(false);
            this.Clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.TabPage Employes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_register;
    }
}

