using System;
using UnityEngine;
/// <summary>
/// Измените этот скрипт
/// </summary>
public class Wall : MonoBehaviour
{
    [SerializeField]
    private Detector _detector;
    [SerializeField] 
    private Vector3 _tagetPosition = new(0, 0, 0f);

    private void Awake()
    {    // Находим объект типа Detector и подписываемся на событие coinDetected и используем метод ChangePosition
        _detector = FindObjectOfType<Detector>();
        _detector.CoinDetected += ChangePosition;
    }

    private void OnDisable()
    {
        
        _detector.CoinDetected -= ChangePosition;
    }

    private void ChangePosition()
    {
        transform.position = _tagetPosition;
    }
}