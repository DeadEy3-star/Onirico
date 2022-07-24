using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public Transform player;
    public float smoothing;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position != player.position)
        {
            Vector3 playerPosition = new Vector3(player.position.x, player.position.y, transform.position.z);

            playerPosition.x = Mathf.Clamp(transform.position.x, minPosition.x, maxPosition.x);
            playerPosition.y = Mathf.Clamp(transform.position.y, minPosition.y, maxPosition.y);



            transform.position = Vector3.Lerp(transform.position, playerPosition, smoothing);
        }
    }
}
 