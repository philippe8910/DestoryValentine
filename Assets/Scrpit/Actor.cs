using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField] private GameObject bulletObject;

    [SerializeField] private Vector3 resetPosition , bulletPosition;

    [SerializeField] private Quaternion resetQuaternion , bulletQuaternion;
    // Start is called before the first frame update
    void Start()
    {
        resetPosition = transform.position;
        resetQuaternion = transform.rotation;
        bulletPosition = bulletObject.transform.position;
        bulletQuaternion = bulletObject.transform.rotation;
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

        bulletObject.transform.position = bulletPosition;
        bulletObject.transform.rotation = resetQuaternion;
        
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    public void ThrowBullet()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * 3 , ForceMode.Impulse);
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Camera.main.transform.parent = null;
    }


}
