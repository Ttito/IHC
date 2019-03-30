using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerSpeed;

    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        NewMethod();
    }

    private void NewMethod()
    {
        //transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
    }
}
