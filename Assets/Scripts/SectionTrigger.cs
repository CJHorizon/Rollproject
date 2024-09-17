using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class SectionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        public GameObject roadSection;

        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger"))
        {
            Instantiate(roadSection, new Vector3(0, 0, -25), Quaternion.identity);
        }
    }

}


    // Update is called once per frame
    //void Update()
    //{
        
    //}
//}
