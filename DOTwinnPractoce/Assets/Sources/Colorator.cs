using DG.Tweening;
using UnityEngine;

public class Colorator : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _startColor = Color.blue;
    [SerializeField] private Color _targetColor = Color.green;
    [SerializeField] private float _duration = 3f;
    [SerializeField] private int _lopCount = -1;
    
    void Start()
    {
        _material.color = _startColor;
        
        _material.DOColor(_targetColor, _duration).SetLoops(_lopCount, LoopType.Yoyo);
    }
}
