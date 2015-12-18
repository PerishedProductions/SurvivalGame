using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    //Variables 
    public int playerHealth = 100;                  //The players health
    public bool playerIsDead = false;               //A bool to see if the player is dead or not

    public Text healthDisplay;

	// Used for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(playerHealth <= 0)
        {
            playerIsDead = true;
        }

        healthDisplay.text = "Health:" + playerHealth;
	}
}
