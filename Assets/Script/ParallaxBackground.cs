using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private GameObject cam;

    [SerializeField] private float parallaxEffect;

    private float xPosition;
    private float yPosition;
    private float length;
    private float height;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");

        length = GetComponent<SpriteRenderer>().bounds.size.x;
        height = GetComponent<SpriteRenderer>().bounds.size.y;

        xPosition = transform.position.x;
        yPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceMovedX = cam.transform.position.x * (1 - parallaxEffect);
        float distanceMovedY = cam.transform.position.y * (1 - parallaxEffect);
        float distanceToMoveX = cam.transform.position.x * parallaxEffect;
        float distnaceToMoveY = cam.transform.position.y * parallaxEffect;

        transform.position = new Vector3(xPosition + distanceToMoveX, yPosition + distnaceToMoveY);

        if (distanceMovedX > xPosition + length)
        {
            xPosition = xPosition + length;
        }
        else if (distanceMovedX < xPosition - length)
        {
            xPosition = xPosition - length;
        }

        if (distanceMovedY > yPosition + height)
        {
            yPosition = yPosition + height;
        }
        else if (distanceMovedY < yPosition - height)
        {
            yPosition = yPosition - height;
        }
    }
}
