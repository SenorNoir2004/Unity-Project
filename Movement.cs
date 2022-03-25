using UnityEngine;

 public class Player_Movement{
    public float Player_velocity;
    public float Player_Mass; // This value is a place holder 
    public float Gravity; // This value is a place holder 
    public float Defult_Jump; // This value is a place holder 
    public float Boosted_jump;
    public float Momentum;

 public Player_Movement() {
      Player_velocity = 70f;
     Player_Mass = 1; // This value is a place holder 
     Gravity = -4f; // This value is a place holder 
     Defult_Jump = 2.0f; // This value is a place holder 
     Boosted_jump = Defult_Jump * 1.2f;
     Momentum = Player_Mass * Player_velocity;

    
public class Classic_Controls: MonoBehaviour 
{
    public Camera cam;
    MouseInput mouseInput;


    private Vector3 destination;
   
public Vector3 T = new Vector3();

public Player_Movement Player01_Movement = new Player_Movement(); 
   public CharacterController controller;
   public float turnSmoothTime = 0.1f;
   float turnSmoothVelocity;
       

    // Update is called once per frame
    public void Update()
    {
 
        }
        
        // This section recieves player possion and input

        //Transforms player movement 
        if (Vector3.Distance(transform.position, destination) > 0.1f)
          transform.position = Vector3.MoveTowards(transform.position, destination, Player01_Movement.Player_velocity* Time.deltaTime);
         

       float xDirection = Input.GetAxis("Horizontal"); 
       float zDirection = Input.GetAxis("Vertical"); 
       bool JumpKey = Input.GetKey(KeyCode.Space);
       bool JumpKeyHeld = Input.GetKeyDown(KeyCode.Space);
       // This section updates player possition
       Vector3 DirectT = new Vector3(xDirection, Player01_Movement.Gravity, zDirection).normalized; 
       Vector3 movedirection = new Vector3(xDirection, Player01_Movement.Gravity, zDirection).normalized;
       Vector3 T = DirectT;
       //The magn itude is calculated here. Ob)IF
       if (movedirection.magnitude >= 0.1f)
       {/// Atan2 is a function that returns an angle between the x axis and the y axisin raidians 
           float targetAngle = Mathf.Atan2(movedirection.x, movedirection.z) * Mathf.Rad2Deg;
           float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y,targetAngle,ref turnSmoothVelocity, turnSmoothTime);
           controller.Move(movedirection * Player01_Movement.Player_velocity * Time.deltaTime);
           transform.rotation = Quaternion.Euler(0f,angle, 0f);
       }
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



