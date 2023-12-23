using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperCube : MonoBehaviour
{
    [SerializeField] Vector3 _position;
    [SerializeField] Vector3 _rotatePosition;
    [SerializeField] float _scaleSize;

    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(_repeats, _loopType);
        transform.DORotate(_rotatePosition, _duration).SetLoops(_repeats, _loopType);
        transform.DOScale(_scaleSize, _duration).SetLoops(_repeats, _loopType);
    }
}
