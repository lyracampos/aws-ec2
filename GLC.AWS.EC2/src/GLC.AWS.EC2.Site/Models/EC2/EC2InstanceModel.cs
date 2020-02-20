using GLC.AWS.EC2.Services.Entities;

namespace GLC.AWS.EC2.Site.Models.EC2
{
    public class EC2InstanceModel
    {
        public EC2InstanceModel(EC2Instance instance)
        {
            InstanceId = instance.InstanceId;
            TagName = instance.TagName;
            StatusDescription = instance.StatusDescription;
            InstanceType = instance.InstanceType;
            PrivateDNS = instance.PrivateDNS;
            PrivateIp = instance.PrivateIp;
            PublicDNSIpv4 = instance.PublicDNSIpv4;
            IPv4PublicIp = instance.IPv4PublicIp;
            AvailabilityZone = instance.AvailabilityZone;
        }
        public string InstanceId { get; private set; }
        public string TagName { get; private set; }
        public string StatusDescription { get; private set; }
        public string InstanceType { get; private set; }
        public string PrivateDNS { get; private set; }
        public string PrivateIp { get; private set; }
        public string PublicDNSIpv4 { get; private set; }
        public string IPv4PublicIp { get; private set; }
        public string AvailabilityZone { get; private set; }

        public string StatusCss()
        {
            if (StatusDescription == "stopped")
                return "background-color: #dc3545; color: #fbfafa; padding: 4px 4px 4px 4px";

            if (StatusDescription == "stopping")
                return "background-color: #ffc107; color: #fbfafa; padding: 4px 4px 4px 4px";

            if (StatusDescription == "running")
                return "background-color: #28a745; color: #fbfafa; padding: 4px 4px 4px 4px";

            if (StatusDescription == "pending")
                return "background-color: #ffc107; color: #fbfafa; padding: 4px 4px 4px 4px";
            return "";
        }
    }
}
