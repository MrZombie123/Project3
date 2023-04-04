using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public KeyCode interact = KeyCode.E;
    [SerializeField]AudioClip buttonClick;
    [SerializeField]LayerMask IlayerMask;
    //[SerializeField]private Vector3 castPoint;
    [SerializeField]private AudioSource audioSource;
    [SerializeField]private Camera playerCamera;
    private interactable currentInteractable;
    
    //private RaycastHit IRayHit;
    // Start is called before the first frame update
    void Start()
    {
        //
    }
    
    // Update is called once per frame
    void Update()
    {
       
       
             //RaycastHit IRayHit;
            if(Input.GetKeyDown(interact))
            {
                //Physics.Raycast(playerCamera.ViewportPointToRay(castPoint), out RaycastHit hit, 2);
                Vector3 direction = Vector3.forward;
                Ray theRay = new Ray(transform.position, transform.TransformDirection(direction*3));
                Debug.DrawRay(start: transform.position, dir: transform.TransformDirection(direction*3), color: Color.blue, duration: 0.1f);
                Debug.Log("raycast");
                audioSource.PlayOneShot(buttonClick,1);
                if(Physics.Raycast(theRay, out RaycastHit hit, 3) && hit.collider.gameObject.layer==9 && (currentInteractable == null || hit.collider.gameObject.GetInstanceID() != currentInteractable.GetInstanceID()))
                {
                    Debug.Log("ray");
                    
                    hit.collider.TryGetComponent(out currentInteractable);
                    if(currentInteractable)
                    {
                        currentInteractable.GetComponent<interactable>().OnInteract();
                    }
                    
                }
                else if(currentInteractable)
                {
                    currentInteractable = null;
                }
            /*if(hit.collider.gameObject.layer==9)
            {
                hit.collider.TryGetComponent(out currentInteractable);
                //currentInteractable
                 currentInteractable.OnInteract();
                 Debug.Log("ray");
                 
            } 
            else
            {
                audioSource.PlayOneShot(buttonClick,1);
            }*/
            }
           
            
        
    }
}
