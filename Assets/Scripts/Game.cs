using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    [SerializeField] private Changer _changer;
    [SerializeField] private Button _startButton;
    [SerializeField] private int _gameTime;
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] public TMP_Text _examplesText;
    [SerializeField] private Image _image;

    private void Start()
    {
        _startButton.onClick.AddListener(StartGame);
        _image.gameObject.SetActive(false);
    }

    private void StartGame()
    {
        StartCoroutine(GameTime());
        _startButton.gameObject.SetActive(false);
        _image.gameObject.SetActive(true);
        _image.sprite = _changer._listSprites[0];
        _examplesText.text = _changer._listExampleString[0];
    }

    private IEnumerator GameTime()
    {
        for (int i = _gameTime; i >= 0; i--)
        {
            _timerText.text = _gameTime.ToString();
            _gameTime--;
            yield return new WaitForSeconds(1f);
        }
    }
}
