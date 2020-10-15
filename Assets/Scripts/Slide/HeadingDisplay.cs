using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeadingDisplay : MonoBehaviour {

	public Heading heading;

	[SerializeField] TextMeshProUGUI indexNumberText;
	[SerializeField] TextMeshProUGUI headingText;



	// Use this for initialization
	void Start () {
		indexNumberText.text = heading.indexNumber;
		headingText.text = heading.heading;       
    }
	
}
