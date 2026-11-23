using UnityEngine;
using Unity.Cinemachine;

public class CameraTransitor : MonoBehaviour
{

    public enum Target { ToConfined, ToFree }

    [SerializeField] private Target target = Target.ToConfined;
    [SerializeField] private CinemachineBrain brain;
    [SerializeField] private CinemachineCamera confinedCam;
    [SerializeField] private CinemachineCamera freeCam;
    [SerializeField] private CinemachineBlendDefinition blend =
        new CinemachineBlendDefinition(CinemachineBlendDefinition.Styles.EaseInOut, 1f);

    void Start()
    {
        // Blend por defecto de la transición
        brain.DefaultBlend = blend;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        if (target == Target.ToConfined)
        {
            SetPriority(confinedCam, 20);
            SetPriority(freeCam, 0);
        }
        else
        {
            SetPriority(freeCam, 20);
            SetPriority(confinedCam, 0);
        }
    }

    // Priority es una estructura, así que la copiamos, cambiamos el valor y la reasignamos
    void SetPriority(CinemachineCamera cam, int value)
    {
        var p = cam.Priority;
        p.Value = value;
        cam.Priority = p;
    }
}
