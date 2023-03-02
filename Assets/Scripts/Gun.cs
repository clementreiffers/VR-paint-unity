using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody bullet;

    public void Shot()
    {
        // Instantiate the projectile at the position and rotation of this transform
        Rigidbody clone;
        clone = Instantiate(bullet, transform.position, transform.rotation);

        // Give the cloned object an initial velocity along the current
        // object's Z axis
        clone.velocity = transform.TransformDirection(Vector3.forward * 10);
    }
}