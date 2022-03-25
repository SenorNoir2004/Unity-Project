using System; 
using static System.Console; 
using UnityEngine;

public class Selection_Manager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable"; 
    [SerializeField] private Material  highlightMaterial;
    [SerializeField] private Material  DefultMaterial;
    public Camera Cam; 
    private Transform _selection; 
    private float MaxDist = 500f;
    public GameObject NexusOb;
    public MouseClickDetected  Clicks; 
    public bool Nex_Selected = false; 
    public Vector3 Nexus_Location; 
    private float Select_Time = 0.5f;
    private bool CoRuitineAllowed = false; 
    

    private void Start()
    {
      CoRuitineAllowed =  true;
    }
    
    
        // Update is called once per frame
    public (bool,Vector3) Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = DefultMaterial;
            _selection = null;
        }
     
        // Mouse and ray interact when casted 
       Ray ray = Cam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * MaxDist, Color.red);
       //Ray is casted 
       if(Physics.Raycast(ray, out RaycastHit hit, MaxDist))
       {
          
           //Grabs the transform of the current slection
           var selection = hit.transform;
           //Grabs selections renderer 
           var selectionRenderer = selection.GetComponent<Renderer>();
           if (selection.CompareTag(selectableTag))
           {
             if((Clicks.clickCounter >= 1) && ( selectionRenderer  != null) )
             //Logic for selecting the nexus. When the player clicks on the nexus Nex_Selected will be set tp true  
             {
              Nex_Selected = true; 
              Nexus_Location = NexusOb.transform.position;
              
             }
            if(Clicks.clickCounter == 0)
            {
              Nex_Selected = false;  
            }
             
              
               
            // Sets material to highlighted material 
            if ( selectionRenderer != null)
             {
                 
             selectionRenderer.material = highlightMaterial;
            
             }
             _selection = selection;
             
            }
             
             
             
        }
          
         
       return (Nex_Selected,Nexus_Location);

       
       

    }

    
    
}
