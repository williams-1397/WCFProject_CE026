using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencyConversionService
{ // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICurrencyConversionService
    {
        [OperationContract]
        double ConvertINRTo(double amount, string currency);
        [OperationContract]
        double ConvertUSDTo(double amount, string currency);
        [OperationContract]
        double ConvertCADTo(double amount, string currency);
        [OperationContract]
        double ConvertGBPTo(double amount, string currency);
        [OperationContract]
        double ConvertYENTo(double amount, string currency);
        [OperationContract]
        double ConvertEUROTo(double amount, string currency);
        [OperationContract]
        double ConvertPKRTo(double amount, string currency);
        [OperationContract]
        double ConvertYUANTo(double amount, string currency);
        [OperationContract]
        double ConvertNZDTo(double amount, string currency);
        [OperationContract]
        double ConvertAEDTo(double amount, string currency);
        [OperationContract]
        double ConvertRUBTo(double amount, string currency);
    }
}