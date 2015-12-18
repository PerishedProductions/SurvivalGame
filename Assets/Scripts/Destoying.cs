using UnityEngine;
using System.Collections;

public class Destoying : MonoBehaviour
{
    //Variables
    public int objectHealth = 100;                  //The objects health
    public GameObject drop;                         //The thing to drop when the object "dies"

    //Update function gets called every frame
    void Update()
    {
        //If the objectHealth variable is less than or equal to 0 destroy the gameobject and spawn the drop
        if(objectHealth <= 0)
        {
            Destroy(this.gameObject);
            Instantiate(drop, new Vector3(this.transform.position.x, 1.171f, this.transform.position.z), Quaternion.Euler(90, 0, 0));
        }
    }

    //When something enter the trigger collider do something!
    void OnTriggerStay(Collider coll)
    {
        //checks if the gameObject going into the trigger is the player
        if (coll.tag == "Player" && Input.GetButtonDown("Fire1"))
        {
            //Applying the damage using the ApplyDammage Function
            ApplyDamage(20);
        }
    }

    //The ApplyDamage function // method
    void ApplyDamage(int amount)
    {
        //take away a special "amount" of health 
        objectHealth = objectHealth - amount;
    }
	
}
