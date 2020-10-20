using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Presentation.Heading.Model
{
	[CreateAssetMenu(fileName = "Heading Slide", menuName = "Slide/Heading")]
	public class HeadingModel : ScriptableObject
	{
		public string indexNumber;
		public string heading;
	}
}


