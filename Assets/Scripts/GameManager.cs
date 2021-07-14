using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        if (!Instance) Instance = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    private float time = 0f;
    private int frames = 0;
    private void Update()
    {
        frames++;
        time += Time.deltaTime;
        if (time >= 1f)
        {
            time = 0f;
            Debug.Log(frames);
            frames = 0;
        }
    }
}