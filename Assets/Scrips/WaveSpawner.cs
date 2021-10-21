using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUTING }; //lista av bools
    [System.Serializable]
    public class Wave
    {
        public string name; //namnet på waven
        public Transform enemy; // enemy saken
        public int count; //hur många 
        public float rate; //hastigheten dom kommer spawnas 
    }
    public Wave[] wave;
    private int nextWave = 0;

    public float timeBetweenWaves = 5f;
    public float waveCountdown; //så vi kan bestämma själva

    private float searchCoundown = 1f; //!! Dubbelkolla vad den gör!! Den ska leta 

    private SpawnState state = SpawnState.COUTING;

    void Start()
    {
        waveCountdown = timeBetweenWaves;
    }

    void Update()
    {
        if (state == SpawnState.WAITING)
        {
            if (EnemyIsAlive() == false)
            {
                //Begin a new round
                Debug.Log("Wave Complete");
            }
            else
            {
                return;
            }
            if (waveCountdown <= 0)
            {
                if (state != SpawnState.SPAWNING)
                {
                    StartCoroutine(SpawnWave(wave[nextWave])); //kanske waves??
                    //Start spawing 
                }
                else
                {
                    waveCountdown -= Time.deltaTime;
                }
            }
        }
    }
                bool EnemyIsAlive() //kollar om den lever
                {
                    searchCoundown -= Time.deltaTime;
                    if (searchCoundown <= 0f)
                    {
                        searchCoundown = 1f;
                        if (GameObject.FindGameObjectsWithTag("Enemy") == null)
                        {
                            return false;
                        }
                    }

                    return true;
                }
        
            IEnumerator SpawnWave(Wave _wave)
            {
        Debug.Log("Spawning Wave:" + _wave.name);
                state = SpawnState.SPAWNING;

                for (int i = 0; i < _wave.count; i++) // att detta ska hända ____
                {
                    SpawnEnemy(_wave.enemy);
                    yield return new WaitForSeconds(1f / _wave.rate);
                }

                state = SpawnState.WAITING;

                yield break;
            }

            void SpawnEnemy(Transform _enemy)
            {
        //spawn enemy
       
                Debug.Log("Spawning Enemy" + _enemy.name);
        Instantiate(_enemy, transform.position, transform.rotation); 
            }

        
    
}

    

