using {{cookiecutter.project_name}}.Application.Infrastructure.Handlers;
using {{cookiecutter.project_name}}.Shared.Results;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.entity_name}}.{{cookiecutter.project_slug}};

public sealed class {{cookiecutter.project_slug}}QueryHandler()
    : IQueryHandler<{{cookiecutter.project_slug}}Query, {{cookiecutter.project_slug}}Response>
{
    public async Task<Result<{{cookiecutter.project_slug}}Response>> Handle({{cookiecutter.project_slug}}Query? query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
