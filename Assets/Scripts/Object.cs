using UnityEngine;
using System.Collections;

public enum ObjectType { Enviorment, Drop };

public class Object : MonoBehaviour {

    public string objectName = "";                  //Object name
    public int objectHealth = 100;                  //Object health
    public bool pickup = true;                      //Can it be picked up?

    public ObjectType objectType;                   //Object type

    public Rigidbody rig;

    void Start()
    {
        rig = this.gameObject.GetComponent<Rigidbody>();
        rig.isKinematic = true;
    }

    //Called every frame
    void Update()
    {
        CheckDestroy();
    }

    //The destroy function
    void CheckDestroy ()
    {
        if(objectHealth <= 0)
        {
            StartCoroutine(KillObject());
        }
    }

    //The apply dammage function
    public void ApplyDamage(int damage)
    {
        objectHealth = objectHealth - damage;
    }

    IEnumerator KillObject()
    {
        rig.isKinematic = false;
        rig.AddForce(Vector3.right * 10 * Time.deltaTime);

        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }
}

