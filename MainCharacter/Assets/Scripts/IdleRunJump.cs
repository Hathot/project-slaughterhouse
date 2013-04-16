using UnityEngine;
using System.Collections;

public class IdleRunJump : MonoBehaviour {


	public Animator animator;
	public float DirectionDampTime = .25f;
	public bool ApplyGravity = true; 
	public bool downButtonPressed = false;
	
	//parameters to fill
	public int jumpHeight = 2;
	public float speed = 1;
	

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
			/*
			//Jumping
			if (Input.GetButton("Jump")){ 
				if(!animator.GetBool("Jump")) {
					animator.SetBool("Double Jump", false); 
					animator.SetBool("Jump", true);
				}
				else if(!animator.GetBool("Double Jump")){
					animator.SetBool("Double Jump", true); 
					animator.SetBool("Jump", false);	
				}
				

				else {
					animator.SetBool("Double Jump", false);   	
					animator.SetBool("Jump", false);  
				}
			}	
			else{
				animator.SetBool("Double Jump", false);   	
				animator.SetBool("Jump", false);              
            }
			
			Crowling
			if (Input.GetButton("Crawl")){ 
				animator.SetBool("Crawl", true);      
			}			
			else{
				animator.SetBool("Crawl",false);
			}
			//Run
			if (Input.GetButton("Up")) {
				animator.SetFloat("Speed", 45);
			}
			else {
				animator.SetFloat("Speed", 0);
			}
			
			//Turnig
			if (Input.GetButton("Left")) {
				animator.transform.Rotate(0,-2,0,Space.World);
			}
			if (Input.GetButton("Right")) {
			animator.transform.Rotate(0,2,0,Space.World);
			}
			if (Input.GetButton("Down") && !downButtonPressed) {
				animator.transform.Rotate(0,180,0,Space.World);
				downButtonPressed = true;
			}
			else if (!Input.GetButton("Down")){
				downButtonPressed = false;
			}
			
			//running
			if (Input.GetButton("Up")) {
			}
			else {
				animator.SetFloat("Speed", 0);
				
			}
			
			//sprinting
			if (Input.GetButton("Sprint")) {
				animator.animation.
				animator.SetBool("Sprint",true);
				
			}
			else {
				animator.SetBool("Sprint",false);
				
			}
			 */
			

			
		
      		//float h = Input.GetAxis("Horizontal");
        	//float v = Input.GetAxis("Vertical");
			//
			//animator.SetFloat("Speed", h*h+v*v);
           //animator.SetFloat("Direction", h, DirectionDampTime, Time.deltaTime);	
		}   		  
	}
}
