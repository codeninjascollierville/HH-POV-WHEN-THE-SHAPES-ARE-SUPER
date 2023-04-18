using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [Header("Rigidbody Object")]
        public Rigidbody2D rb;

        [Header("default shrinking sppeed")]
        public float shrinkspeed = 3f;


    // Start is called before the first frame update
    void Start()
    {


rb.rotation = Random.Range(0f, 360f);
transform.localScale = Vector3.one * 10f;








    }

    // Update is called once per frame
    void Update()
    {

    }
}
