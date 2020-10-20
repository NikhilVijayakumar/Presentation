using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Presentation.Content.Model
{
	[CreateAssetMenu(fileName = "Content Slide", menuName = "Slide/Content")]
	public class ContentModel : ScriptableObject
	{

		public Sprite background;
		public string[] data;
		public float typeSpeed;
		public float sentenceDelay;

	}
}

