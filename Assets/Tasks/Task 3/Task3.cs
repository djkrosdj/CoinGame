using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    
    private void Start()
    {
        Instantiate(_wallPrefab);
        _wallPrefab.GetComponent<Rigidbody>().isKinematic = false;
    }
}
