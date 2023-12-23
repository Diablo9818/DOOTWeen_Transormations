using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _changedText;
    [SerializeField] private float _duration;
    [SerializeField] private bool _iSrichTextEnabled;

    private void Start()
    {
        _text.DOText(_changedText, _duration, _iSrichTextEnabled, ScrambleMode.All);
    }
}
