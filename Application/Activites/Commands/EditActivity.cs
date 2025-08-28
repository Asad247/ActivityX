using System;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activites.Commands;

public class EditActivity
{
    public class Command : IRequest
    {
        public required Activity Activity { get; set; }
    }

    public class Handler(AppDbContext database, IMapper mapper) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var activity = await database.Activities.FindAsync([request.Activity.Id], cancellationToken)
          ?? throw new Exception("Activity not found");

            // activity.Title = request.Activity.Title;
            mapper.Map(request.Activity, activity);

            await database.SaveChangesAsync(cancellationToken);
        }
    }
}
