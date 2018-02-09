namespace GraphWorkFinal {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.btn_exit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ImportEdgesList = new System.Windows.Forms.Button();
            this.btn_inportMergeList = new System.Windows.Forms.Button();
            this.btn_updateGraphPicture = new System.Windows.Forms.Button();
            this.btn_importIncidenceMatrix = new System.Windows.Forms.Button();
            this.btnImportAdjacenctMatrix = new System.Windows.Forms.Button();
            this.pb_graphPicture = new System.Windows.Forms.PictureBox();
            this.btn_importBerzh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_graphPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 440);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_importBerzh);
            this.groupBox1.Controls.Add(this.btn_ImportEdgesList);
            this.groupBox1.Controls.Add(this.btn_inportMergeList);
            this.groupBox1.Controls.Add(this.btn_updateGraphPicture);
            this.groupBox1.Controls.Add(this.btn_importIncidenceMatrix);
            this.groupBox1.Controls.Add(this.btnImportAdjacenctMatrix);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 422);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_ImportEdgesList
            // 
            this.btn_ImportEdgesList.Location = new System.Drawing.Point(6, 148);
            this.btn_ImportEdgesList.Name = "btn_ImportEdgesList";
            this.btn_ImportEdgesList.Size = new System.Drawing.Size(75, 38);
            this.btn_ImportEdgesList.TabIndex = 6;
            this.btn_ImportEdgesList.Text = "Список дуг";
            this.btn_ImportEdgesList.UseVisualStyleBackColor = true;
            this.btn_ImportEdgesList.Click += new System.EventHandler(this.btn_ImportEdgesList_Click);
            // 
            // btn_inportMergeList
            // 
            this.btn_inportMergeList.Location = new System.Drawing.Point(6, 105);
            this.btn_inportMergeList.Name = "btn_inportMergeList";
            this.btn_inportMergeList.Size = new System.Drawing.Size(75, 37);
            this.btn_inportMergeList.TabIndex = 5;
            this.btn_inportMergeList.Text = "Список смежности";
            this.btn_inportMergeList.UseVisualStyleBackColor = true;
            this.btn_inportMergeList.Click += new System.EventHandler(this.btn_inportMergeList_Click);
            // 
            // btn_updateGraphPicture
            // 
            this.btn_updateGraphPicture.Location = new System.Drawing.Point(0, 379);
            this.btn_updateGraphPicture.Name = "btn_updateGraphPicture";
            this.btn_updateGraphPicture.Size = new System.Drawing.Size(75, 37);
            this.btn_updateGraphPicture.TabIndex = 4;
            this.btn_updateGraphPicture.Text = "Обновить граф";
            this.btn_updateGraphPicture.UseVisualStyleBackColor = true;
            this.btn_updateGraphPicture.Click += new System.EventHandler(this.btn_updateGraphPicture_Click);
            // 
            // btn_importIncidenceMatrix
            // 
            this.btn_importIncidenceMatrix.Location = new System.Drawing.Point(6, 62);
            this.btn_importIncidenceMatrix.Name = "btn_importIncidenceMatrix";
            this.btn_importIncidenceMatrix.Size = new System.Drawing.Size(75, 37);
            this.btn_importIncidenceMatrix.TabIndex = 3;
            this.btn_importIncidenceMatrix.Text = "Матрица инциден-ти";
            this.btn_importIncidenceMatrix.UseVisualStyleBackColor = true;
            this.btn_importIncidenceMatrix.Click += new System.EventHandler(this.btn_importIncidenceMatrix_Click);
            // 
            // btnImportAdjacenctMatrix
            // 
            this.btnImportAdjacenctMatrix.Location = new System.Drawing.Point(6, 19);
            this.btnImportAdjacenctMatrix.Name = "btnImportAdjacenctMatrix";
            this.btnImportAdjacenctMatrix.Size = new System.Drawing.Size(75, 37);
            this.btnImportAdjacenctMatrix.TabIndex = 2;
            this.btnImportAdjacenctMatrix.Text = "Матрица смежности";
            this.btnImportAdjacenctMatrix.UseVisualStyleBackColor = true;
            this.btnImportAdjacenctMatrix.Click += new System.EventHandler(this.btnImportAdjacenctMatrix_Click);
            // 
            // pb_graphPicture
            // 
            this.pb_graphPicture.Location = new System.Drawing.Point(624, 18);
            this.pb_graphPicture.Name = "pb_graphPicture";
            this.pb_graphPicture.Size = new System.Drawing.Size(401, 416);
            this.pb_graphPicture.TabIndex = 5;
            this.pb_graphPicture.TabStop = false;
            // 
            // btn_importBerzh
            // 
            this.btn_importBerzh.Location = new System.Drawing.Point(6, 192);
            this.btn_importBerzh.Name = "btn_importBerzh";
            this.btn_importBerzh.Size = new System.Drawing.Size(75, 38);
            this.btn_importBerzh.TabIndex = 6;
            this.btn_importBerzh.Text = "Описание Бержа";
            this.btn_importBerzh.UseVisualStyleBackColor = true;
            this.btn_importBerzh.Click += new System.EventHandler(this.btn_importBerzh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 475);
            this.Controls.Add(this.pb_graphPicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_exit);
            this.Name = "Form1";
            this.Text = "Graph";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_graphPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImportAdjacenctMatrix;
        private System.Windows.Forms.Button btn_importIncidenceMatrix;
        private System.Windows.Forms.Button btn_updateGraphPicture;
        private System.Windows.Forms.PictureBox pb_graphPicture;
        private System.Windows.Forms.Button btn_inportMergeList;
        private System.Windows.Forms.Button btn_ImportEdgesList;
        private System.Windows.Forms.Button btn_importBerzh;
    }
}

