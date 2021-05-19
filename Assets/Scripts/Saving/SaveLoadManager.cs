using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class SaveLoadManager
{

    public static void SavePlayerInt(GlobalVariables globalVariables)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "//playerInt.sav", FileMode.Create);

        PlayerDataInt data = new PlayerDataInt(globalVariables);

        bf.Serialize(stream, data);
        stream.Close();
    }


    public static int[] LoadPlayerInt()
    {
        if (File.Exists(Application.persistentDataPath + "//playerInt.sav"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "//playerInt.sav", FileMode.Open);

            PlayerDataInt data = bf.Deserialize(stream) as PlayerDataInt;
            stream.Close();
            return data.stats;
        }

        else
        {
            var standard = new int[24];
            standard[0] = 0; // globalVariables.s_deaths_levelOne;
            standard[1] = 0; // globalVariables.s_deaths_levelTwo;
            standard[2] = 0; // globalVariables.s_deaths_levelThree;
            standard[3] = 0; // globalVariables.s_deaths_levelFour;
            standard[4] = 0; // globalVariables.s_deaths_levelFive;
            standard[5] = 0; // globalVariables.s_deaths_levelSix;
            standard[6] = 0; // globalVariables.s_deaths_levelSeven;
            standard[7] = 0; // globalVariables.s_deaths_levelEight;
            standard[8] = 0; // globalVariables.s_deaths_levelNine;
            standard[9] = 0; // globalVariables.s_deaths_levelTen;
            standard[10] = 0; // globalVariables.s_deaths_levelEleven;
            standard[11] = 0; // globalVariables.s_deaths_levelTwelve;
            standard[12] = 0; // globalVariables.s_deaths_levelThirteen;
            standard[13] = 0; // globalVariables.s_deaths_levelFourteen;
            standard[14] = 0; // globalVariables.s_deaths_levelFifteen;
            standard[15] = 0; // globalVariables.s_deaths_levelSixteen;
            standard[16] = 0; // globalVariables.s_deaths_levelSeventeen;
            standard[17] = 0; // globalVariables.s_deaths_levelEighteen;
            standard[18] = 0; // globalVariables.s_deaths_levelNineteen;
            standard[19] = 0; // globalVariables.s_deaths_levelTwenty;
            standard[20] = 0; // globalVariables.s_deaths_levelTwentyOne;
            standard[21] = 0; // globalVariables.s_deaths_levelTwentyTwo;
            standard[22] = 0; // globalVariables.s_deaths_levelTwentyThree;
            standard[23] = 0; // globalVariables.s_deaths_levelTwentyFour;


            //Debug.Log("No Loading File.");
            return standard;
        }
    }





    //public static void SavePlayerFloat(GlobalVariables globalVariables)
    //{
    //    BinaryFormatter bf = new BinaryFormatter();
    //    FileStream stream = new FileStream(Application.persistentDataPath + "//playerFloat.sav", FileMode.Create);

    //    PlayerDataFloat data = new PlayerDataFloat(globalVariables);

    //    bf.Serialize(stream, data);
    //    stream.Close();
    //}


    //public static float[] LoadPlayerFloat()
    //{
    //    if (File.Exists(Application.persistentDataPath + "//playerFloat.sav"))
    //    {
    //        BinaryFormatter bf = new BinaryFormatter();
    //        FileStream stream = new FileStream(Application.persistentDataPath + "//playerFloat.sav", FileMode.Open);

    //        PlayerDataFloat data = bf.Deserialize(stream) as PlayerDataFloat;
    //        stream.Close();
    //        return data.stats;
    //    }

    //    else
    //    {
    //        var standard = new float[1];
    //        standard[0] = 0; // globalVariables.;

    //        //Debug.Log("No Loading File.");
    //        return standard;
    //    }
    //}




    public static void SavePlayerBool(GlobalVariables globalVariables)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "//playerBool.sav", FileMode.Create);

        PlayerDataBool data = new PlayerDataBool(globalVariables);

        bf.Serialize(stream, data);
        stream.Close();
    }


    public static bool[] LoadPlayerBool()
    {
        if (File.Exists(Application.persistentDataPath + "//playerBool.sav"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "//playerBool.sav", FileMode.Open);

            PlayerDataBool data = bf.Deserialize(stream) as PlayerDataBool;
            stream.Close();
            return data.stats;
        }

        else
        {
            var standard = new bool[30];

            standard[0] = false; // globalVariables.s_levelOneComplete;            
            standard[1] = false; // globalVariables.s_levelTwoComplete;      
            standard[2] = false; // globalVariables.s_levelThreeComplete;      
            standard[3] = false; // globalVariables.s_levelFourComplete;
            standard[4] = false; // globalVariables.s_levelFiveComplete;
            standard[5] = false; // globalVariables.s_levelSixComplete;
            standard[6] = false; // globalVariables.s_levelSevenComplete;
            standard[7] = false; // globalVariables.s_levelEightComplete;
            standard[8] = false; // globalVariables.s_levelNineComplete;
            standard[9] = false; // globalVariables.s_levelTenComplete;
            standard[10] = false; // globalVariables.s_levelElevenComplete;
            standard[11] = false; // globalVariables.s_levelTwelveComplete;
            standard[12] = false; // globalVariables.s_levelThirteenComplete;
            standard[13] = false; // globalVariables.s_levelFourteenComplete;
            standard[14] = false; // globalVariables.s_levelFifteenComplete;
            standard[15] = false; // globalVariables.s_levelSixteenComplete;
            standard[16] = false; // globalVariables.s_levelSeventeenComplete;
            standard[17] = false; // globalVariables.s_levelEighteenComplete;
            standard[18] = false; // globalVariables.s_levelNineteenComplete;
            standard[19] = false; // globalVariables.s_levelTwentyComplete;
            standard[20] = false; // globalVariables.s_levelTwentyOneComplete;
            standard[21] = false; // globalVariables.s_levelTwentyTwoComplete;
            standard[22] = false; // globalVariables.s_levelTwentyThreeComplete;
            standard[23] = false; // globalVariables.s_levelTwentyFourComplete;

            standard[24] = true; // globalVariables.music;
            standard[25] = true; // globalVariables.sound;

            standard[26] = true; // globalVariables.arrowsOne;
            standard[27] = false; // globalVariables.arrowsTwo;
            standard[28] = false; // globalVariables.joystickOne;
            standard[29] = false; // globalVariables.joystickTwo;


            //Debug.Log("No Loading File.");
            return standard;
        }
    }
}

