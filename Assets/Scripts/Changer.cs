using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Changer : MonoBehaviour
{
    [SerializeField] private Game _game;
    [SerializeField] private Button _startButton;
    [SerializeField] private TMP_InputField _input;
    [SerializeField] private Image _image;
    [SerializeField] private List<string> _listInputString;
    [SerializeField] public List<string> _listExampleString;
    [SerializeField] public List<Sprite> _listSprites;
    [SerializeField] private Dictionary<string, Sprite> _dictionary;
    [SerializeField] private TMP_Text _countsText;
    private int _index;

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
        if (_listExampleString[_index] == s)
        {
            _index++;
            if (_index > _listExampleString.Count - 1) return;
            Counts.AllPoints++;
            _countsText.text = "очки: " + Counts.AllPoints.ToString();
            _input.text = "";

            _image.sprite = _listSprites[_index];
            _game._examplesText.text = _listExampleString[_index].ToString();
        }
    }
}
