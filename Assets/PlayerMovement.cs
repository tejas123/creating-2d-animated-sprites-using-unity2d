using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Animator animator;

	const int WALK =1;
	const int IDEL =2;
	const int ATTACK =3;
	const int DIE =4;
	const string animationState = "zombieAnimationState";

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame


	void Update () {
	
		if(Input.GetKey(KeyCode.W)){
			animator.SetInteger(animationState,WALK); //for Walk
		}else if(Input.GetKeyDown(KeyCode.A)){
			animator.SetInteger(animationState,ATTACK); // for Attack
		}else if(Input.GetKey(KeyCode.Space)){
			animator.SetInteger(animationState,DIE); // for Die
		}else{
			animator.SetInteger(animationState,IDEL); //For Idel
		}

	}
}
