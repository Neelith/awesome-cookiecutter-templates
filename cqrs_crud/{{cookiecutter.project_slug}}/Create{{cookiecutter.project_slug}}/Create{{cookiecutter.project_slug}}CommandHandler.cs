using {{cookiecutter.project_name}}.Application.Infrastructure.Handlers;
using {{cookiecutter.project_name}}.Shared.Results;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.project_slug}}.Create{{cookiecutter.project_slug}};

public sealed class Create{{cookiecutter.project_slug}}CommandHandler()
    : ICommandHandler<Create{{cookiecutter.project_slug}}Command, Create{{cookiecutter.project_slug}}Response>
{
    public async Task<Result<Create{{cookiecutter.project_slug}}Response>> Handle(Create{{cookiecutter.project_slug}}Command command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
