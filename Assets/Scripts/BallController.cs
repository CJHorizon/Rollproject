using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public float speed = 1;
    public float speed2 = 0.1f;
    private Rigidbody rigid;
    // Start is called before the first frame update
    private void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            rigid.AddForce(-Vector3.right * speed);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rigid.AddForce(Vector3.right * speed);
        }

       
        
        if (Input.GetAxis("Vertical") > -1)
        {
            rigid.AddForce(-Vector3.forward * speed2);
        }
        /*
        else if (Input.GetAxis("Vertical") < 0)
        {
            rigid.AddForce(-Vector3.right * speed);
        }
*/
    }
}
