using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlquilerVehiculos : MonoBehaviour
{
    public GameObject[] vehiculos;

    // Start is called before the first frame update
    void Start()
    {
        ResetearVehiculos();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

        }   
    }

    void ResetearVehiculos()
    {
        //Desactivar todos los elementos del array, y luego activo solo el primer elemento
        DeactivateAll();
        vehiculos[0].SetActive(true);
    }

    void DeactivateAll()
    {
        for (int i = 0; i < vehiculos.Length; i++)
        {
            vehiculos[i].SetActive(false);
        }
    }
}
