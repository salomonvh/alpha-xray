using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class root : MonoBehaviour {

	public string api_key = "";

	public void CreateQuote() {
      StartCoroutine(CreateQuoteCoroutine());
  }

  IEnumerator CreateQuoteCoroutine() {
      // List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
      // formData.Add( new MultipartFormDataSection("username=&password=''") );
			//
      // UnityWebRequest www = UnityWebRequest.Post("https://api.root.co.za/v1/insurance", formData);
      // yield return www.SendWebRequest();
			//
      // if(www.isNetworkError || www.isHttpError) {
      //     Debug.Log(www.error);
      // }
      // else {
      //     Debug.Log("Form upload complete!");
      // }
			Debug.Log("Quote created");
			yield return true;
  }
}
