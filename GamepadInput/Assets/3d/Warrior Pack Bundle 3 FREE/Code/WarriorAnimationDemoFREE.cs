using UnityEngine;
using System.Collections;

public class WarriorAnimationDemoFREE : MonoBehaviour {

    public const string RUN     = "run";
    public const string IDLE    = "idle";
    public const string ATTACK  = "attack";

    [SerializeField]
    private Animator _animator;

    private void LateUpdate() {
        transform.position = new Vector3();
    }

    public void Run() {
        _animator.SetTrigger(RUN);
    }

    public void Idle() {
        _animator.SetTrigger(IDLE);
    }

    public void Attack() {
        _animator.SetTrigger(ATTACK);
    }
}

	