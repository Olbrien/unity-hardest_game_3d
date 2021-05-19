using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalVariables : MonoBehaviour
{
    [Header("Arrows")]
    public bool arrowsOne;
    public bool arrowsTwo;
    public bool joystickOne;
    public bool joystickTwo;

    [Header("Music And Sound")]
    public bool music;
    public bool sound;

    [Header("Timer For Ads")]
    public float timerCount;

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


    [Space(20)]
    public AudioManager audioManager;




    private static GlobalVariables globalVariableInstance;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (globalVariableInstance == null) { globalVariableInstance = this; }
        else { Destroy(gameObject); }

        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Application.targetFrameRate = 60;

        SceneManager.activeSceneChanged += SceneManager_activeSceneChanged;  // Isto é para ler o UpdateState sempre que 
                                                                             // muda a cena. Sem isto, o Start e Awake não 
                                                                             // funciona.
    }

    private void SceneManager_activeSceneChanged(Scene arg0, Scene arg1)
    {
        LoadGame();
    }


    void Update()
    {
        timerCount += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadGame();
            //Debug.Log("Game Loaded");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
            activity.Call<bool>("moveTaskToBack", true);
        }

        if (Input.GetKeyDown(KeyCode.Home))
        {
            AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
            activity.Call<bool>("moveTaskToBack", true);
        }

        if (Input.GetKeyDown(KeyCode.Menu))
        {
            AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
            activity.Call<bool>("moveTaskToBack", true);
        }
    }


    public void SaveGame()
    {
        SaveLoadManager.SavePlayerInt(this);
        //SaveLoadManager.SavePlayerFloat(this);
        SaveLoadManager.SavePlayerBool(this);
        //Debug.Log("Saving Game");
    }


    public void LoadGame()
    {
        int[] loadedStatsInt = SaveLoadManager.LoadPlayerInt();

        s_deaths_levelOne = loadedStatsInt[0];
        s_deaths_levelTwo = loadedStatsInt[1];
        s_deaths_levelThree = loadedStatsInt[2];
        s_deaths_levelFour = loadedStatsInt[3];
        s_deaths_levelFive = loadedStatsInt[4];
        s_deaths_levelSix = loadedStatsInt[5];
        s_deaths_levelSeven = loadedStatsInt[6];
        s_deaths_levelEight = loadedStatsInt[7];
        s_deaths_levelNine = loadedStatsInt[8];
        s_deaths_levelTen = loadedStatsInt[9];
        s_deaths_levelEleven = loadedStatsInt[10];
        s_deaths_levelTwelve = loadedStatsInt[11];
        s_deaths_levelThirteen = loadedStatsInt[12];
        s_deaths_levelFourteen = loadedStatsInt[13];
        s_deaths_levelFifteen = loadedStatsInt[14];
        s_deaths_levelSixteen = loadedStatsInt[15];
        s_deaths_levelSeventeen = loadedStatsInt[16];
        s_deaths_levelEighteen = loadedStatsInt[17];
        s_deaths_levelNineteen = loadedStatsInt[18];
        s_deaths_levelTwenty = loadedStatsInt[19];
        s_deaths_levelTwentyOne = loadedStatsInt[20];
        s_deaths_levelTwentyTwo = loadedStatsInt[21];
        s_deaths_levelTwentyThree = loadedStatsInt[22];
        s_deaths_levelTwentyFour = loadedStatsInt[23];        


        //float[] loadedStatsFloat = SaveLoadManager.LoadPlayerFloat();



        bool[] loadedStatsBool = SaveLoadManager.LoadPlayerBool();

        s_levelOneComplete = loadedStatsBool[0];
        s_levelTwoComplete = loadedStatsBool[1];
        s_levelThreeComplete = loadedStatsBool[2];
        s_levelFourComplete = loadedStatsBool[3];
        s_levelFiveComplete = loadedStatsBool[4];
        s_levelSixComplete = loadedStatsBool[5];
        s_levelSevenComplete = loadedStatsBool[6];
        s_levelEightComplete = loadedStatsBool[7];
        s_levelNineComplete = loadedStatsBool[8];
        s_levelTenComplete = loadedStatsBool[9];
        s_levelElevenComplete = loadedStatsBool[10];
        s_levelTwelveComplete = loadedStatsBool[11];
        s_levelThirteenComplete = loadedStatsBool[12];
        s_levelFourteenComplete = loadedStatsBool[13];
        s_levelFifteenComplete = loadedStatsBool[14];
        s_levelSixteenComplete = loadedStatsBool[15];
        s_levelSeventeenComplete = loadedStatsBool[16];
        s_levelEighteenComplete = loadedStatsBool[17];
        s_levelNineteenComplete = loadedStatsBool[18];
        s_levelTwentyComplete = loadedStatsBool[19];
        s_levelTwentyOneComplete = loadedStatsBool[20];
        s_levelTwentyTwoComplete = loadedStatsBool[21];
        s_levelTwentyThreeComplete = loadedStatsBool[22];
        s_levelTwentyFourComplete = loadedStatsBool[23];

        music = loadedStatsBool[24];
        sound = loadedStatsBool[25];

        arrowsOne = loadedStatsBool[26];
        arrowsTwo = loadedStatsBool[27];
        joystickOne = loadedStatsBool[28];
        joystickTwo = loadedStatsBool[29];
    }



    ///////////////////////////////
    //////////////////////////////

    public void MusicVolumeOn()
    {
        audioManager.MusicVolumeOn();
    }

    public void MusicVolumeOff()
    {
        audioManager.MusicVolumeOff();
    }

    public void SoundVolumeOn()
    {
        audioManager.SoundVolumeOn();
    }

    public void SoundVolumeOff()
    {
        audioManager.SoundVolumeOff();
    }



    //////////////
    /// Music ///
    /////////////

    public void PlayMusic(string name)
    {
        audioManager.PlayMusic(name);
    }

    public void StopMusic(string name)
    {
        audioManager.StopMusic(name);
    }


    //////////////
    /// Sound ///
    /////////////

    public void PlaySound(string name)
    {
        audioManager.PlaySound(name);
    }
}
