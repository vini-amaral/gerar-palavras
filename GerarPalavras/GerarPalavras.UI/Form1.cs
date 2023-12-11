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
        GerarPalavras();
    }

    private void GerarPalavras()
    {
        try
        {
            StringBuilder sb = new StringBuilder();

            List<char> letras = txtLetras.Text.Replace(" ", "").ToList();



            List<string> combinacoes = new List<string>();// = GerarCombinacoes(letras.ToArray(), 3);
            List<string> arranjos = new List<string>();// = GerarArranjos(letras.ToArray(), 4);

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

            // Exibir os arranjos gerados
            for (int i = 0; i < arranjos.Count; i++)
            {
                sb.AppendLine($"{(i + 1)}: {arranjos[i]}");
            }

            txtPalavras.Text = sb.ToString();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }



    static List<string> GerarCombinacoes(char[] letras, int tamanho)
    {
        List<string> combinacoes = new List<string>();

        // Garantir que o tamanho solicitado seja válido
        if (tamanho < 1 || tamanho > letras.Length)
        {
            Console.WriteLine("Tamanho inválido para gerar combinações.");
            return combinacoes;
        }

        // Gerar combinações usando loops aninhados
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
        // Caso base: se a posição atingiu o tamanho desejado, adicionamos o arranjo
        if (posicao == tamanhoCombinacao)
        {
            arranjos.Add(new string(arranjoAtual));
            return;
        }

        // Loop para permutar letras
        for (int i = 0; i < letras.Length; i++)
        {
            // Verifica se a posição já foi usada
            if (!posicoesUsadas[i])
            {
                // Marca a posição como usada
                posicoesUsadas[i] = true;

                // Atribui a letra na posição atual do arranjo
                arranjoAtual[posicao] = letras[i];

                // Chama recursivamente para a próxima posição
                GerarArranjosRecursivo(letras, tamanhoCombinacao, posicoesUsadas, arranjoAtual, posicao + 1, arranjos);

                // Desmarca a posição para voltar ao estado anterior
                posicoesUsadas[i] = false;
            }
        }
    }
}
