using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //[SerializeField] private Transform player;

    //private void Update()
    //{
    //transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    //}

    private Transform player;

    public float minX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            Vector3 temp = transform.position;
            temp.x = player.position.x;

            if (temp.x < minX)
            {
                temp.x = minX;
            }

            if (temp.x > maxX)
            {
                temp.x = maxX;
            }

            transform.position = temp;
        }
    }
}
