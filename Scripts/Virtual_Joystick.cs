using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Virtual_Joystick : MonoBehaviour, IDragHandler , IPointerUpHandler , IPointerDownHandler {

	private Image Background_Image;
	private Image Joystick_Image;
	private Button Jump;
	private Vector3 InputVector;

	private void Start()
	{

		Background_Image = GetComponent<Image>();
		Joystick_Image = transform.GetChild (0).GetComponent<Image> ();

	}

	public virtual void OnDrag(PointerEventData PED)
	{

		Vector2 Position;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle (Background_Image.rectTransform, PED.position, PED.pressEventCamera, out Position)) 
		{

			Position.x = (Position.x / Background_Image.rectTransform.sizeDelta.x);
			Position.y = (Position.y / Background_Image.rectTransform.sizeDelta.y);
			InputVector = new Vector3 (Position.x * 2 + 1, 0, Position.y * 2 - 1);
			InputVector = (InputVector.magnitude > 1.0f) ? InputVector.normalized : InputVector;

			//Move Joystick Image

			Joystick_Image.rectTransform.anchoredPosition = new Vector3 (0,InputVector.z * (Background_Image.rectTransform.sizeDelta.y / 3), 0);


		}

	}

	public virtual void OnPointerUp(PointerEventData PED)
	{

		InputVector = Vector3.zero;
		Joystick_Image.rectTransform.anchoredPosition = Vector3.zero;

	}

	public virtual void OnPointerDown(PointerEventData PED)
	{

		OnDrag (PED);

	}

	public float Horizontal()
	{

		if (InputVector.x != 0)
			return InputVector.x;
		else
			return Input.GetAxis ("Horizontal");

	}

	public float Vertical()
	{

		if (-InputVector.z != 0)
			return InputVector.z;
		else
			return Input.GetAxis ("Vertical");

	}

}
