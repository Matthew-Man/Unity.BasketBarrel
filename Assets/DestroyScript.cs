using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Technically basket detection script
public class DestroyScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        transform.parent.position = new Vector3(Random.Range(-7.50f, 7.50f), Random.Range(1.50f, 6f), transform.parent.position.z);
        // Can have different items scoring different points

        score += 10;
        scoreText.text = "Score: " + score;
    }
}
