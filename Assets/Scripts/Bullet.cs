using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Texture2D bulletTexture;
    public Color bulletColor;
    public float bulletDepth, bulletWidth;
    public LayerMask layers;
    public int timeToLive;

    private RaycastHit _hit;

    private void Update()
    {
        WatchAllAlongTheBullet(transform.position, transform.forward);
        // bullets destroyed after 5 seconds
        Destroy(gameObject, timeToLive);
    }

    private void WatchAllAlongTheBullet(Vector3 position, Vector3 forward)
    {
        DrawIfRaycastHitPaintableTarget(position, -forward);
    }

    private void DrawIfRaycastHitPaintableTarget(Vector3 position, Vector3 forward)
    {
        if (IfRaycastHitPaintableTarget(new Ray(position, forward))) ComputeShowBulletSplash();
    }

    private bool IfRaycastHitPaintableTarget(Ray ray)
    {
        return Physics.Raycast(ray, out _hit, bulletDepth, layers);
    }

    private void ComputeShowBulletSplash()
    {
        var textureCoord = _hit.textureCoord;
        var paintCanvas = _hit.transform.GetComponent<PaintCanvas>();
        paintCanvas.Paint(textureCoord, bulletWidth, bulletTexture, Color.green);
    }
}