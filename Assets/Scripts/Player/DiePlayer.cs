using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiePlayer : MonoBehaviour
{
    public bool bluePlayer = true;
    public bool redPlayer;
    [HideInInspector]
    public bool canChangeColors = true;
    float timerChangeColors;


    Vector3 startPosition;
    public float timeBeforeRespawn = 0.5f;

    public LocalVariables localVariables;
    public StarList starList;
    public CollectStarPlayer collectStarPlayer;

    public TextMeshProUGUI deathsText;

    public MeshRenderer meshRenderer;
    public BoxCollider boxCollider;
    public Rigidbody rigidBody;

    bool start = true;

    void Start()
    {
        startPosition = transform.position;
        deathsText.text = "Deaths: " + localVariables.GetCurrentLevelDeathText().ToString();
        transform.position = new Vector3(transform.position.x, 30, transform.position.z);
        rigidBody.mass = 1000;
        StartCoroutine(PlayerFallingFromSky());
    }

    private void Update()
    {
        if (start)
        {
            deathsText.text = "Deaths: " + localVariables.GetCurrentLevelDeathText().ToString();
            start = false;
        }

        if (!canChangeColors)
        {
            timerChangeColors += Time.deltaTime;

            if (timerChangeColors > 0.1f) { canChangeColors = true; timerChangeColors = 0; }
        }
    }

    public void Die()
    {
        StartCoroutine(DieCoroutine());
    }

    IEnumerator DieCoroutine()
    {
        DisablePlayer();
        localVariables.PlaySound("Died");

        while (meshRenderer.material.color.a > 0)
        {
            meshRenderer.material.color = new Color(meshRenderer.material.color.r, meshRenderer.material.color.g, meshRenderer.material.color.b, meshRenderer.material.color.a - Time.deltaTime * 3);
            yield return null;            
        }

        AddAndChangePlayerDeaths();
        collectStarPlayer.RestartStars();

        //yield return new WaitForSeconds(timeBeforeRespawn);

        bluePlayer = true;
        redPlayer = false;
        meshRenderer.material.color = new Color32(42, 132, 207, 255);
        EnableStars();
        EnablePlayer();
        localVariables.ShowAdNoReward();
    }
    
       
    void DisablePlayer()
    {
        boxCollider.enabled = false;
        rigidBody.mass = 1000;
    }

    void AddAndChangePlayerDeaths()
    {
        localVariables.PlayerDied();
        deathsText.text = "Deaths: " + localVariables.GetCurrentLevelDeathText().ToString();
    }

    void EnablePlayer()
    {
        transform.position = startPosition;
        transform.position = new Vector3(transform.position.x, 20, transform.position.z);

        meshRenderer.material.color = new Color(meshRenderer.material.color.r, meshRenderer.material.color.g, meshRenderer.material.color.b, 1);

        StartCoroutine(PlayerFallingFromSky());
    }

    IEnumerator PlayerFallingFromSky()
    {
        while (transform.position.y > 0.86f)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 0.86f, transform.position.z), 0.5f);
            yield return null;
        }
        localVariables.PlaySound("FallingFromSky");
        boxCollider.enabled = true;
        rigidBody.mass = 1;
    }

    void EnableStars()
    {
        foreach (var star in starList.allStars)
        {
            star.EnableStar();
        }
    }
}
