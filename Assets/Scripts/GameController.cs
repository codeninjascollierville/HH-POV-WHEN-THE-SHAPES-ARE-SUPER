using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
[Header("Shape Objects")]
public GameObject[] shapePrefabs;
[Header("default spwn delay tome")]
public float spawnDelay = 2f;
[Header("dtaulst aoaeb time")]
public float spawnTime = 3f;


    // Start is called before the first frame update
    void Start()
    {


InvokeRepeating("Spawn", spawnDelay, spawnTime);

    }

    // Update is called once per frame
    void Update()
    {

    }

void Spawn()
{


    int randomInt = Random.Range(0, shapePrefabs.Length);
    Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);




}






}
