using System.Diagnostics;
using System.Text;

namespace GerarPalavras.UI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnGerarPalavras_Click(object sender, EventArgs e)
    {
        // Cria uma inst�ncia do Stopwatch
        Stopwatch stopwatch = new Stopwatch();

        // Inicia o cron�metro
        stopwatch.Start();

        // Chame suas fun��es aqui
        NewMethod();

        // Para o cron�metro
        stopwatch.Stop();

        // Obt�m o tempo decorrido
        TimeSpan tempoDecorrido = stopwatch.Elapsed;

        // Exibe o tempo decorrido no Label
        lblStatus2.Text = $"Tempo de execu��o: {tempoDecorrido.TotalSeconds} segundos";

    }

    private void NewMethod()
    {

        if (txtLetras.Text.Trim() == "")
        {
            // Exibe um �cone de erro e uma mensagem associada ao controle txtLetras
            errorProvider1.SetError(txtLetras, "Este campo n�o pode estar vazio.");
        }
        else
        {
            // Limpa o �cone de erro associado ao controle txtLetras
            errorProvider1.SetError(txtLetras, "");
            GerarPalavras();
        }

    }

    private void GerarPalavras()
    {
        try
        {
            btnGerarPalavras.Enabled = false;
            lblStatus1.Text = "Aguarde enquanto as palavras est�o sendo geradas!";
            lblStatus2.Text = string.Empty;

            StringBuilder sb = new StringBuilder();

            List<char> letras = txtLetras.Text.Replace(" ", "").ToList();

            List<string> combinacoes = new List<string>();
            List<string> arranjos = new List<string>();

            int inicio = (int)txtInicio.Value;
            if (inicio > letras.Count)
            {
                inicio = letras.Count;
            }

            for (int i = inicio; i <= letras.Count; i++)
            {
                combinacoes.AddRange(GerarCombinacoes(letras.ToArray(), i));
                arranjos.AddRange(GerarArranjos(letras.ToArray(), i));
            }

            if (cbxPalavraUnica.Checked)
            {
                // Remover elementos duplicados
                HashSet<string> conjuntoUnico = new HashSet<string>(arranjos);
                arranjos.Clear();
                arranjos.AddRange(conjuntoUnico);
            }

            // Exibir os arranjos gerados
            for (int i = 0; i < arranjos.Count; i++)
            {
                if (cbxExibirItensNumerados.Checked)
                {
                    sb.AppendLine($"{(i + 1)}: {arranjos[i]}");
                }
                else
                {
                    sb.AppendLine($"{arranjos[i]}");
                }
            }

            sb.Remove(sb.Length - 1, 1);

            lblStatus1.Text = $"{arranjos.Count.ToString("N0")} palavras {(cbxPalavraUnica.Checked ? "�nicas " : "")}geradas com {txtLetras.Text.Replace(" ", "").Length} letras.";

            txtPalavras.Text = sb.ToString();

            btnGerarPalavras.Enabled = true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }



    static List<string> GerarCombinacoes(char[] letras, int tamanho)
    {
        List<string> combinacoes = new List<string>();

        // Garantir que o tamanho solicitado seja v�lido
        if (tamanho < 1 || tamanho > letras.Length)
        {
            Console.WriteLine("Tamanho inv�lido para gerar combina��es.");
            return combinacoes;
        }

        // Gerar combina��es usando loops aninhados
        for (int i = 0; i < letras.Length - tamanho + 1; i++)
        {
            for (int j = i + 1; j < letras.Length - tamanho + 2; j++)
            {
                for (int k = j + 1; k < letras.Length; k++)
                {
                    string combinacao = $"{letras[i]}{letras[j]}{letras[k]}";
                    combinacoes.Add(combinacao);
                }
            }
        }

        return combinacoes;
    }

    static List<string> GerarArranjos(char[] letras, int tamanhoCombinacao)
    {
        List<string> arranjos = new List<string>();
        bool[] posicoesUsadas = new bool[letras.Length];
        GerarArranjosRecursivo(letras, tamanhoCombinacao, posicoesUsadas, new char[tamanhoCombinacao], 0, arranjos);
        return arranjos;
    }

    static void GerarArranjosRecursivo(char[] letras, int tamanhoCombinacao, bool[] posicoesUsadas, char[] arranjoAtual, int posicao, List<string> arranjos)
    {
        // Caso base: se a posi��o atingiu o tamanho desejado, adicionamos o arranjo
        if (posicao == tamanhoCombinacao)
        {
            arranjos.Add(new string(arranjoAtual));
            return;
        }

        // Loop para permutar letras
        for (int i = 0; i < letras.Length; i++)
        {
            // Verifica se a posi��o j� foi usada
            if (!posicoesUsadas[i])
            {
                // Marca a posi��o como usada
                posicoesUsadas[i] = true;

                // Atribui a letra na posi��o atual do arranjo
                arranjoAtual[posicao] = letras[i];

                // Chama recursivamente para a pr�xima posi��o
                GerarArranjosRecursivo(letras, tamanhoCombinacao, posicoesUsadas, arranjoAtual, posicao + 1, arranjos);

                // Desmarca a posi��o para voltar ao estado anterior
                posicoesUsadas[i] = false;
            }
        }
    }

    private void txtLetras_TextChanged(object sender, EventArgs e)
    {
        int quantidadeCaracteres = txtLetras.Text.Replace(" ", "").Length;
        if (quantidadeCaracteres >= 3)
        {
            btnGerarPalavras.Enabled = true;
            txtInicio.Minimum = 3;
            txtInicio.Maximum = quantidadeCaracteres;
        }
        else
        {
            btnGerarPalavras.Enabled = false;
            txtInicio.Minimum = 3;
            txtInicio.Maximum = 3;
        }
    }
}
