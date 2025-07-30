using UnityEngine;

public class ScriptB : MonoBehaviour
{
    public float speedB = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedB * Time.deltaTime, 0, 0);
    }
}
