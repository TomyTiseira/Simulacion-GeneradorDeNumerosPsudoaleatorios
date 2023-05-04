namespace TP1_Generador_de_numeros_pseudoaleatoreos.Forms
{
    partial class Montecarlo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtReparacion = new System.Windows.Forms.TextBox();
            this.txtMantenimiento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dvgPreventiva = new System.Windows.Forms.DataGridView();
            this.ciclo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_reparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_averia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_hay_averia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_reparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_mantenimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_averias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_revisiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCorrectiva = new System.Windows.Forms.DataGridView();
            this.ciclo_ec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_ec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_averia_ec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias_averia_ec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_hay_averia_ec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_total_ec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_ac_ec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad_averia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEstrategia = new System.Windows.Forms.Label();
            this.lblCostoPromedioCorrectiva = new System.Windows.Forms.Label();
            this.lblCostoPromedioPreventiva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPreventiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCorrectiva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cant Ciclos (N)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mostrar Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo de reparación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo de mantenimiento:";
            // 
            // txtN
            // 
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(15, 46);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(80, 26);
            this.txtN.TabIndex = 4;
            // 
            // txtDesde
            // 
            this.txtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesde.Location = new System.Drawing.Point(548, 44);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(70, 26);
            this.txtDesde.TabIndex = 5;
            // 
            // txtReparacion
            // 
            this.txtReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReparacion.Location = new System.Drawing.Point(172, 46);
            this.txtReparacion.Name = "txtReparacion";
            this.txtReparacion.Size = new System.Drawing.Size(80, 26);
            this.txtReparacion.TabIndex = 6;
            // 
            // txtMantenimiento
            // 
            this.txtMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMantenimiento.Location = new System.Drawing.Point(344, 46);
            this.txtMantenimiento.Name = "txtMantenimiento";
            this.txtMantenimiento.Size = new System.Drawing.Size(80, 26);
            this.txtMantenimiento.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(708, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "GENERAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CalcularMontecarlo);
            // 
            // dvgPreventiva
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgPreventiva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dvgPreventiva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPreventiva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciclo,
            this.dia,
            this.dia_reparacion,
            this.rnd_averia,
            this.averia,
            this.dia_hay_averia,
            this.costo_reparacion,
            this.costo_mantenimiento,
            this.costo_total,
            this.costo_ac,
            this.cantidad_averias,
            this.cantidad_revisiones});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgPreventiva.DefaultCellStyle = dataGridViewCellStyle12;
            this.dvgPreventiva.Location = new System.Drawing.Point(15, 518);
            this.dvgPreventiva.Name = "dvgPreventiva";
            this.dvgPreventiva.Size = new System.Drawing.Size(1161, 214);
            this.dvgPreventiva.TabIndex = 9;
            // 
            // ciclo
            // 
            this.ciclo.HeaderText = "Ciclo";
            this.ciclo.Name = "ciclo";
            this.ciclo.Width = 55;
            // 
            // dia
            // 
            this.dia.HeaderText = "Dia";
            this.dia.Name = "dia";
            this.dia.Width = 50;
            // 
            // dia_reparacion
            // 
            this.dia_reparacion.HeaderText = "Día en que hay revisión";
            this.dia_reparacion.Name = "dia_reparacion";
            // 
            // rnd_averia
            // 
            this.rnd_averia.HeaderText = "RND Días Para Averia";
            this.rnd_averia.Name = "rnd_averia";
            // 
            // averia
            // 
            this.averia.HeaderText = "Días Para Avería";
            this.averia.Name = "averia";
            // 
            // dia_hay_averia
            // 
            this.dia_hay_averia.HeaderText = "Día En Que Hay Averia";
            this.dia_hay_averia.Name = "dia_hay_averia";
            // 
            // costo_reparacion
            // 
            this.costo_reparacion.HeaderText = "Costo Reparación";
            this.costo_reparacion.Name = "costo_reparacion";
            // 
            // costo_mantenimiento
            // 
            this.costo_mantenimiento.HeaderText = "Costo Mantenimiento";
            this.costo_mantenimiento.Name = "costo_mantenimiento";
            // 
            // costo_total
            // 
            this.costo_total.HeaderText = "Costo Total";
            this.costo_total.Name = "costo_total";
            // 
            // costo_ac
            // 
            this.costo_ac.HeaderText = "Costo Acumulado";
            this.costo_ac.Name = "costo_ac";
            // 
            // cantidad_averias
            // 
            this.cantidad_averias.HeaderText = "Cantidad Averias";
            this.cantidad_averias.Name = "cantidad_averias";
            // 
            // cantidad_revisiones
            // 
            this.cantidad_revisiones.HeaderText = "Cantidad Revisiones";
            this.cantidad_revisiones.Name = "cantidad_revisiones";
            // 
            // dvgCorrectiva
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCorrectiva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dvgCorrectiva.ColumnHeadersHeight = 45;
            this.dvgCorrectiva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciclo_ec,
            this.dia_ec,
            this.rnd_averia_ec,
            this.dias_averia_ec,
            this.dia_hay_averia_ec,
            this.costo_total_ec,
            this.costo_ac_ec,
            this.cantidad_averia});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgCorrectiva.DefaultCellStyle = dataGridViewCellStyle14;
            this.dvgCorrectiva.Location = new System.Drawing.Point(15, 141);
            this.dvgCorrectiva.Name = "dvgCorrectiva";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCorrectiva.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dvgCorrectiva.Size = new System.Drawing.Size(731, 214);
            this.dvgCorrectiva.TabIndex = 10;
            // 
            // ciclo_ec
            // 
            this.ciclo_ec.HeaderText = "Ciclo";
            this.ciclo_ec.Name = "ciclo_ec";
            this.ciclo_ec.Width = 55;
            // 
            // dia_ec
            // 
            this.dia_ec.HeaderText = "Día";
            this.dia_ec.Name = "dia_ec";
            this.dia_ec.Width = 50;
            // 
            // rnd_averia_ec
            // 
            this.rnd_averia_ec.HeaderText = "RND Días Para Averia";
            this.rnd_averia_ec.Name = "rnd_averia_ec";
            // 
            // dias_averia_ec
            // 
            this.dias_averia_ec.HeaderText = "Días Para Avería";
            this.dias_averia_ec.Name = "dias_averia_ec";
            // 
            // dia_hay_averia_ec
            // 
            this.dia_hay_averia_ec.HeaderText = "Día En Que Hay Averia";
            this.dia_hay_averia_ec.Name = "dia_hay_averia_ec";
            // 
            // costo_total_ec
            // 
            this.costo_total_ec.HeaderText = "Costo Total";
            this.costo_total_ec.Name = "costo_total_ec";
            // 
            // costo_ac_ec
            // 
            this.costo_ac_ec.HeaderText = "Costo Acumulado";
            this.costo_ac_ec.Name = "costo_ac_ec";
            // 
            // cantidad_averia
            // 
            this.cantidad_averia.HeaderText = "Cantidad Averia";
            this.cantidad_averia.Name = "cantidad_averia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estrategía Preventiva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estrategía Correctiva";
            // 
            // lblEstrategia
            // 
            this.lblEstrategia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstrategia.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblEstrategia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrategia.Location = new System.Drawing.Point(810, 196);
            this.lblEstrategia.Name = "lblEstrategia";
            this.lblEstrategia.Size = new System.Drawing.Size(595, 214);
            this.lblEstrategia.TabIndex = 28;
            // 
            // lblCostoPromedioCorrectiva
            // 
            this.lblCostoPromedioCorrectiva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostoPromedioCorrectiva.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblCostoPromedioCorrectiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoPromedioCorrectiva.Location = new System.Drawing.Point(14, 366);
            this.lblCostoPromedioCorrectiva.Name = "lblCostoPromedioCorrectiva";
            this.lblCostoPromedioCorrectiva.Size = new System.Drawing.Size(551, 44);
            this.lblCostoPromedioCorrectiva.TabIndex = 29;
            // 
            // lblCostoPromedioPreventiva
            // 
            this.lblCostoPromedioPreventiva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostoPromedioPreventiva.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblCostoPromedioPreventiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoPromedioPreventiva.Location = new System.Drawing.Point(12, 756);
            this.lblCostoPromedioPreventiva.Name = "lblCostoPromedioPreventiva";
            this.lblCostoPromedioPreventiva.Size = new System.Drawing.Size(553, 44);
            this.lblCostoPromedioPreventiva.TabIndex = 32;
            // 
            // Montecarlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1428, 846);
            this.Controls.Add(this.lblCostoPromedioPreventiva);
            this.Controls.Add(this.lblCostoPromedioCorrectiva);
            this.Controls.Add(this.lblEstrategia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dvgCorrectiva);
            this.Controls.Add(this.dvgPreventiva);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMantenimiento);
            this.Controls.Add(this.txtReparacion);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Montecarlo";
            this.Text = "Montecarlo";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPreventiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCorrectiva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtReparacion;
        private System.Windows.Forms.TextBox txtMantenimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dvgPreventiva;
        private System.Windows.Forms.DataGridView dvgCorrectiva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEstrategia;
        private System.Windows.Forms.Label lblCostoPromedioCorrectiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciclo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_reparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_averia;
        private System.Windows.Forms.DataGridViewTextBoxColumn averia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_hay_averia;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_reparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_mantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_ac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_averias;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_revisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciclo_ec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_ec;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_averia_ec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias_averia_ec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_hay_averia_ec;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_total_ec;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_ac_ec;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad_averia;
        private System.Windows.Forms.Label lblCostoPromedioPreventiva;
    }
}