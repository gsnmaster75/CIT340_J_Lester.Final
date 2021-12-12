using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int laserLayer;

    public GameObject LaserPrefab;

    public float delayFire = 0.45f;
    float coolTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        laserLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        coolTimer -= Time.deltaTime;

        if (coolTimer <= 0)
        {
            coolTimer = delayFire;

            Vector3 offset = transform.rotation * new Vector3(0, 0.5f, 0);

            GameObject LaserGO = (GameObject)Instantiate(LaserPrefab, transform.position + offset, transform.rotation);
            LaserGO.layer = gameObject.layer;
        }
    }
}
