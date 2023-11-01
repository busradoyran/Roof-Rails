using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectLong : MonoBehaviour
{
    public Transform mainRod;
    public Score Score;
    void Collect()
    {
        mainRod.transform.localScale = new Vector3(mainRod.transform.localScale.x, (float)(mainRod.transform.localScale.y + 0.1), mainRod.transform.localScale.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Collect();
            Score.score = Score.score + 2;
            Destroy(gameObject);
        }
    }
}
