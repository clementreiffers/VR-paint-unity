using UnityEngine;

public class PaintBrush : MonoBehaviour
{
    [Range(0.05f, 3)] public float brushDepth;
    public LayerMask layers;
    [Range(0, 1)] public float brushWidth;
    public Texture2D brushTexture;
    private bool hasHitPaintable;

    // Update is called once per frame
    private void Update()
    {
        // cree la ray(demi droite)partant du peinceau
        var ray = new Ray(transform.position, -transform.forward);
        RaycastHit hit;

        // Raycast pour verifier le contact entre peinceau et toile
        if (Physics.Raycast(ray, out hit))
        {
            var hitUV = hit.textureCoord;

            var paintCanvas = hit.transform.GetComponent<PaintCanvas>();
            paintCanvas.Paint(hitUV, brushWidth, brushTexture);

            hasHitPaintable = true;
        }
        else
        {
            hasHitPaintable = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = hasHitPaintable ? Color.blue : Color.green;
        Gizmos.DrawRay(transform.position, -transform.forward * brushDepth);
    }
}