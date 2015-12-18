using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    public Animator weaponAnim;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            weaponAnim.SetBool("striking", true);
        }
        if(Input.GetButtonUp("Fire1"))
        {
            weaponAnim.SetBool("striking", false);
        }
        
	}
}
