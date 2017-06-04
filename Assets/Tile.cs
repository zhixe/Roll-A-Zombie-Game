using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    public GameManager gameManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
#pragma warning disable CS0168 // Variable is declared but never used
        void OnTriggerEnter(Collider other)
#pragma warning restore CS0168 // Variable is declared but never used
        {
            gameManager.AddPoint();
        }
	}
}
