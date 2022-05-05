using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsconderEscolha : MonoBehaviour
{
    public GameObject ToggleStart;

    private void Start()
    {
        StartCoroutine(Hide(2, ToggleStart));
    }
    IEnumerator Hide (int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(2);
        obj.SetActive(false);

    }

    
}
