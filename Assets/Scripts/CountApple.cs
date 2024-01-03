using UnityEngine;

public class SphereInteractionApple : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Apple"))
        {
            SphereManagerApple.GetInstanceApple().IncrementCount();

            // ��������� ������, ����� �� �����
            Destroy(collision.gameObject);
        }
    }
}
