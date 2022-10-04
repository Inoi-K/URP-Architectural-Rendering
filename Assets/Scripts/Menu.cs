using UnityEngine;

public class Menu : MonoBehaviour {
    [Header("Camera")]
    [SerializeField] Camera[] cameras;

    [Header("TV")]
    [SerializeField] MeshRenderer tvMeshRenderer;
    [SerializeField] Material tvOn;
    [SerializeField] Material tvOff;

    bool isTVOn = true;
    
    public void ChangeCamera(int index) {
        foreach (Camera cam in cameras)
            cam.gameObject.SetActive(false);
        
        cameras[index].gameObject.SetActive(true);
    }
    
    public void SwitchTV() {
        tvMeshRenderer.materials = isTVOn ? new []{tvMeshRenderer.material, tvOff} : new []{tvMeshRenderer.material, tvOn};
        isTVOn = !isTVOn;
    }
}
