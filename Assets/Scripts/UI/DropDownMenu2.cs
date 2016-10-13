using UnityEngine;
using System.Collections;
//Classe responsável por expandir o Botão de Serviços Online Habilitando Conquistas e Ranking.
public class DropDownMenu2 : MonoBehaviour {

    public RectTransform container;
    private bool IsOpen;
    void Start()
    {

        container = transform.FindChild("Container2").GetComponent<RectTransform>();
        IsOpen = false;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 scale = container.localScale;
        scale.x = Mathf.Lerp(scale.x, (IsOpen == true) ? 1 : 0, Time.deltaTime * 10);
        container.localScale = scale;
    }
    //Metodo que verifica se o Botão(Serviços Online) está aberto quando clicado, se sim ele o fecha, senão ele o abre.
    public void Verifica()
    {
        if (IsOpen == true)
        {
            IsOpen = false;
        }
        else IsOpen = true;
    }
}
