using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    public float brushDepth = 10;
    public float brushWidth = 10;
    public Texture2D brushTexture;
    public LayerMask layers;

    private bool _hasHitPaintable;
    private Vector3 _position, _forward;

    // Update is called once per frame
    private void Update()
    {
        _position = transform.position;
        _forward = -transform.forward * 10;

        var ray = new Ray(_position, _forward);
        RaycastHit hit;

        Debug.DrawRay(_position, _forward, Color.green);

        // Raycast pour verifier le contact entre peinceau et toile
        if (Physics.Raycast(ray, out hit, brushDepth, layers))
        {
            var hitUV = hit.textureCoord;

            var paintCanvas = hit.transform.GetComponent<PaintCanvas>();
            // if (paintCanvas == null) Debug.Break();
            paintCanvas.Paint(hitUV, brushWidth, brushTexture);
            _hasHitPaintable = true;
            Debug.Log("touche");
        }
        else
        {
            _hasHitPaintable = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _hasHitPaintable ? Color.blue : Color.green;
    }
}