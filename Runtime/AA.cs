using UnityEngine;
using DEVp;

public class AA : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.ResetLocal();
        transform.DestroyChildren();

        Debug.Log($"더한값 : {MyMath.Add(1,3)}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

