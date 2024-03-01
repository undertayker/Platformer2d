using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int _money;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Coin coin))
        {
            Destroy(collision.gameObject);
            _money++;
        }
    }
}