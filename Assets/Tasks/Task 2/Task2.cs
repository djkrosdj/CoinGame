using UnityEngine;

public class Task2 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    [SerializeField] 
    private Vector3 _tagetPosition = new(0, 0, 0f);
    
    private void Start()
    {
        Instantiate(_wallPrefab);
        _wallPrefab.transform.position = _tagetPosition;
    }
}
