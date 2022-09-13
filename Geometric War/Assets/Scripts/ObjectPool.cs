using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> : MonoBehaviour
{
    private List<T> m_Objects = new List<T>();
    private Transform m_Transform;

    public void Initialise(Transform parent, int amount, T item)
    {
        for (int i = 0; i < amount; i++)
        {
            Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube), parent);
            //GameObject obj = ()item;
            //var obj = Instantiate(item, parent);
            //m_Objects.Add(obj);
        }
    }

    public T GetItem()
    {
        return default;
    }

    public void ReturnItem(T item)
    {

    }

}
