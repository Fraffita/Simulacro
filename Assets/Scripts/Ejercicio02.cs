using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Ejercicio02 : MonoBehaviour
{
    //2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible.Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.

    public int producto_1, producto_2, producto_3;
    public int monto;
    private int extra1;
    private int suma;
    private int inverso;

    // Start is called before the first frame update
    void Start()
    {
        suma = producto_1 + producto_2 + producto_3;
        extra1 = monto - suma;
        inverso = Math.Abs(extra1);
        if (monto>suma)
        {
            Debug.Log("Su monto de dinero disponible cubre el gasto total");
            Debug.Log("Le sobran $"+extra1);
        }
        else if (monto<suma)
        {
            Debug.Log("Su monto de dinero disponible no cubre el gasto total");
            Debug.Log("Le faltan $" + inverso);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
