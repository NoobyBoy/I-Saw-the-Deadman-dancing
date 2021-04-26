using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour
{

    public GameObject prefab;
    public int size;

    public Transform stock;

    Queue<GameObject> q = new Queue<GameObject>();

    void Start()
    {
        if (!stock)
            stock = transform;
        for (int i = 0; i < size; ++i)
        {
            GameObject obj = Instantiate(prefab, stock);
            obj.SetActive(false);
            q.Enqueue(obj);
        }
    }


    public GameObject SpawnFromPool(Vector3 position, Quaternion rotation)
    {
        GameObject obj = q.Dequeue();
        obj.SetActive(false);
        obj.transform.position = position;
        obj.transform.rotation = rotation;
        obj.SetActive(true);
        q.Enqueue(obj);
        return obj;
    }

}
