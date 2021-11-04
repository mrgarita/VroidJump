using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	public GameObject target; // カメラの中心ターゲット
	public float distance;    // ターゲットとカメラの距離
	public bool rotate;       // 回転中か？
	Vector3 d;                // カメラとターゲットの距離計算用

	// Start is called before the first frame update
	void Start()
	{
		rotate = false;
		d = Vector3.back * distance + Vector3.up;
	}

	// Update is called once per frame
	void Update()
	{
		// カメラの回転ON
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
