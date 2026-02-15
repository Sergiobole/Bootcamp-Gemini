using UnityEngine;

public class Arma : MonoBehaviour
{
    // --- ATRIBUTOS (O que a arma tem) ---
    // Usamos 'public' para que essas variáveis apareçam lá no Inspector da Unity!
    [Header("Configurações da Arma")]
    [SerializeField] private string Nome;
    [SerializeField] private int MunicaoAtual;
    [SerializeField] private int Dano;

    // --- MÉTODOS (O que a arma faz) ---
    public void Atirar()
    {
        // Verifica se tem bala
        if (MunicaoAtual > 0)
        {
            MunicaoAtual--; // Tira 1 bala da conta
            Debug.Log($"POW! Tiro com a {Nome}. Dano causado: {Dano}. Munição restante: {MunicaoAtual}");
        }
        else
        {
            Debug.Log($"A arma {Nome} está descarregada! *click click*");
                Recarregar(); // Chama o método de recarga automaticamente quando a munição acabar
        }
    }

    // 🚀 SEU DESAFIO AQUI EMBAIXO:
    // Crie o método public void Recarregar()
    public void Recarregar()
    {
        if(MunicaoAtual < 30)
        {
            MunicaoAtual = 30; // Recarrega a arma para o máximo de munição
            Debug.Log($"A arma {Nome} foi recarregada! Munição atual: {MunicaoAtual}");
        }
        else
        {
            Debug.Log($"A arma {Nome} já está cheia! Munição atual: {MunicaoAtual}");
        }
    }

    void Start()
    {
        MunicaoAtual = 30; // Começa com a arma cheia
        Debug.Log($"Arma {Nome} criada com {MunicaoAtual} balas e dano de {Dano}");

    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // Se o jogador clicar com o mouse esquerdo
        {
            Atirar(); // Chama o método de atirar
        }
        else if(Input.GetKeyDown(KeyCode.R)) // Se o jogador apertar a tecla 'R'
        {
            Recarregar(); // Chama o método de recarregar
        }
    }

}