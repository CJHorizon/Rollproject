using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PinkPickUp : MonoBehaviour

{
    private Rigidbody pinTest;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!TryGetComponent<Rigidbody>(out pinTest))
        {
            pinTest = gameObject.AddComponent<Rigidbody>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
      
        
            if (other.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
            

        }
    }
}
