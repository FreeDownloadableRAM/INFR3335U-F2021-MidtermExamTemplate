using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    //rotate speed
    private float roty;
    

    // Start is called before the first frame update
    void Start()
    {
        roty = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //roty = (roty + 1) * Time.deltaTime;
        roty = roty + 1.0f;
        //rotate
        transform.rotation = Quaternion.Euler(90, roty, 0);
    }
}
