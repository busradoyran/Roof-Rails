using UnityEngine;

public class CollectShort : MonoBehaviour
{
    public Transform mainRod;
    public Score Score;
    void Collect()
    {
        mainRod.transform.localScale = new Vector3(mainRod.transform.localScale.x, (float)(mainRod.transform.localScale.y + 0.05), mainRod.transform.localScale.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Collect();
            Score.score = Score.score + 1;
            Destroy(gameObject);
        }
    }
}
