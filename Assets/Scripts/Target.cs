using UnityEngine;

public class Target : MonoBehaviour
{
    public int score;

    // Start is called before the first frame update
    private void Start()
    {
        score = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        score++;
    }
}