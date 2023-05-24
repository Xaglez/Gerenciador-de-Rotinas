namespace Rotina
{
    partial class F_edicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_edicao));
            this.clb_editar = new System.Windows.Forms.CheckedListBox();
            this.bnt_adicionar = new System.Windows.Forms.Button();
            this.tb_adicionar = new System.Windows.Forms.TextBox();
            this.btn_limparLista = new System.Windows.Forms.Button();
            this.btn_marcarTodos = new System.Windows.Forms.Button();
            this.btn_desmarcarTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_editar
            // 
            this.clb_editar.BackColor = System.Drawing.Color.LightCyan;
            this.clb_editar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clb_editar.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_editar.ForeColor = System.Drawing.Color.DarkCyan;
            this.clb_editar.FormattingEnabled = true;
            this.clb_editar.Location = new System.Drawing.Point(12, 38);
            this.clb_editar.Name = "clb_editar";
            this.clb_editar.Size = new System.Drawing.Size(172, 304);
            this.clb_editar.TabIndex = 0;
            // 
            // bnt_adicionar
            // 
            this.bnt_adicionar.BackColor = System.Drawing.Color.LightBlue;
            this.bnt_adicionar.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_adicionar.Location = new System.Drawing.Point(190, 313);
            this.bnt_adicionar.Name = "bnt_adicionar";
            this.bnt_adicionar.Size = new System.Drawing.Size(107, 29);
            this.bnt_adicionar.TabIndex = 2;
            this.bnt_adicionar.Text = "Adicionar tarefa";
            this.bnt_adicionar.UseVisualStyleBackColor = false;
            this.bnt_adicionar.Click += new System.EventHandler(this.bnt_adicionar_Click);
            // 
            // tb_adicionar
            // 
            this.tb_adicionar.BackColor = System.Drawing.Color.Azure;
            this.tb_adicionar.Location = new System.Drawing.Point(190, 286);
            this.tb_adicionar.Name = "tb_adicionar";
            this.tb_adicionar.Size = new System.Drawing.Size(107, 21);
            this.tb_adicionar.TabIndex = 3;
            this.tb_adicionar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_adicionar_KeyPress_1);
            // 
            // btn_limparLista
            // 
            this.btn_limparLista.BackColor = System.Drawing.Color.LightBlue;
            this.btn_limparLista.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparLista.Location = new System.Drawing.Point(189, 108);
            this.btn_limparLista.Name = "btn_limparLista";
            this.btn_limparLista.Size = new System.Drawing.Size(107, 29);
            this.btn_limparLista.TabIndex = 4;
            this.btn_limparLista.Text = "Limpar Lista";
            this.btn_limparLista.UseVisualStyleBackColor = false;
            this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
            // 
            // btn_marcarTodos
            // 
            this.btn_marcarTodos.BackColor = System.Drawing.Color.LightBlue;
            this.btn_marcarTodos.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marcarTodos.Location = new System.Drawing.Point(189, 73);
            this.btn_marcarTodos.Name = "btn_marcarTodos";
            this.btn_marcarTodos.Size = new System.Drawing.Size(107, 29);
            this.btn_marcarTodos.TabIndex = 5;
            this.btn_marcarTodos.Text = "Marcar Todos";
            this.btn_marcarTodos.UseVisualStyleBackColor = false;
            this.btn_marcarTodos.Click += new System.EventHandler(this.btn_marcarTodos_Click);
            // 
            // btn_desmarcarTodos
            // 
            this.btn_desmarcarTodos.BackColor = System.Drawing.Color.LightBlue;
            this.btn_desmarcarTodos.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desmarcarTodos.Location = new System.Drawing.Point(190, 38);
            this.btn_desmarcarTodos.Name = "btn_desmarcarTodos";
            this.btn_desmarcarTodos.Size = new System.Drawing.Size(107, 29);
            this.btn_desmarcarTodos.TabIndex = 6;
            this.btn_desmarcarTodos.Text = "Desmarcar todos";
            this.btn_desmarcarTodos.UseVisualStyleBackColor = false;
            this.btn_desmarcarTodos.Click += new System.EventHandler(this.btn_desmarcarTodos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tarefas";
            // 
            // F_edicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(308, 352);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_desmarcarTodos);
            this.Controls.Add(this.btn_marcarTodos);
            this.Controls.Add(this.btn_limparLista);
            this.Controls.Add(this.tb_adicionar);
            this.Controls.Add(this.bnt_adicionar);
            this.Controls.Add(this.clb_editar);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_edicao";
            this.Text = "Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bnt_adicionar;
        private System.Windows.Forms.Button btn_limparLista;
        private System.Windows.Forms.Button btn_marcarTodos;
        public System.Windows.Forms.Button btn_desmarcarTodos;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_adicionar;
        public System.Windows.Forms.CheckedListBox clb_editar;
    }
}