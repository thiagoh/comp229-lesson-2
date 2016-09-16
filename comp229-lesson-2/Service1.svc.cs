using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json;
using System.Collections;
using System.IO;

namespace comp229_lesson_2 {

  [ServiceContract]
  [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
  public class Service1 {

    [OperationContract, WebGet(UriTemplate = "/my-first-service", ResponseFormat = WebMessageFormat.Json)]
    public Stream DoWork() {

      var test = new Dictionary<string, object>();
      test.Add("firstName", "junio");
      test.Add("lastName", "souza");

      string json = JsonConvert.SerializeObject(test, Formatting.Indented);

      return getStream(json);
    }

    [OperationContract, WebGet(UriTemplate = "/my-service-test/{parameter}", ResponseFormat = WebMessageFormat.Json)]
    public Stream DoWork2(string parameter) {

      var test = new Dictionary<string, object>();
      test.Add("firstName", "junio");
      test.Add("lastName", "souza");

      string json = JsonConvert.SerializeObject(test, Formatting.Indented);

      return getStream(json);
    }

    private static Stream getStream(string json) {

      // this is not thread safe
      WebOperationContext.Current.OutgoingResponse.ContentType =
        "application/json; charset=utf-8";

      System.Diagnostics.Debug.WriteLine(json);

      return new MemoryStream(Encoding.UTF8.GetBytes(json));
    }

    // Add more operations here and mark them with [OperationContract]
  }
}
