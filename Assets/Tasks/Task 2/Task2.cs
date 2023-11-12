using UnityEngine;

public class Task2 : MonoBehaviour
{
    [SerializeField] private Transform _wallPrefab;
    [SerializeField] private Vector3 _tagetPosition = new(0, 0, 0f);

    private void Start()
    {
        // Создаем новый экземпляр объекта и сохраняем ссылку на него, чтобы работать с новым объектом а не с оригиналом
        // так же можно не писать transform после wall так как мы сразу сериализуем компонент Transform.
        var wall = Instantiate(_wallPrefab);
        wall.position = _tagetPosition;
    }
}