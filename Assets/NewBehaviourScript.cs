using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text="";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            texto.text="Bayonetta";
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            texto.text="Hades";
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            texto.text="NieR:Automata";
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            texto.text="PERSONA5";
        }
    }
}
