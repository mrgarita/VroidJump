using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// �Q�[�����[�h�ݒ�
public enum MODE
{
  GAME,
  GAMEOVER,
  GAMECLEAR,
  HAPPYEND
}

public class GameController : MonoBehaviour
{
  public MODE mode;

  // �Q�[���N���A����BGM�؂�ւ�
  void ChangeBgm()
  {
    GameObject.Find("BGM").GetComponent<AudioSource>().enabled = false;
    GameObject.Find("ClearBGM").GetComponent<AudioSource>().enabled = true;

  }

  // �R���e�B�j���[�����i�V�[���ēǂݍ��݁j
  void Continue()
  {
    SceneManager.LoadScene("GameScene");
  }

  // Start is called before the first frame update
  void Start()
  {
    mode = MODE.GAME; // �Q�[����
  }

  // Update is called once per frame
  void Update()
  {
    if (mode == MODE.GAMECLEAR)  // �Q�[���N���A��
    {
      ChangeBgm();  // BGM�ύX
      mode = MODE.HAPPYEND; // �I�����̃A�j���[�V�����Ɉړ�
    }
    else if (mode == MODE.GAMEOVER)  // �Q�[���I�[�o�[��
    {
      Invoke("Continue", 8);  // 8�b��ɃV�[���ēǂݍ���
    }

    // �Q�[���N���A��́AEnter�L�[�Ń��v���C
    if (mode == MODE.HAPPYEND && Input.GetKeyDown(KeyCode.Return))
    {
      Continue();
    }
  }
}
