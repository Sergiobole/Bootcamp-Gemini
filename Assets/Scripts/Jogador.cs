using UnityEngine;

public class Jogador : MonoBehaviour
{
    [Header("Equipamento")]
    // Olha a mágica da POO! Nós usamos a classe Arma que VOCÊ criou como se fosse um tipo de variável (igual int ou string)
    [SerializeField] private Arma armaEquipada;

    void Update()
    {
        // 1. O Jogador ouve o clique do mouse
        if (Input.GetMouseButtonDown(0))
        {
            // 2. O Jogador verifica se tem uma arma na mão
            if (armaEquipada != null)
            {
                // 3. O Jogador manda a arma específica atirar!
                armaEquipada.Atirar();
            }
        }

        // SEU DESAFIO: 
        // Faça a mesma lógica aqui para a tecla 'R' (Recarregar) a armaEquipada!
        else if(Input.GetKeyDown(KeyCode.R)) // Se o jogador apertar a tecla 'R'
        {
            if (armaEquipada != null)
            {
                armaEquipada.Recarregar(); // Chama o método de recarregar
            }
        }
    }
}