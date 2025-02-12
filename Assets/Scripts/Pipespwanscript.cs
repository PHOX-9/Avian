using UnityEngine;

public class Pipespwanscript : MonoBehaviour
{
    public GameObject pipe;
    public float rate=2;
    public float timer=0;

    public float upperHeightOffset=10;
    public float lowerHeightOffset=10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {

        if(timer<rate){
            timer+=Time.deltaTime;
        }
        else{
        spawnPipe();
        timer=0;
        }
    }

    void spawnPipe(){
        float lowerpoint=transform.position.y-lowerHeightOffset;
        float upperpoint=transform.position.y+upperHeightOffset;
        float random=Random.Range(lowerpoint,upperpoint);
        Debug.Log(random);
        Instantiate(pipe, new Vector3(transform.position.x, random, 0), transform.rotation);
    }
}
