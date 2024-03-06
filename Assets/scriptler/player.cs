using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor;

public class player : MonoBehaviour
{
    private Animator anim;
    public bool isDead;
    private Rigidbody rigi;
    public float velocity = 5f;
    private float sabithareket;
    public gamemanager game;
    public GameObject patlama;


    int FlyingFWD;

    void Start()
    {

        //çağırma
        rigi = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();


       // IdleAgressive = Animator.StringToHash("IdleAgressive");

        FlyingFWD = Animator.StringToHash("FlyingFWD");


    }

    void Update()
    {
        sabithareket = Input.GetAxis("Horizontal");
        //ıdle
        if (sabithareket <= 0)
        {
            anim.SetBool("IdleAgressive", true);
        }
        else
        {
            anim.SetBool("IdleAgressive", false);
        }

        if (Input.GetMouseButtonDown(0))
        {

            //anim.SetBool(IdleAgressive, false);

            //    anim.SetBool(FlyingAttack, true);
            anim.SetTrigger("zıplama");
            rigi.velocity = Vector3.up * velocity;

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ölümalanı")
        {
            isDead = true;
          
            Instantiate(patlama, this.gameObject.transform.position, this.gameObject.transform.rotation);
            SceneManager.LoadScene("gameover");
        }
    }

    private void OnTriggerEnter(Collider obje)
    {
        if (obje.gameObject.tag == "puanalanı")
        {
            game.Updatescore();
        }
    }
}

       

