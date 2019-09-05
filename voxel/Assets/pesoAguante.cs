using UnityEngine;
using System.Collections;

public class pesoAguante : MonoBehaviour
{
	//public List<string[]> rbs=new List<string>();
	public int masaSoportada = 1;
    // Make all rigidbodies we touch fly upwards
    void OnCollisionStay(Collision collision)
    {
        // Check if the collider we hit has a rigidbody
        // Then apply the force
        if (collision.rigidbody)
        {
		if (collision.rigidbody.transform.position.y>transform.position.y) {
            		if (collision.rigidbody.mass>masaSoportada) {
				Destroy(gameObject);
	    		}
		}
		//falta preguntar a los de arriba por su masa y sumarla en total
        }
    }
}
