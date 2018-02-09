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
                        if (!haveEdges) {
                            graphText.Add(graphVerticesNames[i] + ";");
                        }
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
                        if (!haveEdges) {
                            graphText.Add(graphVerticesNames[i] + ";");
                        }
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
            pb_graphPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            pb_graphPicture.Image = img;
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
    }
}