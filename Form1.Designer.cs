
namespace MiningSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPrepareFiles = new System.Windows.Forms.GroupBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.nudGain = new System.Windows.Forms.NumericUpDown();
            this.btnGain = new System.Windows.Forms.Button();
            this.btnLargeDataSet = new System.Windows.Forms.Button();
            this.btnSmallDataSet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.btnLf = new System.Windows.Forms.Button();
            this.btnSf = new System.Windows.Forms.Button();
            this.gbNormalizare = new System.Windows.Forms.GroupBox();
            this.btnNormalizare = new System.Windows.Forms.Button();
            this.rbNormSum1 = new System.Windows.Forms.RadioButton();
            this.rbNormNom = new System.Windows.Forms.RadioButton();
            this.rbNormCS = new System.Windows.Forms.RadioButton();
            this.rbNormB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDistE = new System.Windows.Forms.RadioButton();
            this.rbDisMan = new System.Windows.Forms.RadioButton();
            this.rbDisMin = new System.Windows.Forms.RadioButton();
            this.rbDistCos = new System.Windows.Forms.RadioButton();
            this.btnCalcDistante = new System.Windows.Forms.Button();
            this.nUdMinkOrder = new System.Windows.Forms.NumericUpDown();
            this.gpKNN = new System.Windows.Forms.GroupBox();
            this.tbK = new System.Windows.Forms.TextBox();
            this.lbK = new System.Windows.Forms.Label();
            this.btnKKN = new System.Windows.Forms.Button();
            this.gbPrepareFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGain)).BeginInit();
            this.gbFiles.SuspendLayout();
            this.gbNormalizare.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdMinkOrder)).BeginInit();
            this.gpKNN.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrepareFiles
            // 
            this.gbPrepareFiles.Controls.Add(this.btnSplit);
            this.gbPrepareFiles.Controls.Add(this.nudGain);
            this.gbPrepareFiles.Controls.Add(this.btnGain);
            this.gbPrepareFiles.Controls.Add(this.btnLargeDataSet);
            this.gbPrepareFiles.Controls.Add(this.btnSmallDataSet);
            this.gbPrepareFiles.Location = new System.Drawing.Point(13, 25);
            this.gbPrepareFiles.Name = "gbPrepareFiles";
            this.gbPrepareFiles.Size = new System.Drawing.Size(164, 184);
            this.gbPrepareFiles.TabIndex = 0;
            this.gbPrepareFiles.TabStop = false;
            this.gbPrepareFiles.Text = "Prepare files";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(7, 151);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 4;
            this.btnSplit.Text = "Split Data";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // nudGain
            // 
            this.nudGain.DecimalPlaces = 2;
            this.nudGain.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudGain.Location = new System.Drawing.Point(89, 105);
            this.nudGain.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGain.Name = "nudGain";
            this.nudGain.Size = new System.Drawing.Size(52, 23);
            this.nudGain.TabIndex = 3;
            // 
            // btnGain
            // 
            this.btnGain.Location = new System.Drawing.Point(7, 106);
            this.btnGain.Name = "btnGain";
            this.btnGain.Size = new System.Drawing.Size(75, 23);
            this.btnGain.TabIndex = 2;
            this.btnGain.Text = "Gain";
            this.btnGain.UseVisualStyleBackColor = true;
            this.btnGain.Click += new System.EventHandler(this.btnGain_Click);
            // 
            // btnLargeDataSet
            // 
            this.btnLargeDataSet.Location = new System.Drawing.Point(7, 63);
            this.btnLargeDataSet.Name = "btnLargeDataSet";
            this.btnLargeDataSet.Size = new System.Drawing.Size(134, 23);
            this.btnLargeDataSet.TabIndex = 1;
            this.btnLargeDataSet.Text = "Load Large Data Set";
            this.btnLargeDataSet.UseVisualStyleBackColor = true;
            this.btnLargeDataSet.Click += new System.EventHandler(this.btnLargeDataSet_Click);
            // 
            // btnSmallDataSet
            // 
            this.btnSmallDataSet.Location = new System.Drawing.Point(7, 23);
            this.btnSmallDataSet.Name = "btnSmallDataSet";
            this.btnSmallDataSet.Size = new System.Drawing.Size(134, 23);
            this.btnSmallDataSet.TabIndex = 0;
            this.btnSmallDataSet.Text = "Load Small Data Set";
            this.btnSmallDataSet.UseVisualStyleBackColor = true;
            this.btnSmallDataSet.Click += new System.EventHandler(this.btnSmallDataSet_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(713, 534);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E X I T";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.btnLf);
            this.gbFiles.Controls.Add(this.btnSf);
            this.gbFiles.Location = new System.Drawing.Point(195, 25);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(292, 116);
            this.gbFiles.TabIndex = 2;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // btnLf
            // 
            this.btnLf.Location = new System.Drawing.Point(7, 76);
            this.btnLf.Name = "btnLf";
            this.btnLf.Size = new System.Drawing.Size(112, 23);
            this.btnLf.TabIndex = 1;
            this.btnLf.Text = "Load large arff";
            this.btnLf.UseVisualStyleBackColor = true;
            this.btnLf.Click += new System.EventHandler(this.btnLf_Click);
            // 
            // btnSf
            // 
            this.btnSf.Location = new System.Drawing.Point(7, 34);
            this.btnSf.Name = "btnSf";
            this.btnSf.Size = new System.Drawing.Size(112, 23);
            this.btnSf.TabIndex = 0;
            this.btnSf.Text = "Load small arff";
            this.btnSf.UseVisualStyleBackColor = true;
            this.btnSf.Click += new System.EventHandler(this.btnSf_Click);
            // 
            // gbNormalizare
            // 
            this.gbNormalizare.Controls.Add(this.btnNormalizare);
            this.gbNormalizare.Controls.Add(this.rbNormSum1);
            this.gbNormalizare.Controls.Add(this.rbNormNom);
            this.gbNormalizare.Controls.Add(this.rbNormCS);
            this.gbNormalizare.Controls.Add(this.rbNormB);
            this.gbNormalizare.Location = new System.Drawing.Point(195, 158);
            this.gbNormalizare.Name = "gbNormalizare";
            this.gbNormalizare.Size = new System.Drawing.Size(200, 157);
            this.gbNormalizare.TabIndex = 3;
            this.gbNormalizare.TabStop = false;
            this.gbNormalizare.Text = "Normalizare";
            // 
            // btnNormalizare
            // 
            this.btnNormalizare.Location = new System.Drawing.Point(7, 126);
            this.btnNormalizare.Name = "btnNormalizare";
            this.btnNormalizare.Size = new System.Drawing.Size(89, 23);
            this.btnNormalizare.TabIndex = 4;
            this.btnNormalizare.Text = "Normalizare";
            this.btnNormalizare.UseVisualStyleBackColor = true;
            this.btnNormalizare.Click += new System.EventHandler(this.btnNormalizare_Click);
            // 
            // rbNormSum1
            // 
            this.rbNormSum1.AutoSize = true;
            this.rbNormSum1.Location = new System.Drawing.Point(7, 100);
            this.rbNormSum1.Name = "rbNormSum1";
            this.rbNormSum1.Size = new System.Drawing.Size(131, 19);
            this.rbNormSum1.TabIndex = 3;
            this.rbNormSum1.TabStop = true;
            this.rbNormSum1.Text = "Normalizare Suma 1";
            this.rbNormSum1.UseVisualStyleBackColor = true;
            // 
            // rbNormNom
            // 
            this.rbNormNom.AutoSize = true;
            this.rbNormNom.Location = new System.Drawing.Point(7, 75);
            this.rbNormNom.Name = "rbNormNom";
            this.rbNormNom.Size = new System.Drawing.Size(144, 19);
            this.rbNormNom.TabIndex = 2;
            this.rbNormNom.TabStop = true;
            this.rbNormNom.Text = "Normalizare Nominala";
            this.rbNormNom.UseVisualStyleBackColor = true;
            // 
            // rbNormCS
            // 
            this.rbNormCS.AutoSize = true;
            this.rbNormCS.Location = new System.Drawing.Point(6, 50);
            this.rbNormCS.Name = "rbNormCS";
            this.rbNormCS.Size = new System.Drawing.Size(164, 19);
            this.rbNormCS.TabIndex = 1;
            this.rbNormCS.TabStop = true;
            this.rbNormCS.Text = "Normalizare Conrell Smart";
            this.rbNormCS.UseVisualStyleBackColor = true;
            // 
            // rbNormB
            // 
            this.rbNormB.AutoSize = true;
            this.rbNormB.Location = new System.Drawing.Point(6, 22);
            this.rbNormB.Name = "rbNormB";
            this.rbNormB.Size = new System.Drawing.Size(125, 19);
            this.rbNormB.TabIndex = 0;
            this.rbNormB.TabStop = true;
            this.rbNormB.Text = "Normalizare Binara";
            this.rbNormB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nUdMinkOrder);
            this.groupBox1.Controls.Add(this.btnCalcDistante);
            this.groupBox1.Controls.Add(this.rbDistCos);
            this.groupBox1.Controls.Add(this.rbDisMin);
            this.groupBox1.Controls.Add(this.rbDisMan);
            this.groupBox1.Controls.Add(this.rbDistE);
            this.groupBox1.Location = new System.Drawing.Point(432, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distanta";
            // 
            // rbDistE
            // 
            this.rbDistE.AutoSize = true;
            this.rbDistE.Location = new System.Drawing.Point(7, 23);
            this.rbDistE.Name = "rbDistE";
            this.rbDistE.Size = new System.Drawing.Size(125, 19);
            this.rbDistE.TabIndex = 0;
            this.rbDistE.TabStop = true;
            this.rbDistE.Text = "Distanta Euclidiana";
            this.rbDistE.UseVisualStyleBackColor = true;
            // 
            // rbDisMan
            // 
            this.rbDisMan.AutoSize = true;
            this.rbDisMan.Location = new System.Drawing.Point(6, 50);
            this.rbDisMan.Name = "rbDisMan";
            this.rbDisMan.Size = new System.Drawing.Size(129, 19);
            this.rbDisMan.TabIndex = 1;
            this.rbDisMan.TabStop = true;
            this.rbDisMan.Text = "Distanta Manhattan";
            this.rbDisMan.UseVisualStyleBackColor = true;
            // 
            // rbDisMin
            // 
            this.rbDisMin.AutoSize = true;
            this.rbDisMin.Location = new System.Drawing.Point(6, 75);
            this.rbDisMin.Name = "rbDisMin";
            this.rbDisMin.Size = new System.Drawing.Size(128, 19);
            this.rbDisMin.TabIndex = 2;
            this.rbDisMin.TabStop = true;
            this.rbDisMin.Text = "Distanta Minkowski";
            this.rbDisMin.UseVisualStyleBackColor = true;
            // 
            // rbDistCos
            // 
            this.rbDistCos.AutoSize = true;
            this.rbDistCos.Location = new System.Drawing.Point(7, 100);
            this.rbDistCos.Name = "rbDistCos";
            this.rbDistCos.Size = new System.Drawing.Size(113, 19);
            this.rbDistCos.TabIndex = 3;
            this.rbDistCos.TabStop = true;
            this.rbDistCos.Text = "Distanta Cosinus";
            this.rbDistCos.UseVisualStyleBackColor = true;
            // 
            // btnCalcDistante
            // 
            this.btnCalcDistante.Location = new System.Drawing.Point(7, 128);
            this.btnCalcDistante.Name = "btnCalcDistante";
            this.btnCalcDistante.Size = new System.Drawing.Size(75, 23);
            this.btnCalcDistante.TabIndex = 4;
            this.btnCalcDistante.Text = "Distanta";
            this.btnCalcDistante.UseVisualStyleBackColor = true;
            this.btnCalcDistante.Click += new System.EventHandler(this.btnCalcDistante_Click);
            // 
            // nUdMinkOrder
            // 
            this.nUdMinkOrder.Location = new System.Drawing.Point(141, 70);
            this.nUdMinkOrder.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUdMinkOrder.Name = "nUdMinkOrder";
            this.nUdMinkOrder.Size = new System.Drawing.Size(53, 23);
            this.nUdMinkOrder.TabIndex = 5;
            this.nUdMinkOrder.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // gpKNN
            // 
            this.gpKNN.Controls.Add(this.btnKKN);
            this.gpKNN.Controls.Add(this.lbK);
            this.gpKNN.Controls.Add(this.tbK);
            this.gpKNN.Location = new System.Drawing.Point(195, 343);
            this.gpKNN.Name = "gpKNN";
            this.gpKNN.Size = new System.Drawing.Size(200, 100);
            this.gpKNN.TabIndex = 5;
            this.gpKNN.TabStop = false;
            this.gpKNN.Text = "KNN";
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(27, 23);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(79, 23);
            this.tbK.TabIndex = 0;
            // 
            // lbK
            // 
            this.lbK.AutoSize = true;
            this.lbK.Location = new System.Drawing.Point(7, 23);
            this.lbK.Name = "lbK";
            this.lbK.Size = new System.Drawing.Size(14, 15);
            this.lbK.TabIndex = 1;
            this.lbK.Text = "K";
            // 
            // btnKKN
            // 
            this.btnKKN.Location = new System.Drawing.Point(7, 66);
            this.btnKKN.Name = "btnKKN";
            this.btnKKN.Size = new System.Drawing.Size(75, 23);
            this.btnKKN.TabIndex = 2;
            this.btnKKN.Text = "KNN";
            this.btnKKN.UseVisualStyleBackColor = true;
            this.btnKKN.Click += new System.EventHandler(this.btnKKN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.gpKNN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbNormalizare);
            this.Controls.Add(this.gbFiles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbPrepareFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPrepareFiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudGain)).EndInit();
            this.gbFiles.ResumeLayout(false);
            this.gbNormalizare.ResumeLayout(false);
            this.gbNormalizare.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUdMinkOrder)).EndInit();
            this.gpKNN.ResumeLayout(false);
            this.gpKNN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrepareFiles;
        private System.Windows.Forms.Button btnLargeDataSet;
        private System.Windows.Forms.Button btnSmallDataSet;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGain;
        private System.Windows.Forms.NumericUpDown nudGain;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.Button btnLf;
        private System.Windows.Forms.Button btnSf;
        private System.Windows.Forms.GroupBox gbNormalizare;
        private System.Windows.Forms.RadioButton rbNormSum1;
        private System.Windows.Forms.RadioButton rbNormNom;
        private System.Windows.Forms.RadioButton rbNormCS;
        private System.Windows.Forms.RadioButton rbNormB;
        private System.Windows.Forms.Button btnNormalizare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nUdMinkOrder;
        private System.Windows.Forms.Button btnCalcDistante;
        private System.Windows.Forms.RadioButton rbDistCos;
        private System.Windows.Forms.RadioButton rbDisMin;
        private System.Windows.Forms.RadioButton rbDisMan;
        private System.Windows.Forms.RadioButton rbDistE;
        private System.Windows.Forms.GroupBox gpKNN;
        private System.Windows.Forms.Button btnKKN;
        private System.Windows.Forms.Label lbK;
        private System.Windows.Forms.TextBox tbK;
    }
}

