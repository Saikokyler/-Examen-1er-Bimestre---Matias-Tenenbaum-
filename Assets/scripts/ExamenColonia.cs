using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ExamenColonia : MonoBehaviour
{
    public int insJuveniles;
     int profesores;
    public int insInfantiles;
    int profesorJuve;
    int profesorInfant;
    int cordis;
    int listaEspera;
    int extraJuve;
    int extraInfant;


    // Start is called before the first frame update
    void Start()
    {

        profesorJuve = insJuveniles / 20;
        profesorInfant = insInfantiles / 20;

        profesores = profesorJuve + profesorInfant;
        cordis = (profesores + 4) / 5;

        extraJuve = insJuveniles % 20;
        extraInfant = insInfantiles % 10;
        listaEspera = extraJuve + extraInfant;

        Debug.Log($"se necesitan {profesorJuve} profes para los juveniles inscriptos");
        Debug.Log($"se necesitan {profesorInfant} profes para los infantiles inscriptos");
        Debug.Log($"se necesitan {cordis} cordinadores para los profesores");
        Debug.Log($"Hay {listaEspera} inscriptos en la lista de espera");


        if ( insJuveniles > 100 || insInfantiles > 100 || insJuveniles < 0 || insInfantiles < 0)
        {
            Debug.LogError("La cantidad de inscriptos debe estar entre 0 y 100");
            return;
        };
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
