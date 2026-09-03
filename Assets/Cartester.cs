using System.Runtime.CompilerServices;
using UnityEngine;
public class CarTester : MonoBehaviour
{
    // Start is called once before the first frame update

    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float turnSpeed = 100f;
    void Start()
    {
 // This is our test message!
  Debug.Log("My awesome car is ready! Hello from ");
    }

    private void Update()
    {
        MoveVehicle();
        TurnVehicle();
    }

    void MoveVehicle()
    {
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(transform.forward * verticalInput * moveSpeed * Time.deltaTime);

        if (verticalInput !=0)
        {
            Debug.Log("Vehicle is moving");
        }

        if (verticalInput < 0)
        {
            Debug.Log("Vehicle is reversing.");
        }

    }

    void TurnVehicle()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(0f, horizontalInput * turnSpeed * Time.deltaTime, 0f);
    }


}
        

