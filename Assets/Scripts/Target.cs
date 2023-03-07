using UnityEngine;

public class Target : MonoBehaviour
{
    public Texture2D bulletTexture;
    ScoreUI score;

    // Start is called before the first frame update
    private void Start()
    {
        score = FindObjectOfType<ScoreUI>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        score.scorehitcount++;
        // var bullet = collision.transform.GetComponent<Bullet>();
        // Vector2 bulletCoord = bullet.transform.position;
        // PaintOnPaintCanvasAtHit(paintCanvas, bulletCoord);
    }

    private void PaintOnPaintCanvasAtHit(Bullet paintCanvas, Vector2 coord)
    {
        // paintCanvas.Paint(coord, 10, bulletTexture, bulletColor);
    }
}