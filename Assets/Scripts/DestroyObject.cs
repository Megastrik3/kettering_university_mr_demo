using System.Security.Cryptography;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object we collided with has the tag "Plane"
        if (other.CompareTag("Cube"))
        {
            // Destroy the game object this script is attached to
            Debug.Log("Triggered with: " + other.gameObject.name);
            Destroy(other.gameObject);
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource != null)
            {
                AudioClip destroyEffect = audioSource.clip; // Assuming the AudioSource has a clip assigned
                if (destroyEffect != null)
                {
                    audioSource.PlayOneShot(destroyEffect);
                }
                else
                {
                    Debug.LogWarning("Destroy effect audio clip not found.");
                }
            }
            else
            {
                Debug.LogWarning("AudioSource component not found on the object.");
            }
        }
        else
        {
            Debug.Log("Triggered with an object that is not the Cube: " + other.gameObject.name);
        }
    }
}