using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvent : MonoBehaviour
{
    [SerializeField] private ParticleSystem attackParticle;
    private Animator anim;
    private float targetSpeed = 1.0f; // Целевое значение параметра анимации Speed
    private float blendSpeed = 0.5f; // Скорость изменения параметра

    private void Awake()
    {
        anim = GetComponent<Animator>();
        
    }
    public IEnumerator ChangeBlendParameterOverTime()
    {
        while (Mathf.Abs(anim.GetFloat("Speed") - targetSpeed) > 0.1f)
        {
            // Изменяем параметр анимации плавно
            float currentSpeed = anim.GetFloat("Speed");
            float newSpeed = Mathf.Lerp(currentSpeed, targetSpeed, blendSpeed * Time.deltaTime);
            anim.SetFloat("Speed", newSpeed);

            // Ждем следующий кадр
            yield return null;
        }
    }
    public void TriggerUnityEvent()
    {
        attackParticle.Play(true);
    }

    public void Attack()
    {
        anim.SetTrigger("Attack");
    }

    private void Hit()
    {
        anim.SetTrigger("Hit");
    }
}
