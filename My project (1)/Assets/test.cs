using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start"); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update" + transform.position);
        transform.rotation = Quaternion.Euler(0, 0, (1 * Time.deltaTime)   + transform.rotation.eulerAngles.z);
    }
}
