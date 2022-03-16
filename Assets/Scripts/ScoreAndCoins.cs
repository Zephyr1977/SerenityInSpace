using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAndCoins : MonoBehaviour
{
    private int _coinsInGame;
    public Text CoinsText;


 
    private void Update()
    {
        CoinsText.text = _coinsInGame.ToString();


        SaveRecord(); 

    }


    private void SaveRecord() 
    {
        if (_coinsInGame > PlayerPrefs.GetFloat("Record")) 
        {
            PlayerPrefs.SetFloat("Record", _coinsInGame);
        }
    }

    public float GetRecord() 
    {
        return _coinsInGame;
    }

    public void SetCoins() 
    {
        _coinsInGame++;
    }
}
