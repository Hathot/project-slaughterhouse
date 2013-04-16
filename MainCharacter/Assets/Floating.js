#pragma strict


var Target : Transform;
var maxRange = 2;
function Start () {

}

function Update () {
	//makes player2 not allowed to move futher than maxRange away from player1;
	if(this.transform.position.x > Target.position.x+maxRange) {
		this.transform.position.x = Target.position.x+maxRange;
	}
	if(this.transform.position.x < Target.position.x-maxRange) {
		this.transform.position.x = Target.position.x-maxRange;
	}
	
	if(this.transform.position.z > Target.position.z+maxRange) {
		this.transform.position.z = Target.position.z+maxRange;
	}
	if(this.transform.position.z < Target.position.z-maxRange) {
		this.transform.position.z = Target.position.z-maxRange;
	}
	if(this.transform.position.y > Target.position.y+maxRange) {
		this.transform.position.y = Target.position.y+maxRange;
	}
	if(this.transform.position.y < Target.position.y-maxRange) {
		this.transform.position.y = Target.position.y-maxRange;
	}
	
}


