namespace PAV
{
    partial class GestionDeCursos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbInsertarCurso = new System.Windows.Forms.TabPage();
            this.txtFechaVigenciaCurso = new System.Windows.Forms.MaskedTextBox();
            this.btnInstertarCurso = new System.Windows.Forms.Button();
            this.txtBorradoCurso = new System.Windows.Forms.TextBox();
            this.txtIdCategoriaDelCurso = new System.Windows.Forms.TextBox();
            this.txtDescripcionCurso = new System.Windows.Forms.TextBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtIdCurso = new System.Windows.Forms.TextBox();
            this.lblBorrado = new System.Windows.Forms.Label();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.lblFechaVigencia = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.tbUpdateCurso = new System.Windows.Forms.TabPage();
            this.txtFechaVigenciaCurso2 = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            this.btnActualizarCurso = new System.Windows.Forms.Button();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.btnConsultarCurso = new System.Windows.Forms.Button();
            this.lblDescripcion2 = new System.Windows.Forms.Label();
            this.lblFechaVigencia2 = new System.Windows.Forms.Label();
            this.txtIdCurso2 = new System.Windows.Forms.TextBox();
            this.lblIdCategoria2 = new System.Windows.Forms.Label();
            this.lblIdCurso2 = new System.Windows.Forms.Label();
            this.lblBorrado2 = new System.Windows.Forms.Label();
            this.txtBorradoCurso2 = new System.Windows.Forms.TextBox();
            this.txtNombreCurso2 = new System.Windows.Forms.TextBox();
            this.txtIdCategoriaDelCurso2 = new System.Windows.Forms.TextBox();
            this.txtDescripcionCurso2 = new System.Windows.Forms.TextBox();
            this.tbConsultarCurso = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVerTodosCursos = new System.Windows.Forms.Button();
            this.btnConsultarCurso2 = new System.Windows.Forms.Button();
            this.txtIdCurso3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbInsertarCurso.SuspendLayout();
            this.tbUpdateCurso.SuspendLayout();
            this.tbConsultarCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbInsertarCurso);
            this.tabControl1.Controls.Add(this.tbUpdateCurso);
            this.tabControl1.Controls.Add(this.tbConsultarCurso);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 2;
            this.tabControl1.Size = new System.Drawing.Size(490, 385);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbInsertarCurso
            // 
            this.tbInsertarCurso.Controls.Add(this.txtFechaVigenciaCurso);
            this.tbInsertarCurso.Controls.Add(this.btnInstertarCurso);
            this.tbInsertarCurso.Controls.Add(this.txtBorradoCurso);
            this.tbInsertarCurso.Controls.Add(this.txtIdCategoriaDelCurso);
            this.tbInsertarCurso.Controls.Add(this.txtDescripcionCurso);
            this.tbInsertarCurso.Controls.Add(this.txtNombreCurso);
            this.tbInsertarCurso.Controls.Add(this.txtIdCurso);
            this.tbInsertarCurso.Controls.Add(this.lblBorrado);
            this.tbInsertarCurso.Controls.Add(this.lblIdCategoria);
            this.tbInsertarCurso.Controls.Add(this.lblFechaVigencia);
            this.tbInsertarCurso.Controls.Add(this.lblDescripcion);
            this.tbInsertarCurso.Controls.Add(this.lblNombre);
            this.tbInsertarCurso.Controls.Add(this.lblIdCurso);
            this.tbInsertarCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbInsertarCurso.Location = new System.Drawing.Point(4, 24);
            this.tbInsertarCurso.Name = "tbInsertarCurso";
            this.tbInsertarCurso.Padding = new System.Windows.Forms.Padding(3);
            this.tbInsertarCurso.Size = new System.Drawing.Size(482, 357);
            this.tbInsertarCurso.TabIndex = 0;
            this.tbInsertarCurso.Text = "Insertar curso";
            this.tbInsertarCurso.UseVisualStyleBackColor = true;
            // 
            // txtFechaVigenciaCurso
            // 
            this.txtFechaVigenciaCurso.Location = new System.Drawing.Point(143, 124);
            this.txtFechaVigenciaCurso.Mask = "00/00/0000";
            this.txtFechaVigenciaCurso.Name = "txtFechaVigenciaCurso";
            this.txtFechaVigenciaCurso.Size = new System.Drawing.Size(182, 25);
            this.txtFechaVigenciaCurso.TabIndex = 3;
            this.txtFechaVigenciaCurso.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // btnInstertarCurso
            // 
            this.btnInstertarCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInstertarCurso.Location = new System.Drawing.Point(192, 231);
            this.btnInstertarCurso.Name = "btnInstertarCurso";
            this.btnInstertarCurso.Size = new System.Drawing.Size(80, 30);
            this.btnInstertarCurso.TabIndex = 2;
            this.btnInstertarCurso.Text = "Insertar";
            this.btnInstertarCurso.UseVisualStyleBackColor = true;
            // 
            // txtBorradoCurso
            // 
            this.txtBorradoCurso.Location = new System.Drawing.Point(143, 194);
            this.txtBorradoCurso.Name = "txtBorradoCurso";
            this.txtBorradoCurso.Size = new System.Drawing.Size(182, 25);
            this.txtBorradoCurso.TabIndex = 1;
            // 
            // txtIdCategoriaDelCurso
            // 
            this.txtIdCategoriaDelCurso.Location = new System.Drawing.Point(143, 159);
            this.txtIdCategoriaDelCurso.Name = "txtIdCategoriaDelCurso";
            this.txtIdCategoriaDelCurso.Size = new System.Drawing.Size(182, 25);
            this.txtIdCategoriaDelCurso.TabIndex = 1;
            // 
            // txtDescripcionCurso
            // 
            this.txtDescripcionCurso.Location = new System.Drawing.Point(143, 89);
            this.txtDescripcionCurso.Name = "txtDescripcionCurso";
            this.txtDescripcionCurso.Size = new System.Drawing.Size(182, 25);
            this.txtDescripcionCurso.TabIndex = 1;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(143, 54);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(182, 25);
            this.txtNombreCurso.TabIndex = 1;
            // 
            // txtIdCurso
            // 
            this.txtIdCurso.Location = new System.Drawing.Point(143, 19);
            this.txtIdCurso.Name = "txtIdCurso";
            this.txtIdCurso.Size = new System.Drawing.Size(182, 25);
            this.txtIdCurso.TabIndex = 1;
            // 
            // lblBorrado
            // 
            this.lblBorrado.AutoSize = true;
            this.lblBorrado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBorrado.Location = new System.Drawing.Point(58, 197);
            this.lblBorrado.Name = "lblBorrado";
            this.lblBorrado.Size = new System.Drawing.Size(61, 17);
            this.lblBorrado.TabIndex = 0;
            this.lblBorrado.Text = "Borrado:";
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdCategoria.Location = new System.Drawing.Point(34, 162);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(86, 17);
            this.lblIdCategoria.TabIndex = 0;
            this.lblIdCategoria.Text = "Id_categoria:";
            // 
            // lblFechaVigencia
            // 
            this.lblFechaVigencia.AutoSize = true;
            this.lblFechaVigencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaVigencia.Location = new System.Drawing.Point(17, 127);
            this.lblFechaVigencia.Name = "lblFechaVigencia";
            this.lblFechaVigencia.Size = new System.Drawing.Size(103, 17);
            this.lblFechaVigencia.TabIndex = 0;
            this.lblFechaVigencia.Text = "Fecha_vigencia:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion.Location = new System.Drawing.Point(36, 92);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(84, 17);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(58, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdCurso.Location = new System.Drawing.Point(58, 22);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(62, 17);
            this.lblIdCurso.TabIndex = 0;
            this.lblIdCurso.Text = "Id_curso:";
            // 
            // tbUpdateCurso
            // 
            this.tbUpdateCurso.Controls.Add(this.txtFechaVigenciaCurso2);
            this.tbUpdateCurso.Controls.Add(this.btnEliminarCurso);
            this.tbUpdateCurso.Controls.Add(this.btnActualizarCurso);
            this.tbUpdateCurso.Controls.Add(this.lblNombre2);
            this.tbUpdateCurso.Controls.Add(this.btnConsultarCurso);
            this.tbUpdateCurso.Controls.Add(this.lblDescripcion2);
            this.tbUpdateCurso.Controls.Add(this.lblFechaVigencia2);
            this.tbUpdateCurso.Controls.Add(this.txtIdCurso2);
            this.tbUpdateCurso.Controls.Add(this.lblIdCategoria2);
            this.tbUpdateCurso.Controls.Add(this.lblIdCurso2);
            this.tbUpdateCurso.Controls.Add(this.lblBorrado2);
            this.tbUpdateCurso.Controls.Add(this.txtBorradoCurso2);
            this.tbUpdateCurso.Controls.Add(this.txtNombreCurso2);
            this.tbUpdateCurso.Controls.Add(this.txtIdCategoriaDelCurso2);
            this.tbUpdateCurso.Controls.Add(this.txtDescripcionCurso2);
            this.tbUpdateCurso.Location = new System.Drawing.Point(4, 24);
            this.tbUpdateCurso.Name = "tbUpdateCurso";
            this.tbUpdateCurso.Padding = new System.Windows.Forms.Padding(3);
            this.tbUpdateCurso.Size = new System.Drawing.Size(482, 357);
            this.tbUpdateCurso.TabIndex = 1;
            this.tbUpdateCurso.Text = "Actualizar/eliminar curso";
            this.tbUpdateCurso.UseVisualStyleBackColor = true;
            // 
            // txtFechaVigenciaCurso2
            // 
            this.txtFechaVigenciaCurso2.Location = new System.Drawing.Point(135, 194);
            this.txtFechaVigenciaCurso2.Mask = "00/00/0000";
            this.txtFechaVigenciaCurso2.Name = "txtFechaVigenciaCurso2";
            this.txtFechaVigenciaCurso2.Size = new System.Drawing.Size(182, 23);
            this.txtFechaVigenciaCurso2.TabIndex = 3;
            this.txtFechaVigenciaCurso2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarCurso.Location = new System.Drawing.Point(237, 306);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(80, 30);
            this.btnEliminarCurso.TabIndex = 3;
            this.btnEliminarCurso.Text = "Eliminar";
            this.btnEliminarCurso.UseVisualStyleBackColor = true;
            // 
            // btnActualizarCurso
            // 
            this.btnActualizarCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarCurso.Location = new System.Drawing.Point(135, 306);
            this.btnActualizarCurso.Name = "btnActualizarCurso";
            this.btnActualizarCurso.Size = new System.Drawing.Size(80, 30);
            this.btnActualizarCurso.TabIndex = 3;
            this.btnActualizarCurso.Text = "Actualizar";
            this.btnActualizarCurso.UseVisualStyleBackColor = true;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre2.Location = new System.Drawing.Point(50, 125);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(62, 17);
            this.lblNombre2.TabIndex = 0;
            this.lblNombre2.Text = "Nombre:";
            // 
            // btnConsultarCurso
            // 
            this.btnConsultarCurso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarCurso.Location = new System.Drawing.Point(182, 66);
            this.btnConsultarCurso.Name = "btnConsultarCurso";
            this.btnConsultarCurso.Size = new System.Drawing.Size(80, 30);
            this.btnConsultarCurso.TabIndex = 2;
            this.btnConsultarCurso.Text = "Consultar";
            this.btnConsultarCurso.UseVisualStyleBackColor = true;
            // 
            // lblDescripcion2
            // 
            this.lblDescripcion2.AutoSize = true;
            this.lblDescripcion2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescripcion2.Location = new System.Drawing.Point(28, 160);
            this.lblDescripcion2.Name = "lblDescripcion2";
            this.lblDescripcion2.Size = new System.Drawing.Size(84, 17);
            this.lblDescripcion2.TabIndex = 0;
            this.lblDescripcion2.Text = "Descripcion:";
            // 
            // lblFechaVigencia2
            // 
            this.lblFechaVigencia2.AutoSize = true;
            this.lblFechaVigencia2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFechaVigencia2.Location = new System.Drawing.Point(9, 195);
            this.lblFechaVigencia2.Name = "lblFechaVigencia2";
            this.lblFechaVigencia2.Size = new System.Drawing.Size(103, 17);
            this.lblFechaVigencia2.TabIndex = 0;
            this.lblFechaVigencia2.Text = "Fecha_vigencia:";
            // 
            // txtIdCurso2
            // 
            this.txtIdCurso2.Location = new System.Drawing.Point(135, 26);
            this.txtIdCurso2.Name = "txtIdCurso2";
            this.txtIdCurso2.Size = new System.Drawing.Size(182, 23);
            this.txtIdCurso2.TabIndex = 1;
            // 
            // lblIdCategoria2
            // 
            this.lblIdCategoria2.AutoSize = true;
            this.lblIdCategoria2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdCategoria2.Location = new System.Drawing.Point(26, 230);
            this.lblIdCategoria2.Name = "lblIdCategoria2";
            this.lblIdCategoria2.Size = new System.Drawing.Size(86, 17);
            this.lblIdCategoria2.TabIndex = 0;
            this.lblIdCategoria2.Text = "Id_categoria:";
            // 
            // lblIdCurso2
            // 
            this.lblIdCurso2.AutoSize = true;
            this.lblIdCurso2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdCurso2.Location = new System.Drawing.Point(46, 27);
            this.lblIdCurso2.Name = "lblIdCurso2";
            this.lblIdCurso2.Size = new System.Drawing.Size(62, 17);
            this.lblIdCurso2.TabIndex = 0;
            this.lblIdCurso2.Text = "Id_curso:";
            // 
            // lblBorrado2
            // 
            this.lblBorrado2.AutoSize = true;
            this.lblBorrado2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBorrado2.Location = new System.Drawing.Point(50, 265);
            this.lblBorrado2.Name = "lblBorrado2";
            this.lblBorrado2.Size = new System.Drawing.Size(61, 17);
            this.lblBorrado2.TabIndex = 0;
            this.lblBorrado2.Text = "Borrado:";
            // 
            // txtBorradoCurso2
            // 
            this.txtBorradoCurso2.Location = new System.Drawing.Point(135, 264);
            this.txtBorradoCurso2.Name = "txtBorradoCurso2";
            this.txtBorradoCurso2.Size = new System.Drawing.Size(182, 23);
            this.txtBorradoCurso2.TabIndex = 1;
            // 
            // txtNombreCurso2
            // 
            this.txtNombreCurso2.Location = new System.Drawing.Point(135, 124);
            this.txtNombreCurso2.Name = "txtNombreCurso2";
            this.txtNombreCurso2.Size = new System.Drawing.Size(182, 23);
            this.txtNombreCurso2.TabIndex = 1;
            // 
            // txtIdCategoriaDelCurso2
            // 
            this.txtIdCategoriaDelCurso2.Location = new System.Drawing.Point(135, 229);
            this.txtIdCategoriaDelCurso2.Name = "txtIdCategoriaDelCurso2";
            this.txtIdCategoriaDelCurso2.Size = new System.Drawing.Size(182, 23);
            this.txtIdCategoriaDelCurso2.TabIndex = 1;
            // 
            // txtDescripcionCurso2
            // 
            this.txtDescripcionCurso2.Location = new System.Drawing.Point(135, 159);
            this.txtDescripcionCurso2.Name = "txtDescripcionCurso2";
            this.txtDescripcionCurso2.Size = new System.Drawing.Size(182, 23);
            this.txtDescripcionCurso2.TabIndex = 1;
            // 
            // tbConsultarCurso
            // 
            this.tbConsultarCurso.Controls.Add(this.dataGridView1);
            this.tbConsultarCurso.Controls.Add(this.btnVerTodosCursos);
            this.tbConsultarCurso.Controls.Add(this.btnConsultarCurso2);
            this.tbConsultarCurso.Controls.Add(this.txtIdCurso3);
            this.tbConsultarCurso.Controls.Add(this.label1);
            this.tbConsultarCurso.Location = new System.Drawing.Point(4, 24);
            this.tbConsultarCurso.Name = "tbConsultarCurso";
            this.tbConsultarCurso.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsultarCurso.Size = new System.Drawing.Size(482, 357);
            this.tbConsultarCurso.TabIndex = 2;
            this.tbConsultarCurso.Text = "Consultar curso";
            this.tbConsultarCurso.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 270);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // btnVerTodosCursos
            // 
            this.btnVerTodosCursos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerTodosCursos.Location = new System.Drawing.Point(369, 22);
            this.btnVerTodosCursos.Name = "btnVerTodosCursos";
            this.btnVerTodosCursos.Size = new System.Drawing.Size(80, 23);
            this.btnVerTodosCursos.TabIndex = 2;
            this.btnVerTodosCursos.Text = "Ver todos";
            this.btnVerTodosCursos.UseVisualStyleBackColor = true;
            // 
            // btnConsultarCurso2
            // 
            this.btnConsultarCurso2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarCurso2.Location = new System.Drawing.Point(283, 22);
            this.btnConsultarCurso2.Name = "btnConsultarCurso2";
            this.btnConsultarCurso2.Size = new System.Drawing.Size(80, 23);
            this.btnConsultarCurso2.TabIndex = 2;
            this.btnConsultarCurso2.Text = "Consultar";
            this.btnConsultarCurso2.UseVisualStyleBackColor = true;
            // 
            // txtIdCurso3
            // 
            this.txtIdCurso3.Location = new System.Drawing.Point(95, 22);
            this.txtIdCurso3.Name = "txtIdCurso3";
            this.txtIdCurso3.Size = new System.Drawing.Size(182, 23);
            this.txtIdCurso3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id_curso:";
            // 
            // GestionDeCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 412);
            this.Controls.Add(this.tabControl1);
            this.Name = "GestionDeCursos";
            this.Text = "Gestion De Cursos";
            this.tabControl1.ResumeLayout(false);
            this.tbInsertarCurso.ResumeLayout(false);
            this.tbInsertarCurso.PerformLayout();
            this.tbUpdateCurso.ResumeLayout(false);
            this.tbUpdateCurso.PerformLayout();
            this.tbConsultarCurso.ResumeLayout(false);
            this.tbConsultarCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbInsertarCurso;
        private System.Windows.Forms.Label lblIdCurso;
        private System.Windows.Forms.TabPage tbUpdateCurso;
        private System.Windows.Forms.TabPage tbConsultarCurso;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Label lblFechaVigencia;
        private System.Windows.Forms.Label lblBorrado;
        private System.Windows.Forms.Label lblIdCurso2;
        private System.Windows.Forms.Button btnInstertarCurso;
        private System.Windows.Forms.TextBox txtBorradoCurso;
        private System.Windows.Forms.TextBox txtIdCategoriaDelCurso;
        private System.Windows.Forms.TextBox txtDescripcionCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.TextBox txtIdCurso;
        private System.Windows.Forms.Button btnEliminarCurso;
        private System.Windows.Forms.Button btnActualizarCurso;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Button btnConsultarCurso;
        private System.Windows.Forms.Label lblDescripcion2;
        private System.Windows.Forms.Label lblFechaVigencia2;
        private System.Windows.Forms.TextBox txtIdCurso2;
        private System.Windows.Forms.Label lblIdCategoria2;
        private System.Windows.Forms.Label lblBorrado2;
        private System.Windows.Forms.TextBox txtBorradoCurso2;
        private System.Windows.Forms.TextBox txtNombreCurso2;
        private System.Windows.Forms.TextBox txtIdCategoriaDelCurso2;
        private System.Windows.Forms.TextBox txtDescripcionCurso2;
        private System.Windows.Forms.MaskedTextBox txtFechaVigenciaCurso;
        private System.Windows.Forms.TextBox txtIdCurso3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFechaVigenciaCurso2;
        private System.Windows.Forms.Button btnVerTodosCursos;
        private System.Windows.Forms.Button btnConsultarCurso2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}