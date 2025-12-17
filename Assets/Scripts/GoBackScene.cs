using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GoBackScene : MonoBehaviour
{
    public string nombreEscenaDestino = "SampleScene";

    void Start()
    {
        StartCoroutine(CambiarDespuesDeTiempo());
    }

    IEnumerator CambiarDespuesDeTiempo()
    {
        yield return new WaitForSeconds(12f);  
        SceneManager.LoadScene(nombreEscenaDestino); 
    }
}
