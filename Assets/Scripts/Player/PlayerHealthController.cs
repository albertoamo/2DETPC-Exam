using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Count the number of lives of the player
public class PlayerHealthController : MonoBehaviour
{
    public int maxLives = 5; // Initial live number.
    public int lives; // Live number

    public float dmgDelay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        lives = maxLives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage()
    {
        if(lives > 0)
        {
            lives = lives - 1;
        }
        
        // The player has died.
        if(lives == 0)
        {
            GameStateManager statemanager = FindFirstObjectByType<GameStateManager>();
            statemanager.ChangeState(GameStateManager.GameState.OVER);

            return;
        }

        PlayerController hCtr = gameObject.GetComponent<PlayerController>();
        hCtr.cAnimator.SetBool("Hurt", true);
        StartCoroutine(HurtDelay());

        UIHealth health = FindFirstObjectByType<UIHealth>();
        health.UpdateHealth(lives, maxLives);

        hCtr.cRenderer.DOColor(Color.red, 0.5f).SetEase(Ease.InOutSine);
        hCtr.cRenderer.DOColor(Color.white, 0.5f).SetDelay(0.5f).SetEase(Ease.InOutSine);

        Debug.Log("The player has taken damage.");
    }

    IEnumerator HurtDelay()
    {
        yield return new WaitForSeconds(dmgDelay);

        PlayerController hCtr = gameObject.GetComponent<PlayerController>();
        hCtr.cAnimator.SetBool("Hurt", false);
    }

    public void Regenerate()
    {
        lives = Mathf.Clamp(lives + 1, 0, maxLives);

        UIHealth health = FindFirstObjectByType<UIHealth>();
        health.UpdateHealth(lives, maxLives);

        Debug.Log("The player has gained one hp.");
    }
}
