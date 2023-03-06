using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody bullet;

    public void Shot()
    {
        // Instantiate the projectile at the position and rotation of this transform
        var clone = Instantiate(bullet, transform.position, transform.rotation);

        clone.velocity = transform.TransformDirection(Vector3.forward * 10);
    }
}