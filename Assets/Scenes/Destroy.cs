using UnityEngine;

public class Destroy : MonoBehaviour
{

    public GameObject gameObjectOutside;

    void Start()
    {
        if (gameObjectOutside != null)
        {
            Destroy(gameObjectOutside);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
