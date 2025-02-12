using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed=5;
    public float deadzone=-20;

    public bool check=true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(check){
        transform.position=transform.position+(Vector3.left*speed)*Time.deltaTime;
        if(transform.position.x<-20){
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
        }
    }

}
