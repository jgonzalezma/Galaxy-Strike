using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    bool isFiring = false;
    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform puntoMira;
    [SerializeField] Transform targetPoint;
    [SerializeField] float targetDistance = 200f;
    private Camera cam;

    private void Start()
    {
        Cursor.visible = false;
        cam = Camera.main;
    }

    private void Update()
    {
        ProcessFiring();
        Aim();
        AimLasers();
    }
    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    void ProcessFiring()
    {
        foreach (GameObject laser in lasers)
        {
            var emissionModule = laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isFiring;
        }
    }

    void Aim()
    {
        Vector3 targetPointPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, targetDistance);
        targetPoint.position = Camera.main.ScreenToWorldPoint(targetPointPosition);
        puntoMira.position = Input.mousePosition;
    }

    void AimLasers()
    {
        foreach (GameObject laser in lasers)
        {
            Vector3 fireDirection = targetPoint.position - this.transform.position;
            Quaternion rotationToTarget = Quaternion.LookRotation(fireDirection);
            laser.transform.rotation = rotationToTarget;
        }
    }
}
