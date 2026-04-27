using UnityEngine;

public class monsterGene : MonoBehaviour
{
    public Rigidbody[] objectsToDrop;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (Rigidbody rb in objectsToDrop)
        {
            rb.useGravity = false;

            Renderer r = rb.GetComponentInChildren<Renderer>();
            if (r != null)
                r.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (Rigidbody rb in objectsToDrop)
            {
                rb.useGravity = true;
                Renderer r = rb.GetComponentInChildren<Renderer>();
                if (r != null)
                    r.enabled = true;
            }
        }
    }
}
