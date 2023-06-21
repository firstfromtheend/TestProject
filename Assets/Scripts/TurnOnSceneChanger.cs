using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TurnOnSceneChanger : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Button _button;

    public void OnPointerClick(PointerEventData eventData)
    {
        _button.interactable = !_button.interactable;
    }
}
