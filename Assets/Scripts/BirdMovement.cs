using Unity.VisualScripting;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    AudioManager audioManager;

    public Rigidbody2D myRigidbody;
    public float flap;

    bool check=true;

    public LogicScript logic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        audioManager=GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&check)
        {
            myRigidbody.linearVelocity = Vector2.up *flap;
            audioManager.PlaySFX(audioManager.jump);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision ){
        if(collision.gameObject.tag=="obstacle"&&check){
        audioManager.PlaySFX(audioManager.GameOver);
        logic.gameOver();
        check=false;
        }
    }
}
