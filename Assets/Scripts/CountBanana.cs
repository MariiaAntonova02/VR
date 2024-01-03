using UnityEngine;

public class SphereInteractionBanana : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Banana"))
        {
            SphereManagerBanana.GetInstanceBanana().IncrementCount();

            // ��������� ������, ����� �� �����
            Destroy(collision.gameObject);
        }
    }
}
