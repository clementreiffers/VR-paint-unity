using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Texture2D bulletTexture;
    public Color bulletColor;

    private void OnCollisionExit(Collision collision)
    {
        var paintCanvas = collision.transform.GetComponent<PaintCanvas>();
        Vector2 coord = collision.transform.position;

        // Debug.Log("BOOM AT :" + coord);
        // Debug.Log("canvas : " + paintCanvas);
        // PaintOnPaintCanvasAtHit(paintCanvas, coord);
    }

    private void PaintOnPaintCanvasAtHit(PaintCanvas paintCanvas, Vector2 coord)
    {
        paintCanvas.Paint(coord, 10, bulletTexture, bulletColor);
    }
}