using FluentValidation;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.entity_name}}.{{cookiecutter.project_slug}};

public sealed class {{cookiecutter.project_slug}}QueryValidator : AbstractValidator<{{cookiecutter.project_slug}}Query>
{
    public {{cookiecutter.project_slug}}QueryValidator()
    {
    }
}
