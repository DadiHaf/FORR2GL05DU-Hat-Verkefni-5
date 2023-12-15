using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.lifid < controller.maxLif)
            {
                controller.BreytaLifi(1);
                Destroy(gameObject);
            }
        }
    }

}
