using FluentValidation;

namespace {{cookiecutter.project_name}}.Application.Features.{{cookiecutter.project_slug}}.Create{{cookiecutter.project_slug}};

public sealed class Create{{cookiecutter.project_slug}}CommandValidator : AbstractValidator<Create{{cookiecutter.project_slug}}Command>
{
    public Create{{cookiecutter.project_slug}}CommandValidator()
    {
    }
}
