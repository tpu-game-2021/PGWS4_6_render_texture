using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSwitcherBehaviourScript : MonoBehaviour
{
    [SerializeField] private Camera renderTextureCamera = default;
    [SerializeField] private RenderTexture texture1 = default;
    [SerializeField] private RenderTexture texture2 = default;
    [SerializeField] private Material sampleMaterial1 = null;
    [SerializeField] private Material sampleMaterial2 = null;
    [SerializeField] private Material sampleMaterial3 = null;
    bool idx = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        idx = !idx;

        RenderTexture read_texture;
        RenderTexture write_texture;
        if (idx)
        {
            read_texture = texture1;
            write_texture = texture2;
        }
        else
        {
            read_texture = texture2;
            write_texture = texture1;
        }

        // Write
        renderTextureCamera.targetTexture = write_texture;

        // Read
        if (sampleMaterial1) sampleMaterial1.SetTexture("Texture2D_RT", read_texture);
        if (sampleMaterial2) sampleMaterial2.SetTexture("Texture2D_RT", read_texture);
        if (sampleMaterial3) sampleMaterial3.SetTexture("Texture2D_RT", read_texture);
    }
}
