using System;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    /// <summary>
    ///   <para>Metodos es la clase implementación de la primera parte de la actividad.</para>
    /// </summary>
    
    // el numero a multiplicar recibido por parametro
    public int numero;
    
    // el numero de veces a multiplicar el numero
    public int veces;
    
    // Start is called before the first frame update
    void Start()
    {
        Multiplicacion(numero, veces);
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    /// <summary>
    ///   <para>Implementación de la multiplicación usando el tradicional bucle For.</para>
    /// </summary>
    private void Multiplicacion(int elNumero, int numeroDeVeces)
    {
        String mensaje = "El resultado de multiplicar " + elNumero + ", " + numeroDeVeces + " veces es : ";
        // si multiplicamos un número 0 veces por sí mismo, devolvemos el mismo número
        int resultado = elNumero;
        // en caso de que se introduzca un valor negativo, utilizamos el valor absoluto
        for (int i = 0; i < Math.Abs(numeroDeVeces); i++)
        {
            resultado = resultado * elNumero;
        }
        Debug.Log(mensaje + resultado);
    }
    
}
