using UnityEngine;

public class CircleDrawer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    float radius=2f;
    int segments =100;
    private LineRenderer lineRenderer;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = segments +1;
        for (int i=0; i<=segments; i++)
        {
            float angle=(i/(float)segments)*2*Mathf.PI;
            float x=radius*Mathf.Cos(angle);
            float y=0.1f;
            float z=radius*Mathf.Sin(angle);
            lineRenderer.SetPosition(i,new Vector3(x,y,z));
        }        
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
