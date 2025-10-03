using UnityEditor.SpeedTree.Importer;
using UnityEngine;

public class ShaderToggle : MonoBehaviour
{
    public Material lambert;
    public Material ambient;
    public Material specular;
    public Material eyes;

    bool lambertActive;
    bool ambientActive;
    bool specularActive;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.GetComponent<Renderer>().materials = new Material[] { eyes, lambert };
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            this.GetComponent<Renderer>().materials = new Material[] { eyes, ambient };
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            this.GetComponent<Renderer>().materials = new Material[] { eyes, specular };
        }
    }
}
