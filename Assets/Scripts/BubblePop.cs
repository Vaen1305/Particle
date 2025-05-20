using UnityEngine;

public class BubblePop : MonoBehaviour
{
    private Animator _animator;
    private static readonly int Pop = Animator.StringToHash(name: "Pop");

    private void Awake() => _animator = GetComponent<Animator>();

    private void OnMouseDown()
    {
        _animator.SetTrigger(id: Pop);
        ScoreText.Instance.AddScore(1);
    }
}
