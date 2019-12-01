using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public float jeda = 0.8f;
    float timer;
    public GameObject[] persons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > jeda)
        {
            int random = Random.Range(0, persons.Length);
            Instantiate(persons[random], transform.position, transform.rotation);
            timer = 0;
        }
    }
}
