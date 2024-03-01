using UnityEngine;

public class TargetPointMover : MonoBehaviour
{
    private const int DirectionRight = 1;
    private const int DirectionLeft = -1;

    [SerializeField] private float _speed;

    private int _direction = 1;

    private void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime * _direction);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Point point))
        {
            if (_direction == DirectionRight)
            {
                _direction = DirectionLeft;
            }
            else
            {
                _direction = DirectionRight;
            }
        }
    }
}
