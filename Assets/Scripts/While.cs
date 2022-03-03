using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
    }
}
