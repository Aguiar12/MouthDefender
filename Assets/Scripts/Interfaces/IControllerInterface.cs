using UnityEngine;
using System.Collections;

public interface IControllerInterface {

   /*
	* Método para todos os tipos diferentes de controller devem implementar para 
	* realizar movimentação 
	*/
	float getWalkInput();

	bool verifyJumpInput();

	bool verifyAttkInput();

	bool verifyPowerUpInput();


}
