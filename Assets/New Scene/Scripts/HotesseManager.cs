using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotesseManager : MonoBehaviour
{
    public LayerMask mask;
    [SerializeField] Transform player;
    void Start()
    {
       //mask = LayerMask.GetMask("Player");
    }


    void Update()
    {
        HelloHotesse();
    }
    private void HelloHotesse()
    {
       

        if (Physics.CheckSphere(transform.position, 5f, mask))
        {
            transform.LookAt(player);

        }
    }
}
