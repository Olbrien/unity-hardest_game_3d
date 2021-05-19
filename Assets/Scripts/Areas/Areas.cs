using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Areas : MonoBehaviour
{

    public bool isExit;
    public bool isCheckpoint;
    public bool isTeleport;

    public bool isTurnBlue;
    public bool isTurnRed;

    public Transform teleportLocation;

    public LocalVariables localVariables;
    public GameCalls gameCalls;

    

    public MeshCollider meshCollider;
    public MovementPlayer movementPlayer;
    public DiePlayer diePlayer;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (isExit)
            {
                if (localVariables.starsCollected == localVariables.starsMax)
                {
                    gameCalls.LevelCompleteScreen();                    
                    //Debug.Log("Level Complete");
                }
                
                else 
                {
                    //Debug.Log("Missing Stars");
                }
            }

            if (isTeleport && movementPlayer.canTeleport)
            {
                movementPlayer.transform.position = new Vector3 (teleportLocation.position.x, movementPlayer.transform.position.y,
                                                                  teleportLocation.position.z);
                localVariables.PlaySound("Teleport");
                movementPlayer.canTeleport = false;
            }

            if (isTurnBlue)
            {
                diePlayer.bluePlayer = true;
                diePlayer.redPlayer = false;
                diePlayer.meshRenderer.material.color = new Color32(42, 132, 207, 255);
            }

            else if (isTurnRed)
            {
                diePlayer.bluePlayer = false;
                diePlayer.redPlayer = true;
                diePlayer.meshRenderer.material.color = new Color32(236, 32, 32, 255);
            }
        }
    }

}
