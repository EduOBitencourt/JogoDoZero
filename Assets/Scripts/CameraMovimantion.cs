using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovimantion : MonoBehaviour
{
    public GameObject player;
    Vector3 distanciaCameraplayer;

    void Start()
    {
        distanciaCameraplayer = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + distanciaCameraplayer;
        
    }
}
