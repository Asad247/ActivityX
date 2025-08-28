using System;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Activites.Queries;

public class GetActivityList
{
    public class Query : IRequest<List<Activity>>
    {
    }

    public class Handler : IRequestHandler<Query, List<Activity>>
    {
        private readonly Persistence.AppDbContext _context;

        public Handler(Persistence.AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _context.Activities.ToListAsync(cancellationToken);
        }


    }
}
