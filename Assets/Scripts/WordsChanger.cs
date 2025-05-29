using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WordsChanger : MonoBehaviour
{
    [SerializeField] private StartGame _game;
    [SerializeField] private Button _startButton;
    [SerializeField] private TMP_InputField _input;
    [SerializeField] public List<string> _listExampleString;
    [SerializeField] private TMP_Text _countsText;
    private int _index;

    private void Start()
    {
        SetDictionary();
        _input.onValueChanged.AddListener(ChangeSprite);
    }

    private void SetDictionary()
    {
        var count = _listExampleString.Count;
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
            _game._examplesText.text = _listExampleString[_index].ToString();
        }
    }
}
