using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    Animator myanime;
    // Start is called before the first frame update
    void Start()
    {
        myanime = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    void OnRoll() 
    {
        myanime.SetTrigger("Roll");
    }
}
