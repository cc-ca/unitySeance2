using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEnCercle : MonoBehaviour
{

public GameObject monCube;
    [SerializeField] private GameObject prefabAInstantier;
    [SerializeField] private int nbCube;
    [SerializeField] private float rayon;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < nbCube; i++)
        {
            float angle = i * Mathf.PI * 2 / nbCube;
            float x = Mathf.Cos(angle) * rayon;
            float z = Mathf.Sin(angle) * rayon;
            float degAngle = -angle * Mathf.Rad2Deg;
            Vector3 positionCube = transform.position + new Vector3(x, 0, z);
            Quaternion rotationCube = Quaternion.Euler(0, degAngle, 0);
            Instantiate(monCube, positionCube, rotationCube);

        }
    }

    // Update is called once per frame
    void Update()
    {
         for(int i = 0; i < nbCube; i++)
         {
            float angle = i * Mathf.PI * 2 / nbCube;
            float x = Mathf.Cos(angle) * rayon;
            float z = Mathf.Sin(angle) * rayon;
            float degAngle = -angle * Mathf.Rad2Deg;
            Vector3 positionCube = transform.position + new Vector3(x, 0, z);
            Quaternion rotationCube = Quaternion.Euler(0, degAngle, 0);
            Instantiate(monCube, positionCube, rotationCube);
         }

    }
}