
using UnityEngine;

public class LevelDifficulty : MonoBehaviour
{
    public GenerateObstacles Generate;

    private float _score;

 
    void Update()
    {
        _score = GetComponent<ScoreAndCoins>().GetRecord();

        if (_score<900) 
        {
            Generate.SetFrequncy(_score/1000);
        } 
    }
}
