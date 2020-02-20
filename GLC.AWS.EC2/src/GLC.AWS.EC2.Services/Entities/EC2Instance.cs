namespace GLC.AWS.EC2.Services.Entities
{
    public class EC2Instance
    {
        public EC2Instance()
        {
            
        }
        public EC2Instance(
            string instanceId, 
            string tagName, 
            string statusDescription, 
            string instanceType, 
            string privateDNS, 
            string privateIp, 
            string publicDNSIpv4, 
            string iPv4PublicIp,
            string availabilityZone)
        {
            this.InstanceId = instanceId;
            this.TagName = tagName;
            this.StatusDescription = statusDescription;
            this.InstanceType = instanceType;
            this.PrivateDNS = privateDNS;
            this.PrivateIp = privateIp;
            this.PublicDNSIpv4 = publicDNSIpv4;
            this.IPv4PublicIp = iPv4PublicIp;
            this.AvailabilityZone = availabilityZone;

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
    }
}