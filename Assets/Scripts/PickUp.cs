using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour
{

    //Variables
    public GameObject pickupCanvas;                 //The canvas we are going to be spawning and deleting -- Prefab version
    public GameObject inventory;                    //The inventory gameobject

    private GameObject pickupCanvas2;               //The canvas we are going to be spawning and deleting -- non-Prefab version

    //Used at the start of the scene
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory");
    }

    //When something enters the trigger check if it is the player and then spawn the pickupCanvas
    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            Instantiate(pickupCanvas);
        }
    }

    //When the player stays he can pickup the item via the Pickup function
    void OnTriggerStay(Collider coll)
    {
        if (coll.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                //The pickup function
                Pickup();       
            }
        }
    }

    //When the player goes out of the trigger collider the pickupCanvas will be deleted
    void OnTriggerExit(Collider coll)
    {
        if(coll.tag == "Player")
        {
            pickupCanvas2 = GameObject.FindGameObjectWithTag("Pickup Canvas");
            Destroy(pickupCanvas2);
        }
    }


    //The pickup function
    void Pickup()
    {
        //Destroying "this" and destroying the pickupCanvas
        Destroy(this.gameObject);
        pickupCanvas2 = GameObject.FindGameObjectWithTag("Pickup Canvas");
        Destroy(pickupCanvas2);
    }

}
