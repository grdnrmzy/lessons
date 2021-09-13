using System;
using UnityEngine;

public class InteritablePicker : MonoBehaviour
{
    [SerializeField] private Camera _inputCamera;

    private void Update()
    {

        var ray = _inputCamera.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            Input.mousePosition.z));
        var raycastHit = new RaycastHit();

        if (Physics.Raycast(ray, out  raycastHit))
        {
            if (raycastHit.collider.GetComponent<IInteritable>())
            {
                
            }
        }
    }
}