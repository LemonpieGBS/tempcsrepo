namespace WFATest;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        lblId = new System.Windows.Forms.Label();
        lblNombre = new System.Windows.Forms.Label();
        lblPrecio = new System.Windows.Forms.Label();
        txtId = new System.Windows.Forms.TextBox();
        txtNombre = new System.Windows.Forms.TextBox();
        txtPrecio = new System.Windows.Forms.TextBox();
        btnCrear = new System.Windows.Forms.Button();
        btnLeer = new System.Windows.Forms.Button();
        btnActualizar = new System.Windows.Forms.Button();
        btnEliminar = new System.Windows.Forms.Button();
        dgvProductos = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(12, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(684, 67);
        label1.TabIndex = 0;
        label1.Text = "Formulario de Entrada de Productos (CRUD)";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblId
        // 
        lblId.Location = new System.Drawing.Point(84, 90);
        lblId.Name = "lblId";
        lblId.Size = new System.Drawing.Size(64, 20);
        lblId.TabIndex = 1;
        lblId.Text = "Id:";
        // 
        // lblNombre
        // 
        lblNombre.Location = new System.Drawing.Point(84, 122);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new System.Drawing.Size(64, 20);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre:";
        // 
        // lblPrecio
        // 
        lblPrecio.Location = new System.Drawing.Point(84, 153);
        lblPrecio.Name = "lblPrecio";
        lblPrecio.Size = new System.Drawing.Size(64, 20);
        lblPrecio.TabIndex = 3;
        lblPrecio.Text = "Precio:";
        // 
        // txtId
        // 
        txtId.Location = new System.Drawing.Point(154, 90);
        txtId.Name = "txtId";
        txtId.Size = new System.Drawing.Size(182, 23);
        txtId.TabIndex = 4;
        // 
        // txtNombre
        // 
        txtNombre.Location = new System.Drawing.Point(154, 119);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new System.Drawing.Size(182, 23);
        txtNombre.TabIndex = 5;
        // 
        // txtPrecio
        // 
        txtPrecio.Location = new System.Drawing.Point(154, 148);
        txtPrecio.Name = "txtPrecio";
        txtPrecio.Size = new System.Drawing.Size(182, 23);
        txtPrecio.TabIndex = 6;
        // 
        // btnCrear
        // 
        btnCrear.Location = new System.Drawing.Point(154, 184);
        btnCrear.Name = "btnCrear";
        btnCrear.Size = new System.Drawing.Size(110, 28);
        btnCrear.TabIndex = 7;
        btnCrear.Text = "Crear";
        btnCrear.UseVisualStyleBackColor = true;
        btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
        // 
        // btnLeer
        // 
        btnLeer.Location = new System.Drawing.Point(270, 184);
        btnLeer.Name = "btnLeer";
        btnLeer.Size = new System.Drawing.Size(110, 28);
        btnLeer.TabIndex = 8;
        btnLeer.Text = "Leer";
        btnLeer.UseVisualStyleBackColor = true;
        btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
        // 
        // btnActualizar
        // 
        btnActualizar.Location = new System.Drawing.Point(386, 184);
        btnActualizar.Name = "btnActualizar";
        btnActualizar.Size = new System.Drawing.Size(110, 28);
        btnActualizar.TabIndex = 9;
        btnActualizar.Text = "Actualizar";
        btnActualizar.UseVisualStyleBackColor = true;
        btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
        // 
        // btnEliminar
        // 
        btnEliminar.Location = new System.Drawing.Point(502, 184);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new System.Drawing.Size(110, 28);
        btnEliminar.TabIndex = 10;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = true;
        btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
        // 
        // dgvProductos
        // 
        dgvProductos.Location = new System.Drawing.Point(154, 221);
        dgvProductos.Name = "dgvProductos";
        dgvProductos.Size = new System.Drawing.Size(457, 186);
        dgvProductos.TabIndex = 11;
        dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
        dgvProductos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductos_CellMouseClick);
        // 
        // Form1
        // 
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(708, 450);
        Controls.Add(dgvProductos);
        Controls.Add(btnEliminar);
        Controls.Add(btnActualizar);
        Controls.Add(btnLeer);
        Controls.Add(btnCrear);
        Controls.Add(txtPrecio);
        Controls.Add(txtNombre);
        Controls.Add(txtId);
        Controls.Add(lblPrecio);
        Controls.Add(lblNombre);
        Controls.Add(lblId);
        Controls.Add(label1);
        HelpButton = true;
        Location = new System.Drawing.Point(15, 15);
        MaximizeBox = false;
        MinimizeBox = false;
        Text = "FormularioProductos";
        this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.Label lblPrecio;
    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtPrecio;
    private System.Windows.Forms.Button btnCrear;
    private System.Windows.Forms.Button btnLeer;
    private System.Windows.Forms.Button btnActualizar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.DataGridView dgvProductos;

    private System.Windows.Forms.Label label1;

    #endregion
}