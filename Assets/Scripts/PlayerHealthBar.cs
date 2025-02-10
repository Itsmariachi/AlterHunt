using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayerHealthBar : MonoBehaviour
{
   public Slider healthSlider;
   public Slider easeHealthSlider;
   public float maxHealth = 100f;
   public float health;
    private float lerpSpeed = 0.02f;
    public GameObject camera;
    public GameObject DeathScreen;



    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        DeathScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(healthSlider.value != health){
            healthSlider.value = health;
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            takeDamage(10);
        }

        if(healthSlider.value != easeHealthSlider.value){
            easeHealthSlider.value = Mathf.Lerp(easeHealthSlider.value, health, lerpSpeed);
        }

        if(health <= 0){
            DeathScreen.SetActive(true);
        }

        if(camera.activeInHierarchy)
        {
            
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void takeDamage(float damage){
        health -= damage;
        
    }
}
