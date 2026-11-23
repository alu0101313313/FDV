using UnityEngine;
using Unity.Cinemachine;
using System;

public class ExplosionTrigger : MonoBehaviour
{
    [SerializeField] private CinemachineImpulseSource impulseSource;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            impulseSource.GenerateImpulse();
        }
    }
}
