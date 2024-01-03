using UnityEngine;

public class SphereInteractionBanana : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Banana"))
        {
            SphereManagerBanana.GetInstanceBanana().IncrementCount();

            // Отключаем объект, чтобы он исчез
            Destroy(collision.gameObject);
        }
    }
}
