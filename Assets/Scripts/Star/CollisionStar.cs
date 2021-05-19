using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionStar : MonoBehaviour
{
    public CollectStarPlayer collectStarPlayer;

    public SphereCollider sphereCollider;
    public MeshRenderer meshRenderer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            collectStarPlayer.CollectStar();
            DisableStar();
        }
    }

    void DisableStar()
    {
        sphereCollider.enabled = false;
        meshRenderer.enabled = false;
    }

    public void EnableStar()
    {
        sphereCollider.enabled = true;
        meshRenderer.enabled = true;
    }
}
