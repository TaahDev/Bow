using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{

    [Header("Bow Settings")]
    public float minStrength = 2f;
    public float maxStrength = 30f;
    public float drawTime = 0.35f;
    public float drawBackStrength = 0.05f;

    [Header("Projectile")]
    public GameObject projectilePrefab;
    public Transform projectilePoint;
    public Vector3 arrowRotation;
    public Camera fpCam;

    private float percentage = 0;
    private float currentDrawTime = 0;

    public Transform upperLine, middleLine, lowerLine;
    public LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
            DrawBow();

        if (Input.GetMouseButtonUp(0))
            StopDrawBow();
    }

    private void DrawBow()
    {
        currentDrawTime += Time.deltaTime;
        percentage = currentDrawTime / drawTime;

        RenderLine();

    }

    private void StopDrawBow()
    {
        //Instantiating Projectile
        GameObject projectile = Instantiate(projectilePrefab, projectilePoint.position, Quaternion.Euler(arrowRotation));

        //Calculate Force
        Vector3 force = ((fpCam.transform.forward * 100) - projectilePoint.transform.position).normalized * Mathf.Lerp(minStrength, maxStrength, percentage);

        //Setup Rotation Arrow Component
        projectile.GetComponent<Arrow>().SetDefaultRot(arrowRotation + force);

        //Add Force
        projectile.GetComponent<Rigidbody>().AddForce(force, ForceMode.VelocityChange);

        //Reset Force & Percentage
        percentage = 0f;
        currentDrawTime = 0f;

        RenderLine();
    }

    private void RenderLine()
    {
        lineRenderer.positionCount = 3;
        lineRenderer.SetPosition(0, upperLine.localPosition);
        lineRenderer.SetPosition(2, lowerLine.localPosition);

        //Middle Pos
        lineRenderer.SetPosition(1, middleLine.localPosition + Vector3.Lerp(Vector3.zero, new Vector3(-drawBackStrength, 0, 0), percentage));
    }

}
