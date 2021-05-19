using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreasMainMenu : MonoBehaviour
{
    public bool isLevel1;
    public bool isLevel2;
    public bool isLevel3;
    public bool isLevel4;
    public bool isLevel5;
    public bool isLevel6;
    public bool isLevel7;
    public bool isLevel8;
    public bool isLevel9;
    public bool isLevel10;
    public bool isLevel11;
    public bool isLevel12;
    public bool isLevel13;
    public bool isLevel14;
    public bool isLevel15;
    public bool isLevel16;
    public bool isLevel17;
    public bool isLevel18;
    public bool isLevel19;
    public bool isLevel20;
    public bool isLevel21;
    public bool isLevel22;
    public bool isLevel23;
    public bool isLevel24;


    public bool isCameraBottom;
    public bool isCameraTop;
    public bool isCredits;


    public MainMenuCalls mainMenuCalls;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (isCameraBottom)
            {
                mainMenuCalls.CameraToTheBottom();
            }

            else if (isCameraTop)
            {
                mainMenuCalls.CameraToTheTop();
            }

            else if (isCredits)
            {
                mainMenuCalls.CameraToCredits();
            }


            if (isLevel1) { mainMenuCalls.StartCountDown(1); }
            else if (isLevel2) { mainMenuCalls.StartCountDown(2); }
            else if (isLevel3) { mainMenuCalls.StartCountDown(3); }
            else if (isLevel4) { mainMenuCalls.StartCountDown(4); }
            else if (isLevel5) { mainMenuCalls.StartCountDown(5); }
            else if (isLevel6) { mainMenuCalls.StartCountDown(6); }
            else if (isLevel7) { mainMenuCalls.StartCountDown(7); }
            else if (isLevel8) { mainMenuCalls.StartCountDown(8); }
            else if (isLevel9) { mainMenuCalls.StartCountDown(9); }
            else if (isLevel10) { mainMenuCalls.StartCountDown(10); }
            else if (isLevel11) { mainMenuCalls.StartCountDown(11); }
            else if (isLevel12) { mainMenuCalls.StartCountDown(12); }
            else if (isLevel13) { mainMenuCalls.StartCountDown(13); }
            else if (isLevel14) { mainMenuCalls.StartCountDown(14); }
            else if (isLevel15) { mainMenuCalls.StartCountDown(15); }
            else if (isLevel16) { mainMenuCalls.StartCountDown(16); }
            else if (isLevel17) { mainMenuCalls.StartCountDown(17); }
            else if (isLevel18) { mainMenuCalls.StartCountDown(18); }
            else if (isLevel19) { mainMenuCalls.StartCountDown(19); }
            else if (isLevel20) { mainMenuCalls.StartCountDown(20); }
            else if (isLevel21) { mainMenuCalls.StartCountDown(21); }
            else if (isLevel22) { mainMenuCalls.StartCountDown(22); }
            else if (isLevel23) { mainMenuCalls.StartCountDown(23); }
            else if (isLevel24) { mainMenuCalls.StartCountDown(24); }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (isLevel1) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel2) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel3) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel4) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel5) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel6) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel7) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel8) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel9) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel10) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel11) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel12) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel13) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel14) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel15) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel16) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel17) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel18) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel19) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel20) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel21) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel22) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel23) { mainMenuCalls.CancelCountDownTimer(); }
            else if (isLevel24) { mainMenuCalls.CancelCountDownTimer(); }
        }

        if (isCredits)
        {
            mainMenuCalls.CameraToTheBottom();
        }
    }

}
