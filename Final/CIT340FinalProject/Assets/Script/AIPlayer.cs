using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayer : MonoBehaviour
{
    Transform player;

    float RotSpeed = 90f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            GameObject go = GameObject.Find("ClassicShip2");

            if(go != null)
            {
                player = go.transform;
            }
        }

        if(player == null)
        {
            return;
        }

        Vector3 dir = player.position - transform.position;
        dir.Normalize();

        float ZAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

        Quaternion desRot = Quaternion.Euler(0, 0, ZAngle);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, desRot, RotSpeed * Time.deltaTime);


    }
}
