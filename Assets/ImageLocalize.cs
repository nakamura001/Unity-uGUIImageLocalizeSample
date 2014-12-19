using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Globalization;
using System;

public class ImageLocalize : MonoBehaviour {
	void Awake () {
		Image img = gameObject.GetComponent<Image>();
		if (img) {
			string language = Application.systemLanguage.ToString();
			string texturePath = "images/" + language + "/" + img.sprite.name;
			Texture2D tex = (Texture2D)Instantiate(Resources.Load(texturePath));
			RectTransform rt = gameObject.GetComponent<RectTransform>();
			Sprite sp = img.sprite;
			Sprite newSp = Sprite.Create(tex, sp.rect, rt.pivot, sp.pixelsPerUnit);
			img.sprite = newSp;
		}
	}
}
