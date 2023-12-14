namespace GerarPalavras.UI;

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
        components = new System.ComponentModel.Container();
        txtLetras = new TextBox();
        btnGerarPalavras = new Button();
        txtInicio = new NumericUpDown();
        lblLetras = new Label();
        blInicio = new Label();
        gbxOpcoes = new GroupBox();
        cbxExibirItensNumerados = new CheckBox();
        cbxPalavraUnica = new CheckBox();
        gbxPalavrasGeradas = new GroupBox();
        txtPalavras = new TextBox();
        errorProvider1 = new ErrorProvider(components);
        statusStrip1 = new StatusStrip();
        lblStatus1 = new ToolStripStatusLabel();
        lblStatus2 = new ToolStripStatusLabel();
        ((System.ComponentModel.ISupportInitialize)txtInicio).BeginInit();
        gbxOpcoes.SuspendLayout();
        gbxPalavrasGeradas.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
        statusStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // txtLetras
        // 
        txtLetras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtLetras.CharacterCasing = CharacterCasing.Upper;
        txtLetras.Location = new Point(12, 42);
        txtLetras.MaxLength = 10;
        txtLetras.Name = "txtLetras";
        txtLetras.Size = new Size(588, 35);
        txtLetras.TabIndex = 1;
        txtLetras.TextChanged += txtLetras_TextChanged;
        // 
        // btnGerarPalavras
        // 
        btnGerarPalavras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnGerarPalavras.Enabled = false;
        btnGerarPalavras.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnGerarPalavras.Location = new Point(732, 42);
        btnGerarPalavras.Name = "btnGerarPalavras";
        btnGerarPalavras.Size = new Size(200, 35);
        btnGerarPalavras.TabIndex = 4;
        btnGerarPalavras.Text = "Gerar Palavras";
        btnGerarPalavras.UseVisualStyleBackColor = true;
        btnGerarPalavras.Click += btnGerarPalavras_Click;
        // 
        // txtInicio
        // 
        txtInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtInicio.Location = new Point(606, 42);
        txtInicio.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
        txtInicio.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
        txtInicio.Name = "txtInicio";
        txtInicio.ReadOnly = true;
        txtInicio.Size = new Size(120, 35);
        txtInicio.TabIndex = 3;
        txtInicio.TextAlign = HorizontalAlignment.Center;
        txtInicio.Value = new decimal(new int[] { 3, 0, 0, 0 });
        // 
        // lblLetras
        // 
        lblLetras.AutoSize = true;
        lblLetras.Location = new Point(12, 9);
        lblLetras.Name = "lblLetras";
        lblLetras.Size = new Size(68, 30);
        lblLetras.TabIndex = 0;
        lblLetras.Text = "Letras";
        // 
        // blInicio
        // 
        blInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        blInicio.AutoSize = true;
        blInicio.Location = new Point(606, 9);
        blInicio.Name = "blInicio";
        blInicio.Size = new Size(63, 30);
        blInicio.TabIndex = 2;
        blInicio.Text = "Início";
        // 
        // gbxOpcoes
        // 
        gbxOpcoes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        gbxOpcoes.Controls.Add(cbxExibirItensNumerados);
        gbxOpcoes.Controls.Add(cbxPalavraUnica);
        gbxOpcoes.Location = new Point(606, 83);
        gbxOpcoes.Name = "gbxOpcoes";
        gbxOpcoes.Size = new Size(326, 114);
        gbxOpcoes.TabIndex = 6;
        gbxOpcoes.TabStop = false;
        gbxOpcoes.Text = "Opções";
        // 
        // cbxExibirItensNumerados
        // 
        cbxExibirItensNumerados.AutoSize = true;
        cbxExibirItensNumerados.Location = new Point(6, 74);
        cbxExibirItensNumerados.Name = "cbxExibirItensNumerados";
        cbxExibirItensNumerados.Size = new Size(247, 34);
        cbxExibirItensNumerados.TabIndex = 1;
        cbxExibirItensNumerados.Text = "Exibir Itens Numerados";
        cbxExibirItensNumerados.UseVisualStyleBackColor = true;
        // 
        // cbxPalavraUnica
        // 
        cbxPalavraUnica.AutoSize = true;
        cbxPalavraUnica.Location = new Point(6, 34);
        cbxPalavraUnica.Name = "cbxPalavraUnica";
        cbxPalavraUnica.Size = new Size(174, 34);
        cbxPalavraUnica.TabIndex = 0;
        cbxPalavraUnica.Text = "Palavras Únicas";
        cbxPalavraUnica.UseVisualStyleBackColor = true;
        // 
        // gbxPalavrasGeradas
        // 
        gbxPalavrasGeradas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gbxPalavrasGeradas.Controls.Add(txtPalavras);
        gbxPalavrasGeradas.Location = new Point(12, 83);
        gbxPalavrasGeradas.Name = "gbxPalavrasGeradas";
        gbxPalavrasGeradas.Size = new Size(588, 393);
        gbxPalavrasGeradas.TabIndex = 5;
        gbxPalavrasGeradas.TabStop = false;
        gbxPalavrasGeradas.Text = "Palavras Geradas";
        // 
        // txtPalavras
        // 
        txtPalavras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtPalavras.Location = new Point(6, 34);
        txtPalavras.Multiline = true;
        txtPalavras.Name = "txtPalavras";
        txtPalavras.ReadOnly = true;
        txtPalavras.ScrollBars = ScrollBars.Vertical;
        txtPalavras.Size = new Size(576, 353);
        txtPalavras.TabIndex = 0;
        // 
        // errorProvider1
        // 
        errorProvider1.ContainerControl = this;
        // 
        // statusStrip1
        // 
        statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus1, lblStatus2 });
        statusStrip1.Location = new Point(0, 479);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new Size(944, 22);
        statusStrip1.TabIndex = 7;
        statusStrip1.Text = "statusStrip1";
        // 
        // lblStatus1
        // 
        lblStatus1.AutoSize = false;
        lblStatus1.BackColor = Color.LightCoral;
        lblStatus1.ImageAlign = ContentAlignment.MiddleLeft;
        lblStatus1.Name = "lblStatus1";
        lblStatus1.Size = new Size(250, 17);
        lblStatus1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblStatus2
        // 
        lblStatus2.AutoSize = false;
        lblStatus2.BackColor = Color.MistyRose;
        lblStatus2.ImageAlign = ContentAlignment.MiddleLeft;
        lblStatus2.Name = "lblStatus2";
        lblStatus2.Size = new Size(250, 17);
        lblStatus2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(944, 501);
        Controls.Add(statusStrip1);
        Controls.Add(gbxPalavrasGeradas);
        Controls.Add(gbxOpcoes);
        Controls.Add(blInicio);
        Controls.Add(lblLetras);
        Controls.Add(txtInicio);
        Controls.Add(btnGerarPalavras);
        Controls.Add(txtLetras);
        Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5, 6, 5, 6);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Gerar Palavras";
        ((System.ComponentModel.ISupportInitialize)txtInicio).EndInit();
        gbxOpcoes.ResumeLayout(false);
        gbxOpcoes.PerformLayout();
        gbxPalavrasGeradas.ResumeLayout(false);
        gbxPalavrasGeradas.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtLetras;
    private Button btnGerarPalavras;
    private NumericUpDown txtInicio;
    private Label lblLetras;
    private Label blInicio;
    private Label lblPalavras;
    private GroupBox gbxOpcoes;
    private CheckBox cbxPalavraUnica;
    private GroupBox gbxPalavrasGeradas;
    private TextBox txtPalavras;
    private CheckBox cbxExibirItensNumerados;
    private ErrorProvider errorProvider1;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel lblStatus1;
    private ToolStripStatusLabel lblStatus2;
}
