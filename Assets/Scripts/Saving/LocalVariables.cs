using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class LocalVariables : MonoBehaviour, IUnityAdsListener
{
    [Header("Arrows")]
    public bool arrowsOne;
    public bool arrowsTwo;
    public bool joystickOne;
    public bool joystickTwo;

    [Header("Music And Sound")]
    public bool music;
    public bool sound;

    [Header("Current Level")]
    public int starsCollected;
    public int starsMax;

    [Header("Level 1")]
    public int s_deaths_levelOne;
    public bool s_levelOneComplete;

    [Header("Level 2")]
    public int s_deaths_levelTwo;
    public bool s_levelTwoComplete;

    [Header("Level 3")]
    public int s_deaths_levelThree;
    public bool s_levelThreeComplete;

    [Header("Level 4")]
    public int s_deaths_levelFour;
    public bool s_levelFourComplete;

    [Header("Level 5")]
    public int s_deaths_levelFive;
    public bool s_levelFiveComplete;

    [Header("Level 6")]
    public int s_deaths_levelSix;
    public bool s_levelSixComplete;

    [Header("Level 7")]
    public int s_deaths_levelSeven;
    public bool s_levelSevenComplete;

    [Header("Level 8")]
    public int s_deaths_levelEight;
    public bool s_levelEightComplete;

    [Header("Level 9")]
    public int s_deaths_levelNine;
    public bool s_levelNineComplete;

    [Header("Level 10")]
    public int s_deaths_levelTen;
    public bool s_levelTenComplete;

    [Header("Level 11")]
    public int s_deaths_levelEleven;
    public bool s_levelElevenComplete;

    [Header("Level 12")]
    public int s_deaths_levelTwelve;
    public bool s_levelTwelveComplete;

    [Header("Level 13")]
    public int s_deaths_levelThirteen;
    public bool s_levelThirteenComplete;

    [Header("Level 14")]
    public int s_deaths_levelFourteen;
    public bool s_levelFourteenComplete;

    [Header("Level 15")]
    public int s_deaths_levelFifteen;
    public bool s_levelFifteenComplete;

    [Header("Level 16")]
    public int s_deaths_levelSixteen;
    public bool s_levelSixteenComplete;

    [Header("Level 17")]
    public int s_deaths_levelSeventeen;
    public bool s_levelSeventeenComplete;

    [Header("Level 18")]
    public int s_deaths_levelEighteen;
    public bool s_levelEighteenComplete;

    [Header("Level 19")]
    public int s_deaths_levelNineteen;
    public bool s_levelNineteenComplete;

    [Header("Level 20")]
    public int s_deaths_levelTwenty;
    public bool s_levelTwentyComplete;

    [Header("Level 21")]
    public int s_deaths_levelTwentyOne;
    public bool s_levelTwentyOneComplete;

    [Header("Level 22")]
    public int s_deaths_levelTwentyTwo;
    public bool s_levelTwentyTwoComplete;

    [Header("Level 23")]
    public int s_deaths_levelTwentyThree;
    public bool s_levelTwentyThreeComplete;

    [Header("Level 24")]
    public int s_deaths_levelTwentyFour;
    public bool s_levelTwentyFourComplete;


    string gameID = "3446804";
    string myPlacementIdRewarded = "rewardedVideo";
    string myPlacementIdNoReward = "video";


    Scene scene;
    int currentScene;

    GlobalVariables globalVariables;

    private void Awake()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameID, false);
    }

    void Start()
    {
        globalVariables = GameObject.FindGameObjectWithTag("GlobalVariables").GetComponent<GlobalVariables>();

        scene = SceneManager.GetActiveScene();
        currentScene = scene.buildIndex;

        //Debug.Log(Application.persistentDataPath);

        UpdateEverything();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SaveGameToMain();
            //Debug.Log("Game Saved");
        }
    }


    void UpdateEverything()
    {
        s_deaths_levelOne = globalVariables.s_deaths_levelOne;
        s_levelOneComplete = globalVariables.s_levelOneComplete;

        s_deaths_levelTwo = globalVariables.s_deaths_levelTwo;
        s_levelTwoComplete = globalVariables.s_levelTwoComplete;

        s_deaths_levelThree = globalVariables.s_deaths_levelThree;
        s_levelThreeComplete = globalVariables.s_levelThreeComplete;

        s_deaths_levelFour = globalVariables.s_deaths_levelFour;
        s_levelFourComplete = globalVariables.s_levelFourComplete;

        s_deaths_levelFive = globalVariables.s_deaths_levelFive;
        s_levelFiveComplete = globalVariables.s_levelFiveComplete;

        s_deaths_levelSix = globalVariables.s_deaths_levelSix;
        s_levelSixComplete = globalVariables.s_levelSixComplete;

        s_deaths_levelSeven = globalVariables.s_deaths_levelSeven;
        s_levelSevenComplete = globalVariables.s_levelSevenComplete;

        s_deaths_levelEight = globalVariables.s_deaths_levelEight;
        s_levelEightComplete = globalVariables.s_levelEightComplete;

        s_deaths_levelNine = globalVariables.s_deaths_levelNine;
        s_levelNineComplete = globalVariables.s_levelNineComplete;

        s_deaths_levelTen = globalVariables.s_deaths_levelTen;
        s_levelTenComplete = globalVariables.s_levelTenComplete;

        s_deaths_levelEleven = globalVariables.s_deaths_levelEleven;
        s_levelElevenComplete = globalVariables.s_levelElevenComplete;

        s_deaths_levelTwelve = globalVariables.s_deaths_levelTwelve;
        s_levelTwelveComplete = globalVariables.s_levelTwelveComplete;

        s_deaths_levelThirteen = globalVariables.s_deaths_levelThirteen;
        s_levelThirteenComplete = globalVariables.s_levelThirteenComplete;

        s_deaths_levelFourteen = globalVariables.s_deaths_levelFourteen;
        s_levelFourteenComplete = globalVariables.s_levelFourteenComplete;

        s_deaths_levelFifteen = globalVariables.s_deaths_levelFifteen;
        s_levelFifteenComplete = globalVariables.s_levelFifteenComplete;

        s_deaths_levelSixteen = globalVariables.s_deaths_levelSixteen;
        s_levelSixteenComplete = globalVariables.s_levelSixteenComplete;

        s_deaths_levelSeventeen = globalVariables.s_deaths_levelSeventeen;
        s_levelSeventeenComplete = globalVariables.s_levelSeventeenComplete;

        s_deaths_levelEighteen = globalVariables.s_deaths_levelEighteen;
        s_levelEighteenComplete = globalVariables.s_levelEighteenComplete;

        s_deaths_levelNineteen = globalVariables.s_deaths_levelNineteen;
        s_levelNineteenComplete = globalVariables.s_levelNineteenComplete;

        s_deaths_levelTwenty = globalVariables.s_deaths_levelTwenty;
        s_levelTwentyComplete = globalVariables.s_levelTwentyComplete;

        s_deaths_levelTwentyOne = globalVariables.s_deaths_levelTwentyOne;
        s_levelTwentyOneComplete = globalVariables.s_levelTwentyOneComplete;

        s_deaths_levelTwentyTwo = globalVariables.s_deaths_levelTwentyTwo;
        s_levelTwentyTwoComplete = globalVariables.s_levelTwentyTwoComplete;

        s_deaths_levelTwentyThree = globalVariables.s_deaths_levelTwentyThree;
        s_levelTwentyThreeComplete = globalVariables.s_levelTwentyThreeComplete;

        s_deaths_levelTwentyFour = globalVariables.s_deaths_levelTwentyFour;
        s_levelTwentyFourComplete = globalVariables.s_levelTwentyFourComplete;

        music = globalVariables.music;
        sound = globalVariables.sound;

        arrowsOne = globalVariables.arrowsOne;
        arrowsTwo = globalVariables.arrowsTwo;
        joystickOne = globalVariables.joystickOne;
        joystickTwo = globalVariables.joystickTwo;
    }
       
    void UpdateToSave()
    {
        globalVariables.s_deaths_levelOne = s_deaths_levelOne;
        globalVariables.s_levelOneComplete = s_levelOneComplete;

        globalVariables.s_deaths_levelTwo = s_deaths_levelTwo;
        globalVariables.s_levelTwoComplete = s_levelTwoComplete;

        globalVariables.s_deaths_levelThree = s_deaths_levelThree;
        globalVariables.s_levelThreeComplete = s_levelThreeComplete;


        globalVariables.s_deaths_levelFour = s_deaths_levelFour;
        globalVariables.s_levelFourComplete = s_levelFourComplete;

        globalVariables.s_deaths_levelFive = s_deaths_levelFive;
        globalVariables.s_levelFiveComplete = s_levelFiveComplete;

        globalVariables.s_deaths_levelSix = s_deaths_levelSix;
        globalVariables.s_levelSixComplete = s_levelSixComplete;

        globalVariables.s_deaths_levelSeven = s_deaths_levelSeven;
        globalVariables.s_levelSevenComplete = s_levelSevenComplete;

        globalVariables.s_deaths_levelEight = s_deaths_levelEight;
        globalVariables.s_levelEightComplete = s_levelEightComplete;

        globalVariables.s_deaths_levelNine = s_deaths_levelNine;
        globalVariables.s_levelNineComplete = s_levelNineComplete;

        globalVariables.s_deaths_levelTen = s_deaths_levelTen;
        globalVariables.s_levelTenComplete = s_levelTenComplete;

        globalVariables.s_deaths_levelEleven = s_deaths_levelEleven;
        globalVariables.s_levelElevenComplete = s_levelElevenComplete;

        globalVariables.s_deaths_levelTwelve = s_deaths_levelTwelve;
        globalVariables.s_levelTwelveComplete = s_levelTwelveComplete;

        globalVariables.s_deaths_levelThirteen = s_deaths_levelThirteen;
        globalVariables.s_levelThirteenComplete = s_levelThirteenComplete;

        globalVariables.s_deaths_levelFourteen = s_deaths_levelFourteen;
        globalVariables.s_levelFourteenComplete = s_levelFourteenComplete;

        globalVariables.s_deaths_levelFifteen = s_deaths_levelFifteen;
        globalVariables.s_levelFifteenComplete = s_levelFifteenComplete;

        globalVariables.s_deaths_levelSixteen = s_deaths_levelSixteen;
        globalVariables.s_levelSixteenComplete = s_levelSixteenComplete;

        globalVariables.s_deaths_levelSeventeen = s_deaths_levelSeventeen;
        globalVariables.s_levelSeventeenComplete = s_levelSeventeenComplete;

        globalVariables.s_deaths_levelEighteen = s_deaths_levelEighteen;
        globalVariables.s_levelEighteenComplete = s_levelEighteenComplete;

        globalVariables.s_deaths_levelNineteen = s_deaths_levelNineteen;
        globalVariables.s_levelNineteenComplete = s_levelNineteenComplete;

        globalVariables.s_deaths_levelTwenty = s_deaths_levelTwenty;
        globalVariables.s_levelTwentyComplete = s_levelTwentyComplete;

        globalVariables.s_deaths_levelTwentyOne = s_deaths_levelTwentyOne;
        globalVariables.s_levelTwentyOneComplete = s_levelTwentyOneComplete;

        globalVariables.s_deaths_levelTwentyTwo = s_deaths_levelTwentyTwo;
        globalVariables.s_levelTwentyTwoComplete = s_levelTwentyTwoComplete;

        globalVariables.s_deaths_levelTwentyThree = s_deaths_levelTwentyThree;
        globalVariables.s_levelTwentyThreeComplete = s_levelTwentyThreeComplete;

        globalVariables.s_deaths_levelTwentyFour = s_deaths_levelTwentyFour;
        globalVariables.s_levelTwentyFourComplete = s_levelTwentyFourComplete;

        globalVariables.music = music;
        globalVariables.sound = sound;

        globalVariables.arrowsOne = arrowsOne;
        globalVariables.arrowsTwo = arrowsTwo;
        globalVariables.joystickOne = joystickOne;
        globalVariables.joystickTwo = joystickTwo;
    }

    public void SaveGameToMain()
    {
        UpdateToSave();
        globalVariables.SaveGame();
    }



    ////////////////////////////////////
    ////////////////////////////////////

    public void LevelCompleted()
    {
        if (currentScene == 1) { s_levelOneComplete = true; }
        else if (currentScene == 2) { s_levelTwoComplete = true; }
        else if (currentScene == 3) { s_levelThreeComplete = true; }
        else if (currentScene == 4) { s_levelFourComplete = true; }
        else if (currentScene == 5) { s_levelFiveComplete = true; }
        else if (currentScene == 6) { s_levelSixComplete = true; }
        else if (currentScene == 7) { s_levelSevenComplete = true; }
        else if (currentScene == 8) { s_levelEightComplete = true; }
        else if (currentScene == 9) { s_levelNineComplete = true; }
        else if (currentScene == 10) { s_levelTenComplete = true; }
        else if (currentScene == 11) { s_levelElevenComplete = true; }
        else if (currentScene == 12) { s_levelTwelveComplete = true; }
        else if (currentScene == 13) { s_levelThirteenComplete = true; }
        else if (currentScene == 14) { s_levelFourteenComplete = true; }
        else if (currentScene == 15) { s_levelFifteenComplete = true; }
        else if (currentScene == 16) { s_levelSixteenComplete = true; }
        else if (currentScene == 17) { s_levelSeventeenComplete = true; }
        else if (currentScene == 18) { s_levelEighteenComplete = true; }
        else if (currentScene == 19) { s_levelNineteenComplete = true; }
        else if (currentScene == 20) { s_levelTwentyComplete = true; }
        else if (currentScene == 21) { s_levelTwentyOneComplete = true; }
        else if (currentScene == 22) { s_levelTwentyTwoComplete = true; }
        else if (currentScene == 23) { s_levelTwentyThreeComplete = true; }
        else if (currentScene == 24) { s_levelTwentyFourComplete = true; }
        else if (currentScene > 24) { Debug.Log("YOui need to add this level"); }

        SaveGameToMain();
    }


    public void PlayerDied()
    {
        if (currentScene == 1) { s_deaths_levelOne += 1; }
        else if (currentScene == 2) { s_deaths_levelTwo += 1; }
        else if (currentScene == 3) { s_deaths_levelThree += 1; }
        else if (currentScene == 4) { s_deaths_levelFour += 1; }
        else if (currentScene == 5) { s_deaths_levelFive += 1; }
        else if (currentScene == 6) { s_deaths_levelSix += 1; }
        else if (currentScene == 7) { s_deaths_levelSeven += 1; }
        else if (currentScene == 8) { s_deaths_levelEight += 1; }
        else if (currentScene == 9) { s_deaths_levelNine += 1; }
        else if (currentScene == 10) { s_deaths_levelTen += 1; }
        else if (currentScene == 11) { s_deaths_levelEleven += 1; }
        else if (currentScene == 12) { s_deaths_levelTwelve += 1; }
        else if (currentScene == 13) { s_deaths_levelThirteen += 1; }
        else if (currentScene == 14) { s_deaths_levelFourteen += 1; }
        else if (currentScene == 15) { s_deaths_levelFifteen += 1; }
        else if (currentScene == 16) { s_deaths_levelSixteen += 1; }
        else if (currentScene == 17) { s_deaths_levelSeventeen += 1; }
        else if (currentScene == 18) { s_deaths_levelEighteen += 1; }
        else if (currentScene == 19) { s_deaths_levelNineteen += 1; }
        else if (currentScene == 20) { s_deaths_levelTwenty += 1; }
        else if (currentScene == 21) { s_deaths_levelTwentyOne += 1; }
        else if (currentScene == 22) { s_deaths_levelTwentyTwo += 1; }
        else if (currentScene == 23) { s_deaths_levelTwentyThree += 1; }
        else if (currentScene == 24) { s_deaths_levelTwentyFour += 1; }
        else if (currentScene > 24) { Debug.Log("YOui need to add this level"); }

        SaveGameToMain();
    }

    public int GetCurrentLevelDeathText()
    {
        if (currentScene == 1) { return s_deaths_levelOne; }
        else if (currentScene == 2) { return s_deaths_levelTwo; }
        else if (currentScene == 3) { return s_deaths_levelThree; }
        else if (currentScene == 4) { return s_deaths_levelFour; }
        else if (currentScene == 5) { return s_deaths_levelFive; }
        else if (currentScene == 6) { return s_deaths_levelSix; }
        else if (currentScene == 7) { return s_deaths_levelSeven; }
        else if (currentScene == 8) { return s_deaths_levelEight; }
        else if (currentScene == 9) { return s_deaths_levelNine; }
        else if (currentScene == 10) { return s_deaths_levelTen; }
        else if (currentScene == 11) { return s_deaths_levelEleven; }
        else if (currentScene == 12) { return s_deaths_levelTwelve; }
        else if (currentScene == 13) { return s_deaths_levelThirteen; }
        else if (currentScene == 14) { return s_deaths_levelFourteen; }
        else if (currentScene == 15) { return s_deaths_levelFifteen; }
        else if (currentScene == 16) { return s_deaths_levelSixteen; }
        else if (currentScene == 17) { return s_deaths_levelSeventeen; }
        else if (currentScene == 18) { return s_deaths_levelEighteen; }
        else if (currentScene == 19) { return s_deaths_levelNineteen; }
        else if (currentScene == 20) { return s_deaths_levelTwenty; }
        else if (currentScene == 21) { return s_deaths_levelTwentyOne; }
        else if (currentScene == 22) { return s_deaths_levelTwentyTwo; }
        else if (currentScene == 23) { return s_deaths_levelTwentyThree; }
        else if (currentScene == 24) { return s_deaths_levelTwentyFour; }

        else { return 999999; }
    }

    ////////////////////////////////////
    ////////////////////////////////////


    public void MainMenuScene()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void NextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 20) { SceneManager.LoadSceneAsync(0); return; }
        SceneManager.LoadSceneAsync(currentSceneIndex + 1);
    }

    public void PreviousScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(currentSceneIndex - 1);
    }

    public void ChangeToLevel(int level)
    {
        SceneManager.LoadSceneAsync(level);
    }


    ////////////////////////
    ///////////////////////


    public void MusicVolumeOn()
    {
        globalVariables.MusicVolumeOn();
    }

    public void MusicVolumeOff()
    {
        globalVariables.MusicVolumeOff();
    }

    public void SoundVolumeOn()
    {
        globalVariables.SoundVolumeOn();
    }

    public void SoundVolumeOff()
    {
        globalVariables.SoundVolumeOff();
    }


    //////////////
    /// Music ///
    /////////////

    public void PlayMusic(string name)
    {
        globalVariables.PlayMusic(name);
    }

    public void StopMusic(string name)
    {
        globalVariables.StopMusic(name);
    }


    //////////////
    /// Sound ///
    /////////////

    public void PlaySound(string name)
    {
        globalVariables.PlaySound(name);
    }



    //////////////
    ///  Ads  ///
    /////////////


    public void ShowAdNoReward()
    {
        if (globalVariables.timerCount >= 180) 
        {
            Advertisement.Show(myPlacementIdNoReward);
            globalVariables.timerCount = 0;
        }
    }




    public void OnUnityAdsReady(string placementId)
    {        
        // Optional actions to take when the end-users triggers an ad.
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (showResult == ShowResult.Finished)
        {
            Debug.Log("Finished");
            // Reward the user for watching the ad to completion.
        }
        else if (showResult == ShowResult.Skipped)
        {
            Debug.Log("Skipped");
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            // Debug.LogWarning(“The ad did not finish due to an error.);
        }
    }

}
