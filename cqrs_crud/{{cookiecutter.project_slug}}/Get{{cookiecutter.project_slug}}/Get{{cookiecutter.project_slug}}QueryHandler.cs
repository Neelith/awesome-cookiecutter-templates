using {{cookiecutter.project_name}}.Application.Infrastructure.Handlers;
using {{cookiecutter.project_name}}.Shared.Results;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.project_slug}}.Get{{cookiecutter.project_slug}};

public sealed class Get{{cookiecutter.project_slug}}QueryHandler()
    : IQueryHandler<Get{{cookiecutter.project_slug}}Query, Get{{cookiecutter.project_slug}}Response>
{
    public async Task<Result<Get{{cookiecutter.project_slug}}Response>> Handle(Get{{cookiecutter.project_slug}}Query? query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
