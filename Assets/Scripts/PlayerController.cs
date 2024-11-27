using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float velocidadMovimiento = 10f;
    [SerializeField] float xClampRange = 10f;
    [SerializeField] float yClampRange = 10f;
    [SerializeField] float rollFactorValue = 15f;
    [SerializeField] float rollSpeed = 10f;
    [SerializeField] float pitchFactorValue = 15f;
    [SerializeField] float pitchSpeed = 10f;
    Vector2 vectorMovimiento;

    // Update is called once per frame
    void Update()
    {
        ProcessTranslation();
        ProcessRotation();
    }
    
    void OnMoverse(InputValue value)
    {
        vectorMovimiento = value.Get<Vector2>();
    }

    void ProcessTranslation()
    {
        float xOffset = vectorMovimiento.x * velocidadMovimiento * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawXPos, -xClampRange, xClampRange);
        float yOffset = vectorMovimiento.y * velocidadMovimiento * Time.deltaTime;
        float rawYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYPos, -yClampRange, yClampRange);

        // Mathf.Clamp es una funcion para limitar el movimiento de la nave en la camara

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, 0f);
    }

    void ProcessRotation()
    {
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, -vectorMovimiento.x * rollFactorValue);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, rollSpeed * Time.deltaTime);
        Quaternion targetPitch = Quaternion.Euler(vectorMovimiento.y * pitchFactorValue, 0f, 0f);
        transform.localRotation = Quaternion.Lerp(transform.localRotation, targetPitch, pitchSpeed * Time.deltaTime);
           
    }
}
