using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    public float moveSpeed = 5f;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        this.anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");  
        float v = Input.GetAxis("Vertical");

        Vector3 moveDir = (Vector3.up * v) + (Vector3.right * h);
        this.transform.Translate(moveDir.normalized * this.moveSpeed * Time.deltaTime);

        this.anim.SetInteger("dir", (int)h);
    }
}