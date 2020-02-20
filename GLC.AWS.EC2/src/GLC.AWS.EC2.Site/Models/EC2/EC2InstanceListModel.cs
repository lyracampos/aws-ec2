using System.Collections.Generic;
using System.Linq;
using GLC.AWS.EC2.Services.Entities;

namespace GLC.AWS.EC2.Site.Models.EC2
{
    public class EC2InstanceListModel
    {
        private readonly IEnumerable<EC2Instance> _instances;
        public EC2InstanceListModel(IEnumerable<EC2Instance> instances)
        {
            _instances = instances;
            Populate();
        }

        public List<EC2InstanceModel> Instances { get; private set; }
        public int Total { get; private set; }

        public bool HasInstance
        {
            get
            {
                return (Instances != null && Instances.Any());
            }
        }   

        private void Populate()
        {
            Instances = (Instances ?? new List<EC2InstanceModel>());
            foreach (var instance in _instances)
            {
                Instances.Add(new EC2InstanceModel(instance));
            }
        }
    }
}