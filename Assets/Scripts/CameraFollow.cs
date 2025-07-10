using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;  // השחקן
    public Vector3 offset = new Vector3(0f, 1.5f, -2f); // מרחק מהמטרה - נמוך וקרוב יותר
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        transform.LookAt(target); // תמיד להסתכל על השחקן
    }
}
