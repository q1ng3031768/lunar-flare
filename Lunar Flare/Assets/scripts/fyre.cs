using UnityEngine;

public class fyre : MonoBehaviour
{
    public float damage = 1;
    public float range = 100f;

    public Camera playercam;
    public ParticleSystem impacteffect;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot()
        }
    }

    void Shoot()
    {
        RayCastHit hit;
        if (Physics Raycast(playercam.transform.position, playercam.transform.forward, out hit, range)
        {
            Target target = hit.transform.GetComponent<enemybehaviour>();
            if (target != null)
            {
                target.damage(damage);
            }
            GameObject impact = Instantiate(impacteffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 2f);
        }

    }

}
