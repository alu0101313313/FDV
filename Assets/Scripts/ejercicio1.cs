using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    private Vector3 GoalPosition = new Vector3(22, 1, -14);
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.transform.Translate(GoalPosition);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
