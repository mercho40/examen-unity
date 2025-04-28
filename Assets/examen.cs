using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examen : MonoBehaviour
{
    // Start is called before the first frame update
    public int cantidadDeUnidades;
    public int periodoDeDias;
    int kmRecorridos;
    int litrosConsumidos;
    double costoTotalCombustible;

    void Start()
    {
      // verificar datos ingresados
      if(periodoDeDias < 5){
        Debug.Log("Por favor ingresar un periodo de dias mayor a 5");
        return;
      }
      if(cantidadDeUnidades < 1){
        Debug.Log("Por favor ingresar una cantida de unidades mayor a 1");
        return;
      }
      
      kmRecorridos = cantidadDeUnidades * 90;
      kmRecorridos = kmRecorridos * periodoDeDias;
      litrosConsumidos = kmRecorridos / 15;
      if(kmRecorridos % 15 > 0){
        litrosConsumidos = litrosConsumidos + 1;
      }
      costoTotalCombustible = litrosConsumidos * 130;

      if (litrosConsumidos >= 100)
      {
         costoTotalCombustible = costoTotalCombustible * 0.8; 
      }
      Debug.Log("Una flota de "+ cantidadDeUnidades + " unidades trabajando durante " + periodoDeDias + " días implicará un gasto de " + costoTotalCombustible + " pesos en concepto de combustible");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
