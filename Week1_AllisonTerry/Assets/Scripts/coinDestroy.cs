using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinDestroy : MonoBehaviour
{
    public float monies = 0;

    public TextMeshProUGUI moniesText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            monies++;
            moniesText.text = "Monies: " + monies;

        }
    }
}
