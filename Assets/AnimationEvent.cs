using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvent : MonoBehaviour
{
    [SerializeField] private ParticleSystem attackParticle;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void TriggerUnityEvent()
    {
        attackParticle.Play(true);
    }

    private void Attack()
    {
        anim.SetTrigger("Attack");
    }

    private void Hit()
    {
        anim.SetTrigger("Hit");
    }
}
