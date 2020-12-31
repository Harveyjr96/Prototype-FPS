using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public ParticleSystem muzzleEffect;
    float lastShootTime;
    public float fireRate;
    Animator animator;
    // Update is called once per frame
    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.timeScale > 0)
        {
            animator.SetBool("Shooting", true);
            var timeSinceLastSHoot = Time.time - lastShootTime;
            if (timeSinceLastSHoot < fireRate) { 
                return; 
            }

            lastShootTime = Time.time;

            muzzleEffect.Play();
            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;
        }
        else
        {
            animator.SetBool("Shooting", false);
        }
    }
}
