using DG.Tweening;
using UnityEngine;

public class CapsuleScaler : MonoBehaviour
{
    [SerializeField] private float _endValue = 3f;
    [SerializeField] private float _duration = 3f;
    [SerializeField] private int _loopCount = -1;
    
    void Start() => 
        transform.DOScale(_endValue, _duration).SetLoops(_loopCount, LoopType.Yoyo);
}
