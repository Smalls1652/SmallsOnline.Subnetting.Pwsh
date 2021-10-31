using System;
using System.Management.Automation;
using System.Net;

namespace SmallsOnline.Subnetting.Pwsh.Cmdlets
{
    using Lib.Models;

    [Cmdlet(VerbsCommon.New, "IPv4Subnet")]
    public class NewIPv4Subnet : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true, ParameterSetName = "IPAddressAndCIDRNotation")]
        [Parameter(Position = 0, Mandatory = true, ParameterSetName = "IPAddressAndSubnetMask")]
        [ValidateNotNullOrEmpty()]
        public IPAddress IPAddress
        {
            get => ipAddress;
            set => ipAddress = value;
        }

        [Parameter(Position = 1, ParameterSetName = "IPAddressAndCIDRNotation")]
        [ValidateNotNullOrEmpty()]
        public double CidrNotation
        {
            get => cidrNotation;
            set => cidrNotation = value;
        }

        [Parameter(Position = 1, Mandatory = true, ParameterSetName = "IPAddressAndSubnetMask")]
        [ValidateNotNullOrEmpty()]
        public IPAddress SubnetMask
        {
            get => subnetMask;
            set => subnetMask = value;
        }

        [Parameter(Position = 0, Mandatory = true, ParameterSetName = "SubnetString")]
        [ValidateNotNullOrEmpty()]
        public string NetworkString
        {
            get => networkString;
            set => networkString = value;
        }

        private IPAddress ipAddress;
        private double cidrNotation = 24;
        private IPAddress subnetMask = new(new byte[] { 255, 255, 255, 0 });
        private string networkString;

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            IPv4Subnet subnetItem = ParameterSetName switch
            {
                "SubnetString" => new(networkString),
                "IPAddressAndSubnetMask" => new(ipAddress, subnetMask),
                _ => new(ipAddress, cidrNotation)
            };

            WriteObject(subnetItem);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }
    }
}