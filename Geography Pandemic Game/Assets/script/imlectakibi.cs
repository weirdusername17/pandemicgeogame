using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imlectakibi : MonoBehaviour
{
  public Vector3 mousepos;
  public float movespeed;

   private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            mousepos=Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousepos.z=0;
        }
        transform.position =Vector3.Lerp(transform.position, mousepos,Time.deltaTime*movespeed);
    }
}
