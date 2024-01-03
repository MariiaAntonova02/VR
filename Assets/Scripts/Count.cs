using UnityEngine;

public class SphereInteraction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Vase"))
        {
            SphereManager.GetInstance().IncrementCount();

            // Отключаем объект, чтобы он исчез
           
            Destroy(collision.gameObject);
        }
    }
}
