using UnityEngine;

public class Particle
{
    public GameObject GameObject;
    public Transform Transform;
    public Vector3 Velocity;
    public float Lifetime;
    public float Age;

    public Particle(ParticleDataSO data, Vector3 position, Vector3 velocity, Transform parent)
    {
        GameObject = new GameObject("Particle");
        Transform = GameObject.transform;
        Transform.position = position;
        Transform.localScale = Vector3.one * data.size;
        Transform.parent = parent;

        MeshFilter mf = GameObject.AddComponent<MeshFilter>();
        mf.sharedMesh = data.mesh;

        MeshRenderer mr = GameObject.AddComponent<MeshRenderer>();
        mr.material = new Material(data.material);
        mr.material.color = data.color;

        Velocity = velocity;
        Lifetime = data.lifetime;
        Age = 0f;
    }

    public bool IsAlive => Age < Lifetime;

    public void UpdateParticle(float deltaTime)
    {
        Age += deltaTime;
        if (IsAlive)
        {
            Transform.position += Velocity * deltaTime;
        }
        else
        {
            Object.Destroy(GameObject);
        }
    }
}
