using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> ADlist = new List<GameObject>();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetAD()
    {
        ADlist[Random.Range(0 , ADlist.Count)].SetActive(true);
    }
}
