using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    //Prefab for instantiating apples
    public GameObject applePrefab;

    //speed at which the AppleTree moves
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float changeDirChance = 0.1f;
    public float appleDropDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // start dropping apples
        Invoke("DropApple", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        // basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;


        // changing direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // move right 

        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }


    }
     void FixedUpdate()
    {
          if (Random.value < changeDirChance)
        {
            speed *= -1;
        }
    }
    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position; //place that apple right on the apple tree
        Invoke("DropApple", appleDropDelay);
    }
}
