using UnityEngine;

public class Trineo : MonoBehaviour
{
    public float velocidad = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        float VInput = Input.GetAxisRaw("Vertical");
        Vector3 direccionMovimiento = new Vector3 (hInput, 0, VInput).normalized;
        transform.position += direccionMovimiento * velocidad * Time.deltaTime;
    }
}
