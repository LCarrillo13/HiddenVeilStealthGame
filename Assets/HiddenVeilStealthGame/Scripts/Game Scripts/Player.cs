using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controls
{
    public class Player : MonoBehaviour
    {
        
        [Header("Player Components")]

        [SerializeField] private GameObject player;

        [SerializeField] private Rigidbody rb;

        [SerializeField] private Collider aCollider;
 
        

        [Header("Player Variables")] 
        [SerializeField] private float moveSpeed = 10;
        [SerializeField] private float jumpHeight = 5;
        [SerializeField] private float crouchSpeed = 5;
        [SerializeField] private bool isHidden = false;
        
        

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            isHidden = false;
        }

        // Update is called once per frame
        void Update() { }

        private void Hide()
        {
            Debug.Log("Object has been Hidden");
            isHidden = true;
        }
    }
}
