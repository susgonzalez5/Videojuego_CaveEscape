using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject mainPage;

    [SerializeField]
    GameObject creditsPage;

    [SerializeField]
    GameObject loadingPage;

    [SerializeField]
    Texture2D backgroundImage;

    [SerializeField]
    Texture2D tituloImage;

    
    [SerializeField]
    Texture2D logoImage;

     [SerializeField]
    Texture2D logoImageBlanco;

     [SerializeField]
    Texture2D tituloImageBlanco;
    
    public float incrementotamano = 2;
    public float tamanofuente;

    void OnEnable()
    {
        Button playButton = GetComponent<UIDocument>().rootVisualElement.Q("PlayButton") as Button;
        playButton.clicked += StartGame;
        
        Button creditsButton = GetComponent<UIDocument>().rootVisualElement.Q("CreditsButton") as Button;
        creditsButton.clicked += CreditsPage;
       
        Button accessibilityButton = GetComponent<UIDocument>().rootVisualElement.Q("AccessibilityButton") as Button;
        accessibilityButton.clicked += AccessibilityOptions;
        
        Button exitButton = GetComponent<UIDocument>().rootVisualElement.Q("ExitButton") as Button;
        exitButton.clicked += QuitGame;  
        
        Button cerrarMenuButton = GetComponent<UIDocument>().rootVisualElement.Q("CerrarButton") as Button;
        cerrarMenuButton.clicked += CerrarAccesibilidad;
 
        Toggle toggle = GetComponent<UIDocument>().rootVisualElement.Q("CambiarContraste") as Toggle;
        toggle.RegisterValueChangedCallback(ChangeContrast);
        
        Button reducirtamanofuente = GetComponent<UIDocument>().rootVisualElement.Q("ReducirTamanoFuente") as Button;
        reducirtamanofuente.clicked += ReducirTamanoFuente;  
        
        Button aumentartamanofuente = GetComponent<UIDocument>().rootVisualElement.Q("AumentarTamanoFuente") as Button;
        aumentartamanofuente.clicked += AumentarTamanoFuente;  
    }

    void StartGame()
    {
      gameObject.SetActive(false);
      loadingPage.SetActive(true);
    }

  void CreditsPage()
    {
       mainPage.SetActive(false);
       creditsPage.SetActive(true);
    }

  void AccessibilityOptions()
    {
      VisualElement abrirAccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("Accesibilidad");
      abrirAccesibilidad.visible = true;
    }
  void QuitGame()
    {
       Application.Quit();
    }

  void CerrarAccesibilidad()
    { 
      VisualElement cerrarAccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("Accesibilidad");
      cerrarAccesibilidad.visible = false;
    }

    void ChangeContrast(ChangeEvent<bool> evt)
    { 
        if (evt.newValue)
        {
            VisualElement background = GetComponent<UIDocument>().rootVisualElement.Q("Background");
            background.style.backgroundImage = null;
            background.style.backgroundColor = Color.black;
            
            VisualElement titulo = GetComponent<UIDocument>().rootVisualElement.Q("Cabecera");
            titulo.style.backgroundImage = new StyleBackground(tituloImageBlanco);

            VisualElement logo = GetComponent<UIDocument>().rootVisualElement.Q("Logo");
            logo.style.backgroundImage = new StyleBackground(logoImageBlanco);
            
            VisualElement botonjugar = GetComponent<UIDocument>().rootVisualElement.Q("PlayButton");
            botonjugar.style.color = Color.black;
            botonjugar.style.backgroundColor = Color.white;
           
            VisualElement botonopciones = GetComponent<UIDocument>().rootVisualElement.Q("OptionButton");
            botonopciones.style.color = Color.black;
            botonopciones.style.backgroundColor = Color.white;
           
            VisualElement botoncreditos = GetComponent<UIDocument>().rootVisualElement.Q("CreditsButton");
            botoncreditos.style.color = Color.black;
            botoncreditos.style.backgroundColor = Color.white;
           
            VisualElement botonaccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("AccessibilityButton");
            botonaccesibilidad.style.color = Color.black;
            botonaccesibilidad.style.backgroundColor = Color.white;
            
            VisualElement botonsalir = GetComponent<UIDocument>().rootVisualElement.Q("ExitButton");
            botonsalir.style.color = Color.black;
            botonsalir.style.backgroundColor = Color.white;
            
            VisualElement cuadroaccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("Accesibilidad");
            cuadroaccesibilidad.style.backgroundColor = Color.white;
            
            VisualElement tituloaccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("Titulo");
            tituloaccesibilidad.style.color = Color.black;
           
            VisualElement recuadro = GetComponent<UIDocument>().rootVisualElement.Q("Recuadro");
            recuadro.style.backgroundColor = Color.black;
            
            VisualElement cambiarcontraste = GetComponent<UIDocument>().rootVisualElement.Q("CambiarContraste");
            cambiarcontraste.style.color = Color.white;
            
            VisualElement cambiartamano = GetComponent<UIDocument>().rootVisualElement.Q("TamanoFuenteTexto");
            cambiartamano.style.color = Color.white;
            
            VisualElement cerraraccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("CerrarButton");
            cerraraccesibilidad.style.color = Color.black;

        } 
        else   
        {
            VisualElement background = GetComponent<UIDocument>().rootVisualElement.Q("Background");
            background.style.backgroundImage = new StyleBackground(backgroundImage);
           
            VisualElement titulo = GetComponent<UIDocument>().rootVisualElement.Q("Cabecera");
            titulo.style.backgroundImage = new StyleBackground(tituloImage);
            
            VisualElement logo = GetComponent<UIDocument>().rootVisualElement.Q("Logo");
            logo.style.backgroundImage = new StyleBackground(logoImage);
            
            VisualElement botonjugar = GetComponent<UIDocument>().rootVisualElement.Q("PlayButton");
            botonjugar.style.color = new Color(0.84765625f, 0.66796875f, 0.24609375f, 1f);
            botonjugar.style.backgroundColor = new Color(0.33203125f, 0.27734375f, 0.34765625f, 1f);
           
            VisualElement botonopciones = GetComponent<UIDocument>().rootVisualElement.Q("OptionButton");
            botonopciones.style.color = new Color(0.84765625f, 0.66796875f, 0.24609375f, 1f);
            botonopciones.style.backgroundColor = new Color(0.33203125f, 0.27734375f, 0.34765625f, 1f);
           
            VisualElement botoncreditos = GetComponent<UIDocument>().rootVisualElement.Q("CreditsButton");
            botoncreditos.style.color = new Color(0.84765625f, 0.66796875f, 0.24609375f, 1f);
            botoncreditos.style.backgroundColor = new Color(0.33203125f, 0.27734375f, 0.34765625f, 1f);
            
            VisualElement botonaccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("AccessibilityButton");
            botonaccesibilidad.style.color = new Color(0.84765625f, 0.66796875f, 0.24609375f, 1f);
            botonaccesibilidad.style.backgroundColor = new Color(0.33203125f, 0.27734375f, 0.34765625f, 1f);
           
            VisualElement botonsalir = GetComponent<UIDocument>().rootVisualElement.Q("ExitButton");
            botonsalir.style.color = new Color(0.84765625f, 0.66796875f, 0.24609375f, 1f);
            botonsalir.style.backgroundColor = new Color(0.33203125f, 0.27734375f, 0.34765625f, 1f);
           
            VisualElement cuadroaccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("Accesibilidad");
            cuadroaccesibilidad.style.backgroundColor = new Color(0.33203125f, 0.27734375f, 0.34765625f, 1f);
            
            VisualElement tituloaccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("Titulo");
            tituloaccesibilidad.style.color = new Color(0.84765625f, 0.66796875f, 0.24609375f, 1f);
            
            VisualElement recuadro = GetComponent<UIDocument>().rootVisualElement.Q("Recuadro");
            recuadro.style.backgroundColor = new Color(0.40625f, 0.34375f, 0.375f, 1f);
            
            VisualElement cambiarcontraste = GetComponent<UIDocument>().rootVisualElement.Q("CambiarContraste");
            cambiarcontraste.style.color = new Color(0.84765625f, 0.66796875f, 0.24609375f, 1f);
           
            VisualElement cambiartamano = GetComponent<UIDocument>().rootVisualElement.Q("TamanoFuenteTexto");
            cambiartamano.style.color = new Color(0.84765625f, 0.66796875f, 0.24609375f, 1f);
            
            VisualElement cerraraccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("CerrarButton");
            cerraraccesibilidad.style.color = new Color(0.84765625f, 0.66796875f, 0.24609375f, 1f);
           
            VisualElement fondoaccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("Accesibilidad");
            fondoaccesibilidad.style.backgroundColor = new Color(0.33203125f, 0.27734375f, 0.34765625f, 1f);
            
        } 
    }
        void ReducirTamanoFuente()
        { 

          VisualElement tituloaccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("Titulo");
          Debug.Log(tituloaccesibilidad.resolvedStyle.fontSize);
          tamanofuente = tituloaccesibilidad.resolvedStyle.fontSize;
          if (tamanofuente > 50)
          { 
            tamanofuente = tamanofuente - incrementotamano;
            tituloaccesibilidad.style.fontSize = tamanofuente;
          } 

         
          VisualElement cerraraccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("CerrarButton");
          tamanofuente = cerraraccesibilidad.resolvedStyle.fontSize;
          if (tamanofuente > 40)
          { 
            tamanofuente = tamanofuente - incrementotamano;
            cerraraccesibilidad.style.fontSize = tamanofuente;
          }   
          
           
          VisualElement cambiarcontraste = GetComponent<UIDocument>().rootVisualElement.Q("CambiarContraste");
          tamanofuente = cambiarcontraste.resolvedStyle.fontSize;
          if (tamanofuente > 40)
          {
            tamanofuente = tamanofuente - incrementotamano;
            cambiarcontraste.style.fontSize = tamanofuente;
          } 

          VisualElement tamanofuentetexto = GetComponent<UIDocument>().rootVisualElement.Q("TamanoFuenteTexto");
          tamanofuente = tamanofuentetexto.resolvedStyle.fontSize;
          if (tamanofuente > 40)
          { 
            tamanofuente = tamanofuente - incrementotamano;
            tamanofuentetexto.style.fontSize = tamanofuente;
          } 

          VisualElement botonjugar = GetComponent<UIDocument>().rootVisualElement.Q("PlayButton");
          tamanofuente = botonjugar.resolvedStyle.fontSize;
          if (tamanofuente > 40)
          { 
            tamanofuente = tamanofuente - incrementotamano;
            botonjugar.style.fontSize = tamanofuente;
          } 

          VisualElement botonopciones = GetComponent<UIDocument>().rootVisualElement.Q("OptionButton");
          tamanofuente = botonopciones.resolvedStyle.fontSize;
          if (tamanofuente > 40)
          { 
            tamanofuente = tamanofuente - incrementotamano;
            botonopciones.style.fontSize = tamanofuente;
          } 

          VisualElement botonaccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("AccessibilityButton");
          tamanofuente = botonaccesibilidad.resolvedStyle.fontSize;
          if (tamanofuente > 40)
          { 
            tamanofuente = tamanofuente - incrementotamano;
            botonaccesibilidad.style.fontSize = tamanofuente;
          } 

          VisualElement botoncreditos = GetComponent<UIDocument>().rootVisualElement.Q("CreditsButton");
          tamanofuente = botoncreditos.resolvedStyle.fontSize;
          if (tamanofuente > 40)
          { 
            tamanofuente = tamanofuente - incrementotamano;
            botoncreditos.style.fontSize = tamanofuente;
          } 

          VisualElement botonsalir = GetComponent<UIDocument>().rootVisualElement.Q("ExitButton");
          tamanofuente = botonsalir.resolvedStyle.fontSize;
          if (tamanofuente > 40)
          { 
            tamanofuente = tamanofuente - incrementotamano;
            botonsalir.style.fontSize = tamanofuente;
          } 

        }
    
    void AumentarTamanoFuente()
        { 
          
          VisualElement tituloaccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("Titulo");
          Debug.Log(tituloaccesibilidad.resolvedStyle.fontSize);
          tamanofuente = tituloaccesibilidad.resolvedStyle.fontSize;
          if (tamanofuente < 90)
          { 
            tamanofuente = tamanofuente + incrementotamano;
            tituloaccesibilidad.style.fontSize = tamanofuente;
          } 

         
          VisualElement cerraraccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("CerrarButton");
          tamanofuente = cerraraccesibilidad.resolvedStyle.fontSize;
          if (tamanofuente < 80)
          { 
            tamanofuente = tamanofuente + incrementotamano;
            cerraraccesibilidad.style.fontSize = tamanofuente;
          }   
          
           
          VisualElement cambiarcontraste = GetComponent<UIDocument>().rootVisualElement.Q("CambiarContraste");
          tamanofuente = cambiarcontraste.resolvedStyle.fontSize;
          if (tamanofuente < 80)
          {
            tamanofuente = tamanofuente + incrementotamano;
            cambiarcontraste.style.fontSize = tamanofuente;
          } 

          VisualElement tamanofuentetexto = GetComponent<UIDocument>().rootVisualElement.Q("TamanoFuenteTexto");
          tamanofuente = tamanofuentetexto.resolvedStyle.fontSize;
          if (tamanofuente < 80)
          { 
            tamanofuente = tamanofuente + incrementotamano;
            tamanofuentetexto.style.fontSize = tamanofuente;
          } 

          VisualElement botonjugar = GetComponent<UIDocument>().rootVisualElement.Q("PlayButton");
          tamanofuente = botonjugar.resolvedStyle.fontSize;
          if (tamanofuente < 80)
          { 
            tamanofuente = tamanofuente + incrementotamano;
            botonjugar.style.fontSize = tamanofuente;
          } 

          VisualElement botonopciones = GetComponent<UIDocument>().rootVisualElement.Q("OptionButton");
          tamanofuente = botonopciones.resolvedStyle.fontSize;
          if (tamanofuente < 80)
          { 
            tamanofuente = tamanofuente + incrementotamano;
            botonopciones.style.fontSize = tamanofuente;
          } 

          VisualElement botonaccesibilidad = GetComponent<UIDocument>().rootVisualElement.Q("AccessibilityButton");
          tamanofuente = botonaccesibilidad.resolvedStyle.fontSize;
          if (tamanofuente < 80)
          { 
            tamanofuente = tamanofuente + incrementotamano;
            botonaccesibilidad.style.fontSize = tamanofuente;
          } 

          VisualElement botoncreditos = GetComponent<UIDocument>().rootVisualElement.Q("CreditsButton");
          tamanofuente = botoncreditos.resolvedStyle.fontSize;
          if (tamanofuente < 80)
          { 
            tamanofuente = tamanofuente + incrementotamano;
            botoncreditos.style.fontSize = tamanofuente;
          } 

          VisualElement botonsalir = GetComponent<UIDocument>().rootVisualElement.Q("ExitButton");
          tamanofuente = botonsalir.resolvedStyle.fontSize;
          if (tamanofuente < 80)
          { 
            tamanofuente = tamanofuente + incrementotamano;
            botonsalir.style.fontSize = tamanofuente;
          } 
        }

    

}