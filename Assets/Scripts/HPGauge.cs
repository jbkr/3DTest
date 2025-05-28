using UnityEngine;

public class HPGauge : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        Vector3 pos = cam.WorldToScreenPoint(target.position);
        (transform as RectTransform).position = pos;
    }
}
