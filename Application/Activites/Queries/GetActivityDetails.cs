using System;
using Domain;
using MediatR;

namespace Application.Activites.Queries;

public class GetActivityDetails
{
    public class Query : IRequest<Activity>
    {
        public string Id { get; set; } = string.Empty;
    }

    public class Handler : IRequestHandler<Query, Activity>
    {
        private readonly Persistence.AppDbContext _context;

        public Handler(Persistence.AppDbContext context)
        {
            _context = context;
        }

        public async Task<Activity> Handle(Query request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(new object[] { request.Id }, cancellationToken);
            if (activity == null)
            {
                throw new KeyNotFoundException("Activity not found");
            }
            return activity;
        }
    }
}
