using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleSceneChange : MonoBehaviour
{

    public static HandleSceneChange Instance { get; private set; }

    FadeInOut fadeInOut;

    public AudioSource musicSource;
    public AudioSource sfxSource;
    public AudioClip musicBGM;
    public AudioClip tuturuSFX;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(musicSource);
        DontDestroyOnLoad(sfxSource);
    }

    private void Start()
    {
        musicSource.clip = musicBGM;
        musicSource.Play();

        fadeInOut = GameObject.Find("FadeHandler").GetComponent<FadeInOut>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            StartCoroutine(fadeInOut.FadeInAndOut("Scene2"));

        if (Input.GetKeyDown(KeyCode.Space))
            sfxSource.PlayOneShot(tuturuSFX);

        if (Input.GetKeyDown(KeyCode.V))
            Time.timeScale = 0;

        if (Input.GetKeyDown(KeyCode.B))
            Time.timeScale = 1;
    }

    
}
