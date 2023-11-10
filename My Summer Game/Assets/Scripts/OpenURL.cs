 using UnityEngine;
 using System.Collections;
 
 public class OpenURL : MonoBehaviour
 {
     public string URL;
	 
	 public void Open()
     {
         Application.OpenURL(URL);
     }
 }