﻿namespace proyecto_int_capa_de_datos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.emailFiedl = new System.Windows.Forms.TextBox();
            this.phone2_field = new System.Windows.Forms.TextBox();
            this.phone_field = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.direction_field = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.name_field = new System.Windows.Forms.TextBox();
            this.date_field = new System.Windows.Forms.DateTimePicker();
            this.genre_field = new System.Windows.Forms.ComboBox();
            this.marital_status_field = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.search_field = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.emailFiedl, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.phone2_field, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.phone_field, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.direction_field, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.name_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.name_field, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.date_field, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.genre_field, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.marital_status_field, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 129);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // emailFiedl
            // 
            this.emailFiedl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emailFiedl.Location = new System.Drawing.Point(591, 102);
            this.emailFiedl.Multiline = true;
            this.emailFiedl.Name = "emailFiedl";
            this.emailFiedl.Size = new System.Drawing.Size(192, 20);
            this.emailFiedl.TabIndex = 16;
            // 
            // phone2_field
            // 
            this.phone2_field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phone2_field.Location = new System.Drawing.Point(395, 102);
            this.phone2_field.Multiline = true;
            this.phone2_field.Name = "phone2_field";
            this.phone2_field.Size = new System.Drawing.Size(190, 20);
            this.phone2_field.TabIndex = 15;
            // 
            // phone_field
            // 
            this.phone_field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.phone_field.Location = new System.Drawing.Point(199, 102);
            this.phone_field.Multiline = true;
            this.phone_field.Name = "phone_field";
            this.phone_field.Size = new System.Drawing.Size(190, 20);
            this.phone_field.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(591, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefono";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(199, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Numero celular";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado civil";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // direction_field
            // 
            this.direction_field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.direction_field.Location = new System.Drawing.Point(395, 38);
            this.direction_field.Multiline = true;
            this.direction_field.Name = "direction_field";
            this.direction_field.Size = new System.Drawing.Size(190, 20);
            this.direction_field.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Genero";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nacimiento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_label
            // 
            this.name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_label.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(3, 2);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(190, 28);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Nombre";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_field
            // 
            this.name_field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_field.Location = new System.Drawing.Point(3, 38);
            this.name_field.Multiline = true;
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(190, 20);
            this.name_field.TabIndex = 6;
            // 
            // date_field
            // 
            this.date_field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.date_field.Location = new System.Drawing.Point(199, 38);
            this.date_field.Name = "date_field";
            this.date_field.Size = new System.Drawing.Size(190, 20);
            this.date_field.TabIndex = 7;
            // 
            // genre_field
            // 
            this.genre_field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.genre_field.FormattingEnabled = true;
            this.genre_field.Items.AddRange(new object[] {
            "Femenino",
            "Masculino",
            "Otro"});
            this.genre_field.Location = new System.Drawing.Point(591, 37);
            this.genre_field.Name = "genre_field";
            this.genre_field.Size = new System.Drawing.Size(192, 21);
            this.genre_field.TabIndex = 2;
            // 
            // marital_status_field
            // 
            this.marital_status_field.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.marital_status_field.FormattingEnabled = true;
            this.marital_status_field.Items.AddRange(new object[] {
            "Soltero",
            "Soltera",
            "Casado",
            "Casada",
            "Viuda",
            "Viudo"});
            this.marital_status_field.Location = new System.Drawing.Point(3, 102);
            this.marital_status_field.Name = "marital_status_field";
            this.marital_status_field.Size = new System.Drawing.Size(190, 21);
            this.marital_status_field.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.RemoveBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.edit_btn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.add_btn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.refresh_btn, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 134);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(783, 44);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.Location = new System.Drawing.Point(588, 3);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(192, 38);
            this.RemoveBtn.TabIndex = 3;
            this.RemoveBtn.Text = "Eliminar";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.Location = new System.Drawing.Point(198, 3);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(189, 38);
            this.edit_btn.TabIndex = 1;
            this.edit_btn.Text = "Editar";
            this.edit_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.Location = new System.Drawing.Point(3, 3);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(189, 38);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Insertar";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh_btn.Location = new System.Drawing.Point(393, 3);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(189, 38);
            this.refresh_btn.TabIndex = 2;
            this.refresh_btn.Text = "Refrescar";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DataGrid, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 230);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(786, 221);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.apellido_field,
            this.Nacimiento,
            this.Sexo,
            this.Direccion,
            this.Estado_civil,
            this.Numero});
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(3, 3);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(780, 215);
            this.DataGrid.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // apellido_field
            // 
            this.apellido_field.HeaderText = "Apellido";
            this.apellido_field.Name = "apellido_field";
            this.apellido_field.ReadOnly = true;
            // 
            // Nacimiento
            // 
            this.Nacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nacimiento.HeaderText = "Nacimiento";
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Estado_civil
            // 
            this.Estado_civil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Estado_civil.HeaderText = "Estado_civil";
            this.Estado_civil.Name = "Estado_civil";
            this.Estado_civil.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numero.HeaderText = "Numero de telefono";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.95866F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.04134F));
            this.tableLayoutPanel4.Controls.Add(this.search_field, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Search_btn, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(207, 190);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(387, 27);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // search_field
            // 
            this.search_field.Location = new System.Drawing.Point(3, 3);
            this.search_field.Name = "search_field";
            this.search_field.Size = new System.Drawing.Size(257, 20);
            this.search_field.TabIndex = 0;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(266, 3);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(118, 21);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "Buscar";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(799, 454);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(815, 493);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.DateTimePicker date_field;
        private System.Windows.Forms.TextBox direction_field;
        private System.Windows.Forms.ComboBox genre_field;
        private System.Windows.Forms.TextBox emailFiedl;
        private System.Windows.Forms.TextBox phone2_field;
        private System.Windows.Forms.TextBox phone_field;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox marital_status_field;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_field;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox search_field;
        private System.Windows.Forms.Button Search_btn;
    }
}

