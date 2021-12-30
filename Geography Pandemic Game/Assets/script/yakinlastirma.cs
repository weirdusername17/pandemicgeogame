using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yakinlastirma : MonoBehaviour
{
   public Transform Player;
    public float dampTime = 0.4f;
    private Vector3 cameraPos;
    private Vector3 velocity = Vector3.zero;

    void Update ()
    {
        cameraPos = new Vector3(Player.position.x, Player.position.y, -10f);
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, cameraPos, ref velocity, dampTime);
    }
}
