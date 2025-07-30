using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FadeInOut : MonoBehaviour
{

    public Animator anim;

    public IEnumerator FadeInAndOut(string sceneName)
    {
        anim.SetTrigger("FadeIn");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(sceneName);
    }
}
