using UnityEngine;

public class FakeScan : MonoBehaviour
{
    public Transform circle;
    public GameObject[] targets;

    public float maxScale = 10f;
    public float duration = 1f;

    private bool isPlaying = false;
    private float t = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && !isPlaying)
        {
            isPlaying = true;
            t = 0f;

            if (circle != null)
                circle.localScale = Vector3.zero;
        }

        if (isPlaying)
        {
            t += Time.deltaTime;

            float progress = t / duration;
            circle.localScale = Vector3.one * Mathf.Lerp(0, maxScale, progress);

            if (t >= duration)
            {
                isPlaying = false;


                foreach (var obj in targets)
                {
                    obj.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
                    obj.GetComponent<Renderer>().material.color = Color.cyan;
                }
            }
        }
    }
}
