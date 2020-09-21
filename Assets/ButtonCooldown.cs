using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCooldown : MonoBehaviour
{
    [SerializeField]
    Button button;
    [SerializeField]
    float cooldownTime = 2f;

    private void Awake()
    {
        button = GetComponent<Button>();

        if (button != null) {
            button.onClick.AddListener(OnButtonClick);
        }
    }

    void OnButtonClick() {
        StartCoroutine(Cooldown());
    }

    IEnumerator Cooldown() {
        button.interactable = false;
        yield return new WaitForSeconds(cooldownTime);
        button.interactable = true;
    }
}
