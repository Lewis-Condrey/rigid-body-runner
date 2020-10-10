using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour

{
    public Rigidbody box;
    public float upwForce = 2000f;

    // Start is called before the first frame update
     void Start()
      {
        box = GetComponent<Rigidbody>();
      }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
         box.AddForce(0, upwForce, 0 * Time.deltaTime);
        }
    }
}