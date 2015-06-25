using UnityEngine;
using System.Collections;

/**
*
 */
public class AudioTest : MonoBehaviour {
    public int halloWorld = 2;

    // Use this for initialization
    void Start() {
        var gameObject = GameObject.Find("enzo");
        var audio = gameObject.GetComponent(typeof(AudioSource));
        (audio as AudioSource).Play();
    }

    // Update is called once per frame
    void Update() {

    }
}
