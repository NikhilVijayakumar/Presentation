using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Presentation.Title.Model
{
	[CreateAssetMenu(fileName = "Title Slide", menuName = "Slide/Title")]
	public class TitleModel : ScriptableObject
	{
		public string title;
		public string date;
		public string time;
		public Sprite background;

	}
}