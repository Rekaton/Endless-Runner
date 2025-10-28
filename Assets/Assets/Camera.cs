using UnityEngine;

public class Camera : MonoBehaviour
{

    public float speed;
    void Update()
    {
        transform.position += new Vector3(speed*Time.deltaTime,0,0);
    }
}
