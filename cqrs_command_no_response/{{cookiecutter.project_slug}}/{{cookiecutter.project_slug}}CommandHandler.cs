using {{cookiecutter.project_name}}.Application.Infrastructure.Handlers;
using {{cookiecutter.project_name}}.Shared.Results;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.entity_name}}.{{cookiecutter.project_slug}};

public sealed class {{cookiecutter.project_slug}}CommandHandler()
    : ICommandHandler<{{cookiecutter.project_slug}}Command>
{
    public async Task<Result> Handle({{cookiecutter.project_slug}}Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
