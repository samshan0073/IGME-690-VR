using UnityEngine;

public class sky : MonoBehaviour
{
    public Color startColor = Color.blue;
    public Color endColor = Color.red;

    public float speed = 0.2f;

    void Update()
    {
        float t = Mathf.PingPong(Time.time * speed, 1f);

        Color current = Color.Lerp(startColor, endColor, t);

        RenderSettings.skybox.SetColor("_SkyTint", current);
        DynamicGI.UpdateEnvironment();
    }
}
