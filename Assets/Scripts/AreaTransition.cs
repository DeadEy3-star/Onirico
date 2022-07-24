using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTransition : MonoBehaviour
{
    private CamaraController cam;
    public Vector2 newMinPosition;
    public Vector2 newMaxPosition;
    public Vector3 movePlayer;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<CamaraController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            cam.minPosition = newMinPosition;
            cam.maxPosition = newMaxPosition;
            other.transform.position += movePlayer;
        }
    }
}
