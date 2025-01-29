using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // We need to randomly determine wether this cherry is rotten or not
        // If the cherry is rotten, the player will receive damage from taking the cherry
        // If the cherry is NOT rotten, the player will reheal as normal.
        
        PlayerHealthController hCtr = collision.gameObject.GetComponent<PlayerHealthController>();
        hCtr.Regenerate();

        Debug.Log(collision.name);

        Destroy(this.gameObject); // Destroy the whole object using this.
    }
}
