using FluentValidation;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.project_slug}}.Update{{cookiecutter.project_slug}};

public sealed class Update{{cookiecutter.project_slug}}CommandValidator : AbstractValidator<Update{{cookiecutter.project_slug}}Command>
{
    public Update{{cookiecutter.project_slug}}CommandValidator()
    {
    }
}
