using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
[Header("Shape Objects")]
public gameObject[] shapePrefabs
[Header("default spwn delay tome")]
public float spawnDelay = 2f;
[Header("dtaulst aoaeb time")]


    // Start is called before the first frame update
    void Start()
    {

InvokeRepeating("Spawn", spawnDelay, spawnTime);
Instantiate(shapePrefabs)
    }

    // Update is called once per frame
    void Update()
    {

    }
}
