using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject target; // �J�����̒��S�^�[�Q�b�g
	public float distance;    // �^�[�Q�b�g�ƃJ�����̋���
	public bool rotate;       // ��]�����H
	Vector3 d;                // �J�����ƃ^�[�Q�b�g�̋����v�Z�p

	// Start is called before the first frame update
	void Start()
	{
		rotate = false;
		d = Vector3.back * distance + Vector3.up;
	}

	// Update is called once per frame
	void Update()
	{
		// �J�����̉�]ON
		if (rotate == true)
		{
			var p = target.transform.position;
			p.y = 0f;
			transform.position = p + d;
			transform.RotateAround(p, Vector3.up, 110f * Time.deltaTime);
			d = transform.position - p;
		}
	}
}
