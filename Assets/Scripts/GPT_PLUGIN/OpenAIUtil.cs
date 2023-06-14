// using System.Collections.Generic;
// using Unity.VisualScripting;
// using UnityEngine;
// using UnityEngine.Networking;
//
// namespace GPT_PLUGIN
// {
//     public static class OpenAIUtil
//     {
//         private static List<IMultipartFormSection> CreateChatRepuestBody(string prompt)
//         {
//             var msg = new OpenAI.RequestMessage();
//             msg.role = "user";
//             msg.content = prompt;
//
//             var req = new OpenAI.Request();
//             req.model = "gpt-3.5-turbo";
//             req.messages = new[] { msg };
//
//             var formData = new List<IMultipartFormSection>();
//             formData.Add(new MultipartFormDataSection(JsonUtility.ToJson(req)));
//             return formData;
//         }
//         public static string InvokeChat(string prompt)
// {
//     var settings = AICommandsettings.instance;
//
//     if (settings == null)
//     {
//         Debug.LogError("AICommandSettings is missing. Make sure to create an AICommandSettings asset.");
//         return string.Empty;
//     }
//
//     var timeout = Mathf.RoundToInt(settings.Timeout);
//     var apiKey = settings.ApiKey;
//
//     if (string.IsNullOrEmpty(apiKey))
//     {
//         Debug.LogError("API key is missing. Please provide the OpenAI API key in AICommandSettings.");
//         return string.Empty;
//     }
//
//     // Create request body
//     var requestBody = CreateChatRequestBody(prompt);
//
//     // Create UnityWebRequest POST
//     var request = new UnityWebRequest(OpenAI.Api.Url, UnityWebRequest.kHttpVerbPOST);
//     request.timeout = timeout;
//
//     // Set request headers
//     request.SetRequestHeader("Content-Type", "application/json");
//     request.SetRequestHeader("Authorization", "Bearer " + apiKey);
//
//     // Set request body
//     byte[] bodyRaw = Encoding.UTF8.GetBytes(requestBody);
//     request.uploadHandler = new UploadHandlerRaw(bodyRaw);
//
//     // Send request and wait until it completes
//     var operation = request.SendWebRequest();
//     while (!operation.isDone)
//     {
//         // You can add your own progress indicator here if needed
//     }
//
//     // Check for errors
//     if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
//     {
//         Debug.LogError("OpenAI request failed: " + request.error);
//         return string.Empty;
//     }
//
//     // Get response text
//     var responseText = request.downloadHandler.text;
//
//     // Extract response data
//     var responseData = JsonUtility.FromJson<OpenAI.Response>(responseText);
//
//     if (responseData.choices != null && responseData.choices.Length > 0)
//     {
//         var answer = responseData.choices[0].message.content;
//         return answer;
//     }
//     else
//     {
//         Debug.LogWarning("No response from OpenAI. Please check your API key and try again.");
//         return string.Empty;
//     }
// }
//
//     }
// }