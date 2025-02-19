using UnityEngine;
public class PlayerController : MonoBehaviour
{
    public float carSpeed = 50f;
    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move vehichle
        transform.Translate(Vector3.forward * Time.deltaTime * carSpeed);
    } 
}
