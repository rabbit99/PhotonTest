using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shaderController : MonoBehaviour
{
    public Material shaderMaterial;
    // Start is called before the first frame update
    void Start()
    {
        shaderMaterial = GetComponent<RawImage>().material;
        //shaderMaterial.SetFloat("st", 5);
        //GetComponent<RawImage>().material.SetFloat("Vector1_CA16C7E0", 5);
        StartCoroutine(set());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator set()
    { float i = 0;
        yield return new WaitForSeconds(0.5f);
        while (i < 30)
        {
            i += 0.3f;
            GetComponent<RawImage>().material.SetFloat("Vector1_CA16C7E0", i);
            yield return new WaitForEndOfFrame();
        }
        while (i > 0)
        {
            i -= 0.3f;
            GetComponent<RawImage>().material.SetFloat("Vector1_CA16C7E0", i);
            yield return new WaitForEndOfFrame();
        }
    }
}
