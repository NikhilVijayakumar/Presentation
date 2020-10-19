using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Presentation.Title.Model;

namespace Presentation.Title.View
{
	public class TitleView : MonoBehaviour
	{

		public TitleModel title;
		[SerializeField] TextMeshProUGUI titleText;
		[SerializeField] TextMeshProUGUI dateText;
		[SerializeField] TextMeshProUGUI timeText;
		public Image background;



		// Use this for initialization
		void Start()
		{
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
}

