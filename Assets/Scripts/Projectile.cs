using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float projectileSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // Move the projectile upwards
        transform.Translate(Vector3.up * (projectileSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroy any object that the projectile collides with
        Destroy(other.gameObject);

        // Destroy the projectile as well
        Destroy(gameObject);
    }
}
