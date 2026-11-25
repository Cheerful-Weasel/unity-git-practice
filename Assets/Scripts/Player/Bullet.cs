using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int dmg;

    void Start()
    {
        Invoke("DestroySelf", 2.0f);
    }

    void DestroySelf()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
