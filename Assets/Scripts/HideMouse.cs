using UnityEngine;
using System.Collections;

public class HideMouse : MonoBehaviour
{

	//Start is called at the start of the scene
	void Start ()
    {
        //Locking the cursor and making it invisible
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
