using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] 
    private Transform _shelfPrefab;
    
    private void Start()
    {
        // Создаем новый экземпляр объекта и сохраняем ссылку на него, чтобы работать с новым объектом а не с оригиналом префаба
        var shelf = Instantiate(_shelfPrefab); // Эту строку кода удалять нельзя
        // так же необходимо апкастнуть новый объект shelf из компоненты трансформ в гейм объект
        Destroy(shelf.gameObject);
    }
}
