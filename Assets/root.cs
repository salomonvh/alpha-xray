using System;
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
      List<IMultipartFormSection> formData = new List<IMultipartFormSection>();

      string auth = api_key + ":";
      auth = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(auth));
      auth = "Basic " + auth;

      formData.Add( new MultipartFormDataSection("type=root_gadgets") );
      formData.Add( new MultipartFormDataSection("model_name=iPhone 6s 64GB LTE") );
	     
      UnityWebRequest www = UnityWebRequest.Post("https://sandbox.root.co.za/v1/insurance/quotes", formData);
      www.SetRequestHeader("AUTHORIZATION", auth);
      yield return www.SendWebRequest();
	     
      if(www.isNetworkError || www.isHttpError) {
          Debug.Log(www.error);
      }
      else {
          Debug.Log("Form upload complete!");
      }
			Debug.Log("Quote created");
			yield return true;
  }
}
