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


        // Raycast pour verifier le contact entre peinceau et toile
        if (Physics.Raycast(ray, out hit, brushDepth, layers))
        {
            var paintCanvas = hit.transform.GetComponent<PaintCanvas>();
            paintCanvas.Paint(hit.textureCoord, brushWidth, brushTexture);
            _hasHitPaintable = true;
            // Debug.Log("touche");
        }
        else
        {
            _hasHitPaintable = false;
        }

        Debug.DrawRay(_position, _forward, _hasHitPaintable ? Color.green : Color.red);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _hasHitPaintable ? Color.blue : Color.green;
    }
}