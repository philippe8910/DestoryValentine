using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField] private GameObject bulletObject;

    [SerializeField] private Vector3 resetPosition;

    [SerializeField] private Quaternion resetQuaternion;
    // Start is called before the first frame update
    void Start()
    {
        resetPosition = transform.position;
        resetQuaternion = transform.rotation;
    }

    public void MoveActor(Vector3 direction)
    {
        transform.position += new Vector3(direction.x , direction.y , 0) * Time.deltaTime * 0.03f;
    }

    public void RotateActor(Vector3 direction)
    {
        bulletObject.transform.rotation = Quaternion.Euler(new Vector3(-Mathf.Clamp(direction.y , -80 , 80) , Mathf.Clamp(direction.x , -80 , 80), direction.z));
    }

    public void ResetPosition()
    {
        transform.position = resetPosition;
        transform.rotation = resetQuaternion;
    }


}
