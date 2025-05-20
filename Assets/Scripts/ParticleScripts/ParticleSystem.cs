using System.Collections.Generic;
using UnityEngine;

public class ParticleSystem : MonoBehaviour
{
    private readonly List<Particle> particles = new();
    private float spawnTimer = 0f;

    [Header("Particle Settings")]
    public GameObject particlePrefab;
    public float spawnRate = 10f;
    public float particleLifetime = 2f;
    public float particleSpeed = 1f;
    public Color particleColor = Color.white;
    public float particleSize = 0.2f;

    [Header("Spawn Position")]
    public Vector3 spawnPosition = Vector3.zero;

    private const int MaxParticles = 1000;

    void Update()
    {
        float deltaTime = Time.deltaTime;
        spawnTimer += deltaTime;

        while (spawnTimer >= 1f / spawnRate && particles.Count < MaxParticles)
        {
            SpawnParticle();
            spawnTimer -= 1f / spawnRate;
        }

        for (int i = particles.Count - 1; i >= 0; i--)
        {
            particles[i].UpdateParticle(deltaTime);
            if (!particles[i].IsAlive)
                particles.RemoveAt(i);
        }
    }

    private void SpawnParticle()
    {
        Vector3 dir = new Vector3(
            RandomGen.NextFloat(-1f, 1f),
            RandomGen.NextFloat(-1f, 1f),
            RandomGen.NextFloat(-1f, 1f)
        ).normalized;

        Vector3 velocity = dir * particleSpeed;

        Particle p = new Particle(particlePrefab, spawnPosition, velocity, particleLifetime, particleColor, particleSize, transform);
        particles.Add(p);
    }
}