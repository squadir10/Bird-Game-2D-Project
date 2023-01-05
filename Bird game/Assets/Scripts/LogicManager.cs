using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //to access more options such as text in UI
using UnityEngine.SceneManagement; // to control scenes 


//this script is in charge of keeping score
public class LogicManager : MonoBehaviour
{
    
    public int PlayerScore; //variable called playerscore
    public Text score; //reference to the UI text called "score text"
    [ContextMenu("Increase score")] //I use this to make sure this is working properly without having 
    //to involve the whole game itself. I can just test this specific element itself.
    
    //this function is in charge of adding the score
    public void add_score(int Score_To_Add) 
    {
        PlayerScore += Score_To_Add; // when player passes through pipe add a number based off of the number in the 
        //logid.add_score in the middle.cs script
        score.text = PlayerScore.ToString(); //change the UI to that of the playerscore so it is constantly updated
        
        
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
