using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
  public float Speed;       // �ړ����x
  public GameObject Effect; // ���j�G�t�F�N�g
  public AudioClip BangSe;  // ���j���̌��ʉ�

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Cube���ړ�
    transform.position += Vector3.back * Speed * Time.deltaTime;

    // �v���C���[�̌�ɂ��������]�J������ON
    if (transform.position.z < -2f)
    {
      GameObject.Find("Main Camera").GetComponent<CameraController>().rotate = true;
    }

    // �Ō�ɔ������ď���
    if (transform.position.z < -8f)
    {
      // ���j�G�t�F�N�g
      Instantiate(Effect, transform.position, Quaternion.identity);
      // ���ʉ�
      AudioSource.PlayClipAtPoint(BangSe, transform.position);
      // Cube������
      Destroy(gameObject);
      // �Q�[���N���A
      GameObject.Find("GameMain").GetComponent<GameController>().mode = MODE.GAMECLEAR;
    }
  }
}
