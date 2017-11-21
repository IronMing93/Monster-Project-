
using UnityEngine;

public class Move : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 despriedPostion = target.position + offset;
        Vector3 smoothPostion = Vector3.Lerp(transform.position, despriedPostion,smoothSpeed);
        transform.position = smoothPostion;
        transform.LookAt(target); 


        transform.position = smoothPostion ;
        transform.LookAt(target);
    }

	
}
