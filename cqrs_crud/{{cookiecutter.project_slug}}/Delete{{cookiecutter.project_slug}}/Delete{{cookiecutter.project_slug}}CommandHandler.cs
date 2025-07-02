using {{cookiecutter.project_name}}.Application.Infrastructure.Handlers;
using {{cookiecutter.project_name}}.Shared.Results;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.project_slug}}.Delete{{cookiecutter.project_slug}};

public sealed class Delete{{cookiecutter.project_slug}}CommandHandler()
    : ICommandHandler<Delete{{cookiecutter.project_slug}}Command>
{
    public async Task<Result> Handle(Delete{{cookiecutter.project_slug}}Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
