using UnityEngine;

public class Target : MonoBehaviour
{
    private ScoreUI _score;

    // Start is called before the first frame update
    private void Start()
    {
        _score = FindObjectOfType<ScoreUI>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        _score.scorehitcount++;
    }
}