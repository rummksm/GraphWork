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
using System.Diagnostics;

namespace GraphWorkFinal {
    public partial class Form1 : Form {
        public Form1() {
           

            InitializeComponent();
           
        }


        List<List<int>> graph = new List<List<int>>();
        List<string> graphVerticesNames = new List<string>();
        bool graphOrientated = false;


        private void btn_exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        public int[,] ConvertGraphToAdjMatrix() {
            int vertCount = graphVerticesNames.Count();
            var adjMatrix = new int[vertCount, vertCount];
            for (int i = 0; i < vertCount; i++) {
                for (int j = 0; j < vertCount; j++)
                    adjMatrix[i, j] = graph[i][j];
            }
            return adjMatrix;
        }

        /// <summary>
        /// Конвертация к представлению графа + определение его ориентированности
        /// </summary>
        /// <param name="adjMatrix"></param>
        public void ConvertToGraph(int[,] adjMatrix) {
            int vertCount = adjMatrix.GetLength(0);
            for (int i = 0; i < vertCount; i++) {
                graph.Add(new List<int>());
                for (int j = 0; j < vertCount; j++) {
                    graph[i].Add(adjMatrix[i, j]);
                }
            }
            for (int i = 0; i < vertCount; i++)
                for (int j = 0; j < vertCount; j++)
                    if (adjMatrix[i, j] != adjMatrix[j, i]) {
                        graphOrientated = true;
                        return;
                    }
        }

