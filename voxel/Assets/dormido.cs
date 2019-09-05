using UnityEngine;

public class dormido : MonoBehaviour
{
	public Vector3 posicion;
	public bool estaDormido = true;	
	Rigidbody rb;
	public float temporizador = 5;

    void Start()
    {
	GetComponent<Rigidbody>().Sleep();
    }
}
