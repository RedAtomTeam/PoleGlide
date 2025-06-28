using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ObstraclesLine : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _startPosition;
    [SerializeField] private Transform _endPosition;
    [SerializeField] private GameObject _obj;

    [SerializeField] private GameObject _obstacle;

    private void Start()
    {
        _obj.transform.position = _startPosition.position;
        _obstacle.SetActive(false);
    }

    private void Update()
    {
        var step = _speed * Time.deltaTime;
        _obj.transform.position = Vector3.MoveTowards(_obj.transform.position, _endPosition.position, step);

        if (Vector3.Distance(_obj.transform.position, _endPosition.position) < 0.001f)
        {
            _obj.transform.position = _startPosition.position;
            _obstacle.SetActive(false);
        }
    }

    public void Move()
    {
        
    }

    public void SetObject()
    {
        _obj.transform.position = _startPosition.position;
        _obstacle.SetActive(true);
    }
}
