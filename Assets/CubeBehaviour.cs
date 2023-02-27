using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{

    [SerializeField] float rotateSpeed = 30f;
    [SerializeField] bool spinning = false;

    // Start is called before the first frame update
    void Start()
    {
        spinning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (spinning)
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }

    private void OnMouseUpAsButton()
    {
        spinning = true;
    }
}
