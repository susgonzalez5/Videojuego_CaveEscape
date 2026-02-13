using UnityEngine;
using UnityEngine.UIElements;

public class Credits : MonoBehaviour
{

  [SerializeField]
  GameObject mainPage;

    void OnEnable()
    {
        Button volverMenuButton = GetComponent<UIDocument>().rootVisualElement.Q("BackButton") as Button;
        volverMenuButton.clicked += QuitarPage;
    }

    void QuitarPage()
    { 
       gameObject.SetActive(false); 
       mainPage.SetActive(true); 
    }

}