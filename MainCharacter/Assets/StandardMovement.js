#pragma strict

var charControll:CharacterController;
var runSpeed;
var jumpHeight;

function Start () {
	animation.wrapMode = WrapMode.Loop;
}

function Update () {
				
			if(Input.GetButton("Up")){
				animation.CrossFade("Run");
			}
		
}