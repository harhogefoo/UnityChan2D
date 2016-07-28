using UnityEngine;
using System.Collections;

public class PlayerCharacterController : MonoBehaviour {

	// parameter
	private float maxSpeed = 10.0f;

	private Animator animator;
	private Rigidbody2D rb2D;
	private Transform myTransform;

	void Awake() 
	{
		animator = GetComponent<Animator> ();
		rb2D = GetComponent<Rigidbody2D> ();
		myTransform = transform;
	}

	void Update () 
	{
		float move = Input.GetAxis ("Horizontal");
		if (Mathf.Abs (move) > 0) {
			// 進む方向に寄って向きを変える
			Quaternion rot = myTransform.rotation;
			float newRotY = Mathf.Sign (move) == 1 ? 0 : 180;
			myTransform.rotation = Quaternion.Euler (rot.x, newRotY, rot.z);
			// AnimatorのHorizontalパラメータに入力値(move)を渡す
			animator.SetFloat("Horizontal", move);
			// 移動処理
			rb2D.velocity = new Vector2(move * maxSpeed, rb2D.velocity.y);
		}
	}
}
