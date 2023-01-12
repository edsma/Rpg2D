using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<T>();
                if(instance == null)
                {
                    GameObject nuevoGO = new GameObject();
                    instance = nuevoGO.AddComponent<T>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        instance = this as T;
    }
}
