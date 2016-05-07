using UnityEngine;
using System.Collections;

public class TestBeatDetection : MonoBehaviour, AudioProcessor.AudioCallbacks {

    private AudioProcessor audioProcessor;

    void Awake() {
        audioProcessor = Camera.main.GetComponent<AudioProcessor>();
        audioProcessor.addAudioCallback(this);
    }

    void Start() {
        //Select the instance of AudioProcessor and pass a reference
        //to this object
        //AudioProcessor processor = FindObjectOfType<AudioProcessor>();
    }


    void Update() {

    }

    public void onOnbeatDetected() {
        Debug.Log("Beat!!!");
    }

    public void onSpectrum(float[] spectrum) {

    }
}