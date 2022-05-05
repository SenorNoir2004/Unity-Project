using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Attomic_Count : MonoBehaviour
{
    public P1_Skills Display_At;
    public TextMeshProUGUI textMesh;
    public TextMeshProUGUI textMesh2;

    // Start is called before the first frame update
    private void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        textMesh.SetText(Display_At.Bombcount.ToString());
        textMesh2.SetText(Display_At.MBombcount.ToString());
       
    }
}
