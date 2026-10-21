using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    private Vector3 GoalPosition = new Vector3(22, 1, -14);
    
    void Start()
    {
        GoalPosition = GoalPosition * 0.5f;
    }

    void Update()
    {
        this.transform.Translate(GoalPosition);
        //GoalPosition = GoalPosition * 2.0f;
    }
}
