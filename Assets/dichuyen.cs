using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dichuyen : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator anim;
    public int tocDo = 4;
    public float traiPhai;
    public bool isFacingRight = true;
  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        traiPhai = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(tocDo * traiPhai, rb.velocity.y);

        if (isFacingRight == true && traiPhai == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            isFacingRight = false;
        }
        if (isFacingRight == false && traiPhai == 1)
        {

            transform.localScale = new Vector3(1, 1, 1);
            isFacingRight = true;
        }
        //Animation
        anim.SetFloat("dichuyen", Mathf.Abs(traiPhai));
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("tancong");
        }

        if (Input.GetMouseButtonDown(1))
        {
            anim.SetTrigger("dead"); 
        }
    }
}
