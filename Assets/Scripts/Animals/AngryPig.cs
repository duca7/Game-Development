using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryPig : MonoBehaviour
{

    public float forceY = 300f;

    private Rigidbody2D myBody;
    private Animator anim;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Attack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(Random.Range(0, 3));

        forceY = Random.Range(250f, 500f);

        // jump
        myBody.AddForce(new Vector2(0, forceY));

        anim.SetBool("Attack", true);

        yield return new WaitForSeconds(0.7f);

        StartCoroutine(Attack());
    }
}
