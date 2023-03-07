using UnityEngine;

public class PaintCanvas : MonoBehaviour
{
    public RenderTexture paintableAreaRT;
    public int textureResolution = 256;


    // public void Start()
    // {
    // ClearOutRenderTexture(paintableAreaRT);
    // }

    public void Paint(Vector2 uv, float width, Texture2D texture, Color color)
    {
        //Activate RT
        RenderTexture.active = paintableAreaRT;

        // save matrixes
        GL.PushMatrix();
        // setup matrix for correct size
        GL.LoadPixelMatrix(0, textureResolution, textureResolution, 0);

        //Setup UVs to be the right scale
        uv.x *= textureResolution;
        uv.y = textureResolution * (1 - uv.y);
        //Scale the brush witdh to match the scale of the object in the world and the res of the texture
        width *= textureResolution;

        //Paint on RT
        var paintRect = new Rect(uv.x - width * 0.5f, uv.y - width * 0.5f, width, width);
        Graphics.DrawTexture(paintRect, texture, new Rect(0, 0, 1, 1), 0, 0, 0, 0, color, null);

        GL.PopMatrix();
        // turn off RT
        RenderTexture.active = null;
    }

    public void ClearOutRenderTexture(RenderTexture renderTexture)
    {
        RenderTexture.active = renderTexture;
        GL.Clear(true, true, new Color(0, 0, 0, 0));
        RenderTexture.active = null;
    }
}