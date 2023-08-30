using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAt : MonoBehaviour
{
    public Vector2 intensity = new(10, 5);
    public float speed = 10;
    [HideInInspector] public Vector2 mPoint;

    private void Update()
    {
        GetMPoint();

        Vector3 targetPos = new((mPoint.x * 2 - 1) * intensity.x, (mPoint.y * 2 - 1) * intensity.y,transform.position.z);
        transform.position = transform.position + (targetPos - transform.position) * Mathf.Min(1,speed * Time.deltaTime);
    }

    private void GetMPoint()
    {
        mPoint = new(Input.mousePosition.x / Screen.width, Input.mousePosition.y / Screen.height);
    }
}
