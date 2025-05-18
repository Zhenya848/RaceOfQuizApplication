using UnityEngine;

[RequireComponent(typeof(Animator))]
public abstract class AnimationHandlerBase : MonoBehaviour
{
    protected Animator _animator;

    private void Start() => _animator = GetComponent<Animator>();

    public void Handle() => StartAnim();

    protected virtual void StartAnim() { }
}
