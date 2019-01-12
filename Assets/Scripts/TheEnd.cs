using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{

    public GameObject endWrite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("End");
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        endWrite.SetActive(true);
    }
}
