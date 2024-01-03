using UnityEngine;

public class SphereInteractionLemon : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Lemon"))
        {
            SphereManager.GetInstance().IncrementCount();

            // Отключаем объект, чтобы он исчез
            Destroy(collision.gameObject);
        }
    }
}
