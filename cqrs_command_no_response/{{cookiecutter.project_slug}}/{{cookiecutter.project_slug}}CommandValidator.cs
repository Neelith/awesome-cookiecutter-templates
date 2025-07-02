using FluentValidation;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.entity_name}}.{{cookiecutter.project_slug}};

public sealed class {{cookiecutter.project_slug}}CommandValidator : AbstractValidator<{{cookiecutter.project_slug}}Command>
{
    public {{cookiecutter.project_slug}}CommandValidator()
    {
    }
}
