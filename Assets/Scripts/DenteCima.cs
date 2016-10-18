using UnityEngine;
using System.Collections;

public class DenteCima : MonoBehaviour {
	private int cont;
	private bool mastigando;
	private bool bocejando;

	// Use this for initialization
	void Start () {
		mastigando = false;
		bocejando = false;
		cont = 0;
	}
	// Update is called once per frame
	void Update () {
		if(!mastigando && !bocejando){
			int random = Random.Range(0, 200);
			if(random == 0){
				mastigando = true;
			} else if(random == 1){
				bocejando = true;
			}
		}

		if(mastigando){
			mastigar(40, 0.02f);
		}

		if(bocejando){
			bocejar(80, 0.01f);
		}
	}
	public void cima(float y){
		transform.Translate(new Vector3(0, y));
	}
	public void baixo(float y){
		transform.Translate(new Vector3(0, -y));
	}
	public void direita(float x){
		transform.Translate(new Vector3(x, 0));
	}
	public void esquerda(float x){
		transform.Translate(new Vector3(-x, 0));
	}
	private void mastigar(int tempo, float velocidade) {
		if(cont < 1 * tempo) {
			baixo(velocidade);
			direita(velocidade/3);
		} else if (cont < 2 * tempo) {
			baixo(velocidade);
			esquerda(velocidade/3);
		} else if (cont < 3 * tempo) {
			cima(velocidade);
			esquerda(velocidade/3);
		} else if (cont < 4 * tempo) {
			cima(velocidade);
			direita(velocidade/3);
		} else {
			cont = 0;
			mastigando = false;
		}
		cont++;
	}

	private void bocejar(int tempo, float velocidade) {
		if(cont < 2 * tempo) {
			cima(velocidade);
		} else if(cont < 4 * tempo) {
			
		} else if(cont < 6 * tempo) {
			baixo(velocidade);
		} else {
			cont = 0;
			bocejando = false;
		}
		cont++;
	}
}
