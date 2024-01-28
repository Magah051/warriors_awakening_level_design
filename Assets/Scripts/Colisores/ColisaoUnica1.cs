using UnityEngine;

public class ColisaoUnica1 : MonoBehaviour
{
    private bool colisaoOcorreu = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar se a colis�o j� ocorreu
        if (!colisaoOcorreu)
        {
            // Executar o c�digo relacionado � colis�o aqui

            // Desativar colliders ap�s a primeira colis�o
            DesativarColliders();

            // Definir a flag de colis�o como true para evitar colis�es subsequentes
            colisaoOcorreu = true;
        }
    }

    private void DesativarColliders()
    {
        // Desativar todos os colliders anexados ao GameObject (pode ser adaptado conforme necess�rio)
        Collider2D[] colliders = GetComponents<Collider2D>();

        foreach (Collider2D collider in colliders)
        {
            collider.enabled = false;
        }
    }
}
