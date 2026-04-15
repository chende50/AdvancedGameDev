using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target the camera will follow
    public Vector3 offset; // The offset from the target position

    //Late update is called after all Update functions have been called. Makes sure player moves first before camera follows
    void LateUpdate()
    {
        if (target != null)
        {
            //Only follow position, not rotation
            transform.position = target.position + offset;
        }
    }
}
