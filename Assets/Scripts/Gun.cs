using UnityEngine;

public class Gun : MonoBehaviour
{
    public Rigidbody bullet;

    public void Shot()
    {
        // Instantiate the projectile at the position and rotation of this transform
        var clone = Instantiate(bullet, transform.position, new Quaternion(0, 0, 0, 0));

        clone.velocity = transform.TransformDirection(Vector3.forward * 10);
    }
}