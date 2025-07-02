using FluentValidation;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.project_slug}}.Get{{cookiecutter.project_slug}};

public sealed class Get{{cookiecutter.project_slug}}QueryValidator : AbstractValidator<Get{{cookiecutter.project_slug}}Query>
{
    public Get{{cookiecutter.project_slug}}QueryValidator()
    {
    }
}
