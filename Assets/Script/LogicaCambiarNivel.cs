using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LogicaCambiarNivel : MonoBehaviour
{
    public bool PasarNivel;
    public int IndiceNivel;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CambiarNivel(IndiceNivel);
        }

        if (PasarNivel)
        {
            CambiarNivel(IndiceNivel);
        }
    }

    public void CambiarNivel(int Indice)
    {
        SceneManager.LoadScene(Indice);
    }

}
