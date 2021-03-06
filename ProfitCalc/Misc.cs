﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProfitCalc
{
    public class Profile
    {
        public double FiatPerKwh { get; set; }

        public int FiatOfChoice { get; set; }

        public int Multiplier { get; set; }

        public BindingList<CustomAlgo> CustomAlgoList { get; set; }

        public Profile()
        {
            CustomAlgoList = new BindingList<CustomAlgo>();
        }
    }

    internal class ApiSettingsJson
    {
        public Dictionary<string, string> ApiSettings { get; set; }

        public Dictionary<string, bool> CheckedApis { get; set; }

        public Dictionary<string, bool> CheckedMisc { get; set; }

        public AutoCompleteStringCollection AllAlgoList { get; set; }
    }

    public class CustomCoin
    {
        public bool Use { get; set; }
        public string Tag { get; set; }
        public string FullName { get; set; }

        public string Algo { get; set; }
        public double Difficulty { get; set; }
        public double BlockReward { get; set; }
        public double BlockTime { get; set; }
        public double NetHashRate { get; set; }
        public double CustomPrice { get; set; }

        public uint Height { get; set; }
        public bool UseRpc { get; set; }
        public bool GetDiff { get; set; }
        public bool GetReward { get; set; }
        public bool GetNetHash { get; set; }
        public string RpcIp { get; set; }
        public string RpcPort { get; set; }
        public string RpcUser { get; set; }
        public string RpcPass { get; set; }
    }

    public class CustomAlgo
    {
        public bool Use { get; set; }
        public string Name { get; set; }
        public string SynonymsCsv { get; set; }

        public string Style { get; set; }
        public double HashRate { get; set; }
        public double Wattage { get; set; }
        // Target = log2 diff 1 target
        public double Target { get; set; }
    }

    internal class OldHashrates
    {
        public Dictionary<string, double> HashRateList { get; set; }

        public Dictionary<string, double> WattageList { get; set; }

        public Dictionary<string, bool> CheckedHashRates { get; set; }
    }
}