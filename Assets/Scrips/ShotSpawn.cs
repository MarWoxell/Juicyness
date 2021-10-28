using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpawn : MonoBehaviour
{

    public float spawnTime;        // The amount of time between each spawn.
    public float spawnDelay;       // The amount of time before spawning starts.
    public GameObject bullet;

    public int maxDistance;
    public Transform target;
    public Transform myTransform;

    //spawn sektionen
    void Awake()
    {
        myTransform = transform;

    }

    void Start()
    {

        GameObject stop = GameObject.FindGameObjectWithTag("Player");

        target = stop.transform;

        maxDistance = 5;

        StartCoroutine(SpawnTimeDelay());

        IEnumerator SpawnTimeDelay()
        {
            while (true)
            {
                if (Vector3.Distance(target.position, myTransform.position) < maxDistance)
                {
                    Instantiate(bullet, transform.position, Quaternion.identity);
                    yield return new WaitForSeconds(spawnTime);
                }

                if (Vector3.Distance(target.position, myTransform.position) > maxDistance)
                {
                    yield return null;
                }
            }
        }

    }


}
