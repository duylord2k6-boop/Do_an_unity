using UnityEngine;

public class car : MonoBehaviour
{
    [SerializeField] private float toc_Do = 10f;
    [SerializeField] 
    private float luc_re = 10f;
    private float dau_Vao_Di_Chuyen;
    private float dau_Vao_Re;
    [SerializeField]
    private float luc_Phanh = 50f;
    
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        dau_Vao_Di_Chuyen = Input.GetAxis("Vertical");
        dau_Vao_Re = Input.GetAxis("Horizontal");
        Move();
        Turn();
        if (dau_Vao_Di_Chuyen > 0 && Input.GetKey(KeyCode.Space))
        {
            Brake();
        }
    }

    private void Move()
    {
        rb.AddForce(transform.forward * dau_Vao_Di_Chuyen * toc_Do);
    }

    public void Turn()
    {
        Quaternion re = Quaternion.Euler(Vector3.up * dau_Vao_Re * luc_re * Time.deltaTime);
        rb.MoveRotation(rb.rotation*re);
    }

    public void Brake()
    {
       if(rb.linearVelocity.z != 0)
        {
            rb.AddForce(-transform.forward * luc_Phanh);
        }
    }
}