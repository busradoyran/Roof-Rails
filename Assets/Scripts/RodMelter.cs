using UnityEngine;

public class RodMelter : MonoBehaviour
{
    public Transform mainRod;
    void Melt()
    {
        mainRod.transform.localScale = new Vector3(mainRod.transform.localScale.x, (float)(mainRod.transform.localScale.y - 0.05), mainRod.transform.localScale.z);
        if (mainRod.transform.localScale.y <= 0.05)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Melt();
        }
    }
}
