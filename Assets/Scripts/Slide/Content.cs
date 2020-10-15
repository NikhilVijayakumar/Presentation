using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Content Slide", menuName = "Slide/Content")]
public class Content : ScriptableObject {	
	
	public Sprite background;
	public string[] data;
	public float typeSpeed;
	public float sentenceDelay;

}
