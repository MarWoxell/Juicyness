
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WaveSpawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAITING, COUTING }; //en lista av bools - Emma 
    [System.Serializable]
    public class Wave
    {
        public string name; //namnet på waven - Emma 
        public Transform enemy; // enemy objektet - Emma 
        public int count; //hur många enemies som ska spawnas - Emma 
        public float rate; //hastigheten dom kommer spawnas - Emma 
    }
    public Wave[] wave;
    public int nextWave = 0;

    public float timeBetweenWaves = 5f;
    public float waveCountdown; //så vi kan välja hur långtid mellan varje wave - Emma 

    private float searchCoundown = 1f; 

    private SpawnState state = SpawnState.WAITING;

    public Transform[] SpawnPos;
    void Start()
    {
        waveCountdown = timeBetweenWaves;
    }

    void Update()
    {

 
        if (nextWave < wave.Length) //
        { 
           
            if (wave[nextWave].count <= 0)
            {

                nextWave++;

            }

        }
       
        if (state == SpawnState.WAITING) //tittar vilket state waven är i - Emma
        {
            Debug.Log("Waiting");
            if (EnemyIsAlive() == false) //ifall ingen enemy lever så är waven klar - Emma
            {
                //Begin a new round
                Debug.Log("Wave Complete");
              //  return;
            }
          

            if (waveCountdown <= 0) //när countdownen blir noll så kan den börjar spawna - Emma
            {
                if (state != SpawnState.SPAWNING) 
                {
                   if(nextWave < wave.Length)
                    {
                        StartCoroutine(SpawnWave(wave[nextWave]));
                    }
                
                   
                }
                else
                {
                    waveCountdown -= Time.deltaTime; 
                }
            }
        }
    }
                bool EnemyIsAlive() //kollar om någon enemy lever 
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
        
            IEnumerator SpawnWave(Wave _wave) //Att dom spawnas med en delay
            {
                state = SpawnState.SPAWNING;

                for (int i = 0; i < _wave.count; i++)
                {
                    SpawnEnemy(_wave.enemy);
                    yield return new WaitForSeconds(1f / _wave.rate);
                }

                state = SpawnState.WAITING;

                yield break;
            }

            void SpawnEnemy(Transform _enemy) //
            {
        //spawn enemy
        int RandomSpawn = Random.Range(0, SpawnPos.Length);
        Instantiate(_enemy, SpawnPos[RandomSpawn].position, transform.rotation);
        wave[nextWave].count--;
            }

        
    
}

    

