using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miObjeto : MonoBehaviour
{   
    public float speed = 8f;
    public float posz = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z > posz)
        {
            Destroy(this.gameObject);
        }
        

    }
}
