using UnityEngine;
using DG.Tweening;

public class SphereMover : MonoBehaviour
{
    [SerializeField] private float _duration = 3f;
    [SerializeField] private int _loopCount = -1;
    
    private readonly Vector3 _targetPosition = new Vector3(12, 0.5f, 15);
    
    void Start()
    {
        transform.DOMove(_targetPosition, _duration).
            SetLoops(_loopCount, LoopType.Yoyo);
    }
}
