using UnityEngine;

 public class Player_Movement{
    public float Player_velocity;
    public float Player_Mass; // This value is a place holder 
    public float Gravity; // This value is a place holder 
    public float Defult_Jump; // This value is a place holder 
    public float Boosted_jump;
    public float Momentum;

 public Player_Movement() {
      Player_velocity = 0;
     Player_Mass = 1; // This value is a place holder 
     Gravity = -0.1f; // This value is a place holder 
     Defult_Jump = 2.0f; // This value is a place holder 
     Boosted_jump = Defult_Jump * 1.2f;
     Momentum = Player_Mass * Player_velocity;
 }

 }
 class Player01_Attribute {}
    
public class Movement: MonoBehaviour {

Player_Movement Player01_Movement = new Player_Movement(); 


    // Update is called once per frame
    void Update()
    {
        // This section recieves player possion and input 
       float xDirection = Input.GetAxis("Horizontal"); 
       float zDirection = Input.GetAxis("Vertical"); 
       bool JumpKey = Input.GetKey(KeyCode.Space);
       bool JumpKeyHeld = Input.GetKeyDown(KeyCode.Space);
       // This section updates player possition 
       Vector3 movedirection = new Vector3(xDirection, Player01_Movement.Gravity, zDirection);
       transform.position += movedirection;
       // Checks if space bar is pressed and activates jump when pressed for i frame  
       if (JumpKey == true){
           Vector3 JumpDir = new Vector3(0.0f, (Player01_Movement.Defult_Jump* Player01_Movement.Momentum), 0.0f);
           transform.position += JumpDir;
           JumpKey = false;
           
       if (JumpKeyHeld == true){
       Vector3 JumpHeld = new Vector3(0.0f, (Player01_Movement.Player_velocity* Player01_Movement.Boosted_jump), 0.0f);
       transform.position += JumpHeld;
       JumpKeyHeld = false; 

           }

       }

    }
}

