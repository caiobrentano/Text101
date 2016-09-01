using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	private enum States {cell, cell_mirror, lock_0, lock_1, mirror, sheets_0, sheets_1};
	private States myState;
	
	void Start () {
		myState = States.cell;
	}
	

	void Update () {
		if (myState == States.cell) {
			state_cell ();
		} else if (myState == States.sheets_0) {
			state_sheets_0();
		} else if (myState == States.mirror) {
			state_mirror();
		}
	}

	void state_cell() {
		text.text = "You are in a prison.\n\n" +
					"Press S to view Sheets, M to view Mirror and L to view Lock";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			// Lock
		}
	}

	void state_sheets_0() {
		text.text = "Look at those dirty sheets!\n\n" +
			"Press R to Return to roaming your cell.";
		
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}

	void state_mirror() {
		text.text = "I'll try to check this Mirror!\n\n" +
			"Press T to Take the Mirror, R to Return to roaming your cell.";
		
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
}
