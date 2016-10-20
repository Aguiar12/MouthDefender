using UnityEngine;
using System.Collections;
//Classe responsável por expandir o Botão de Configurações Habilitando SOM,SFX e Idioma.
public class DropDownMenu1 : MonoBehaviour {

    public RectTransform container;
    private bool IsOpen;
    void Start () {

        container = transform.FindChild("Container").GetComponent<RectTransform>();
        IsOpen = false;
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 scale = container.localScale;
        scale.y = Mathf.Lerp(scale.y, (IsOpen == true) ? 1 : 0, Time.deltaTime * 12);
        container.localScale = scale;
	}
    //Metodo que verifica se o Botão(Configurações) está aberto quando clicado, se sim ele o fecha, senão ele o abre.
    public void Verifica()
    {
        if (IsOpen == true)
        {
            IsOpen = false;
        }
        else IsOpen = true;
    }
}
