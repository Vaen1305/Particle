using UnityEngine;

[CreateAssetMenu(fileName = "ParticleDataSO", menuName = "Scriptable Objects/ParticleDataSO")]
public class ParticleDataSO : ScriptableObject
{
    public Mesh mesh;
    public Material material;
    public Color color = Color.white;
    public float size = 0.2f;
    public float lifetime = 2f;
    public float speed = 1f;
}
