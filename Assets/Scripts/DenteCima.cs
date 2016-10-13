using UnityEngine;
using System.Collections;

public class DenteCima : MonoBehaviour {
	public int tempo = 35;
	public float velocidade = 0.012f;
	public int pausa = 0;
	private int aux = 0;
	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {

		if(aux < 1 * tempo) {
			baixo(velocidade);
			direita(velocidade);
			aux++;
		} else if (aux < 2 * tempo) {
			baixo(velocidade);
			esquerda(velocidade);
			aux++;
		} else if (aux < 3 * tempo) {
			cima(velocidade);
			esquerda(velocidade);
			aux++;
		} else if (aux < 4 * tempo) {
			cima(velocidade);
			direita(velocidade);
			aux++;
		} else if (aux < (4 + pausa) * tempo){
			aux++;
		} else {
			aux = 0;
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
}
