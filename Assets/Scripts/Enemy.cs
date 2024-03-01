using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private float _speed;

    private Rigidbody2D _rigidbody;
    private int _directionMove;
    private Transform _target;

    public void SetTarget(Transform target) =>
        _target = target;

    private void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Flip();
    }

    private void Flip()
    {
        if (transform.position.x > _target.position.x)
        {
            _renderer.flipX = true;
            _directionMove = -1;
        }
        else
        {
            _renderer.flipX = false;
            _directionMove = 1;
        }

        _rigidbody.velocity = new Vector2(_speed * _directionMove, _rigidbody.velocity.y);
    }
}