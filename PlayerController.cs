using UnityEngine;

// Simple player movement script example
// Attach to a GameObject (e.g., a Sprite or Cube) in a scene
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, v, 0f);
        transform.position += dir * speed * Time.deltaTime;
    }
}
