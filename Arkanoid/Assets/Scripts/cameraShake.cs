using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class cameraShake : MonoBehaviour
{
    private Vector3 originPosition;
    private Quaternion originRotation;
    public float shake_decay;
    public float shake_intensity;
    public Text text;

    void Update()
    {
        if (shake_intensity > 0)
        {
            text.transform.position = originPosition + Random.insideUnitSphere * shake_intensity;
            text.transform.rotation = new Quaternion(
            originRotation.x + Random.Range(-shake_intensity, shake_intensity) * .2f,
            originRotation.y + Random.Range(-shake_intensity, shake_intensity) * .2f,
            originRotation.z + Random.Range(-shake_intensity, shake_intensity) * .2f,
            originRotation.w + Random.Range(-shake_intensity, shake_intensity) * .2f);
            shake_intensity -= shake_decay;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("brick"))
        {
            Shake();
        }
    }

    public void Shake()
    {
        originPosition = text.transform.position;
        originRotation = text.transform.rotation;
        shake_intensity = .1f;
        shake_decay = 0.02f;
    }
}
