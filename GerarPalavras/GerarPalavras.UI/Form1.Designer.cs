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
        txtLetras = new TextBox();
        btnGerarPalavras = new Button();
        txtPalavras = new TextBox();
        txtInicio = new NumericUpDown();
        lblLetras = new Label();
        blInicio = new Label();
        lblPalavras = new Label();
        ((System.ComponentModel.ISupportInitialize)txtInicio).BeginInit();
        SuspendLayout();
        // 
        // txtLetras
        // 
        txtLetras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtLetras.CharacterCasing = CharacterCasing.Upper;
        txtLetras.Location = new Point(12, 42);
        txtLetras.Name = "txtLetras";
        txtLetras.Size = new Size(324, 35);
        txtLetras.TabIndex = 1;
        // 
        // btnGerarPalavras
        // 
        btnGerarPalavras.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnGerarPalavras.Location = new Point(468, 35);
        btnGerarPalavras.Name = "btnGerarPalavras";
        btnGerarPalavras.Size = new Size(200, 50);
        btnGerarPalavras.TabIndex = 4;
        btnGerarPalavras.Text = "Gerar Palavras";
        btnGerarPalavras.UseVisualStyleBackColor = true;
        btnGerarPalavras.Click += btnGerarPalavras_Click;
        // 
        // txtPalavras
        // 
        txtPalavras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        txtPalavras.Location = new Point(12, 124);
        txtPalavras.Multiline = true;
        txtPalavras.Name = "txtPalavras";
        txtPalavras.ScrollBars = ScrollBars.Vertical;
        txtPalavras.Size = new Size(656, 345);
        txtPalavras.TabIndex = 5;
        // 
        // txtInicio
        // 
        txtInicio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        txtInicio.Location = new Point(342, 42);
        txtInicio.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
        txtInicio.Name = "txtInicio";
        txtInicio.Size = new Size(120, 35);
        txtInicio.TabIndex = 3;
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
        blInicio.Location = new Point(342, 9);
        blInicio.Name = "blInicio";
        blInicio.Size = new Size(63, 30);
        blInicio.TabIndex = 2;
        blInicio.Text = "Início";
        // 
        // lblPalavras
        // 
        lblPalavras.AutoSize = true;
        lblPalavras.Location = new Point(12, 91);
        lblPalavras.Name = "lblPalavras";
        lblPalavras.Size = new Size(88, 30);
        lblPalavras.TabIndex = 6;
        lblPalavras.Text = "Palavras";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(680, 481);
        Controls.Add(lblPalavras);
        Controls.Add(blInicio);
        Controls.Add(lblLetras);
        Controls.Add(txtInicio);
        Controls.Add(txtPalavras);
        Controls.Add(btnGerarPalavras);
        Controls.Add(txtLetras);
        Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(5, 6, 5, 6);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)txtInicio).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtLetras;
    private Button btnGerarPalavras;
    private TextBox txtPalavras;
    private NumericUpDown txtInicio;
    private Label lblLetras;
    private Label blInicio;
    private Label lblPalavras;
}
