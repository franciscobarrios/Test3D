using UnityEngine;

public class StarterScript : MonoBehaviour
{
    [SerializeField] int myNumner;
    [SerializeField] string myName;
    [SerializeField] GameObject myObject;

    void Start()
    {
        myObject.SetActive(true);
    }


    void Update()
    {

    }
}
