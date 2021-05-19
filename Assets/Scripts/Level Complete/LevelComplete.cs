using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public LocalVariables localVariables;

    public void NextScene()
    {
        localVariables.MainMenuScene();
    }
}
