using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceCursor : MonoBehaviour
{
    //public Transform cursorPos;
    public GameObject range;
    public float sensibility = 0.02f;
    private Vector3 origin;
    private Vector3 rangeBounds;
   
    // Start is called before the first frame update
    void Start()
    {
        rangeBounds = range.GetComponent<SpriteRenderer>().bounds.extents;
        origin = transform.position;
        //cursorPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (origin.x - transform.position.x < 0 ||
                Vector3.Distance(origin, transform.position) < rangeBounds.x)
            {
                transform.position = new Vector3(transform.position.x + Vector3.left.x * sensibility,
                                                transform.position.y, transform.position.z);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (origin.x - transform.position.x > 0 ||
                Vector3.Distance(origin, transform.position) < rangeBounds.x)
            {
                transform.position = new Vector3(transform.position.x + Vector3.right.x * sensibility,
                                                transform.position.y, transform.position.z);
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (origin.y - transform.position.y < 0 ||
                Vector3.Distance(origin, transform.position) < rangeBounds.y)
            {
                transform.position = new Vector3(transform.position.x,
                                                transform.position.y + Vector3.down.y * sensibility, 
                                                transform.position.z);
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (origin.y - transform.position.y > 0 ||
                Vector3.Distance(origin, transform.position) < rangeBounds.y)
            {
                transform.position = new Vector3(transform.position.x,
                                                transform.position.y + Vector3.up.y * sensibility,
                                                transform.position.z);
            }
        }

    }
}
