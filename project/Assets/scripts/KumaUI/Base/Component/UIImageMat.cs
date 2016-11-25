using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;



[RequireComponent(typeof(Image))]
[AddComponentMenu("UI/Image Material")]
public class UIImageMat : MonoBehaviour
{
	private Image mImage;
	private Material mMat;
	public Color mColor = Color.white;

	void Start()
	{
		mImage = GetComponent<Image>();
		mImage.material = Instantiate(mImage.material) as Material;
	}

	void LateUpdate()
	{
		mImage.material.SetColor("_Color",mColor);
	}
}