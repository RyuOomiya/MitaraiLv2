using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] Model _model;

    private void Awake()
    {
        _model = GameObject.Find("GameManager").GetComponent<Model>();
    }
    private void OnTriggerEnter(Collider other)
    {
        _model.ScorePlus();
        Destroy(gameObject);
    }


}
