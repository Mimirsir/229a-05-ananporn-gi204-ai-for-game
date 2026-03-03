using UnityEngine;

public class MoveAirplane : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] 
    float force;
    public AudioClip planeSound;
    public AudioSource source;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            source.PlayOneShot(planeSound);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.back * force, ForceMode.Impulse);

        }
    }
}
