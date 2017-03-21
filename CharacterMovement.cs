using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    Animator anim;
    bool IsWalking = false;
    public float _speed;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float input_x = Input.GetAxisRaw("Horizontal");
        float input_y = Input.GetAxisRaw("Vertical");


     IsWalking = (Mathf.Abs(input_x) + Mathf.Abs(input_y)) > 0;
        anim.SetBool("IsWalking", IsWalking);

        if (IsWalking)
        {
            anim.SetFloat("x", input_x);
            anim.SetFloat("y", input_y);
            transform.position += (new Vector3(input_x, input_y, 0).normalized) * _speed * Time.deltaTime;
        }
    }

}
