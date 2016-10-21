using UnityEngine;
using System.Collections;

public class DenteCima : MonoBehaviour {
	/*
	*	0 a 100%
	*/
	public float probabilidadeAtivarAnimacao = 2;
	public int tempoMastigada = 40;
	public float velocidadeMastigada = 0.02f;
	public int tempoBocejada = 40;
	public float velocidadeBocejada = 0.02f;
	private int cont;
	private bool mastigando;
	private bool bocejando;
	// private bool nomeando;

	// Use this for initialization
	void Start () {
		mastigando = false;
		bocejando = false;
		// nomeando = false;
		cont = 0;
	}
	// Update is called once per frame
	void Update () {
		if(mastigando){
			mastigar(tempoMastigada, velocidadeMastigada);
			return;
		}

		if(bocejando){
			bocejar(tempoBocejada, velocidadeBocejada);
			return;
		}

		// if(nomeando){
		// 	nome(40, 0.02f);
		// 	return;
		// }

		//2 e o numero de cases dentro do switch
		switch(Random.Range(0, (int)(2 / (probabilidadeAtivarAnimacao / 100)))){
			case 0:
				mastigando = true;
				break;
			case 1:
				bocejando = true;
				break;
			// case 2:
			// 	nomeando = true;
			// 	break;
		}
	}
	private void cima(float y){
		transform.Translate(new Vector3(0, y));
	}
	private void baixo(float y){
		transform.Translate(new Vector3(0, -y));
	}
	private void direita(float x){
		transform.Translate(new Vector3(x, 0));
	}
	private void esquerda(float x){
		transform.Translate(new Vector3(-x, 0));
	}
	private void mastigar(int tempo, float velocidade) {
		if(cont < 1 * tempo) {
			baixo(velocidade);
			direita(velocidade / 3);
		} else if (cont < 2 * tempo) {
			baixo(velocidade);
			esquerda(velocidade / 3);
		} else if (cont < 3 * tempo) {
			cima(velocidade);
			esquerda(velocidade / 3);
		} else if (cont < 4 * tempo) {
			cima(velocidade);
			direita(velocidade / 3);
		} else {
			cont = 0;
			mastigando = false;
			return;
		}
		cont++;
	}

	private void bocejar(int tempo, float velocidade) {
		if(cont < 2 * tempo) {
			cima(velocidade);
		} else if(cont < 4 * tempo) {
			//boca parada aberta
		} else if(cont < 6 * tempo) {
			baixo(velocidade);
		} else {
			cont = 0;
			bocejando = false;
			return;
		}
		cont++;
	}

	// private void nome(int tempo, float velocidade) {
	// 	if(cont < 2 * tempo) {
	// 		direita(velocidade);
	// 		baixo(velocidade / 3);
	// 	} else if(cont < 4 * tempo) {
	// 		esquerda(velocidade);
	// 		cima(velocidade / 3);
	// 	} else if(cont < 6 * tempo) {
	// 		esquerda(velocidade);
	// 		baixo(velocidade /3);
	// 	} else if(cont < 8 * tempo) {
	// 		direita(velocidade);
	// 		cima(velocidade / 3);
	// 	} else {
	// 		cont = 0;
	// 		nomeando = false;
	// 		return;
	// 	}
	// 	cont++;
	// }
}
