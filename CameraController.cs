using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject _character;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - _character.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _character.transform.position + offset;
    }
}
