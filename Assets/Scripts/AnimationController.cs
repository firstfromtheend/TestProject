using UnityEngine;
using UnityEngine.EventSystems;

public class AnimationController : MonoBehaviour, IPointerClickHandler
{
    private Animator _animator;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.Rebind();
        _animator.Play("anim_1_spin_animation");
    }
}
