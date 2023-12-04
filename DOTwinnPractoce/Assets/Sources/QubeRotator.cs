using DG.Tweening;
using UnityEngine;

public class QubeRotator : MonoBehaviour
{
    [SerializeField] private float _duration = 3f;
    [SerializeField] private int _loopCount = -1;
    
    void Start()
    {
        transform.DOLocalRotateQuaternion(
            Quaternion.LookRotation(Vector3.back), 
            _duration).SetLoops(_loopCount, LoopType.Restart);
    }
}
