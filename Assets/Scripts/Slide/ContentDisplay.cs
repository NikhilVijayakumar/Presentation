using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContentDisplay : MonoBehaviour {

	public Content content;

	[SerializeField] TextMeshProUGUI contentText;
	public Image background;
	


	void Start()
	{

		background.sprite = content.background;
		StartCoroutine(Type());
	}



	IEnumerator Type()
    {		
		for(int i=0;i< content.data.Length; i++)
        {
			contentText.text = "";
			foreach (char letter in content.data[i].ToCharArray())
			{
				contentText.text += letter;
				yield return new WaitForSeconds(content.typeSpeed);

			}
			yield return new WaitForSeconds(content.sentenceDelay);
		}
		
    }

	


	
}
