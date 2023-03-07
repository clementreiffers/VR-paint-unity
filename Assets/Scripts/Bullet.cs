using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Texture2D bulletTexture;
    public Color bulletColor;
    public float bulletDepth;
    public LayerMask layers;

    private RaycastHit _hit;

    private void Update()
    {
        var position = transform.position;
        var forward = transform.forward;

        WatchAllAlongTheBullet(position, forward);
    }

    private void WatchAllAlongTheBullet(Vector3 position, Vector3 forward)
    {
        var ray1 = new Ray(position, forward);
        var ray2 = new Ray(-position, -forward);
        var ray3 = new Ray(position, -forward);
        var ray4 = new Ray(-position, forward);


        if (IfRaycastHitTarget(ray1)) ComputeShowBulletSplash();
        if (IfRaycastHitTarget(ray2)) ComputeShowBulletSplash();
        if (IfRaycastHitTarget(ray3)) ComputeShowBulletSplash();
        if (IfRaycastHitTarget(ray4)) ComputeShowBulletSplash();
    }

    private bool IfRaycastHitTarget(Ray ray)
    {
        return Physics.Raycast(ray, out _hit, bulletDepth, layers);
    }

    private void ComputeShowBulletSplash()
    {
        Debug.Log("KABOOM AT : " + _hit.textureCoord);
        var textureCoord = _hit.textureCoord;
        var paintCanvas = _hit.transform.GetComponent<PaintCanvas>();
        paintCanvas.Paint(textureCoord, 100, bulletTexture, bulletColor);
    }
}