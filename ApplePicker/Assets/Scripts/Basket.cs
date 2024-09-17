using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2d = Input.mousePosition;
        mousePos2d.z = -Camera.main.transform.position.z;    
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2d);
        // move the x position of this Basket to the x position of the mouse
        Vector3 pos = this.transform.position;  
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }
     void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.CompareTag("Apple"))
        {
            Destroy(collidedWith);
        }
    }
}
