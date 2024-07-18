using UnityEngine;










using System.Collections;

public class shoot : MonoBehaviour

{



    public GameObject bullet;
    public float delayTime = 8;
    private float counter = 0;

    // Start is called once befy
    void Start ()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Mouse0) && counter > delayTime)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            GetComponent<AudioSource>().Play();
            counter = 0;
            RaycastHit hit;
           
            
        }
        counter += Time.deltaTime;
    }
}
