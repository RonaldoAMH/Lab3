namespace Lab3.UI
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
            botonRegistrar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            nombreTxt = new TextBox();
            marcaTxt = new TextBox();
            tallaTxt = new TextBox();
            descriTxt = new TextBox();
            botonBuscar = new Button();
            label5 = new Label();
            idTxt = new TextBox();
            dataInfo = new DataGridView();
            botonMostrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataInfo).BeginInit();
            SuspendLayout();
            // 
            // botonRegistrar
            // 
            botonRegistrar.Location = new Point(128, 274);
            botonRegistrar.Name = "botonRegistrar";
            botonRegistrar.Size = new Size(75, 23);
            botonRegistrar.TabIndex = 0;
            botonRegistrar.Text = "Registrar";
            botonRegistrar.UseVisualStyleBackColor = true;
            botonRegistrar.Click += botonRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 56);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 100);
            label2.Name = "label2";
            label2.Size = new Size(42, 18);
            label2.TabIndex = 2;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 147);
            label3.Name = "label3";
            label3.Size = new Size(32, 18);
            label3.TabIndex = 3;
            label3.Text = "Talla";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 193);
            label4.Name = "label4";
            label4.Size = new Size(73, 18);
            label4.TabIndex = 4;
            label4.Text = "Descripción";
            // 
            // nombreTxt
            // 
            nombreTxt.Location = new Point(128, 53);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(100, 21);
            nombreTxt.TabIndex = 5;
            // 
            // marcaTxt
            // 
            marcaTxt.Location = new Point(128, 100);
            marcaTxt.Name = "marcaTxt";
            marcaTxt.Size = new Size(100, 21);
            marcaTxt.TabIndex = 6;
            // 
            // tallaTxt
            // 
            tallaTxt.Location = new Point(128, 147);
            tallaTxt.Name = "tallaTxt";
            tallaTxt.Size = new Size(100, 21);
            tallaTxt.TabIndex = 7;
            // 
            // descriTxt
            // 
            descriTxt.Location = new Point(128, 190);
            descriTxt.Multiline = true;
            descriTxt.Name = "descriTxt";
            descriTxt.Size = new Size(158, 67);
            descriTxt.TabIndex = 8;
            // 
            // botonBuscar
            // 
            botonBuscar.Location = new Point(168, 344);
            botonBuscar.Name = "botonBuscar";
            botonBuscar.Size = new Size(75, 23);
            botonBuscar.TabIndex = 10;
            botonBuscar.Text = "Buscar";
            botonBuscar.UseVisualStyleBackColor = true;
            botonBuscar.Click += botonBuscar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 349);
            label5.Name = "label5";
            label5.Size = new Size(18, 18);
            label5.TabIndex = 11;
            label5.Text = "ID";
            // 
            // idTxt
            // 
            idTxt.Location = new Point(80, 346);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(71, 21);
            idTxt.TabIndex = 12;
            // 
            // dataInfo
            // 
            dataInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataInfo.Location = new Point(315, 87);
            dataInfo.Name = "dataInfo";
            dataInfo.RowTemplate.Height = 23;
            dataInfo.Size = new Size(387, 244);
            dataInfo.TabIndex = 13;
            // 
            // botonMostrar
            // 
            botonMostrar.Location = new Point(437, 41);
            botonMostrar.Name = "botonMostrar";
            botonMostrar.Size = new Size(137, 23);
            botonMostrar.TabIndex = 14;
            botonMostrar.Text = "Mostrar Productos";
            botonMostrar.UseVisualStyleBackColor = true;
            botonMostrar.Click += botonMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 450);
            Controls.Add(botonMostrar);
            Controls.Add(dataInfo);
            Controls.Add(idTxt);
            Controls.Add(label5);
            Controls.Add(botonBuscar);
            Controls.Add(descriTxt);
            Controls.Add(tallaTxt);
            Controls.Add(marcaTxt);
            Controls.Add(nombreTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(botonRegistrar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonRegistrar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox nombreTxt;
        private TextBox marcaTxt;
        private TextBox tallaTxt;
        private TextBox descriTxt;
        private Button botonBuscar;
        private Label label5;
        private TextBox idTxt;
        private DataGridView dataInfo;
        private Button botonMostrar;
    }
}