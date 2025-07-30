using UnityEngine;

public class ScriptA : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.unscaledDeltaTime, 0, 0);
    }
}
