using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SerializeFieldManager : MonoBehaviour
{
    [HideInInspector]
    public int valueTemp = 5;

    [SerializeField]
    private int privateValue = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        //Debug.Log("ok");
    }
}
