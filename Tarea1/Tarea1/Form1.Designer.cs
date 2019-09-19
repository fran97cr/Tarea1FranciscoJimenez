namespace Tarea1
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.BtnNumMin = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.NumericUpDown();
            this.btnNumMax = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.NumericUpDown();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.LblClaseMath = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.lblString = new System.Windows.Forms.Label();
            this.lblIndexOf = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnToLower = new System.Windows.Forms.Button();
            this.btnToUpper = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblClaseString = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnAbstraccion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAbstraccion);
            this.splitContainer1.Panel1.Controls.Add(this.splitter2);
            this.splitContainer1.Panel1.Controls.Add(this.lblNum2);
            this.splitContainer1.Panel1.Controls.Add(this.lblNum1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnNumMin);
            this.splitContainer1.Panel1.Controls.Add(this.txtNum2);
            this.splitContainer1.Panel1.Controls.Add(this.btnNumMax);
            this.splitContainer1.Panel1.Controls.Add(this.txtNum1);
            this.splitContainer1.Panel1.Controls.Add(this.splitter1);
            this.splitContainer1.Panel1.Controls.Add(this.LblClaseMath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtIndex);
            this.splitContainer1.Panel2.Controls.Add(this.lblString);
            this.splitContainer1.Panel2.Controls.Add(this.lblIndexOf);
            this.splitContainer1.Panel2.Controls.Add(this.txtString);
            this.splitContainer1.Panel2.Controls.Add(this.btnToLower);
            this.splitContainer1.Panel2.Controls.Add(this.btnToUpper);
            this.splitContainer1.Panel2.Controls.Add(this.btnIndexOf);
            this.splitContainer1.Panel2.Controls.Add(this.lblResultado);
            this.splitContainer1.Panel2.Controls.Add(this.lblClaseString);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 655);
            this.splitContainer1.SplitterDistance = 636;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(211, 194);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(111, 13);
            this.lblNum2.TabIndex = 20;
            this.lblNum2.Text = "Introduce otro número";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(211, 129);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(105, 13);
            this.lblNum1.TabIndex = 19;
            this.lblNum1.Text = "Introduce un número";
            // 
            // BtnNumMin
            // 
            this.BtnNumMin.Location = new System.Drawing.Point(107, 324);
            this.BtnNumMin.Name = "BtnNumMin";
            this.BtnNumMin.Size = new System.Drawing.Size(353, 23);
            this.BtnNumMin.TabIndex = 17;
            this.BtnNumMin.Text = "Sacar numero menor";
            this.BtnNumMin.UseVisualStyleBackColor = true;
            this.BtnNumMin.Click += new System.EventHandler(this.BtnNumMin_Click);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(107, 210);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(353, 20);
            this.txtNum2.TabIndex = 18;
            // 
            // btnNumMax
            // 
            this.btnNumMax.Location = new System.Drawing.Point(107, 280);
            this.btnNumMax.Name = "btnNumMax";
            this.btnNumMax.Size = new System.Drawing.Size(353, 23);
            this.btnNumMax.TabIndex = 15;
            this.btnNumMax.Text = "Sacar numero mayor";
            this.btnNumMax.UseVisualStyleBackColor = true;
            this.btnNumMax.Click += new System.EventHandler(this.btnNumMax_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(107, 145);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(353, 20);
            this.txtNum1.TabIndex = 16;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 655);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // LblClaseMath
            // 
            this.LblClaseMath.AutoSize = true;
            this.LblClaseMath.Location = new System.Drawing.Point(241, 54);
            this.LblClaseMath.Name = "LblClaseMath";
            this.LblClaseMath.Size = new System.Drawing.Size(60, 13);
            this.LblClaseMath.TabIndex = 0;
            this.LblClaseMath.Text = "Clase Math";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(137, 231);
            this.txtIndex.MaxLength = 1;
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(353, 20);
            this.txtIndex.TabIndex = 17;
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(262, 139);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(93, 13);
            this.lblString.TabIndex = 16;
            this.lblString.Text = "Introduce un texto";
            // 
            // lblIndexOf
            // 
            this.lblIndexOf.AutoSize = true;
            this.lblIndexOf.Location = new System.Drawing.Point(234, 196);
            this.lblIndexOf.Name = "lblIndexOf";
            this.lblIndexOf.Size = new System.Drawing.Size(154, 13);
            this.lblIndexOf.TabIndex = 15;
            this.lblIndexOf.Text = "Letra a buscar en texto anterior";
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(137, 155);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(353, 20);
            this.txtString.TabIndex = 14;
            // 
            // btnToLower
            // 
            this.btnToLower.Location = new System.Drawing.Point(136, 373);
            this.btnToLower.Name = "btnToLower";
            this.btnToLower.Size = new System.Drawing.Size(353, 23);
            this.btnToLower.TabIndex = 13;
            this.btnToLower.Text = "Pasar a minusculas";
            this.btnToLower.UseVisualStyleBackColor = true;
            this.btnToLower.Click += new System.EventHandler(this.btnToLower_Click);
            // 
            // btnToUpper
            // 
            this.btnToUpper.Location = new System.Drawing.Point(136, 328);
            this.btnToUpper.Name = "btnToUpper";
            this.btnToUpper.Size = new System.Drawing.Size(353, 23);
            this.btnToUpper.TabIndex = 12;
            this.btnToUpper.Text = "Pasar a mayusculas";
            this.btnToUpper.UseVisualStyleBackColor = true;
            this.btnToUpper.Click += new System.EventHandler(this.btnToUpper_Click);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(136, 284);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(353, 23);
            this.btnIndexOf.TabIndex = 11;
            this.btnIndexOf.Text = "Sacar indice";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(306, 366);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 8;
            // 
            // lblClaseString
            // 
            this.lblClaseString.AutoSize = true;
            this.lblClaseString.Location = new System.Drawing.Point(278, 54);
            this.lblClaseString.Name = "lblClaseString";
            this.lblClaseString.Size = new System.Drawing.Size(63, 13);
            this.lblClaseString.TabIndex = 1;
            this.lblClaseString.Text = "Clase String";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 655);
            this.splitter2.TabIndex = 21;
            this.splitter2.TabStop = false;
            // 
            // btnAbstraccion
            // 
            this.btnAbstraccion.Location = new System.Drawing.Point(69, 531);
            this.btnAbstraccion.Name = "btnAbstraccion";
            this.btnAbstraccion.Size = new System.Drawing.Size(473, 23);
            this.btnAbstraccion.TabIndex = 22;
            this.btnAbstraccion.Text = "Parte 3 y 4 Herencia-Abstracción";
            this.btnAbstraccion.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 655);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormHome";
            this.Text = "Tarea1-FranciscoJimenez";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label LblClaseMath;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblClaseString;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button BtnNumMin;
        private System.Windows.Forms.NumericUpDown txtNum2;
        private System.Windows.Forms.Button btnNumMax;
        private System.Windows.Forms.NumericUpDown txtNum1;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblIndexOf;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnToLower;
        private System.Windows.Forms.Button btnToUpper;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnAbstraccion;
        private System.Windows.Forms.Splitter splitter2;
    }
}

