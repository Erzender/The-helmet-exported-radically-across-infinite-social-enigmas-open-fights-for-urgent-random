using UnityEngine;
using System.Collections;

public class BasicIngame : MonoBehaviour
{
    public GameObject canvas;
    private bool on;
    // Use this for initialization
    void Start()
    {
        on = false;
        canvas.SetActive(on);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            close();
        }
    }
    public void close()
    {
        on = !on;
        canvas.SetActive(on);
    }
}
