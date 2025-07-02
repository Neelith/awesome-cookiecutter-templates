using {{cookiecutter.project_name}}.Application.Infrastructure.Handlers;
using {{cookiecutter.project_name}}.Shared.Results;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.project_slug}}.Update{{cookiecutter.project_slug}};

public sealed class Update{{cookiecutter.project_slug}}CommandHandler()
    : ICommandHandler<Update{{cookiecutter.project_slug}}Command>
{
    public async Task<Result> Handle(Update{{cookiecutter.project_slug}}Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
