using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takip : MonoBehaviour
{

   private void Update()
   {

    Vector3 mousePos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
    mousePos.z=0;
    transform.position=mousePos;
   }
}
