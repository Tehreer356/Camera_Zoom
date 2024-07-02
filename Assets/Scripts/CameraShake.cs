using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeTime;
    public float shakeRange;

    Transform camTrans;
    Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        camTrans = Camera.main.transform;
        originalPosition = camTrans.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            StartCoroutine(ShakeCamera());
        }
    }
    IEnumerator ShakeCamera() 
    {
        float elapsedTime = 0;
        while(elapsedTime < shakeTime)
        {
            Vector3 pos = originalPosition+Random.insideUnitSphere*shakeRange;
            pos.z = originalPosition.z;
            camTrans.position = pos;
            elapsedTime += Time.deltaTime;
            yield return null;


        }
        camTrans.position = originalPosition;
    }
}
