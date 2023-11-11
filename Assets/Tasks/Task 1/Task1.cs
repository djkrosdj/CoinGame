using UnityEngine;

public class Task1 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    [SerializeField] 
    private Vector3 _tagetScale = new(2, 2, 2);
    
    private void Start()
    {
        Instantiate(_wallPrefab);
        _wallPrefab.transform.localScale = _tagetScale;
    }
}
