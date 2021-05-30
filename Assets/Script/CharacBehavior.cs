using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacBehavior : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vitesse;
    public Animator anim;
    public float max_Jump;
    public float VulnerabilityTime;
    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        SetVelocity(vitesse, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && isGrounded)
        {
            Jump();
        }
    }

   public void Jump()
    {
        GameObject.Find("JumpSound").GetComponent<AudioSource>().Play(0);
        rb.velocity += new Vector2(0, max_Jump);
        anim.SetBool("IsJumping", true);
    }

    	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.CompareTag("Ground")){
			anim.SetBool("IsJumping", false);
			isGrounded = true;
		}
    }
    	void OnCollisionExit2D(Collision2D col){
		if(col.gameObject.CompareTag("Ground")){
			// anim.SetBool("IsJumping", false);
			isGrounded = false;
		}
    }

    void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("Obstacle")){
			StartCoroutine(ObstacleFind());
		}
    }

     IEnumerator ObstacleFind()
    {
    	yield return new WaitForSeconds(0.1f);
        GameObject.FindWithTag("Monster").GetComponent<MonsterSystem>().GoCloser();
        SetVelocity(vitesse/2,0);
        yield return new WaitForSeconds(0.5f);
        SetVelocity(vitesse,0);
        yield return new WaitForSeconds(VulnerabilityTime);
        GameObject.FindWithTag("Monster").GetComponent<MonsterSystem>().GoFurther();
        
    }

       void SetVelocity(float xVelocity, float yVelocity){
    	rb.velocity = new Vector2(0, 0);
    	rb.velocity += new Vector2(xVelocity, yVelocity);
    }
}
