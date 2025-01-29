using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Utilizar los diferentes sprites
// Cuando pierda una vida, el sprite se oscurezca

public class UIHealth : MonoBehaviour
{
    public Image healthbar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Restar una vida
    public void UpdateHealth(int LIVES, int MAXLIVES)
    {
        // For each health lost, the healtbar should proportionally decrease its size (maxlives/maxlives as starting)
        // For instance, if we have LIVES out of MAXLIVES, the green health bar should be displayed as LIVES/MAXLIVES of its maximum size.

        // Bonus, use dottween to make a soft transition of the healthbar size

        // Use the spike to test the damage to the player
    }
}
