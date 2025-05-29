using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] public int GameTime;
    [SerializeField] public TMP_Text TimerText;

    [SerializeField] private WordsChanger _changer;
    [SerializeField] private TowerDefence _towerDefence;

    [SerializeField] private Button _startButton;

    [SerializeField] public TMP_Text _examplesText;

    private void Start()
    {
        _startButton.onClick.AddListener(StartGameSession);
    }

    private void StartGameSession()
    {
        StartCoroutine(Timer());
        _startButton.gameObject.SetActive(false);

        StartBlindPrinting();
        StartTowerDefence();
    }

    private IEnumerator Timer()
    {
        for (int i = GameTime; i >= 0; i--)
        {
            TimerText.text = GameTime.ToString();
            GameTime--;
            yield return new WaitForSeconds(1f);
        }
    }

    private void StartTowerDefence()
    {
        _towerDefence.EnemyAttack();
    }

    private void StartBlindPrinting()
    {
        _examplesText.text = _changer._listExampleString[0];
    }
}
