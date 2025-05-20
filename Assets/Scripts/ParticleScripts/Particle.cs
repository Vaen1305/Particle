using UnityEngine;

public class Particle
{
    public GameObject GameObject;
    public Transform Transform;
    public Vector3 Velocity;
    public float Lifetime;
    public float Age;

    public Particle(GameObject prefab, Vector3 position, Vector3 velocity, float lifetime, Color color, float size, Transform parent)
    {
        GameObject = Object.Instantiate(prefab, position, Quaternion.identity, parent);
        Transform = GameObject.transform;
        Velocity = velocity;
        Lifetime = lifetime;
        Age = 0f;

        MeshRenderer mr = GameObject.GetComponent<MeshRenderer>();
        if (mr != null)
        {
            mr.material = new Material(mr.material);
            mr.material.color = color;
        }

        Transform.localScale = new Vector3(size, size, size);
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