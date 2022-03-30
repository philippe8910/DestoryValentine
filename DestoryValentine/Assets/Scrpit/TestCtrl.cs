using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCtrl : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    
    [SerializeField] private Transform CameraFollowPos;
    
    [SerializeField] private Vector3 startPos, Direction;

    [SerializeField] private bool isTouch = false;

    [SerializeField] private bool isShooting = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isTouch = Input.GetMouseButton(0);
        
        if (Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
    }

    private void FixedUpdate()
    {
        if (isTouch)
        {
            isShooting = true;
            
            Direction = Input.mousePosition - startPos;
            transform.position += new Vector3(Direction.x , Direction.y , 0) * Time.deltaTime * 0.03f;
            Bullet.transform.rotation = Quaternion.Euler(new Vector3(-Direction.y , Direction.x , Direction.z));
            Debug.Log(Direction.normalized);
        }

        if (isShooting)
        {
            transform.position += Vector3.forward * Time.deltaTime * 2;
            Camera.main.transform.position = CameraFollowPos.position;
            //Camera.main.transform.position = new Vector3(Camera.main.transform.position.x,
            //Camera.main.transform.position.y, CameraFollowPos.position.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            
        }

        if (collision.gameObject.tag == "HeartShape")
        {
            
        }
    }
}
