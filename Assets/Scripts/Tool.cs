using UnityEngine;
using System.Collections;

public enum ToolType { Weapon, Other };

[RequireComponent (typeof(CapsuleCollider))]
public class Tool : MonoBehaviour {

    public string toolName = "";                  //Tool Name
    public int toolHealth = 100;                  //Tool Durability
    public int toolPower = 10;                    //Tool power
    public Animator itemAnim;                     //The tools animator

    public ToolType toolType;                     //Tool Type

    private Object objectScript;                  //Object Script

    //Used for initialization
    void Start()
    {
        //Getting the tools animator
        if(toolType == ToolType.Weapon)
        {
            itemAnim = this.GetComponent<Animator>();
        }
    }

    void Update()
    {
        //Doing all the animation stuff
        if (toolType == ToolType.Weapon)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                itemAnim.SetBool("isHitting", true);
            } else if (Input.GetButtonUp("Fire1")) {
                itemAnim.SetBool("isHitting", false);
            }
        }
    }

    //All of the attacking/destroying stuff
    void OnTriggerStay(Collider coll)
    {
        if(coll.tag == "Enviorment")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                objectScript = coll.GetComponent<Object>();
                objectScript.ApplyDamage(toolPower);
            }
        }
    }

}
