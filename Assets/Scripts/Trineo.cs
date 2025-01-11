using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class Trineo : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxisRaw("Horizontal");
        float VInput = Input.GetAxisRaw("Vertical");
        Vector3 direccionMovimiento = new Vector3 (hInput, 0, VInput).normalized;
        //transform.position += direccionMovimiento * velocidad * Time.deltaTime;
        transform.Translate(direccionMovimiento * velocidad * Time.deltaTime);
    }
}
