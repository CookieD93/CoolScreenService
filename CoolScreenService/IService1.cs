using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Script.Services;
using System.Web.UI;

namespace CoolScreenService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        // Opskrift service del
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate= "Opskrifter", ResponseFormat = WebMessageFormat.Json)]
        void CreateOpskrift(OpskriftClass opskriftClass);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Opskrifter", ResponseFormat = WebMessageFormat.Json)]
        IList<OpskriftClass> GetOpskrifterDB();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Opskrifter/{id}", ResponseFormat = WebMessageFormat.Json)]
        OpskriftClass ReadOpskrift(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Opskrifter", ResponseFormat = WebMessageFormat.Json)]
        void UpdateOpskrift(OpskriftClass opskriftClass);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Opskrifter/{id}", ResponseFormat = WebMessageFormat.Json)]
        void DeleteOpskrift(string id);

        //Temperatur service del

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Temperatur", ResponseFormat = WebMessageFormat.Json)]
        void PostTemperatur(TemperaturClass temperaturClass);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Temperatur", ResponseFormat = WebMessageFormat.Json)]
        TemperaturClass ReadTemperatur();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Temperatur/Average", ResponseFormat = WebMessageFormat.Json)]
        double GetAvgTemperatur();




        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
