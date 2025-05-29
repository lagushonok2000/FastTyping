using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] public int TowerHealth;
    [SerializeField] private TMP_Text _towerHealthText;

    public void GetAttacked()
    {
        _towerHealthText.text = TowerHealth + "/" + TowerHealth.ToString();
    }
}
