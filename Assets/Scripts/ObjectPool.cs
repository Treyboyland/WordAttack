using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField]
    protected T prefab;

    protected List<T> pool = new List<T>();

    protected T CreateObject()
    {
        var newObj = Instantiate(prefab, transform);
        newObj.gameObject.SetActive(false);
        pool.Add(newObj);
        return newObj;
    }

    public T GetObject()
    {
        foreach (var obj in pool)
        {
            if (!obj.gameObject.activeInHierarchy)
            {
                return obj;
            }
        }

        return CreateObject();
    }

    public void DisableAll()
    {
        foreach (var obj in pool)
        {
            obj.gameObject.SetActive(false);
        }
    }
}
