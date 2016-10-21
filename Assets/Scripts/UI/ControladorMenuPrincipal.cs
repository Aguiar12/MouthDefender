using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEngine.SceneManagement;

//Classe responsável por gerenciar todo o Menu Principal
public class ControladorMenuPrincipal : MonoBehaviour {

    // Botão Start // Ao clicar no botão ele carrega a cena "LevelSelect"
    private string level = "LevelSelect";
    private int language;
    private bool sfxSound;
    private bool musicSound;

    public void Botao_start() {

        SceneManager.LoadScene(level);
    
    }

    // Botão de configurações // Ao clicar ele se expande(Dropdown) e habilita os botões de SOM,SFX e Idioma.
    public void Botao_Config() {

        GameObject.Find("Config").GetComponent<DropDownMenu1>().Verifica();
    
    }

    // Botão de configurações // Ao clicar ele se expande(Dropdown) e habilita os botões de Conquistas e Ranking.
    public void Botao_Online() {

        GameObject.Find("Online Service").GetComponent<DropDownMenu2>().Verifica();
    
    }

    // Função que altera os sprites, conforme a língua selecionada pelo usuário
    private void changeLanguageSprite(){

        if(language == 0){
            GameObject.Find("Idioma").GetComponent<UnityEngine.UI.Image>().sprite = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Ui/MenuPrincipal/botao_lingua_ptbr_md.png", typeof(Sprite));
            GameObject.Find("Loja").GetComponent<UnityEngine.UI.Image>().sprite = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Ui/MenuPrincipal/botao_loja_ptbr_md.png", typeof(Sprite));
            GameObject.Find("Start").GetComponent<UnityEngine.UI.Image>().sprite = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Ui/MenuPrincipal/botao_play_ptbr_md.png", typeof(Sprite));
        }
        else if(language == 1){
            GameObject.Find("Idioma").GetComponent<UnityEngine.UI.Image>().sprite = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Ui/MenuPrincipal/botao_lingua_en_md.png", typeof(Sprite));
            GameObject.Find("Loja").GetComponent<UnityEngine.UI.Image>().sprite = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Ui/MenuPrincipal/botao_loja_en_md.png", typeof(Sprite));
            GameObject.Find("Start").GetComponent<UnityEngine.UI.Image>().sprite = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Ui/MenuPrincipal/botao_play_en_md.png", typeof(Sprite));
        }

    }

    //Botão de mutar a música do jogo // Ao clicar a música do jogo deve ser desabilitado e o sprite alterado
    public void botao_MuteMusic(){

        if(musicSound){
            musicSound = false;
            GameObject.Find("Mute - Music").GetComponent<UnityEngine.UI.Image>().sprite = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Ui/MenuPrincipal/botao_musica_wx.png", typeof(Sprite));
        }
        else if(!musicSound){
            musicSound = true;
            GameObject.Find("Mute - Music").GetComponent<UnityEngine.UI.Image>().sprite = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Ui/MenuPrincipal/botao_musica_md.png", typeof(Sprite));
        }   

    }

    //Botão de mutar o som do jogo // Ao clicar o som do jogo deve ser desabilitado e o sprite alterado
    public void botao_MuteSFX(){

        if(sfxSound){
            sfxSound = false;
            GameObject.Find("Mute - SFX").GetComponent<UnityEngine.UI.Image>().sprite = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Ui/MenuPrincipal/botao_sfx_wx.png", typeof(Sprite));
        }
        else if(!sfxSound){
            sfxSound = true;
            GameObject.Find("Mute - SFX").GetComponent<UnityEngine.UI.Image>().sprite = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Ui/MenuPrincipal/botao_sfx_md.png", typeof(Sprite));
        }   

    }

    //Botão de Idiomas // Ao clicar ele altera os sprites para o idioma que o usuário desejar
    public void botao_Idioma(){

        if(language == 0){
            language = 1;
        }
        else if(language == 1){
            language = 0;
        }

    }

    //Function that is runned when the scene is started
    void Start(){

        language = 0;
        sfxSound = true;
        musicSound = true;
    
    }

    //Function that makes the update
    void Update(){

        changeLanguageSprite();

    }

}

