using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Presentation.Content.Model;

namespace Presentation.Content.View
{
	public class ContentView : MonoBehaviour
	{

		public delegate void ContentCompleted();
		public ContentCompleted completed;

		public ContentModel content;


		[SerializeField] TextMeshProUGUI contentText;
		public Image background;
		bool isEnded;


		void Start()
		{

			background.sprite = content.background;
			StartCoroutine(Type());
		}

		void Update()
		{
			background.sprite = content.background;
			if (isEnded)
			{

				StartCoroutine(Type());
			}
		}



		IEnumerator Type()
		{
			isEnded = false;
			for (int i = 0; i < content.data.Length; i++)
			{
				contentText.text = "";
				foreach (char letter in content.data[i].ToCharArray())
				{
					contentText.text += letter;
					yield return new WaitForSeconds(content.typeSpeed);

				}
				yield return new WaitForSeconds(content.sentenceDelay);
			}
			isEnded = true;
			completed();
		}



	}
	
}
