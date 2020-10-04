using MediatR;
using Microsoft.EntityFrameworkCore;
using NetCore_MediatR_Example.Models;
using NetCore_MediatR_Example.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NetCore_MediatR_Example.Application.TestObjects.Queries
{
    public class GetTestObjectHandler : IRequestHandler<GetTestObjectQuery, TestObject>
    {

        //Burası business ı döndüğü yer.
        private AppMemoryContext _db;
        public GetTestObjectHandler(AppMemoryContext db)
        {
            _db = db;
        }
        public Task<TestObject> Handle(GetTestObjectQuery request, CancellationToken cancellationToken)
        {
            return this._db.TestObjects.SingleOrDefaultAsync(r=>r.Id==request.Id);
        }
    }
}
