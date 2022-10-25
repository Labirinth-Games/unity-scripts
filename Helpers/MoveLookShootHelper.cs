using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLookShootHelper : MonoBehaviour
{
    public Camera cam;
    public float maximumLength = 200;
    public float delayToLook = 1;

    private Ray _rayMouse;
    private Vector3 _pos;
    private Vector3 _direction;
    private Quaternion rotation;

    private void Update()
    {
        if(cam != null)
        {
            RaycastHit hit;

            var mousePos = Input.mousePosition;
            _rayMouse = cam.ScreenPointToRay(mousePos);

            if (Physics.Raycast(_rayMouse.origin, _rayMouse.direction, out hit, maximumLength))
            {
                RotateToMouseDirection(gameObject, hit.point);
            } else
            {
                var pos = _rayMouse.GetPoint(maximumLength);
                RotateToMouseDirection(gameObject, pos);
            }
        }
    }

    private void RotateToMouseDirection (GameObject obj, Vector3 destination)
    {
        _direction = destination - obj.transform.position;
        rotation = Quaternion.LookRotation(_direction);
        obj.transform.localRotation = Quaternion.Lerp(obj.transform.rotation, rotation, delayToLook);
    }
}
