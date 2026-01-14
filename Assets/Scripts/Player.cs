using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;

        if (_playerTransform == null)
            _playerTransform = transform;

        if (_plantCountUI != null)
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); 
        float y = Input.GetAxisRaw("Vertical");   

        Vector3 move = new Vector3(x, y, 0f).normalized;
        _playerTransform.position += move * _speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed ()
    {
        if (_numSeedsLeft <= 0)
            return;
        if (_plantPrefab != null)
        {
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
        }
        _numSeedsLeft--;

        _numSeedsPlanted++;

        if (_plantCountUI != null)
            _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
    }
}
