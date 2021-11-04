using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  Animator animator;      // Animator�R���|�[�l���g�擾�p
  bool isJump;            // �W�����v�����H
  public float JumpPower;   // �W�����v��
  public AudioClip JumpSe;  // �W�����v���̌��ʉ�
  public AudioClip DamageSe;  // Cube�ɂԂ��������̌��ʉ�

  // Start is called before the first frame update
  void Start()
  {
    isJump = false;
    animator = gameObject.GetComponent<Animator>(); // Animator�R���|�[�l���g�擾
    animator.SetBool("damage", false);
    animator.SetBool("jump", false);
  }

  // Update is called once per frame
  void Update()
  {
    // ���}�E�X�{�^���N���b�N�i�W�����v���łȂ��Ƃ��j
    if(Input.GetMouseButtonDown(0) && !isJump){
      isJump = true;

      // �W�����v������
      Vector3 force = Vector3.up * JumpPower;
      gameObject.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);

      animator.SetBool("jump", true); // �W�����v���̃A�j���ɕύX
      AudioSource.PlayClipAtPoint(JumpSe, transform.position);  // �W�����v���̌��ʉ��Đ�
    }

  }

  private void OnCollisionEnter(Collision col)
  {
    // �v���C���[��Cube�ƏՓ˂�����
    if (col.gameObject.tag == "Cube")
    {
 
      // Cube�̈ړ����~
      col.gameObject.GetComponent<CubeController>().Speed = 0f;

      // �Փˎ��̃A�j���[�V�����ƌ��ʉ�
      animator.SetBool("damage", true);
      AudioSource.PlayClipAtPoint(DamageSe, transform.position);
    }

    // �n�ʁiPlane�j�Ɛڒn�������H
    if(col.gameObject.tag == "Ground")
    {
      // �W�����v���̏�Ԃ�����
      isJump = false;
      animator.SetBool("jump", false);
    }
  }
}