[Serializable]
public class PlayerDataInt
{

    public int[] stats;

    public PlayerDataInt(GlobalVariables globalVariables)
    {
        stats = new int[24];
        stats[0] = globalVariables.s_deaths_levelOne;
        stats[1] = globalVariables.s_deaths_levelTwo;
        stats[2] = globalVariables.s_deaths_levelThree;
        stats[3] = globalVariables.s_deaths_levelFour;
        stats[4] = globalVariables.s_deaths_levelFive;
        stats[5] = globalVariables.s_deaths_levelSix;
        stats[6] = globalVariables.s_deaths_levelSeven;
        stats[7] = globalVariables.s_deaths_levelEight;
        stats[8] = globalVariables.s_deaths_levelNine;
        stats[9] = globalVariables.s_deaths_levelTen;
        stats[10] = globalVariables.s_deaths_levelEleven;
        stats[11] = globalVariables.s_deaths_levelTwelve;
        stats[12] = globalVariables.s_deaths_levelThirteen;
        stats[13] = globalVariables.s_deaths_levelFourteen;
        stats[14] = globalVariables.s_deaths_levelFifteen;
        stats[15] = globalVariables.s_deaths_levelSixteen;
        stats[16] = globalVariables.s_deaths_levelSeventeen;
        stats[17] = globalVariables.s_deaths_levelEighteen;
        stats[18] = globalVariables.s_deaths_levelNineteen;
        stats[19] = globalVariables.s_deaths_levelTwenty;
        stats[20] = globalVariables.s_deaths_levelTwentyOne;
        stats[21] = globalVariables.s_deaths_levelTwentyTwo;
        stats[22] = globalVariables.s_deaths_levelTwentyThree;
        stats[23] = globalVariables.s_deaths_levelTwentyFour;
    }
}


//[Serializable]
//public class PlayerDataFloat
//{

//    public float[] stats;

//    public PlayerDataFloat(GlobalVariables globalVariables)
//    {
//        //stats = new float[5];
//        //stats[0] = globalVariables.;
//    }

//}

[Serializable]
public class PlayerDataBool
{

    public bool[] stats;

    public PlayerDataBool(GlobalVariables globalVariables)
    {
        stats = new bool[30];
        stats[0] = globalVariables.s_levelOneComplete;            
        stats[1] = globalVariables.s_levelTwoComplete;      
        stats[2] = globalVariables.s_levelThreeComplete;      
        stats[3] = globalVariables.s_levelFourComplete;
        stats[4] = globalVariables.s_levelFiveComplete;
        stats[5] = globalVariables.s_levelSixComplete;
        stats[6] = globalVariables.s_levelSevenComplete;
        stats[7] = globalVariables.s_levelEightComplete;
        stats[8] = globalVariables.s_levelNineComplete;
        stats[9] = globalVariables.s_levelTenComplete;
        stats[10] = globalVariables.s_levelElevenComplete;
        stats[11] = globalVariables.s_levelTwelveComplete;
        stats[12] = globalVariables.s_levelThirteenComplete;
        stats[13] = globalVariables.s_levelFourteenComplete;
        stats[14] = globalVariables.s_levelFifteenComplete;
        stats[15] = globalVariables.s_levelSixteenComplete;
        stats[16] = globalVariables.s_levelSeventeenComplete;
        stats[17] = globalVariables.s_levelEighteenComplete;
        stats[18] = globalVariables.s_levelNineteenComplete;
        stats[19] = globalVariables.s_levelTwentyComplete;
        stats[20] = globalVariables.s_levelTwentyOneComplete;
        stats[21] = globalVariables.s_levelTwentyTwoComplete;
        stats[22] = globalVariables.s_levelTwentyThreeComplete;
        stats[23] = globalVariables.s_levelTwentyFourComplete;

        stats[24] = globalVariables.music;
        stats[25] = globalVariables.sound;

        stats[26] = globalVariables.arrowsOne;
        stats[27] = globalVariables.arrowsTwo;
        stats[28] = globalVariables.joystickOne;
        stats[29] = globalVariables.joystickTwo;

    }

}
