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
            this.groupBoxFull = new System.Windows.Forms.GroupBox();
            this.btn_absCenter = new System.Windows.Forms.Button();
            this.btn_isTree = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cycleNumber = new System.Windows.Forms.Button();
            this.btn_countComponents = new System.Windows.Forms.Button();
            this.btn_DFS = new System.Windows.Forms.Button();
            this.btn_getDiametrRadius = new System.Windows.Forms.Button();
            this.tb_searchEdgeM2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_addVertex = new System.Windows.Forms.Button();
            this.btn_addEdge = new System.Windows.Forms.Button();
            this.btn_delVertex = new System.Windows.Forms.Button();
            this.tb_delEdgeM2 = new System.Windows.Forms.TextBox();
            this.btn_delEdge = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_addVertex = new System.Windows.Forms.TextBox();
            this.tb_addEdgeM2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_delEdgeM1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_addEdgeM1 = new System.Windows.Forms.TextBox();
            this.tb_addEdgeWeight = new System.Windows.Forms.TextBox();
            this.tb_delVertex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_adjVertices = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_countVertices = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_countEdges = new System.Windows.Forms.Button();
            this.btn_adjVertices = new System.Windows.Forms.Button();
            this.tb_searchVertex = new System.Windows.Forms.TextBox();
            this.tb_searchEdgeM1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_getPower = new System.Windows.Forms.Button();
            this.btn_searchEdge = new System.Windows.Forms.Button();
            this.btn_searchVertex = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_updateGraphPicture = new System.Windows.Forms.Button();
            this.btn_importBerzh = new System.Windows.Forms.Button();
            this.btn_ImportEdgesList = new System.Windows.Forms.Button();
            this.btn_inportMergeList = new System.Windows.Forms.Button();
            this.btn_importIncidenceMatrix = new System.Windows.Forms.Button();
            this.btnImportAdjacenctMatrix = new System.Windows.Forms.Button();
            this.pb_graphPicture = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxFull.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_graphPicture)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            // groupBoxFull
            // 
            this.groupBoxFull.Controls.Add(this.btn_absCenter);
            this.groupBoxFull.Controls.Add(this.btn_isTree);
            this.groupBoxFull.Controls.Add(this.button1);
            this.groupBoxFull.Controls.Add(this.btn_cycleNumber);
            this.groupBoxFull.Controls.Add(this.btn_countComponents);
            this.groupBoxFull.Controls.Add(this.btn_DFS);
            this.groupBoxFull.Controls.Add(this.btn_getDiametrRadius);
            this.groupBoxFull.Controls.Add(this.tb_searchEdgeM2);
            this.groupBoxFull.Controls.Add(this.groupBox2);
            this.groupBoxFull.Controls.Add(this.tb_adjVertices);
            this.groupBoxFull.Controls.Add(this.textBox1);
            this.groupBoxFull.Controls.Add(this.label12);
            this.groupBoxFull.Controls.Add(this.btn_countVertices);
            this.groupBoxFull.Controls.Add(this.label11);
            this.groupBoxFull.Controls.Add(this.label10);
            this.groupBoxFull.Controls.Add(this.btn_countEdges);
            this.groupBoxFull.Controls.Add(this.btn_adjVertices);
            this.groupBoxFull.Controls.Add(this.tb_searchVertex);
            this.groupBoxFull.Controls.Add(this.tb_searchEdgeM1);
            this.groupBoxFull.Controls.Add(this.label8);
            this.groupBoxFull.Controls.Add(this.btn_getPower);
            this.groupBoxFull.Controls.Add(this.btn_searchEdge);
            this.groupBoxFull.Controls.Add(this.btn_searchVertex);
            this.groupBoxFull.Controls.Add(this.label4);
            this.groupBoxFull.Controls.Add(this.btn_updateGraphPicture);
            this.groupBoxFull.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFull.Name = "groupBoxFull";
            this.groupBoxFull.Size = new System.Drawing.Size(606, 422);
            this.groupBoxFull.TabIndex = 1;
            this.groupBoxFull.TabStop = false;
            this.groupBoxFull.Enter += new System.EventHandler(this.groupBoxFull_Enter);
            // 
            // btn_absCenter
            // 
            this.btn_absCenter.Location = new System.Drawing.Point(385, 189);
            this.btn_absCenter.Name = "btn_absCenter";
            this.btn_absCenter.Size = new System.Drawing.Size(156, 35);
            this.btn_absCenter.TabIndex = 43;
            this.btn_absCenter.Text = "Абсолютный центр графа";
            this.btn_absCenter.UseVisualStyleBackColor = true;
            this.btn_absCenter.Click += new System.EventHandler(this.btn_absCenter_Click);
            // 
            // btn_isTree
            // 
            this.btn_isTree.Location = new System.Drawing.Point(466, 148);
            this.btn_isTree.Name = "btn_isTree";
            this.btn_isTree.Size = new System.Drawing.Size(75, 35);
            this.btn_isTree.TabIndex = 7;
            this.btn_isTree.Text = "Дерево?";
            this.btn_isTree.UseVisualStyleBackColor = true;
            this.btn_isTree.Click += new System.EventHandler(this.btn_isTree_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_cycleNumber
            // 
            this.btn_cycleNumber.Location = new System.Drawing.Point(466, 105);
            this.btn_cycleNumber.Name = "btn_cycleNumber";
            this.btn_cycleNumber.Size = new System.Drawing.Size(75, 36);
            this.btn_cycleNumber.TabIndex = 33;
            this.btn_cycleNumber.Text = "Циклическое число";
            this.btn_cycleNumber.UseVisualStyleBackColor = true;
            this.btn_cycleNumber.Click += new System.EventHandler(this.btn_cycleNumber_Click);
            // 
            // btn_countComponents
            // 
            this.btn_countComponents.Location = new System.Drawing.Point(466, 63);
            this.btn_countComponents.Name = "btn_countComponents";
            this.btn_countComponents.Size = new System.Drawing.Size(75, 36);
            this.btn_countComponents.TabIndex = 7;
            this.btn_countComponents.Text = "Число ком-т св-ти";
            this.btn_countComponents.UseVisualStyleBackColor = true;
            this.btn_countComponents.Click += new System.EventHandler(this.btn_countComponents_Click);
            // 
            // btn_DFS
            // 
            this.btn_DFS.Location = new System.Drawing.Point(466, 19);
            this.btn_DFS.Name = "btn_DFS";
            this.btn_DFS.Size = new System.Drawing.Size(75, 37);
            this.btn_DFS.TabIndex = 33;
            this.btn_DFS.Text = "DFS";
            this.btn_DFS.UseVisualStyleBackColor = true;
            this.btn_DFS.Click += new System.EventHandler(this.btn_DFS_Click);
            // 
            // btn_getDiametrRadius
            // 
            this.btn_getDiametrRadius.Location = new System.Drawing.Point(385, 147);
            this.btn_getDiametrRadius.Name = "btn_getDiametrRadius";
            this.btn_getDiametrRadius.Size = new System.Drawing.Size(75, 36);
            this.btn_getDiametrRadius.TabIndex = 41;
            this.btn_getDiametrRadius.Text = "Диаметр и радиус";
            this.btn_getDiametrRadius.UseVisualStyleBackColor = true;
            this.btn_getDiametrRadius.Click += new System.EventHandler(this.btn_getDiametrRadius_Click);
            // 
            // tb_searchEdgeM2
            // 
            this.tb_searchEdgeM2.Location = new System.Drawing.Point(150, 302);
            this.tb_searchEdgeM2.Name = "tb_searchEdgeM2";
            this.tb_searchEdgeM2.Size = new System.Drawing.Size(42, 20);
            this.tb_searchEdgeM2.TabIndex = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_addVertex);
            this.groupBox2.Controls.Add(this.btn_addEdge);
            this.groupBox2.Controls.Add(this.btn_delVertex);
            this.groupBox2.Controls.Add(this.tb_delEdgeM2);
            this.groupBox2.Controls.Add(this.btn_delEdge);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_addVertex);
            this.groupBox2.Controls.Add(this.tb_addEdgeM2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_delEdgeM1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_addEdgeM1);
            this.groupBox2.Controls.Add(this.tb_addEdgeWeight);
            this.groupBox2.Controls.Add(this.tb_delVertex);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(87, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 236);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // btn_addVertex
            // 
            this.btn_addVertex.Location = new System.Drawing.Point(6, 19);
            this.btn_addVertex.Name = "btn_addVertex";
            this.btn_addVertex.Size = new System.Drawing.Size(75, 37);
            this.btn_addVertex.TabIndex = 7;
            this.btn_addVertex.Text = "Добавить вершину";
            this.btn_addVertex.UseVisualStyleBackColor = true;
            this.btn_addVertex.Click += new System.EventHandler(this.btn_addVertex_Click);
            // 
            // btn_addEdge
            // 
            this.btn_addEdge.Location = new System.Drawing.Point(6, 105);
            this.btn_addEdge.Name = "btn_addEdge";
            this.btn_addEdge.Size = new System.Drawing.Size(75, 37);
            this.btn_addEdge.TabIndex = 11;
            this.btn_addEdge.Text = "Добавить ребро";
            this.btn_addEdge.UseVisualStyleBackColor = true;
            this.btn_addEdge.Click += new System.EventHandler(this.btn_addEdge_Click);
            // 
            // btn_delVertex
            // 
            this.btn_delVertex.Location = new System.Drawing.Point(6, 62);
            this.btn_delVertex.Name = "btn_delVertex";
            this.btn_delVertex.Size = new System.Drawing.Size(75, 37);
            this.btn_delVertex.TabIndex = 23;
            this.btn_delVertex.Text = "Удалить вершину";
            this.btn_delVertex.UseVisualStyleBackColor = true;
            this.btn_delVertex.Click += new System.EventHandler(this.btn_delVertex_Click);
            // 
            // tb_delEdgeM2
            // 
            this.tb_delEdgeM2.Location = new System.Drawing.Point(167, 167);
            this.tb_delEdgeM2.Name = "tb_delEdgeM2";
            this.tb_delEdgeM2.Size = new System.Drawing.Size(39, 20);
            this.tb_delEdgeM2.TabIndex = 29;
            // 
            // btn_delEdge
            // 
            this.btn_delEdge.Location = new System.Drawing.Point(6, 148);
            this.btn_delEdge.Name = "btn_delEdge";
            this.btn_delEdge.Size = new System.Drawing.Size(75, 38);
            this.btn_delEdge.TabIndex = 8;
            this.btn_delEdge.Text = "Удалить ребро";
            this.btn_delEdge.UseVisualStyleBackColor = true;
            this.btn_delEdge.Click += new System.EventHandler(this.btn_delEdge_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Метка 1:";
            // 
            // tb_addVertex
            // 
            this.tb_addVertex.Location = new System.Drawing.Point(100, 36);
            this.tb_addVertex.Name = "tb_addVertex";
            this.tb_addVertex.Size = new System.Drawing.Size(39, 20);
            this.tb_addVertex.TabIndex = 18;
            // 
            // tb_addEdgeM2
            // 
            this.tb_addEdgeM2.Location = new System.Drawing.Point(167, 123);
            this.tb_addEdgeM2.Name = "tb_addEdgeM2";
            this.tb_addEdgeM2.Size = new System.Drawing.Size(39, 20);
            this.tb_addEdgeM2.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Метка:";
            // 
            // tb_delEdgeM1
            // 
            this.tb_delEdgeM1.Location = new System.Drawing.Point(100, 167);
            this.tb_delEdgeM1.Name = "tb_delEdgeM1";
            this.tb_delEdgeM1.Size = new System.Drawing.Size(40, 20);
            this.tb_delEdgeM1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Метка 2:";
            // 
            // tb_addEdgeM1
            // 
            this.tb_addEdgeM1.Location = new System.Drawing.Point(101, 123);
            this.tb_addEdgeM1.Name = "tb_addEdgeM1";
            this.tb_addEdgeM1.Size = new System.Drawing.Size(39, 20);
            this.tb_addEdgeM1.TabIndex = 20;
            // 
            // tb_addEdgeWeight
            // 
            this.tb_addEdgeWeight.Location = new System.Drawing.Point(231, 123);
            this.tb_addEdgeWeight.Name = "tb_addEdgeWeight";
            this.tb_addEdgeWeight.Size = new System.Drawing.Size(39, 20);
            this.tb_addEdgeWeight.TabIndex = 19;
            // 
            // tb_delVertex
            // 
            this.tb_delVertex.Location = new System.Drawing.Point(99, 79);
            this.tb_delVertex.Name = "tb_delVertex";
            this.tb_delVertex.Size = new System.Drawing.Size(40, 20);
            this.tb_delVertex.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Метка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Вес:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Метка 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Метка 2:";
            // 
            // tb_adjVertices
            // 
            this.tb_adjVertices.Location = new System.Drawing.Point(87, 344);
            this.tb_adjVertices.Name = "tb_adjVertices";
            this.tb_adjVertices.Size = new System.Drawing.Size(42, 20);
            this.tb_adjVertices.TabIndex = 39;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(500, 357);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(147, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Метка 2:";
            // 
            // btn_countVertices
            // 
            this.btn_countVertices.Location = new System.Drawing.Point(385, 19);
            this.btn_countVertices.Name = "btn_countVertices";
            this.btn_countVertices.Size = new System.Drawing.Size(75, 37);
            this.btn_countVertices.TabIndex = 34;
            this.btn_countVertices.Text = "Количество вершин";
            this.btn_countVertices.UseVisualStyleBackColor = true;
            this.btn_countVertices.Click += new System.EventHandler(this.btn_countVertices_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Метка:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(453, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "label10";
            // 
            // btn_countEdges
            // 
            this.btn_countEdges.Location = new System.Drawing.Point(385, 62);
            this.btn_countEdges.Name = "btn_countEdges";
            this.btn_countEdges.Size = new System.Drawing.Size(75, 37);
            this.btn_countEdges.TabIndex = 33;
            this.btn_countEdges.Text = "Количество ребер";
            this.btn_countEdges.UseVisualStyleBackColor = true;
            this.btn_countEdges.Click += new System.EventHandler(this.btn_countEdges_Click);
            // 
            // btn_adjVertices
            // 
            this.btn_adjVertices.Location = new System.Drawing.Point(6, 328);
            this.btn_adjVertices.Name = "btn_adjVertices";
            this.btn_adjVertices.Size = new System.Drawing.Size(75, 37);
            this.btn_adjVertices.TabIndex = 32;
            this.btn_adjVertices.Text = "Смежные вершины";
            this.btn_adjVertices.UseVisualStyleBackColor = true;
            this.btn_adjVertices.Click += new System.EventHandler(this.btn_adjVertices_Click);
            // 
            // tb_searchVertex
            // 
            this.tb_searchVertex.Location = new System.Drawing.Point(87, 258);
            this.tb_searchVertex.Name = "tb_searchVertex";
            this.tb_searchVertex.Size = new System.Drawing.Size(41, 20);
            this.tb_searchVertex.TabIndex = 31;
            // 
            // tb_searchEdgeM1
            // 
            this.tb_searchEdgeM1.Location = new System.Drawing.Point(87, 302);
            this.tb_searchEdgeM1.Name = "tb_searchEdgeM1";
            this.tb_searchEdgeM1.Size = new System.Drawing.Size(42, 20);
            this.tb_searchEdgeM1.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Метка:";
            // 
            // btn_getPower
            // 
            this.btn_getPower.Location = new System.Drawing.Point(385, 105);
            this.btn_getPower.Name = "btn_getPower";
            this.btn_getPower.Size = new System.Drawing.Size(75, 36);
            this.btn_getPower.TabIndex = 24;
            this.btn_getPower.Text = "Степень графа";
            this.btn_getPower.UseVisualStyleBackColor = true;
            this.btn_getPower.Click += new System.EventHandler(this.btn_getPower_Click);
            // 
            // btn_searchEdge
            // 
            this.btn_searchEdge.Location = new System.Drawing.Point(6, 285);
            this.btn_searchEdge.Name = "btn_searchEdge";
            this.btn_searchEdge.Size = new System.Drawing.Size(75, 37);
            this.btn_searchEdge.TabIndex = 9;
            this.btn_searchEdge.Text = "Поиск ребра";
            this.btn_searchEdge.UseVisualStyleBackColor = true;
            this.btn_searchEdge.Click += new System.EventHandler(this.btn_searchEdge_Click);
            // 
            // btn_searchVertex
            // 
            this.btn_searchVertex.Location = new System.Drawing.Point(6, 242);
            this.btn_searchVertex.Name = "btn_searchVertex";
            this.btn_searchVertex.Size = new System.Drawing.Size(75, 37);
            this.btn_searchVertex.TabIndex = 10;
            this.btn_searchVertex.Text = "Поиск вершины по метке";
            this.btn_searchVertex.UseVisualStyleBackColor = true;
            this.btn_searchVertex.Click += new System.EventHandler(this.btn_searchVertex_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Метка 1:";
            // 
            // btn_updateGraphPicture
            // 
            this.btn_updateGraphPicture.Location = new System.Drawing.Point(6, 379);
            this.btn_updateGraphPicture.Name = "btn_updateGraphPicture";
            this.btn_updateGraphPicture.Size = new System.Drawing.Size(75, 37);
            this.btn_updateGraphPicture.TabIndex = 4;
            this.btn_updateGraphPicture.Text = "Обновить граф";
            this.btn_updateGraphPicture.UseVisualStyleBackColor = true;
            this.btn_updateGraphPicture.Click += new System.EventHandler(this.btn_updateGraphPicture_Click);
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
            this.pb_graphPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_graphPicture.TabIndex = 5;
            this.pb_graphPicture.TabStop = false;
            this.pb_graphPicture.Click += new System.EventHandler(this.pb_graphPicture_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnImportAdjacenctMatrix);
            this.groupBox3.Controls.Add(this.btn_importIncidenceMatrix);
            this.groupBox3.Controls.Add(this.btn_inportMergeList);
            this.groupBox3.Controls.Add(this.btn_ImportEdgesList);
            this.groupBox3.Controls.Add(this.btn_importBerzh);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(87, 236);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pb_graphPicture);
            this.Controls.Add(this.groupBoxFull);
            this.Controls.Add(this.btn_exit);
            this.Name = "Form1";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFull.ResumeLayout(false);
            this.groupBoxFull.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_graphPicture)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox groupBoxFull;
        private System.Windows.Forms.Button btnImportAdjacenctMatrix;
        private System.Windows.Forms.Button btn_importIncidenceMatrix;
        private System.Windows.Forms.Button btn_updateGraphPicture;
        private System.Windows.Forms.PictureBox pb_graphPicture;
        private System.Windows.Forms.Button btn_inportMergeList;
        private System.Windows.Forms.Button btn_ImportEdgesList;
        private System.Windows.Forms.Button btn_importBerzh;
        private System.Windows.Forms.Button btn_addVertex;
        private System.Windows.Forms.Button btn_delEdge;
        private System.Windows.Forms.Button btn_searchEdge;
        private System.Windows.Forms.Button btn_searchVertex;
        private System.Windows.Forms.Button btn_addEdge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_delVertex;
        private System.Windows.Forms.TextBox tb_addVertex;
        private System.Windows.Forms.TextBox tb_addEdgeWeight;
        private System.Windows.Forms.TextBox tb_addEdgeM1;
        private System.Windows.Forms.TextBox tb_delEdgeM1;
        private System.Windows.Forms.TextBox tb_addEdgeM2;
        private System.Windows.Forms.TextBox tb_searchVertex;
        private System.Windows.Forms.TextBox tb_searchEdgeM1;
        private System.Windows.Forms.TextBox tb_delEdgeM2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_getPower;
        private System.Windows.Forms.Button btn_delVertex;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_searchEdgeM2;
        private System.Windows.Forms.TextBox tb_adjVertices;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_countVertices;
        private System.Windows.Forms.Button btn_countEdges;
        private System.Windows.Forms.Button btn_adjVertices;
        private System.Windows.Forms.Button btn_getDiametrRadius;
        private System.Windows.Forms.Button btn_DFS;
        private System.Windows.Forms.Button btn_countComponents;
        private System.Windows.Forms.Button btn_cycleNumber;
        private System.Windows.Forms.Button btn_isTree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_absCenter;
    }
}

