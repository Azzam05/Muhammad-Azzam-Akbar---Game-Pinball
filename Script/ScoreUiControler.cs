using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUiControler : MonoBehaviour
{
    public TMP_Text scoreText;

    public ScoreManager scoreManager;

    private void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
