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
        [WebInvoke(Method = "POST", UriTemplate= "Opskrifter", RequestFormat = WebMessageFormat.Json)]
        void CreateOpskrift(OpskriftClass opskriftClass);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Opskrifter", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IList<OpskriftClass> GetOpskrifterDB();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Opskrifter/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        OpskriftClass ReadOpskrift(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Opskrifter", RequestFormat = WebMessageFormat.Json)]
        void UpdateOpskrift(OpskriftClass opskriftClass);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Opskrifter/{id}", RequestFormat = WebMessageFormat.Json)]
        void DeleteOpskrift(string id);

        //Temperatur service del

        [OperationContract]

        [WebInvoke(Method = "POST",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            RequestFormat = WebMessageFormat.Json,
            UriTemplate = "Temperatur"
        )]
        void PostTemperatur(TemperaturClass temperaturClass);


        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Temperatur", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        TemperaturClass ReadTemperatur();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Temperatur/Average", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        double GetAvgTemperatur();

        // Note service del

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Note", RequestFormat = WebMessageFormat.Json)]
        int PostNote(NoteClass noteClass);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Note/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        NoteClass GetNote(string id);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Note", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IList<NoteClass> GetNoteDB();

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Note/{id}", RequestFormat = WebMessageFormat.Json)]
        int DeleteNote(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Note", RequestFormat = WebMessageFormat.Json)]
        void UpdateNote(NoteClass noteClass);

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
