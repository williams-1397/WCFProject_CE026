using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CurrencyConversionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CurrenyConversionService : ICurrencyConversionService
    {
        public double ConvertINRTo(double amount, string currency)
        {
            if (currency == "USD")
            {
                return amount * 0.0138;
            }
            else if (currency == "CAD")
            {
                return amount * 0.0174;
            }
            else if (currency == "GBP")
            {
                return amount * 0.0098;
            }
            else if (currency == "YEN")
            {
                return amount * 1.4523;
            }
            else if (currency == "EURO")
            {
                return amount * 0.0114;
            }
            else if (currency == "PKR")
            {
                return amount * 2.1906;
            }
            else if (currency == "YUAN")
            {
                return amount * 0.0892;
            }
            else if (currency == "NZD")
            {
                return amount * 0.0189;
            }
            else if (currency == "AED")
            {
                return amount * 0.051;
            }
            else if (currency == "RUB")
            {
                return amount * 1.0200;
            }
            return -1;
        }

        public double ConvertUSDTo(double amount, string currency)
        {
            if (currency == "INR")
            {
                return amount * 72.5568;
            }
            else if (currency == "CAD")
            {
                return amount * 1.2610;
            }
            else if (currency == "GBP")
            {
                return amount * 0.7135;
            }
            else if (currency == "YEN")
            {
                return amount * 105.3728;
            }
            else if (currency == "EURO")
            {
                return amount * 0.8251;
            }
            else if (currency == "PKR")
            {
                return amount * 158.9462;
            }
            else if (currency == "YUAN")
            {
                return amount * 6.4716;
            }
            else if (currency == "NZD")
            {
                return amount * 1.3697;
            }
            else if (currency == "AED")
            {
                return amount * 3.67;
            }
            else if (currency == "RUB")
            {
                return amount * 74.0056;
            }
            return -1;
        }
        public double ConvertCADTo(double amount, string currency)
        {
            if (currency == "INR")
            {
                return amount * 57.5373;
            }
            else if (currency == "USD")
            {
                return amount *0.7930;
            }
            else if (currency == "GBP")
            {
                return amount * 0.5658;
            }
            else if (currency == "YEN")
            {
                return amount * 105.3728;
            }
            else if (currency == "EURO")
            {
                return amount * 0.8251;
            }
            else if (currency == "PKR")
            {
                return amount * 158.9462;
            }
            else if (currency == "YUAN")
            {
                return amount * 6.4716;
            }
            else if (currency == "NZD")
            {
                return amount * 1.3697;
            }
            else if (currency == "AED")
            {
                return amount * 2.91;
            }
            else if (currency == "RUB")
            {
                return amount * 58.6862;
            }
            return -1;
        }

        public double ConvertGBPTo(double amount, string currency)
        {
            if (currency == "INR")
            {
                return amount * 101.6854;
            }
            else if (currency == "USD")
            {
                return amount * 1.4015;
            }
            else if (currency == "CAD")
            {
                return amount * 1.7673;
            }
            else if (currency == "YEN")
            {
                return amount * 147.6756;
            }
            else if (currency == "EURO")
            {
                return amount * 1.1564;
            }
            else if (currency == "PKR")
            {
                return amount * 222.76;
            }
            else if (currency == "YUAN")
            {
                return amount * 9.0696;
            }
            else if (currency == "NZD")
            {
                return amount * 1.9195;
            }
            else if (currency == "AED")
            {
                return amount * 5.15;
            }
            else if (currency == "RUB")
            {
                return amount * 103.7158;
            }
            return -1;
        }

        public double ConvertYENTo(double amount, string currency)
        {
            if (currency == "INR")
            {
                return amount * 0.6886;
            }
            else if (currency == "USD")
            {
                return amount * 0.0095;
            }
            else if (currency == "CAD")
            {
                return amount * 0.0120;
            }
            else if (currency == "GBP")
            {
                return amount * 0.0068;
            }
            else if (currency == "EURO")
            {
                return amount * 0.0078;
            }
            else if (currency == "PKR")
            {
                return amount * 1.5084;
            }
            else if (currency == "YUAN")
            {
                return amount * 0.0614;
            }
            else if (currency == "NZD")
            {
                return amount * 0.0130;
            }
            else if (currency == "AED")
            {
                return amount * 0.035;
            }
            else if (currency == "RUB")
            {
                return amount * 0.7023;
            }
            return -1;
        }

        public double ConvertEUROTo(double amount, string currency)
        {
            if(currency == "INR")
            {
                return amount * 87.9345;
            }
            else if (currency == "USD")
            {
                return amount * 1.2119;
            }
            else if (currency == "CAD")
            {
                return amount * 1.5283;
            }
            else if (currency == "GBP")
            {
                return amount * 0.8648;
            }
            else if (currency == "YEN")
            {
                return amount * 127.7054;
            }
            else if (currency == "PKR")
            {
                return amount * 192.6331;
            }
            else if (currency == "YUAN")
            {
                return amount * 7.8431;
            }
            else if (currency == "NZD")
            {
                return amount * 1.6599;
            }
            else if (currency == "AED")
            {
                return amount * 4.45;
            }
            else if (currency == "RUB")
            {
                return amount * 74.04;
            }
            return -1;
        }

        public double ConvertPKRTo(double amount, string currency)
        {
            if (currency == "INR")
            {
                return amount * 0.4565;
            }
            else if (currency == "USD")
            {
                return amount * 0.0063;
            }
            else if (currency == "CAD")
            {
                return amount * 0.0079;
            }
            else if (currency == "GBP")
            {
                return amount * 0.0045;
            }
            else if (currency == "YEN")
            {
                return amount * 0.6629;
            }
            else if (currency == "EURO")
            {
                return amount * 0.0052;
            }
            else if (currency == "YUAN")
            {
                return amount * 0.0407;
            }
            else if (currency == "NZD")
            {
                return amount * 0.0086;
            }
            else if (currency == "AED")
            {
                return amount * 0.023;
            }
            else if (currency == "RUB")
            {
                return amount * 0.0407;
            }
            return -1;
        }

        public double ConvertYUANTo(double amount, string currency)
        {
            if (currency == "INR")
            {
                return amount * 11.211;
            }
            else if (currency == "USD")
            {
                return amount * 0.1545;
            }
            else if (currency == "CAD")
            {
                return amount * 0.1949;
            }
            else if (currency == "GBP")
            {
                return amount * 0.1103;
            }
            else if (currency == "YEN")
            {
                return amount * 16.2825;
            }
            else if (currency == "EURO")
            {
                return amount * 0.1275;
            }
            else if (currency == "PKR")
            {
                return amount * 24.5607;
            }
            else if (currency == "NZD")
            {
                return amount * 0.2116;
            }
            else if (currency == "AED")
            {
                return amount * 0.57;
            }
            else if (currency == "RUB")
            {
                return amount * 11.4355;
            }
            return -1;
        }

        public double ConvertNZDTo(double amount, string currency)
        {
            if (currency == "INR")
            {
                return amount * 52.9742;
            }
            else if (currency == "USD")
            {
                return amount * 0.7301;
            }
            else if (currency == "CAD")
            {
                return amount * 0.9207;
            }
            else if (currency == "GBP")
            {
                return amount * 0.5210;
            }
            else if (currency == "YEN")
            {
                return amount * 76.9334;
            }
            else if (currency == "EURO")
            {
                return amount * 0.6024;
            }
            else if (currency == "PKR")
            {
                return amount * 116.0476;
            }
            else if (currency == "YUAN")
            {
                return amount * 4.7249;
            }
            else if (currency == "AED")
            {
                return amount * 2.68;
            }
            else if (currency == "RUB")
            {
                return amount * 54.0320;
            }
            return -1;
        }

        public double ConvertAEDTo(double amount, string currency)
        {
            if (currency == "INR")
            {
                return amount * 19.7613;
            }
            else if (currency == "USD")
            {
                return amount * 0.2723;
            }
            else if (currency == "CAD")
            {
                return amount * 0.3433;
            }
            else if (currency == "GBP")
            {
                return amount * 0.1943;
            }
            else if (currency == "YEN")
            {
                return amount * 28.6826;
            }
            else if (currency == "EURO")
            {
                return amount * 0.2247;
            }
            else if (currency == "PKR")
            {
                return amount * 43.2696;
            }
            else if (currency == "YUAN")
            {
                return amount * 1.7597;
            }
            else if (currency == "NZD")
            {
                return amount * 0.3730;
            }
            else if (currency == "RUB")
            {
                return amount * 20.16;
            }
            return -1;
        }

        public double ConvertRUBTo(double amount, string currency)
        {
            if (currency == "INR")
            {
                return amount * 0.9803;
            }
            else if (currency == "USD")
            {
                return amount * 0.0135;
            }
            else if (currency == "CAD")
            {
                return amount * 0.0170;
            }
            else if (currency == "GBP")
            {
                return amount * 0.0096;
            }
            else if (currency == "YEN")
            {
                return amount * 1.4228;
            }
            else if (currency == "EURO")
            {
                return amount * 0.0111;
            }
            else if (currency == "PKR")
            {
                return amount * 2.1463;
            }
            else if (currency == "YUAN")
            {
                return amount * 0.0873;
            }
            else if (currency == "NZD")
            {
                return amount * 0.0185;
            }
            else if (currency == "AED")
            {
                return amount * 0.050;
            }
            return -1;
        }
    }
}
