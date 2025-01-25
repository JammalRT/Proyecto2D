using UnityEngine;

public class GroundScroll : MonoBehaviour
{
    public float speed = 2f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
