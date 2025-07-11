using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject mbox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        int numCube = GameObject.FindGameObjectsWithTag("Cube").Length;
        if (OVRInput.GetDown(OVRInput.Button.Two) && numCube < 10)
        {
            // Make sure 'hit' is defined and assigned, e.g., from a RaycastHit
            // Example: RaycastHit hit; Physics.Raycast(..., out hit);
            GameObject _box = Instantiate(mbox);
            AudioSource audioSource = GetComponent<AudioSource>();
            if (audioSource != null)
            {
                AudioClip createEffect = audioSource.clip; // Assuming the AudioSource has a clip assigned
                if (createEffect != null)
                {
                    audioSource.PlayOneShot(createEffect);
                }
                else
                {
                    Debug.LogWarning("Create effect audio clip not found.");
                }
            }
            else
            {
                Debug.LogWarning("AudioSource component not found on the object.");
            }
        }
        
    }
}
