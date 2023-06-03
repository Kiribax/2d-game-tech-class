using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathzone : MonoBehaviour
{    
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        PlayerDied();
    }    
    
    private void PlayerDied() {
        LevelManager.instance.GameOver();
        gameObject.SetActive(false);
    }
}
