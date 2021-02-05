using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterController : MonoBehaviour
{

    public Animator aController;
    public Transform parent;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            aController.SetBool("walking", true);
            parent.rotation = Quaternion.Euler(new Vector3(0, 180, 3));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            aController.SetBool("walking", true);
            parent.rotation = Quaternion.Euler(new Vector3(0, 0, 3));

        }
        else
        {
            aController.SetBool("walking", false);
            
        }

        if (Input.GetKey(KeyCode.Space)) 
        {


            aController.SetTrigger("wingflapT");
                
        }


    }

   

}
