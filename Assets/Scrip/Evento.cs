using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evento : MonoBehaviour
{
    public InputField RecopiladoNombre;
    public InputField recopiladorCedula;
    public List<string> recom;
    public GameObject nom;
    public Jeison jey;
    
    void Start()
    {
       // jey.lista.Clear();
       
    }
   public void New_Player()
    {
        if (string.IsNullOrWhiteSpace(RecopiladoNombre.text) == false && string.IsNullOrWhiteSpace(recopiladorCedula.text) == false)
        {
            jey.lista.Add(RecopiladoNombre.text);
            jey.lista.Add(recopiladorCedula.text);
            nom.SetActive(true);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
