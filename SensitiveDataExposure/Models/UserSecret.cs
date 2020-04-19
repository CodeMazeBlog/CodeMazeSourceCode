using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OWASPTop10.Models
{
    public class UserSecret
    {
        public string SecretValue { get; set; }

        public string Salt { get; set; }

        public string HashedKey { get; set; }
    }
}
