using Azure.Functions;
using Azure.AppServices;
using RESTClient;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {
  [Header("Azure Functions")]
  public string Account;
  public string FunctionName = "test";
  public string FunctionCode = "";
  private string route = "";

  [Header("Sample Values")]
  public string YourName = "Unity";

  [Header("Unity objects")]
  public TextMesh DisplayName;

  private AzureFunctionClient client;
  private AzureFunction service;

  // Use this for initialization
  void Start() {
    if (string.IsNullOrEmpty(Account)) {
      Debug.LogError("Azure Functions Account name required.");
      return;
    }

    if (DisplayName == null) {
      Debug.LogError("Expected TextMesh game object to be set.");
      return;
    }

    client = AzureFunctionClient.Create(Account);
    service = new AzureFunction(FunctionName, client, FunctionCode);
  }

  public void TappedGet() {
    QueryParams queryParams = new QueryParams();
    queryParams.AddParam("name", YourName);

    Debug.Log("GET: " + YourName + " url:" + service.ApiUrl());
    DisplayName.text = "GET";
    StartCoroutine(service.Get<string>(SayHelloCompleted, route, queryParams));
  }

  public void TappedPost() {
    QueryParams queryParams = new QueryParams();
    queryParams.AddParam("name", YourName);

    Debug.Log("POST: " + YourName + " url:" + service.ApiUrl());
    DisplayName.text = "POST";
    StartCoroutine(service.Post<string>(SayHelloCompleted, route, queryParams));
  }

  public void TappedPut() {
    QueryParams queryParams = new QueryParams();
    queryParams.AddParam("name", YourName);

    Debug.Log("PUT: " + YourName + " url:" + service.ApiUrl());
    DisplayName.text = "PUT";
    StartCoroutine(service.Put<string>(SayHelloCompleted, route, queryParams));
  }

  public void TappedDelete() {
    QueryParams queryParams = new QueryParams();
    queryParams.AddParam("name", YourName);

    Debug.Log("DELETE: " + YourName + " url:" + service.ApiUrl());
    DisplayName.text = "DELETE";
    StartCoroutine(service.Delete<string>(SayHelloCompleted, route, queryParams));
  }

  public void TappedPatch() {
    QueryParams queryParams = new QueryParams();
    queryParams.AddParam("name", YourName);

    Debug.Log("PATCH: " + YourName + " url:" + service.ApiUrl());
    DisplayName.text = "PATCH";
    StartCoroutine(service.Patch<string>(SayHelloCompleted, route, queryParams));
  }

  private void SayHelloCompleted(IRestResponse<string> response) {
    if (response.IsError) {
      Debug.LogError("Request error: " + response.StatusCode);
      return;
    }
    Debug.Log("Completed: " + response.Content);
    DisplayName.text = TrimQuotes(response.Content);
  }

  private string TrimQuotes(string message) {
    return message.TrimStart('"').TrimEnd('"');
  }

  // Update is called once per frame
  void Update() {

  }
}
