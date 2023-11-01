using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutter : MonoBehaviour
{
    public void Cut(Transform cutter)
    {
        if(cutter.transform.position.x < 0)
        {
            float y = transform.localScale.y;
            y -= transform.position.x;
            float distance = y + cutter.position.x;
            Debug.Log("Distance : " + distance);

            if (distance/2 > 0)
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - distance/2, transform.localScale.z);
                transform.position = new Vector3(transform.position.x + distance / 2, transform.position.y, transform.position.z);
                GameObject newObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

                newObject.transform.localScale = new Vector3(transform.localScale.x, distance / 2, transform.localScale.z);
                newObject.transform.rotation = transform.rotation;
                newObject.transform.position = new Vector3(-(y - newObject.transform.localScale.y), transform.position.y, transform.position.z);
                newObject.AddComponent<Rigidbody>();
            }
        }
        else
        {
            float y = transform.localScale.y;
            y += transform.position.x;
            float distance = y - cutter.position.x;
            Debug.Log("Distance : " + distance);

            if (distance/2 > 0)
            {
                transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y - distance / 2, transform.localScale.z);
                transform.position = new Vector3(transform.position.x - distance / 2, transform.position.y, transform.position.z);

                GameObject newObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                newObject.transform.localScale = new Vector3(transform.localScale.x, distance / 2, transform.localScale.z);
                newObject.transform.rotation = transform.rotation;
                newObject.transform.position = new Vector3(y - newObject.transform.localScale.y, transform.position.y, transform.position.z);

                newObject.AddComponent<Rigidbody>();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cut"))
        {
            Cut(other.gameObject.transform);
        }
    }
}
