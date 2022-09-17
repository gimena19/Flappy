
using UnityEngine;

public class parallaxefect : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 previousCameraPosition;
    [SerializeField] private float ParallaxMultiplier;
    private float spritewidth, startPosition;
    void Start()
    {
        cameraTransform = Camera.main.transform;
        previousCameraPosition = cameraTransform.position;
        spritewidth = GetComponent<SpriteRenderer>().bounds.size.x;
        startPosition = transform.position.x;
        
    }


    void LateUpdate()
    {
        float deltaX = (cameraTransform.position.x - previousCameraPosition.x)*ParallaxMultiplier;
        float moveAmount = cameraTransform.position.x * (1 - ParallaxMultiplier);
        transform.Translate(new Vector3(deltaX, 0, 0));
        previousCameraPosition = cameraTransform.position;

        if(moveAmount > startPosition + spritewidth)
        {
            transform.Translate(new Vector3(spritewidth, 0, 0));
            startPosition += spritewidth;
        }
        else if(moveAmount < startPosition - spritewidth)
        {
            transform.Translate(new Vector3(-spritewidth, 0, 0));
            startPosition -= spritewidth;
        }
    }
}
