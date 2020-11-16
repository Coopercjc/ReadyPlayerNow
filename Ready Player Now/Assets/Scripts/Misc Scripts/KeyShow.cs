using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyShow : MonoBehaviour {
    public GameObject _object1;
    public GameObject _object2;
    public GameObject _object3;
    // Start is called before the first frame update
    void Start()
    {
        _object1.SetActive (false);
        _object2.SetActive (false);
        _object3.SetActive (false);
    }

    // Update is called once per frame
    void Update() {
        if (secondsKeeper.Show1)
            _object1.SetActive(true);
    }
}
