using UnityEngine;
using System.Collections;

public class Attack: MonoBehaviour {


	public Animator animator;
	public float DirectionDampTime = .25f;
	public bool ApplyGravity = true; 
	public bool downButtonPressed = false;
	

	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator>();
		
		if(animator.layerCount >= 2)
			animator.SetLayerWeight(1, 1);
	}
		
	// Update is called once per frame
	void Update () 
	{

		if (animator)
		{
			AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);			

			
			
			//Run
			if (Input.GetButton("punchLeft1")) {
				animator.SetBool("PunchLeft1", true);
			}
			else {
				animator.SetBool("PunchLeft1", false);
			}

			
			


			
		
      		//float h = Input.GetAxis("Horizontal");
        	//float v = Input.GetAxis("Vertical");
			//
			//animator.SetFloat("Speed", h*h+v*v);
           //animator.SetFloat("Direction", h, DirectionDampTime, Time.deltaTime);	
		}   		  
	}
}
