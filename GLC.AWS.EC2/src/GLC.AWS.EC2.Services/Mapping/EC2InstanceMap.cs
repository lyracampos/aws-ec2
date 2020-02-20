using Amazon.EC2.Model;
using GLC.AWS.EC2.Services.Entities;

namespace GLC.AWS.EC2.Services.Mapping
{
    public static class EC2InstanceMap
    {
        public static EC2Instance Map(Instance instance)
        {
            var name = instance.Tags[0].Value;
            return new EC2Instance(
                instance.InstanceId,
                name,
                instance.State.Name,
                instance.InstanceType,
                instance.PrivateDnsName,
                instance.PrivateIpAddress,
                instance.PublicDnsName,
                instance.PublicIpAddress,
                instance.Placement.AvailabilityZone
            );
        }
    }
}