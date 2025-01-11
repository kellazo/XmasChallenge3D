using UnityEngine;

public class Cilindro : MonoBehaviour
{
   // [SerializeField] private float velocidadRotacion;
    private Rigidbody rb;
    [SerializeField] private float fuerzaRotacion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       rb.AddTorque(Vector3.up * fuerzaRotacion, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 direccionMovimiento = new Vector3(0, 1, 0).normalized;
        //transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime, Space.World);
        
    }
}
