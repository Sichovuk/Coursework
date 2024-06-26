namespace Coursework_try2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSorting = new System.Windows.Forms.GroupBox();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.btnSearch3 = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gvApplicants = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbEnrollment = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEnrollmentNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMark2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch4 = new System.Windows.Forms.Button();
            this.btnCancel4 = new System.Windows.Forms.Button();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch5 = new System.Windows.Forms.Button();
            this.btnCancel5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindSrcApplicants = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteAll = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnInfo = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbSorting.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplicants)).BeginInit();
            this.gbEnrollment.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcApplicants)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.toolStripSeparator1,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator2,
            this.btnSave,
            this.btnOpen,
            this.toolStripSeparator3,
            this.btnDeleteAll,
            this.btnExit,
            this.btnInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(2564, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.tbSearch);
            this.gbSearch.Controls.Add(this.btnCancel1);
            this.gbSearch.Controls.Add(this.btnSearch1);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Location = new System.Drawing.Point(12, 65);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(430, 185);
            this.gbSearch.TabIndex = 1;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Знайти запис";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(6, 77);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(418, 29);
            this.tbSearch.TabIndex = 5;
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(296, 126);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(128, 53);
            this.btnCancel1.TabIndex = 3;
            this.btnCancel1.Text = "Скасувати";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnCancel1_Click);
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(6, 126);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(121, 53);
            this.btnSearch1.TabIndex = 2;
            this.btnSearch1.Text = "Пошук";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Шукати:";
            // 
            // gbSorting
            // 
            this.gbSorting.Controls.Add(this.btnCancel2);
            this.gbSorting.Controls.Add(this.btnSearch2);
            this.gbSorting.Controls.Add(this.cbSort);
            this.gbSorting.Controls.Add(this.label2);
            this.gbSorting.Location = new System.Drawing.Point(448, 65);
            this.gbSorting.Name = "gbSorting";
            this.gbSorting.Size = new System.Drawing.Size(556, 185);
            this.gbSorting.TabIndex = 2;
            this.gbSorting.TabStop = false;
            this.gbSorting.Text = "Сортування";
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(423, 126);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(128, 53);
            this.btnCancel2.TabIndex = 4;
            this.btnCancel2.Text = "Скасувати";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(6, 126);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(152, 53);
            this.btnSearch2.TabIndex = 3;
            this.btnSearch2.Text = "Відсортувати";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(6, 77);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(545, 32);
            this.cbSort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Відстортувати за:";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.tbMark);
            this.gbFilter.Controls.Add(this.btnCancel3);
            this.gbFilter.Controls.Add(this.btnSearch3);
            this.gbFilter.Controls.Add(this.cbFilter);
            this.gbFilter.Controls.Add(this.label3);
            this.gbFilter.Location = new System.Drawing.Point(1010, 65);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(343, 185);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фільтрування";
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(237, 77);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(100, 29);
            this.tbMark.TabIndex = 6;
            // 
            // btnCancel3
            // 
            this.btnCancel3.Location = new System.Drawing.Point(209, 126);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(128, 53);
            this.btnCancel3.TabIndex = 5;
            this.btnCancel3.Text = "Скасувати";
            this.btnCancel3.UseVisualStyleBackColor = true;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel3_Click);
            // 
            // btnSearch3
            // 
            this.btnSearch3.Location = new System.Drawing.Point(6, 126);
            this.btnSearch3.Name = "btnSearch3";
            this.btnSearch3.Size = new System.Drawing.Size(121, 53);
            this.btnSearch3.TabIndex = 4;
            this.btnSearch3.Text = "Пошук";
            this.btnSearch3.UseVisualStyleBackColor = true;
            this.btnSearch3.Click += new System.EventHandler(this.btnSearch3_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(6, 77);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(198, 32);
            this.cbFilter.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вступний бал:";
            // 
            // gvApplicants
            // 
            this.gvApplicants.AllowUserToAddRows = false;
            this.gvApplicants.AllowUserToDeleteRows = false;
            this.gvApplicants.AutoGenerateColumns = false;
            this.gvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvApplicants.DataSource = this.bindSrcApplicants;
            this.gvApplicants.Location = new System.Drawing.Point(12, 256);
            this.gvApplicants.Name = "gvApplicants";
            this.gvApplicants.ReadOnly = true;
            this.gvApplicants.RowHeadersWidth = 72;
            this.gvApplicants.RowTemplate.Height = 31;
            this.gvApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvApplicants.Size = new System.Drawing.Size(2656, 1136);
            this.gvApplicants.TabIndex = 4;
            // 
            // gbEnrollment
            // 
            this.gbEnrollment.Controls.Add(this.btnCancel4);
            this.gbEnrollment.Controls.Add(this.btnSearch4);
            this.gbEnrollment.Controls.Add(this.label6);
            this.gbEnrollment.Controls.Add(this.tbMark2);
            this.gbEnrollment.Controls.Add(this.label5);
            this.gbEnrollment.Controls.Add(this.tbEnrollmentNumber);
            this.gbEnrollment.Controls.Add(this.label4);
            this.gbEnrollment.Location = new System.Drawing.Point(1359, 65);
            this.gbEnrollment.Name = "gbEnrollment";
            this.gbEnrollment.Size = new System.Drawing.Size(428, 185);
            this.gbEnrollment.TabIndex = 5;
            this.gbEnrollment.TabStop = false;
            this.gbEnrollment.Text = "Зарахування абітурієнтів";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Кількість до зарахування:";
            // 
            // tbEnrollmentNumber
            // 
            this.tbEnrollmentNumber.Location = new System.Drawing.Point(261, 33);
            this.tbEnrollmentNumber.Name = "tbEnrollmentNumber";
            this.tbEnrollmentNumber.Size = new System.Drawing.Size(124, 29);
            this.tbEnrollmentNumber.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Повинні мати балів:";
            // 
            // tbMark2
            // 
            this.tbMark2.Location = new System.Drawing.Point(209, 84);
            this.tbMark2.Name = "tbMark2";
            this.tbMark2.Size = new System.Drawing.Size(124, 29);
            this.tbMark2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "і більше";
            // 
            // btnSearch4
            // 
            this.btnSearch4.Location = new System.Drawing.Point(6, 126);
            this.btnSearch4.Name = "btnSearch4";
            this.btnSearch4.Size = new System.Drawing.Size(139, 53);
            this.btnSearch4.TabIndex = 5;
            this.btnSearch4.Text = "Зарахувати";
            this.btnSearch4.UseVisualStyleBackColor = true;
            this.btnSearch4.Click += new System.EventHandler(this.btnSearch4_Click);
            // 
            // btnCancel4
            // 
            this.btnCancel4.Location = new System.Drawing.Point(294, 126);
            this.btnCancel4.Name = "btnCancel4";
            this.btnCancel4.Size = new System.Drawing.Size(128, 53);
            this.btnCancel4.TabIndex = 6;
            this.btnCancel4.Text = "Скасувати";
            this.btnCancel4.UseVisualStyleBackColor = true;
            this.btnCancel4.Click += new System.EventHandler(this.btnCancel4_Click);
            // 
            // gbList
            // 
            this.gbList.Controls.Add(this.btnCancel5);
            this.gbList.Controls.Add(this.btnSearch5);
            this.gbList.Controls.Add(this.label9);
            this.gbList.Controls.Add(this.label8);
            this.gbList.Controls.Add(this.label7);
            this.gbList.Location = new System.Drawing.Point(1793, 65);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(428, 185);
            this.gbList.TabIndex = 6;
            this.gbList.TabStop = false;
            this.gbList.Text = "Формування списку";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(385, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Сформувати для співбесіди список тих,";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(353, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "хто набрав граничний прохідний бал,";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(346, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "але не здатен оплачувати навчання";
            // 
            // btnSearch5
            // 
            this.btnSearch5.Location = new System.Drawing.Point(6, 126);
            this.btnSearch5.Name = "btnSearch5";
            this.btnSearch5.Size = new System.Drawing.Size(152, 53);
            this.btnSearch5.TabIndex = 6;
            this.btnSearch5.Text = "Сформувати";
            this.btnSearch5.UseVisualStyleBackColor = true;
            this.btnSearch5.Click += new System.EventHandler(this.btnSearch5_Click);
            // 
            // btnCancel5
            // 
            this.btnCancel5.Location = new System.Drawing.Point(294, 126);
            this.btnCancel5.Name = "btnCancel5";
            this.btnCancel5.Size = new System.Drawing.Size(128, 53);
            this.btnCancel5.TabIndex = 7;
            this.btnCancel5.Text = "Скасувати";
            this.btnCancel5.UseVisualStyleBackColor = true;
            this.btnCancel5.Click += new System.EventHandler(this.btnCancel5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework_try2.Properties.Resources._555;
            this.pictureBox1.Location = new System.Drawing.Point(2245, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 185);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 32);
            this.btnAdd.Text = "Додати нового абітурієнта";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 32);
            this.btnEdit.Text = "Редагувати запис";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 32);
            this.btnDelete.Text = "Видалити запис";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 32);
            this.btnSave.Text = "Зберегти у текстовому форматі";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(40, 32);
            this.btnOpen.Text = "Завантажити з файлу";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(40, 32);
            this.btnDeleteAll.Text = "Видалити всі записи";
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 32);
            this.btnExit.Text = "Вийти з програми";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 32);
            this.btnInfo.Text = "Інформація";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.gbEnrollment);
            this.Controls.Add(this.gvApplicants);
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.gbSorting);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant database";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbSorting.ResumeLayout(false);
            this.gbSorting.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvApplicants)).EndInit();
            this.gbEnrollment.ResumeLayout(false);
            this.gbEnrollment.PerformLayout();
            this.gbList.ResumeLayout(false);
            this.gbList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcApplicants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnDeleteAll;
        private System.Windows.Forms.ToolStripButton btnInfo;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSorting;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.Button btnCancel3;
        private System.Windows.Forms.Button btnSearch3;
        private System.Windows.Forms.DataGridView gvApplicants;
        private System.Windows.Forms.BindingSource bindSrcApplicants;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbEnrollment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMark2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEnrollmentNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel4;
        private System.Windows.Forms.Button btnSearch4;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.Button btnCancel5;
        private System.Windows.Forms.Button btnSearch5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

