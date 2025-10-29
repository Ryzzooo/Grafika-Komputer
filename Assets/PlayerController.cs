using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // T = T + (1, 0, 0) * speed

    Vector3 kanan = new Vector3(1f, 0f, 0f);
    Vector3 kiri = new Vector3(-1f, 0f, 0f);
    Vector3 depan = new Vector3(0f, 0f, 1f);
    Vector3 belakang = new Vector3(0f, 0f, -1f);
    Vector3 atas = new Vector3(0f, 1f, 0f);
    Vector3 bawah = new Vector3(0f, -1f, 0f);

    float speed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += kanan * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += kiri * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += depan * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += belakang * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.position += atas * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.position += bawah * speed * Time.deltaTime;
        }
    }
}
