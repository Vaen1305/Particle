using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer _renderer;

    void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _propBlock = new MaterialPropertyBlock();
    }
    private Color GetRandomColor()
    {
        return new Color(
            r: Random.Range(0f, 1f),
            g: Random.Range(0f, 1f),
            b: Random.Range(0f, 1f));
    }
    private MaterialPropertyBlock _propBlock;
    
    private void Update()
    {
        _renderer.GetPropertyBlock(_propBlock);
        _propBlock.SetColor("_BaseColor", GetRandomColor() );
        _renderer.SetPropertyBlock(_propBlock);
    }
}
