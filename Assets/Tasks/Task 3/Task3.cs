using UnityEngine;

public class Task3 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    
    private void Start()
    {
        // Создаем новый экземпляр объекта и сохраняем ссылку на него, чтобы работать с новым объектом а не с оригиналом префаба
        var wall = Instantiate(_wallPrefab);
        wall.GetComponent<Rigidbody>().isKinematic = false;
    }
}
