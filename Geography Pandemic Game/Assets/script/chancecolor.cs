using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class chancecolor : MonoBehaviour
{
        public Material startcolor;
        public Material hovercolor;
        bool mouseOver = false; 

        private void OnMouseEnter()
        { mouseOver = true;
        gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
        
        private void OnMouseExit() 
        { mouseOver = false;
        gameObject.GetComponent<Renderer>().material.color = Color.white;
    }
    
}
