using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class composant : MonoBehaviour
{
    [SerializeField] private Transform monTransform;

     [SerializeField] private GameObject prefabAInstancier;

     [SerializeField] public float Radius = 1f;
      [SerializeField] public float RSpeed = 1;
     [SerializeField] public int SelfRotationSpeed = 150;
     //[SerializeField] public float XRotationCenter = 0;
     //[SerializeField] public float YRotationCenter = 0;
     //[SerializeField] public float ZRotationCenter = 0;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefabAInstancier);
        Instantiate(prefabAInstancier);
        Debug.Log(message:"start");

        //monTransform.position = new Vector3(x:XRotationCenter, y:YRotationCenter, z:ZRotationCenter);
    }

    // Update is called once per frame
    void Update()
    {   
        
        monTransform.position+= new Vector3(x:0f, y: 0 + Radius* Mathf.Sin(2f* Time.time),z:0 +Radius * Mathf.Cos(2f* Time.time)) ;
        Debug.Log(monTransform.position);
        transform.Rotate(Vector3.left * Time.deltaTime*SelfRotationSpeed);
    }
}
