using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float depth, width;
    public LayerMask layers;
    public Texture2D bulletTexture;
    public Color bulletColor;

    private bool _hasHitPaintable;
    private RaycastHit _hit;
    private Vector3 _position, _forward;
    private Ray _ray;

    // Update is called once per frame
    private void Update()
    {
        _ray = new Ray(_position, _forward);

        Debug.DrawRay(_position, _forward * 1000);

        // verify if the paintbrush touch the layer
        _hasHitPaintable = Physics.Raycast(_ray, out _hit, depth, layers);

        if (!_hasHitPaintable) return;

        PaintOnPaintCanvasAtHit();
    }

    private void PaintOnPaintCanvasAtHit()
    {
        var paintCanvas = _hit.transform.GetComponent<PaintCanvas>();
        var textureCoord = _hit.textureCoord;
        paintCanvas.Paint(textureCoord, width, bulletTexture, bulletColor);
    }
}