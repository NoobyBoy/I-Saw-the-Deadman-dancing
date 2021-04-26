using UnityEngine;

public class DestroyOnEnable : MonoBehaviour
{
    public GameObject obj;


    private void OnEnable()
    {
        Destroy(obj);
        Destroy(this);
    }

}
