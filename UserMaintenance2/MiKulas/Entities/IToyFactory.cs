using MiKulas.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiKulas.Entities
{
    public class IToyFactory: Abstractions.IToyFactory
    {
            public Abstractions.Toy CreateNew()
            {
                return new Toy();
            }
        
    }
}
