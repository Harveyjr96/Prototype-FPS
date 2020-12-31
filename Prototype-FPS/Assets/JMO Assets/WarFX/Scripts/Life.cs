using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Life : MonoBehaviour
{
    public float amount;
    public UnityEvent onDeath;
    public float poison;


    // Update is called once per frame
    void Update()
    {
        amount -= poison * Time.deltaTime;
        if (amount <= 0)
        {
            onDeath.Invoke();
        }
        if (amount <= 0)
        {
            Destroy(gameObject);
        }
    }
}
