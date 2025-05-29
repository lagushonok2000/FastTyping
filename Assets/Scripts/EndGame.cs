using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject _defeatPanel;
    [SerializeField] private GameObject _victoryPanel;
    [SerializeField] private TMP_Text _countsText;

    //public void End()
    //{
    //    if (CheckWin()) Win(); else Lose();
    //}
    //private void Win()
    //{
    //    _levelTimer._timerText.text = "0";
    //    _victoryPanel.SetActive(true);
    //}

    //private void Lose()
    //{
    //    _levelTimer._timerText.text = "0";
    //    _defeatPanel.SetActive(true);
    //    _pointsManager.ResetLevelPoints();
    //}
}
