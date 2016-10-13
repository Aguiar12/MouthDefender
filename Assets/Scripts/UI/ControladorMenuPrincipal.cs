using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//Classe responsável por gerenciar todo o Menu Principal
public class ControladorMenuPrincipal : MonoBehaviour {
    // Botão Start // Ao clicar no botão ele carrega a cena "LevelSelect"
    private string level = "LevelSelect";
    public void Botao_start()
    {
        SceneManager.LoadScene(level);
    }
    // Botão de configurações // Ao clicar ele se expande(Dropdown) e habilita os botões de SOM,SFX e Idioma.
    public void Botao_Config()
    {
        GameObject.Find("Config").GetComponent<DropDownMenu1>().Verifica();
    }
    // Botão de configurações // Ao clicar ele se expande(Dropdown) e habilita os botões de Conquistas e Ranking.
    public void Botao_Online()
    {
        GameObject.Find("Online Service").GetComponent<DropDownMenu2>().Verifica();
    }
}
