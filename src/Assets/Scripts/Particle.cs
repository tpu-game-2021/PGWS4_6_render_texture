using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    private ParticleSystem particle;
    private List<ParticleCollisionEvent> collisionEvents = new List<ParticleCollisionEvent>();
    [SerializeField] CustomRenderTexture texture;
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }
     void OnParticleCollision(GameObject other)
    {
        Material m = texture.material;
        if (other.tag=="sea")
        {
            particle.GetCollisionEvents(other, collisionEvents);

            foreach(var collisionEvent in collisionEvents)
            {
                Vector3 pos = collisionEvent.intersection;
                Vector3 p = new Vector3(pos.x * 0.2f, 0.0f, pos.z * 0.2f);
                float u = p.x * 0.5f + 0.5f;
                float v = p.z * 0.5f + 0.5f;

                m.SetFloat("_BulletX", u);
                m.SetFloat("_BulletZ", v);
            }
        }
    }
}
