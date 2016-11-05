using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour
{
    
    public void quit()
    {
        Application.Quit();
    }
    public void start()
    {
        Application.LoadLevel("Level");
    }
}
