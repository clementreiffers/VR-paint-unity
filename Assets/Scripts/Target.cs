using UnityEngine;

public class Target : MonoBehaviour
{
    public int hitCount;
    public Texture2D bulletTexture;

    // Start is called before the first frame update
    private void Start()
    {
        hitCount = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        hitCount++;
        // var bullet = collision.transform.GetComponent<Bullet>();
        // Vector2 bulletCoord = bullet.transform.position;
        // PaintOnPaintCanvasAtHit(paintCanvas, bulletCoord);
    }

    private void PaintOnPaintCanvasAtHit(Bullet paintCanvas, Vector2 coord)
    {
        // paintCanvas.Paint(coord, 10, bulletTexture, bulletColor);
    }
}