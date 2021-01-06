using System;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class Mes : MonoBehaviour
{
    /// <summary>
    ///   <para>Mes es la clase implementación de la segunda parte de la actividad.</para>
    /// </summary>
    ///

    // meses del anio
    private String[] mesesDelAnio = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
    
    // nombre del mes introducido
    public String nombreDelMes;

    // cardinal del mes, sera la posicion del nombre del mes en el array de meses + 1, si se encuentra
    private int _cardinalDelMes;
    
    // TODO chequear escribir buenos comentarios y documentacion

    // Start is called before the first frame update
    void Start()
    {
        Ejecutar(nombreDelMes);
    }

    // Update is called once per frame
    void Update() 
    {
        
    }

    /// <summary>
    ///   <para>Esta funcion ejecuta toda la logica para calcular el numero cardinal de un mes.</para>
    /// </summary>
    ///
    private void Ejecutar(String elNombreDelMes)
    {
        _cardinalDelMes = DevolverCardinalMes(elNombreDelMes);
        if (_cardinalDelMes > 0)
        {
            ParImpar(_cardinalDelMes);
        } else {
            Debug.Log("=> " + elNombreDelMes + " No es un nombre de mes valido. Por favor introduzca un nombre valido.");
        }
    }
    
    /// <summary>
    ///   <para>Devuelve el numero cardinal de un mes si lo encuentra en el array de meses y es un nombre de mes valido, en caso contrario devolvera un -1.</para>
    /// </summary>
    ///
    private int DevolverCardinalMes(String elNombreDelMes)
    {
        if (EsNombreMesValido(elNombreDelMes))
        {
            return ArrayUtility.FindIndex(mesesDelAnio, mesDelAnio => mesDelAnio.ToLower().Equals(elNombreDelMes.ToLower())) + 1;
        }
        return -1;
    }

    /// <summary>
    ///   <para>Muestra el mensaje por consola de si el cardinal de un mes es par o impar.</para>
    /// </summary>
    ///
    private void ParImpar(int elCardinalDelMes)
    {
        if (EsNumeroPar(elCardinalDelMes))
        {
            Debug.Log("=> El numero " + elCardinalDelMes + " es Par");
        }
        else
        {
            Debug.Log("=> El numero " + elCardinalDelMes + " es Impar");
        }
    }
    
    /// <summary>
    ///   <para>Devuelve si el nombre del mes es valido. Un nombre de mes es valido si coincide con alguno de los nombres en el array de meses.</para>
    /// </summary>
    ///
    private bool EsNombreMesValido(String elNombreDelMes)
    {
        return mesesDelAnio.Contains(elNombreDelMes, StringComparer.OrdinalIgnoreCase);
    }

    /// <summary>
    ///   <para>Devuelve si un numero es par o impar utlizando el operador modulo. Cualquier numero divido entre 2 y cuyo resto de la division es 0, es par, en caso contario es impar.</para>
    /// </summary>
    ///
    private bool EsNumeroPar(int numero)
    {
        return numero % 2 == 0;
    }
}
