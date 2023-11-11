using UnityEngine;

public class Task1 : MonoBehaviour
{
    [SerializeField] 
    private Transform _wallPrefab;
    [SerializeField] 
    private Vector3 _tagetScale = new(2, 2, 2);
    
    private void Start()
    {
        // Создаем новый экземпляр объекта и сохраняем ссылку на него, чтобы работать с новым объектом а не с оригиналом
        Transform wall = Instantiate(_wallPrefab);
        
        wall.transform.localScale = _tagetScale;
    }
}
