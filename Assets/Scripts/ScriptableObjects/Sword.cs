using UnityEngine;
using UnityEngine.Events;

public class Sword : MonoBehaviour
{
    [SerializeField] private UnityEvent onMouseDown;

    private void OnMouseDown()
    {
        onMouseDown.Invoke();
    }
}
