﻿namespace DataBase
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
            this.register_client_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.показатьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.change_client_button = new System.Windows.Forms.Button();
            this.delete_client_button = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.TabPage();
            this.Clients_base = new System.Windows.Forms.DataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Employes = new System.Windows.Forms.TabPage();
            this.delete_emp_button = new System.Windows.Forms.Button();
            this.Employes_base = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.register_emp_button = new System.Windows.Forms.Button();
            this.change_emp_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Clients_base)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Employes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employes_base)).BeginInit();
            this.SuspendLayout();
            // 
            // register_client_button
            // 
            this.register_client_button.Location = new System.Drawing.Point(739, 133);
            this.register_client_button.Name = "register_client_button";
            this.register_client_button.Size = new System.Drawing.Size(375, 55);
            this.register_client_button.TabIndex = 2;
            this.register_client_button.Text = "Добавить";
            this.register_client_button.UseVisualStyleBackColor = true;
            this.register_client_button.Click += new System.EventHandler(this.button_register_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьВсеToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 48);
            // 
            // показатьВсеToolStripMenuItem
            // 
            this.показатьВсеToolStripMenuItem.Name = "показатьВсеToolStripMenuItem";
            this.показатьВсеToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.показатьВсеToolStripMenuItem.Text = "Показать все";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // change_client_button
            // 
            this.change_client_button.Location = new System.Drawing.Point(739, 76);
            this.change_client_button.Name = "change_client_button";
            this.change_client_button.Size = new System.Drawing.Size(375, 51);
            this.change_client_button.TabIndex = 3;
            this.change_client_button.Text = "Изменить выбранные";
            this.change_client_button.UseVisualStyleBackColor = true;
            this.change_client_button.Click += new System.EventHandler(this.change_client_button_Click);
            // 
            // delete_client_button
            // 
            this.delete_client_button.Location = new System.Drawing.Point(739, 16);
            this.delete_client_button.Name = "delete_client_button";
            this.delete_client_button.Size = new System.Drawing.Size(375, 54);
            this.delete_client_button.TabIndex = 4;
            this.delete_client_button.Text = "Удалить выбранные";
            this.delete_client_button.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.Clients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Clients.Controls.Add(this.delete_client_button);
            this.Clients.Controls.Add(this.Clients_base);
            this.Clients.Controls.Add(this.register_client_button);
            this.Clients.Controls.Add(this.change_client_button);
            this.Clients.Location = new System.Drawing.Point(4, 28);
            this.Clients.Name = "Clients";
            this.Clients.Padding = new System.Windows.Forms.Padding(3);
            this.Clients.Size = new System.Drawing.Size(1124, 446);
            this.Clients.TabIndex = 0;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = true;
            // 
            // Clients_base
            // 
            this.Clients_base.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Clients_base.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Clients_base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clients_base.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Check});
            this.Clients_base.Location = new System.Drawing.Point(1, 1);
            this.Clients_base.Name = "Clients_base";
            this.Clients_base.Size = new System.Drawing.Size(732, 440);
            this.Clients_base.TabIndex = 0;
            this.Clients_base.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Check
            // 
            this.Check.Frozen = true;
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.Width = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Clients);
            this.tabControl1.Controls.Add(this.Employes);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1132, 478);
            this.tabControl1.TabIndex = 1;
            // 
            // Employes
            // 
            this.Employes.BackColor = System.Drawing.Color.White;
            this.Employes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Employes.Controls.Add(this.delete_emp_button);
            this.Employes.Controls.Add(this.Employes_base);
            this.Employes.Controls.Add(this.register_emp_button);
            this.Employes.Controls.Add(this.change_emp_button);
            this.Employes.Location = new System.Drawing.Point(4, 28);
            this.Employes.Name = "Employes";
            this.Employes.Padding = new System.Windows.Forms.Padding(3);
            this.Employes.Size = new System.Drawing.Size(1124, 446);
            this.Employes.TabIndex = 1;
            this.Employes.Text = "Работники МФО";
            // 
            // delete_emp_button
            // 
            this.delete_emp_button.Location = new System.Drawing.Point(742, 16);
            this.delete_emp_button.Name = "delete_emp_button";
            this.delete_emp_button.Size = new System.Drawing.Size(375, 54);
            this.delete_emp_button.TabIndex = 8;
            this.delete_emp_button.Text = "Удалить выбранные";
            this.delete_emp_button.UseVisualStyleBackColor = true;
            // 
            // Employes_base
            // 
            this.Employes_base.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Employes_base.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.Employes_base.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Employes_base.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.Employes_base.Location = new System.Drawing.Point(4, 1);
            this.Employes_base.Name = "Employes_base";
            this.Employes_base.Size = new System.Drawing.Size(732, 440);
            this.Employes_base.TabIndex = 5;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // register_emp_button
            // 
            this.register_emp_button.Location = new System.Drawing.Point(742, 133);
            this.register_emp_button.Name = "register_emp_button";
            this.register_emp_button.Size = new System.Drawing.Size(375, 55);
            this.register_emp_button.TabIndex = 6;
            this.register_emp_button.Text = "Добавить";
            this.register_emp_button.UseVisualStyleBackColor = true;
            // 
            // change_emp_button
            // 
            this.change_emp_button.Location = new System.Drawing.Point(742, 76);
            this.change_emp_button.Name = "change_emp_button";
            this.change_emp_button.Size = new System.Drawing.Size(375, 51);
            this.change_emp_button.TabIndex = 7;
            this.change_emp_button.Text = "Изменить выбранные";
            this.change_emp_button.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1156, 563);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main_Form";
            this.Text = "Главная форма";
            this.Enter += new System.EventHandler(this.Main_Form_Enter);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Clients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Clients_base)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Employes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Employes_base)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button register_client_button;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.Button change_client_button;
        private System.Windows.Forms.Button delete_client_button;
        private System.Windows.Forms.TabPage Clients;
        private System.Windows.Forms.DataGridView Clients_base;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Employes;
        private System.Windows.Forms.Button delete_emp_button;
        private System.Windows.Forms.DataGridView Employes_base;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button register_emp_button;
        private System.Windows.Forms.Button change_emp_button;
    }
}

