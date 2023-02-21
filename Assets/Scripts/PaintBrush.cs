using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    [Range(0.05f, 3)] public float brushDepth;
    public LayerMask layers;
    [Range(0, 1)] public float brushWidth;
    public Texture2D brushTexture;
    public Color paintColor;

    private bool _hasHitPaintable;
    private RaycastHit _hit;
    private Vector3 _position, _forward;
    private Ray _ray;


    // Update is called once per frame
    private void Update()
    {
        _position = transform.position;
        _forward = transform.forward;

        // create ray from paintbrush
        _ray = new Ray(_position, _forward);

        // verify if the paintbrush touch the layer
        _hasHitPaintable = Physics.Raycast(_ray, out _hit, brushDepth, layers);

        if (!_hasHitPaintable) return;

        PaintOnPaintCanvasAtHit();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _hasHitPaintable ? Color.blue : Color.green;
        Gizmos.DrawRay(transform.position, _forward * brushDepth);
    }

    private void PaintOnPaintCanvasAtHit()
    {
        var paintCanvas = _hit.transform.GetComponent<PaintCanvas>();
        var textureCoord = _hit.textureCoord;
        paintCanvas.Paint(textureCoord, brushWidth, brushTexture, paintColor);
    }
}