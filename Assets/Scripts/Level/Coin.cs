using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float animationDuration;
    [SerializeField] MeshRenderer rend;
    [SerializeField] ParticleSystem ps;

    private void OnTriggerEnter(Collider other)
    {
        CoinsController.Instance.Increment();
        rend.enabled = false;
        animationDuration = ps.main.duration;
        ps.Play();
        StartCoroutine(Animation());
    }

    IEnumerator Animation()
    {
        //float startTime = Time.time;
        //while (Time.time - startTime < animationDuration)
        //{

        //}

        yield return new WaitForSeconds(animationDuration);
        Destroy(gameObject);
    }
}
