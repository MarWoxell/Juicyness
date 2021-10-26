
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUTING }; //lista av bools
    [System.Serializable]
    public class Wave
    {
        public string name; //namnet p� waven
        public Transform enemy; // enemy saken
        public int count; //hur m�nga 
        public float rate; //hastigheten dom kommer spawnas 
    }
    public Wave[] wave;
    public int nextWave = 0;

    public float timeBetweenWaves = 5f;
    public float waveCountdown; //s� vi kan best�mma sj�lva

    private float searchCoundown = 1f; //!! Dubbelkolla vad den g�r!! Den ska leta 

    private SpawnState state = SpawnState.WAITING;

    public Transform[] SpawnPos;
    void Start()
    {
        waveCountdown = timeBetweenWaves;
    }

    void Update()
    {

 
        if (nextWave < wave.Length)
        {
           
            if (wave[nextWave].count <= 0)
            {

                nextWave++;

            }

        }
       
        if (state == SpawnState.WAITING)
        {
            Debug.Log("Waiting");
            if (EnemyIsAlive() == false)
            {
                //Begin a new round
                Debug.Log("Wave Complete");
              //  return;
            }
          

            if (waveCountdown <= 0)
            {
                Debug.Log("Spawn");
                if (state != SpawnState.SPAWNING)
                {
                   if(nextWave < wave.Length)
                    {
                        StartCoroutine(SpawnWave(wave[nextWave])); //kanske waves??
                    }
                
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

                for (int i = 0; i < _wave.count; i++) // att detta ska h�nda ____
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
        int RandomSpawn = Random.Range(0, SpawnPos.Length);
                Debug.Log("Spawning Enemy" + _enemy.name);
        Instantiate(_enemy, SpawnPos[RandomSpawn].position, transform.rotation);
        wave[nextWave].count--;
            }

        
    
}

    

