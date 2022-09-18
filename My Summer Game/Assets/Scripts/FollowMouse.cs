using UnityEngine;

public class FollowMouse : MonoBehaviour
{
	private void Update()
	{
		Vector3 position = new Vector3(z: Camera.main.WorldToScreenPoint(base.transform.position).z, x: Input.mousePosition.x, y: Input.mousePosition.y);
		base.transform.position = Camera.main.ScreenToWorldPoint(position);
	}
}