using UnityEngine;

public class HandMovementController : MonoBehaviour
{
    public Transform leftHandTransform;   
    public Transform rightHandTransform;  
    public Transform headTransform;       
    public float movementSpeed = 2.0f;  

    public float threshhold = 0.01f;

    private Vector3 lastLeftHandPosition;
    private Vector3 lastRightHandPosition;

    private void Start()
    {
        
        lastLeftHandPosition = leftHandTransform.localPosition;
        lastRightHandPosition = rightHandTransform.localPosition;
    }

    public void SetSpeed(float speed)
    {
        this.movementSpeed = speed;
    }

    private void Update()
    {
        
        Vector3 currentLeftHandPosition = leftHandTransform.localPosition;
        Vector3 currentRightHandPosition = rightHandTransform.localPosition;

        
        float leftHandMovement = currentLeftHandPosition.y - lastLeftHandPosition.y;
        float rightHandMovement = currentRightHandPosition.y - lastRightHandPosition.y;

        
        if ((leftHandMovement > threshhold && rightHandMovement < threshhold) || (leftHandMovement < threshhold && rightHandMovement > threshhold))
        {
            
            Vector3 forwardMovement = headTransform.forward * movementSpeed * Time.deltaTime;
            forwardMovement.y = 0; 
            transform.position += forwardMovement;
        }

       
        lastLeftHandPosition = currentLeftHandPosition;
        lastRightHandPosition = currentRightHandPosition;
    }
}
