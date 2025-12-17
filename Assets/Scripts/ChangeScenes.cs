using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public string nombreEscenaDestino;
    private Animator transitionAnim;
    private void Start()
    {
        transitionAnim = GetComponentInChildren<Animator>();
    
    }

    public void IrAEscena()
    {
        
        SceneManager.LoadScene(nombreEscenaDestino);
        StartCoroutine(SceneLoad());
    }
    public IEnumerator SceneLoad()
    {
        transitionAnim.SetTrigger("StartTransition");

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(nombreEscenaDestino);
        
    }
}