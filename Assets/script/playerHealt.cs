using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealt : MonoBehaviour
{
    public int lives;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lives <=0 || Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void DamagePlayer(int danio)
    {
        lives = lives - danio;
    }

}
