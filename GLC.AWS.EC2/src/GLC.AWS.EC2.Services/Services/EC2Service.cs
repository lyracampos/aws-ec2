using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.EC2;
using Amazon.EC2.Model;
using GLC.AWS.EC2.Services.Entities;
using GLC.AWS.EC2.Services.Mapping;

namespace GLC.AWS.EC2.Services.Services
{
    public class EC2Service : IEC2Service
    {
        private readonly IAmazonEC2 _amazonEC2;
        public EC2Service(IAmazonEC2 amazonEC2)
        {
            _amazonEC2 = amazonEC2;
        }

        public async Task<IEnumerable<EC2Instance>> Get()
        {
            var result = new List<EC2Instance>();
            var instances = await _amazonEC2.DescribeInstancesAsync(new DescribeInstancesRequest());
            if (instances != null)
            {
                result.AddRange
                (
                    instances.Reservations.SelectMany(p => p.Instances.Select(pe => EC2InstanceMap.Map(pe)))
                );
            }

            return result;
        }

        public async Task<EC2Instance> Get(string instanceId)
        {
            var ids = new List<string> { instanceId };
            var instance = await _amazonEC2.DescribeInstancesAsync(new DescribeInstancesRequest { InstanceIds = ids });
            return EC2InstanceMap.Map(instance.Reservations.FirstOrDefault().Instances.FirstOrDefault());
        }

        public async Task Restart(string instanceId)
        {
            try
            {
                var response = await _amazonEC2.RebootInstancesAsync(new RebootInstancesRequest
                {
                    InstanceIds = new List<string> { instanceId }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public async Task Start(string instanceId)
        {
            var response = await _amazonEC2.StartInstancesAsync(new StartInstancesRequest
            {
                InstanceIds = new List<string> { instanceId }
            });
        }

        public async Task Stop(string instanceId)
        {
            var ids = new List<string> { instanceId };
            await _amazonEC2.StopInstancesAsync(new StopInstancesRequest(ids));
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}