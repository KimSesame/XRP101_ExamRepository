using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupController : MonoBehaviour
{
    [SerializeField] private float _deactiveTime;
    private Button _popupButton;

    [SerializeField] private GameObject _popup;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _popupButton = GetComponent<Button>();
        SubscribeEvent();
    }

    private void SubscribeEvent()
    {
        _popupButton.onClick.AddListener(Activate);
    }

    private void Activate()
    {
        _popup.gameObject.SetActive(true);
        GameManager.Instance.Pause();
        StartCoroutine(DeactivateRoutine());
    }

    private void Deactivate()
    {
        GameManager.Instance.Resume();
        _popup.gameObject.SetActive(false);
    }

    private IEnumerator DeactivateRoutine()
    {
        float elapsedTime = 0f;

        while (elapsedTime < _deactiveTime)
        {
            elapsedTime += Time.unscaledDeltaTime;
            yield return null;
        }

        Deactivate();
    }
}
