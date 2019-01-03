using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shakecam : MonoBehaviour
{

    Transform camtrans;
    public float shaketime;
    public float shakerange;
    Vector3 originalpos;

    // Start is called before the first frame update
    void Start()
    {
        camtrans = Camera.main.transform;
        originalpos = camtrans.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine("shakecamera");
        }
    }

    IEnumerator shakecamera()
    {
        float elapsetime = 0;

        while(elapsetime < shaketime)
        {
            Vector3 pos = originalpos + Random.insideUnitSphere* shakerange;
            pos.z = camtrans.position.z;

            camtrans.position = pos;

            elapsetime += Time.deltaTime;
            yield return null;
        }

        camtrans.position = originalpos;
    }

}
