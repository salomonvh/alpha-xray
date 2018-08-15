using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class root : MonoBehaviour
{

    /* Create a Root Object to store the returned json data in */
    [System.Serializable]
    public class Quotes
    {
        public Quote[] values;
    }

    [System.Serializable]
    public class Quote
    {
        public string package_name;
        public string sum_assured;
        public int base_premium;
        public string suggested_premium;
        public string created_at;
        public string quote_package_id;
        public QuoteModule module;
    }

    [System.Serializable]
    public class QuoteModule
    {
        public string type;
        public string make;
        public string model;
    }

    [Serializable]
    public struct Param
    {
        public string key;
        public string value;
    }

    public string api_key = "";

    public void CallApi()
    {
        StartCoroutine(CreateQuoteCoroutine("iPhone 6S 64GB LTE"));
    }

	private void Start()
	{
        CallApi();
	}

    IEnumerator CreateQuoteCoroutine(String modelNr)
    {

        string auth = api_key + ":";
        auth = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(auth));
        auth = "Basic " + auth;

        WWWForm form = new WWWForm();
        form.AddField("type", "root_gadgets");
        form.AddField("model_name", modelNr);

        UnityWebRequest www = UnityWebRequest.Post("https://sandbox.root.co.za/v1/insurance/quotes", form);
        www.SetRequestHeader("AUTHORIZATION", auth);
        yield return www.Send();

        if (www.isNetworkError || www.isHttpError)
        {
           Debug.Log(www.downloadHandler.text);
        }
        else
        {
            Quotes json = JsonUtility.FromJson<Quotes>("{\"values\":" + www.downloadHandler.text + "}");

            String text = "Make: " + json.values[0].module.make + "\nPremium: R" + (json.values[0].base_premium / 100);
            Debug.Log(modelNr + ": " + json.values[0].module.make);
            Debug.Log(text);
            Debug.Log("Form upload complete!");
        }
        yield return true;
    }
}
