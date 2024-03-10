using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    private GameObject cam;

    [SerializeField] private float parallaxEffect;

    private float xPosition;
    private float yPosition;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");

        xPosition = transform.position.x;
        yPosition = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToMoveX = cam.transform.position.x * parallaxEffect;
        float distnaceToMoveY = cam.transform.position.y * parallaxEffect;

        transform.position = new Vector3(xPosition + distanceToMoveX, yPosition + distnaceToMoveY);
    }
}
