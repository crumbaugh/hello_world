using UnityEngine;
using System.Collections;

public class Print : MonoBehaviour {
	public void printString(string toPrint, float x, float y, float len, float kerning, bool forward){
		float xoffset = 0;
		float yoffset = 0;
		if (forward) {
			for (int i = 0; i < toPrint.Length; i++) {
				Instantiate(Resources.Load(toPrint[i]), new Vector3(x + xoffset, y + yoffset, 0), Quaternion.identity);
				xoffset += .05 + kerning;
				if (xoffset > len) {
					yoffset += .1;
					xoffset = 0;
				}
			}
		} else {
			for (int i = toPrint.Length - 1; i >= 0; i++) {
				Instantiate(Resources.Load(toPrint[i]), new Vector3(x - xoffset, y - yoffset, 0), Quaternion.identity);
				xoffset += .05 + kerning;
				if (xoffset > len) {
					yoffset += .1;
					xoffset = 0;
				}
			}
		}
	
}
