using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GLC.AWS.EC2.Services.Entities;

namespace GLC.AWS.EC2.Services.Services
{
    public interface IEC2Service : IDisposable
    {
        Task<IEnumerable<EC2Instance>> Get();
        Task<EC2Instance> Get(string instanceId);
        Task Start(string instanceId);
        Task Stop(string instanceId);
        Task Restart(string instanceId);        
    }
}
