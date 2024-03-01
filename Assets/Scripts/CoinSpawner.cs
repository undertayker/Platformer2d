using UnityEngine;

[RequireComponent(typeof(Transform))]
public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Coin _coinPrefab;

    private void Start()
    {
        _spawnPoint = GetComponent<Transform>();

        Coin coin = Instantiate(_coinPrefab,
            _spawnPoint.position,
            Quaternion.identity);
    }
}
