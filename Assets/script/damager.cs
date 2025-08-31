using Unity.VisualScripting;
using UnityEngine;

public class damager : MonoBehaviour
{
    public int danio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        playerHealt playerHealt = collision.gameObject.GetComponent<playerHealt>();
        if (playerHealt != null) 
        {
            playerHealt.DamagePlayer(danio);
        }

    }
}
