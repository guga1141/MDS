using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerSimples : MonoBehaviour
{
    public GameObject targetToFollow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(targetToFollow.transform.position.x + 2f,
            targetToFollow.transform.position.y + 2f,
            transform.position.z + 2f );
    }
}

