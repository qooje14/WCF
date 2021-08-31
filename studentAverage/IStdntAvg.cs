using System;
using System.ServiceModel;

namespace studentAverage
{
    [ServiceContract]
    interface IStdntAvg
    {
        [OperationContract]
        string getName(string name);
        [OperationContract]
        string getResult(int sid, string sName,int m1, int m2, int m3, int m4);
        [OperationContract]
        string getMax();
       
        
    }
}
