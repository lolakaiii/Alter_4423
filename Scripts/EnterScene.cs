using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrance : MonoBehaviour
{
    public GameObject entrance;
    public GameObject exit;
    public Vector3 offset = new Vector3(1, 0.5f, 0);
    private Rigidbody2D body;
    [SerializeField] public SceneData sceneData;


    void Awake() {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    void Start() {
        if (entrance == null) {
            return;
        }

        if (sceneData.isNextScene)
        {
            sceneData.distance -= 2;
        }

        Vector3 startingPosition = entrance.transform.position + offset;
        body.position = startingPosition;
    }
}
