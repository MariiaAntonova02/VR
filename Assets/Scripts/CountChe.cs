using UnityEngine;

public class SphereInteractionChe : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Cheri"))
        {
            SphereManager.GetInstance().IncrementCount();

            // ��������� ������, ����� �� �����
            Destroy(collision.gameObject);
        }
    }
}
