using UnityEngine;
using System.Collections;

public class ColorSwapSliders : MonoBehaviour {

	public GameObject sprite1;
	public GameObject sprite2;

	public Material spriteMat1;
	public Material spriteMat2;

	Color s1c1;
	Color s1c2;
	Color s1c3;

	Color s2c1;
	Color s2c2;
	Color s2c3;

	// Use this for initialization
	void Start () {
		Renderer r = null;

		if (sprite1)
			r = sprite1.GetComponent<Renderer> ();
		if (r)
			spriteMat1 = r.material;

		if (sprite2)
			r = sprite2.GetComponent<Renderer> ();
		if (r)
			spriteMat2 = r.material;

		if (spriteMat1 && spriteMat2)
		{
			s1c1 = spriteMat1.GetColor ("_Channel1");
			s1c2 = spriteMat1.GetColor ("_Channel2");
			s1c3 = spriteMat1.GetColor ("_Channel3");

			s2c1 = spriteMat2.GetColor ("_Channel1");
			s2c2 = spriteMat2.GetColor ("_Channel2");
			s2c3 = spriteMat2.GetColor ("_Channel3");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!spriteMat1 || !spriteMat2)
		{
			return;
		}
		
		spriteMat1.SetColor ("_Channel1", s1c1);
		spriteMat1.SetColor ("_Channel2", s1c2);
		spriteMat1.SetColor ("_Channel3", s1c3);

		spriteMat2.SetColor ("_Channel1", s2c1);
		spriteMat2.SetColor ("_Channel2", s2c2);
		spriteMat2.SetColor ("_Channel3", s2c3);
	
	}

	void OnGUI ()
	{
		if (!spriteMat1 || !spriteMat2)
		{
			return;
		}
		
		GUILayout.Label ("Sprite 1");
		GUI.color = s1c1;
		GUILayout.Label ("Primary Color");
		GUI.color = Color.red;
		s1c1.r = GUILayout.HorizontalSlider (s1c1.r,0,1);
		GUI.color = Color.green;
		s1c1.g = GUILayout.HorizontalSlider (s1c1.g,0,1);
		GUI.color = Color.blue;
		s1c1.b = GUILayout.HorizontalSlider (s1c1.b,0,1);

		GUI.color = s1c2;
		GUILayout.Label ("Secondary Color");
		GUI.color = Color.red;
		s1c2.r = GUILayout.HorizontalSlider (s1c2.r,0,1);
		GUI.color = Color.green;
		s1c2.g = GUILayout.HorizontalSlider (s1c2.g,0,1);
		GUI.color = Color.blue;
		s1c2.b = GUILayout.HorizontalSlider (s1c2.b,0,1);

		GUI.color = s1c3;
		GUILayout.Label ("Trim");
		GUI.color = Color.red;
		s1c3.r = GUILayout.HorizontalSlider (s1c3.r,0,1);
		GUI.color = Color.green;
		s1c3.g = GUILayout.HorizontalSlider (s1c3.g,0,1);
		GUI.color = Color.blue;
		s1c3.b = GUILayout.HorizontalSlider (s1c3.b,0,1);
		GUI.color = Color.white;

		GUILayout.Space(15);

		GUILayout.Label ("Sprite 2");
		GUI.color = s2c1;
		GUILayout.Label ("Primary Color");
		GUI.color = Color.red;
		s2c1.r = GUILayout.HorizontalSlider (s2c1.r,0,1);
		GUI.color = Color.green;
		s2c1.g = GUILayout.HorizontalSlider (s2c1.g,0,1);
		GUI.color = Color.blue;
		s2c1.b = GUILayout.HorizontalSlider (s2c1.b,0,1);

		GUI.color = s2c2;
		GUILayout.Label ("Secondary Color");
		GUI.color = Color.red;
		s2c2.r = GUILayout.HorizontalSlider (s2c2.r,0,1);
		GUI.color = Color.green;
		s2c2.g = GUILayout.HorizontalSlider (s2c2.g,0,1);
		GUI.color = Color.blue;
		s2c2.b = GUILayout.HorizontalSlider (s2c2.b,0,1);

		GUI.color = s2c3;
		GUILayout.Label ("Trim");
		GUI.color = Color.red;
		s2c3.r = GUILayout.HorizontalSlider (s2c3.r,0,1);
		GUI.color = Color.green;
		s2c3.g = GUILayout.HorizontalSlider (s2c3.g,0,1);
		GUI.color = Color.blue;
		s2c3.b = GUILayout.HorizontalSlider (s2c3.b,0,1);
		GUI.color = Color.white;
	}
}
