using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TitleDisplay : MonoBehaviour {

	public Title title;
	[SerializeField] TextMeshProUGUI titleText;
	[SerializeField] TextMeshProUGUI dateText;
	[SerializeField] TextMeshProUGUI timeText;
	public Image background;



	// Use this for initialization
	void Start () {
		titleText.text = title.title;
		dateText.text = title.date;
		timeText.text = title.time;
		background.sprite = title.background;
    }

	// Use this for initialization
	void Update()
	{
		titleText.text = title.title;
		dateText.text = title.date;
		timeText.text = title.time;
		background.sprite = title.background;
	}

}