        private void btnImportAdjacenctMatrix_Click(object sender, EventArgs e) {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Файл txt|*.txt";
            if (openDialog.ShowDialog() == DialogResult.OK) {
                string[] fileContent = File.ReadAllLines(openDialog.FileName, System.Text.Encoding.Default);
                graph.Clear();
                graphVerticesNames.Clear();
                graphOrientated = false;
                string[] vertNames = fileContent[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < vertNames.Count(); i++)
                    graphVerticesNames.Add(vertNames[i]);
                int vertCount = graphVerticesNames.Count();
                var adjMatrix = new int[vertCount, vertCount];
                for (int i = 0; i < vertCount; i++) {
                    int[] row = fileContent[i + 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                    for (int j = 0; j < vertCount; j++) {
                        adjMatrix[i, j] = row[j];
                    }
                }
                ConvertToGraph(adjMatrix);
            }
        }
        private void btn_inportMergeList_Click(object sender, EventArgs e) {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Файл txt|*.txt";
            if (openDialog.ShowDialog() == DialogResult.OK) {
                string[] fileContent = File.ReadAllLines(openDialog.FileName, System.Text.Encoding.Default);
                graph.Clear();
                graphVerticesNames.Clear();
                graphOrientated = false;
                var vert = new List<int>();
                var adj = new List<List<int>>();
                string[] verticesNames = fileContent[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < verticesNames.Count(); i++)
                    graphVerticesNames.Add(verticesNames[i]);
                int[] row = fileContent[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int i = 0; i < row.Count(); i++)
                    vert.Add(row[i]);
                for (int i = 0; i < 3; i++)
                    adj.Add(new List<int>());
                for (int i = 0; i < 3; i++) {
                    row = fileContent[i + 2].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                    for (int j = 0; j < row.Count(); j++)
                        adj[i].Add(row[j]);
                }
                ConvertToGraph(ConvertMergeListToAdjacencyMatrix(vert, adj));
            }
        }

        public int[,] ConvertMergeListToAdjacencyMatrix(List<int> vertices, List<List<int>> adjs) {
            int verticesCount = vertices.Count();
            var adjacencyMatrix = new int[verticesCount, verticesCount];
            var edgesCount = adjs[0].Count();
            for (int i = 0; i < verticesCount; i++) {
                int firstEdgeIndex = vertices[i];
                if (firstEdgeIndex == -1)
                    continue;
                int secondEdgeIndex = -1;
                if (i == verticesCount - 1)
                    secondEdgeIndex = edgesCount;
                else
                    secondEdgeIndex = vertices[i + 1];
                if (secondEdgeIndex == -1) {
                    for (int k = i + 1; k < verticesCount; k++)
                        if (vertices[k] != -1) {
                            secondEdgeIndex = vertices[k];
                            break;
                        }
                }
                if (secondEdgeIndex == -1)
                    secondEdgeIndex = edgesCount;
                for (int j = firstEdgeIndex; j < secondEdgeIndex; j++) {
                    adjacencyMatrix[i, adjs[0][j]] = adjs[1][j];
                }
            }
            return adjacencyMatrix;
        }

        private void btn_importIncidenceMatrix_Click(object sender, EventArgs e) {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Файл txt|*.txt";
            if (openDialog.ShowDialog() == DialogResult.OK) {
                string[] fileContent = File.ReadAllLines(openDialog.FileName, System.Text.Encoding.Default);
                graph.Clear();
                graphVerticesNames.Clear();
                graphOrientated = false;
                string[] vertNames = fileContent[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var countVertices = vertNames.Count();
                for (int i = 0; i < countVertices; i++)
                    graphVerticesNames.Add(vertNames[i]);
                int[] row = fileContent[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                int countEdges = row.Count();
                var incidenceMatrix = new int[countVertices, countEdges];
                for (int i = 0; i < countVertices; i++) {
                    row = fileContent[i + 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                    for (int j = 0; j < countEdges; j++) {
                        incidenceMatrix[i, j] = row[j];
                    }
                }
                var adjacencyMatrix = new int[countVertices, countVertices];
                for (int i = 0; i < countEdges; i++) {
                    int firstVertex = -1, secondVertex = -1;
                    for (int j = 0; j < countVertices; j++) {
                        if (incidenceMatrix[j, i] != 0 && firstVertex == -1)
                            firstVertex = j;
                        else if (incidenceMatrix[j, i] != 0 && firstVertex != -1) {
                            secondVertex = j;
                            break;
                        }
                    }
                    if (incidenceMatrix[firstVertex, i] == incidenceMatrix[secondVertex, i]) {
                        adjacencyMatrix[firstVertex, secondVertex] = adjacencyMatrix[secondVertex, firstVertex] = incidenceMatrix[firstVertex, i];
                    }
                    else {
                        if (incidenceMatrix[firstVertex, i] < incidenceMatrix[secondVertex, i]) {
                            adjacencyMatrix[secondVertex, firstVertex] = incidenceMatrix[secondVertex, i];
                        }
                        else {
                            adjacencyMatrix[firstVertex, secondVertex] = incidenceMatrix[firstVertex, i];
                        }
                    }
                }
                ConvertToGraph(adjacencyMatrix);
            }
        }

        public void UpdateGraphPicture() {
           
            var fileGraphCode = new StreamWriter(@"GraphCode.dot");
            var fileBatCode = new StreamWriter("GraphBat.bat");
            var graphText = new List<string>();
            if (graphOrientated) {
                graphText.Add("digraph G{");
                var adjMatrix = ConvertGraphToAdjMatrix();
                int vertCount = graphVerticesNames.Count();
                bool haveEdges = false;
                for (int i = 0; i < vertCount; i++) {
                    for (int j = 0; j < vertCount; j++) {
                        if (adjMatrix[i, j] != 0) {
                            haveEdges = true;
                            graphText.Add(graphVerticesNames[i] + "->" + graphVerticesNames[j] + " [label =\"" + adjMatrix[i, j] + "\"];");
                        }
                    }
                    if (!haveEdges) {
                        graphText.Add(graphVerticesNames[i] + ";");
                    }
                    haveEdges = false;
                }
                graphText.Add("}");
            }
            if (!graphOrientated) {
                graphText.Add("graph G{");
                var adjMatrix = ConvertGraphToAdjMatrix();
                int vertCount = graphVerticesNames.Count();
                bool haveEdges = false;
                for (int i = 0; i < vertCount; i++) {
                    for (int j = i; j < vertCount; j++) {
                        if (adjMatrix[i, j] != 0) {
                            haveEdges = true;
                            graphText.Add(graphVerticesNames[i] + "--" + graphVerticesNames[j] + " [label =\"" + adjMatrix[i, j] + "\"];");
                        }
                    }
                    if (!haveEdges) {
                        graphText.Add(graphVerticesNames[i] + ";");
                    }
                    haveEdges = false;
                }
                graphText.Add("}");
            }
            foreach (var elem in graphText) {
                fileGraphCode.WriteLine(elem);
            }
            fileGraphCode.Close();
            fileBatCode.Write("start " + Directory.GetCurrentDirectory() + @"\Graphviz\bin\dot -Tpng GraphCode.dot -o GraphPicture.png");
            fileBatCode.Close();
            var startInfo = new ProcessStartInfo(@"GraphBat.bat");
            startInfo.WorkingDirectory = Path.GetDirectoryName(startInfo.FileName);
            Process.Start(startInfo);
            System.Threading.Thread.Sleep(2000);
            var fs = new System.IO.FileStream(@"GraphPicture.png", System.IO.FileMode.Open);
            var img = System.Drawing.Image.FromStream(fs);
            fs.Close();
            //pb_graphPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_graphPicture.Image = img;
            pb_graphPicture.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void btn_updateGraphPicture_Click(object sender, EventArgs e) {
            UpdateGraphPicture();
        }

        private void btn_ImportEdgesList_Click(object sender, EventArgs e) {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Файл txt|*.txt";
            if (openDialog.ShowDialog() == DialogResult.OK) {
                string[] fileContent = File.ReadAllLines(openDialog.FileName, System.Text.Encoding.Default);
                graph.Clear();
                graphVerticesNames.Clear();
                graphOrientated = false;
                string[] verticesNames = fileContent[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < verticesNames.Count(); i++)
                    graphVerticesNames.Add(verticesNames[i]);
                int countVertices = verticesNames.Count();
                var adjacencyMatrix = new int[countVertices, countVertices];
                int[] row1 = fileContent[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                int[] row2 = fileContent[2].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                int[] row3 = fileContent[3].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int i = 0; i < row1.Count(); i++) {
                    adjacencyMatrix[row1[i], row2[i]] = row3[i];
                }
                ConvertToGraph(adjacencyMatrix);
            }
        }

        private void btn_importBerzh_Click(object sender, EventArgs e) {
            var openDialog = new OpenFileDialog();
            openDialog.Filter = "Файл txt|*.txt";
            if (openDialog.ShowDialog() == DialogResult.OK) {
                string[] fileContent = File.ReadAllLines(openDialog.FileName, System.Text.Encoding.Default);
                graph.Clear();
                graphVerticesNames.Clear();
                graphOrientated = false;
                string[] verticesNames = fileContent[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < verticesNames.Count(); i++)
                    graphVerticesNames.Add(verticesNames[i]);
                int countVertices = verticesNames.Count();
                var adjacencyMatrix = new int[countVertices, countVertices];
                for (int i = 0; i < countVertices; i++) {
                    int[] rowVert = fileContent[i + 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                    int[] rowWeight = fileContent[countVertices + i + 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                    for (int j = 0; j < rowVert[0]; j++) {
                        adjacencyMatrix[i, rowVert[j + 1]] = rowWeight[j + 1];
                    }
                }
                ConvertToGraph(adjacencyMatrix);
            }
        }

        private void btn_addVertex_Click(object sender, EventArgs e) {
            if (graphVerticesNames.Contains(tb_addVertex.Text) || tb_addVertex.Text == "") {
                MessageBox.Show("Вершина задана неверно!", "Ошибка");
            }
            else {
                int vertexCount = graphVerticesNames.Count();
                graph.Add(new List<int>());
                for (int i = 0; i < vertexCount; i++)
                    graph[i].Add(0);
                for (int i = 0; i < vertexCount + 1; i++)
                    graph[vertexCount].Add(0);
                graphVerticesNames.Add(tb_addVertex.Text);
                MessageBox.Show("Вершина добавлена!", "Добавление вершины");
            }
        }

        private void btn_addEdge_Click(object sender, EventArgs e) {
            if (!graphVerticesNames.Contains(tb_addEdgeM1.Text) || !graphVerticesNames.Contains(tb_addEdgeM2.Text)) {
                MessageBox.Show("Такой пары вершин в графе нет", "Ошибка");
                return;
            }
            int fromVertexId = graphVerticesNames.IndexOf(tb_addEdgeM1.Text);
            int toVertexId = graphVerticesNames.IndexOf(tb_addEdgeM2.Text);
            if (graph[fromVertexId][toVertexId] != 0) {
                MessageBox.Show("Такое ребро уже есть!", "Ошибка");
                return;
            }
            int weight = int.Parse(tb_addEdgeWeight.Text);
            if (!graphOrientated) {
                graph[fromVertexId][toVertexId] = graph[toVertexId][fromVertexId] = weight;
                MessageBox.Show("Неориентированное ребро добавлено", "Добавление ребра");
            }
            else {
                graph[fromVertexId][toVertexId] = weight;
                MessageBox.Show("Ориентированное ребро добавлено", "Добавление ребра");
            }
        }

        private void btn_delEdge_Click(object sender, EventArgs e) {
            if (!graphVerticesNames.Contains(tb_delEdgeM1.Text) || !graphVerticesNames.Contains(tb_delEdgeM2.Text)) {
                MessageBox.Show("Такой пары вершин в графе нет", "Ошибка");
                return;
            }
            int fromVertexId = graphVerticesNames.IndexOf(tb_delEdgeM1.Text);
            int toVertexId = graphVerticesNames.IndexOf(tb_delEdgeM2.Text);
            if (graph[fromVertexId][toVertexId] == 0) {
                MessageBox.Show("Такого ребра в графе нет!", "Ошибка");
                return;
            }
            if (!graphOrientated) {
                graph[fromVertexId][toVertexId] = graph[toVertexId][fromVertexId] = 0;
                MessageBox.Show("Неориентированное ребро удалено", "Удаление ребра");
            }
            else {
                graph[fromVertexId][toVertexId] = 0;
                MessageBox.Show("Ориентированное ребро удалено", "Удаление ребра");
            }
        }

        private void btn_delVertex_Click(object sender, EventArgs e) {
            if (!graphVerticesNames.Contains(tb_delVertex.Text) || tb_delVertex.Text == "") {
                MessageBox.Show("Вершина задана неверно!", "Ошибка");
                return;
            }
            int vertexId = graphVerticesNames.IndexOf(tb_delVertex.Text);
            graph.RemoveAt(vertexId);
            graphVerticesNames.RemoveAt(vertexId);
            int countVertices = graphVerticesNames.Count();
            for (int i = 0; i < countVertices; i++) {
                graph[i].RemoveAt(vertexId);
            }
            MessageBox.Show("Вершина удалена!", "Удаление вершины");
        }

        private void btn_searchVertex_Click(object sender, EventArgs e) {
            if (graphVerticesNames.Contains(tb_searchVertex.Text))
                MessageBox.Show("Такая вершина в графе есть!", "Поиск вершины");
            else
                MessageBox.Show("Такой вершины в графе нет!", "Поиск вершины");
        }

        private void btn_searchEdge_Click(object sender, EventArgs e) {
            if (!graphVerticesNames.Contains(tb_searchEdgeM1.Text) || !graphVerticesNames.Contains(tb_searchEdgeM2.Text)) {
                MessageBox.Show("Такой пары вершин в графе нет", "Ошибка");
                return;
            }
            int fromVertexId = graphVerticesNames.IndexOf(tb_searchEdgeM1.Text);
            int toVertexId = graphVerticesNames.IndexOf(tb_searchEdgeM2.Text);
            int weight = graph[fromVertexId][toVertexId];
            if (weight != 0) {
                MessageBox.Show($"Ребро между данными вершинами есть. Его вес: {weight}", "Поиск ребра");
            }
            else {
                MessageBox.Show("Ребра между данными вершинами нет", "Поиск ребра");
            }
        }

        private void btn_adjVertices_Click(object sender, EventArgs e) {
            if (!graphVerticesNames.Contains(tb_adjVertices.Text)) {
                MessageBox.Show("Такой вершины в графе нет", "Ошибка");
                return;
            }
            int vertexId = graphVerticesNames.IndexOf(tb_adjVertices.Text);
            string s = "";
            for (int i = 0; i < graphVerticesNames.Count(); i++) {
                if (graph[vertexId][i] != 0)
                    s += graphVerticesNames[i] + " ";
            }
            if (s != "")
                MessageBox.Show($"Список смежных с данной вершин: {s} ", "Поиск смежных вершин");
            else
                MessageBox.Show("Смежных вершин нет!", "Поиск смежных вершин");
        }

        private void btn_countVertices_Click(object sender, EventArgs e) {
            MessageBox.Show($"Число вершин в графе = {graphVerticesNames.Count()}", "Подсчет количества вершин");
        }

        public int GetCountEdges() {
            int countVertices = graphVerticesNames.Count();
            int countEdges = 0;
            if (!graphOrientated) {
                for (int i = 0; i < countVertices; i++)
                    for (int j = i; j < countVertices; j++)
                        if (graph[i][j] != 0)
                            countEdges++;
            }
            else {
                for (int i = 0; i < countVertices; i++)
                    for (int j = 0; j < countVertices; j++)
                        if (graph[i][j] != 0)
                            countEdges++;
            }
            return countEdges;
        }

        private void btn_countEdges_Click(object sender, EventArgs e) {
            MessageBox.Show($"Число ребер в графе = {GetCountEdges()}", "Число ребер графа");
        }

        private void btn_getPower_Click(object sender, EventArgs e) {
            int countVertices = graphVerticesNames.Count();
            int maxPower = 0;
            int currentPower = 0;
            if (!graphOrientated) {
                for (int i = 0; i < countVertices; i++) {
                    for (int j = 0; j < countVertices; j++) {
                        if (graph[i][j] != 0)
                            currentPower++;
                        if (graph[i][j] != 0 && i == j)
                            currentPower++;
                    }
                    if (currentPower > maxPower)
                        maxPower = currentPower;
                    currentPower = 0;
                }

            }
            if (graphOrientated) {
                //степень выхода и выхода
                for (int i = 0; i < countVertices; i++) {
                    for (int j = 0; j < countVertices; j++) {
                        if (graph[i][j] != 0)
                            currentPower++;
                        if (graph[j][i] != 0)
                            currentPower++;
                    }
                    if (currentPower > maxPower)
                        maxPower = currentPower;
                    currentPower = 0;
                }
            }
            MessageBox.Show($"Степень графа равна {maxPower}", "Степень графа");
        }

        public int[,] GetDistanceMatrix() {
            int countVertices = graphVerticesNames.Count();
            var distances = new int[countVertices, countVertices];
            int addPath = 99999; //добавка для отсутствующих путей
            for (int i = 0; i < countVertices; i++) {
                for (int j = 0; j < countVertices; j++) {
                    if (graph[i][j] != 0)
                        distances[i, j] = graph[i][j];
                    else if (i != j)
                        distances[i, j] = addPath;
                }
            }
            for (int k = 0; k < countVertices; k++) {
                for (int i = 0; i < countVertices; i++) {
                    for (int j = 0; j < countVertices; j++)
                        distances[i, j] = Math.Min(distances[i, j], distances[i, k] + distances[k, j]);
                }
            }
            return distances;
        }

        private void btn_getDiametrRadius_Click(object sender, EventArgs e) {

            int countVertices = graphVerticesNames.Count();
            // Флойд - Уоршелл
            var distances = GetDistanceMatrix();
            int addPath = 99999;
            var ekscentrisitets = new List<int>();
            for (int i = 0; i < countVertices; i++) {
                int maxValue = 0;
                for (int j = 0; j < countVertices; j++) {
                    if (distances[i, j] > maxValue)
                        maxValue = distances[i, j];
                }
                ekscentrisitets.Add(maxValue);
            }
            int radius = ekscentrisitets.Min();
            int diametr = ekscentrisitets.Max();
            string rad = "";
            string diam = "";
            if (radius == addPath)
                rad = "Бесконечность";
            else
                rad = radius.ToString();
            if (diametr == addPath)
                diam = "Бесконечность";
            else
                diam = diametr.ToString();
            MessageBox.Show($"Радиус графа = {rad}, диаметр графа = {diam}", "Радиус и диаметр графа");
        }

        public void DFS(bool[] used, int v, List<string> dfsVertices) {
            used[v] = true;
            dfsVertices.Add(graphVerticesNames[v]);
            for (int i = 0; i < graphVerticesNames.Count(); i++) {
                if (graph[v][i] != 0 && !used[i])
                    DFS(used, i, dfsVertices);
            }
            dfsVertices.Insert(0, "(");
            dfsVertices.Add(")");
        }

        private void btn_DFS_Click(object sender, EventArgs e) {
            int countVertices = graphVerticesNames.Count();
            var dfsVertices = new List<string>();
            var used = new bool[countVertices];
            for (int i = 0; i < countVertices; i++) {
                if (!used[i]) {
                    dfsVertices.Insert(0, "(");
                    if (i != 0) {
                        dfsVertices.Add(")");
                    }
                    DFS(used, i, dfsVertices);
                }
            }
            dfsVertices.Add(")");
            string output = "";
            for (int i = 0; i < dfsVertices.Count() - 1; i++) {
                if (dfsVertices[i] == ")" && dfsVertices[i + 1] == ")") {
                    dfsVertices.RemoveAt(i);
                    dfsVertices.RemoveAt(0);
                    i -= 2;
                }
            }
            foreach (var elem in dfsVertices)
                output += elem + " ";
            MessageBox.Show($"Порядок обохода вершин по алгоритму DFS: {output}", "Обход графа в глубину");
        }

        private void groupBoxFull_Enter(object sender, EventArgs e) {

        }
        /// <summary>
        /// число обычных компонент связности
        /// </summary>
        /// <returns></returns>
        public int GetCountLowComponents() {
            int countComponents = 0;
            var dfsVertices = new List<string>();
            int countVertices = graphVerticesNames.Count();
            var used = new bool[countVertices];
            for (int i = 0; i < countVertices; i++) {
                if (!used[i]) {
                    countComponents++;
                    DFS(used, i, dfsVertices);
                }

            }
            return countComponents;
        }

        public int GetCountHighComponents() {
            int countComponents = 0;
            var distMatrix = GetDistanceMatrix();
            int countVertices = distMatrix.GetLength(0);
            var dostMatrix = new bool[countVertices, countVertices];
            var dostMatrixTranspon = new bool[countVertices, countVertices];
            for (int i = 0; i < countVertices; i++) {
                for (int j = 0; j < countVertices; j++) {
                    if (i == j)
                        dostMatrix[i, j] = true;
                    else if (distMatrix[i, j] != 99999)
                        dostMatrix[i, j] = true;
                }
            }
            for (int i = 0; i < countVertices; i++) {
                for (int j = 0; j < countVertices; j++) {
                    dostMatrixTranspon[i, j] = dostMatrix[j, i];
                }
            }
            var finalDostMatrix = new List<List<bool>>();
            for (int i = 0; i < countVertices; i++) {
                finalDostMatrix.Add(new List<bool>());
                for (int j = 0; j < countVertices; j++) {
                    finalDostMatrix[i].Add(dostMatrix[i, j] && dostMatrixTranspon[i, j]);
                }
            }
            while (true) {
                var vec = new List<bool>();
                for (int i = 0; i < finalDostMatrix[0].Count; i++)
                    vec.Add(finalDostMatrix[0][i]);
                countComponents++;
                var exit = vec.IndexOf(false);
                if (exit == -1)
                    break;
                for (int i = 0; i < vec.Count; i++) {
                    if (vec[i]) {
                        for (int j = 0; j < vec.Count; j++) {
                            finalDostMatrix[j].RemoveAt(i);
                        }
                        finalDostMatrix.RemoveAt(i);
                        vec.RemoveAt(i);
                        i--;
                    }
                }
            }
            return countComponents;
        }

        private void btn_countComponents_Click(object sender, EventArgs e) {
            if (!graphOrientated) {
                MessageBox.Show($"Число компонентов связности неориентированного графа = {GetCountLowComponents()}");
            }
            if (graphOrientated) {
                MessageBox.Show($"Число компонент сильной связности ориентированного графа = {GetCountHighComponents()}");

            }
        }

        public int GetUnOrientatedCycleNumber() {
            int countEdges = GetCountEdges();
            int countVertices = graphVerticesNames.Count();
            int countComponents = GetCountLowComponents();
            int cycleNumber = countEdges - countVertices + countComponents;
            return cycleNumber;
        }

        /// <summary>
        /// Число ребер на удаление для орграфа
        /// </summary>
        /// <returns></returns>
        public int CountOrientatedDelEdgesCycleNumber() {
            int countDelEdges = 0;
            int countVertices = graphVerticesNames.Count();
            var unOrientatedMatrix = new int[countVertices, countVertices];
            for (int i = 0; i < countVertices; i++) {
                for (int j = 0; j < countVertices; j++) {
                    if (graph[i][j] != 0 && unOrientatedMatrix[i, j] == 0) {
                        unOrientatedMatrix[i, j] = unOrientatedMatrix[j, i] = graph[i][j];
                        continue;
                    }
                    if (graph[i][j] != 0 && unOrientatedMatrix[i, j] != 0)
                        countDelEdges++;
                }
            }

            var graphCopy = new List<List<int>>();
            for (int i = 0; i < countVertices; i++) {
                graphCopy.Add(new List<int>());
                for (int j = 0; j < countVertices; j++)
                    graphCopy[i].Add(graph[i][j]);
            }
            graph.Clear();
            for (int i = 0; i < countVertices; i++) {
                graph.Add(new List<int>());
                for (int j = 0; j < countVertices; j++)
                    graph[i].Add(unOrientatedMatrix[i, j]);
            }
            graphOrientated = false;
            var cycleNumber = GetUnOrientatedCycleNumber();
            graphOrientated = true;
            graph.Clear();
            for (int i = 0; i < countVertices; i++) {
                graph.Add(new List<int>());
                for (int j = 0; j < countVertices; j++)
                    graph[i].Add(graphCopy[i][j]);
            }
            countDelEdges += cycleNumber;
            return countDelEdges;
        }

        public int GetOrientatedCycleNumber() {
            return CountOrientatedDelEdgesCycleNumber();
        }

        private void btn_cycleNumber_Click(object sender, EventArgs e) {
            if (!graphOrientated) {
                MessageBox.Show($"Циклическое число графа равно {GetUnOrientatedCycleNumber()}", "Циклическое число графа");
            }
            if (graphOrientated) {
                MessageBox.Show($"Циклическое число графа равно {GetOrientatedCycleNumber()}", "Циклическое число графа");
            }
        }

        private void btn_isTree_Click(object sender, EventArgs e) {
            if (!graphOrientated) {
                int countComponents = GetCountLowComponents();
                int countEdges = GetCountEdges();
                int verticesCount = graphVerticesNames.Count();
                if (verticesCount - countEdges == 1 && countComponents == 1) {
                    MessageBox.Show("Данный неориентированный граф является деревом!");
                }
                else {
                    MessageBox.Show("Данный неориентированный граф не является деревом!");
                }
            }

            if (graphOrientated) {
                if (GetUnOrientatedCycleNumber() == 0 && graphVerticesNames.Count() == GetCountEdges() + 1) {
                    MessageBox.Show("Данный ориентированный граф является деревом!");
                }
                else {
                    MessageBox.Show("Данный ориентированный граф не является деревом!");
                }
            }
        }

        private void btn_absCenter_Click(object sender, EventArgs e) {
            if (graphOrientated || GetCountLowComponents() != 1) {
                MessageBox.Show("Граф должен быть неориентированным и связным!", "Ошибка");
            }
            else {
                var test = new List<string>();
                var D = GetDistanceMatrix();
                var vertexAndRad = new Dictionary<string, int>();
                double minmax = int.MaxValue; // расстояние от абсолютного центра r до самой удаленной вершины
                int r = 0;
                int MAX = 0;
                int countVert = graphVerticesNames.Count();
                for (int i = 0; i < countVert; i++) {
                    MAX = D[i, 0];
                    for (int j = 1; j < countVert; j++) {
                        if (D[i, j] > MAX)
                            MAX = D[i, j];
                    }
                    vertexAndRad.Add(graphVerticesNames[i], MAX);
                    if (minmax > MAX) {
                        r = i;
                        minmax = MAX;
                    }
                }
                double centerRad = minmax;
                var vertices = new List<string>();
                foreach (var elem in vertexAndRad.Keys)
                    if (vertexAndRad[elem] == minmax)
                        vertices.Add(elem);
                
                int di = 0, dj = 0;
                for (int i = 0; i < countVert - 1; i++)
                    for (int j = i + 1; j < countVert; j++)
                        if (graph[i][j] != 0) { //дуга существует
                            int MaxI = 0; //расстояние от i до самой удаленной вершины
                            int MaxJ = 0; //расстояние от j до самой удаленной вершины
                            for (int k = 0; k < countVert; k++)
                                if (k != i && k != j) {
                                    if (D[i, k] < 99999)
                                        di = D[i, k];
                                    if (D[j, k] < 99999)
                                        dj = D[j, k];
                                    if (di > dj) {
                                        if (dj > MaxJ)
                                            MaxJ = dj;
                                    }
                                    else {
                                        if (di > MaxI)
                                            MaxI = di;
                                    }
                                }

                            double dist = (double)(MaxI + graph[i][j] + MaxJ) / 2; //Расстояние между внутренними точками дуги i-j и максимально удаленной от них вершиной равно
                            var x = dist - MaxI;
                            if (dist <= minmax && x > 0 && graph[i][j] - x > 0) { //мягкое условие. Если мягкое условие, то может найти абс. центр с радиусом = радиусу центра в вершине.
                                minmax = dist;
                                test.Add("Ребро (" + graphVerticesNames[i] + "-" + graphVerticesNames[j] + "); удаление точки от вершины " + graphVerticesNames[i] + " = " + x.ToString() + "; радиус = " + minmax.ToString());
                            }
                        }
                if (test.Count() == 0) {
                    string s = "";
                    foreach (var elem in vertices) {
                        s += elem + " ";
                    }
                    MessageBox.Show($"Абсолютный центр графа находится в вершинах {s}, радиус равен {minmax}", "Абсолютный центр графа");
                }
                else {
                    string s = "";
                    foreach (var elem in test) {
                        s += elem + "\n";
                    }
                    if (minmax == centerRad) {
                        s += "Абсолютный центр графа находится в вершинах:\n";
                        foreach (var elem in vertices) {
                            s += elem + " ";
                        }
                        s += "\n";
                    }

                    MessageBox.Show($"Абсолютный центр графа: \n{s}", "Абсолютыный центр графа");
                }
            }

        }

        private void pb_graphPicture_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
          
        }
    }
}