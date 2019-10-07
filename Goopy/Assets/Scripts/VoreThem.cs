using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoreThem : MonoBehaviour
{
    Voreable voreComponent;
    private Rigidbody rb = new Rigidbody();

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        voreComponent = collision.gameObject.GetComponent<Voreable>();
        

        if (voreComponent != null)
            if (transform.localScale.x >= voreComponent.vore.sizeToVore)
            {
                if (voreComponent.isVored != true) {
                    voreComponent.isVored = true;
                    StartCoroutine(waitExplode(collision.gameObject, voreComponent));
                }                
            }           
    }

    IEnumerator waitExplode(GameObject duckyou, Voreable voreComp)
    {
        yield return new WaitForSeconds(0.5f);

        Destroy(duckyou);
        transform.localScale += (Vector3.one * voreComp.vore.sizeToGrow);
        PlayerMove moveSpeed = gameObject.GetComponent<PlayerMove>();
        moveSpeed.playerSpeed *= 1.06f;
        rb.mass *= 1.04f;
    }
}

