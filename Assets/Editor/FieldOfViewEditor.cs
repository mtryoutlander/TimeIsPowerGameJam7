
using System;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(FieldOfView))]

public class FieldOfViewEditor : Editor
{
    // Start is called before the first frame update
  
    private void OnSceneGUI() 
    {
        FieldOfView fov = (FieldOfView)target;
        Handles.color.white();
        Handles.DrawWireArc(fov.transform, Vector3.up, Vector3.forward, 360, fov.radius);

        Vector3 viewAngle01 = DirectionFromAngle(fov.transform.eulerAngles.y, -fov.angle / 2);
        Vector3 viewAngle02 = DirectionFromAngle(fov.transform.eulerAngles.y, fov.angle / 2);

        Handles.color = Color.yellow;
        Handles.Debug.DrawLine(fov.transform.position, fov.transform.position + viewAngle01 * fov.radius);
        Handles.Debug.DrawLine(fov.transform.position, fov.transform.position + viewAngle02 * fov.radius);
    }
        
    private Vector3 DirectionFromAngle(float eulerY, float angleInDegrees)
    {
        angleInDegrees += eulerY;

        return new Vector3(Mathf.Sin(angleInDegrees + Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees* Mathf.Deg2Rad));
    }

}

