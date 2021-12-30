using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool fare=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fare=true)
        {
            Vector3 mousePos=Input.mousePosition;
            {
                Debug.Log(mousePos.x);
                Debug.Log(mousePos.y);
            }                
        }
    }
}
