using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    public bool circleAroundObject;
    public bool moveToWayPoints;

    public float speed = 0.5f;
    public float rotateAroundSpeed = 50f;
    public GameObject wayPoints;
    const float waypointGizmoRadius = 0.3f;
    int wayPoint = 0;

    Vector3 nextPosition;
    public Transform rotateAroundObject;


    void FixedUpdate()
    {
        if (moveToWayPoints)
        {
            if (transform.position == GetWayPoint(wayPoint))
            {
                CycleWayPoint();
            }
            nextPosition = GetWayPoint(wayPoint);
            transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed);
        }

        else if (circleAroundObject)
        {
            transform.RotateAround(rotateAroundObject.position, Vector3.up, rotateAroundSpeed * Time.deltaTime);
        }
    }

    private void OnDrawGizmos()
    {
        if (circleAroundObject)
        {
            Gizmos.DrawSphere(rotateAroundObject.position, waypointGizmoRadius);
        }

        if (moveToWayPoints)
        {
            for (int i = 0; i < wayPoints.transform.childCount; i++)
            {
                int j = GetNextIndex(i);
                Gizmos.DrawSphere(GetWayPoint(i), waypointGizmoRadius);
                Gizmos.DrawLine(GetWayPoint(i), GetWayPoint(j));
            }
        }
    }

    public int GetNextIndex(int i)
    {
        if (i + 1 == wayPoints.transform.childCount)
        {
            return 0;
        }

        return i + 1;
    }

    public Vector3 GetWayPoint(int i)
    {
        return wayPoints.transform.GetChild(i).position;
    }

    private void CycleWayPoint()
    {
        wayPoint = GetNextIndex(wayPoint);        
    }
}
