using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuCalls : MonoBehaviour
{

    public Transform cameraTransform;
    public Transform skyboxCameraTransform;
    public LocalVariables localVariables;
    public CanvasGroup whiteGroundCanvasGroup;
    public CanvasGroup arrowsCanvasGroup;

    [Space(20)]

    public MeshCollider levelOneCollider;
    public MeshRenderer levelOneRenderer;
    public MeshCollider levelTwoCollider;
    public MeshRenderer levelTwoRenderer;
    public MeshCollider levelThreeCollider;
    public MeshRenderer levelThreeRenderer;
    public MeshCollider levelFourCollider;
    public MeshRenderer levelFourRenderer;
    public MeshCollider levelFiveCollider;
    public MeshRenderer levelFiveRenderer;
    public MeshCollider levelSixCollider;
    public MeshRenderer levelSixRenderer;
    public MeshCollider levelSevenCollider;
    public MeshRenderer levelSevenRenderer;
    public MeshCollider levelEightCollider;
    public MeshRenderer levelEightRenderer;
    public MeshCollider levelNineCollider;
    public MeshRenderer levelNineRenderer;
    public MeshCollider levelTenCollider;
    public MeshRenderer levelTenRenderer;
    public MeshCollider levelElevenCollider;
    public MeshRenderer levelElevenRenderer;
    public MeshCollider levelTwelveCollider;
    public MeshRenderer levelTwelveRenderer;
    public MeshCollider levelThirteenCollider;
    public MeshRenderer levelThirteenRenderer;
    public MeshCollider levelFourteenCollider;
    public MeshRenderer levelFourteenRenderer;
    public MeshCollider levelFifteenCollider;
    public MeshRenderer levelFifteenRenderer;
    public MeshCollider levelSixteenCollider;
    public MeshRenderer levelSixteenRenderer;
    public MeshCollider levelSeventeenCollider;
    public MeshRenderer levelSeventeenRenderer;
    public MeshCollider levelEighteenCollider;
    public MeshRenderer levelEighteenRenderer;
    public MeshCollider levelNineteenCollider;
    public MeshRenderer levelNineteenRenderer;
    public MeshCollider levelTwentyCollider;
    public MeshRenderer levelTwentyRenderer;


    bool startFunction = true;
    bool countDown;
    int changeToLevel;

    Color32 yellowColor = new Color32(254, 255, 83, 255);
    Color32 blackColor = new Color32(0, 0, 0, 165);


    public TextMeshProUGUI musicOnTxt;
    public TextMeshProUGUI musicOffTxt;

    public TextMeshProUGUI soundFXOnTxt;
    public TextMeshProUGUI soundFXOffTxt;

    public GameObject arrowsOneGameObject;
    public TextMeshProUGUI sizeOneText;
    public GameObject arrowsTwoGameObject;
    public TextMeshProUGUI sizeTwoText;
    public GameObject joystickOneGameObject;
    public TextMeshProUGUI typeOneText;
    public GameObject joystickTwoGameObject;
    public TextMeshProUGUI typeTwoText;

    public bool gameFade;

    void Awake()
    {
        StartGameFade();
    }


    void StartGameFade()
    {
        whiteGroundCanvasGroup.alpha = 1f;
        gameFade = true;
    }


    void Update()
    {
        if (gameFade)
        {
            if (whiteGroundCanvasGroup.alpha > 0f)
            {
                whiteGroundCanvasGroup.alpha -= Time.deltaTime * 0.7f;

                if (whiteGroundCanvasGroup.alpha <= 0)
                {
                    gameFade = false;
                }
            }
        }

        skyboxCameraTransform.Rotate(Vector3.up * 4 * Time.deltaTime, Space.World);

        if (startFunction)
        {            
            UpdateLevels();
            UpdateAudio();
            UpdateArrows();
            startFunction = false;
        }
        
        if (countDown)
        {
            whiteGroundCanvasGroup.alpha += Time.deltaTime;
            arrowsCanvasGroup.alpha -= Time.deltaTime;

            if (whiteGroundCanvasGroup.alpha >= 1)
            {
                countDown = false;
                ChangeToLevel();
                return;
            }
        }
    }


    public void CameraToTheBottom()
    {
        cameraTransform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y, 21.3f);
    }

    public void CameraToTheTop()
    {
        cameraTransform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y, -0.7f);
    }

    public void CameraToCredits()
    {
        cameraTransform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y, 42.6f);
    }


    //////////////    
    /////////////


    public void UpdateLevels()
    {
        if (!localVariables.s_levelOneComplete)
        {
            levelOneRenderer.material.color = yellowColor;
            levelTwoRenderer.material.color = blackColor;
            levelThreeRenderer.material.color = blackColor;
            levelFourRenderer.material.color = blackColor;
            levelFiveRenderer.material.color = blackColor;
            levelSixRenderer.material.color = blackColor;
            levelSevenRenderer.material.color = blackColor;
            levelEightRenderer.material.color = blackColor;
            levelNineRenderer.material.color = blackColor;
            levelTenRenderer.material.color = blackColor;
            levelElevenRenderer.material.color = blackColor;
            levelTwelveRenderer.material.color = blackColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelTwoComplete)
        {
            levelTwoRenderer.material.color = yellowColor;
            levelThreeRenderer.material.color = blackColor;
            levelFourRenderer.material.color = blackColor;
            levelFiveRenderer.material.color = blackColor;
            levelSixRenderer.material.color = blackColor;
            levelSevenRenderer.material.color = blackColor;
            levelEightRenderer.material.color = blackColor;
            levelNineRenderer.material.color = blackColor;
            levelTenRenderer.material.color = blackColor;
            levelElevenRenderer.material.color = blackColor;
            levelTwelveRenderer.material.color = blackColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelThreeComplete)
        {
            levelThreeRenderer.material.color = yellowColor;
            levelFourRenderer.material.color = blackColor;
            levelFiveRenderer.material.color = blackColor;
            levelSixRenderer.material.color = blackColor;
            levelSevenRenderer.material.color = blackColor;
            levelEightRenderer.material.color = blackColor;
            levelNineRenderer.material.color = blackColor;
            levelTenRenderer.material.color = blackColor;
            levelElevenRenderer.material.color = blackColor;
            levelTwelveRenderer.material.color = blackColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelFourComplete)
        {
            levelFourRenderer.material.color = yellowColor;
            levelFiveRenderer.material.color = blackColor;
            levelSixRenderer.material.color = blackColor;
            levelSevenRenderer.material.color = blackColor;
            levelEightRenderer.material.color = blackColor;
            levelNineRenderer.material.color = blackColor;
            levelTenRenderer.material.color = blackColor;
            levelElevenRenderer.material.color = blackColor;
            levelTwelveRenderer.material.color = blackColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelFiveComplete)
        {
            levelFiveRenderer.material.color = yellowColor;
            levelSixRenderer.material.color = blackColor;
            levelSevenRenderer.material.color = blackColor;
            levelEightRenderer.material.color = blackColor;
            levelNineRenderer.material.color = blackColor;
            levelTenRenderer.material.color = blackColor;
            levelElevenRenderer.material.color = blackColor;
            levelTwelveRenderer.material.color = blackColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelSixComplete)
        {
            levelSixRenderer.material.color = yellowColor;
            levelSevenRenderer.material.color = blackColor;
            levelEightRenderer.material.color = blackColor;
            levelNineRenderer.material.color = blackColor;
            levelTenRenderer.material.color = blackColor;
            levelElevenRenderer.material.color = blackColor;
            levelTwelveRenderer.material.color = blackColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelSevenComplete)
        {
            levelSevenRenderer.material.color = yellowColor;
            levelEightRenderer.material.color = blackColor;
            levelNineRenderer.material.color = blackColor;
            levelTenRenderer.material.color = blackColor;
            levelElevenRenderer.material.color = blackColor;
            levelTwelveRenderer.material.color = blackColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelEightComplete)
        {
            levelEightRenderer.material.color = yellowColor;
            levelNineRenderer.material.color = blackColor;
            levelTenRenderer.material.color = blackColor;
            levelElevenRenderer.material.color = blackColor;
            levelTwelveRenderer.material.color = blackColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelNineComplete)
        {
            levelNineRenderer.material.color = yellowColor;
            levelTenRenderer.material.color = blackColor;
            levelElevenRenderer.material.color = blackColor;
            levelTwelveRenderer.material.color = blackColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelTenComplete)
        {
            levelTenRenderer.material.color = yellowColor;
            levelElevenRenderer.material.color = blackColor;
            levelTwelveRenderer.material.color = blackColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelElevenComplete)
        {
            levelElevenRenderer.material.color = yellowColor;
            levelTwelveRenderer.material.color = blackColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelTwelveComplete)
        {
            levelTwelveRenderer.material.color = yellowColor;
            levelThirteenRenderer.material.color = blackColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelThirteenComplete)
        {
            levelThirteenRenderer.material.color = yellowColor;
            levelFourteenRenderer.material.color = blackColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelFourteenComplete)
        {
            levelFourteenRenderer.material.color = yellowColor;
            levelFifteenRenderer.material.color = blackColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelFifteenComplete)
        {
            levelFifteenRenderer.material.color = yellowColor;
            levelSixteenRenderer.material.color = blackColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelSixteenComplete)
        {
            levelSixteenRenderer.material.color = yellowColor;
            levelSeventeenRenderer.material.color = blackColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelSeventeenComplete)
        {
            levelSeventeenRenderer.material.color = yellowColor;
            levelEighteenRenderer.material.color = blackColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }


        else if (!localVariables.s_levelEighteenComplete)
        {
            levelEighteenRenderer.material.color = yellowColor;
            levelNineteenRenderer.material.color = blackColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelNineteenComplete)
        {
            levelNineteenRenderer.material.color = yellowColor;
            levelTwentyRenderer.material.color = blackColor;
        }

        else if (!localVariables.s_levelTwentyComplete)
        {
            levelTwentyRenderer.material.color = yellowColor;
        }
    }


    //////////////    
    /////////////


    public void CancelCountDownTimer()
    {
        countDown = false;
        whiteGroundCanvasGroup.alpha = 0;
        arrowsCanvasGroup.alpha = 0.5f;
    }

    public void StartCountDown(int level)
    {    
        if (level == 2 && !localVariables.s_levelOneComplete) { return; }
        if (level == 3 && !localVariables.s_levelTwoComplete) { return; }
        if (level == 4 && !localVariables.s_levelThreeComplete) { return; }
        if (level == 5 && !localVariables.s_levelFourComplete) { return; }
        if (level == 6 && !localVariables.s_levelFiveComplete) { return; }
        if (level == 7 && !localVariables.s_levelSixComplete) { return; }
        if (level == 8 && !localVariables.s_levelSevenComplete) { return; }
        if (level == 9 && !localVariables.s_levelEightComplete) { return; }
        if (level == 10 && !localVariables.s_levelNineComplete) { return; }
        if (level == 11 && !localVariables.s_levelTenComplete) { return; }
        if (level == 12 && !localVariables.s_levelElevenComplete) { return; }
        if (level == 13 && !localVariables.s_levelTwelveComplete) { return; }
        if (level == 14 && !localVariables.s_levelThirteenComplete) { return; }
        if (level == 15 && !localVariables.s_levelFourteenComplete) { return; }
        if (level == 16 && !localVariables.s_levelFifteenComplete) { return; }
        if (level == 17 && !localVariables.s_levelSixteenComplete) { return; }
        if (level == 18 && !localVariables.s_levelSeventeenComplete) { return; }
        if (level == 19 && !localVariables.s_levelEighteenComplete) { return; }
        if (level == 20 && !localVariables.s_levelNineteenComplete) { return; }
        if (level == 21 && !localVariables.s_levelTwentyComplete) { return; }
        if (level == 22 && !localVariables.s_levelTwentyOneComplete) { return; }
        if (level == 23 && !localVariables.s_levelTwentyTwoComplete) { return; }
        if (level == 24 && !localVariables.s_levelTwentyThreeComplete) { return; }

        localVariables.PlaySound("SelectLevel");
        changeToLevel = level;
        gameFade = false;
        countDown = true;
    }

    void ChangeToLevel()
    {
        countDown = false;
        localVariables.PlaySound("ChangeLevel");
        localVariables.ChangeToLevel(changeToLevel);
    }



    //////////////    
    /////////////


    public void UpdateAudio()
    {
        if (localVariables.music) { OnClickMusicOn(); }
        else if (!localVariables.music) { OnClickMusicOff(); }

        if (localVariables.sound) { OnClickSoundFXOn(); }
        else if (!localVariables.sound) { OnClickSoundFXOff(); }
    }


    public void OnClickMusicOn()
    {
        localVariables.music = true;
        localVariables.MusicVolumeOn();
        localVariables.SaveGameToMain();

        musicOnTxt.color = new Color32(88, 255, 115, 255);
        musicOffTxt.color = new Color32(255, 138, 105, 255);
    }

    public void OnClickMusicOff()
    {
        localVariables.music = false;
        localVariables.MusicVolumeOff();
        localVariables.SaveGameToMain();

        musicOffTxt.color = new Color32(88, 255, 115, 255);
        musicOnTxt.color = new Color32(255, 138, 105, 255);
    }

    public void OnClickSoundFXOn()
    {
        localVariables.sound = true;
        localVariables.SoundVolumeOn();
        localVariables.SaveGameToMain();

        soundFXOnTxt.color = new Color32(88, 255, 115, 255);
        soundFXOffTxt.color = new Color32(255, 138, 105, 255);
    }

    public void OnClickSoundFXOff()
    {
        localVariables.sound = false;
        localVariables.SoundVolumeOff();
        localVariables.SaveGameToMain();

        soundFXOffTxt.color = new Color32(88, 255, 115, 255);
        soundFXOnTxt.color = new Color32(255, 138, 105, 255);
    }



    ////////////////
    ///////////////

    void UpdateArrows()
    {
        if (localVariables.arrowsOne)
        {
            arrowsOneGameObject.SetActive(true); arrowsTwoGameObject.SetActive(false);
            joystickOneGameObject.SetActive(false); joystickTwoGameObject.SetActive(false);

            sizeOneText.color = new Color32(88, 255, 115, 255);
            sizeTwoText.color = new Color32(255, 138, 105, 255);
            typeOneText.color = new Color32(255, 138, 105, 255);
            typeTwoText.color = new Color32(255, 138, 105, 255);
        }

        else if (localVariables.arrowsTwo)
        {
            arrowsOneGameObject.SetActive(false); arrowsTwoGameObject.SetActive(true);
            joystickOneGameObject.SetActive(false); joystickTwoGameObject.SetActive(false);

            sizeOneText.color = new Color32(255, 138, 105, 255);
            sizeTwoText.color = new Color32(88, 255, 115, 255);
            typeOneText.color = new Color32(255, 138, 105, 255);
            typeTwoText.color = new Color32(255, 138, 105, 255);
        }

        else if (localVariables.joystickOne)
        {
            arrowsOneGameObject.SetActive(false); arrowsTwoGameObject.SetActive(false);
            joystickOneGameObject.SetActive(true); joystickTwoGameObject.SetActive(false);

            sizeOneText.color = new Color32(255, 138, 105, 255);
            sizeTwoText.color = new Color32(255, 138, 105, 255);
            typeOneText.color = new Color32(88, 255, 115, 255);
            typeTwoText.color = new Color32(255, 138, 105, 255);
        }

        else if (localVariables.joystickTwo)
        {
            arrowsOneGameObject.SetActive(false); arrowsTwoGameObject.SetActive(false);
            joystickOneGameObject.SetActive(false); joystickTwoGameObject.SetActive(true);

            sizeOneText.color = new Color32(255, 138, 105, 255);
            sizeTwoText.color = new Color32(255, 138, 105, 255);
            typeOneText.color = new Color32(255, 138, 105, 255);
            typeTwoText.color = new Color32(88, 255, 115, 255);
        }
    }

    public void OnClickSizeOne()
    {
        localVariables.arrowsOne = true;
        localVariables.arrowsTwo = false;
        localVariables.joystickOne = false;
        localVariables.joystickTwo = false;

        UpdateArrows();
        localVariables.SaveGameToMain();

        sizeOneText.color = new Color32(88, 255, 115, 255);
        sizeTwoText.color = new Color32(255, 138, 105, 255);
        typeOneText.color = new Color32(255, 138, 105, 255);
        typeTwoText.color = new Color32(255, 138, 105, 255);
    }

    public void OnClickSizeTwo()
    {
        localVariables.arrowsOne = false;
        localVariables.arrowsTwo = true;
        localVariables.joystickOne = false;
        localVariables.joystickTwo = false;

        UpdateArrows();
        localVariables.SaveGameToMain();

        sizeOneText.color = new Color32(255, 138, 105, 255);
        sizeTwoText.color = new Color32(88, 255, 115, 255);
        typeOneText.color = new Color32(255, 138, 105, 255);
        typeTwoText.color = new Color32(255, 138, 105, 255);
    }

    public void OnClickTypeOne()
    {
        localVariables.arrowsOne = false;
        localVariables.arrowsTwo = false;
        localVariables.joystickOne = true;
        localVariables.joystickTwo = false;

        UpdateArrows();
        localVariables.SaveGameToMain();

        sizeOneText.color = new Color32(255, 138, 105, 255);
        sizeTwoText.color = new Color32(255, 138, 105, 255);
        typeOneText.color = new Color32(88, 255, 115, 255);
        typeTwoText.color = new Color32(255, 138, 105, 255);
    }

    public void OnClickTypeTwo()
    {
        localVariables.arrowsOne = false;
        localVariables.arrowsTwo = false;
        localVariables.joystickOne = false;
        localVariables.joystickTwo = true;

        UpdateArrows();
        localVariables.SaveGameToMain();

        sizeOneText.color = new Color32(255, 138, 105, 255);
        sizeTwoText.color = new Color32(255, 138, 105, 255);
        typeOneText.color = new Color32(255, 138, 105, 255);
        typeTwoText.color = new Color32(88, 255, 115, 255);
    }
}
