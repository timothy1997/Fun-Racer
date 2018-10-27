using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player 1" || collision.gameObject.tag == "Player 2")
        {
            Vector3 pos = new Vector3(-400.7f, 257f, 461.0289f);
            collision.gameObject.transform.position = pos;
        }

    }
}
