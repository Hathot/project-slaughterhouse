#pragma strict


var theAnimator:Animator;

var Player:Transform;




var defaultSpeed = 1.0;
var sprintSpeed = 1.5;
var speedIncrease = 0.05;
var currentSpeed = 1.0;
var amountOfButtonsPressed = 0;
var directionDegree = 0;

private var isSprinting = false;


function Start () {
}

function Update () {	
    
    if(Input.GetButton("Up")) {
    	theAnimator.SetFloat("Speed", 1);
    	Player.transform.Translate(-0.2,0,0);    	
    	
    }
    else {
    theAnimator.SetFloat("Speed", 0);
    }

    
        
            
                /*    if(Input.GetButton("Up")) {
    
    	//change speed to normal run speed
    	changeSpeed(defaultSpeed);
    	
    	//set the parameter Speed
    	theAnimator.SetFloat("Speed", 1);
    	
    	//set the animator speed
    	theAnimator.speed = currentSpeed;    	   	
    }  
    
    if(Input.GetButtonUp("Up")) {
    	amountOfButtonsPressed--; 
    }  
    
    if(Input.GetButtonDown("Left")) {
    	amountOfButtonsPressed++; 
    	directionDegree-=90;
    	theAnimator.transform.Rotate(0,(directionDegree/amountOfButtonsPressed),0,Space.World);  
    }
    if(Input.GetButtonUp("Left")) {
    	amountOfButtonsPressed--; 
    	directionDegree+=90;
    }
    if(Input.GetButton("Left")) {
    
    	//change speed to normal run speed
    	changeSpeed(defaultSpeed);
    	
    	//set the parameter Speed
    	theAnimator.SetFloat("Speed", 1);
    	
    	//set the animator speed
    	theAnimator.speed = currentSpeed;    
    }
    
    if(Input.GetButtonDown("Right")) {
    	amountOfButtonsPressed++; 
    	directionDegree+=90;
    	theAnimator.transform.Rotate(0,(directionDegree/amountOfButtonsPressed),0,Space.World);  
    }
    if(Input.GetButtonUp("Right")) {
    	amountOfButtonsPressed--; 
    	directionDegree-=90;
    }
        if(Input.GetButton("Right")) {
    
    	//change speed to normal run speed
    	changeSpeed(defaultSpeed);
    	
    	//set the parameter Speed
    	theAnimator.SetFloat("Speed", 1);
    	
    	//set the animator speed
    	theAnimator.speed = currentSpeed;    
    }
    
    
    if(amountOfButtonsPressed==0) {
    	changeSpeed(0);  
    	theAnimator.SetFloat("Speed", 0);
    	theAnimator.speed = 1;
    }
    
    
    
    
    
    if(Input.GetButton("Left")) {
    	if(Input.GetButtonDown("Left")) {
   			 		
   		}
   	
    	if(Input.GetButton("Left")) {    	
   			theAnimator.SetFloat("Speed", 1);
   		}
    }
    if(Input.GetButton("Right")) {
    	if(Input.GetButtonDown("Right")) {
   			theAnimator.transform.Rotate(0,90,0,Space.World);   		
   		}
   	
    	if(Input.GetButton("Right")) {    	
   			theAnimator.SetFloat("Speed", 1);
   		}
    }   
    
        
    else {
    	 changeSpeed(maxSpeed);
    	 theAnimator.SetFloat("Speed", 0);
   		 theAnimator.speed = 1;
    }*/
    
   // if (Input.GetButton("Sprint")) {
    //	changeSpeed(maxSprintSpeed);  
    //	theAnimator.SetFloat("Speed", speed);
    //	theAnimator.speed = speed;
    //}
        
            
   
   
   
    
   	
   	
   	//turning Left
   
   
   	
   
} 


function changeSpeed(maxSpeed:float) {
	if(currentSpeed >= maxSpeed) {
		currentSpeed -= speedIncrease;
	}
	else {
		currentSpeed+=speedIncrease;
	}
}

