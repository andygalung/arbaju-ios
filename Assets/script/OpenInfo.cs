using UnityEngine;

public class OpenInfo : MonoBehaviour
{
    public GameObject panelInfo;

    // tampilkan panel info
    public void ShowInfo()
    {
        panelInfo.SetActive(true);
    }

    // sembunyikan panel info
    public void HideInfo()
    {
        panelInfo.SetActive(false);
    }
}
