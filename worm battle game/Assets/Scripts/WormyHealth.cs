using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormyHealth : MonoBehaviour
{

    public int health;
    public int maxHealth;
    public Text txtHealth;
    private PlayerController playerCtrl;

    public GameObject DeathUI, LeftKey, RightKey, ShootKey, PauseButton;



    // Use this for initialization
    void Start()
    {
        health = maxHealth;
        txtHealth.text = health.ToString();
        playerCtrl = FindObjectOfType<PlayerController>();
    }

    void Update()
    {
      if (health <= 0)
        {
            Die();
            DeathUI.SetActive(true);
            LeftKey.SetActive(false);
            RightKey.SetActive(false);
            ShootKey.SetActive(false);
            PauseButton.SetActive(false);
        }
    }


    public void ChangeHealth(int change)
    {
        health += change;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        txtHealth.text = health.ToString();
    }

    void TakeHit(int hit)
    {
        health -= hit;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Explosion")
        {
            TakeHit(20);
        }
    }

    void Die()
    {
        playerCtrl.enabled = false;
        Destroy(this.gameObject);
    }
}
