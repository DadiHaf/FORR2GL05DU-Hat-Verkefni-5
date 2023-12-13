using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    public float hradi = 3.0f;

    public int stig = 1;
    public int lifid { get { return currentLif; } }
    int currentLif;

    Rigidbody2D rigidbody2d1;
    float horizontal;
    float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d1 = GetComponent<Rigidbody2D>();
        currentLif = stig;
        currentLif = 1;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d1.position;
        position.x = position.x + hradi * horizontal * Time.deltaTime;
        position.y = position.y + hradi * vertical * Time.deltaTime;

        rigidbody2d1.MovePosition(position);
    }

    public void BreytaLifi(int amount)
    {
        currentLif = Mathf.Clamp(currentLif + amount, 0, stig);
        Debug.Log(currentLif + "/" + stig);
    }
}
