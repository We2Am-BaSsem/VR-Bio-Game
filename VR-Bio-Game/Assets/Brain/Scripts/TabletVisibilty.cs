using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class TabletVisibilty : MonoBehaviour
{
    public Transform tablet;
    public GameObject ActivePoint;
    private bool isPicked = false;
    private bool visibility = false;

    public TextMeshProUGUI RespirationText;
    public TextMeshProUGUI DigestionText;
    public TextMeshProUGUI ImmuneText;
    public Image RespirationSlider;
    public Image DigestionSlider;
    public Image ImmuneSlider;
    void Update()
    {
        RespirationText.text = GameManager._gameManager.RespirationStatus.ToString();
        DigestionText.text = GameManager._gameManager.DigestionStatus.ToString();
        ImmuneText.text = GameManager._gameManager.ImmuneStatus.ToString();
        RespirationSlider.fillAmount = GameManager._gameManager.RespirationStatus / 100.0f;
        DigestionSlider.fillAmount = GameManager._gameManager.RespirationStatus / 100.0f;
        ImmuneSlider.fillAmount = GameManager._gameManager.RespirationStatus / 100.0f;

        if (Input.GetButtonDown("Fire1") || OVRInput.GetDown(OVRInput.RawButton.X))
        {
            tablet.position = ActivePoint.transform.position;
            tablet.GetComponent<TabletFloater>().posOffset = tablet.position;
            tablet.rotation = ActivePoint.transform.rotation;
            tablet.gameObject.SetActive(!visibility);
            visibility = !visibility;
        }
    }

    public void isGrabbed(bool val)
    {
        isPicked = false;
    }
}
