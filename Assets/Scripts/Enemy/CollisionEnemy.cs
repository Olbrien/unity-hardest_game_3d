using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour
{
    public bool blueEnemy;
    public bool redEnemy;

    public DiePlayer diePlayer;

    public CapsuleCollider capsuleCollider;
    public MeshRenderer meshRenderer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (blueEnemy && diePlayer.bluePlayer) { return; }
            else if (blueEnemy && diePlayer.redPlayer) { diePlayer.Die(); return; }

            if (redEnemy && diePlayer.redPlayer) { return; }
            else if (redEnemy && diePlayer.bluePlayer) { diePlayer.Die(); return; }            

            diePlayer.Die();
        }
    }
}
