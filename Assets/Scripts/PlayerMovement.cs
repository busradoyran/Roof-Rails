using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.001f;
    public Swipe swipeControls;
    bool rightEnable = true;
    bool leftEnable = true;
    int playerPos;
    int road;

    public Image barLevel;
    void Start()
    {
        DOTween.Init();
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);

        if (swipeControls.SwipeLeft && leftEnable && transform.position.x > -9.7)
        {
            leftEnable = false;
            transform.DOMoveX(transform.position.x - 1, 0.05f).OnComplete(() => setEnable(ref leftEnable));
        }
        if (swipeControls.SwipeRight && rightEnable && transform.position.x < 9.7)
        {
            rightEnable = false;
            transform.DOMoveX(transform.position.x + 1, 0.05f).OnComplete(() => setEnable(ref rightEnable));
        }

        barLevel.fillAmount = 
    }
    void setEnable(ref bool enable)
    {
        enable = true;
    }
}
