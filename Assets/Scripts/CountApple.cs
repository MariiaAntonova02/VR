using UnityEngine;

public class SphereInteractionApple : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Apple"))
        {
            SphereManagerApple.GetInstanceApple().IncrementCount();

            // Отключаем объект, чтобы он исчез
            Destroy(collision.gameObject);
        }
    }
}
