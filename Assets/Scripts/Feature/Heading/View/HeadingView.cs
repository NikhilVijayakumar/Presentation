using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Presentation.Heading.Model;

namespace Presentation.Heading.View
{
	public class HeadingView : MonoBehaviour
	{

		public HeadingModel heading;

		[SerializeField] TextMeshProUGUI indexNumberText;
		[SerializeField] TextMeshProUGUI headingText;



		// Use this for initialization
		void Start()
		{
			indexNumberText.text = heading.indexNumber;
			headingText.text = heading.heading;
		}

		void Update()
		{
			indexNumberText.text = heading.indexNumber;
			headingText.text = heading.heading;
		}

	}
}


