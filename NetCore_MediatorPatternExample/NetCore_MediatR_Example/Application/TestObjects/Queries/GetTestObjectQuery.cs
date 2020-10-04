using MediatR;
using NetCore_MediatR_Example.Models;
using NetCore_MediatR_Example.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore_MediatR_Example.Application.TestObjects.Queries
{
    public class GetTestObjectQuery:IRequest<TestObject>
    {
        public int Id { get; set; }
    }
}
