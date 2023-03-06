using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Texture2D bulletTexture;
    public Color bulletColor;

    private void OnCollisionExit(Collision collision)
    {
        // Debug.Log("BOOM AT :" + coord);
        // Debug.Log("canvas : " + paintCanvas);
        // 
    }
}