using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectStarPlayer : MonoBehaviour
{
    public StarList starList;
    public LocalVariables localVariables;

    public TextMeshProUGUI starsText;

    void Start()
    {
        localVariables.starsMax = starList.allStars.Count;
        RestartStars();
    }

    public void CollectStar()
    {
        localVariables.PlaySound("CollectStar");
        localVariables.starsCollected += 1;
        starsText.text = localVariables.starsCollected.ToString() + " / " + localVariables.starsMax.ToString();
    }


    public void RestartStars()
    {
        localVariables.starsCollected = 0;        
        starsText.text = localVariables.starsCollected.ToString() + " / " + localVariables.starsMax.ToString();
    }
}
