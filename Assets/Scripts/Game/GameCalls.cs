using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameCalls : MonoBehaviour
{
    public float speed = 2f;

    [Space(20)]

    public LocalVariables localVariables;
    public MovementPlayer movementPlayer;

    public GraphicRaycaster levelCompleteGraphicRaycaster;
    public CanvasGroup levelCompleteCanvasGroup;
    public Animator levelCompleteAnimator;

    public CanvasGroup whiteGroundCanvasGroup;

    public Canvas canvasArrows;

    public GraphicRaycaster menuButtonGraphicRaycaster;
    public GraphicRaycaster menuGraphicRaycaster;
    public CanvasGroup menuCanvasGroup;

    public TextMeshProUGUI musicOnTxt;
    public TextMeshProUGUI musicOffTxt;

    public TextMeshProUGUI soundFXOnTxt;
    public TextMeshProUGUI soundFXOffTxt;

    public Transform skyboxCameraTransform;

    public GameObject arrowsOneGameObject;
    public GameObject arrowsTwoGameObject;
    public GameObject joystickOneGameObject;
    public GameObject joystickTwoGameObject;

    bool startFunction = true;


    void Awake()
    {
        StartGameFade();
    }


    void Update()
    {
        skyboxCameraTransform.Rotate(Vector3.up * 4 * Time.deltaTime, Space.World);

        if (startFunction)
        {
            UpdateAudio();
            UpdateArrows();
            startFunction = false;
        }
    }

    void StartGameFade()
    {        
        whiteGroundCanvasGroup.alpha = 1f;
        StartCoroutine(StartGameFadeCoroutine());
    }

    IEnumerator StartGameFadeCoroutine()
    {
        while (whiteGroundCanvasGroup.alpha > 0f)
        {
            whiteGroundCanvasGroup.alpha -= Time.deltaTime * speed;
            yield return null;
        }
    }


    public void LevelCompleteScreen()
    {
        localVariables.PlaySound("LevelCompleted");
        localVariables.LevelCompleted();
        canvasArrows.enabled = false;
        menuButtonGraphicRaycaster.enabled = false;
        movementPlayer.horizontalAxisButton = 0;
        movementPlayer.verticalAxisButton = 0;
        levelCompleteCanvasGroup.interactable = true;
        levelCompleteGraphicRaycaster.enabled = true;
        StartCoroutine(LevelCompleteScreenCoroutine());        
    }

    IEnumerator LevelCompleteScreenCoroutine()
    {
        while (levelCompleteCanvasGroup.alpha < 1f)
        {
            levelCompleteCanvasGroup.alpha += Time.deltaTime * 0.8f;
            yield return null;
        }        
    }


    public void OnClickLevelComplete()
    {
        levelCompleteCanvasGroup.interactable = false;
        levelCompleteGraphicRaycaster.enabled = false;
        levelCompleteAnimator.SetTrigger("LeaveScreen");
    }



    ////////////////
    /// Main Menu 
    ///////////////


    public void OnClickMenu()
    {
        menuButtonGraphicRaycaster.enabled = false;
        canvasArrows.enabled = false;
        movementPlayer.horizontalAxisButton = 0;
        movementPlayer.verticalAxisButton = 0;

        StartCoroutine(ClickMenuFadeIn());
    }

    IEnumerator ClickMenuFadeIn()
    {        
        while (menuCanvasGroup.alpha < 1f)
        {
            menuCanvasGroup.alpha += Time.deltaTime * speed * 2;
            yield return null;
        }
        menuGraphicRaycaster.enabled = true;
    }


    public void OnClickBackFromMenu()
    {
        menuGraphicRaycaster.enabled = false;       

        StartCoroutine(ClickBackFromMenuFadeOff());
    }

    IEnumerator ClickBackFromMenuFadeOff()
    {
        while (menuCanvasGroup.alpha > 0f)
        {
            menuCanvasGroup.alpha -= Time.deltaTime * speed * 2;
            yield return null;
        }        
        menuButtonGraphicRaycaster.enabled = true;
        canvasArrows.enabled = true;
    }



    public void OnClickMainMenu()
    {
        menuGraphicRaycaster.enabled = false;

        StartCoroutine(ClickMainMenuFadeIn());
    }

    IEnumerator ClickMainMenuFadeIn()
    {
        while (whiteGroundCanvasGroup.alpha < 1f)
        {
            whiteGroundCanvasGroup.alpha += Time.deltaTime * speed * 1;
            yield return null;
        }

        localVariables.MainMenuScene();
    }


    ///////////////////
    //////////////////
    

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
        if (localVariables.arrowsOne) { arrowsOneGameObject.SetActive(true); arrowsTwoGameObject.SetActive(false);
                                        joystickOneGameObject.SetActive(false); joystickTwoGameObject.SetActive(false);
        }

        else if (localVariables.arrowsTwo) { arrowsOneGameObject.SetActive(false); arrowsTwoGameObject.SetActive(true);
                                        joystickOneGameObject.SetActive(false); joystickTwoGameObject.SetActive(false);
        }

        else if (localVariables.joystickOne) { arrowsOneGameObject.SetActive(false); arrowsTwoGameObject.SetActive(false);
                                        joystickOneGameObject.SetActive(true); joystickTwoGameObject.SetActive(false);
        }

        else if (localVariables.joystickTwo) { arrowsOneGameObject.SetActive(false); arrowsTwoGameObject.SetActive(false);
                                        joystickOneGameObject.SetActive(false); joystickTwoGameObject.SetActive(true);
        }
    }
}
