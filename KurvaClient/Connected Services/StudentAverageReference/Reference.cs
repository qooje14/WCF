﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentAverageReference
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentAverageReference.IStdntAvg")]
    public interface IStdntAvg
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStdntAvg/getName", ReplyAction="http://tempuri.org/IStdntAvg/getNameResponse")]
        StudentAverageReference.getNameResponse getName(StudentAverageReference.getNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStdntAvg/getName", ReplyAction="http://tempuri.org/IStdntAvg/getNameResponse")]
        System.Threading.Tasks.Task<StudentAverageReference.getNameResponse> getNameAsync(StudentAverageReference.getNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStdntAvg/getResult", ReplyAction="http://tempuri.org/IStdntAvg/getResultResponse")]
        StudentAverageReference.getResultResponse getResult(StudentAverageReference.getResultRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStdntAvg/getResult", ReplyAction="http://tempuri.org/IStdntAvg/getResultResponse")]
        System.Threading.Tasks.Task<StudentAverageReference.getResultResponse> getResultAsync(StudentAverageReference.getResultRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStdntAvg/getMax", ReplyAction="http://tempuri.org/IStdntAvg/getMaxResponse")]
        StudentAverageReference.getMaxResponse getMax(StudentAverageReference.getMaxRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStdntAvg/getMax", ReplyAction="http://tempuri.org/IStdntAvg/getMaxResponse")]
        System.Threading.Tasks.Task<StudentAverageReference.getMaxResponse> getMaxAsync(StudentAverageReference.getMaxRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStdntAvg/sort", ReplyAction="http://tempuri.org/IStdntAvg/sortResponse")]
        StudentAverageReference.sortResponse sort(StudentAverageReference.sortRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStdntAvg/sort", ReplyAction="http://tempuri.org/IStdntAvg/sortResponse")]
        System.Threading.Tasks.Task<StudentAverageReference.sortResponse> sortAsync(StudentAverageReference.sortRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getName", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string name;
        
        public getNameRequest()
        {
        }
        
        public getNameRequest(string name)
        {
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getNameResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string getNameResult;
        
        public getNameResponse()
        {
        }
        
        public getNameResponse(string getNameResult)
        {
            this.getNameResult = getNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getResult", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getResultRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int sid;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string sName;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int m1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public int m2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public int m3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public int m4;
        
        public getResultRequest()
        {
        }
        
        public getResultRequest(int sid, string sName, int m1, int m2, int m3, int m4)
        {
            this.sid = sid;
            this.sName = sName;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.m4 = m4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getResultResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getResultResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string getResultResult;
        
        public getResultResponse()
        {
        }
        
        public getResultResponse(string getResultResult)
        {
            this.getResultResult = getResultResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getMax", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getMaxRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int[] ar;
        
        public getMaxRequest()
        {
        }
        
        public getMaxRequest(int[] ar)
        {
            this.ar = ar;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getMaxResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class getMaxResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int getMaxResult;
        
        public getMaxResponse()
        {
        }
        
        public getMaxResponse(int getMaxResult)
        {
            this.getMaxResult = getMaxResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sort", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class sortRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int[] ar;
        
        public sortRequest()
        {
        }
        
        public sortRequest(int[] ar)
        {
            this.ar = ar;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sortResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class sortResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int[] sortResult;
        
        public sortResponse()
        {
        }
        
        public sortResponse(int[] sortResult)
        {
            this.sortResult = sortResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IStdntAvgChannel : StudentAverageReference.IStdntAvg, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class StdntAvgClient : System.ServiceModel.ClientBase<StudentAverageReference.IStdntAvg>, StudentAverageReference.IStdntAvg
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public StdntAvgClient() : 
                base(StdntAvgClient.GetDefaultBinding(), StdntAvgClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IStdntAvg.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StdntAvgClient(EndpointConfiguration endpointConfiguration) : 
                base(StdntAvgClient.GetBindingForEndpoint(endpointConfiguration), StdntAvgClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StdntAvgClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(StdntAvgClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StdntAvgClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(StdntAvgClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StdntAvgClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public StudentAverageReference.getNameResponse getName(StudentAverageReference.getNameRequest request)
        {
            return base.Channel.getName(request);
        }
        
        public System.Threading.Tasks.Task<StudentAverageReference.getNameResponse> getNameAsync(StudentAverageReference.getNameRequest request)
        {
            return base.Channel.getNameAsync(request);
        }
        
        public StudentAverageReference.getResultResponse getResult(StudentAverageReference.getResultRequest request)
        {
            return base.Channel.getResult(request);
        }
        
        public System.Threading.Tasks.Task<StudentAverageReference.getResultResponse> getResultAsync(StudentAverageReference.getResultRequest request)
        {
            return base.Channel.getResultAsync(request);
        }
        
        public StudentAverageReference.getMaxResponse getMax(StudentAverageReference.getMaxRequest request)
        {
            return base.Channel.getMax(request);
        }
        
        public System.Threading.Tasks.Task<StudentAverageReference.getMaxResponse> getMaxAsync(StudentAverageReference.getMaxRequest request)
        {
            return base.Channel.getMaxAsync(request);
        }
        
        public StudentAverageReference.sortResponse sort(StudentAverageReference.sortRequest request)
        {
            return base.Channel.sort(request);
        }
        
        public System.Threading.Tasks.Task<StudentAverageReference.sortResponse> sortAsync(StudentAverageReference.sortRequest request)
        {
            return base.Channel.sortAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IStdntAvg))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IStdntAvg))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/studentAverage/StudentInfo/");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return StdntAvgClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IStdntAvg);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return StdntAvgClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IStdntAvg);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IStdntAvg,
        }
    }
}
