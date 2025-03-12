using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    [SerializeField] private TMP_InputField _input;
    [SerializeField] private Image _image;
    [SerializeField] private Sprite _defaultSprite;
    [SerializeField] private List<string> _listInputString;
    [SerializeField] public List<string> _listExampleString;
    [SerializeField] private List<Sprite> _listSprites;
    [SerializeField] private Dictionary<string, Sprite> _dictionary;

    private void Start()
    {
        SetDictionary();
        _input.onValueChanged.AddListener(ChangeSprite);
    }

    private void SetDictionary()
    {
        _dictionary = new Dictionary<string, Sprite>();
        var count = _listInputString.Count;

        if (_listInputString.Count != _listSprites.Count)
        {
            return;
        }

        for (int i = 0; i < count; i++)
        {
            _dictionary.Add(_listInputString[i], _listSprites[i]);
        }
    }

    private void ChangeSprite(string s)
    {
        foreach (var element in _dictionary)
        {
            if (element.Key == s)
            {
                _image.sprite = element.Value;
            }
            else
            {
                _image.sprite = _defaultSprite;
            }
        }
    }
}
