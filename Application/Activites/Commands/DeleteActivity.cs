using System;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activites.Commands;

public class DeleteActivity
{
    public class Command : IRequest
    {
        public required string Id { get; set; }

    }


    public class Handler(AppDbContext database) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var activty = await database.Activities.FindAsync([request.Id], cancellationToken)
          ?? throw new Exception("Activity not found");


            database.Activities.Remove(activty);
            await database.SaveChangesAsync(cancellationToken);
        }
    }
}
