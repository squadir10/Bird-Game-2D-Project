using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //to access more options such as text in UI
public class LogicManager : MonoBehaviour
{
    public int PlayerScore;
    public Text score;
    [ContextMenu("Increase score")]
    public void add_score()
    {
        PlayerScore += 1;
        score.text = PlayerScore.ToString();
    }

}
