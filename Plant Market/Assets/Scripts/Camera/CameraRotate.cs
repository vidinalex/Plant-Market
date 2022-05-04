using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField]
    private GameObject _camTarget;
    [SerializeField]
    private float camMaxOffset;
    [SerializeField]
    private float rotationSpeed;

    private float scWidth;

    private void GetScreenWidth()
    {
        scWidth = Screen.width;
    }
    void Start()
    {
        GetScreenWidth();
    }

    private Vector3 GetTargetOffset()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 targetOffset = new Vector3(0,
            (scWidth - mousePos.x)/scWidth*camMaxOffset*2-camMaxOffset
            ,0);
        
        return targetOffset;
    }

    private void setCamRotation(Vector3 targetOffset)
    {
        _camTarget.transform.rotation = Quaternion.RotateTowards(
            _camTarget.transform.rotation,
            Quaternion.Euler(-targetOffset),
            rotationSpeed * Time.deltaTime);

        //Debug.Log(targetOffset);
    }

    void Update()
    {
        setCamRotation(GetTargetOffset());
    }
}
