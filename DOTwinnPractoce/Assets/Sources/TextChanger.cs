using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration = 3f;
    
    private readonly string _startText = "Стартовый текст";
    private readonly string _replacedText = "Заменил текс";
    private readonly string _addedText = "Добавил текс";
    private readonly string _compositeText = "Заменил и перебрал";

    void Start()
    {
        _text.text = _startText;

        Sequence sequence = DOTween.Sequence();
        
        sequence.Append(_text.DOText(_replacedText, _duration));
        sequence.Append(_text.DOText(_addedText, _duration).SetRelative());
        sequence.Append(_text.DOText(_compositeText, _duration, true, ScrambleMode.All));
        sequence.Restart();
    }
}