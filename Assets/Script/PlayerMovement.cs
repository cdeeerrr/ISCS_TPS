using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	
	private CharacterController characterController;
	[SerializeField] private float moveSpeed = 200f;
	[SerializeField] private float turnSpeed = 5f;
	
	private void Awake(){
		characterController = GetComponent<CharacterController>();
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
		var vertical = Input.GetAxis("Vertical");
		
		var movement = new Vector3(horizontal, 0, vertical);
		
		characterController.SimpleMove(movement * Time.deltaTime * moveSpeed);
    }
}
